namespace B3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Default();
        }
        TextBox text;
        TextBox text1;
        Label label1;
        Label label2;
        private void Default()
        {
            Font = new Font("Times New Roman", 14);
            Size = new Size(500, 380);
            Text = "Biletul 3";
            this.BackColor = Color.White;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            Label label = new Label();
            label.Text = "Lungimea dreptunghiului :";
            label.Location = new Point(30, 35);
            label.Size = new Size(210, 20);
            Controls.Add(label);

            text = new TextBox();
            text.Location = new Point(30, 60);
            text.Size = new Size(170, 50);
            Controls.Add(text);

            Label label3 = new Label();
            label3.Text = "Latimea dreptunghiului :";
            label3.Location = new Point(30, 95);
            label3.Size = new Size(200, 20);
            Controls.Add(label3);

            text1 = new TextBox();
            text1.Location = new Point(30, 120);
            text1.Size = new Size(170, 50);
            Controls.Add(text1);

            Button button = new Button();
            button.Location = new Point(50, 160);
            button.Size = new Size(170, 45);
            button.Text = "Calculeaza";
            button.BackColor = Color.Aquamarine;
            button.Click += Button_Click;
            Controls.Add(button);

            label1 = new Label();
            label1.Text = "Aria : ";
            label1.Location = new Point(30, 220);
            label1.Size = new Size(200, 30);
            Controls.Add(label1);

            label2 = new Label();
            label2.Text = "Perimetrul : ";
            label2.Location = new Point(30, 250);
            label2.Size = new Size(180, 30);
            Controls.Add(label2);

            PictureBox pictureBox1 = new PictureBox();
            pictureBox1.Image = new Bitmap("1.png");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Size = new Size(190, 180);
            pictureBox1.Location = new Point(260, 100);
            Controls.Add(pictureBox1);
        }
        private void Button_Click(object? sender, EventArgs e)
        {
            double lungimea = double.Parse(text.Text);
            double latimea = double.Parse(text1.Text);
            double aria = lungimea*latimea;
            double perimetru = lungimea+lungimea+latimea+latimea;
            label1.Text = $"Aria : {aria} cm^2";
            label2.Text = $"Perimetrul : {perimetru} cm";
        }
    }
}