namespace B8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadElements();
        }
        TextBox tbUsername, tbPassword, textBox;
        private void LoadElements()
        {
            BackColor = Color.LightGray;
            Font = new Font("Verdana", 12);
            Size = new Size(400, 400);
            Text = "Biletul 7";
            this.StartPosition = FormStartPosition.CenterScreen;

            Label lbUsername = new Label();
            lbUsername.Text = "Nume de utilizator";
            lbUsername.Location = new Point(80, 70);
            lbUsername.Size = new Size(240, 20);
            Controls.Add(lbUsername);

            tbUsername = new TextBox();
            tbUsername.Location = new Point(80, 100);
            tbUsername.Size = new Size(240, 20);
            Controls.Add(tbUsername);

            Label lbPassword = new Label();
            lbPassword.Text = "Parola";
            lbPassword.Location = new Point(80, 140);
            lbPassword.Size = new Size(240, 20);
            Controls.Add(lbPassword);

            tbPassword = new TextBox();
            tbPassword.Location = new Point(80, 170);
            tbPassword.PasswordChar = '*';
            tbPassword.Size = new Size(240, 20);
            Controls.Add(tbPassword);

            Label label=new Label();
            label.Text = "Email";
            label.Location = new Point(80,210);
            label.Size = new Size(240,20);
            Controls.Add(label);

            textBox=new TextBox();
            textBox.Location = new Point(80,230);
            textBox.Size = new Size(240,20);
            Controls.Add(textBox);

            Button btLogIn = new Button();
            btLogIn.BackColor = Color.DarkGray;
            btLogIn.Dock = DockStyle.Bottom;
            btLogIn.Text = "Autentificare";
            btLogIn.Height = 40;
            btLogIn.Click += btLogIn_Click;
            Controls.Add(btLogIn);
        }
        private void btLogIn_Click(object sender, EventArgs e)
        {
            string valid = "@";
            if ((tbUsername.Text.Length > 8)&&(valid.Contains(textBox.Text)&&((tbPassword.Text.Length > 8))))
            {
                MessageBox.Show("Succes");
            }
            else
            {
                MessageBox.Show("Fail");
            }
        }
    }
}