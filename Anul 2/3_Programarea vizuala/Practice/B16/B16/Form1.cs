namespace B16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Default();
        }

        private void Default()
        {
            Font = new Font("Verdana", 12);
            Size = new Size(500, 400);
            Text = "Biletul 16";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            Label label=new Label();
            label.Text = "Sportul preferat";
            label.Location = new Point();
            label.Size = new Size();
            Controls.Add(label);

            TextBox textBox=new TextBox();
            textBox.Location = new Point();
            textBox.Size = new Size();
            Controls.Add(textBox);

            Label label2=new Label();
            label2.Text = "Hobby";
            label2.Location = new Point();
            label2.Size = new Size();
            Controls.Add(label2);

            TextBox textBox1 = new TextBox();
            textBox1.Location = new Point();
            textBox1.Size = new Size();
            Controls.Add(textBox1);

            Label label3=new Label();
            label3.Text = "Descrierea dumneavoastra ca persoana";
            label3.Location= new Point();
            label3.Size = new Size();
            Controls.Add(label3);

            RichTextBox textBox2 = new RichTextBox();
            textBox2.Location = new Point();
            textBox2.Size = new Size();
            Controls.Add(textBox2);

            Label label4=new Label();
            label4.Text = "Genul";
            label4.Location = new Point();
            label4.Size = new Size();
            Controls.Add(label4);

            Label label5=new Label();
            label5.Text = "Starea civila";
            label5.Location = new Point();
            label5.Size = new Size();
            Controls.Add(label5); 

            Button button=new Button();
            button.Location = new Point();
            button.Size = new Size();
            button.Text = "Trimite";
            button.BackColor = Color.Aquamarine;
            button.Click += Button_Click;
            Controls.Add(button);
        }
        private void Button_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("");
        }
    }
}