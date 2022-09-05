namespace Problema_2
{
    /*
     Creați aplicația Login. Aceasta va conține 2 label-uri, 2 textbox-uri pentru a introduce Username-ul și Parola,
    iar sub acestea – un buton cu textul LogIn. La efectuarea unui click pe acest button datele din textbox-uri vor fi verificate 
    – Atât username-ul, cât și parola să conțină minim 8 caractere. Dacă condiția este satisfăcută, datele introduse vor fi afisate 
    într-un MessageBox. În caz contrar va fi afișat un mesaj corespunzător.
     */
    public partial class Form1 : Form
    {
        TextBox tbUsername;
        TextBox tbPassword;
        public Form1()
        {
            InitializeComponent();
            LoadElements();
        }
        private void LoadElements()
        {
            BackColor = Color.LightGray;
            Font = new Font("Verdana", 12);
            Size = new Size(400, 400);
            Text = "Laboratorul2";
            this.StartPosition = FormStartPosition.CenterScreen;

            Label lbUsername = new Label();
            lbUsername.Text = "Username";
            lbUsername.Location = new Point(80, 100);
            lbUsername.Size = new Size(240, 20);
            Controls.Add(lbUsername);

            tbUsername = new TextBox();
            tbUsername.Location = new Point(80, 130);
            tbUsername.Size = new Size(240, 20);
            Controls.Add(tbUsername);

            Label lbPassword = new Label();
            lbPassword.Text = "Password";
            lbPassword.Location = new Point(80, 170);
            lbPassword.Size = new Size(240, 20);
            Controls.Add(lbPassword);

            tbPassword = new TextBox();
            tbPassword.Location = new Point(80, 200);
            tbPassword.PasswordChar = '*';
            tbPassword.Size = new Size(240, 20);
            Controls.Add(tbPassword);

            Button btLogIn = new Button();
            btLogIn.BackColor = Color.DarkGray;
            btLogIn.Dock = DockStyle.Bottom;
            btLogIn.Text = "Log In";
            btLogIn.Height = 40;
            btLogIn.Click += btLogIn_Click;
            Controls.Add(btLogIn);
        }
        private void btLogIn_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text.Length<8)
            {
                MessageBox.Show("Invalid username !");
            }
            else
            {
                if ((tbPassword.Text.Length < 8))
                {
                    MessageBox.Show("Invalid password !");
                }
                else
                {
                    MessageBox.Show($"Username: {tbUsername.Text}\nPassword: {tbPassword.Text}");
                }
            }
        }

    }
}