namespace Problema_4
{
    public partial class Form1 : Form
    {
        /*
         Vom simula modul de lucru al butoanelor upvote / downvote de pe stackoverflow.com.
         Amplasați două butoane și un label pe suprața ferestrei
         Butonul ⮝ – Va incrementa cu o unitate numărul de voturi
         Butonul ⮟ – Va decrementa cu o unitate numărul de voturi
         Label – Va afișa numărul de voturi cu roșu – dacă numărul este negativ,
         Negru – 0, verde – pozitiv.
         Eliminați border-urile butoanelor pentru un efect mai estetic.
         */
        public Form1()
        {
            InitializeComponent();
            Default();
            UdateLabel();
        }
        Label label1;
        private int count = 0;
        public int Count { get { return count; } set { count = value; UdateLabel(); } }
        private void Default()
        {
            Font = new Font("Verdana", 16);
            Size = new Size(400, 400);
            BackColor = Color.WhiteSmoke;
            Text = "Problema 4";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            Button buttonPlus=new Button();
            buttonPlus.Location = new Point(160,75);
            buttonPlus.Size = new Size(70,70);
            buttonPlus.Text = "▲";
            buttonPlus.Font = new Font("Verdana", 20);
            buttonPlus.Click += ButtonPlus_Click;
            buttonPlus.TabStop = false;
            buttonPlus.FlatStyle = FlatStyle.Flat;
            buttonPlus.FlatAppearance.BorderSize = 0;
            Controls.Add(buttonPlus);

            Button buttonMinus=new Button();
            buttonMinus.Location = new Point(160, 205);
            buttonMinus.Size = new Size(70, 70);
            buttonMinus.Text = "▼";
            buttonMinus.Font = new Font("Verdana", 20);
            buttonMinus.Click += ButtonMinus_Click;
            buttonMinus.TabStop = false;
            buttonMinus.FlatStyle = FlatStyle.Flat;
            buttonMinus.FlatAppearance.BorderSize = 0;
            Controls.Add(buttonMinus);

            label1=new Label();
            label1.Location = new Point(180, 160);
            label1.Size = new Size(60,60);
            Controls.Add(label1);
        }
        private void ButtonMinus_Click(object? sender, EventArgs e)
        {
            Count--;
        }
        private void ButtonPlus_Click(object? sender, EventArgs e)
        {
            Count++;
        }
        private void UdateLabel()
        {
            if (Count < 0)
            {
               label1.ForeColor = Color.Red;
            }
            if (Count == 0)
            {
                label1.ForeColor = Color.Black;
            }
            if (Count > 0)
            {
                label1.ForeColor = Color.Green;
            }
            label1.Text = $"{Count}";
        }
    }
}