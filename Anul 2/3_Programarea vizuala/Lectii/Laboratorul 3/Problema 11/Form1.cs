namespace Problema_11
{
    public partial class Form1 : Form
    {
        //ComboBox - Exemplu de utilizare
        ComboBox Combo1;
        RichTextBox Rich;
        ComboBox Combo2;
        public Form1()
        {
            InitializeComponent();
            Default();
        }
        private void Default()
        {
            Font = new Font("Verdana", 12);
            Size = new Size(400, 350);
            Text = "Problema 11";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            Label Label1=new Label();
            Label1.Location = new Point(40,30);
            Label1.Size = new Size(50,30);
            Label1.Text = "Font";
            Controls.Add(Label1);

            Combo1=new ComboBox();
            Combo1.Location = new Point(90,25);
            Combo1.Size = new Size(100,30);
            Combo1.Items.Add("Verdana");
            Combo1.Items.Add("Times New Roman");
            Combo1.Items.Add("Consolas");
            Combo1.Items.Add("Courier New");
            Combo1.SelectedIndexChanged += Combo1_SelectedIndexChanged;
            Controls.Add(Combo1);

            Label Label2=new Label();
            Label2.Location = new Point(200,30);
            Label2.Size = new Size(50,30);
            Label2.Text = "Size";
            Controls.Add(Label2);

            Combo2=new ComboBox();
            Combo2.Location = new Point(250,25);
            Combo2.Size = new Size(70,30);
            for (int i = 2; i <= 100; i+=2)
            {
                Combo2.Items.Add(i);
            }
            Combo2.SelectedIndexChanged += Combo2_SelectedIndexChanged;
            Controls.Add(Combo2);

            Rich = new RichTextBox();
            Rich.Location = new Point(40,65);
            Rich.Size = new Size(300,200);
            Controls.Add(Rich);
        }
        private void Combo2_SelectedIndexChanged(object? sender, EventArgs e)
        {
            Rich.Font = new Font(Rich.Font.FontFamily, (int)Combo2.SelectedItem);
        }
        private void Combo1_SelectedIndexChanged(object? sender, EventArgs e)
        {
            Rich.Font = new Font(Combo1.SelectedItem.ToString(), Rich.Font.Size);
        }
    }
}