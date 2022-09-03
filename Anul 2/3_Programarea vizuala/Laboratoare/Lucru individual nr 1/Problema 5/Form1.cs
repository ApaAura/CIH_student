namespace Problema_5
{
    public partial class Form1 : Form
    {
        /*
         Aceasta va reprezenta un formular simplu de logare.
         Amplasați două Buttoane, două Label-uri și două TextBox-uri pe suprafața ferestrei. 
         Label-urile vor fi utilizate pentru a afișa pe suprafața ferestrei textele Username și Password
         TextBox-urile vor folosi pentru introducerea datelor. Acestea vor accepta maxim 80 de caractere.
         Butonul Reset: Va curăța tot ce a introdus utilizatorul
         Butonul LogIn: Va valida input-ul utilizatorului (Username-ul și Parola să conțină cel puțin 8 caractere). 
         Dacă input-ul este valid, va fi afișat mesajul “Success” cu ajutorul unui MessageBox. 
         În caz contrar, mesajul afișat va fi “Login attempt failed”.
         */
        public Form1()
        {
            InitializeComponent();
            Default();
        }
        TextBox tbPassword;
        TextBox tbUsername;
        private void Default()
        {
            Font = new Font("Verdana", 12);
            Size = new Size(400, 400);
            Text = "Problema 5";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            Label lbUsername = new Label();
            lbUsername.Text = "Username";
            lbUsername.Location = new Point(80, 80);
            lbUsername.Size = new Size(240, 20);
            Controls.Add(lbUsername);

            tbUsername = new TextBox();
            tbUsername.Location = new Point(80, 110);
            tbUsername.Size = new Size(240, 20);
            Controls.Add(tbUsername);

            Label lbPassword = new Label();
            lbPassword.Text = "Password";
            lbPassword.Location = new Point(80, 150);
            lbPassword.Size = new Size(240, 20);
            Controls.Add(lbPassword);

            tbPassword = new TextBox();
            tbPassword.Location = new Point(80, 180);
            tbPassword.PasswordChar = '*';
            tbPassword.Size = new Size(240, 20);
            Controls.Add(tbPassword);

            Button btReset=new Button();
            btReset.Location = new Point(80,250);
            btReset.Size = new Size(100,30);
            btReset.Text = "Reset";
            btReset.Click += BtReset_Click;
            Controls.Add(btReset);

            Button btLogIn =  new Button();
            btLogIn.Location = new Point(200,250);
            btLogIn.Size = new Size(100,30);
            btLogIn.Text = "Login";
            btLogIn.Click += BtLogIn_Click;
            Controls.Add(btLogIn);

        }
        private void BtLogIn_Click(object? sender, EventArgs e)
        {
            if (tbUsername.Text.Length < 8)
            {
                MessageBox.Show("Login attempt failed !");
            }
            else
            {
                if (tbPassword.Text.Length < 8)
                {
                    MessageBox.Show("Login attempt failed !");
                }
                else
                {
                    MessageBox.Show("Success !");
                }
            }
        }
        private void BtReset_Click(object? sender, EventArgs e)
        {
            tbUsername.Text ="";
            tbPassword.Text = "";
        }
    }
}