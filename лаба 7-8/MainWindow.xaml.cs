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

namespace лаба_7_8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            InitializeComponent();
        }
        private void button1Zad_Click(object sender, RoutedEventArgs e)
        {
            textBlock1zad.Text = textBox1zad.Text;

        }

        private void button2zad2_Click(object sender, RoutedEventArgs e)
        {
            textBlock1zad.Text = textBlock1zad.Text.Replace("Nikolay", "Oleg");
        }

        private void button2zad_Click(object sender, RoutedEventArgs e)
        {
            int lenght = textBox2zad.Text.Length;
            textBlock2zad.Text = textBox2zad.Text + " lenght:" + lenght + ", " + textBox2zad.Text + " lenght:" + lenght + ", " + textBox2zad.Text + " lenght:" + lenght + ".";

        }

        private void button3zad_Click(object sender, RoutedEventArgs e)
        {
            string str3 = "";
            str3 = textBox3zad.Text;
            if (str3.Length % 2 == 0)
            {
                textBlock3zad.Text = "Первый символ:" + Convert.ToString(str3[0]) + "\n" + "Средний символ:" + Convert.ToString(str3.Length / 2) + "\n" + "Последний символ:" + Convert.ToString(str3[str3.Length - 1]);
            }
            else
            {
                textBlock3zad.Text = "Первый символ:" + Convert.ToString(str3[0]) + "\n" + "Последний символ:" + Convert.ToString(str3[str3.Length - 1]);

            }
        }

        private void button4zad_Click(object sender, RoutedEventArgs e)
        {
            textBlock4zad.Text = "";
            int k = 0;
            string str4 = textBox4zad.Text;
            List<int> num = new List<int>();
            for (int i = 0; i < str4.Length; i++)
            {
                if (str4[i] == str4[str4.Length - 1])
                {
                    num.Add(i);
                }
            }
            for (int i = 0; i < num.Count - 1; i++)
            {
                num[i] = num[i] + 1;
                textBlock4zad.Text += " Совпадает:" + num[i];

            }
        }

        private void button6Zad_Click(object sender, RoutedEventArgs e)
        {
            string str6 = textBox6Zad.Text;
            textBlock6zad.Text = "";
            for (int i = 2; i < str6.Length; i += 3)
            {
                textBlock6zad.Text += str6[i] + " ";

            }
            str6 = "";
        }

        private void button7Zad_Click(object sender, RoutedEventArgs e)
        {
            string str7 = textBox7Zad.Text;
            int k = 0;
            int l = 0;
            for (int i = 0; i < str7.Length - 1; i++)
            {
                if (str7[i] == '+' || str7[i] == '-')
                {
                    k++;
                }
            }
            textBlock7zad.Text += "\nКоличество + и - : " + k;
        }

        private void button7zad1_Click(object sender, RoutedEventArgs e)
        {
            string str7 = textBox7Zad.Text;
            int k = 0;
            int l = 0;
            for (int i = 0; i < str7.Length - 1; i++)
            {
                if (str7[i] != '0' & str7[i + 1] == '0')
                {
                    l++;
                }
            }
            textBlock7zad.Text += "\nКоличество нулей : " + l;

        }

        private void button7Zad_Click_1(object sender, RoutedEventArgs e)
        {
            textBlock8zad.Text = "";
            string str = textBox8Zad.Text;
            int w = -1;
            int x = -1;
            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str[i] == 'x' || str[i] == 'X')
                    x = i;
                if (str[i] == 'w' || str[i] == 'W')
                    w = i;

            }
            if (x > w)
            {
                textBlock8zad.Text += "X раньше; ";
            }
            if (w > x)
            {
                textBlock8zad.Text += "W раньше; ";
            }
            if (str.Contains("x") == false & str.Contains("X") == false)
            {
                textBlock8zad.Text += "X нет; ";
            }
            if (str.Contains("w") == false & str.Contains("W") == false)
            {
                textBlock8zad.Text += "W нет; ";
            }
            str = "";



        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string str = textBox9Zad.Text;
            string str1 = textBox9Zad1.Text;

            if (str.Length > str1.Length)
            {
                for (int i = 0; i < (str.Length) - (str1.Length); i++)
                {
                    textBlock9zad.Text += str + "\n";
                }
            }
            else
            {
                for (int i = 0; i < (str1.Length) - (str.Length); i++)
                {
                    textBlock9zad.Text += str1 + "\n";
                }
            }
        }

        private void button10Zad_Click(object sender, RoutedEventArgs e)
        {
            textBlock10zad.Text = "";
            string str = textBox10Zad.Text;
            if (str[0] == 'a' & str[1] == 'b' & str[2] == 'c')
            {
                str = str.Replace("abc", "www");
            }
           ///
            else
            {
                str += "zzz";
            }
            textBlock10zad.Text = str;
            str = "";
        }

        private void button11Zad_Click(object sender, RoutedEventArgs e)
        {
            textBlock11zad.Text = "";
            string str = textBox11Zad.Text;
            if (str.Length > 10)
            {
                for (int i = 10; i >= 6; i--)
                {
                    str = str.Remove(i);

                }
            }
            else
            {
                while (str.Length + 1 <= 12)
                {
                    str += "о";
                }

            }
            textBlock11zad.Text = str;
            str = "";
        }

        private void button12Zad_Click(object sender, RoutedEventArgs e)
        {
            textBlock12zad.Text = "";
            int k = 0;
            string str = textBox12Zad.Text;
            foreach (char c in str)
            {
                if (char.IsDigit(c))
                {
                    k++;
                }
            }
            textBlock12zad.Text = "Количество цифр в строке: " + k;
            str = "";
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            textBlock13zad.Text = "";
            string str = textBox13Zad.Text;
            string res = str.Trim('a').Trim('b').Trim('c');
            if (res.Length == 0)
            {
                textBlock13zad.Text = "Строка содержит только символы 'a','b','c";
            }
            else
            {
                textBlock13zad.Text = "Строка уникальна";
            }
            str = "";
            res = "";

        }

        private void button14Zad_Click(object sender, RoutedEventArgs e)
        {
            string str = textBox14Zad.Text;
            str = str.Replace("word", "letter");
            textBlock14zad.Text = str;
        }
        public string text = "";
        private void button15Zad_Click(object sender, RoutedEventArgs e)
        {

            textBlock15zad.Text = "";
            text = textBox15Zad.Text;
            textBlock15zad.Text = text;

        }

        private void button15Zad2_Click(object sender, RoutedEventArgs e)
        {
            text = text.Replace("xabc", "abc");
            textBlock15zad.Text = text;
            text = "";
        }

        private void button17Zad_Click(object sender, RoutedEventArgs e)
        {
            string str = textBox17Zad.Text;
            for (int i = 0; i < str.Length; i++)
            {
                if (i == str.Length - 3)
                {
                    break;
                }
                else
                {
                    if (char.IsDigit(str[i]) & str[i + 1] == 'a' & str[i + 2] == 'b' & str[i + 3] == 'c')
                    {
                        str = str.Replace("abc", "");
                    }
                }
            }

            textBlock17zad.Text = str;
        }

        private void button18Zad_Click(object sender, RoutedEventArgs e)
        {
            string str = textBox18Zad.Text;
            int k = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (i == str.Length - 2)
                {
                    break;
                }
                if (str[i] == 'a' & str[i + 1] == 'b' & str[i + 2] == 'a')
                {
                    k++;
                }
            }
            textBlock18zad.Text = "Число вхождений: " + k;
        }

       
    }
}
