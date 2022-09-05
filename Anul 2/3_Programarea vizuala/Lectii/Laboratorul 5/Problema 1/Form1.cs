namespace Problema_1
{
    public partial class Form1 : Form
    {
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

            Button b1=new Button();
            b1.Location = new Point(100,120);
            b1.Size = new Size(180,45);
            b1.Text = " Afiseaza Data";
            b1.Font = new Font("Verdana", 16);
            b1.BackColor = Color.Aqua;
            b1.Click += B1_Click;
            Controls.Add(b1);

            Button b2 = new Button();
            b2.Location = new Point(100, 185);
            b2.Size = new Size(180, 45);
            b2.Text = " Afiseaza Ora";
            b2.Font = new Font("Verdana", 16);
            b2.BackColor = Color.Aqua;
            b2.Click += B2_Click;
            Controls.Add(b2);
        }
        private void B2_Click(object? sender, EventArgs e)
        {
            string ora = $"Este ora {DateTime.Now.ToString("hh:mm")}";
            ShowInfoForm showInfoForm = new ShowInfoForm(ora);
            showInfoForm.Show();
        }
        private void B1_Click(object? sender, EventArgs e)
        {
            string data = $"Este data de {DateTime.Now.ToString("dd/MM/yyyy")}";
            ShowInfoForm showInfoForm = new ShowInfoForm(data);
            showInfoForm.Show();
        }
    }
}