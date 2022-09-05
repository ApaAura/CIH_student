namespace Problema_1
{
    public partial class Form1 : Form
    {
        //Button - Exemplu de utilzare
        public Form1()
        {
            InitializeComponent();
            Default();
        }
        private void Default()
        {
            Font = new Font("Verdana", 12);
            Size = new Size(400, 400);
            Text = "Problema 1";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            Button Bt1=new Button();
            Bt1.Location = new Point(70,130);
            Bt1.Size = new Size(250,80);
            Bt1.Text = "Sunt un button :)";
            Bt1.Click += Bt1_Click;
            Controls.Add(Bt1);
        }
        private void Bt1_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Hello world !");
        }
    }
}