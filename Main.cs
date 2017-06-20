using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Windows.Forms;
using System.Data;
using System.Text;
using System.Linq;
using System.IO;
using FastReport;
using System.Xml.Serialization;
using System.Drawing;

namespace EventManager
{
    public partial class Main : Form
    {
        DataTable dt = new DataTable();
        private string addM = "http://eventsmanager.ru/api/events/members?id=" + Program.event_id + "&auth_key=" + Program.auth_key;        
        DataGridViewCheckBoxColumn c = new DataGridViewCheckBoxColumn();
        public Members[] members { get; private set; }
        public Main()
        {
            InitializeComponent();
        }
        public class Members
        {
            public string id { get; set; }
            public string firstname_rus { get; set; }
            public string firstname_eng { get; set; }
            public string lastname_rus { get; set; }
            public string lastname_eng { get; set; }
            public string country { get; set; }
            public string city { get; set; }
            public string company { get; set; }
            public string mail { get; set; }
            public string Badges { get; set; }
            public string username { get; set; }
            public string password { get; set; }
        }        

        public void Main_Load(object sender, EventArgs e)
        {
            add();
            c.Name = "Select";
            c.HeaderText = "Выбор";
            c.ReadOnly = false;
            c.Frozen = true;
            c.DisplayIndex = 0;
            dataGridView1.Columns.Add(c);
            dataGridView1.CurrentRow.Selected = false;
            firstname_rus.HeaderText = "Имя";
            firstname_eng.HeaderText = "Имя(анг)";
            lastname_rus.HeaderText = "Фамилия";
            lastname_eng.HeaderText = "Фамилия(анг)";
            country.HeaderText = "Страна";
            city.HeaderText = "Город";
            company.HeaderText = "Компания";
            mail.HeaderText = "Почта";
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9F, FontStyle.Bold);

            dtadd();            
        }

