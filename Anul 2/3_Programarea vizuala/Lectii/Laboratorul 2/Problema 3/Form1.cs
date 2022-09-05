namespace Problema_3
{
    /*
     Amplasați pe suprafața ferestrei un RichTextBox și un label. Label-ul va fi folosit pentru a indica 
    numărul de caractere introduse în RichTextBox. Numărul de caractere maxim admis este 50 (Utilizatorul 
    nu va putea introduce mai mult de 50 de caractere), iar label-ul va afișa informația în formatul: 
    `Caractere introduse: x / 50`, unde x este numarul de caractere introduse in RichTextBox. 
    Acest numar este actualizat de fiecare data cand utilizatorul insereaza sau elimina un caracter.
     */
    public partial class Form1 : Form
    {
        Label lbText;
        RichTextBox RichTx;
        public Form1()
        {
            InitializeComponent();
            LoadElements();
        }
        private void LoadElements()
        {
            Size = new Size(400, 400);
            Text = "Laboratorul2";
            BackColor = Color.Azure;
            this.StartPosition = FormStartPosition.CenterScreen;
            
            Label Text1 = new Label();
            Text1.Text = "Introduceti un mesaj: ";
            Text1.Font = new Font("Arial", 16, FontStyle.Bold);
            Text1.Size = new Size(230, 30);
            Text1.ForeColor = Color.Turquoise;
            Text1.Location = new Point(90, 90);
            Controls.Add(Text1);

            RichTx = new RichTextBox();
            RichTx.Location = new Point(135, 120);
            RichTx.Size = new Size(120, 60);
            RichTx.TextChanged += RichTx_TextChanged;
            Controls.Add(RichTx);

            lbText= new Label();
            lbText.Location = new Point(130,190);
            lbText.Size = new Size(230, 30);
            lbText.Text = $"Caractere introduse: {RichTx.Text.Length}/50";
            Controls.Add(lbText);
        }

        private void RichTx_TextChanged(object? sender, EventArgs e)
        {
            if (RichTx.Text.Length>50)
            {
                lbText.ForeColor = Color.Red;
                lbText.Text = $"Caractere introduse: {RichTx.Text.Length}/50";
                return;
            }
            lbText.ForeColor = Color.Black;
            lbText.Text = $"Caractere introduse: {RichTx.Text.Length}/50";
        }
    }
}