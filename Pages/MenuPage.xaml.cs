using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
using VovaPractics.BD;

namespace VovaPractics.Pages
{
    /// <summary>
    /// Логика взаимодействия для MenuPage.xaml
    /// </summary>
    public partial class MenuPage : Page
    {
        Model1 context;
        Window parentWindow;
        private int secondsElapsed = 5000;
        public MenuPage(Model1 cont, Window window)
        {
            InitializeComponent();
            context = cont;
            parentWindow = window;
        }
        private DispatcherTimer timer;

        // Диплом -->>>
        private void AuthorizationButton_Click(object sender, RoutedEventArgs e)
        {

            string enteredCode = KodBox.Text;
            Codes codes = context.Codes.ToList().Find(x => x.Code.Equals(enteredCode));
                if (codes != null)
            {
                if (codes.Code.Equals(enteredCode))
                {
                    NavigationService.Navigate(new AutorizationWindow(context, parentWindow, secondsElapsed));
                }
                else
                {
                    MessageBox.Show("Неверный код!!!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Неверный код!!!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        // <<<----Диплом

        // Диплом --->>
        private void BuyCode_Click(object sender, RoutedEventArgs e)
        {
            using (var context = new Model1()) // Замените YourDbContext на ваш контекст базы данных
            {
                // Генерация рандомного кода
                string randomCode = GenerateRandomCode(5);
                MessageBox.Show("Ваш код: " + randomCode + ".Спасибо за покупку вам начислен 1ч бонусом." );
                // Создаем новый объект Codes
                var newCode = new Codes
                {
                    Code = randomCode
                };

                // Добавляем созданный объект в DbSet
                context.Codes.Add(newCode);

                // Сохраняем изменения в базе данных
                context.SaveChanges();
            }
        }
        // <<<<----Диплом
        // Функция для генерации рандомного кода
        private string GenerateRandomCode(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"; // Все символы, из которых будет состоять код
            Random random = new Random();
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
