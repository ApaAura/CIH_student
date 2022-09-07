namespace Problema_2
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
        Label lb3;
        PictureBox pictureBox1;
        Button bt1;
        private void Default()
        {
            Size = new Size(400, 300);
            Font = new Font("Verdana", 14);
            Text = "Problema 1";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            Label lb = new Label();
            lb.Text = "Lungimea :";
            lb.Location = new Point(50, 30);
            lb.Size = new Size(120, 30);
            Controls.Add(lb);

            Label lb1 = new Label();
            lb1.Text = "Latimea :";
            lb1.Location = new Point(50, 80);
            lb1.Size = new Size(120, 30);
            Controls.Add(lb1);

            tb = new TextBox();
            tb.Location = new Point(170, 30);
            tb.Size = new Size(100, 30);
            tb.KeyPress += Tb_KeyPress;
            Controls.Add(tb);

            tb1 = new TextBox();
            tb1.Location = new Point(170, 80);
            tb1.Size = new Size(100, 30);
            tb1.KeyPress += Tb1_KeyPress;
            Controls.Add(tb1);

            bt1 = new Button();
            bt1.Location = new Point(100, 170);
            bt1.Size = new Size(130, 40);
            bt1.Text = "Calculeaza";
            bt1.Click += Bt1_Click;
            Controls.Add(bt1);

            lb3 = new Label();
            lb3.Size = new Size(260, 130);
            lb3.Location = new Point(30, 230);
            lb3.BackColor = Color.Aquamarine;
            lb3.Text = "";
            Controls.Add(lb3);

            Label lb4 = new Label();
            lb4.Location = new Point(400, 30);
            lb4.Size = new Size(200, 50);
            lb4.Text = "Desenul figurii: ";
            Controls.Add(lb4);

            pictureBox1 = new PictureBox();
            pictureBox1.Location = new Point(330, 80);
            pictureBox1.Size = new Size(300, 250);
            pictureBox1.BackColor = Color.LightGray;
            Controls.Add(pictureBox1);
        }
        private void Tb1_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar>='0')&&(e.KeyChar<='9'))
            {
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar==(char)Keys.Enter)
                {
                    bt1.Focus();
                }
                return;
            }
            e.Handled = true;
        }

        private void Tb_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    bt1.Focus();
                }
                return;
            }
            e.Handled = true;
        }
        private void Bt1_Click(object? sender, EventArgs e)
        {
            try
            {
                int lungimea = int.Parse(tb.Text);
                int latimea = int.Parse(tb1.Text);
                int perimetru = (lungimea+latimea)*2;
                double aria = lungimea * latimea;
                lb3.Text = $"Langimea= {lungimea}\nLatimea = {latimea}\nAria = {aria:F3}\nPerimetrul = {perimetru}";
                tb.Text = "";
                tb1.Text = "";
                pictureBox1.Refresh();
                using (Graphics d = pictureBox1.CreateGraphics())
                {
                    Pen bluePen = new Pen(Color.Blue, 2);
                    d.DrawRectangle(bluePen, lungimea,latimea,lungimea,latimea);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Introdu dimensiunile !");
            }
        }
    }
}