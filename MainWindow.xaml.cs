using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KSDist
{
    public class _Icon
    {
        public Bitmap NormalIcon { get; set; }
        public Bitmap BigIcon { get; set; }
        
        public _Icon()
        {
            // unset
            NormalIcon = KSDist.Properties.Resources.error32;
            BigIcon = KSDist.Properties.Resources.error64;
        }

        public Stream BigIconPNG()
        {
            MemoryStream mem = new MemoryStream();
            BigIcon.Save(mem, ImageFormat.Png);
            return mem;
        }
        public Stream NormalIconPNG()
        {
            MemoryStream mem = new MemoryStream();
            NormalIcon.Save(mem, ImageFormat.Png);
            return mem;
        }
    }

    public class GrigmaBalls 
    {

    }
    public partial class MainWindow : Window
    {
        public List<string> sigma = new List<string>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
