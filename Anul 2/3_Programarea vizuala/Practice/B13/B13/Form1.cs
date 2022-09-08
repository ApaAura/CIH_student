namespace B13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Default();
        }
        RadioButton radioButton;
        Label label, label2 ;
        private void Default()
        {
            Font = new Font("Verdana", 12);
            Size = new Size(400, 400);
            Text = "Biletul 13";
            this.BackColor = Color.White;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            radioButton=new RadioButton();
            radioButton.Text = "NightMode";
            radioButton.Location = new Point(10,10);
            radioButton.Size = new Size(200,30);
            radioButton.CheckedChanged += RadioButton_CheckedChanged; ;
            Controls.Add(radioButton);

            label=new Label();
            label.Text = "Heading";
            label.Font = new Font("Bold", 30);
            label.Size = new Size(300,50);
            label.Location = new Point(30,100);
            Controls.Add(label);

            label2=new Label();
            label2.Text = "Lorem ipsum dolor sit amet, consectetur \nadipiscing elit, sed do eiusmod tempor \nincididunt ut labore et dolore magna \naliqua.";
            label2.Font = new Font("Verdana", 10);
            label2.Size = new Size(300, 70);
            label2.Location = new Point(35, 160);
            Controls.Add(label2);
        }

        private void RadioButton_CheckedChanged(object? sender, EventArgs e)
        {
            if (radioButton.Checked)
            {
                this.BackColor = Color.Black;
                radioButton.ForeColor = Color.White;
                label.ForeColor=Color.White;
                label2.ForeColor=Color.White;
            }
            else
            {
                this.BackColor = Color.White;
                radioButton.ForeColor = Color.Black;
                label.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
            }
        }
    }
}