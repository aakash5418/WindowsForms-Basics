namespace RadioButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rdoHappy_CheckedChanged(object sender, EventArgs e)
        {
            pichappy.Visible = true;
            picSad.Visible = false;
        }

        private void rdoSad_CheckedChanged(object sender, EventArgs e)
        {
            pichappy.Visible = false;
            picSad.Visible = true;
        }
    }
}