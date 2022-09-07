namespace Problema_1
{
    public partial class Form1 : Form
    {
        static bool flag = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                this.BackColor = Color.Black;
                flag = false;
            }
            else
            {
                this.BackColor = Color.White; 
                flag = true;
            }
        }
    }
}