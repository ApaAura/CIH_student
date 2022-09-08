namespace B22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Button ClickedButton = (Button)sender;
            Controls.Remove(ClickedButton);
        }
    }
}