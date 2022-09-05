namespace Problema_2
{
    public partial class Form1 : Form
    {
        //Label - Exemplu de utilizare
        Label label;
        public Form1()
        {
            InitializeComponent();
            Default();
        }
        private void Default()
        {
            Font = new Font("Verdana", 16);
            Size = new Size(400, 400);
            Text = "Problema 2";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            Button buttonPlus = new Button();
            buttonPlus.Location = new Point(90,180);
            buttonPlus.Size = new Size(70,70); 
            buttonPlus.Text = "+1";
            buttonPlus.Click += ButtonPlus_Click;
            Controls.Add(buttonPlus);

            Button buttonMinus = new Button();
            buttonMinus.Location = new Point(230, 180);
            buttonMinus.Size = new Size(70, 70);
            buttonMinus.Text = "-1";
            buttonMinus.Click += ButtonMinus_Click;
            Controls.Add(buttonMinus);

            label = new Label();
            label.Size = new Size(150,90);
            label.Text = "Contor : ";
            label.Location = new Point(150,130);
            Controls.Add(label);
        }

        int valoareContor = 0;
        private void ButtonMinus_Click(object sender, EventArgs e)
        {
            valoareContor--;
            label.Text = $"Contor: {valoareContor}";
        }
        private void ButtonPlus_Click(object sender, EventArgs e)
        {
            valoareContor++;
            label.Text = $"Contor: {valoareContor}";
        }

    }
}