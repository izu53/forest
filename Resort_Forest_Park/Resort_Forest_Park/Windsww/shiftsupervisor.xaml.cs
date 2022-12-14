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
using System.Windows.Shapes;

namespace Resort_Forest_Park.Windsww
{
    /// <summary>
    /// Логика взаимодействия для shiftsupervisor.xaml
    /// </summary>
    public partial class shiftsupervisor : Window
    {
        public shiftsupervisor()
        {
            InitializeComponent();
            DataGridP.ItemsSource = App.forestEntities.Servicee.ToList();
        }
        System.Windows.Threading.DispatcherTimer timer = new System.Windows.Threading.DispatcherTimer();
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            timer.Tick += new EventHandler(timerTick);
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Start();
        }
        int r = 60;
        private void timerTick(object sender, EventArgs e)
        {
            r -= 1;
            l1.Content = "0:" + r.ToString();
            if (r == 30)
            {
                MessageBox.Show("Через 30 с. вас выкинит с аккаунта");
            }
            if (r == 0)
            {
                timer.Stop();
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                Close();
            }
        }

        private void vx_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }
    }
}
