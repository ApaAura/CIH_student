namespace B4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Default();
        }
        TextBox textBox, textBox1, textBox2, textBox3, textBox4;
        Label label5, label6;
        private void Default()
        {
            Font = new Font("Times New Roman", 13);
            Size = new Size(500, 400);
            Text = "Biletul 4";
            this.BackColor = Color.White;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            Label label=new Label();
            label.Text = "Latura stanga : ";
            label.Size = new Size(140,30);
            label.Location = new Point(30,100);
            Controls.Add(label);

            textBox = new TextBox();
            textBox.Size = new Size(80,30);
            textBox.Location = new Point(45,130);
            Controls.Add(textBox);

            Label label1 = new Label();
            label1.Text = "Latura dreapta : ";
            label1.Size = new Size(150, 30);
            label1.Location = new Point(325,100);
            Controls.Add(label1);

            textBox1 = new TextBox();
            textBox1.Size = new Size(80,30);
            textBox1.Location=new Point(345,130);
            Controls.Add(textBox1);

            Label label2 = new Label();
            label2.Text = "Baza mica : ";
            label2.Size = new Size(150, 30);
            label2.Location = new Point(200,30);
            Controls.Add(label2);

            textBox2 = new TextBox();
            textBox2.Size = new Size(80, 30);
            textBox2.Location = new Point(200,60);
            Controls.Add(textBox2);

            Label label3 = new Label();
            label3.Text = "Baza mare : ";
            label3.Size = new Size(95, 20);
            label3.Location = new Point(150,210);
            Controls.Add(label3);

            textBox3 = new TextBox();
            textBox3.Size = new Size(80, 30);
            textBox3.Location = new Point(245, 208);
            Controls.Add(textBox3);

            Label label4 = new Label();
            label4.Text = "Inaltimea : ";
            label4.Size = new Size(95, 20);
            label4.Location = new Point(150,245);
            Controls.Add(label4);

            textBox4 = new TextBox();
            textBox4.Size = new Size(80, 30);
            textBox4.Location = new Point(245, 240);
            Controls.Add(textBox4);

            Button button = new Button();
            button.Location = new Point(30, 280);
            button.Size = new Size(170, 45);
            button.Text = "Calculeaza";
            button.BackColor = Color.Aquamarine;
            button.Click += Button_Click;
            Controls.Add(button);

            label5 = new Label();
            label5.Text = "Aria : ";
            label5.Location = new Point(280, 275);
            label5.Size = new Size(180, 30);
            Controls.Add(label5);

            label6 = new Label();
            label6.Text = "Perimetrul : ";
            label6.Location = new Point(280, 305);
            label6.Size = new Size(180, 30);
            Controls.Add(label6);

            PictureBox pictureBox1 = new PictureBox();
            pictureBox1.Image = new Bitmap("1.png");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Size = new Size(190, 100);
            pictureBox1.Location = new Point(145, 100);
            Controls.Add(pictureBox1);
        }

        private void Button_Click(object? sender, EventArgs e)
        {
            double latS =double.Parse(textBox.Text);
            double latD = double.Parse(textBox1.Text);
            double Bmica = double.Parse(textBox2.Text);
            double Bmare = double.Parse(textBox3.Text);
            double H = double.Parse(textBox4.Text);
            double aria = ((Bmare + Bmica) * H) / 2;
            double perimetru = Bmica + Bmare + latD + latS;
            label5.Text = $"Aria : {aria}";
            label6.Text = $"Perimetrul : {perimetru}";
        }
    }
}