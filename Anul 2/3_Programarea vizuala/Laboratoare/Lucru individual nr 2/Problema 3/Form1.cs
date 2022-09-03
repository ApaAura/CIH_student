using System.Drawing;

namespace Problema_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Default();
        }
        Label lb2;
        Label lb3;
        TextBox textBox1;
        TextBox textBox2;
        private void Default()
        {
            Font = new Font("Verdana", 12);
            Size = new Size(500, 300);
            Text = "Problema 3";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Paint += Form1_Paint;

            //Panel pan = new Panel();
            //pan.Size = new Size(100, 200);
            //pan.Location = new Point(300, 40);
            //pan.BackColor = Color.FromArgb(255, 153, 204, 255);
            //this.Controls.Add(pan);

            Label label=new Label();
            label.Text = "Lungimea";
            label.Location = new Point(30,40);
            label.Size = new Size(80,30);
            Controls.Add(label);

            Label label1 = new Label();
            label1.Text = "Latimea";
            label1.Location = new Point(30,70);
            label1.Size = new Size(80,30);
            Controls.Add(label1);

            textBox1 = new TextBox();
            textBox1.Location = new Point(120,40);
            textBox1.Size = new Size(130, 50);
            Controls.Add(textBox1);

            textBox2 = new TextBox();
            textBox2.Location = new Point(120,70);
            textBox2.Size= new Size(130, 50);
            Controls.Add(textBox2);

            Button button = new Button();
            button.Text = "Calculeaza";
            button.Size = new Size(150, 50);
            button.Location = new Point(70, 110);
            button.Click += Button_Click;
            button.BackColor = Color.FromArgb(255, 153, 204, 255);
            Controls.Add(button);

            lb2 = new Label();
            lb2.Size = new Size(250, 30);
            lb2.Location = new Point(30, 190);
            lb2.Text = "Aria : ";
            Controls.Add(lb2);

            lb3 = new Label();
            lb3.Size = new Size(250, 30);
            lb3.Location = new Point(30, 220);
            lb3.Text = "Perimetrul : ";
            Controls.Add(lb3);
        }
        private void Form1_Paint(object? sender, PaintEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            SolidBrush br = new SolidBrush(Color.FromArgb(255, 153, 204, 255));
            g.FillRectangle(br, 310, 40, 120, 200);
            br.Dispose();
        }
        private void Button_Click(object? sender, EventArgs e)
        {
            try
            {
                int A = int.Parse(textBox1.Text);
                int B=int.Parse(textBox2.Text);
                lb2.Text = $"Aria : {A*B}";
                lb3.Text = $"Perimetrul : {2*(A+B)}";
            }
            catch (Exception)
            {
                MessageBox.Show("Programul are nevoie de dimensiunile dreptunghiului !");
            }
        }
    }
}