using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace MarathonSkills2016;

public partial class Window1 : Window
{
    public Window1()
    {
        InitializeComponent();
    }

    private void Login_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
    }

    private void Register_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {

    }

    private void BackToMain(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        var newwindow = new MainWindow();
        newwindow.Show();
        this.Close();
    }
}