namespace B17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Default();
        }
        TextBox textBox1;
        RichTextBox textBox2;
        private void Default()
        {
            Font = new Font("Verdana", 12);
            Size = new Size(500, 400);
            Text = "Biletul 17";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            Label label=new Label();
            label.Font = new Font("Bold", 14);
            label.Text = "Creaza o postare: ";
            label.Location = new Point(30,30);
            label.Size = new Size(200,30);
            Controls.Add(label);

            Label label1 = new Label();
            label1.Text = "Titlul postarii:";
            label1.Size = new Size(180,20);
            label1.Location = new Point(30,70);
            Controls.Add(label1);

            textBox1 = new TextBox();
            textBox1.Size = new Size(250,30);
            textBox1.Location = new Point(30,90);
            Controls.Add(textBox1);

            Label label2 = new Label();
            label2.Text = "Continutul (Maxim 250 de caractere)";
            label2.Size = new Size(350,20);
            label2.Location = new Point(30,140);
            Controls.Add(label2);

            textBox2 = new RichTextBox();
            textBox2.Size = new Size(420,90);
            textBox2.Location = new Point(30,160);
            Controls.Add(textBox2);

            CheckBox checkBox3 = new CheckBox();
            checkBox3.Checked = false;
            checkBox3.Text = "Marcheaza postarea ca important";
            checkBox3.Location = new Point(30,260);
            checkBox3.Size = new Size(400,30);
            Controls.Add(checkBox3);

            Button button2 = new Button();
            button2.Text = "Trimite";
            button2.Location = new Point(340,300);
            button2.Size = new Size(100,30);
            button2.Click += Button2_Click;
            Controls.Add(button2);
        }
        private void Button2_Click(object? sender, EventArgs e)
        {
            string titlu = textBox1.Text;
            string continut= textBox2.Text;
            MessageBox.Show($"Titlu: {titlu}\nContinut: {continut}");
        }
    }
}