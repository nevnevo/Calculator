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
        private double _answer=0;
        private double _num1=0;
        private double _num2=0;
        private double _RadDeg=Math.PI/180;
        private char _operator = '@';
        private bool isNeg = false;
        private bool _shift = false;
        
        
        public MainPage()
        {
            this.InitializeComponent();

        }
        
        private void ClearALl()
        {
            _num1 = 0;
            _num2 = 0;
            _operator = '@';
            firstNumTXT.Text = "";
            secNumTXT.Text = "";
        }
        private Windows.UI.Xaml.Controls.TextBlock Ctextbox()
        {
            if (_operator == '@')
                return firstNumTXT;
            return secNumTXT;
        }
        

        private void oneBtn_Click_1(object sender, RoutedEventArgs e)
        {
        
            Ctextbox().Text += "1";
        }

        private void twoBtn_Click(object sender, RoutedEventArgs e)
        {
            
            Ctextbox().Text += "2";
        }

        private void queBtn_Click(object sender, RoutedEventArgs e)
        {
            if(!(HelpGrid.Visibility == Visibility.Visible))
                HelpGrid.Visibility = Visibility.Visible;
            else
                HelpGrid.Visibility = Visibility.Collapsed;
        }

      

        private void queBtn_PointerEntered_1(object sender, PointerRoutedEventArgs e)
        {

            helpImg.Source = new BitmapImage(new Uri("ms-appx:///Assets/Digits/helpBtn2.png"));
        }

        private void threeBtn_Click(object sender, RoutedEventArgs e)
        {
            
             Ctextbox().Text += "3";
        }

        private void clearBtn_Click(object sender, RoutedEventArgs e)
        {
            ansBox.Text = "";
            _answer = 0;
            ClearALl();

            
        }

        private void fourBtn_Click(object sender, RoutedEventArgs e)
        {
            
            Ctextbox().Text += "4";
        }

        private void fiveBtn_Click(object sender, RoutedEventArgs e)
        {

            Ctextbox().Text += "5";
        }

        private void sixBtn_Click(object sender, RoutedEventArgs e)
        {

            Ctextbox().Text += "6";
        }

        private void sevenBtn_Click(object sender, RoutedEventArgs e)
        {
            
            Ctextbox().Text += "7";
        }

        private void eightBtn_Click(object sender, RoutedEventArgs e)
        {
            
            Ctextbox().Text += "8";
        }

        private void nineBtn_Click(object sender, RoutedEventArgs e)
        {

            Ctextbox().Text += "9";
        }

        private void ansBtn_Click(object sender, RoutedEventArgs e)
        {

            Ctextbox().Text += _answer;
        }

        private void zeroBtn_Click(object sender, RoutedEventArgs e)
        {
            
            Ctextbox().Text += "0";
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

        private void equBtn_Click(object sender, RoutedEventArgs e)
        {
            if (secNumTXT.Text != "")
            {
                if (firstNumTXT.Text == "")
                    _num1 = 0;
                else
                    _num1 = double.Parse(firstNumTXT.Text);
                
                _num2 = double.Parse(secNumTXT.Text);
            }
           
            switch(_operator)
            {
                case '+':
                    _answer = _num1 + _num2;
                    ansBox.Text = _answer.ToString();
                    ClearALl();
                    break;
                case '*':
                    _answer = _num1 * _num2;
                    ansBox.Text = _answer.ToString();
                    ClearALl();
                    break;
                case '-':
                    _answer = _num1 - _num2;
                    ansBox.Text = _answer.ToString();
                    ClearALl();
                    break;
                case '/':
                    if(_num2!=0) { 
                        _answer = _num1 + _num2;
                        
                        ansBox.Text = _answer.ToString();
                        ClearALl();

                    }
                    else
                    {
                        ansBox.Text = "You cant divide in 0!";
                    }
                    break;
                case 's':
                    if (!_shift) {
                        _answer = Math.Sin(_num2* _RadDeg);
                        ansBox.Text = _answer.ToString();
                        ClearALl();
                        
                    }
                    else
                    {
                        _answer = Math.Sinh(_num2 * _RadDeg);
                        ansBox.Text = _answer.ToString();
                        ClearALl();
                        
                    }
                    break;


                case 't':
                    if (!_shift)
                    {
                        _answer = Math.Tan(_num2 * _RadDeg);
                        ansBox.Text = _answer.ToString();
                        ClearALl();

                    }
                    else
                    {
                        _answer = Math.Atan(_num2 * _RadDeg);
                        ansBox.Text = _answer.ToString();
                        ClearALl();

                    }
                    break;
                case 'c':
                    if (!_shift)
                    {
                        _answer = Math.Cos(_num2 * _RadDeg);
                        ansBox.Text = _answer.ToString();
                        ClearALl();

                    }
                    else
                    {
                        _answer = Math.Acos(_num2 * _RadDeg);
                        ansBox.Text = _answer.ToString();
                        ClearALl();

                    }
                    break;
            }
        }

        

        private void backBtn_Click_1(object sender, RoutedEventArgs e)
        {
            Ctextbox().Text = Ctextbox().Text.ToString().Substring(0, Ctextbox().Text.ToString().Length - 1);
        }

        private void negBtn_Click(object sender, RoutedEventArgs e)
        {
            if (!isNeg) { 
                isNeg = true;
                Ctextbox().Text = '-'+Ctextbox().Text.ToString().Substring(0, Ctextbox().Text.ToString().Length);
            }
            else { 
                isNeg = false;
                Ctextbox().Text = Ctextbox().Text.ToString().Substring(1, Ctextbox().Text.ToString().Length-1);
            }
        }

        private void dotBtn_Click(object sender, RoutedEventArgs e)
        {
            if (!Ctextbox().Text.Contains('.'))
            {
                Ctextbox().Text += '.';
            }
            
        }

        private void sinBtn_Click(object sender, RoutedEventArgs e)
        {
            _operator = 's';
        }
        private void cosBtn_Click(object sender, RoutedEventArgs e)
        {
            _operator = 'c';
        }
        private void tanBtn_Click(object sender, RoutedEventArgs e)
        {
            _operator = 't';
        }

        private void Deg_Rad_Click(object sender, RoutedEventArgs e)
        {
            if (_RadDeg == Math.PI / 180)
            {
                _RadDeg = 1;
            }
            else
                _RadDeg = Math.PI / 180;

        }

        private void shift_Click(object sender, RoutedEventArgs e)
        {
            if (_shift)
            {
                _shift = false;
                shift.Background = clearBtn.Background;
            }
            else
            {
                _shift = true;
                shift.Background = new SolidColorBrush(Windows.UI.Color.FromArgb(255, 255, 0, 0));
            }
        }
    }
    


}
