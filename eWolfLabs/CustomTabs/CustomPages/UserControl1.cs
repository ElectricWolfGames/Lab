using System.Windows.Forms;

namespace CustomTabs.CustomPages
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        public TabPage Page()
        {
            return tabControl1.TabPages[0];
        }
    }
}