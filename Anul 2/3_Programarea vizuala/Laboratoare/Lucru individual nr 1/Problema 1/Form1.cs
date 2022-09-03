namespace Problema_1
{
    public partial class Form1 : Form
    {
        /*
         Setările ferestrei vor fi:
         Dimensiunea: 600x400
         Culoarea de fundal – WhiteSmoke
         Fontul – Verdana, 14px
         Fereastra va fi lansată mereu în centrul ecranului
         Restricționați utilizatorul în a redimensiona fereastra
         Amplasați pe fereastră un label cu numele myLabel și textul “Simple WF App”.
         */
        public Form1()
        {
            InitializeComponent();
            Default();
        }
        private void Default()
        {
            Font = new Font("Verdana", 14);
            Size = new Size(600, 400);
            BackColor = Color.WhiteSmoke;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            Text = "Problema 1" ;

            Label myLabel=new Label();
            myLabel.Text = "Simple WF App";
            myLabel.Location = new Point(200, 100);
            myLabel.Size = new Size(170, 100); 
            Controls.Add(myLabel);
        }
    }
}