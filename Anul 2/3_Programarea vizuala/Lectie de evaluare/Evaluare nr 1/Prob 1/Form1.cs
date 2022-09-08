namespace Prob_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Default();
        }
        CheckBox CheckBox1;
        CheckBox CheckBox2;
        CheckBox CheckBox3;
        Label lblRezultat;
        private void Default()
        {
            this.Font = new Font("Verdana",14);
            Text = "Completatia Automobilului";
            Size = new Size(600, 430);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            Label Label1 = new Label();
            Label1.Font =new Font ("Verdana", 18);
            Label1.Text = "Scoda Fabia";
            Label1.Location = new Point(30, 20);
            Label1.Size = new Size(400,40);
            Controls.Add(Label1);

            Label Label2 = new Label();
            Label2.Font = new Font("Verdana", 16);
            Label2.Text = "Pretul completatiei de baza : 250 000 lei";
            Label2.Location = new Point(30,60); ;
            Label2.Size = new Size(450,40);
            Controls.Add(Label2);

            GroupBox GroupBox1= new GroupBox();
            GroupBox1.Text = "Facilitati suplimentare:";
            GroupBox1.BackColor = Color.LightYellow;
            GroupBox1.Location = new Point(30,112);
            GroupBox1.Size = new Size(250,150);

            CheckBox1= new CheckBox();
            CheckBox1.Text = "ABS";
            CheckBox1.Location = new Point(20,20);
            CheckBox1.Size = new Size(100,40);
            CheckBox1.Checked = false;
            CheckBox1.CheckedChanged += CheckBox1_CheckedChanged;

            CheckBox2= new CheckBox();
            CheckBox2.Text = "Parctronic";
            CheckBox2.Location = new Point(20,60);
            CheckBox2.Size = new Size(100,40);
            CheckBox2.Checked = false;

            CheckBox3 = new CheckBox();
            CheckBox3.Location = new Point(20,100);
            CheckBox3.Size = new Size(100, 40);
            CheckBox3.Text = "Securitate";
            CheckBox3.Checked = false;

            GroupBox1.Controls.Add(CheckBox1);
            GroupBox1.Controls.Add(CheckBox2);
            GroupBox1.Controls.Add(CheckBox3);

            Controls.Add(GroupBox1);
           
            Button Button1= new Button();
            Button1.Text = "Calculeaza";
            Button1.Location = new Point(60,270);
            Button1.Size = new Size(200,45);
            Button1.Click += Button1_Click;
            Controls.Add(Button1);
            
            PictureBox pbImage= new PictureBox();
            pbImage.Location = new Point();
            pbImage.Image = new Bitmap("image.png");
            pbImage.Size = new Size(300,200);
            pbImage.Location = new Point(300,100);
            Controls.Add(pbImage);

            lblRezultat=new Label();
            lblRezultat.Text = "Pret final: ";
            lblRezultat.Location = new Point(40,325);
            lblRezultat.Size = new Size(250,40);
            lblRezultat.BackColor = Color.Green;
            Controls.Add(lblRezultat);
        }
        private void Button1_Click(object? sender, EventArgs e)
        {
            int Price = 250000;
            if (CheckBox1.Checked)
            {
                Price += 15000;
            }
            if (CheckBox2.Checked)
            {
                Price += 20000;
            }
            if (CheckBox3.Checked)
            {
                Price += 13000;
            }
            lblRezultat.Text = $"Pretul final: {Price}";
        }
        private void CheckBox1_CheckedChanged(object? sender, EventArgs e)
        {
            
        }
    }
}