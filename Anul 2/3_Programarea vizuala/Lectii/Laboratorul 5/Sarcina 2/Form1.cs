namespace Sarcina_2
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
            Text = "Sarcina 2";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            Label lb = new Label();
            lb.Font= new Font("Verdana", 16);
            lb.Text = "Fereastra parinte !";
            lb.Size = new Size(220,40);
            lb.Location = new Point(80,100);
            Controls.Add(lb);

            Button bt=new Button();
            bt.BackColor = Color.Aquamarine;
            bt.Text = "Fereastra modala";
            bt.Location = new Point(85,140);
            bt.Size = new Size(200,40);
            bt.Click += Bt_Click;
            Controls.Add(bt);
        }
        private void Bt_Click(object? sender, EventArgs e)
        {
            Info info = new Info();
            info.Show();
        }
    }
}