using System.Web.UI;

namespace HomeForms
{
    public class LiteralControlDisplay
    {
        private LiteralControl _literalControl;
        private string _display;

        public LiteralControlDisplay(System.Web.UI.WebControls.Panel pnlShowData)
        {
            _literalControl = new LiteralControl();
            pnlShowData.Controls.Add(_literalControl);
        }

        public string Display
        {
            get
            {
                return _display;
            }
            set
            {
                _display = value;
                _literalControl.Text = _display;
            }
        }
    }
}
