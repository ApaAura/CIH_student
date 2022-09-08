namespace B28
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Default();
        }
        TextBox textBox, textBox2, textBox3;
        Label label4;
        private void Default()
        {
            Font = new Font("Verdana", 12);
            Size = new Size(500, 300);
            Text = "Biletul 28";
            this.BackColor = Color.White;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            Label label = new Label();
            label.Text = "Validare triunghi";
            label.Font =new Font ("Bold", 14);
            label.Size = new Size(180, 30);
            label.Location = new Point(30,30);
            Controls.Add(label);

            Label label1 = new Label();
            label1.Text = "Latura 1";
            label1.Size = new Size(100, 30);
            label1.Location = new Point(30, 100);
            Controls.Add (label1);

            textBox = new TextBox();
            textBox.Size = new Size(80,30);
            textBox.Location = new Point(30,130);
            Controls.Add(textBox);

            Label label2 = new Label();
            label2.Text = "Latura 2";
            label2.Size = new Size(80, 30);
            label2.Location = new Point(140, 100);
            Controls.Add (label2);

            textBox2 = new TextBox();
            textBox2.Size = new Size(80, 30);
            textBox2.Location = new Point(140, 130);
            Controls.Add(textBox2);

            Label label3 = new Label();
            label3.Text = "Latura 3";
            label3.Size = new Size(80, 30);
            label3.Location = new Point(250, 100);
            Controls.Add (label3);

            textBox3 = new TextBox();
            textBox3.Size = new Size(80, 30);
            textBox3.Location = new Point(250, 130);
            Controls.Add(textBox3);

            Button button1 = new Button();
            button1.Text = "Verifica";
            button1.Size = new Size(130,35);
            button1.Location = new Point(340,127);
            button1.BackColor = Color.Aquamarine;
            button1.Click += Button1_Click;
            Controls.Add(button1);

            label4 = new Label();
            label4.Text = "";
            label4.Size = new Size(200, 50);
            label4.Location = new Point(150, 200);
            Controls.Add(label4);
        }
        private void Button1_Click(object? sender, EventArgs e)
        {
            int n1 = int.Parse(textBox.Text);
            int n2=int.Parse(textBox2.Text);
            int n3=int.Parse(textBox3.Text);    
            if ((n1+n2>n3)&&(n1+n3>n2)&&(n2+n3>n1))
            {
                label4.Text = "Dimensiunile pot forma\n       un triunghi";
            }
            else label4.Text = "Nu poate exista un\n astfel de triunghi";
        }
    }
}