using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sarcina_1
{
    public partial class ChangeColorcs : Form
    {
        public ChangeColorcs()
        {
            InitializeComponent();
            Size = new Size(400, 300);
            Text = "Change color";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
    }
}
