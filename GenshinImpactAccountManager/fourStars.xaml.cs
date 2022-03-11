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
    /// Logica di interazione per fourStars.xaml
    /// </summary>
    public partial class fourStars : Window, IWeaponsManager
    {
        private fourStars_weapons wp;
        ICancelHandler cancelHandler;
        public fourStars()
        {
            wp = new fourStars_weapons();
            wp.setWeaponsManager(this);
            InitializeComponent();
        }

        private void constLevel_preview(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-6]+").IsMatch(e.Text);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.cancelHandler.FourStarsCanceled();
            this.Hide();
        }

        public void setCancelHandler(ICancelHandler cancelHandler)
        {
            this.cancelHandler = cancelHandler;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }

        private void WeaponsButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            wp.Show();        
        }

        public void WindowClosed()
        {
            wp.Hide();
            this.Show();
        }

        public fourStars_weapons Get4Weapons()
        {
            return this.wp;
        }

    }
}
