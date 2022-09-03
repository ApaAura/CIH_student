namespace Problema_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Default();
        }
        Label label1;
        public DateTime Start { get; set; } = DateTime.Now;
        public DateTime End { get; set; } = DateTime.Now;

        private void Default()
        {
            Font = new Font("Verdana", 12);
            Size = new Size(600, 420);
            Text = "Problema 3";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            Label label = new Label();
            label.Text = "Diferenta in zile, ore si minute dintre\ndoua dati calendaristie";
            label.Location = new Point(30,15);
            label.Size = new Size(500,40);
            Controls.Add(label);

            MonthCalendar monthCalendar;
            MonthCalendar monthCalendar1;

            monthCalendar = new MonthCalendar();
            monthCalendar.Location = new Point(50,60);
            monthCalendar.Size = new Size(60,60);
            monthCalendar.DateChanged += MonthCalendar_DateChanged;
            Controls.Add(monthCalendar);

            monthCalendar1 = new MonthCalendar();
            monthCalendar1.Location = new Point(330,60);
            monthCalendar1.Size = new Size(60,60);
            monthCalendar1.DateChanged += MonthCalendar1_DateChanged;
            Controls.Add(monthCalendar1);

            Button button= new Button();
            button.Location = new Point(210, 230);
            button.Size = new Size(180, 40);
            button.BackColor = Color.Aquamarine;
            button.Text = "Determina";
            button.Click += Button_Click;
            Controls.Add(button);

            label1 = new Label();
            label1.Text = "Diferenta : ";
            label1.Location = new Point(260,280);
            label1.Size = new Size(150,100);
            Controls.Add(label1);
        }
        private void MonthCalendar1_DateChanged(object? sender, DateRangeEventArgs e)
        {
            End = e.End;
        }
        private void MonthCalendar_DateChanged(object? sender, DateRangeEventArgs e)
        {
            Start = e.Start;
        }
        private void Button_Click(object? sender, EventArgs e)
        {
            label1.Text = $"Diferenta :\nZile : {(End - Start).TotalDays:F0}\nOre : {(End - Start).TotalHours:F0}\nMinute : {(End - Start).TotalMinutes:F0} ";
        }
    }
}