namespace Problema_1
{
    public partial class Form1 : Form
    {
        /*
         Amplasați pe suprafața ferestrei un label și un button. Iniția, text-ul label-ului și a butonului este negru, 
        iar fundalul aplicației – alb, iar textul butonului va fi `Night Light`. La efectuarea unui click pe button, aplicația 
        trece în night-mode, textul label-ului și a butonului devine alb, fundalul (Atât al ferestrei, cât și al butonului) va 
        fi negru, iar text-ul butonului se va schimba in `Day Light`. La efectuarea altui click, aplicația va reveni la interfața inițială.
         */

        static bool IsDay = true;

        Button btChange;
        Label lbText;
        public Form1()
        {
            InitializeComponent();
            Load_elements();
        }

        void Load_elements()
        {
            Font = new Font("Verdana", 16);
            Size = new Size(400, 400);
            Text = "Laboratorul2";

            btChange = new Button();
            btChange.Location = new Point(210, 12);
            btChange.Size = new Size(162, 43);
            btChange.Text = "Night Light";
            btChange.Click += btChange_Click;
            Controls.Add(btChange);

            lbText = new Label();
            lbText.Location = new Point(170, 150);
            lbText.Size = new Size(78, 32);
            lbText.Text = "skr";
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