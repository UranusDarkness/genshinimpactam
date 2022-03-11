using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace GenshinImpactAccountManager
{
    /// <summary>
    /// Logica di interazione per fourStars_weapons.xaml
    /// </summary>
    public partial class fourStars_weapons : Window
    {
        ICancelHandler cancelHandler;
        public fourStars_weapons()
        {
            InitializeComponent();
        }

        private void constLevel_preview(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-6]+").IsMatch(e.Text);
        }

        private void refinLevel_preview(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^1-5]+").IsMatch(e.Text);
        }

        private void Ok_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.cancelHandler.FourStarsCanceled();
            this.Hide();
        }

        public void setCancelHandler(ICancelHandler cancelHandler)
        {
            this.cancelHandler = cancelHandler;
        }

        private void Characters_Click(object sender, RoutedEventArgs e)
        {
            weaponsManager.WindowClosed();
        }

        IWeaponsManager weaponsManager;

        public void setWeaponsManager(IWeaponsManager weaponsManager)
        {
            this.weaponsManager = weaponsManager;
        }
    }
}
