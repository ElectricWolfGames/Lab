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
