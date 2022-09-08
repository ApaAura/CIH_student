namespace Biletul_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Default();
;       }
        TextBox textBox, textBox2, textBox3;
        private void Default()
        {
            Font = new Font("Verdana", 12);
            Size = new Size(400, 300);
            Text = "Biletul 11";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            Label label=new Label();
            label.Text = "Triunghi";
            label.Font = new Font("Bold", 14);
            label.Location = new Point(28,30);
            label.Size = new Size(100,30);
            Controls.Add(label);

            Label label1 = new Label();
            label1.Text = "Latura 1";
            label1.Location = new Point(30,90);
            label1.Size = new Size(100,20);
            Controls.Add(label1);

            textBox = new TextBox();
            textBox.Location = new Point(30,110);
            textBox.Size = new Size(80,30);
            textBox.KeyPress += textBox1_KeyPress;
            Controls.Add(textBox);

            Label label2 = new Label();
            label2.Text = "Latura 2";
            label2.Location = new Point(150,90);
            label2.Size = new Size(100,20);
            Controls.Add(label2);

            textBox2 = new TextBox();
            textBox2.Location = new Point(150,110);
            textBox2.Size = new Size(80,30);
            textBox2.KeyPress += textBox1_KeyPress;
            Controls.Add(textBox2);

            Label label3 = new Label();
            label3.Text = "Latura 3";
            label3.Location = new Point(270,90);
            label3.Size = new Size(100,20);
            Controls.Add(label3);

            textBox3 = new TextBox();
            textBox3.Location = new Point(270,110);
            textBox3.Size = new Size(80,30);
            textBox3.KeyPress += textBox1_KeyPress;
            Controls.Add(textBox3);

            Label label4 = new Label();
            label4.Text = "Determinati tipul triunghiului";
            label4.Location = new Point(70,180);
            label4.Size = new Size(250,20);
            Controls.Add(label4);

            Button button=new Button();
            button.Location = new Point(120,200);
            button.Size = new Size(150,30);
            button.Text = "Calcul";
            button.BackColor= Color.Aquamarine;
            button.Click += Button_Click;
            Controls.Add(button);
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void Button_Click(object? sender, EventArgs e)
        {
            int a = int.Parse(textBox.Text);
            int b = int.Parse(textBox2.Text);
            int c = int.Parse(textBox3.Text);
            double putere = Math.Pow(a, 2) + Math.Pow(b, 2);
            double putere1= Math.Pow(a, 2) + Math.Pow(c, 2);
            double putere2=Math.Pow(c, 2) + Math.Pow(b, 2);
            if ((a+b>c)&&(a+c>b)&&(c+b>a))
            {
                //a^2+b^2=c^2 - dreptunghic
                if ((putere == Math.Pow(c, 2))||(putere1==Math.Pow(b,2))||(putere2==Math.Pow(a,2)))
                {
                    MessageBox.Show($"Latura 1 = {a} cm\nLatura 2 = {b} cm\nLatura 3 = {c} cm\nTriunghi dreptunghic");
                }
                //a^2+b^2>c^2 - ascutitunghic
                if ((putere > Math.Pow(c, 2)) || (putere1 > Math.Pow(b, 2)) || (putere2 > Math.Pow(a, 2)))
                {
                    MessageBox.Show($"Latura 1 = {a} cm\nLatura 2 = {b} cm\nLatura 3 = {c} cm\nTriunghi ascutitunghic");
                }
                //a^2+b^2<c^2 - obtuzunghic
                if ((putere < Math.Pow(c, 2)) || (putere1 < Math.Pow(b, 2)) || (putere2 < Math.Pow(a, 2)))
                {
                    MessageBox.Show($"Latura 1 = {a} cm\nLatura 2 = {b} cm\nLatura 3 = {c} cm\nTriunghi obtuzunghic");
                }
            }
            else
            {
                MessageBox.Show("Nu se poate forma un triunghi !");
            }
           
        }
    }
}