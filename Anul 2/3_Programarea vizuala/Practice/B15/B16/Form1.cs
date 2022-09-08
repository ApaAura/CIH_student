namespace B16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Default();
        }
        TextBox textBox, textBox2, textBox1;
        DateTimePicker dateTimePicker;
        CheckBox checkBox, checkBox2, checkBox3;
        private void Default()
        {
            Font = new Font("Verdana", 12);
            Size = new Size(500, 380);
            Text = "Biletul 15";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            Label label=new Label();
            label.Text = "Nume";
            label.Location = new Point(30,40);
            label.Size = new Size(100,20);
            Controls.Add(label);

            textBox = new TextBox();
            textBox.Location = new Point(30,60);
            textBox.Size = new Size(160,30);
            Controls.Add(textBox);

            Label label1 = new Label();
            label1.Text = "Prenume";
            label1.Location = new Point(30, 120);
            label1.Size = new Size(100,20);
            Controls.Add(label1);

            textBox2 = new TextBox();
            textBox2.Location = new Point(30,140);
            textBox2.Size = new Size(160,30);
            Controls.Add(textBox2);

            Label label2 = new Label();
            label2.Location = new Point(30,200);
            label2.Size = new Size(100,20);
            label2.Text = "Email";
            Controls.Add(label2);

            textBox1= new TextBox();
            textBox1.Location = new Point(30,220);
            textBox1.Size = new Size(160,30);
            Controls.Add(textBox1);

            Label label3 = new Label();
            label3.Location = new Point(240,40);
            label3.Size = new Size(220,40);
            label3.Text = "Limbaje de programare \n        cunoscute";
            Controls.Add(label3);
             
            checkBox = new CheckBox();
            checkBox.Location = new Point(240,90);
            checkBox.Size = new Size(100,20);
            checkBox.Text = "C#";
            Controls.Add(checkBox);

            checkBox2 = new CheckBox();
            checkBox2.Text = "JavaScript";
            checkBox2.Location = new Point(240,115);
            checkBox2.Size = new Size(100,20);
            Controls.Add(checkBox2);

            checkBox3 = new CheckBox();
            checkBox3.Location = new Point(240,140);
            checkBox3.Size = new Size(100, 20);
            checkBox3.Text = "Python";
            Controls.Add(checkBox3);

            Label label4 = new Label();
            label4.Text = "Data nasterii: ";
            label4.Location = new Point(240,200);
            label4.Size = new Size(150,20);
            Controls.Add(label4);

            dateTimePicker = new DateTimePicker();
            dateTimePicker.Location = new Point(240,220);
            dateTimePicker.Size = new Size(180,30);
            Controls.Add(dateTimePicker);

            Button button=new Button();
            button.Text = "Trimite";
            button.Location=new Point(250,270);
            button.Size = new Size(130,30);
            button.Click += Button_Click;
            button.BackColor = Color.Aquamarine;
            Controls.Add(button);
        }
        private void Button_Click(object? sender, EventArgs e)
        {
            string Nume = textBox.Text;
            string Prenume= textBox2.Text;
            string Email = textBox1.Text;
            object date = dateTimePicker.Value;
            string limbaje = "";
            if (checkBox.Checked == true)
            {
                limbaje += "C# ";
            }
            if (checkBox2.Checked == true)
            {
                limbaje += "JavaScript ";
            }
            if (checkBox3.Checked == true)
            {
                limbaje += "Python ";
            }
            MessageBox.Show($"Nume : {Nume}\nPrenume : {Prenume}\nEmail : {Email}\nLimbaje de programare : {limbaje}\nData nasterii : {date}");
        }
    }
}