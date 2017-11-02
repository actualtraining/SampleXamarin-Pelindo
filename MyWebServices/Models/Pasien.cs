using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyWebServices.Models
{
    public class Pasien
    {
        public int PasienID { get; set; }
        public string Nama { get; set; }
        public string Alamat { get; set; }
        public string Telpon { get; set; }
        public int Umur { get; set; }
    }
}