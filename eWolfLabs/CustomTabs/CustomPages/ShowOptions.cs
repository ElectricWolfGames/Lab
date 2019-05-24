using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomTabs.CustomPages
{
    public partial class ShowOptions : UserControl
    {
        public ShowOptions()
        {
            InitializeComponent();
        }

        public TabPage Page()
        {
            return tabControl1.TabPages[0];
        }
    }
}
