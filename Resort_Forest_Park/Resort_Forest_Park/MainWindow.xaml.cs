using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using Resort_Forest_Park.Windsww;
using Resort_Forest_Park.Entities;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Runtime.InteropServices;
using System.Windows.Interop;
using Brush = System.Drawing.Brush;
using Brushes = System.Drawing.Brushes;
using Point = System.Drawing.Point;


namespace Resort_Forest_Park
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string text = String.Empty;
        private Bitmap CreateImage(int Width, int Height)
        {
            Random rnd = new Random();

            //Создадим изображение
            Bitmap result = new Bitmap(Width, Height);

            //Вычислим позицию текста
            int Xpos = rnd.Next(0, Width - 95);
            int Ypos = rnd.Next(15, Height - 25);

            //Добавим различные цвета
            Brush[] colors = { Brushes.Black,
                     Brushes.Red,
                     Brushes.Gold,
                     Brushes.Green,
                     Brushes.DarkBlue};

            //Укажем где рисовать
            Graphics g = Graphics.FromImage((System.Drawing.Image)result);

            //Пусть фон картинки будет серым
            g.Clear(System.Drawing.Color.Gray);

            //Сгенерируем текст
            text = String.Empty;
            string ALF = "1234567890QWERTYUIOPASDFGHJKLZXCVBNM";
            for (int i = 0; i < 5; ++i)
                text += ALF[rnd.Next(ALF.Length)];

            //Сгенерируем формат текста
            string[] st =
            {
            "Arial",
            "Times New Roman",
            "Lucida Calligraphy"
            };
            //Нарисуем сгенирируемый текст
            g.DrawString(text,
            new Font(st[rnd.Next(st.Length)], 15),
            colors[rnd.Next(colors.Length)],
            new PointF(Xpos, Ypos));

            //Добавим немного помех
            /////Линии из углов
            g.DrawLine(Pens.Black,
            new Point(0, 0),
            new Point(Width - 1, Height - 1));
            g.DrawLine(Pens.Black,
            new Point(0, Height - 1),
            new Point(Width - 1, 0));
            ////Белые точки
            for (int i = 0; i < Width; ++i)
                for (int j = 0; j < Height; ++j)
                    if (rnd.Next() % 20 == 0)
                        result.SetPixel(i, j, System.Drawing.Color.White);

            return result;
        }

        //If you get 'dllimport unknown'-, then add 'using System.Runtime.InteropServices;'
        [DllImport("gdi32.dll", EntryPoint = "DeleteObject")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool DeleteObject([In] IntPtr hObject);

        public ImageSource ImageSourceFromBitmap(Bitmap bmp)
        {
            var handle = bmp.GetHbitmap();
            try
            {
                return Imaging.CreateBitmapSourceFromHBitmap(handle, IntPtr.Zero, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());
            }
            finally { DeleteObject(handle); }
        }
        public MainWindow()
        {
            InitializeComponent();
        }
        int y = 0;
        int OH = 0;
        private void t_Click(object sender, RoutedEventArgs e)
        {
            if (y == 0)
            {
                pass.Visibility = Visibility.Hidden;
                pas.Visibility = Visibility.Visible;
                y = 1;
                pas.Text = pass.Password;

            }
            else
            {
                pass.Visibility = Visibility.Visible;
                pas.Visibility = Visibility.Hidden;
                y = 0;
                pass.Password = pas.Text;
            }
        }

        private void vx_Click(object sender, RoutedEventArgs e)
        {
            history history = new history();
            ForestEntities forest = new ForestEntities();
            Employees a = null;
            a = forest.Employees.Where(b => b.Login == log.Text && (b.Password == pass.Password || b.Password == pas.Text)).FirstOrDefault();
            if (a != null)
            {
                //ClassName.name = a.Name;
                //wer.Visibility = Visibility.Hidden;
                if (a.id_jobtitle == 1)
                {
                    admin admin = new admin();
                    admin.Show();
                    Close();
                    int i1 = a.id_employees;
                    string i2 = a.Login;
                    history.ra(i1,i2);
                }
                else
                {
                    if (a.id_jobtitle == 3)
                    {
                        salesman salesman = new salesman();
                        salesman.Show();
                        Close();
                        int i1 = a.id_employees;
                        string i2 = a.Login;
                        history.ra(i1, i2);
                    }
                    else
                    {
                        if (a.id_jobtitle == 2)
                        {
                            shiftsupervisor shift = new shiftsupervisor();
                            shift.Show();
                            Close();
                            int i1 = a.id_employees;
                            string i2 = a.Login;
                            history.ra(i1, i2);
                        }
                    }
                }
            }
            else
            {
                wer.Visibility = Visibility.Visible;
                OH = OH + 1;
                if (OH == 3)
                {
                    wer.Visibility = Visibility.Hidden;
                    ok.Visibility = Visibility.Visible;
                    IM.Visibility = Visibility.Visible;
                    IM.Source = ImageSourceFromBitmap(CreateImage(200, 50));
                    ehe.Visibility = Visibility.Visible;
                    e3.Visibility = Visibility.Visible;
                    vx.Visibility=Visibility.Hidden;

                }
               
            }
        }

        private void ehe_Click(object sender, RoutedEventArgs e)
        {
            IM.Source = ImageSourceFromBitmap(CreateImage(200, 50));
        }

        private void ok_Click(object sender, RoutedEventArgs e)
        {
            if (e3.Text == text)
            {
                OH = 0;
                IM.Visibility = Visibility.Hidden;
                ok.Visibility = Visibility.Hidden;
                ehe.Visibility = Visibility.Hidden;
                e3.Visibility = Visibility.Hidden;
                vx.Visibility = Visibility.Visible;
            }
            else
            {
                IM.Source = ImageSourceFromBitmap(CreateImage(200, 50));
            }
        }
    }
}
