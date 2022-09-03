namespace Problema_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Default();
        }
        TextBox textBox;
        Label lb2;
        Label lb3;
        //PictureBox pictureBox1;
        private void Default()
        {
            Font = new Font("Verdana", 12);
            Size = new Size(500, 300);
            Text = "Problema 2";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            Label lb1=new Label();
            lb1.Size = new Size(120,30);
            lb1.Location = new Point(30,60);
            lb1.Text = "Raza cercului";
            Controls.Add(lb1);

            textBox=new TextBox();
            textBox.Size = new Size(130,50);
            textBox.Location = new Point(150,55);
            Controls.Add(textBox);

            Button button=new Button();
            button.Text = "Calculeaza";
            button.Size = new Size(150,50);
            button.Location = new Point(90,90);
            button.Click += Button_Click;
            button.BackColor = Color.Aquamarine;
            Controls.Add(button);

            lb2=  new Label();
            lb2.Size = new Size(250, 30);
            lb2.Location = new Point(30, 190);
            lb2.Text = "Aria cercului : "; 
            Controls.Add(lb2);

            lb3=new Label();
            lb3.Size = new Size(250,30);
            lb3.Location = new Point(30,220);
            lb3.Text = "Lungimea cercului : ";
            Controls.Add(lb3);

            this.Paint += Form1_Paint;
            //pictureBox1 = new PictureBox();
            //pictureBox1.Image = new Bitmap("1.png");
            //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            //pictureBox1.Size = new Size(150, 150);
            //pictureBox1.Location = new Point(280,80);
            //Controls.Add(pictureBox1);
        }
        private void Form1_Paint(object? sender, PaintEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            SolidBrush br = new SolidBrush(Color.FromArgb(255, 127, 255, 212));
            g.FillEllipse(br,new Rectangle(new Point(300,90),new Size(130,130)));
            br.Dispose();
        }
        private void Button_Click(object? sender, EventArgs e)
        {
            try
            {
                int A = int.Parse(textBox.Text);
                double Aria = Math.PI*Math.Pow(A,2);
                double Lungime = 2 * A * Math.PI;
                lb2.Text = $"Aria cercului : {Aria:f2}";
                lb3.Text = $"Lungimea cercului : {Lungime:f2}";
            }
            catch (Exception)
            {
                MessageBox.Show("Programul are nevoie de raza cercului !");
            }
        }
    }
}