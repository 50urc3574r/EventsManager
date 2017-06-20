using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventManager
{
    public partial class EditBadge : Form
    {
        public string BadgeName
        {
            get
            {
                return tbName.Text;
            }
            set
            {
                tbName.Text = value;
            }
        }

        public Color BadgeColor
        {
            get
            {
                return btnColor.BackColor;
            }
            set
            {
                btnColor.BackColor = value;
            }
        }

        public Image TopImage
        {
            get
            {
                return pbTop.Image;
            }
            set
            {
                pbTop.Image = value;
            }
        }

        public EditBadge()
        {
            InitializeComponent();
        }

        private void pbTop_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pbTop.ImageLocation = openFileDialog.FileName;
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                btnColor.BackColor = colorDialog.Color;
            }
        }
    }
}
