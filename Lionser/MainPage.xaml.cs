using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Chat;
using Windows.ApplicationModel.UserDataTasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Security.Cryptography.Certificates;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;



// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Lionser
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    ///  System.ComponentModel.Browsable(false)

    public sealed partial class MainPage : Page
    {

        public MainPage()
        {
            this.InitializeComponent();
            webBrowser1.Navigate(new Uri("http://google.com"));


        }

        public void OnNewWindowRequested(WebView sender, WebViewNewWindowRequestedEventArgs e)
        {
            // Block all requests to open a new window
            e.Handled = true;

        }
        public string Text { get; private set; }

        private void WebBrowser1_DocumentTitleChanged(object sender, EventArgs e)
        {

            this.Text = webBrowser1.DocumentTitle.ToString();

        }

        private void webBrowser1_LoadCompleted(object sender, NavigationEventArgs e)
        {

            txtBlock1.Text = webBrowser1.DocumentTitle;
            textBox1.Text = e.Uri.ToString();

        }



        private void textBox1_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            if (e.Key == Windows.System.VirtualKey.Enter)
            {
                webBrowser1.Navigate(new Uri("http://" + textBox1.Text));
            }
        }





        private void webBrowser1_NavigationStarting(WebView sender, WebViewNavigationStartingEventArgs args)
        {
            proBar1.IsIndeterminate = true;
            proBar1.IsEnabled = true;

        }

        private void webBrowser1_NavigationCompleted(WebView sender, WebViewNavigationCompletedEventArgs args)
        {
            proBar1.IsIndeterminate = false;
            proBar1.IsEnabled = false;
        }

        private void backBtn1_Click(object sender, RoutedEventArgs e)
        {
            if (this.webBrowser1.CanGoBack)
            {
                this.webBrowser1.GoBack();
            }
        }

        private void forwardBtn1_Click(object sender, RoutedEventArgs e)
        {
            if (this.webBrowser1.CanGoForward)
            {
                this.webBrowser1.GoForward();
            }
        }

        private void refreshBtn1_Click(object sender, RoutedEventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void Contactbtn1_Click(object sender, RoutedEventArgs e)
        {
            webBrowser1.Navigate(new Uri("https://onursercanyilmaz.tumblr.com/ask"));
        }

        private void Helpbtn1_Click(object sender, RoutedEventArgs e)
        {
            pvt.SelectedItem = pvthistory;
        }

        private void homeBtn1_Click(object sender, RoutedEventArgs e)
        {
            webBrowser1.Navigate(new Uri("http://google.com"));
        }
        //------------------------------------------2nd pivot--------------------------------------------
        private void backBtn2_Click(object sender, RoutedEventArgs e)
        {
            if (this.webBrowser2.CanGoBack)
            {
                this.webBrowser2.GoBack();
            }
        }

        private void homeBtn2_Click(object sender, RoutedEventArgs e)
        {
            webBrowser2.Navigate(new Uri("http://google.com"));
        }

        private void forwardBtn2_Click(object sender, RoutedEventArgs e)
        {
            if (this.webBrowser2.CanGoForward)
            {
                this.webBrowser2.GoForward();
            }
        }

        private void refreshBtn2_Click(object sender, RoutedEventArgs e)
        {
            webBrowser2.Refresh();
        }

        private void Contactbtn2_Click(object sender, RoutedEventArgs e)
        {
            webBrowser2.Navigate(new Uri("https://onursercanyilmaz.tumblr.com/ask"));
        }

        private void Helpbtn2_Click(object sender, RoutedEventArgs e)
        {
            pvt.SelectedItem = pvthistory;
        }



        private void WebBrowser2_DocumentTitleChanged(object sender, EventArgs e)
        {

            this.Text = webBrowser2.DocumentTitle.ToString();

        }

        private void webBrowser2_LoadCompleted(object sender, NavigationEventArgs e)
        {
            txtBlock2.Text = webBrowser2.DocumentTitle;
            textBox2.Text = e.Uri.ToString();

        }



        private void textBox2_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            if (e.Key == Windows.System.VirtualKey.Enter)
            {
                webBrowser2.Navigate(new Uri("http://" + textBox2.Text));
            }
        }





        private void webBrowser2_NavigationStarting(WebView sender, WebViewNavigationStartingEventArgs args)
        {
            proBar2.IsIndeterminate = true;
            proBar2.IsEnabled = true;
        }

        private void webBrowser2_NavigationCompleted(WebView sender, WebViewNavigationCompletedEventArgs args)
        {
            proBar2.IsIndeterminate = false;
            proBar2.IsEnabled = false;
        }
        //---------------------------------3rd pivot-------------------------------------------------
        private void backBtn3_Click(object sender, RoutedEventArgs e)
        {
            if (this.webBrowser3.CanGoBack)
            {
                this.webBrowser3.GoBack();
            }
        }

        private void homeBtn3_Click(object sender, RoutedEventArgs e)
        {
            webBrowser3.Navigate(new Uri("http://google.com"));
        }

        private void forwardBtn3_Click(object sender, RoutedEventArgs e)
        {
            if (this.webBrowser3.CanGoForward)
            {
                this.webBrowser3.GoForward();
            }
        }

        private void refreshBtn3_Click(object sender, RoutedEventArgs e)
        {
            webBrowser3.Refresh();
        }

        private void Contactbtn3_Click(object sender, RoutedEventArgs e)
        {
            webBrowser3.Navigate(new Uri("https://onursercanyilmaz.tumblr.com/ask"));
        }

        private void Helpbtn3_Click(object sender, RoutedEventArgs e)
        {
            pvt.SelectedItem = pvthistory;
        }



        private void WebBrowser3_DocumentTitleChanged(object sender, EventArgs e)
        {

            this.Text = webBrowser3.DocumentTitle.ToString();

        }

        private void webBrowser3_LoadCompleted(object sender, NavigationEventArgs e)
        {
            txtBlock3.Text = webBrowser3.DocumentTitle;
            textBox3.Text = e.Uri.ToString();

        }



        private void textBox3_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            if (e.Key == Windows.System.VirtualKey.Enter)
            {
                webBrowser3.Navigate(new Uri("http://" + textBox3.Text));
            }
        }





        private void webBrowser3_NavigationStarting(WebView sender, WebViewNavigationStartingEventArgs args)
        {
            proBar3.IsIndeterminate = true;
            proBar3.IsEnabled = true;
        }

        private void webBrowser3_NavigationCompleted(WebView sender, WebViewNavigationCompletedEventArgs args)
        {
            proBar3.IsIndeterminate = false;
            proBar3.IsEnabled = false;
        }
        //---------------------------4th-----------------------------------------

        private void backBtn4_Click(object sender, RoutedEventArgs e)
        {
            if (this.webBrowser4.CanGoBack)
            {
                this.webBrowser4.GoBack();
            }
        }

        private void homeBtn4_Click(object sender, RoutedEventArgs e)
        {
            webBrowser4.Navigate(new Uri("http://google.com"));
        }

        private void forwardBtn4_Click(object sender, RoutedEventArgs e)
        {
            if (this.webBrowser4.CanGoForward)
            {
                this.webBrowser4.GoForward();
            }
        }

        private void refreshBtn4_Click(object sender, RoutedEventArgs e)
        {
            webBrowser4.Refresh();
        }

        private void Contactbtn4_Click(object sender, RoutedEventArgs e)
        {
            webBrowser4.Navigate(new Uri("https://onursercanyilmaz.tumblr.com/ask"));
        }

        private void Helpbtn4_Click(object sender, RoutedEventArgs e)
        {
            pvt.SelectedItem = pvthistory;
        }



        private void WebBrowser4_DocumentTitleChanged(object sender, EventArgs e)
        {

            this.Text = webBrowser4.DocumentTitle.ToString();

        }

        private void webBrowser4_LoadCompleted(object sender, NavigationEventArgs e)
        {
            txtBlock4.Text = webBrowser4.DocumentTitle;
            textBox4.Text = e.Uri.ToString();

        }



        private void textBox4_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            if (e.Key == Windows.System.VirtualKey.Enter)
            {
                webBrowser4.Navigate(new Uri("http://" + textBox4.Text));
            }
        }





        private void webBrowser4_NavigationStarting(WebView sender, WebViewNavigationStartingEventArgs args)
        {
            proBar4.IsIndeterminate = true;
            proBar4.IsEnabled = true;
        }

        private void webBrowser4_NavigationCompleted(WebView sender, WebViewNavigationCompletedEventArgs args)
        {
            proBar4.IsIndeterminate = false;
            proBar4.IsEnabled = false;
        }
        //---------------------------------5th pivot-------------------------------------------------
        private void backBtn5_Click(object sender, RoutedEventArgs e)
        {
            if (this.webBrowser5.CanGoBack)
            {
                this.webBrowser5.GoBack();
            }
        }

        private void homeBtn5_Click(object sender, RoutedEventArgs e)
        {
            webBrowser5.Navigate(new Uri("http://google.com"));
        }

        private void forwardBtn5_Click(object sender, RoutedEventArgs e)
        {
            if (this.webBrowser5.CanGoForward)
            {
                this.webBrowser5.GoForward();
            }
        }

        private void refreshBtn5_Click(object sender, RoutedEventArgs e)
        {
            webBrowser5.Refresh();
        }

        private void Contactbtn5_Click(object sender, RoutedEventArgs e)
        {
            webBrowser5.Navigate(new Uri("https://onursercanyilmaz.tumblr.com/ask"));
        }

        private void Helpbtn5_Click(object sender, RoutedEventArgs e)
        {
            pvt.SelectedItem = pvthistory;
        }



        private void WebBrowser5_DocumentTitleChanged(object sender, EventArgs e)
        {

            this.Text = webBrowser5.DocumentTitle.ToString();

        }

        private void webBrowser5_LoadCompleted(object sender, NavigationEventArgs e)
        {
            txtBlock5.Text = webBrowser5.DocumentTitle;
            textBox5.Text = e.Uri.ToString();

        }



        private void textBox5_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            if (e.Key == Windows.System.VirtualKey.Enter)
            {
                webBrowser5.Navigate(new Uri("http://" + textBox5.Text));
            }
        }





        private void webBrowser5_NavigationStarting(WebView sender, WebViewNavigationStartingEventArgs args)
        {
            proBar5.IsIndeterminate = true;
            proBar5.IsEnabled = true;
        }

        private void webBrowser5_NavigationCompleted(WebView sender, WebViewNavigationCompletedEventArgs args)
        {
            proBar5.IsIndeterminate = false;
            proBar5.IsEnabled = false;
        }
        //---------------------------------6th pivot-------------------------------------------------
        private void backBtn6_Click(object sender, RoutedEventArgs e)
        {
            if (this.webBrowser6.CanGoBack)
            {
                this.webBrowser6.GoBack();
            }
        }

        private void homeBtn6_Click(object sender, RoutedEventArgs e)
        {
            webBrowser6.Navigate(new Uri("http://google.com"));
        }

        private void forwardBtn6_Click(object sender, RoutedEventArgs e)
        {
            if (this.webBrowser6.CanGoForward)
            {
                this.webBrowser6.GoForward();
            }
        }

        private void refreshBtn6_Click(object sender, RoutedEventArgs e)
        {
            webBrowser6.Refresh();
        }

        private void Contactbtn6_Click(object sender, RoutedEventArgs e)
        {
            webBrowser6.Navigate(new Uri("https://onursercanyilmaz.tumblr.com/ask"));
        }

        private void Helpbtn6_Click(object sender, RoutedEventArgs e)
        {
            pvt.SelectedItem = pvthistory;
        }



        private void WebBrowser6_DocumentTitleChanged(object sender, EventArgs e)
        {

            this.Text = webBrowser6.DocumentTitle.ToString();

        }

        private void webBrowser6_LoadCompleted(object sender, NavigationEventArgs e)
        {
            txtBlock6.Text = webBrowser6.DocumentTitle;
            textBox6.Text = e.Uri.ToString();

        }



        private void textBox6_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            if (e.Key == Windows.System.VirtualKey.Enter)
            {
                webBrowser6.Navigate(new Uri("http://" + textBox6.Text));
            }
        }





        private void webBrowser6_NavigationStarting(WebView sender, WebViewNavigationStartingEventArgs args)
        {
            proBar6.IsIndeterminate = true;
            proBar6.IsEnabled = true;
        }

        private void webBrowser6_NavigationCompleted(WebView sender, WebViewNavigationCompletedEventArgs args)
        {
            proBar6.IsIndeterminate = false;
            proBar6.IsEnabled = false;
        }
        //--------------------------------7th pivot-------------------------------------------------
        private void backBtn7_Click(object sender, RoutedEventArgs e)
        {
            if (this.webBrowser7.CanGoBack)
            {
                this.webBrowser7.GoBack();
            }
        }

        private void homeBtn7_Click(object sender, RoutedEventArgs e)
        {
            webBrowser7.Navigate(new Uri("http://google.com"));
        }

        private void forwardBtn7_Click(object sender, RoutedEventArgs e)
        {
            if (this.webBrowser7.CanGoForward)
            {
                this.webBrowser7.GoForward();
            }
        }

        private void refreshBtn7_Click(object sender, RoutedEventArgs e)
        {
            webBrowser7.Refresh();
        }

        private void Contactbtn7_Click(object sender, RoutedEventArgs e)
        {
            webBrowser7.Navigate(new Uri("https://onursercanyilmaz.tumblr.com/ask"));
        }

        private void Helpbtn7_Click(object sender, RoutedEventArgs e)
        {
            pvt.SelectedItem = pvthistory;
        }



        private void WebBrowser7_DocumentTitleChanged(object sender, EventArgs e)
        {

            this.Text = webBrowser7.DocumentTitle.ToString();

        }

        private void webBrowser7_LoadCompleted(object sender, NavigationEventArgs e)
        {
            txtBlock7.Text = webBrowser7.DocumentTitle;
            textBox7.Text = e.Uri.ToString();

        }



        private void textBox7_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            if (e.Key == Windows.System.VirtualKey.Enter)
            {
                webBrowser7.Navigate(new Uri("http://" + textBox7.Text));
            }
        }





        private void webBrowser7_NavigationStarting(WebView sender, WebViewNavigationStartingEventArgs args)
        {
            proBar7.IsIndeterminate = true;
            proBar7.IsEnabled = true;
        }

        private void webBrowser7_NavigationCompleted(WebView sender, WebViewNavigationCompletedEventArgs args)
        {
            proBar7.IsIndeterminate = false;
            proBar7.IsEnabled = false;
        }
        //---------------------------------8th pivot-------------------------------------------------
        private void backBtn8_Click(object sender, RoutedEventArgs e)
        {
            if (this.webBrowser8.CanGoBack)
            {
                this.webBrowser8.GoBack();
            }
        }

        private void homeBtn8_Click(object sender, RoutedEventArgs e)
        {
            webBrowser8.Navigate(new Uri("http://google.com"));
        }

        private void forwardBtn8_Click(object sender, RoutedEventArgs e)
        {
            if (this.webBrowser8.CanGoForward)
            {
                this.webBrowser8.GoForward();
            }
        }

        private void refreshBtn8_Click(object sender, RoutedEventArgs e)
        {
            webBrowser8.Refresh();
        }

        private void Contactbtn8_Click(object sender, RoutedEventArgs e)
        {
            webBrowser8.Navigate(new Uri("https://onursercanyilmaz.tumblr.com/ask"));
        }

        private void Helpbtn8_Click(object sender, RoutedEventArgs e)
        {
            pvt.SelectedItem = pvthistory;
        }



        private void WebBrowser8_DocumentTitleChanged(object sender, EventArgs e)
        {

            this.Text = webBrowser8.DocumentTitle.ToString();

        }

        private void webBrowser8_LoadCompleted(object sender, NavigationEventArgs e)
        {
            txtBlock8.Text = webBrowser8.DocumentTitle;
            textBox8.Text = e.Uri.ToString();

        }



        private void textBox8_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            if (e.Key == Windows.System.VirtualKey.Enter)
            {
                webBrowser8.Navigate(new Uri("http://" + textBox8.Text));
            }
        }





        private void webBrowser8_NavigationStarting(WebView sender, WebViewNavigationStartingEventArgs args)
        {
            proBar8.IsIndeterminate = true;
            proBar8.IsEnabled = true;
        }

        private void webBrowser8_NavigationCompleted(WebView sender, WebViewNavigationCompletedEventArgs args)
        {
            proBar8.IsIndeterminate = false;
            proBar8.IsEnabled = false;
        }
        //---------------------------------9th pivot-------------------------------------------------
        private void backBtn9_Click(object sender, RoutedEventArgs e)
        {
            if (this.webBrowser9.CanGoBack)
            {
                this.webBrowser9.GoBack();
            }
        }

        private void homeBtn9_Click(object sender, RoutedEventArgs e)
        {
            webBrowser9.Navigate(new Uri("http://google.com"));
        }

        private void forwardBtn9_Click(object sender, RoutedEventArgs e)
        {
            if (this.webBrowser9.CanGoForward)
            {
                this.webBrowser9.GoForward();
            }
        }

        private void refreshBtn9_Click(object sender, RoutedEventArgs e)
        {
            webBrowser9.Refresh();
        }

        private void Contactbtn9_Click(object sender, RoutedEventArgs e)
        {
            webBrowser9.Navigate(new Uri("https://onursercanyilmaz.tumblr.com/ask"));
        }

        private void Helpbtn9_Click(object sender, RoutedEventArgs e)
        {
            pvt.SelectedItem = pvthistory;
        }



        private void WebBrowser9_DocumentTitleChanged(object sender, EventArgs e)
        {

            this.Text = webBrowser9.DocumentTitle.ToString();

        }

        private void webBrowser9_LoadCompleted(object sender, NavigationEventArgs e)
        {
            txtBlock9.Text = webBrowser9.DocumentTitle;
            textBox9.Text = e.Uri.ToString();

        }



        private void textBox9_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            if (e.Key == Windows.System.VirtualKey.Enter)
            {
                webBrowser9.Navigate(new Uri("http://" + textBox9.Text));
            }
        }





        private void webBrowser9_NavigationStarting(WebView sender, WebViewNavigationStartingEventArgs args)
        {
            proBar9.IsIndeterminate = true;
            proBar9.IsEnabled = true;
        }

        private void webBrowser9_NavigationCompleted(WebView sender, WebViewNavigationCompletedEventArgs args)
        {
            proBar9.IsIndeterminate = false;
            proBar9.IsEnabled = false;
        }
        //---------------------------------10th pivot-------------------------------------------------
        private void backBtn10_Click(object sender, RoutedEventArgs e)
        {
            if (this.webBrowser10.CanGoBack)
            {
                this.webBrowser10.GoBack();
            }
        }

        private void homeBtn10_Click(object sender, RoutedEventArgs e)
        {
            webBrowser10.Navigate(new Uri("http://google.com"));
        }

        private void forwardBtn10_Click(object sender, RoutedEventArgs e)
        {
            if (this.webBrowser10.CanGoForward)
            {
                this.webBrowser10.GoForward();
            }
        }

        private void refreshBtn10_Click(object sender, RoutedEventArgs e)
        {
            webBrowser10.Refresh();
        }

        private void Contactbtn10_Click(object sender, RoutedEventArgs e)
        {
            webBrowser10.Navigate(new Uri("https://onursercanyilmaz.tumblr.com/ask"));
        }

        private void Helpbtn10_Click(object sender, RoutedEventArgs e)
        {
            pvt.SelectedItem = pvthistory;
        }



        private void WebBrowser10_DocumentTitleChanged(object sender, EventArgs e)
        {

            this.Text = webBrowser10.DocumentTitle.ToString();

        }

        private void webBrowser10_LoadCompleted(object sender, NavigationEventArgs e)
        {
            txtBlock10.Text = webBrowser10.DocumentTitle;
            textBox10.Text = e.Uri.ToString();

        }



        private void textBox10_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            if (e.Key == Windows.System.VirtualKey.Enter)
            {
                webBrowser10.Navigate(new Uri("http://" + textBox10.Text));
            }
        }





        private void webBrowser10_NavigationStarting(WebView sender, WebViewNavigationStartingEventArgs args)
        {
            proBar10.IsIndeterminate = true;
            proBar10.IsEnabled = true;
        }

        private void webBrowser10_NavigationCompleted(WebView sender, WebViewNavigationCompletedEventArgs args)
        {
            proBar10.IsIndeterminate = false;
            proBar10.IsEnabled = false;
        }
        //---------------------------------11th pivot-------------------------------------------------
        private void backBtn11_Click(object sender, RoutedEventArgs e)
        {
            if (this.webBrowser11.CanGoBack)
            {
                this.webBrowser11.GoBack();
            }
        }

        private void homeBtn11_Click(object sender, RoutedEventArgs e)
        {
            webBrowser11.Navigate(new Uri("http://google.com"));
        }

        private void forwardBtn11_Click(object sender, RoutedEventArgs e)
        {
            if (this.webBrowser11.CanGoForward)
            {
                this.webBrowser11.GoForward();
            }
        }

        private void refreshBtn11_Click(object sender, RoutedEventArgs e)
        {
            webBrowser11.Refresh();
        }

        private void Contactbtn11_Click(object sender, RoutedEventArgs e)
        {
            webBrowser11.Navigate(new Uri("https://onursercanyilmaz.tumblr.com/ask"));
        }

        private void Helpbtn11_Click(object sender, RoutedEventArgs e)
        {
            pvt.SelectedItem = pvthistory;
        }



        private void WebBrowser11_DocumentTitleChanged(object sender, EventArgs e)
        {

            this.Text = webBrowser11.DocumentTitle.ToString();

        }

        private void webBrowser11_LoadCompleted(object sender, NavigationEventArgs e)
        {
            txtBlock11.Text = webBrowser11.DocumentTitle;
            textBox11.Text = e.Uri.ToString();

        }



        private void textBox11_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            if (e.Key == Windows.System.VirtualKey.Enter)
            {
                webBrowser11.Navigate(new Uri("http://" + textBox11.Text));
            }
        }





        private void webBrowser11_NavigationStarting(WebView sender, WebViewNavigationStartingEventArgs args)
        {
            proBar11.IsIndeterminate = true;
            proBar11.IsEnabled = true;
        }

        private void webBrowser11_NavigationCompleted(WebView sender, WebViewNavigationCompletedEventArgs args)
        {
            proBar11.IsIndeterminate = false;
            proBar11.IsEnabled = false;
        }



        

        private void Helpbtn12_Click(object sender, RoutedEventArgs e)
        {
            listBox.Items.Clear();
        }

       

        
        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            listBox.Items.Add(textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, TextChangedEventArgs e)
        {

            listBox.Items.Add(textBox2.Text);
        }

        private void textBox3_TextChanged(object sender, TextChangedEventArgs e)
        {

            listBox.Items.Add(textBox3.Text);
        }

        private void textBox4_TextChanged(object sender, TextChangedEventArgs e)
        {

            listBox.Items.Add(textBox4.Text);
        }

        private void textBox5_TextChanged(object sender, TextChangedEventArgs e)
        {

            listBox.Items.Add(textBox5.Text);
        }

        private void textBox6_TextChanged(object sender, TextChangedEventArgs e)
        {

            listBox.Items.Add(textBox6.Text);
        }

        private void textBox7_TextChanged(object sender, TextChangedEventArgs e)
        {

            listBox.Items.Add(textBox7.Text);
        }

        private void textBox8_TextChanged(object sender, TextChangedEventArgs e)
        {

            listBox.Items.Add(textBox8.Text);
        }

        private void textBox9_TextChanged(object sender, TextChangedEventArgs e)
        {

            listBox.Items.Add(textBox9.Text);
        }

        private void textBox10_TextChanged(object sender, TextChangedEventArgs e)
        {

            listBox.Items.Add(textBox10.Text);
        }

        private void textBox11_TextChanged(object sender, TextChangedEventArgs e)
        {

            listBox.Items.Add(textBox11.Text);
        }
    }
}
