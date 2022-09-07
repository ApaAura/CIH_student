namespace Problema_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Default();
            Paint += Form1_Paint;
            Paint += Form2_Paint;
            Paint += Form3_Paint;
        }
        PictureBox pictureBox1;
        private void Default()
        {
            Size = new Size(600, 400);
            Text = "Problema 3";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            pictureBox1 = new PictureBox();
            pictureBox1.Image = new Bitmap("1.png");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Size = new Size(150, 150);
            pictureBox1.Location = new Point(225, 100);
            Controls.Add(pictureBox1);

        }
        private void Form3_Paint(object? sender, PaintEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            SolidBrush br = new SolidBrush(Color.FromArgb(255, 0, 0, 179));
            g.FillRectangle(br, new Rectangle(new Point(0, 0), new Size(200, 400)));
            br.Dispose();
        }
        private void Form2_Paint(object? sender, PaintEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            SolidBrush br = new SolidBrush(Color.FromArgb(255, 247, 217, 0));
            g.FillRectangle(br, new Rectangle(new Point(200,0), new Size(200, 400)));
            br.Dispose();
        }
        private void Form1_Paint(object? sender, PaintEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            SolidBrush br = new SolidBrush(Color.FromArgb(255, 227, 33, 16));
            g.FillRectangle(br, new Rectangle(new Point(400, 0), new Size(200, 400)));
            br.Dispose();
        }
    }
}