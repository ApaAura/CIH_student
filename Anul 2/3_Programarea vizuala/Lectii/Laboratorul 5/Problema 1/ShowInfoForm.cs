using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Problema_1
{
    public partial class ShowInfoForm : Form
    {
        public ShowInfoForm(string info)
        {
            InitializeComponent();
            Font = new Font("Verdana", 12);
            Size = new Size(400, 400);
            Text = "Show Info";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            Label lb = new Label();
            lb.Location = new Point(120,120);
            lb.Size = new Size(180,45);
            lb.Text = info;
            Controls.Add(lb);
        }
    }
}
