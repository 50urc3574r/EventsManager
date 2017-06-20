using FastReport;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace EventManager
{
    public partial class BadgesList : Form
    {
        public Main.Members[] members { get; internal set; }

        public BadgesList()
        {
            InitializeComponent();
        }

        private void BadgesList_Load(object sender, EventArgs e)
        {
            badgesTableAdapter.Fill(databaseDataSet.Badges);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (EditBadge editBadge = new EditBadge())
            {
                editBadge.Text = "Новый бэдж";
                if (editBadge.ShowDialog() == DialogResult.OK)
                {
                    // save
                    DataRow row = databaseDataSet.Tables["Badges"].NewRow();
                    SaveBadge(row, editBadge.BadgeName, editBadge.BadgeColor, editBadge.TopImage);
                    badgesTableAdapter.Insert(row["GroupName"] as string,
                        row["TopPicture"] as byte[],
                        row["LeftPicture"] as byte[],
                        (int)row["Color"]);
                    databaseDataSet.Badges.Rows.Add(row);
                    databaseDataSet.AcceptChanges();
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            using (EditBadge editBadge = new EditBadge())
            {
                // load
                int index = (int)dataGridView1.CurrentRow.Cells["Number"].Value;
                DataRow row = databaseDataSet.Badges.Select("Number =" + index.ToString())[0];
                editBadge.BadgeName = row["GroupName"].ToString();
                int badgeColor = (int)row["Color"];
                byte[] topPictureBlob = row["TopPicture"] as byte[];
                byte[] leftPictureBlob = row["LeftPicture"] as byte[];
                editBadge.BadgeColor = Color.FromArgb((255 << 24) | badgeColor);
                if (topPictureBlob != null)
                {
                    MemoryStream imageStream = new MemoryStream();
                    imageStream.Write(topPictureBlob, 0, topPictureBlob.Length);
                    imageStream.Position = 0;
                    editBadge.TopImage = new Bitmap(imageStream);
                }
                if (editBadge.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    // save
                    SaveBadge(row, editBadge.BadgeName, editBadge.BadgeColor, editBadge.TopImage);
                    badgesTableAdapter.Update(row);
                    databaseDataSet.AcceptChanges();
                }
            }
        }

        private void SaveBadge(DataRow row, string BadgeName, Color BadgeColor, Image TopImage)
        {
            row["GroupName"] = BadgeName;
            row["Color"] = BadgeColor.ToArgb();
            MemoryStream imageStream;
            if (TopImage != null)
            {
                imageStream = new MemoryStream();
                TopImage.Save(imageStream, ImageFormat.Png);
                row["TopPicture"] = imageStream.GetBuffer();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "Удалить запись?",
                "Запрос на удаление",
                MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                int index = (int)dataGridView1.CurrentRow.Cells["Number"].Value;
                DataRow row = databaseDataSet.Badges.Select("Number =" + index.ToString())[0];
                badgesTableAdapter.Delete(index, row["GroupName"] as string, row["Color"] as int?);
                row.Delete();
                databaseDataSet.Badges.AcceptChanges();
                databaseDataSet.AcceptChanges();
            }
        }

        private void btnDesigner_Click(object sender, EventArgs e)
        {            
            using (Report report = new Report())
            {
                string reportPath = Path.GetDirectoryName(Application.ExecutablePath);
                string reportFileName = Path.Combine(reportPath, "badge.frx");
                if (!File.Exists(reportFileName))
                    if (File.Exists(Path.Combine(reportPath, "badge.frx")))
                    {
                        reportFileName = Path.Combine(reportPath, "badge.frx");
                    }

                if (File.Exists(reportFileName))
                    report.Load(reportFileName);
               
                if (members != null) { 
                //report.RegisterData(members, "members");
                }
                report.Design();
            }

        }
    }
}
