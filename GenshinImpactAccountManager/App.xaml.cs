using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace GenshinImpactAccountManager
{
    /// <summary>
    /// Logica di interazione per App.xaml
    /// </summary>
    public partial class App : Application
    {
        static string DBName = "Database.db";
        static string Folderpath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        public static string DatabasePath = System.IO.Path.Combine(Folderpath, DBName);
    }
}
