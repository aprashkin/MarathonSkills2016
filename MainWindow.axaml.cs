using Avalonia.Controls;
using Avalonia.Threading;
using System;
using System.Globalization;
using System.Threading.Tasks;

namespace MarathonSkills2016
{
    public partial class MainWindow : Window
    {
        public DateTime time = DateTime.Now;
        public MainWindow()
        {
            InitializeComponent();
            
            async void CurrentTimeUpdate()
            {
                    while (true)
                    {
                        await Dispatcher.UIThread.InvokeAsync(() =>
                        {
                            CultureInfo culture = new CultureInfo("ru-RU");
                            CurrentDateTimeTextBlock.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy", culture);
                        });
                        await Task.Delay(1000); // Wait for a second
                    }
            }
            CurrentTimeUpdate();
        }

        private void WannaBeRunner(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            var newwindow = new Window1();
            newwindow.Show();
            this.Close();
        }

        private void WannaBeSponsor(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            var newwindow1 = new SponsorPage();
            newwindow1.Show();
            this.Close();
        }
    }
}