namespace Problema_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Default();
        }
        TextBox textBox;
        TextBox textBox1;
        private void Default()
        {
            Font = new Font("Verdana", 18);
            Size = new Size(600, 430);
            Text = "Problema 1";
            this.BackColor = Color.Azure;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            PictureBox pictureBox =new PictureBox();
            pictureBox.Image = new Bitmap("1.png");
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Size = new Size(150, 150);
            pictureBox.Location = new Point(100, 10);
            Controls.Add(pictureBox);

            PictureBox pictureBox1 = new PictureBox();
            pictureBox1.Image = new Bitmap("2.png");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Size = new Size(150, 150);
            pictureBox1.Location = new Point(330, 10);
            Controls.Add(pictureBox1);

            Label label=new Label();
            label.Text = "Paula";
            label.Location = new Point(135,160);
            label.Size = new Size(100,30);
            Controls.Add(label);

            Label label1= new Label();
            label1.Text = "Pavel";
            label1.Size = new Size(100,30);
            label1.Location = new Point(370,160);
            Controls.Add(label1);

            Button button1=new Button();
            button1.Text = "Investitii Paula";
            button1.Size = new Size(180,30);
            button1.Location = new Point(95,220);
            button1.Font = new Font("Verdana",10);
            button1.Click += Button1_Click;
            Controls.Add(button1);

            Button button2=new Button();
            button2.Text = "Decapitalizare Paula";
            button2.Size = new Size(180,30);
            button2.Location = new Point(95,260);
            button2.Font = new Font("Verdana", 10);
            button2.Click += Button2_Click;
            Controls.Add(button2);

            Button button3=new Button();
            button3.Text = "Investitii Pavel";
            button3.Size = new Size(180, 30);
            button3.Location = new Point(320, 220);
            button3.Font = new Font("Verdana", 10);
            button3.Click += Button3_Click;
            Controls.Add(button3);

            Button button4=new Button();
            button4.Text = "Decapitalizare Pavel";
            button4.Size = new Size(180, 30);
            button4.Location = new Point(320, 260);
            button4.Font = new Font("Verdana", 10);
            button4.Click += Button4_Click;
            Controls.Add(button4);

            textBox = new TextBox();
            textBox.Location = new Point(150,300);
            textBox.Size = new Size(60,40);
            textBox.Font = new Font("Verdana", 12);
            textBox.Text = "60";
            textBox.ForeColor= Color.Green;
            //textBox.Enabled = false;
            Controls.Add(textBox);

            textBox1 = new TextBox();
            textBox1.Location = new Point(385, 300);
            textBox1.Size = new Size(60, 40);
            textBox1.Font = new Font("Verdana", 12);
            textBox1.ForeColor = Color.Green;
            textBox1.Text = "60";
            //textBox1.Enabled = false;
            Controls.Add(textBox1);
        }
        public int nr;
        public int nr1;
        private void Verify()
        {
            nr = int.Parse(textBox.Text);
            nr1 = int.Parse(textBox1.Text);
            if (nr<0)
            {
                textBox.ForeColor = Color.Red;
            }
            else
            {
                textBox.ForeColor = Color.Green;
            }
            if (nr1<0)
            {
                textBox1.ForeColor = Color.Red;
            }
            else
            {
                textBox1.ForeColor = Color.Green;
            }
            if (nr<20)
            {
                MessageBox.Show("ATENTIE ! Paula pompati investitii !");
            }
            if (nr1<20)
            {
                MessageBox.Show("ATENTIE ! Pavel pompati investitii !");
            }
        }
        int consec1 = 0, consec2 = 0, sconsec1 = 0, sconsec2 = 0;
        private void Button4_Click(object? sender, EventArgs e)
        {
            nr = int.Parse(textBox.Text);
            nr1 = int.Parse(textBox1.Text);
            textBox.Text = $"{nr - 5}";
            textBox1.Text = $"{nr1 - 15}";
            sconsec2++;
            if (sconsec2 == 3)
            {
                MessageBox.Show("Atentie Pavel, sunteti in declin !");
            }
            Verify();
        }
        private void Button3_Click(object? sender, EventArgs e)
        {
            nr = int.Parse(textBox.Text);
            nr1 = int.Parse(textBox1.Text);
            textBox.Text = $"{nr + 3}";
            textBox1.Text = $"{nr1 + 10}";
            consec2++;
            consec1 = 0;
            sconsec2 = 0;
            if(consec2 == 5)
            {
                MessageBox.Show("Felicitari Pavel, sunteti in crestere !");
            }
            Verify();
        }
        private void Button2_Click(object? sender, EventArgs e)
        {
            nr = int.Parse(textBox.Text);
            nr1 = int.Parse(textBox1.Text);
            textBox.Text = $"{nr - 17}";
            textBox1.Text = $"{nr1 - 9}";
            sconsec1++;
            if (sconsec1 == 3)
            {
                MessageBox.Show("Atentie Paula, sunteti in declin !");
            }
            Verify();
        }
        private void Button1_Click(object? sender, EventArgs e)
        {
            nr = int.Parse(textBox.Text);
            nr1 = int.Parse(textBox1.Text);
            textBox.Text = $"{nr+20}";
            textBox1.Text = $"{nr1 + 5}";
            consec1++;
            consec2 = 0;
            sconsec1 = 0;
            if (consec1 == 5)
            {
                MessageBox.Show("Felicitari Paula, sunteti in crestere !");
            }
            Verify();
        }
    }
}