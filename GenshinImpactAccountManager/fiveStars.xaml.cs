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
    /// Logica di interazione per fiveStars.xaml
    /// </summary>
    public partial class fiveStars : Window, IWeaponsManager
    {
        private fiveStars_weapons wp;
        private ICancelHandler cancelHandler;
        public fiveStars()
        {
            wp = new fiveStars_weapons();
            wp.setWeaponsManager(this);
            InitializeComponent();
        }

        private void constLevel_preview(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-6]+").IsMatch(e.Text);
        }

        private void refinLevel_preview(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-5]+").IsMatch(e.Text);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            cancelHandler.FiveStarsCanceled();
            this.Hide();
        }

        public void setCancelHandler(ICancelHandler cancelHandler)
        {
            this.cancelHandler = cancelHandler;
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

        public fiveStars_weapons Get5Weapons()
        {
            return this.wp;
        }
    }
}
