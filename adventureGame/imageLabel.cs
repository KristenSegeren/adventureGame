using System.Drawing;
using System.Windows.Forms;

namespace adventureGame
{
    internal class imageLabel : Label
    {
        private Bitmap street;

        public imageLabel(Bitmap street)
        {
            this.street = street;
        }
    }
}