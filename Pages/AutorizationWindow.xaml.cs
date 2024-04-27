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
using static OfficeOpenXml.ExcelErrorValue;

namespace VovaPractics.Pages
{
    /// <summary>
    /// Логика взаимодействия для AutorizationWindow.xaml
    /// </summary>
    public partial class AutorizationWindow : Page
    {
        Model1 context;
        Window Window;
        Codes Copy;
        private DispatcherTimer timer;
        private int secondsElapsed = 3600;

        public AutorizationWindow(Model1 cont, Window window, int initialSecondsElapsed)
        {
            InitializeComponent();
            context = cont;
            Window = window;

            // Создание и настройка таймера
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;

            // Установка начального значения времени
            secondsElapsed = initialSecondsElapsed;

            // Запуск таймера
            timer.Start();

        }
        private void MenuPage_TimerUpdated(object sender, int secondsElapsed)
        {
            // Обновление значения таймера
            // Например, вывод в консоль
            Console.WriteLine("New timer value: " + TimeSpan.FromSeconds(secondsElapsed).ToString(@"hh\:mm\:ss"));
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Уменьшение значения времени
            secondsElapsed--;

            // Проверка, достигнуто ли значение 0
            if (secondsElapsed <= 0)
            {
                // Остановка таймера
                timer.Stop();

                // Открытие окна авторизации
                NavigationService.Navigate(new MenuPage(context, Window));
            }
            else
            {
                // Обновление текста в TextBlock
                txtTimer.Text = TimeSpan.FromSeconds(secondsElapsed).ToString(@"hh\:mm\:ss");
            }
        }
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MenuPage(context, Window));
        }

        private MenuHoursPage menuHoursPage;

        private void MenuHours_Click(object sender, RoutedEventArgs e)
        {
            if (menuHoursPage == null)
            {
                menuHoursPage = new MenuHoursPage(context, secondsElapsed, txtTimer);
            }
            FrameToBasePage.Navigate(menuHoursPage);
        }


        private void MenuFood_Click(object sender, RoutedEventArgs e)
        {
            FrameToBasePage.Navigate(new MenuFoodPage(context));
        }

        private void Pc_Click(object sender, RoutedEventArgs e)
        {
            FrameToBasePage.Navigate(new PcPage(context));
        }


        // <?> код для диплома
        private void Promo_Click(object sender, RoutedEventArgs e)
        {
            string value = PromoBox.Text;
            switch (value)
            {
                case "HtSpw682":
                case "sTas85w3":
                    secondsElapsed += 3600;
                    txtTimer.Text = TimeSpan.FromSeconds(secondsElapsed).ToString(@"hh\:mm\:ss");
                    MessageBox.Show("Промокод Активирован. Вам добавлен 1ч");
                    break;
                case "ft856dpasd":
                case "fSps776":
                case "dgfpfg2":
                    secondsElapsed += 7200;
                    txtTimer.Text = TimeSpan.FromSeconds(secondsElapsed).ToString(@"hh\:mm\:ss");
                    MessageBox.Show("Промокод Активирован. Вам добавлено 2ч");
                    break;
                case "dS61fpaw2":
                case "hHtfS4apw2":
                    secondsElapsed += 18000;
                    txtTimer.Text = TimeSpan.FromSeconds(secondsElapsed).ToString(@"hh\:mm\:ss");
                    MessageBox.Show("Промокод Активирован. Вам добавлено 5ч");
                    break;
                case "hgtd21Spw2":
                case "HtfSpds232w2":
                    secondsElapsed += 36000;
                    txtTimer.Text = TimeSpan.FromSeconds(secondsElapsed).ToString(@"hh\:mm\:ss");
                    MessageBox.Show("Промокод Активирован. Вам добавлено 10ч");
                    break;
                default:
                    MessageBox.Show("Ошибка: Неверный промокод");
                    break;
            }
            // <?> код для диплома
        }
    }
}
