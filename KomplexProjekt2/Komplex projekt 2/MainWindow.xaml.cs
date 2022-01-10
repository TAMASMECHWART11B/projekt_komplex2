using System;
using System.Collections.Generic;
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
using System.Windows.Threading;

namespace Komplex_projekt_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            DispatcherTimer idozito = new DispatcherTimer();
            idozito.Interval = TimeSpan.FromSeconds(0.2);
            idozito.Tick += new EventHandler(Idozito);
            Random rnd = new Random();
            
            
            
        }

        private void Idozito(object sender, EventArgs e)
        {
            
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }
    }
}
