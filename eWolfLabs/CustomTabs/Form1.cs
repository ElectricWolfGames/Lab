using CustomTabs.CustomPages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomTabs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            TabPage tp = new UserControl1().Page();

            this.tabControl1.TabPages.Add(tp);

            TabPage tp2 = new ShowOptions().Page();

            this.tabControl1.TabPages.Add(tp2);
        }
    }
}
