using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sarcina_2
{
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
            Font = new Font("Verdana", 16);
            Size = new Size(400, 300);
            Text = "Show";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            Label lb=new Label();
            lb.Text = "Fereastra copil !";
            lb.Location = new Point(100,100);
            lb.Size = new Size(200,40);
            Controls.Add(lb);
        }
    }
}
