namespace Problema_6
{
    public partial class Form1 : Form
    {
        //Group box - Exemplu de utilizare
        TextBox tbPassword;
        TextBox tbUsername;
        Label lbUsername;
        Label lbPassword;
        Button btReset;
        Button btLogIn;
        public Form1()
        {
            InitializeComponent();
            Default();
        }
        private void Default()
        {
            Font = new Font("Verdana", 12);
            Size = new Size(400, 350);
            Text = "Problema 6";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            GroupBox Grup=new GroupBox();
            Grup.Controls.Add(tbUsername);
            Grup.Controls.Add(tbPassword);
            Grup.Controls.Add(lbUsername);
            Grup.Controls.Add(lbPassword);
            Grup.Controls.Add(btReset);
            Grup.Controls.Add(btLogIn);
            Grup.Location = new Point(40,20);
            Grup.Size = new Size(300,280);
            Grup.Text = "Completati datele";

            lbUsername = new Label();
            lbUsername.Text = "Username";
            lbUsername.Location = new Point(30, 30);
            lbUsername.Size = new Size(240, 20);
            Grup.Controls.Add(lbUsername);

            tbUsername = new TextBox();
            tbUsername.Location = new Point(30, 60);
            tbUsername.Size = new Size(240, 20);
            Grup.Controls.Add(tbUsername);

            lbPassword = new Label();
            lbPassword.Text = "Password";
            lbPassword.Location = new Point(30, 100);
            lbPassword.Size = new Size(240, 20);
            Grup.Controls.Add(lbPassword);

            tbPassword = new TextBox();
            tbPassword.Location = new Point(30, 130);
            tbPassword.PasswordChar = '*';
            tbPassword.Size = new Size(240, 20);
            Grup.Controls.Add(tbPassword);

            btReset = new Button();
            btReset.Location = new Point(20, 200);
            btReset.Size = new Size(100, 30);
            btReset.Text = "Reset";
            btReset.Click += BtReset_Click;
            Grup.Controls.Add(btReset);

            btLogIn = new Button();
            btLogIn.Location = new Point(170, 200);
            btLogIn.Size = new Size(100, 30);
            btLogIn.Text = "Login";
            btLogIn.Click += BtLogIn_Click;
            Grup.Controls.Add(btLogIn);

            Controls.Add(Grup);
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
            tbUsername.Text = "";
            tbPassword.Text = "";
        }
    }
}