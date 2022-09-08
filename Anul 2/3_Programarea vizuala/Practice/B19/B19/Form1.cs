namespace B19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Default();
        }
        TextBox textBox1, textBox2, textBox3;
        DateTimePicker dateTimePicker;
        RichTextBox textBox6;
        private void Default()
        {
            Font = new Font("Verdana", 12);
            Size = new Size(550, 380);
            Text = "Biletul 19";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            Label label=new Label();
            label.Text = "Raporteaza un produs";
            label.Font = new Font("Bold", 13);
            label.Size = new Size(250,30);
            label.Location = new Point(30,20);
            Controls.Add(label);

            Label label1 =new Label();
            label1.Text = "Numele Dumneavoastra";
            label1.Size = new Size(230,20);
            label1.Location = new Point(30,70);
            Controls.Add(label1);

            textBox1 = new TextBox();
            textBox1.Size = new Size(180,30);
            textBox1.Location = new Point(30,90);
            Controls.Add(textBox1);

            Label label2 =new Label();
            label2.Text = "Produs achizitionat";
            label2.Size = new Size(230,20);
            label2.Location = new Point(30,150);
            Controls.Add(label2);

            textBox2 = new TextBox();
            textBox2.Size = new Size(180,30);
            textBox2.Location = new Point(30,170);
            Controls.Add(textBox2);

            Label label3 =new Label();
            label3.Text = "Adresa magazinului";
            label3.Size = new Size(230,20);
            label3.Location = new Point(30,230);
            Controls.Add(label3);

            textBox3 = new TextBox();
            textBox3.Size = new Size(180,30);
            textBox3.Location = new Point(30,250);
            Controls.Add(textBox3);

            Label label4 =new Label();
            label4.Text = "Data achizitiei";
            label4.Size = new Size(180,20);
            label4.Location = new Point(265,70);
            Controls.Add(label4);

            dateTimePicker = new DateTimePicker();
            dateTimePicker.Size = new Size(140,30);
            dateTimePicker.Location = new Point(265,90);
            Controls.Add(dateTimePicker);

            Label label5 =new Label();
            label5.Text = "Descrierea defectului";
            label5.Size = new Size(220,20);
            label5.Location = new Point(265,150);
            Controls.Add(label5);

            textBox6 = new RichTextBox();
            textBox6.Size = new Size(230,90);
            textBox6.Location=new Point(265,170);
            Controls.Add(textBox6);

            Button button2 = new Button();
            button2.Text = "Trimite";
            button2.Location = new Point(340,290);
            button2.Size=new Size(120,30);
            button2.BackColor = Color.Aquamarine;
            button2.Click += Button2_Click;
            Controls.Add(button2);
        }
        private void Button2_Click(object? sender, EventArgs e)
        {
            string Nume=textBox1.Text;
            string Produs=textBox2.Text;
            string Adresa=textBox3.Text;
            object Data = dateTimePicker.Value;
            string Defect = textBox6.Text;
            MessageBox.Show($"Numele clientului: {Nume}\nProdus achizitionat : {Produs}\nAdresa magazinului : {Adresa}\nData achizitiei : {Data}\nDescrierea defectului : {Defect}");
            
        }
    }
}