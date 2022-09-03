namespace Problema_2
{
    public partial class Form1 : Form
    {
        /*
         Setările ferestrei vor fi:
         Dimensiunea inițială: 600x400
         Culoarea de fundal inițială: White
         Amplasați pe suprafața ferestrei două controlere:
         Un button – Un click pe acesta va comuta regimul de zi cu cel de noapte și vice-versa. În regimul de zi – Textul 
         label-ului este de culoare neagră iar fundalul – alb, în regim de noapte – fundalul negru, iar culoarea textului – alb.
         Un label – Pentru a afișa un text (la dorință).
         */

        static bool IsDay = true;
        Button btChange;
        Label lbText;
        public Form1()
        {
            InitializeComponent();
            Load_Elements();
        }
        private void Load_Elements()
        {
            Font = new Font("Verdana", 16);
            Size = new Size(600, 400);
            Text = "Problema 2";

            btChange = new Button();
            btChange.Location = new Point(400, 12);
            btChange.Size = new Size(162, 43);
            btChange.Text = "Night Light";
            btChange.Click += btChange_Click;
            Controls.Add(btChange);

            lbText = new Label();
            lbText.Location = new Point(170, 150);
            lbText.Size = new Size(250, 100);
            lbText.Text = "      Problema 2\nLucru individual nr 1";
            Controls.Add(lbText);
            BussinesLogic();
        }
        void Day()
        {
            btChange.BackColor = Color.White;
            btChange.ForeColor = Color.Black;
            btChange.Text = "Night Light";
            lbText.ForeColor = Color.Black;
            this.BackColor = Color.White;
        }
        void Night()
        {
            btChange.BackColor = Color.Black;
            btChange.ForeColor = Color.White;
            btChange.Text = "Day Light";
            lbText.ForeColor = Color.White;
            this.BackColor = Color.Black;
        }
        private void btChange_Click(object sender, EventArgs e)
        {
            BussinesLogic();
        }
        private void BussinesLogic()
        {
            if (IsDay)
            {
                Night();
                IsDay = false;
            }
            else
            {
                Day();
                IsDay = true;
            }
        }
    }
}