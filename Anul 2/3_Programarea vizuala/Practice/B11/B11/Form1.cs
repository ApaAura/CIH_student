namespace B11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Default();
        }
        PictureBox pictureBox1;
        private void Default()
        {
            Size = new Size(450, 400);
            Text = "Biletul 11";
            this.BackColor = Color.White;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            pictureBox1 = new PictureBox();
            pictureBox1.Image = new Bitmap("1.png");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Size = new Size(180, 140);
            pictureBox1.Location = new Point(195, 110);
            Controls.Add(pictureBox1);

            Button button = new Button();
            button.Size = new Size(100, 30);
            button.Text = "Sus";
            button.BackColor = Color.Aquamarine;
            button.Location = new Point(40,80);
            button.Click += Button_Click;
            Controls.Add(button);

            Button button2 = new Button();
            button2.Size = new Size(100, 30);
            button2.Location = new Point(40,160);
            button2.BackColor = Color.Aquamarine;
            button2.Text = "Centru";
            button2.Click += Button2_Click;
            Controls.Add(button2);

            Button button3 = new Button();
            button3.Size = new Size(100, 30);
            button3.Location = new Point(40,240);
            button3.BackColor = Color.Aquamarine;
            button3.Text = "Jos";
            button3.Click += Button3_Click;
            Controls.Add(button3);
        }
        private void Button3_Click(object? sender, EventArgs e)
        {
            pictureBox1.Location = new Point(195, pictureBox1.Location.Y+5);
        }
        private void Button2_Click(object? sender, EventArgs e)
        {
            pictureBox1.Location = new Point(195,110);
        }
        private void Button_Click(object? sender, EventArgs e)
        {
            pictureBox1.Location = new Point(195, pictureBox1.Location.Y - 5);
        }
    }
}