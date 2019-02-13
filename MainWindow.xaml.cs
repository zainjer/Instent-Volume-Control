using AudioSwitcher.AudioApi.CoreAudio;
using AudioSwitcher.AudioApi;
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

namespace Instent_Volume_Control
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        CoreAudioDevice defaultPlaybackDevice = new CoreAudioController().DefaultPlaybackDevice;
        public MainWindow()
        {
               
            //A fancy startup window
            StartupScreen(3500);

            // to make the window appear on the center of the screen
           
            InitializeComponent();
            MainWindowPositioning();
            this.Show();
            VolumeSlider.Value = defaultPlaybackDevice.Volume;
            VolumeProgress.Value = VolumeSlider.Value;
        }

        void MainWindowPositioning()
        {
            this.Top = -this.Height + 5;
            this.Left = SystemParameters.PrimaryScreenWidth / 2 - this.Width / 2;
            this.Opacity = 0.1;
        }

        async void StartupScreen(int delay) {

            this.Hide();
            starscreen a = new starscreen();
            a.Show();
            await Task.Delay(delay);
            a.Close();
        } 

        private void VolumeSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
           
            VolumeProgress.Value = VolumeSlider.Value;
            defaultPlaybackDevice.Volume = VolumeSlider.Value;
           
        }

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove(); 
        }

        private void Window_MouseEnter(object sender, MouseEventArgs e)
        {
            this.Opacity = 1;
            this.Top = 0;
            instent.Opacity = 1;
            ExitB.Opacity = 1;
        }

        private void Window_MouseLeave(object sender, MouseEventArgs e)
        {
            
           // await Task.Delay(150);
            instent.Opacity = 0;
            ExitB.Opacity = 0;
            this.Opacity = 0.1;
            this.Top = -this.Height + 5;
            this.Left = SystemParameters.PrimaryScreenWidth / 2 - this.Width / 2;
            
        }

        private void Grid_MouseEnter(object sender, MouseEventArgs e)
        {
          
        }

        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void ExitB_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
