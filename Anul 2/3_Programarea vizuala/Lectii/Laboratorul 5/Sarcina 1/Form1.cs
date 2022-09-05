namespace Sarcina_1
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
            Size = new Size(400, 300);
            Text = "Sarcina 1";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            Button red = new Button();
            red.Location = new Point(60,100);
            red.Size = new Size(80,40);
            red.Text = "Red";
            red.Click += Red_Click;
            Controls.Add(red);

            Button yellow= new Button();
            yellow.Location = new Point(150,100);
            yellow.Size = new Size(80,40);
            yellow.Text = "Yellow";
            yellow.Click += Yellow_Click;
            Controls.Add(yellow);

            Button blue = new Button();
            blue.Location = new Point(240,100);
            blue.Size = new Size(80,40);
            blue.Text = "Blue";
            blue.Click += Blue_Click;
            Controls.Add(blue);
        }

        private void Blue_Click(object? sender, EventArgs e)
        {
            ChangeColorcs blue= new ChangeColorcs();
            blue.BackColor= Color.Blue;
            blue.Show();
        }

        private void Yellow_Click(object? sender, EventArgs e)
        {
            ChangeColorcs yellow= new ChangeColorcs();
            yellow.BackColor= Color.Yellow;
            yellow.Show();
        }

        private void Red_Click(object? sender, EventArgs e)
        {
            ChangeColorcs red= new ChangeColorcs();
            red.BackColor= Color.Red;
            red.Show();
        }
    }
}