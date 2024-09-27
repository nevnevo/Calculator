using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Calculator
{
    
    public sealed partial class MainPage : Page
    {
        private bool opPressed = false;
        private int fNum =0;
        private int sNum =0;
        private char oper;
        public MainPage()
        {
            this.InitializeComponent();

        }
        public void OpButtonClick(char op)
        {
            opPressed = true;
            oper = op;
        }

        public void DigButtonClick(int dig)
        {
            if (!opPressed)
            {
                fNum *= 10;
                fNum += dig;
                firstNumTXT.Text = fNum.ToString();
            }
            else if (opPressed)
            {
                sNum *= 10;
                sNum += dig;
                secNumTXT.Text = sNum.ToString();
            }

        }

        

        private void oneBtn_Click_1(object sender, RoutedEventArgs e)
        {
            DigButtonClick(1);
        }

        private void twoBtn_Click(object sender, RoutedEventArgs e)
        {
            DigButtonClick(2);
        }

        private void queBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void queBtn_PointerEntered(object sender, PointerRoutedEventArgs e)
        {

        }

        private void queBtn_PointerEntered_1(object sender, PointerRoutedEventArgs e)
        {

            helpImg.Source = new BitmapImage(new Uri("ms-appx:///Assets/Digits/helpBtn2.png"));
        }
    }
    


}
