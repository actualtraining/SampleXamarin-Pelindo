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

        private Command _editCommand;
        public Command EditCommand
        {
            get { return _editCommand; }
            set { _editCommand = value; OnPropertyChanged("EditCommand"); }
        }

        private Command _deleteCommand;
        public Command DeleteCommand
        {
            get { return _deleteCommand; }
            set { _deleteCommand = value; OnPropertyChanged("DeleteCommand"); }
        }

        public Pegawai()
        {
            EditCommand = new Command(EditRequested);
            DeleteCommand = new Command(DeleteRequested);
        }

        void DeleteRequested()
        {
            MessagingCenter.Send<Pegawai>(this, "DeleteRequested");
        }

        void EditRequested()
        {
            MessagingCenter.Send<Pegawai>(this, "EditRequested");
            
        }
    }
}
