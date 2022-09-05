namespace Problema_5
{
    public partial class Form1 : Form
    {
        //Panel - Exemplu de utilizare 
        public Form1()
        {
            InitializeComponent();
            LoadForm();
        }

        private void LoadForm()
        {
            Font = new Font("Verdana", 12);
            Size = new Size(400, 400);
            Text = "Problema 4";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            Panel panel = new Panel();
            panel.Size = new Size(this.Width, this.Height);
            panel.Location = new Point(0, 0);
            panel.BackColor= Color.LightGreen;

            Panel second = new Panel();
            second.Location = new Point(20, 30);
            second.BackColor = Color.LightCyan;
            second.Size = new Size(200, 100);

            Label lbl = new Label();
            lbl.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse aliquam diam eros, nec dapibus nunc posuere eu.";
            lbl.Width = 200;
            lbl.Height = 90;
            second.Controls.Add(lbl);

            Button button = new Button();
            button.Location = new Point(300, 150);
            button.Text = "Click me!";
            button.Click += Button_Click;

            Panel third = new Panel();
            third.Dock = DockStyle.Bottom;
            third.BackColor = Color.LightYellow;

            Label label = new Label();
            label.Text = "Thist is a label in a panel";
            label.Font = new Font("Verdana", 15);
            label.Width = this.Width;
            third.Controls.Add(label);

            panel.Controls.Add(second);
            panel.Controls.Add(third);
            panel.Controls.Add(button);
            this.Controls.Add(panel);
        }

        private void Button_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Buna!\n:D");
        }
    }
}