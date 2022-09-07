namespace Problema_1
{
    public partial class Form1 : Form
    {
        bool goleft = false;
        bool goright = false;
        bool jumping = false;
        bool isGameOver = false;
        public bool IsGameOver
        {
            get { return isGameOver; }
            set
            {
                if (value == true)
                {
                    isGameOver = true;
                    MessageBox.Show($"You win !! \nScore: {score}");
                    timer1.Stop();
                }
                isGameOver = false;
            }
        }
        int jumpSpeed = 10;
        int force = 8;
        int score = 0;
        public Form1()
        {
            InitializeComponent();
            Default();
        }
        private void Default()
        {
            Text = "Gameee";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = true;
            }
            if (e.KeyCode == Keys.Space && !jumping)
            {
                jumping = true;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            player.Top += jumpSpeed;
            if (jumping && force < 0)
            {
                jumping = false;
            }
            if (goleft)
            {
                player.Left -= 5;
            }
            if (goright)
            {
                player.Left += 5;
            }
            if (jumping)
            {
                jumpSpeed = -12;
                force -= 1;
            }
            else
            {
                jumpSpeed = 12;
            }
            foreach (Control x in this.Controls)
            {

                if (x is PictureBox && x.Tag == "platform")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds) && !jumping)
                    {
                        force = 8;
                        player.Top = x.Top - player.Height;
                    }
                }
                if (x is PictureBox && x.Tag == "Coin")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds) && !jumping)
                    {
                        this.Controls.Remove(x);
                        score++;
                    }
                }
            }
            label2.Text = $"          Score: {score}";
            if (player.Bounds.IntersectsWith(Door.Bounds))
            {
                timer1.Stop();
                IsGameOver = true;
            }
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }
            if (jumping)
            {
                jumping = false;
            }
        }
    }
}