namespace Problema_3
{
    public partial class Form1 : Form
    {
        //TextBox - Exemplu de utilizare
        TextBox Scrie;
        Label NrCaractere;
        public Form1()
        {
            InitializeComponent();
            Default();
        }
        private void Default()
        {
            Font = new Font("Verdana", 12);
            Size = new Size(400, 400);
            Text = "Problema 3";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            Scrie = new TextBox();
            Scrie.Size = new Size(200,50);
            Scrie.Location = new Point(100,170);
            Scrie.TextChanged += Scrie_TextChanged;
            Controls.Add(Scrie);

            NrCaractere=new Label();
            NrCaractere.Text = "Caractere introduse : ";
            NrCaractere.Size = new Size(240,50);
            NrCaractere.Location = new Point(100, 145);
            Controls.Add(NrCaractere);
        }
        private void Scrie_TextChanged(object sender, EventArgs e)
        {
            string textulIntrodus = Scrie.Text;
            NrCaractere.Text = "Caractere introduse : "+textulIntrodus.Length.ToString();
        }
    }
}