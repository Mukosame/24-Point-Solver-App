
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Graphics.Display;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.ApplicationModel.Email;
using Windows.Security.ExchangeActiveSyncProvisioning;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace _24Dian
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Info : Page
    {
        public Info()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }
        async void email(object sender, RoutedEventArgs e)
        {

            EasClientDeviceInformation CurrentDeviceInfor = new Windows.Security.ExchangeActiveSyncProvisioning.EasClientDeviceInformation();
            String OSVersion = CurrentDeviceInfor.OperatingSystem;
            String Manufacturer = CurrentDeviceInfor.SystemManufacturer;
            String FriendlyName = CurrentDeviceInfor.FriendlyName;

            Windows.ApplicationModel.Email.EmailMessage mail = new Windows.ApplicationModel.Email.EmailMessage();
            mail.Subject = "[WP8]速算24点用户反馈-" + Version.Text.ToString();
            mail.Body = "\n\n\n生产厂商：" + Manufacturer + "\n手机型号：" + FriendlyName + "\nOS版本：" + OSVersion;
            mail.To.Add(new Windows.ApplicationModel.Email.EmailRecipient("mukosame@gmail.com", "Mukosame"));
            await Windows.ApplicationModel.Email.EmailManager.ShowComposeNewEmailAsync(mail);

        }

        /*
        private async void searchStore_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            //登录商店搜索
            await Launcher.LaunchUriAsync(new System.Uri("zune:search?publisher=Lython"));
        }*/

        private async void otherapp(object sender, RoutedEventArgs e)
        {
            var uri = new Uri(string.Format(@"ms-windows-store:search?publisher=Mukosame"));
            await Windows.System.Launcher.LaunchUriAsync(uri);
        }

    }
}
