using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _20pract;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void calculateBtn(object sender, RoutedEventArgs e)
    {
        if (!int.TryParse(inputN.Text, out int n) || n <= 0) //проверка на число и !<=0
        {
            MessageBox.Show("Введите положительное число.");
            return;
        }

        Random rand = new Random();
        string numbers = ""; // все числа
        int sum = 0;

        for (int i = 0; i < n; i++)
        {
            int number = rand.Next(0, (n / 2) + 1) * 2; // целые, четные, случайные числа от 0 до n

            // добавление числа в строку через запятую
            numbers += number;
            if (i < n - 1)
                numbers += ", ";

            // прибавление к сумме
            sum += number;
        }

        //вывод результатов
        output.Text = numbers;
        result.Text = sum.ToString();
    }

    private void ExitBtn(object sender, RoutedEventArgs e)
    {
       MessageBoxResult result =  MessageBox.Show(
                        "Вы действительно хотите выйти?",
                        "Подтвердение выхода",
                        MessageBoxButton.YesNo,
                        MessageBoxImage.Question);

        if (result == MessageBoxResult.Yes)
        {
            Application.Current.Shutdown();
        }
    }

    private void AboutAppBtn(object sender, RoutedEventArgs e)
    {
        MessageBox.Show(
                        "Селезнев Никита Денисович\n" +
                        "Група ИСП-22",
                        "Разработчик",
                        MessageBoxButton.OK, MessageBoxImage.Information);
    }


}