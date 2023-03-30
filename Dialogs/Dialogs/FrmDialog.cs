using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dialogs
{
    public partial class FrmDialog : Form
    {
        public FrmDialog()
        {
            InitializeComponent();
        }

        private void btnMessageBox_Click(object sender, EventArgs e)
        {
           DialogResult r =  MessageBox.Show("Do you understand this?","Dialog",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
             
            if (r == DialogResult.Yes)
            {
                MessageBox.Show("You are pass");
            }
            else if (r == DialogResult.No)
            {
                MessageBox.Show("you are fail");
            }


        }

        private void btnCustomdesign_Click(object sender, EventArgs e)
        {
            FrmUser f = new FrmUser();
           DialogResult r = f.ShowDialog();

            if (r == DialogResult.OK)
            {
                MessageBox.Show("Your name is " + f.UserName);
                MessageBox.Show("Your age is " + f.UserAge);
            }
            else
            {
                MessageBox.Show("You pressed cancel");
            }

        }
    }
}
