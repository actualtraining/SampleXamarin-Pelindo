using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLite.Net;
using System.IO;

namespace XamarinAppSample.Droid
{
    public class SqliteService : ISQLIte
    {
        public SQLiteConnection GetConnection()
        {
            var sqlLiteFileName = "PegawaiDb.db3";
            string documentPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentPath, sqlLiteFileName);
            Console.WriteLine(path);
            if (!File.Exists(path))
                File.Create(path);

            var plat = new SQLite.Net.Platform.XamarinAndroid.SQLitePlatformAndroid();
            var conn = new SQLite.Net.SQLiteConnection(plat, path);
            return conn;
        }
    }
}