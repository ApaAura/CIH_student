namespace Problema_9
{
    public partial class Form1 : Form
    {
        //PictureBox - Exemplu de utilizare
        public Form1()
        {
            InitializeComponent();
            Default();
        }
        private void Default()
        {
            Font = new Font("Verdana", 10);
            Size = new Size(400, 400);
            Text = "Problema 9";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            GroupBox Grup=new GroupBox();
            Grup.Location = new Point(35,30);
            Grup.Size = new Size(320,300);
            Grup.Text = "Profilul utilizatorului : ";

            PictureBox Photo= new PictureBox();
            Photo.Location = new Point(20,50);
            Photo.Size = new Size(140,190);
            Photo.Load("Image1.jpg");
            Grup.Controls.Add(Photo);

            Label l1=new Label();
            l1.Text = "Nume : ";
            l1.Location = new Point(180,60);
            l1.Size = new Size(100,20);
            Grup.Controls.Add(l1);

            Label l2=new Label();
            l2.Text = "Ariana Grande";
            l2.Location = new Point(180,80);
            l2.Size = new Size(130,20);
            Grup.Controls.Add(l2);

            Label l3=new Label();
            l3.Text = "Ocupatie : ";
            l3.Location = new Point(180,120);
            l3.Size = new Size(100,20);
            Grup.Controls.Add(l3);

            Label l4=new Label();
            l4.Text = "Singer";
            l4.Location = new Point(180,140);
            l4.Size = new Size(100,20);
            Grup.Controls.Add(l4);

            Label l5=new Label();
            l5.Text = "Data nasterii : ";
            l5.Location = new Point(180,180);
            l5.Size = new Size(120,20);
            Grup.Controls.Add(l5);

            Label l6=new Label();
            l6.Text = "x/y/z";
            l6.Location = new Point(180,200);
            l6.Size = new Size(100,20);
            Grup.Controls.Add(l6);

            Controls.Add(Grup);
        }
    }
}