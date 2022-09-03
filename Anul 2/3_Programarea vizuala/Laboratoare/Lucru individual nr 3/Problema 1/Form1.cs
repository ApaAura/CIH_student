namespace Problema_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Default();
        }
        RadioButton Rd1;
        RadioButton Rd2;
        TextBox textBox;
        TextBox textBox1;
        TextBox textBox2;
        ListBox listBox;
        private void Default()
        {
            Font = new Font("Verdana", 12);
            Size = new Size(480, 400);
            Text = "Problema 1";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            Label label=new Label();
            label.Text = "Nume";
            label.Location = new Point(30,30);
            label.Size = new Size(100,20);
            Controls.Add(label);

            textBox = new TextBox();
            textBox.Location = new Point(30,50);
            textBox.Size = new Size(180,50);
            Controls.Add(textBox);

            Label label1 = new Label();
            label1.Text = "Varsta";
            label1.Location= new Point(250,30);
            label1.Size= new Size(100,20);
            Controls.Add(label1);

            textBox1 = new TextBox();
            textBox1.Location = new Point(250,50);
            textBox1.Size = new Size(180,50);
            Controls.Add(textBox1);

            Label label2 = new Label();
            label2.Text = "Prenume";
            label2.Location= new Point(30,100);
            label2.Size = new Size(100,20);  
            Controls.Add(label2);

            textBox2 = new TextBox();
            textBox2.Location = new Point(30,120);
            textBox2.Size = new Size(180,50);
            Controls.Add(textBox2);

            GroupBox Gen = new GroupBox();
            Gen.Location = new Point(30, 160);
            Gen.Size = new Size(180, 100);
            Gen.Text = "Genul : ";
            Gen.Controls.Add(Rd1);
            Gen.Controls.Add(Rd2);
            Controls.Add(Gen);

            Rd1 = new RadioButton();
            Rd1.Location = new Point(20, 30);
            Rd1.Size = new Size(100, 20);
            Rd1.Text = "Feminin";
            Rd1.Click += Gen_Click;
            Gen.Controls.Add(Rd1);

            Rd2 = new RadioButton();
            Rd2.Location = new Point(20, 60);
            Rd2.Size = new Size(100, 20);
            Rd2.Text = "Masculin";
            Rd2.Click += Gen_Click;
            Gen.Controls.Add(Rd2);

            Label label4 = new Label();
            label4.Text = "Orasul natal";
            label4.Location= new Point(250,100);
            label4.Size = new Size(100, 20);
            Controls.Add(label4);

            TextBox textBox4 = new TextBox();
            textBox4.Location = new Point(250,120);
            textBox4.Size = new Size(180, 50);
            textBox4.Text = "                          ^";
            Controls.Add(textBox4);

            listBox = new ListBox();
            listBox.Size = new Size(178,120);
            listBox.Location = new Point(251,148);
            listBox.Items.Add("Chisinau");
            listBox.Items.Add("Cahul");
            listBox.Items.Add("Hincesti");
            listBox.Items.Add("Comrat");
            listBox.Items.Add("Orhei");
            listBox.Items.Add("Leova");
            Controls.Add(listBox);

            Button button = new Button();
            button.Location = new Point(150,280);
            button.Size = new Size(180,50);
            button.BackColor = Color.Aquamarine;
            button.Text = "Trimite";
            button.Click += Button_Click;
            Controls.Add(button);
        }
        ParticipantFormular participant = new ParticipantFormular();
        private void Gen_Click(object? sender, EventArgs e)
        {
            participant.Genul = (sender as RadioButton).Text;
        }
        private void Button_Click(object? sender, EventArgs e)
        {
            participant.Nume = textBox.Text;
            participant.Prenume = textBox2.Text;
            participant.Varsta=int.Parse(textBox1.Text);
            MessageBox.Show($"Nume : {participant.Nume}\n" +
                $"Prenume: {participant.Prenume}\n"+
                $"Genul : {participant.Genul}\n"+
                $"Varsta : {participant.Varsta}\n");
        }
    }
}