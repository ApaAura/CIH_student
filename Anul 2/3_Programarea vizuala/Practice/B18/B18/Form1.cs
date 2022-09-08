namespace B18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Default();
        }
        ListBox listBox;
        TextBox text;
        Label label3;
        private void Default()
        {
            Font = new Font("Verdana", 12);
            Size = new Size(480, 350);
            Text = "Biletul 18";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            Label label = new Label();
            label.Text = "Comanda un produs";
            label.Location = new Point(30, 30);
            label.Size = new Size(200, 30);
            Controls.Add(label);

            Label label1 = new Label();
            label1.Text = "Alegeti un produs";
            label1.Location = new Point(30, 80);
            label1.Size = new Size(180, 30);
            Controls.Add(label1);

            listBox = new ListBox();
            listBox.Size = new Size(170, 100);
            listBox.Location = new Point(30, 110);
            listBox.Items.Add("Mere (20 lei)");
            listBox.Items.Add("Mandarine (35 lei)");
            listBox.Items.Add("Prune (40 lei)");
            listBox.Items.Add("Pere (22 lei)");
            Controls.Add(listBox);

            Label label2 = new Label();
            label2.Text = "Cantitate(KG)";
            label2.Location = new Point(240, 80);
            label2.Size = new Size(180, 30);
            Controls.Add(label2);

            text = new TextBox();
            text.Location = new Point(240, 110);
            text.Size = new Size(180, 40);
            Controls.Add(text);

            Button button1 = new Button();
            button1.Location = new Point(270, 160);
            button1.Size = new Size(120, 30);
            button1.Text = "Determina pretul";
            button1.Click += Button1_Click;
            Controls.Add(button1);

            label3 = new Label();
            label3.Text = "Pret: ";
            label3.Size = new Size(120, 30);
            label3.Location = new Point(275, 200);
            Controls.Add(label3);

            Button button = new Button();
            button.Location = new Point(150, 240);
            button.Size = new Size(180, 50);
            button.BackColor = Color.Aquamarine;
            button.Text = "Trimite";
            button.Click += Button_Click;
            Controls.Add(button);
        }
        private void Button1_Click(object? sender, EventArgs e)
        {
            string lista = listBox.SelectedItem.ToString();
            int kg = int.Parse(text.Text);
            switch (lista)
            {
                case "Mere (20 lei)": label3.Text = $"Pret: {20 * kg}"; break;
                case "Mandarine (35 lei)": label3.Text = $"Pret: {35 * kg}"; break;
                case "Prune (40 lei)": label3.Text = $"Pret: {40 * kg}"; break;
                case "Pere (22 lei)": label3.Text = $"Pret: {22 * kg}"; break;
                default:
                    MessageBox.Show("Nu ati facut o selectie.");
                    break;
            }
        }
        private void Button_Click(object? sender, EventArgs e)
        {
            string lista = listBox.SelectedItem.ToString();
            int kg = int.Parse(text.Text);
            MessageBox.Show($"Produs : {lista}\nCantitate : {kg} kg\n{label3.Text}");
        }
    }
}