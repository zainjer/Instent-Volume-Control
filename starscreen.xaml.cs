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
using System.Windows.Shapes;

namespace Instent_Volume_Control
{
    /// <summary>
    /// Interaction logic for starscreen.xaml
    /// </summary>
    public partial class starscreen : Window
    {
        public starscreen()
        {
            InitializeComponent();
            this.Left = SystemParameters.PrimaryScreenWidth / 2 - this.Width / 2;
        }
    }
}
