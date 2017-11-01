using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinAppSample.Models
{
    public class Pegawai : BindableObject
    {
        private string _nip;
        public string Nip
        {
            get { return _nip; }
            set { _nip = value; OnPropertyChanged("Nip"); }
        }

        private string _nama;
        public string Nama
        {
            get { return _nama; }
            set { _nama = value; OnPropertyChanged("Nama"); }
        }

        private string _email;
        public string Email
        {
            get { return _email; }
            set { _email = value; OnPropertyChanged("Email"); }
        }

        private string _pic;
        public string Pic
        {
            get { return _pic; }
            set { _pic = value; OnPropertyChanged("Pic"); }
        }
    }
}
