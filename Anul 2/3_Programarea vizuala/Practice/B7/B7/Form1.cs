namespace B7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadElements();
        }
        TextBox tbUsername, tbPassword;
        private void LoadElements()
        {
            BackColor = Color.LightGray;
            Font = new Font("Verdana", 12);
            Size = new Size(400, 400);
            Text = "Biletul 7";
            this.StartPosition = FormStartPosition.CenterScreen;

            Label lbUsername = new Label();
            lbUsername.Text = "Nume de utilizator";
            lbUsername.Location = new Point(80, 100);
            lbUsername.Size = new Size(240, 20);
            Controls.Add(lbUsername);

            tbUsername = new TextBox();
            tbUsername.Location = new Point(80, 130);
            tbUsername.Size = new Size(240, 20);
            Controls.Add(tbUsername);

            Label lbPassword = new Label();
            lbPassword.Text = "Parola";
            lbPassword.Location = new Point(80, 170);
            lbPassword.Size = new Size(240, 20);
            Controls.Add(lbPassword);

            tbPassword = new TextBox();
            tbPassword.Location = new Point(80, 200);
            tbPassword.PasswordChar = '*';
            tbPassword.Size = new Size(240, 20);
            Controls.Add(tbPassword);

            CheckBox cbUsername = new CheckBox();
            cbUsername.Text = "Pastreaza-ma autentificat";
            cbUsername.Size = new Size(300,30);
            cbUsername.Location = new Point(80,230);
            Controls.Add(cbUsername);

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
            if (tbUsername.Text.Length < 8)
            {
                MessageBox.Show("Date invalide!");
            }
            else
            {
                if ((tbPassword.Text.Length < 8))
                {
                    MessageBox.Show("Date invalide !");
                }
                else
                {
                    MessageBox.Show("Succes");
                }
            }
        }
    }
}