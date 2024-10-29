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
        private double answer;
        private double _num1;
        private double _num2;
        private char _operator = '@';
        public MainPage()
        {
            this.InitializeComponent();

        }
        

        

        private void oneBtn_Click_1(object sender, RoutedEventArgs e)
        {
            if(_operator =='@')
                firstNumTXT.Text += "1";
            else
                secNumTXT.Text += "1";
        }

        private void twoBtn_Click(object sender, RoutedEventArgs e)
        {
            if (_operator == '@')
                firstNumTXT.Text += "2";
            else
                secNumTXT.Text += "2";
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

        private void threeBtn_Click(object sender, RoutedEventArgs e)
        {
            if (_operator == '@')
                firstNumTXT.Text += "3";
            else
                secNumTXT.Text += "3";
        }

        private void clearBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void fourBtn_Click(object sender, RoutedEventArgs e)
        {
            if (_operator == '@')
                firstNumTXT.Text += "4";
            else
                secNumTXT.Text += "4";
        }

        private void fiveBtn_Click(object sender, RoutedEventArgs e)
        {
            if (_operator == '@')
                firstNumTXT.Text += "5";
            else
                secNumTXT.Text += "5";
        }

        private void sixBtn_Click(object sender, RoutedEventArgs e)
        {
            if (_operator == '@')
                firstNumTXT.Text += "6";
            else
                secNumTXT.Text += "6";
        }

        private void sevenBtn_Click(object sender, RoutedEventArgs e)
        {
            if (_operator == '@')
                firstNumTXT.Text += "7";
            else
                secNumTXT.Text += "7";
        }

        private void eightBtn_Click(object sender, RoutedEventArgs e)
        {
            if (_operator == '@')
                firstNumTXT.Text += "8";
            else
                secNumTXT.Text += "8";
        }

        private void nineBtn_Click(object sender, RoutedEventArgs e)
        {
            if (_operator == '@')
                firstNumTXT.Text += "9";
            else
                secNumTXT.Text += "9";
        }

        private void ansBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void zeroBtn_Click(object sender, RoutedEventArgs e)
        {
            if (_operator == '@')
                firstNumTXT.Text += "0";
            else
                secNumTXT.Text += "0";
        }

        private void queBtn_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            helpImg.Source = new BitmapImage(new Uri("ms-appx:///Assets/Digits/helpBtn1.png"));
        }

        private void divBtn_Click(object sender, RoutedEventArgs e)
        {
            _operator = '/';
        }

        private void mulBtn_Click(object sender, RoutedEventArgs e)
        {
            _operator = '*';
        }

        private void plusBtn_Click(object sender, RoutedEventArgs e)
        {
            _operator = '+';
        }

        private void minusBtn_Click(object sender, RoutedEventArgs e)
        {
            _operator = '-';
        }
    }
    


}
