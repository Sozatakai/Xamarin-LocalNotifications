//using LocalNotifications.Plugin.Abstractions;
using Plugin.LocalNotification;
using Plugin.LocalNotifications;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TestNotifications
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

            var notification = new NotificationRequest
            {
                NotificationId = 100,
                Title = "Test",
                Description = "Test Description",
                ReturningData = "Dummy data", // Returning data when tapped on notification.
                Schedule =
                {
                    NotifyTime = DateTime.Now.AddSeconds(2) // Used for Scheduling local notification, if not specified notification will show immediately.
                }
            };

            LocalNotificationCenter.Current.Show(notification);

            #region Xam.Plugin.Notifier
            //También probar a configurar las notificaciones y a ver el tema de cancelarlas, ademas del servicio en segundo plano.

            // Depende de la api del dispositivo, en iOS configurar de una manera distinta en el App delegate y en Android, si supera la version
            // Api 31, instalar Xamarin.AndroidX.Work.Runtime o el KTP, por el momento con Apis 30 para a abajo va perfecto y en iOS 8 para abajo.
            // <<< Xam.Plugin.Notifier NuGet

            //CrossLocalNotifications.Current.Show("Test Notification", "Nuget Xam.Plugin.Notifier", 0, DateTime.Now.AddSeconds(5));
            #endregion

            #region Plugin.LocalNotification
            // Tambien depende de la api del dispositivo, revisar el tema de los dispositivos android API 31 O + y iOS 10 O +
            // <<< Plugin.LocalNotifications NuGet
            //var notif = new LocalNotification
            //{
            //    Text = "hello this is a test",
            //    Title = "Notification test",
            //    Id = 2,
            //    NotifyTime = DateTime.Now,
            //};

            //var notifier = LocalNotifications.Plugin.CrossLocalNotifications.CreateLocalNotifier();
            //notifier.Notify(notif);
            #endregion
        }
    }
}
