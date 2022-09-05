using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sarcina_3
{
    public partial class Infocs : Form
    {
        public string Login { get; set; }
        public string Password { get; set; }

        TextBox txt;
        TextBox txt2;
        public Infocs()
        {
            InitializeComponent();

            Font = new Font("Verdana", 14);
            Size = new Size(300, 300);
            Text = "Log In";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            Label lb1=new Label();
            lb1.Size = new Size(120,30);
            lb1.Location = new Point(20,50);
            lb1.Text = "Username";
            Controls.Add(lb1);

            txt=new TextBox();
            txt.Location = new Point(20,80);
            txt.Size = new Size(240,30);
            Controls.Add(txt);

            Label lb2=new Label();
            lb2.Size = new Size(120,30);
            lb2.Location = new Point(20,120);
            lb2.Text = "Password";
            Controls.Add(lb2);

            txt2=new TextBox();
            txt2.Location = new Point(20,150);
            txt2.Size = new Size(240,30);
            Controls.Add(txt2);

            Button btn=new Button();
            btn.Location = new Point(75,190);
            btn.Size = new Size(130,40);
            btn.Text = "Log In";
            btn.Click += Btn_Click;
            Controls.Add(btn);
        }
        private void Btn_Click(object? sender, EventArgs e)
        {
            Login = (txt.Text!=null&&txt.Text.Length!=0)?txt.Text:"Invalid";
            Password = (txt2.Text != null && txt2.Text.Length != 0) ? txt2.Text : "Invalid";
            this.Close();
        }
    }
}
