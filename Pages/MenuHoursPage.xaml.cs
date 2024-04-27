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
using VovaPractics.BD;

namespace VovaPractics.Pages
{
    /// <summary>
    /// Логика взаимодействия для MenuHoursPage.xaml
    /// </summary>
    public partial class MenuHoursPage : Page
    {

        private static int secondsElapsed = 0; // Поле для хранения времени
        Model1 context;
        Window window;
        private TextBlock txtTimer;
        public MenuHoursPage(Model1 cont, int initialSecondsElapsed, TextBlock textBlock)
        {
            InitializeComponent();
            context = cont;
            secondsElapsed = initialSecondsElapsed; // Сохранение начального значения времени
            txtTimer = textBlock;
        }

        private void OneHours_Click(object sender, RoutedEventArgs e)
        {
            //Создание объекта для генерации чисел
            Random rnd = new Random();
            //Получить очередное (в данном случае - первое) случайное число
            int value = rnd.Next(0,2);
            if (value == 0) MessageBox.Show("Спасибо за покупку! Ваш код: HtSpw682");
            if (value == 1) MessageBox.Show("Спасибо за покупку! Ваш код: sTas85w3");
            if (value == 2) MessageBox.Show("Спасибо за покупку! Ваш код: sat53dfpw0");
        }
        private void TwoHours_Click(object sender, RoutedEventArgs e)
        {
            // Отображаем сообщение об успешной покупке
            Random rnd = new Random();
            //Получить очередное (в данном случае - первое) случайное число
            int value = rnd.Next(3, 5);
            if (value == 3) MessageBox.Show("Спасибо за покупку! Ваш код: ft856dpasd");
            if (value == 4) MessageBox.Show("Спасибо за покупку! Ваш код: fSps776");
            if (value == 5) MessageBox.Show("Спасибо за покупку! Ваш код: dgfpfg2");
        }

        private void FiveHours_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            //Получить очередное (в данном случае - первое) случайное число
            int value = rnd.Next(6, 7);
            if (value == 6) MessageBox.Show("Спасибо за покупку! Ваш код: dS61fpaw2");
            if (value == 7) MessageBox.Show("Спасибо за покупку! Ваш код: hHtfS4apw2");
        }

        private void TenHours_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            //Получить очередное (в данном случае - первое) случайное число
            int value = rnd.Next(8, 9);
            if (value == 8) MessageBox.Show("Спасибо за покупку! Ваш код: hgtd21Spw2");
            if (value == 9) MessageBox.Show("Спасибо за покупку! Ваш код: HtfSpds232w2");
        }
    }
}
