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

namespace WpfApp2   
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

        private void Window_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs pip)
        {
            Button щелк  = new Button   // Создала новую кнопку
            {
                Content = "Нажми", // Такой текст будет на кнопке
                // ниже задаю параметры кнопки: цвет, высоту и ширину
                Width = 60,
                Height = 25,
                Background = Brushes .DeepPink,
                Foreground= Brushes.Black,
            };

            // Определяю местонахождение кнопки
            Point место = pip.GetPosition(незанйка);
            Canvas.SetLeft(щелк, место.X);
            Canvas.SetTop(щелк, место.Y);

            незанйка.Children.Add(щелк);
        }
    }
}
