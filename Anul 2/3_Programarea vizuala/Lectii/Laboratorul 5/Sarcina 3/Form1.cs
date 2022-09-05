namespace Sarcina_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Default();
        }
        Label lb2;
        private void Default()
        {
            Font = new Font("Verdana", 12);
            Size = new Size(400, 300);
            Text = "Sarcina 3";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            Label lb=new Label();
            lb.Text = "Logare in sistem";
            lb.Location = new Point(120,70);
            lb.Size = new Size(200,30);
            Controls.Add(lb);

            Button btn=new Button();
            btn.Text = "Log In";
            btn.Location = new Point(140,100);
            btn.Size = new Size(100,40);
            btn.Click += Btn_Click;
            Controls.Add(btn);

            lb2=new Label();
            lb2.Text = "Username: \nPassword: ";
            lb2.Location = new Point(20,200);
            lb2.Size = new Size(220,80);
            Controls.Add(lb2);  
        }
        private void Btn_Click(object? sender, EventArgs e)
        {
            Infocs info = new Infocs();
            info.ShowDialog();
            lb2.Text = $"Username: {info.Login}\nPassword: {info.Password}";
        }
    }
}