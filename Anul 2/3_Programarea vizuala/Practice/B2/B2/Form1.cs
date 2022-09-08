namespace B2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Default();
        }
        Label label1;
        Label label2;
        TextBox text;
        private void Default()
        {
            Font = new Font("Times New Roman", 14);
            Size = new Size(500, 380);
            Text = "Biletul 2";
            this.BackColor = Color.White;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            Label label = new Label();
            label.Text = "Latura patratului :";
            label.Location = new Point(60, 50);
            label.Size = new Size(150, 20);
            Controls.Add(label);

            text = new TextBox();
            text.Location = new Point(40, 75);
            text.Size = new Size(170, 50);
            Controls.Add(text);

            Button button = new Button();
            button.Location = new Point(50, 120);
            button.Size = new Size(150, 45);
            button.Text = "Calculeaza";
            button.BackColor = Color.Aquamarine;
            button.Click += Button_Click;
            Controls.Add(button);

            label1 = new Label();
            label1.Text = "Aria : ";
            label1.Location = new Point(30, 200);
            label1.Size = new Size(200, 30);
            Controls.Add(label1);

            label2 = new Label();
            label2.Text = "Perimetrul : ";
            label2.Location = new Point(30, 230);
            label2.Size = new Size(180, 30);
            Controls.Add(label2);

            PictureBox pictureBox1 = new PictureBox();
            pictureBox1.Image = new Bitmap("1.png");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Size = new Size(190, 150);
            pictureBox1.Location = new Point(260, 100);
            Controls.Add(pictureBox1);
        }
        private void Button_Click(object? sender, EventArgs e)
        {
            double latura = double.Parse(text.Text);
            double aria = latura * latura;
            double perimetru = latura * 4;
            label1.Text = $"Aria : {aria} cm^2";
            label2.Text = $"Perimetrul : {perimetru} cm";
        }
    }
}