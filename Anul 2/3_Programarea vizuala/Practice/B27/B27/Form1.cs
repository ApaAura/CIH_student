namespace B27
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Default();
        }
        TextBox textBox, textBox2;
        Label label1;
        private void Default()
        {
            Font = new Font("Verdana", 12);
            Size = new Size(600, 300);
            Text = "Biletul 27";
            this.BackColor = Color.White;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            Label label=new Label();
            label.Text = "Genereaza un numar aleator cuprins intre: ";
            label.Size = new Size(350, 30);
            label.Location = new Point(135,30);
            label.Font = new Font("Bold", 13);
            Controls.Add(label);

            textBox=new TextBox();
            textBox.Size = new Size(80,40);
            textBox.Location = new Point(180,80);
            Controls.Add(textBox);

            Label label2=new Label();
            label2.Text = "si";
            label2.Size = new Size(40, 30);
            label2.Location = new Point(280,83);
            Controls.Add(label2);

            textBox2=new TextBox();
            textBox2.Size = new Size(80, 40);
            textBox2.Location = new Point(320,80);
            Controls.Add(textBox2);

            Button button2=new Button();
            button2.Text = "Genereaza";
            button2.BackColor = Color.Aquamarine;
            button2.Size = new Size(180,40);
            button2.Location = new Point(200,130);
            button2.Click += Button2_Click;
            Controls.Add(button2);

            label1= new Label();
            label1.Text = "Numarul aleator : ";
            label1.Size = new Size(200,30);
            label1.Location = new Point(205,190);
            Controls.Add(label1);
        }
        private void Button2_Click(object? sender, EventArgs e)
        {
            int n1 = int.Parse(textBox.Text);
            int n2=int.Parse(textBox2.Text);
            Random random = new Random();
            int aleator=random.Next(n1,n2);
            label1.Text = $"Numarul aleator : {aleator}";
        }
    }
}