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
using System.IO;
using Microsoft.Win32;
using System.Drawing;

namespace WpfLab4
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

        public int a_sprawdzam = 0;
        public int b = 0;

        private void wybor_klik(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                string selFileName = openFileDialog.FileName;

                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(selFileName);
                bitmap.EndInit();
                imycz.Source = bitmap;
            }
        }
        private void lustereczko_klik(object sender, RoutedEventArgs e)
        {
            imycz.RenderTransformOrigin = new System.Windows.Point(0.5, 0.5);
            ScaleTransform flipTrans = new ScaleTransform();
            if (a_sprawdzam == 0)
            {
                flipTrans.ScaleX = -1;
                a_sprawdzam = 1;
            }
            else
            {
                flipTrans.ScaleX = 1;
                a_sprawdzam = 0;
            }
            imycz.RenderTransform = flipTrans;
        }
        private void najnti_klik(object sender, RoutedEventArgs e)
        {
            b += 90;
            imycz.RenderTransformOrigin = new System.Windows.Point(0.5, 0.5);
            RotateTransform rotateTransform = new RotateTransform(b);
            imycz.RenderTransform = rotateTransform;
        }
        private void zielony_klik(object sender, RoutedEventArgs e)
        {

        }
        private void negatyw_klik(object sender, RoutedEventArgs e)
        {

        }
    }
}