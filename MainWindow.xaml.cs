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

namespace KSDist {
    public partial class MainWindow : Window {

        public MainWindow() {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {

            if (!File.Exists("pkg.ndx")) {
                window.Hide();

                MessageBoxResult a = MessageBox.Show("Is this the first time you've opened KSDist?", "KSDist", MessageBoxButton.YesNo);
                if (a==MessageBoxResult.Yes) {
                    // Yes
                    File.WriteAllText("pkg.ndx", "");
                    a = MessageBox.Show(
                        "Welcome to KSDist!\n" +
                        "You do not have any packages.\n" +
                        "Someone else will have to send some to you,\n" +
                        "or, if you're the computer savvy type, you can try to make some!\n" +
                        "Do you want to view the help file before continuing?",
                        "KSDist", MessageBoxButton.YesNo);
                    if (a==MessageBoxResult.Yes) {
                        // View the help file
                        System.Windows.Forms.Help.ShowHelp()
                    } else {
                        // Do not
                        MessageBox.Show(
                        "Okay! It's always accessible if you need it!",
                        "KSDist", MessageBoxButton.OK);
                    }
                } else {
                    // No
                    a = MessageBox.Show(
                        "Oh no...!\n" +
                        "Your Package Index file (pkg.ndx) seems to have been deleted!\n" +
                        "Do you want me to try to regenerate it?",
                        "KSDist", MessageBoxButton.YesNo);

                }

                window.Show();
            }

            lstvwIcons.Items.Add(new KSPkg() {
                Name = "Hello World",
                Icon = new Icon() {
                    NormalIcon = KSDist.Properties.Resources.unkpkg32,
                    BigIcon = KSDist.Properties.Resources.unkpkg64
                }
            });

            lstvwIcons.Items.Add(new KSPkg() {
                Name = "Dummy",
                Icon = new Icon()
            });

        }

        private void LstvwIcons_SelectionChanged(object sender, SelectionChangedEventArgs e) {

        }

        private void BtnSend_Click(object sender, RoutedEventArgs e) {
            if (lstvwIcons.SelectedIndex == -1) {
                MessageBox.Show("Select a package to send first.", "KSDist");
                return;
            }
        }

        private void BtnRecieve_Click(object sender, RoutedEventArgs e) {

        }
    }
}
