namespace Problema_7
{
    public partial class Form1 : Form
    {
        //RadioButton - Exemplu de utilizare 
        Label label;
        TextBox text;
        GroupBox Gen;
        GroupBox StareCivila;
        RadioButton Rd1;
        RadioButton Rd2;
        RadioButton Rd3;
        RadioButton Rd4;
        public Form1()
        {
            InitializeComponent();
            Default();
        }
        private void Default()
        {
            Font = new Font("Verdana", 12);
            Size = new Size(400, 400);
            Text = "Problema 7";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            GroupBox GrupMare = new GroupBox();
            GrupMare.Text = "Formular";
            GrupMare.Location = new Point(30,30);
            GrupMare.Size = new Size(320,300);

            label = new Label();
            label.Text = "Nume Prenume";
            label.Location = new Point(20,35);
            label.Size = new Size(150, 20);
            GrupMare.Controls.Add(label);

            text=new TextBox();
            text.Location = new Point(20,60);
            text.Size = new Size(280,35);
            GrupMare.Controls.Add(text);

            Gen = new GroupBox();
            Gen.Location = new Point(30,130);
            Gen.Size = new Size(130,100);
            Gen.Text = "Genul : ";
            Gen.Controls.Add(Rd1);
            Gen.Controls.Add(Rd2);

            Rd1 = new RadioButton();
            Rd1.Location = new Point(20,30);
            Rd1.Size = new Size(80,20);
            Rd1.Text = "Feminin";
            Rd1.Font = new Font("Verdana", 8);
            Rd1.Click += Gen_Click;
            Gen.Controls.Add(Rd1);

            Rd2 = new RadioButton();
            Rd2.Location = new Point(20,60);
            Rd2.Size = new Size(80,20);
            Rd2.Text = "Masculin";
            Rd2.Font = new Font("Verdana", 8);
            Rd2.Click += Gen_Click;
            Gen.Controls.Add(Rd2);

            GrupMare.Controls.Add(Gen);

            StareCivila= new GroupBox();
            StareCivila.Location = new Point(175,130);
            StareCivila.Size = new Size(120,100);
            StareCivila.Text = "Stare civila";

            Rd3 = new RadioButton();
            Rd3.Location = new Point(20, 30);
            Rd3.Size = new Size(80, 20);
            Rd3.Text = "Casatorit";
            Rd3.Font = new Font("Verdana", 8);
            Rd3.Click += Stare_Click;
            StareCivila.Controls.Add(Rd3);

            Rd4 = new RadioButton();
            Rd4.Location = new Point(20, 60);
            Rd4.Size = new Size(95, 20);
            Rd4.Text = "Necasatorit";
            Rd4.Font = new Font("Verdana", 8);
            Rd4.Click += Stare_Click;
            StareCivila.Controls.Add(Rd4);

            GrupMare.Controls.Add(StareCivila);

            Button button=new Button();
            button.Location = new Point(20,250);
            button.Size = new Size(280,40);
            button.Text = "Submit";
            button.BackColor= Color.Gray;
            button.Click += Button_Click;
            GrupMare.Controls.Add(button);

            Controls.Add(GrupMare);
        }
        ParticipantFormular participant = new ParticipantFormular();
        private void Button_Click(object? sender, EventArgs e)
        {
            participant.Nume = text.Text;
            MessageBox.Show($"Participant : {participant.Nume}\n" +
                $"Genul : {participant.Genul}\n" +
                $"Starea civila : {participant.StareaCivila}");
        }
        private void Stare_Click(object? sender, EventArgs e)
        {
            participant.StareaCivila = (sender as RadioButton).Text;
        }
        private void Gen_Click(object? sender, EventArgs e)
        {
            participant.Genul = (sender as RadioButton).Text;
        }

    }
}