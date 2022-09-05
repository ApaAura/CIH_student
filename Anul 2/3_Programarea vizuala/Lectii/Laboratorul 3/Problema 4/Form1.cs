namespace Problema_4
{
    public partial class Form1 : Form
    {
        //RichTextBox - Exemplu de utilizare
        RichTextBox Rich2;
        RichTextBox Rich1;
        public Form1()
        {
            InitializeComponent();
            Default();
        }
        private void Default()
        {
            Font = new Font("Verdana", 12);
            Size = new Size(400, 400);
            Text = "Problema 4";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            Label Lb1=new Label();
            Lb1.Text = "Scrie aici : ";
            Lb1.Location = new Point(30,15);
            Lb1.Size = new Size(100,20);
            Controls.Add(Lb1);

            Rich1= new RichTextBox();
            Rich1.Location = new Point(30,40);
            Rich1.Size = new Size(320,130);
            Rich1.TextChanged += Rich1_TextChanged;
            Controls.Add(Rich1);

            Label Lb2 = new Label();
            Lb2.Text = "Iata mesajul tau : ";
            Lb2.Location = new Point(30, 175);
            Lb2.Size = new Size(170, 20);
            Controls.Add(Lb2);

            Rich2= new RichTextBox();
            Rich2.ReadOnly = true;
            Rich2.Location = new Point(30,200);
            Rich2.Size = new Size(320, 130);
            Controls.Add(Rich2);
        }
        private void Rich1_TextChanged(object? sender, EventArgs e)
        {
            Rich2.Text = Rich1.Text;
        }
    }
}