using System.Drawing.Drawing2D;

namespace Problema_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Default();
            this.Paint += Form1_Paint;
        }
        private void Form1_Paint(object? sender, PaintEventArgs e)
        {
            Rectangle rectangle=new Rectangle(10, 10, 100, 200);
            LinearGradientBrush linearGradientBrush = new LinearGradientBrush(
                rectangle,
                Color.Blue,
                Color.Green,
                LinearGradientMode.Horizontal) ;
            Graphics g = this.CreateGraphics();
            g.FillRectangle(linearGradientBrush, rectangle);
        }
        private void Default()
        {

            Size = new Size(130, 270);
            Text = "Problema 2";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
    }
}