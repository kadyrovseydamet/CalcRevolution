using System;
using System.Collections.Generic;
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

namespace CalcRevolution
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, RoutedEventArgs e) // при клике на цифре срабатывает это условие
        {
            Button numbers1 = (Button)sender; // записывает нажатые кнопки
            if (Convert.ToString(label1.Content) == "0") // если label = 0 то...
            {
                label1.Content = numbers1.Content; // записывает в label.Content текст нажатой кнопки
            }
            else
            {
                label1.Content += Convert.ToString(numbers1.Content); // записывает в label - label + строку текста кнопки
            }
        }

        private void button3_Click(object sender, RoutedEventArgs e) // нажатие на запятую
        {
            Button numbers1 = (Button)sender; // опять добавил запись в numbers1 нажатой кнопки
            if (!Convert.ToString(label1.Content).Contains(Convert.ToString("."))) // если в label есть запятая, то вторую написать уже нельзя
            {
                label1.Content += Convert.ToString(numbers1.Content);
            }
        }

        string numbers2; // создал переменную number2
        string action; // создал переменную action

        private void button20_Click(object sender, RoutedEventArgs e) // нажатие на действия "+, -, *, /"
        {
            if (Convert.ToString(label1.Content) == "0" || Convert.ToString(label1.Content) == "") // если label равен нулю или пустой строке, то...
            {
                label1.Content = "-"; // написать минус
            }
            else // иначе выполнить это условие
            {
                Button action2 = (Button)sender; // записывает на какое из пяти действий нажали
                action = Convert.ToString(action2.Content); // переменная action принимает текст action2("+, -, *, /")
                numbers2 = Convert.ToString(label1.Content); // в переменную number2 записывается первые числа
                label1.Content = "0"; // после нажатия на экране загарется "0"
            }
        }

        private void button21_Click(object sender, RoutedEventArgs e) // при нажатии на эту кнопку стирается последний символ
        {
            if (Convert.ToString(label1.Content).Length - 1 == 0)
            {
                label1.Content = "0"; // при равном нулю, стирать при нажатии не будет
            }
            else
            {
                label1.Content = Convert.ToString(label1.Content).Substring(0, Convert.ToString(label1.Content).Length - 1); // при не равном нулю, стирать при нажатии будет
            }
        }

        private void button17_Click(object sender, RoutedEventArgs e) // кнопка стирает все что есть
        {
            label1.Content = "0";
        }

        private void button4_Click(object sender, RoutedEventArgs e) // при нажатии на равно будет...
        {
            Button action2 = (Button)sender;
            if (action == "+") // прибавлять переменную и объект, сконвертировав в число с плавающей точкой
                label1.Content = Convert.ToDouble(label1.Content) + Convert.ToDouble(numbers2);
            if (action == "-") // вычитает переменную и объект, сконвертировав в число с плавающей точкой
                label1.Content = Convert.ToDouble(numbers2) - Convert.ToDouble(label1.Content);
            if (action == "*") // умножает переменную и объект, сконвертировав в число с плавающей точкой
                label1.Content = Convert.ToDouble(label1.Content) * Convert.ToDouble(numbers2);
            if (action == "/") // делит переменную и объект, сконвертировав в число с плавающей точкой
                label1.Content = Convert.ToDouble(numbers2) / Convert.ToDouble(label1.Content);
            if (action == "%") // находит процент от числа
                label1.Content = Convert.ToDouble(numbers2) / 100 * Convert.ToDouble(label1.Content);
        }

        private void button18_Click(object sender, RoutedEventArgs e) // при вводе числа или числел и нажатия на кнопку "1/x"
        {
            label1.Content = 1 / Convert.ToDouble(label1.Content);
        }

        private void button1_Click(object sender, RoutedEventArgs e) // при вводе числа или числел и нажатия "+/-"
        {
            double plusminus = Convert.ToDouble(label1.Content);
            double plusminus1 = -plusminus; // меняет + на - и обратно
            label1.Content = Convert.ToString(plusminus1);
        }

        private void button22_Click(object sender, RoutedEventArgs e)
        {
            label1.Content = Convert.ToDouble(label1.Content) * Convert.ToDouble(label1.Content);
        }

        private void button23_Click(object sender, RoutedEventArgs e)
        {
            double root = Convert.ToDouble(label1.Content);
            label1.Content = Math.Sqrt(root);

        }

        private void button24_Click(object sender, RoutedEventArgs e)
        {
            double n, i, fac = 1, summ = 0;
            n = Convert.ToDouble(label1.Content);
            for (i = 1; i <= n; i++)
            {
                fac = fac * i;
                summ = summ + i;
                label1.Content = fac;
            }
        }
    }
}