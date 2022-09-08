namespace B20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Default();
        }
        TextBox textBox, textBox2, textBox3, textBox1, textBox4, textBox5, textBox6;
        ComboBox comboBox;
        Label label9;
        private void Default()
        {
            Font = new Font("Verdana", 12);
            Size = new Size(600, 400);
            Text = "Biletul 20";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            Label label = new Label();
            label.Text = "Admitere Colegiu";
            label.Location = new Point(30,20);
            label.Size = new Size(180, 30);
            label.Font = new Font("Bold", 14);
            Controls.Add(label);

            Label label3 = new Label();
            label3.Text = "Nume Elev";
            label3.Location = new Point(30,55);
            label3.Size = new Size(100, 20);
            Controls.Add(label3);

            textBox = new TextBox();
            textBox.Size = new Size(150,30);
            textBox.Location = new Point(30, 75);
            Controls.Add(textBox);

            Label label1 = new Label();
            label1.Text = "Prenume";
            label1.Location = new Point(210,55);
            label1.Size = new Size(150,20);
            Controls.Add(label1);

            textBox2 = new TextBox();
            textBox2.Size = new Size(150,30);
            textBox2.Location = new Point(210,75);
            Controls.Add(textBox2);

            Label label2 = new Label();
            label2.Text = "Patronimic";
            label2.Size = new Size(180,20); 
            label2.Location = new Point(390,55);
            Controls.Add(label2);

            textBox3 = new TextBox();
            textBox3.Size = new Size(150,30);
            textBox3.Location = new Point(390,75);
            Controls.Add(textBox3);

            Label label4 = new Label();
            label4.Text = "Specialitate";
            label4.Size = new Size(180, 20);
            label4.Location = new Point(30, 130);
            Controls.Add(label4);

            comboBox = new ComboBox();
            comboBox.Items.Add("PAPP");
            comboBox.Items.Add("AAW");
            comboBox.Items.Add("ETE");
            comboBox.Items.Add("E");
            comboBox.Items.Add("C");
            comboBox.Items.Add("IP");
            comboBox.Items.Add("ASL");
            comboBox.Size = new Size(150,100);
            comboBox.Location = new Point(30,150);
            Controls.Add(comboBox);

            Label label5 = new Label();
            label5.Text = "Media Matematica";
            label5.Location = new Point(210,130);
            label5.Size = new Size(150, 20);
            Controls.Add(label5);

            textBox1=new TextBox();
            textBox1.Size = new Size(150, 30);
            textBox1.Location=new Point(210,150);
            Controls.Add(textBox1);

            Label label6 = new Label();
            label6.Text = "Media L.Straina";
            label6.Location = new Point(390,130);
            label6.Size = new Size(150, 20);
            Controls.Add(label6);

            textBox4 = new TextBox();
            textBox4.Size=new Size(150, 30);
            textBox4.Location=new Point(390,150);
            Controls.Add(textBox4);

            Label label7 = new Label();
            label7.Text = "Media L.Romana";
            label7.Size= new Size(150, 20);
            label7.Location=new Point(210,200);
            Controls.Add(label7);

            textBox5 = new TextBox();
            textBox5.Size = new Size(150, 30);
            textBox5.Location = new Point(210,220);
            Controls.Add(textBox5);

            Label label8 = new Label();
            label8.Text = "Media Examene";
            label8.Size = new Size(150, 20);
            label8.Location = new Point(390,200);
            Controls.Add(label8);

            textBox6 = new TextBox();
            textBox6.Size = new Size(150, 30);
            textBox6.Location = new Point(390,220);
            Controls.Add(textBox6);

            Button button = new Button();
            button.Text = "Calculeaza media de concurs";
            button.Size = new Size(180, 50);
            button.Location = new Point(210, 260);
            button.BackColor = Color.Aquamarine;
            button.Click += Button_Click;
            Controls.Add(button);

            label9 = new Label();
            label9.Text = "Media: ";
            label9.Size = new Size(150, 20);
            label9.Location=new Point(410, 275);
            Controls.Add(label9);

            Button button1= new Button();
            button1.Text = "Inregistreaza";
            button1.BackColor=Color.Aquamarine;
            button1.Size = new Size(150,30);
            button1.Location=new Point(310, 320);
            button1.Click += Button1_Click;
            Controls.Add(button1);
        }
        private void Button1_Click(object? sender, EventArgs e)
        {
            string Nume = textBox.Text;
            string Prenume = textBox2.Text;
            string Patronimic= textBox3.Text;
            object Specialitate = comboBox.SelectedItem;
            double MediaMat = double.Parse(textBox1.Text);
            double MediaStraina = double.Parse(textBox4.Text);
            double MediaRom = double.Parse(textBox5.Text);
            double MediaExam = double.Parse(textBox6.Text);
            double Media = (MediaMat + MediaRom + MediaStraina + MediaExam) / 4;
            MessageBox.Show($"Elev: {Nume} {Prenume} {Patronimic}\nSpecialitate: {Specialitate}\nMedia concurs: {Media}");

        }
        private void Button_Click(object? sender, EventArgs e)
        {
            double MediaMat = double.Parse(textBox1.Text);
            double MediaStraina = double.Parse(textBox4.Text);
            double MediaRom = double.Parse(textBox5.Text);
            double MediaExam = double.Parse(textBox6.Text);
            double Media = (MediaMat + MediaRom + MediaStraina + MediaExam) / 4;
            label9.Text = $"Media: {Media}";
        }
    }
}