        private void dtadd()
        {
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                dt.Columns.Add(col.HeaderText);
            }

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DataRow dRow = dt.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dRow[cell.ColumnIndex] = cell.Value;
                }
                dt.Rows.Add(dRow);
            }
        }

        public void add()
        {
            
            dataGridView1.Rows.Clear();
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(addM);
            client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync("").Result;
            if (response.IsSuccessStatusCode)
            {
                /*if (response.Content.Headers.ContentLength <= 2)
                {
                    MessageBox.Show("нет участников");
                    return;
                }*/
                var dataObjects = response.Content.ReadAsAsync<IEnumerable<Members>>().Result;
                foreach (var a in dataObjects)
                {
                    membersBindingSource.Add(a);
                }
                members = dataObjects.ToArray();
            }
        }

        public void xmlupd()
        {
            List<Members> membersList = new List<Members>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                Members member = new Members();
                member.id = row.Cells["id"].Value + string.Empty;
                member.firstname_rus = row.Cells["firstname_rus"].Value + string.Empty;
                member.firstname_eng = row.Cells["firstname_eng"].Value + string.Empty;
                member.lastname_rus = row.Cells["lastname_rus"].Value + string.Empty;
                member.lastname_eng = row.Cells["lastname_eng"].Value + string.Empty;
                member.country = row.Cells["country"].Value + string.Empty;
                member.city = row.Cells["city"].Value + string.Empty;
                member.company = row.Cells["company"].Value + string.Empty;
                member.mail = row.Cells["mail"].Value + string.Empty;
                membersList.Add(member);
            }
            XmlSerializer formatter = new XmlSerializer(typeof(Members[]));
            using (FileStream fs = new FileStream("members.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, membersList.ToArray());
            }
        }        

        private void add_btn_Click(object sender, EventArgs e)
        {
            using (Addmember Addmember = new Addmember())
            {
                Addmember.ShowDialog();
            }
            add();
        }

        private async void del_btn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены?", "Удаление!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells["Select"];
                if (chk.Value == chk.FalseValue || chk.Value == null)
                {
                    chk.Value = chk.TrueValue;
                }
                else
                {
                    int RowIndex = dataGridView1.CurrentCell.RowIndex;
                    string del = "http://eventsmanager.ru/";
                    HttpClient client = new HttpClient();
                    client.BaseAddress = new Uri(del);                    
                    client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response = client.DeleteAsync("apiusers/" + row.Cells["id"].Value).Result;  // Blocking call!
                    var result = await client.DeleteAsync("/apiusers");
                    string resultContent = await result.Content.ReadAsStringAsync();
                    if (response.IsSuccessStatusCode)
                    {
                        var dataObjects = response.Content.ReadAsAsync<IEnumerable<Members>>().Result;
                    }
                    chk.Value = chk.FalseValue;                    
                }
                add();
                File.Delete("members.xml");
                xmlupd();
            }
            
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {            
                using (Editmember editMember = new Editmember())
                {
                    string id = dataGridView1.SelectedRows[0].Cells["id"].Value + string.Empty;
                    string firstname_rus = dataGridView1.SelectedRows[0].Cells["firstname_rus"].Value + string.Empty;
                    string firstname_eng = dataGridView1.SelectedRows[0].Cells["firstname_eng"].Value + string.Empty;
                    string lastname_rus = dataGridView1.SelectedRows[0].Cells["lastname_rus"].Value + string.Empty;
                    string lastname_eng = dataGridView1.SelectedRows[0].Cells["lastname_eng"].Value + string.Empty;
                    string country = dataGridView1.SelectedRows[0].Cells["country"].Value + string.Empty;
                    string city = dataGridView1.SelectedRows[0].Cells["city"].Value + string.Empty;
                    string company = dataGridView1.SelectedRows[0].Cells["company"].Value + string.Empty;
                    string mail = dataGridView1.SelectedRows[0].Cells["mail"].Value + string.Empty;
                    string username = dataGridView1.SelectedRows[0].Cells["username"].Value + string.Empty;
                    string password = dataGridView1.SelectedRows[0].Cells["password"].Value + string.Empty;
                    //string Badges = dataGridView1.SelectedRows[0].Cells["badges"].Value + string.Empty;
                    editMember.firstname_rus = firstname_rus;
                    editMember.firstname_eng = firstname_eng;
                    editMember.lastname_rus = lastname_rus;
                    editMember.lastname_eng = lastname_eng;
                    editMember.country = country;
                    editMember.city = city;
                    editMember.company = company;
                    editMember.mail = mail;
                    editMember.id = id;
                    editMember.username = username;
                    //editMember.password = password;
                    //editMember.badges = Badges;
                    editMember.ShowDialog();
                }
            }
        }

        private void csv_btn_Click(object sender, EventArgs e)
        {
            dt.Reset();
            dtadd();
            StringBuilder sb = new StringBuilder();
            var columnNames = dt.Columns.Cast<DataColumn>().Select(column => column.ColumnName).ToArray();
            sb.AppendLine(string.Join(";", columnNames));
            foreach (DataRow row in dt.Rows)
            {
                var fields = row.ItemArray.Select(field => field.ToString()).ToArray();
                sb.AppendLine(string.Join(";", fields));
            }
            SaveFileDialog saveCSV = new SaveFileDialog();
            saveCSV.DefaultExt = "csv";
            saveCSV.Filter = "CSV (*.csv)|*.csv|All files (*.*)|*.*";
            if (saveCSV.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Сохранено  " + saveCSV.FileName);
                File.WriteAllText(saveCSV.FileName, sb.ToString(), Encoding.UTF8);
            }
        }

        private void reload_Click(object sender, EventArgs e)
        {
            add();
        }

        private async void add_member_btn_Click(object sender, EventArgs e)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://eventsmanager.ru");
                var content = new FormUrlEncodedContent(new[]
                {
                    new KeyValuePair<string, string>("username", textBox9.Text),
                    new KeyValuePair<string, string>("password", textBox10.Text),                   
                    new KeyValuePair<string, string>("firstname_rus", textBox1.Text),
                    new KeyValuePair<string, string>("firstname_eng", textBox2.Text),
                    new KeyValuePair<string, string>("lastname_rus", textBox3.Text),
                    new KeyValuePair<string, string>("lastname_eng", textBox4.Text),
                    new KeyValuePair<string, string>("company", textBox5.Text),
                    new KeyValuePair<string, string>("country", textBox6.Text),
                    new KeyValuePair<string, string>("city", textBox7.Text),
                    new KeyValuePair<string, string>("mail", textBox8.Text)
                });
                var result = await client.PostAsync("/apievents/members?id=" + Program.event_id + " & auth_key = " + Program.auth_key, content);
                string resultContent = await result.Content.ReadAsStringAsync();                
                add();
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
                textBox8.Clear();
                textBox9.Clear();
                textBox10.Clear();
            }
        }

        private void searchtextBox_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            String searchValue = searchtextBox.Text;
            int rowIndex = -1;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["lastname_eng"].Value != null)
                {
                    if (row.Cells["lastname_eng"].Value.ToString().ToLower().Equals(searchValue.ToLower()))
                    {
                        rowIndex = row.Index;
                        dataGridView1.Rows[rowIndex].Selected = true;
                        dataGridView1.FirstDisplayedScrollingRowIndex = rowIndex;                        
                        break;
                    }
                }
            }
        }

        private void Badges_Click(object sender, EventArgs e)
        {
            BadgesMS.Show(PointToScreen(Badges.Location));
        }

        private void Stikers_Click(object sender, EventArgs e)
        {
            StickersMS.Show(PointToScreen(Stikers.Location));
        }

        private void StickersDesing_Click(object sender, EventArgs e)
        {
            using (Report report = new Report())
            {
                string reportPath = Path.GetDirectoryName(Application.ExecutablePath);
                string reportFileName = Path.Combine(reportPath, "stickers.frx");
                if (!File.Exists(reportFileName))
                    if (File.Exists(Path.Combine(reportPath, "stickers.frx")))
                    {
                        reportFileName = Path.Combine(reportPath, "stickers.frx");
                    }

                if (File.Exists(reportFileName))
                    report.Load(reportFileName);

                if (members != null)
                {
                    report.RegisterData(members, "members");
                }
                report.Design();
                report.RegisterData(members, "members");
            }
        }

        private void Events_Click(object sender, EventArgs e)
        {
            using (Events events = new Events())
            {
                events.ShowDialog();
            }
        }
        
        private void Notes_Click(object sender, EventArgs e)
        {
            Notes notes = new Notes();
            {
                notes.ShowDialog();
            }
        }

        private void Russian_Click(object sender, EventArgs e)
        {
            firstname_rus.HeaderText = "Имя";
            firstname_eng.HeaderText = "Имя(анг)";
            lastname_rus.HeaderText = "Фамилия";
            lastname_eng.HeaderText = "Фамилия(анг)";
            country.HeaderText = "Страна";
            city.HeaderText = "Город";
            company.HeaderText = "Компания";
            mail.HeaderText = "Почта";
            c.HeaderText = "Выбор";
            reload.Text = "Обновить таблицу";
            add_btn.Text = "Добавить";
            edit_btn.Text = "Изменить";
            del_btn.Text = "Удалить";
            csv_btn.Text = "Экспорт";
            groupBox1.Text = "Добавление";
            label1.Text = "Имя";
            label2.Text = "Имя(анг)";
            label3.Text = "Фамилия";
            label4.Text = "Фамилия(анг)";
            label5.Text = "Страна";
            label6.Text = "Город";
            label7.Text = "Компания";
            label8.Text = "Почта";
            add_member_btn.Text = "Добавить";
        }
        private void English_Click(object sender, EventArgs e)
        {
            firstname_rus.HeaderText = "Name";
            firstname_eng.HeaderText = "Name2";
            lastname_rus.HeaderText = "Surname";
            lastname_eng.HeaderText = "Surname2";
            country.HeaderText = "Country";
            city.HeaderText = "City";
            company.HeaderText = "Company";
            mail.HeaderText = "eMail";
            c.HeaderText = "Select";
            reload.Text = "Reload table";
            add_btn.Text = "Add";
            edit_btn.Text = "Edit";
            del_btn.Text = "Delete";
            csv_btn.Text = "Export";
            groupBox1.Text = "Additions";
            label1.Text = "Name";
            label2.Text = "Name2";
            label3.Text = "SecondName";
            label4.Text = "SecondName2";
            label5.Text = "Country";
            label6.Text = "City";
            label7.Text = "Company";
            label8.Text = "Email";
            add_member_btn.Text = "Accept";
        }

        private void StickersPrintAll_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count != 0)
            {
                xmlupd();
                using (Report report = new Report())
                {
                    string reportPath = Path.GetDirectoryName(Application.ExecutablePath);
                    string reportFileName = Path.Combine(reportPath, "stickers.frx");
                    if (!File.Exists(reportFileName))
                        if (File.Exists(Path.Combine(reportPath, "stickers.frx")))
                        {
                            reportFileName = Path.Combine(reportPath, "stickers.frx");
                        }
                    if (File.Exists(reportFileName))
                        report.Load(reportFileName);
                    
                    report.Show();
                    report.RegisterData(members, "members.xml");
                }
            }
            else
            {
                MessageBox.Show("Создайте участника");
            }
        }

        private void StickersPrint_Click(object sender, EventArgs e)
        {
            File.Delete("members.xml");
            List<Members> membersList = new List<Members>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                Members member = new Members();
                member.id = row.Cells["id"].Value + string.Empty;
                member.firstname_rus = row.Cells["firstname_rus"].Value + string.Empty;
                member.firstname_eng = row.Cells["firstname_eng"].Value + string.Empty;
                member.lastname_rus = row.Cells["lastname_rus"].Value + string.Empty;
                member.lastname_eng = row.Cells["lastname_eng"].Value + string.Empty;
                member.country = row.Cells["country"].Value + string.Empty;
                member.city = row.Cells["city"].Value + string.Empty;
                member.company = row.Cells["company"].Value + string.Empty;
                member.mail = row.Cells["mail"].Value + string.Empty;
                {
                    DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells["Select"];
                    if (chk.Value == chk.FalseValue || chk.Value == null)
                    {
                        chk.Value = chk.TrueValue;
                    }
                    else
                    {
                        membersList.Add(member);
                        chk.Value = chk.FalseValue;
                    }
                }
            }
            if (membersList.Count == 0)
            { MessageBox.Show("Сначала выберите"); return; }
            XmlSerializer formatter = new XmlSerializer(typeof(Members[]));
            using (FileStream fs = new FileStream("members.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, membersList.ToArray());
            }
            if (dataGridView1.Rows.Count != 0)
            {
                using (Report report = new Report())
                {
                    string reportPath = Path.GetDirectoryName(Application.ExecutablePath);
                    string reportFileName = Path.Combine(reportPath, "stickers.frx");
                    if (!File.Exists(reportFileName))
                        if (File.Exists(Path.Combine(reportPath, "stickers.frx")))
                        {
                            reportFileName = Path.Combine(reportPath, "stickers.frx");
                        }
                    if (File.Exists(reportFileName))
                        report.Load(reportFileName);
                    report.RegisterData(members, "members");
                    report.Show();
                }
            }
            else
            {
                MessageBox.Show("Создайте участника");
            }
        }

        private void List_Click(object sender, EventArgs e)
        {
            using (BadgesList badgesList = new BadgesList())
            {
                xmlupd();
                badgesList.ShowDialog();
            }
        }

        private void BadgesDesing_Click(object sender, EventArgs e)
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

                if (members != null)
                {
                    report.RegisterData(members, "members");
                }
                report.Design();
            }
        }

        private void BadgesPrintAll_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count != 0)
            {
                xmlupd();
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
                    
                    report.Show();
                    report.RegisterData(members, "members");
                }
            }
            else
            {
                MessageBox.Show("Создайте участника");
            }
        }

        private void BadgesPrint_Click(object sender, EventArgs e)
        {
            File.Delete("members.xml");
            List<Members> membersList = new List<Members>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                Members member = new Members();
                member.id = row.Cells["id"].Value + string.Empty;
                member.firstname_rus = row.Cells["firstname_rus"].Value + string.Empty;
                member.firstname_eng = row.Cells["firstname_eng"].Value + string.Empty;
                member.lastname_rus = row.Cells["lastname_rus"].Value + string.Empty;
                member.lastname_eng = row.Cells["lastname_eng"].Value + string.Empty;
                member.country = row.Cells["country"].Value + string.Empty;
                member.city = row.Cells["city"].Value + string.Empty;
                member.company = row.Cells["company"].Value + string.Empty;
                member.mail = row.Cells["mail"].Value + string.Empty;
                {
                    DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells["Select"];
                    if (chk.Value == chk.FalseValue || chk.Value == null)
                    {
                        chk.Value = chk.TrueValue;
                    }
                    else
                    {
                        membersList.Add(member);
                        chk.Value = chk.FalseValue;
                    }
                }
            }
            if (membersList.Count == 0)
            { MessageBox.Show("Сначала выберите"); return; }
                XmlSerializer formatter = new XmlSerializer(typeof(Members[]));
                using (FileStream fs = new FileStream("members.xml", FileMode.OpenOrCreate))
                {
                    formatter.Serialize(fs, membersList.ToArray());
                }
                if (dataGridView1.Rows.Count != 0)
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
                        report.RegisterData(members, "members");
                        report.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Создайте участника");
                }            
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            using (Events events = new Events())
            {
                events.ShowDialog();
            }
        }
    }
}

