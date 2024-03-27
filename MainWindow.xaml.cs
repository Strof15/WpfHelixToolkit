using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

using HelixToolkit.Wpf;

namespace WpfHelixToolkit
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<string> sorok = File.ReadAllLines("gyongyok.txt").Skip(1).ToList();
            List<Bogyo> bogyoklistaja = new();

            foreach (string sor in sorok)
            {
                bogyoklistaja.Add(new Bogyo(sor));
            }
            foreach (Bogyo bogyo in bogyoklistaja)
            {
                EllipsoidVisual3D peldabogyo = new();
                peldabogyo.Center = new Point3D(bogyo.X, bogyo.Y, bogyo.Z);
                peldabogyo.Fill = new SolidColorBrush(Colors.Beige);
                ter.Children.Add(peldabogyo);
            }

        }
    }
}