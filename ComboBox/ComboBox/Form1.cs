using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            Txthour.Text = Vsbhours.Value.ToString();
        }

        private void Cborate_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (double i = 5.5; i <= 10; i += .5)
            {
                Cborate.Items.Add(i);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double gp = double.Parse(Cborate.Text) * double.Parse (Txthour.Text);
            Txtgrosspay.Text = gp.ToString("c");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Txthour.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
