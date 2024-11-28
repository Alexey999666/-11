using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace практос_11
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        /// <summary>
        /// закрывает программу
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Информация о задании
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInfo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Дана строка 'ave a#b a2b a$b a4b a5b a-b acb'. Напишите регулярное выражение, \r\nкоторое найдет строки следующего вида: по краям стоят буквы 'a' и 'b', а между \r\nними - не буква и не цифра.\r\nНапишите регулярное выражение, м найдет строки следующего вида: по краям \r\nстоят буквы 'a', а между ними - буква от a до g", "Задание", MessageBoxButton.OK, MessageBoxImage.Question);
        }
        /// <summary>
        /// Информация о разработчике
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeveloper_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Андрианов Алексей Вариант 14", "Разработчик", MessageBoxButton.OK, MessageBoxImage.Question);
        }
       
        /// <summary>
        /// Очищает все TextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClean_Click(object sender, RoutedEventArgs e)
        {
            tbExpression1.Clear();
            tbExpression2.Clear();
            tbRez.Clear();
        }
        /// <summary>
        /// Находим совпадения в первой строке
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFind1_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(tbExpression1.Text))
            {
                tbRez.Clear();
                string expression = tbExpression1.Text;
                string pattern = "a[^0-9a-zA-Z]+b";
                MatchCollection matches = Regex.Matches(expression, pattern);/// Класс для подсчета успешных совпадений
                foreach (Match match in matches)
                {
                    tbRez.Text += match.Value + " ";
                }

            }
            else MessageBox.Show("Пусто", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }
        /// <summary>
        /// Находим совпадения в второй строке
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFind2_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(tbExpression2.Text))
            {
                tbRez.Clear();
                string expression = tbExpression2.Text;
                string pattern = "a[a-g]{1}a";
                MatchCollection matches = Regex.Matches(expression, pattern);/// Класс для подсчета успешных совпадений
                foreach (Match match in matches)
                {
                    tbRez.Text += match.Value + " ";
                }

            }
            else MessageBox.Show("Пусто", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}