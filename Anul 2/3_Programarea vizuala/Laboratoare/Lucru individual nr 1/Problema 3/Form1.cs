namespace Problema_3
{
    public partial class Form1 : Form
    {
        /*
         Amplasați pe suprafața ferestrei 8 butoane (Vezi schița):
         N – Nord (Va deplasa fereastra în sus cu 5px)
         NE – Nord-Est (Va deplasam fereastra pe diagonala secundară (5px dreapta, 5px în sus)
         E – Est (Va deplasa fereastra 5 px la dreapta)
         BONUS Point: Nu-i permiteți aplicației să părăsească ecranul atunci
         cand este deplasata cu ajutorul butoanelor.
         */
        public Form1()
        {
            InitializeComponent();
            Default();
        }
        private void Default()
        {
            Font = new Font("Verdana", 16);
            Size = new Size(400, 400);
            Text = "Problema 3";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            Button button = new Button();
            button.Text = "NW";
            button.Size = new Size(60, 60);
            button.Location = new Point(95, 65);
            button.Click += Button_Click;
            Controls.Add(button);

            Button button2 = new Button();
            button2.Text = "N";
            button2.Size = new Size(60, 60);
            button2.Location = new Point(165, 65);
            button2.Click += Button2_Click;
            Controls.Add(button2);

            Button button3 = new Button();
            button3.Text = "NE";
            button3.Size = new Size(60, 60);
            button3.Location = new Point(235, 65);
            button3.Click += Button3_Click;
            Controls.Add(button3);

            Button button4 = new Button();
            button4.Text = "E";
            button4.Size = new Size(60, 60);
            button4.Location = new Point(235, 135);
            button4.Click += Button4_Click;
            Controls.Add(button4);

            Button button5 = new Button();
            button5.Text = "SE";
            button5.Size = new Size(60, 60);
            button5.Location = new Point(235, 205);
            button5.Click += Button5_Click;
            Controls.Add(button5);

            Button button6 = new Button();
            button6.Text = "S";
            button6.Size = new Size(60, 60);
            button6.Location = new Point(165, 205);
            button6.Click += Button6_Click;
            Controls.Add(button6);

            Button button7 = new Button();
            button7.Text = "SW";
            button7.Size = new Size(60, 60);
            button7.Location = new Point(95, 205);
            button7.Click += Button7_Click;
            Controls.Add(button7);

            Button button8 = new Button();
            button8.Text = "W";
            button8.Size = new Size(60, 60);
            button8.Location = new Point(95, 135);
            button8.Click += Button8_Click;
            Controls.Add(button8);
        }

        //Screen.PrimaryScreen.Bounds.Width;
        //Screen.PrimaryScreen.Bounds.Height;
        private void Button8_Click(object? sender, EventArgs e)
        {
            if (this.Left-10>0)
            this.Left -= 10;
        }

        private void Button7_Click(object? sender, EventArgs e)
        {
            this.Top += 10;
            this.Left -= 10;
        }

        private void Button6_Click(object? sender, EventArgs e)
        {
            if (!((this.Top+10+this.Height < 0) | (this.Top+10+this.Height>Screen.PrimaryScreen.Bounds.Height)))
            this.Top += 10;
        }

        private void Button5_Click(object? sender, EventArgs e)
        {
            this.Top += 10;
            this.Left += 10;
        }

        private void Button4_Click(object? sender, EventArgs e)
        {
            if (this.Left+10+this.Width< Screen.PrimaryScreen.Bounds.Width)
            this.Left += 10;
        }

        private void Button3_Click(object? sender, EventArgs e)
        {
            this.Top -= 10;
            this.Left += 10;
        }

        private void Button2_Click(object? sender, EventArgs e)
        {
            if (!((this.Top - 10 < 0) | (this.Top - 10> Screen.PrimaryScreen.Bounds.Height)))
                this.Top -= 10;
        }
        private void Button_Click(object? sender, EventArgs e)
        {
            this.Top -= 10;
            this.Left -= 10;
        }
    }
}