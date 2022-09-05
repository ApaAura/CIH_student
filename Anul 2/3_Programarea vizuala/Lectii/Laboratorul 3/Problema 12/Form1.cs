namespace Problema_12
{
    public partial class Form1 : Form
    {
        //MonthCalendar - Exemplu de utilizare 
        MonthCalendar month;
        Label label;
        public Form1()
        {
            InitializeComponent();
            Default();
        }

        private void Default()
        {
            Font = new Font("Verdana", 12);
            Size = new Size(400, 400);
            Text = "Problema 12";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            month=new MonthCalendar();
            month.Location = new Point(80,50);
            month.Size = new Size(200,200);
            month.DateChanged += Month_DateChanged;
            Controls.Add(month);

            label=new Label();
            label.Text = "x zile ramase pana la revelion !";
            label.Location = new Point(65,230);
            label.Size = new Size(300, 30);
            Controls.Add(label);
        }
        private void Month_DateChanged(object? sender, DateRangeEventArgs e)
        {
            var dataSelectat = month.SelectionRange.Start;
            var dataRevelion = DateTime.Parse($"12/31/{dataSelectat.Year}");
            var zileRamase = (dataRevelion - dataSelectat).Days;
            label.Text = $"{zileRamase} zile ramase pana la revelion !";
        }
    }
}