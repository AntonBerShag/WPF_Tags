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

namespace WPF_Tags
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Button[] squares = new Button[12];
        int[] num = new int[12];
        int[] sum = new int[12];
        public MainWindow()
        {
            InitializeComponent();
            gameTags();
        }
        void gameTags()
        {
            GetRandom();
            int a = 50, b = 100;
            for (int i = 0; i < 12; i++)
            {
                squares[i] = new Button();
                squares[i].Height= 100;
                squares[i].Width= 100;
                squares[i].Margin = new Thickness(a, b, 0, 0);
                squares[i].HorizontalAlignment= HorizontalAlignment.Left;
                squares[i].VerticalAlignment = VerticalAlignment.Top;
                squares[i].Background = new SolidColorBrush(Colors.Bisque);
                squares[i].FontSize = 50;
                if (sum[i] != 0)
                {
                    squares[i].Content = sum[i].ToString();
                }
                a += 100;
                if ((i + 1) % 3 == 0)
                {
                    a = 50;
                    b += 100;
                }
                ContentPanel.Children.Add(squares[i]);
            }
        }

        void GetRandom()
        {
            for (int i = 0; i < 12; i++)
            {
                num[i] = i + 1;
                sum[i] = 0;
            }

            Random random = new Random();
            List<int> sum2 = new List<int>();

            for (int i = 0; i < 12; i++)
            {
                int a = random.Next(0, 12);
                while (sum2.Contains(a))
                {
                    a = random.Next(0, 12);
                }
                sum2.Add(a);
            }
            sum = sum2.ToArray();
        }
    }
}
