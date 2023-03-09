using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Markup;
using System.Windows.Threading;
using static Microsoft.WindowsAPICodePack.Shell.PropertySystem.SystemProperties.System;
using Path = System.IO.Path;
using Task = Microsoft.WindowsAPICodePack.Shell.PropertySystem.SystemProperties.System.Task;


namespace audio
{

    public partial class MainWindow : Window
    {
        string filename;
        private List<string> _playlist;
        private bool _isPlaying;
        private bool _isRepeatOn;
        private bool _isShuffleOn;
        private DispatcherTimer _timer;
        private Thread _sliderThread;
        private Thread _timeThread;

        public MainWindow()
        {
            InitializeComponent();
            Thread t = new Thread(ChangeSeconds);
            t.Start();
            stop.IsEnabled = false;
            prev.IsEnabled = false;
            next.IsEnabled = false;
            restart12.IsEnabled = false;
            mix.IsEnabled = false;
            audio.IsEnabled = false;
            timestart.Text = "00:00";
            timestart.Text = "00:00";
        }
        private void restart(object sender, RoutedEventArgs e)
        {
            _isRepeatOn = !_isRepeatOn;
            if(_isRepeatOn){
                restart12.Opacity = 0.5;
            }
            else
            {
                restart12.Opacity = 1;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            CommonFileDialog dialog = new CommonOpenFileDialog{ IsFolderPicker = true };
            CommonFileDialogResult result = dialog.ShowDialog();
            if (result == CommonFileDialogResult.Ok)
            {
                var list = Directory.GetFiles(dialog.FileName, "*.*", SearchOption.AllDirectories).Where(file => file.EndsWith(".mp3") || file.EndsWith(".m4a") || file.EndsWith(".wav")).ToList();
                foreach (string file in list)
                {
                    musicList.Items.Add(file);
                    
                }
                _playlist = _isShuffleOn ? list.OrderBy(x => Guid.NewGuid()).ToList() : list;
                if (_playlist.Any())
                {
                    audio.Source = new Uri(_playlist.First());
                    _isPlaying = true;
                    audio.Play(); 
                    musicname.Text = Path.GetFileNameWithoutExtension(_playlist.First());
                    stop.IsEnabled = true;
                    prev.IsEnabled = true;
                    next.IsEnabled = true;
                    restart12.IsEnabled = true;
                    mix.IsEnabled = true;
                    audio.IsEnabled = true;
                }
                else
                {
                    MessageBox.Show("В этой папке не найдено ни одной аудиозаписи.");
                }
            }
            //1. открыть проводник и выбрать папку, откуда я возьму все файлы при помощи Directory.GetDirectories(), это было в 9 лекции
            //выгрузить все в комбобокс, который называется musicList
        }

        private void musicList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //2. как только я меняю выбор, я беру выбранный элемент при помощи musicList.SelectedItem и записываю его внутрь медиа элемента
            audio.Source = new Uri(musicList.SelectedItem.ToString());
        }
        private void audio_MediaOpened(object sender, RoutedEventArgs e)
        {
            musictime.Maximum = audio.NaturalDuration.TimeSpan.Ticks;
            timelast.Text = audio.NaturalDuration.TimeSpan.Minutes + ":" + audio.NaturalDuration.TimeSpan.Seconds;
        }
        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            audio.Position = new TimeSpan(Convert.ToInt64(musictime.Value));
            timestart.Text = audio.Position.Minutes + ":" + audio.Position.Seconds;
        }
        private void ChangeSeconds()
        {
            while (true)
            {
                Thread.Sleep(1000);
                this.Dispatcher.Invoke(new Action(() =>
                {
                    timestart.Text = audio.Position.Minutes + ":" + audio.Position.Seconds;
                    musictime.Value = audio.Position.Ticks;
                }));
            }
        }
            private void stop_Click(object sender, RoutedEventArgs e)
            {
            _isPlaying = !_isPlaying;
            if (_isPlaying)
            {
                audio.Pause();
                stop.Opacity = 0.5;
            }
            else
            {
                audio.Play();
                stop.Opacity = 1;
            }
        }
        private void prev_Click(object sender, RoutedEventArgs e)
        {
            var currentIndex = _playlist.IndexOf(audio.Source.LocalPath);
            var newIndex = currentIndex == 0 ? _playlist.Count - 1 : currentIndex - 1;
            audio.Source = new Uri(_playlist[newIndex]);
            _isPlaying = true;
            audio.Play();
            musicname.Text = Path.GetFileNameWithoutExtension(_playlist[newIndex]);
        }

        private void next_Click(object sender, RoutedEventArgs e)
        {
            var currentIndex = _playlist.IndexOf(audio.Source.LocalPath);
            var newIndex = currentIndex == _playlist.Count - 1 ? 0 : currentIndex + 1;
            audio.Source = new Uri(_playlist[newIndex]);
            _isPlaying = true;
            audio.Play();
            musicname.Text = Path.GetFileNameWithoutExtension(_playlist[newIndex]);  
        }

        private void mix_Click(object sender, RoutedEventArgs e)
        {
            var rnd = new Random();
            _playlist = _playlist.OrderBy(v => rnd.Next()).ToList();

        }
        private void Slider_ValueChanged_1(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            audio.Volume = volume.Value;
        }

        private void audio_MediaEnded(object sender, RoutedEventArgs e)
        {
            if (_isRepeatOn)
            {
                
                audio.Position = new TimeSpan(0, 0, 0);
                audio.Play();
            }
            else
            {
                restart12.Opacity = 1;
                var currentIndex = _playlist.IndexOf(audio.Source.LocalPath);
                var newIndex = currentIndex == _playlist.Count - 1 ? 0 : currentIndex + 1;
                audio.Source = new Uri(_playlist[newIndex]);
                _isPlaying = true;
                audio.Play();
                musicname.Text = Path.GetFileNameWithoutExtension(_playlist[newIndex]);
            }
        }
    }
}