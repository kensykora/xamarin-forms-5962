using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace test
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            web.Navigated += Web_Navigated;

            web.Source = new UrlWebViewSource 
            {
                Url = "https://ionxskmskstglog.blob.core.windows.net/test/index.html",
            };
        }

        void Handle_Clicked(object sender, EventArgs e)
        {
            web.Reload();
        }

        void Web_Navigated(object sender, WebNavigatedEventArgs e)
        {
            status.Text = e.Result.ToString();
        }

    }
}
