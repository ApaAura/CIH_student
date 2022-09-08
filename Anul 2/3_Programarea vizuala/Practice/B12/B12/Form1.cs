namespace B12
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
            Text = "Biletul 12";
            this.BackColor = Color.White;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            pictureBox1 = new PictureBox();
            pictureBox1.Image = new Bitmap("1.png");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Size = new Size(180, 140);
            pictureBox1.Location = new Point(130,90);
            Controls.Add(pictureBox1);

            Button button = new Button();
            button.Size = new Size(100, 30);
            button.Text = "+";
            button.BackColor = Color.Aquamarine;
            button.Location = new Point(90,280);
            button.Click += Button_Click;
            Controls.Add(button);

            Button button2 = new Button();
            button2.Size = new Size(100, 30);
            button2.Location = new Point(260,280);
            button2.BackColor = Color.Aquamarine;
            button2.Text = "-";
            button2.Click += Button2_Click;
            Controls.Add(button2);

        }
        private void Button2_Click(object? sender, EventArgs e)
        {
            pictureBox1.Height -= 2;
            pictureBox1.Width -= 2;
        }
        private void Button_Click(object? sender, EventArgs e)
        {
            pictureBox1.Height += 2;
            pictureBox1.Width += 2;
        }
    }
}