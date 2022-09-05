namespace Problema_10
{
    public partial class Form1 : Form
    {
        //ListBox - Exemplu de utilizare
        ListBox Lista;
        public Form1()
        {
            InitializeComponent();
            Default();
        }
        private void Default()
        {
            Font = new Font("Verdana", 12);
            Size = new Size(400, 300);
            Text = "Problema 10";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            Label Lb = new Label();
            Lb.Text = "Selectati orasul :";
            Lb.Location = new Point(40, 30);
            Lb.Size = new Size(200,30);
            Controls.Add(Lb);

            Lista=new ListBox();
            Lista.Location = new Point(40,60);
            Lista.Size = new Size(300,200);
            Lista.Items.Add("Chisinau");
            Lista.Items.Add("Cahul");
            Lista.Items.Add("Leova");
            Lista.Items.Add("Comrat");
            Lista.Items.Add("Ialoveni");
            Lista.Items.Add("Orhei");
            Lista.Items.Add("Soroca");
            Lista.Items.Add("Vulcanesti");
            Lista.Items.Add("Balti");
            Lista.Items.Add("Hincesti");
            Lista.SelectedIndexChanged += Lista_SelectedIndexChanged;
            Controls.Add(Lista);

            /*
             List <string> optiuni =new List<string>()
            {   
            "Chisinau",
            "Cahul",
            "Leova",
            "Comrat",
            "Ialoveni",
            };
            Lista.DataSource=optiuni;
             */
        }
        private void Lista_SelectedIndexChanged(object? sender, EventArgs e)
        {
            MessageBox.Show(Lista.SelectedItem.ToString());
        }
    }
}