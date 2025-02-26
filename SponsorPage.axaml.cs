using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace MarathonSkills2016;

public partial class SponsorPage : Window
{
    public SponsorPage()
    {
        InitializeComponent();
    }

    private void Button_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        UpdateDonationAmount(-1);
    }

    private void Button_Click_1(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        UpdateDonationAmount(1);
    }
    private void UpdateDonationAmount(int change)
    {
        if (int.TryParse(DonationAmountTextBox.Text.Replace("$", ""), out int currentAmount))
        {
            int newAmount = currentAmount + change;
            if (newAmount > 0)
            {
                DonationAmountTextBox.Text = "$" + newAmount;
            }
        }
    }

    private void BackToMain(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        var backwindow = new MainWindow();
        backwindow.Show();
        this.Close();
    }
}