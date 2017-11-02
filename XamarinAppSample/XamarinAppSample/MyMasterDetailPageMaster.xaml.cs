using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinAppSample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyMasterDetailPageMaster : ContentPage
    {
        public ListView ListView;

        public MyMasterDetailPageMaster()
        {
            InitializeComponent();

            BindingContext = new MyMasterDetailPageMasterViewModel();
            ListView = MenuItemsListView;

            txtHeader.Text = "Welcome "+Application.Current.Properties["username"].ToString();
        }

        class MyMasterDetailPageMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MyMasterDetailPageMenuItem> MenuItems { get; set; }

            public MyMasterDetailPageMasterViewModel()
            {
                MenuItems = new ObservableCollection<MyMasterDetailPageMenuItem>(new[]
                {
                    new MyMasterDetailPageMenuItem { Id = 0, Title = "Main Page", TargetType=typeof(MainPage),Icon="icon.png" },
                    new MyMasterDetailPageMenuItem { Id = 1, Title = "Daftar Pegawai", TargetType=typeof(CustomListPage) },
                    new MyMasterDetailPageMenuItem { Id = 2, Title = "List Berita",TargetType=typeof(ListBerita) },
                    new MyMasterDetailPageMenuItem { Id = 3, Title = "Kirim Pesan", TargetType=typeof(KirimDataPage) },
                    new MyMasterDetailPageMenuItem { Id = 4, Title = "Sample Binding",TargetType=typeof(SampleDataBinding) },
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}