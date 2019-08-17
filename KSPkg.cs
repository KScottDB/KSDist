using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSDist {

    public class Icon {
        private Stream _niconPNG;
        private Stream _biconPNG;
        public Stream NormalIconPNG { get => _niconPNG; }
        public Stream BigIconPNG { get => _biconPNG; }

        private Bitmap _nicon;
        private Bitmap _bicon;
        public Bitmap NormalIcon {
            get => _nicon;
            set {
                _nicon = value;
                _niconPNG = BitmaptoPNG(value); // update PNG stream
            }
        }
        public Bitmap BigIcon {
            get => _bicon;
            set {
                _bicon = value;
                _biconPNG = BitmaptoPNG(value); // update PNG stream
            }
        }

        public Icon() {
            // unset
            NormalIcon = KSDist.Properties.Resources.error32;
            BigIcon = KSDist.Properties.Resources.error64;
        }

        private Stream BitmaptoPNG(Bitmap b) {
            MemoryStream mem = new MemoryStream();
            b.Save(mem, ImageFormat.Png);
            return mem;
        }
    }

    public class KSPkg {

        public string Name { get; set; }

        public Icon Icon { get; set; }

        public string Directory { get; set; }

    }

}
