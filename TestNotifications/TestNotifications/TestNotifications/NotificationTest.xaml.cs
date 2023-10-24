using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestNotifications
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NotificationTest : ContentPage
    {
        public NotificationTest()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //Plugin.LocalNotifications.CrossLocalNotifications.Current.Show("Test", "Notificación de testing, a ver si funciona", 0, DateTime.Now.AddSeconds(5));
        }
    }
}