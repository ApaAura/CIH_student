namespace B5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Default();
        }
        TextBox TextBox, TextBox1;
        private void Default()
        {
            Font = new Font("Times New Roman", 13);
            Size = new Size(450, 350);
            Text = "Biletul 5";
            this.BackColor = Color.White;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            Label label = new Label();
            label.Text = "Operand";
            label.Location = new Point(180,20);
            label.Size = new Size(100,30);
            Controls.Add(label);

            TextBox = new TextBox();
            TextBox.Size = new Size(160,40);
            TextBox.Location = new Point(135,50);
            Controls.Add(TextBox);

            Label label1 = new Label();
            label1.Text = "Operatia";
            label1.Location = new Point(180, 100);
            label1.Size = new Size(100, 30);
            Controls.Add(label1);

            Button button = new Button();
            button.Text = "dubleaza";
            button.BackColor = Color.Aquamarine;
            button.Size = new Size(110,30);
            button.Location = new Point(30,130);
            button.Click += Button_Click;
            Controls.Add(button);

            Button button1 = new Button();
            button1.Text = "tripleaza";
            button1.BackColor = Color.Aquamarine;
            button1.Size = new Size(110, 30);
            button1.Location = new Point(145, 130);
            button1.Click += Button1_Click;
            Controls.Add(button1);

            Button button2 = new Button();
            button2.Text = "radical de ordin 2";
            button2.BackColor = Color.Aquamarine;
            button2.Size = new Size(150, 30);
            button2.Location = new Point(260, 130);
            button2.Click += Button2_Click;
            Controls.Add(button2);

            Button button3 = new Button();
            button3.Text = "suma cifrelor";
            button3.BackColor = Color.Aquamarine;
            button3.Size = new Size(380, 30);
            button3.Location = new Point(30,165);
            button3.Click += Button3_Click;
            Controls.Add(button3);

            Label label2 = new Label();
            label2.Text = "Rezultat";
            label2.Location = new Point(180, 220);
            label2.Size = new Size(100, 30);
            Controls.Add(label2);

            TextBox1 = new TextBox();
            TextBox1.Text = "";
            TextBox1.Enabled= false;
            TextBox1.Size = new Size(160, 40);
            TextBox1.Location = new Point(135, 250);
            Controls.Add(TextBox1);
        }
        private void Button3_Click(object? sender, EventArgs e)
        {
            double n = double.Parse(TextBox.Text);
            double suma = 0;
            while (n!=0)
            {
                suma += n % 10;
                n /= 10;
            }
            TextBox1.Text = $"{suma:f0}";
        }
        private void Button2_Click(object? sender, EventArgs e)
        {
            double n = double.Parse(TextBox.Text);
            TextBox1.Text = $"{Math.Sqrt(n):F3}";
        }
        private void Button1_Click(object? sender, EventArgs e)
        {
            double n = double.Parse(TextBox.Text);
            TextBox1.Text = $"{3 * n}";
        }
        private void Button_Click(object? sender, EventArgs e)
        {
            double n=double.Parse(TextBox.Text);
            TextBox1.Text = $"{2 * n}";
        }
    }
}