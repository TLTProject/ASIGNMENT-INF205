using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Drawing.Design;
using System.Runtime.InteropServices;
using System.Windows.Forms;
namespace HuyenHBPS02214_ASSIGNMENT_INF205
{
    public class CustomColorTable : ProfessionalColorTable
    {
        public override Color MenuItemSelected
        {
            get { return Color.FromArgb(139, 0, 139); }
        }

        public override Color ToolStripDropDownBackground
        {
            get { return Color.FromArgb(128, 0, 128); }
        }

        public override Color ImageMarginGradientBegin
        {
            get { return Color.FromArgb(128, 0, 128); }
        }

        public override Color ImageMarginGradientEnd
        {
            get { return Color.FromArgb(128, 0, 128); }
        }

        public override Color ImageMarginGradientMiddle
        {
            get { return Color.FromArgb(128, 0, 128); }
        }

        public override Color MenuItemSelectedGradientBegin
        {
            get { return Color.FromArgb(128, 0, 128); }
        }
        public override Color MenuItemSelectedGradientEnd
        {
            get { return Color.FromArgb(128, 0, 128); }
        }

        public override Color MenuItemPressedGradientBegin
        {
            get { return Color.FromArgb(128, 0, 128); }
        }

        public override Color MenuItemPressedGradientMiddle
        {
            get { return Color.FromArgb(128, 0, 128); }
        }

        public override Color MenuItemPressedGradientEnd
        {
            get { return Color.FromArgb(128, 0, 128); }
        }

        public override Color MenuItemBorder
        {
            get { return Color.FromArgb(139, 0, 139); }

        }
    }
}
