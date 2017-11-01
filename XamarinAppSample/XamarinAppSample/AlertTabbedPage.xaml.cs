using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinAppSample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AlertTabbedPage : TabbedPage
    {
        public AlertTabbedPage ()
        {
            InitializeComponent();

            btnShowAction.Clicked += BtnShowAction_Clicked;
        }

        private async void BtnShowAction_Clicked(object sender, EventArgs e)
        {
            String strAction = await DisplayActionSheet("Pilihan", "Cancel", null, "C#", "Java", "PHP", "Phyton", "Swift");
            txtLanguage.Text = strAction;
        }
    }
}