namespace Problema_8
{
    public partial class Form1 : Form
    {
        //CheckBox - Exemplu de utilizare
        public Form1()
        {
            InitializeComponent();
            Default();
        }
        private void Default()
        {

            Font = new Font("Verdana", 10);
            Size = new Size(500, 350);
            Text = "Problema 8";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            Label Lb = new Label();
            Lb.Font = new Font("Vedana", 12);
            Lb.Location = new Point(30,20);
            Lb.Size = new Size(250,30);
            Lb.Text = "Termeni si conditii";
            Controls.Add(Lb);

            RichTextBox Rich1 = new RichTextBox();
            Rich1.Font = new Font("Vedana", 12);
            Rich1.ReadOnly = true;
            Rich1.Location = new Point(30,50);
            Rich1.Size = new Size(400,180);
            Rich1.Text = "Acest set de Termeni și condiții reflectă modul în care Google își desfășoară activitatea, " +
                "legile aplicabile companiei noastre și anumite lucruri în care aceasta a crezut mereu. Prin urmare, " +
                "Termenii și condițiile ajută la definirea relației dvs. cu Google când interacționați cu serviciile sale." +
                " De exemplu, aceste condiții includ următoarele titluri de subiecte:";
            Controls.Add(Rich1);

            CheckBox Check1 = new CheckBox();
            Check1.Location = new Point(30, 240);
            Check1.Size = new Size(380,30);
            Check1.Text = "Sunt de acord cu termenii si conditiile impuse.";
            Check1.Click += Check1_Click;
            Controls.Add(Check1);

            CheckBox Check2 = new CheckBox();
            Check2.Location = new Point(30,270);
            Check2.Size = new Size(500,30);
            Check2.Text = "Doresc sa primesc notificari privind modificarea termenilor.";
            Check2.Click += Check2_Click;
            Controls.Add(Check2);
        }
        bool flag1 = false;
        bool flag2 = false;
        private void Check2_Click(object? sender, EventArgs e)
        {
            flag1 = true;
        }
        private void Check1_Click(object? sender, EventArgs e)
        {
            flag2= true;
        }
    }
}