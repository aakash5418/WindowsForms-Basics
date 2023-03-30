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
    public partial class FrmUser : Form
    {
        public FrmUser()
        {
            InitializeComponent();
        }

        private void FrmUser_Load(object sender, EventArgs e)
        {
            //Set text to lblFormLoad label on Form_Load event
            btnName.Text = "Name";
        }
        public string UserName
        {
            get
            {
                return btnTextbox1.Text;//btnName.Text;
            }
        }
        public string  UserAge
        {
            get
            {
                return textBox2.Text; // btnAge.Text;
            }
        }
    }
}
