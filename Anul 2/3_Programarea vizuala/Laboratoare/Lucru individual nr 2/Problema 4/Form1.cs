using System.Windows.Forms;

namespace Problema_4
{
    public partial class Form1 : Form
    {
        PictureBox pictureBox1;
        System.Windows.Forms.Timer timer1;
        public Form1()
        {
            InitializeComponent();
            Default();
        }
        private void Default()
        {
            Size = new Size(400, 700);
            Text = "Problema 4";
            this.BackColor = Color.FromArgb(255,247, 247, 247);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            pictureBox1 = new PictureBox();
            pictureBox1.Image = new Bitmap("1.png");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Size = new Size(79,140);
            pictureBox1.Location = new Point(this.Width/2-pictureBox1.Size.Width/2,this.Height-pictureBox1.Height);

            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 100;
            timer1.Tick += Timer1_Tick;
            timer1.Start();
            this.Controls.Add(pictureBox1);
        }

        private void Timer1_Tick(object? sender, EventArgs e)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 10);
            if (pictureBox1.Location.Y<-1*pictureBox1.Height)
            {
                timer1.Stop();
            }
        }
    }
}