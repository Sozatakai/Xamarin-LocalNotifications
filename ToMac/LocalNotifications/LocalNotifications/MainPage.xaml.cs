using Plugin.LocalNotification.iOSOption;
using Plugin.LocalNotification;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LocalNotifications
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var notification = new NotificationRequest();

            if (Device.RuntimePlatform == Device.Android)
            {
                notification = new NotificationRequest
                {
                    NotificationId = 100,
                    Title = "Notificación en Android",
                    Description = "Notificación en Android Description",
                    ReturningData = "Dummy data",
                    Schedule =
                            {
                                NotifyTime = DateTime.Now.AddSeconds(2) 
                            }
                };
            }
            else if (Device.RuntimePlatform == Device.iOS)
            {
                var notificationEnabled = LocalNotificationCenter.Current.AreNotificationsEnabled().Result;
                if (notificationEnabled == false)
                {
                    LocalNotificationCenter.Current.RequestNotificationPermission();
                }

                notification = new NotificationRequest
                {
                    NotificationId = 100,
                    Title = "Notificación en iOS",
                    Description = "Notificación en iOS Description",
                    ReturningData = "Dummy data", 
                    Schedule =
                            {
                                NotifyTime = DateTime.Now.AddSeconds(2) 
                            }
                };
            }

            LocalNotificationCenter.Current.Show(notification);
        }
    }
}
