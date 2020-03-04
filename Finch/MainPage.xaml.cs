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
using Windows.UI.Xaml.Navigation;


// Boş Sayfa öğe şablonu https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x41f adresinde açıklanmaktadır

namespace Finch_Browser
{
    /// <summary>
    /// Kendi başına kullanılabilecek ya da bir Çerçeve içine taşınabilecek boş bir sayfa.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {

            this.InitializeComponent();
            webBrowser1.Navigate(new Uri("https://google.com"));

        }

        private void btn_back_Tapped(object sender, TappedRoutedEventArgs e)
        {

            if (this.webBrowser1.CanGoBack)
            {
                this.webBrowser1.GoBack();
            }

        }
       

        private void btn_forw_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (this.webBrowser1.CanGoForward)
            {
                this.webBrowser1.GoForward();
            }
        }
       
        private void btn_refresh_Tapped(object sender, TappedRoutedEventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void btn_home_Tapped(object sender, TappedRoutedEventArgs e)
        {
            webBrowser1.Navigate(new Uri("https://google.com"));
        }

        private void btn_go_Tapped(object sender, TappedRoutedEventArgs e)
        {
            webBrowser1.Navigate(new Uri("https://"+textBox1.Text));
        }

        
    }
}
