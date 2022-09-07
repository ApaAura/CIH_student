namespace Problema_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Default();
        }
        TextBox tb;
        TextBox tb1;
        TextBox tb2;
        Label lb3;
        PictureBox pictureBox1;
        private void Default()
        {
            Size = new Size(400, 300);
            Font = new Font("Verdana", 14);
            Text = "Problema 1";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            Label lb=new Label();
            lb.Text = "Latura 1 :";
            lb.Location = new Point(50, 30);
            lb.Size = new Size(120, 30);
            Controls.Add(lb);

            Label lb1 = new Label();
            lb1.Text = "Latura 2 :";
            lb1.Location = new Point(50, 80);
            lb1.Size = new Size(120, 30);
            Controls.Add(lb1);

            Label lb2 = new Label();
            lb2.Text = "Latura 3 :";
            lb2.Location = new Point(50, 130);
            lb2.Size = new Size(120, 30);
            Controls.Add(lb2);

            tb = new TextBox();
            tb.Location = new Point(170, 30);
            tb.Size = new Size(100, 30);
            Controls.Add(tb);

            tb1 = new TextBox();
            tb1.Location = new Point(170, 80);
            tb1.Size = new Size(100, 30);
            Controls.Add(tb1);

            tb2 = new TextBox();
            tb2.Location = new Point(170, 130);
            tb2.Size = new Size(100, 30);
            Controls.Add(tb2);

            Button bt1=new Button();
            bt1.Location = new Point(100,170);
            bt1.Size = new Size(130, 40);
            bt1.Text = "Calculeaza";
            bt1.Click += Bt1_Click;
            Controls.Add(bt1);

            lb3=new Label();
            lb3.Size = new Size(260, 130);
            lb3.Location = new Point(30, 230);
            lb3.BackColor = Color.Aquamarine;
            lb3.Text = "";
            Controls.Add(lb3);

            Label lb4=new Label();
            lb4.Location = new Point(400,30);
            lb4.Size = new Size(200,50);
            lb4.Text = "Desenul figurii: ";
            Controls.Add(lb4);

            pictureBox1 = new PictureBox();
            pictureBox1.Location = new Point(330,80);
            pictureBox1.Size = new Size(300,250);
            pictureBox1.BackColor = Color.LightGray;
            Controls.Add(pictureBox1);
        }
        private void Bt1_Click(object? sender, EventArgs e)
        {
            try
            {
                int latura1 = int.Parse(tb.Text);
                int latura2=int.Parse(tb1.Text);
                int latura3 = int.Parse(tb2.Text);
                if (Exista(latura1,latura2,latura3))
                {
                    int perimetru = latura1 + latura2 + latura3;
                    double p = perimetru / 2;
                    double aria = Math.Sqrt(p * (p - latura1) * (p - latura2) * (p - latura3));
                    lb3.Text = $"Latura 1 = {latura1}\nLatura 2 = {latura2}\nLatura 3 = {latura3}\nAria = {aria:F3}\nPerimetrul = {perimetru}";
                    tb.Text = "";
                    tb1.Text = "";
                    tb2.Text = "";
                    pictureBox1.Refresh();
                    using (Graphics d=pictureBox1.CreateGraphics())
                    {
                        Pen bluePen = new Pen(Color.Blue, 2);
                        int x = 100;
                        int y = 10;
                        d.DrawLine(bluePen, x, y, x + latura1, y + latura1);
                        d.DrawLine(bluePen, x+latura1, y+latura1, x-latura2, y+latura1);
                        d.DrawLine(bluePen, x - latura2, y + latura1, x, y);
                    }
                }
                else
                {
                    lb3.Text = "Nu se poate forma un triunghi !";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Introdu dimensiunile triunghiului !");
            }
        }
        private bool Exista(int latura1, int latura2, int latura3)
        {
            if (latura1>=latura2+latura3||latura2>=latura1+latura3||latura3>=latura1+latura2)
            {
                return false;
            }
            return true;
        }
    }
}