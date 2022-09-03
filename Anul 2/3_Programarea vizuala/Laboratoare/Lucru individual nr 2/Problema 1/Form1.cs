namespace Problema_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Default();
        }

        TextBox textBox1;
        TextBox textBox2;
        TextBox textBox3;
        TextBox textBox4;
        private void Default()
        {
            Font = new Font("Verdana", 12);
            Size = new Size(400, 300);
            Text = "Problema 1";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            textBox1 = new TextBox();
            textBox1.Location = new Point(40,50);
            textBox1.Size = new Size(50,60);
            Controls.Add(textBox1);

            Label lb1 = new Label();
            lb1.Location = new Point(93,55);
            lb1.Size = new Size(60,30);
            lb1.Text = "X    +";
            Controls.Add(lb1);

            textBox2 = new TextBox();
            textBox2.Location = new Point(170,50);
            textBox2.Size = new Size(50,60);
            Controls.Add(textBox2);

            Label lb2 = new Label();
            lb2.Location= new Point(250,55);
            lb2.Size = new Size(30,30);
            lb2.Text = "=";
            Controls.Add(lb2);

            textBox3 = new TextBox();
            textBox3.Location = new Point(290,50);
            textBox3.Size = new Size(50,60);
            Controls.Add(textBox3);

            Button btn= new Button();
            btn.Location = new Point(130,130);
            btn.Size = new Size(130,40);  
            btn.Text = "Calculeaza";
            btn.BackColor = Color.Beige;
            btn.Click += Btn_Click;
            Controls.Add(btn);

            Label lb3 = new Label();
            lb3.Location = new Point(150,180); 
            lb3.Size = new Size(40,30);
            lb3.Text = "X = ";
            Controls.Add(lb3);

            textBox4 = new TextBox();
            textBox4.Location = new Point(190,175);
            textBox4.Size = new Size(50,60);
            Controls.Add(textBox4);
        }
        private void Btn_Click(object? sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Programul are nevoie de valorile A, B si C pentru calcularea soluției X");
            }
            try
            {
                int A = int.Parse(textBox1.Text);
                int B = int.Parse(textBox2.Text);
                int C = int.Parse(textBox3.Text);

                double X = (double)((double)(C - B) / A);
                textBox4.Text = $"{X:F2}";
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid data !");
            }
        }
    }
}