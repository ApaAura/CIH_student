namespace B26
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Default();
        }
        RichTextBox textBox;
        private void Default()
        {
            Font = new Font("Verdana", 13);
            Size = new Size(500, 360);
            Text = "Biletul 26";
            this.BackColor = Color.White;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            Label label=new Label();
            label.Text = "Introduceti textul : ";
            label.Size = new Size(190,30);
            label.Location = new Point(50,40);
            Controls.Add(label);
            
            textBox = new RichTextBox();
            textBox.Text = "";
            textBox.Size = new Size(385,160);
            textBox.Location = new Point(50,70);
            Controls.Add(textBox);

            Button button = new Button();
            button.Text = "Elimina cifrele: ";
            button.Size = new Size(200,40);
            button.Location = new Point(140,250);
            button.BackColor = Color.Aquamarine;
            button.Click += Button_Click;
            Controls.Add(button);
        }
        private void Button_Click(object? sender, EventArgs e)
        {
            string text=textBox.Text;
            string cifre = "1234567890";
            string faraCifre = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (cifre.Contains(text[i]))
                {
                    faraCifre += " ";
                }
                else faraCifre += text[i];
            }
            textBox.Text = $"{faraCifre}";
        }
    }
}