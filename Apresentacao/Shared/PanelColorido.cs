using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsApp.Shared
{
    [ToolboxItem(true)]
    public class PanelColorido : Panel
    {
        private Color colorBorder = ColorTranslator.FromHtml("#B00731");

        public PanelColorido() : base()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.DrawRectangle(
                new Pen(new SolidBrush(colorBorder), 5), e.ClipRectangle);
        }

        public Color BorderColor
        {
            get
            {
                return colorBorder;
            }
            set
            {
                colorBorder = value;
            }
        }
    }
}
