using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace DnDMusic
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //this.cef.Address = @"https://www.youtube.com/watch?v=KZQBEynt3vA&list=PL2VAyAqd6lNqSm9sIi4u4ih7bzqSYNCDI&index=2&t=0s";

            var start0 = new ProcessStartInfo(
                @"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe",
                "--app=https://music.youtube.com");
            var start = new ProcessStartInfo(
                @"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe",
                @"https://www.youtube.com/embed/watch?autoplay=1&v=KZQBEynt3vA&list=PL2VAyAqd6lNqSm9sIi4u4ih7bzqSYNCDI&index=2&t=0s");
            var process = new Process();
            process.StartInfo = start;
            process.Start();

            //https://developers.google.com/youtube/player_parameters
            //https://developers.google.com/identity/protocols/OAuth2InstalledApp
            //Freemake, save all, annotate, save graphics?
            //play mp3, volume, start, stop, loop, get track length, get mp3 metadata
            //use mp3 metadata for tags
            //https://stackoverflow.com/questions/2068344/how-do-i-get-a-youtube-video-thumbnail-from-the-youtube-api
        }
    }
}
