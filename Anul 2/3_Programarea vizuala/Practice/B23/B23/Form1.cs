namespace B23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Default();
        }
        TextBox textBox;
        Label lb2;
        private void Default()
        {
            Font = new Font("Verdana", 12);
            Size = new Size(400, 300);
            Text = "Biletul 23";
            this.BackColor = Color.LightGray;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            Label lb1 = new Label();
            lb1.Text = "Introdu un numar : ";
            lb1.Location = new Point(110, 50);
            lb1.Size = new Size(180, 30);
            Controls.Add(lb1);

            textBox = new TextBox();
            textBox.Text = "";
            textBox.Location = new Point(90, 80);
            textBox.Size = new Size(200, 60);
            textBox.KeyDown += textBox_KeyDown;
            textBox.KeyPress += textBox_KeyPress;
            Controls.Add(textBox);

            Button button = new Button();
            button.Text = "Verifica";
            button.Location = new Point(110, 130);
            button.Size = new Size(160, 40);
            button.BackColor = Color.White;
            button.Click += Button_Click;
            Controls.Add(button);

            lb2 = new Label();
            lb2.Location = new Point(100, 190);
            lb2.Size = new Size(230, 60);
            lb2.Text = "";
            Controls.Add(lb2);
        }
        private bool nonNumberEntered = false;
        private void textBox_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            nonNumberEntered = false;

            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    if (e.KeyCode != Keys.Back)
                    {
                        nonNumberEntered = true;
                    }
                }
            }
            if (Control.ModifierKeys == Keys.Shift)
            {
                nonNumberEntered = true;
            }
        }
        private void textBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (nonNumberEntered == true)
            {
                e.Handled = true;
            }
        }
        private void Button_Click(object? sender, EventArgs e)
        {
            if (textBox.Text == "")
            {
                lb2.Text = "Valoarea indicata nu este un numar.";
            }
            else
            {
                int nr = int.Parse(textBox.Text);
                if (nr % 2 == 0)
                {
                    lb2.Text = "Numarul este par.";
                }
                else
                {
                    lb2.Text = "Numarul este impar.";
                }
            }
        }
    }
}