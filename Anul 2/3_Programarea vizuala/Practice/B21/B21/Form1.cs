namespace B21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Default();
        }
        public int x = 0;
        Label label1;
        private void Default()
        {
            Font = new Font("Verdana", 12);
            Size = new Size(400, 400);
            Text = "Biletul 21";
            this.BackColor = Color.White;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            Button button=new Button();
            button.Text = "UpVote";
            button.Size = new Size(110,40);
            button.Location = new Point(150,80);
            button.BackColor = Color.Aquamarine;
            button.Click += Button_Click;
            Controls.Add(button);

            Label label=new Label();
            label.Text = "Scor :";
            label.Location = new Point(180,155);
            label.Size = new Size(100,30);
            Controls.Add(label);

            label1 =new Label();
            label1.Text = $"{x}";
            label1.Location = new Point(195, 185);
            label1.Size = new Size(100, 30);
            Controls.Add(label1);

            Button button2=new Button();
            button2.Text = "DownVote";
            button2.Size = new Size(110,40);
            button2.Location = new Point(150,230);
            button2.BackColor = Color.Aquamarine;
            button2.Click += Button2_Click;
            Controls.Add(button2);
        }
        private void Button2_Click(object? sender, EventArgs e)
        {
            x--;
            label1.Text = $"{x}";

        }
        private void Button_Click(object? sender, EventArgs e)
        {
            x++;
            label1.Text = $"{x}";
        }
    }
}