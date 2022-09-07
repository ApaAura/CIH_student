namespace Problema_1
{
    public partial class Form1 : Form
    {
        Button button;
        Button button1;
        Label label1;
        private int counter = 0;
        public Form1()
        {
            InitializeComponent();
            Default();
        }
        private void Default()
        {
            Font = new Font("Verdana", 14);
            Size = new Size(400, 400);
            Text = "Problema 1";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            button = new Button();
            button.Text = "";
            button.Size = new Size(80, 80);
            button.Location = new Point(150, 60);
            Controls.Add(button);

            button1 = new Button();
            button1.Text = "";
            button1.Size = new Size(80, 80);
            button1.Location = new Point(150, 210);
            Controls.Add(button1);

            label1 = new Label();
            label1.Text = "0";
            label1.Size = new Size(50, 50);
            label1.Location = new Point(180, 160);
            Controls.Add(label1);
        }
        private void button1_Paint(object sender, PaintEventArgs e)
        {
            Point[] TriangleUp =
            {
            new Point(45, 0),
            new Point(0, 60),
            new Point(90, 60),
        };
            e.Graphics.Clear(this.BackColor); 
            e.Graphics.FillPolygon(Brushes.Gray, TriangleUp); 
        }
        private void button2_Paint(object sender, PaintEventArgs e)
        {
            Point[] TriangleDown =
            {
            new Point(45, 60),
            new Point(0, 0),
            new Point(90, 0),
        };
            e.Graphics.Clear(this.BackColor); 
            e.Graphics.FillPolygon(Brushes.Gray, TriangleDown); 
        }
        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = (counter--).ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = (counter++).ToString();
        }
    }
}