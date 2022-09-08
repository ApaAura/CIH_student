namespace B9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Default();
        }
        Label label2;
        MonthCalendar monthCalendar;
        private void Default()
        {
            Font = new Font("Verdana", 12);
            Size = new Size(400, 400);
            Text = "Biletul 9";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            Label label=new Label();
            label.Text = "Alegeti data nasterii: ";
            label.Location = new Point(30,30);
            label.Size = new Size(200,30);
            Controls.Add(label);

            monthCalendar = new MonthCalendar();
            monthCalendar.Location = new Point(80,80);
            monthCalendar.Size = new Size(120,100);
            Controls.Add(monthCalendar);

            Button button=new Button();
            button.Location = new Point(60,260);  
            button.Size = new Size(270,30);
            button.Text = "Determina varsta";
            button.BackColor = Color.Aquamarine;
            button.Click += Button_Click;
            Controls.Add(button);

            label2=new Label();
            label2.Text = "Varsta: ";
            label2.Location = new Point(160,295);
            label2.Size = new Size(200,30);
            Controls.Add(label2);
        }
        private void Button_Click(object? sender, EventArgs e)
        {
            TimeSpan rs = DateTime.Now - monthCalendar.SelectionStart;
            label2.Text = "Varsta: " + (rs.Days / 365).ToString();
        }
    }
}