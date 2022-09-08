namespace B6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Default();
        }
        TextBox textBox, textBox1, textBox2;
        ComboBox comboBox;
        private void Default()
        {
            Font = new Font("Verdana", 12);
            Size = new Size(600, 250);
            Text = "Biletul 6";
            this.BackColor = Color.White;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            Label label=new Label();
            label.Text = "Primul operand";
            label.Location = new Point(30,50);
            label.Size = new Size(140,30);
            Controls.Add(label);

            textBox = new TextBox();
            textBox.Size = new Size(130,30);
            textBox.Location = new Point(30,80);
            Controls.Add(textBox);

            Label label1 = new Label();
            label1.Text = "Operatia";
            label1.Location = new Point(175,50);
            label1.Size = new Size(95, 30);
            Controls.Add(label1);

            comboBox = new ComboBox();
            comboBox.Size = new Size(90,30);
            comboBox.Location = new Point(170,80);
            comboBox.Items.Add("+");
            comboBox.Items.Add("-");
            comboBox.Items.Add("*");
            comboBox.Items.Add("/");
            comboBox.SelectionChangeCommitted += ComboBox_SelectionChangeCommitted;
            Controls.Add(comboBox);

            Label label2 = new Label();
            label2.Text = "Al doilea operand";
            label2.Location = new Point(270,50);
            label2.Size = new Size(160, 30);
            Controls.Add(label2);

            textBox1=new TextBox();
            textBox1.Size = new Size(140, 30);
            textBox1.Location = new Point(275, 80);
            Controls.Add(textBox1);

            Label label4 = new Label();
            label4.Text = "=";
            label4.Location = new Point(425,80);
            label4.Size = new Size(30,30);
            Controls.Add(label4);

            Label label3 = new Label();
            label3.Location = new Point(470,50);
            label3.Size = new Size(100, 30);
            label3.Text = "Rezultat";
            Controls.Add(label3);

            textBox2 = new TextBox();
            textBox2.Size = new Size(100, 30);
            textBox2.Location = new Point(460, 80);
            textBox2.Text = "";
            textBox2.Enabled = false;
            Controls.Add(textBox2);
        }
        private void ComboBox_SelectionChangeCommitted(object? sender, EventArgs e)
        {
            object selected = comboBox.SelectedItem;
            double n =double.Parse(textBox.Text);
            double m = double.Parse(textBox1.Text);
            switch (selected)
            {
                case "+": textBox2.Text = $"{n+m}"; break;
                case "-": textBox2.Text = $"{n-m}"; break;
                case "*": textBox2.Text = $"{n*m}"; break;
                case "/": textBox2.Text = $"{n/m}"; break;
                default:
                    break;
            }
        }
    }
}