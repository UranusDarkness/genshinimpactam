using SQLite;
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
    /// Logica di interazione per AddAccount.xaml
    /// </summary>
    public partial class AddAccount : Window, ICancelHandler
    {
        private fiveStars cinquestelle = new fiveStars();
        private fourStars quattrostelle = new fourStars();
        private fiveStars_weapons cinquestelleweapons;
        private fourStars_weapons quattrostelleweapons;
        public AddAccount()
        {
            cinquestelleweapons = cinquestelle.Get5Weapons();
            quattrostelleweapons = quattrostelle.Get4Weapons();
            cinquestelleweapons.setCancelHandler(this);
            quattrostelleweapons.setCancelHandler(this);
            quattrostelle.setCancelHandler(this);
            cinquestelle.setCancelHandler(this);
            InitializeComponent();
        }

        private void acquaint_preview(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            cinquestelle.Owner = this;
            cinquestelle.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            quattrostelle.Owner = this;
            quattrostelle.ShowDialog();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (((TextBox)sender).Text.Length < 6)
            {

                MessageBox.Show("You need to write at least 6 characters", "Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void adventure_rank_preview(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
        }

        private void adventure_rank_check(object sender, RoutedEventArgs e)
        {
            int temp = -1;
            if (((TextBox)sender).Text.Length != 0)
            {
                temp = int.Parse(((TextBox)sender).Text);
            }

            if (temp == 0)
            {
                MessageBox.Show("Adventure Rank cannot be 0", "Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            else if (temp >= 61)
            {
                MessageBox.Show("Adventure Rank cannot be more than 60", "Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            bool checks = false;
            int tempar = int.Parse(ARTextbox.Text);
            if ((UserTextbox.Text.Length != 0) && (PassTextbox.Text.Length != 0) && (ARTextbox.Text.Length != 0) && (tempar <= 60) && (tempar > 0) && (AcquaTextbox.Text.Length != 0) && (InterTextbox.Text.Length != 0) && (PrimoTextbox.Text.Length != 0) && (GenesisTextbox.Text.Length != 0) && (((MaleRadio.IsChecked != false) || (FemaleRadio.IsChecked != false))))
                checks = true;
            else
                checks = false;

            if (checks == true)
            {

                Account Profile = new Account();
                Profile.Fourstars = "";
                Profile.Fivestars = "";
                Profile.Username = UserTextbox.Text;
                Profile.Password = PassTextbox.Text;
                Profile.Rank = int.Parse(ARTextbox.Text);
                Profile.AcquaintFate = long.Parse(AcquaTextbox.Text);
                Profile.IntertwinedFate = long.Parse(InterTextbox.Text);
                Profile.Primogems = long.Parse(PrimoTextbox.Text);
                Profile.GenesisCrystals = long.Parse(GenesisTextbox.Text);
                if (MaleRadio.IsChecked == true)
                    Profile.Gender = "Male";
                else if (FemaleRadio.IsChecked == true)
                    Profile.Gender = "Female";

                Profile.Server = ServerComboBox.Text;


                string[] Characters5Stars = { "Jean", "Diluc", "Venti", "Qiqi", "Keqing", "Mona", "Klee", "Tartaglia"};
                string[] Weapons5Stars = { "Amos' Bow", "Aquila Favonia", "Kunwu's Iris Rift", "Lost Prayer to the Sacred Winds", "Primordial Jade Winged-Spear", "Wolf's Gravestone", "Skyward Atlas", "Skyward Blade", "Skyward Harp", "Skyward Pride", "Skyward Spine", "Memory of Dust" };
                string[] Weapons4Stars = { "Alley Hunter", "Blackcliff Amulet", "Blackcliff Longsword", "Blackcliff Pole", "Blackcliff Slasher", "Blackcliff Warbow", "Compound Bow", "Crescent Pike", "Deathmatch", "Dragon's Bane", "Eye of Perception", "Favonius Codex", "Favonius Greatsword", "Favonius Lance", "Favonius Sword", "Favonius Warbow", "Iron Sting", "Lion's Roar", "Lithic Blade", "Lithic Spear", "Mappa Mare", "Prototype Aminus", "Prototype Crescent", "Prototype Grudge", "Prototype Malice", "Prototype Rancour", "Rainslasher", "Royal Bow", "Royal Greatsword", "Royal Grimoire", "Royal Longsword", "Rust", "Sacrificial Bow", "Sacrificial Fragments", "Sacrificial Greatsword", "Sacrificial Sword", "Serpent Spine", "Solar Pearl", "Sword of Descension", "The Alley Flash", "The Bell", "The Black Sword", "The Flute", "The Stringless", "The Viridescent Hunt", "The Widsith", "Whiteblind", "Wine and Song" };
                string[] Characters4Stars = { "Amber", "Barbara", "Beidou", "Bennett", "Chongyun", "Diona", "Fischl", "Kaeya", "Lisa", "Ningguang", "Noelle", "Razor", "Sucrose", "Xiangling", "Xingqiu"};

                //da aggiungere armi 4 stelle di pagina 2 e 3
                var iArray5StarsCheckbox = new[] { cinquestelle.JeanCheckbox, cinquestelle.DilucCheckbox, cinquestelle.VentiCheckbox, cinquestelle.QiqiCheckbox, cinquestelle.KeqingCheckbox, cinquestelle.MonaCheckbox, cinquestelle.KleeCheckbox, cinquestelle.TartagliaCheckbox };
                var iArray5StarsTextbox = new[] { cinquestelle.JeanTextbox, cinquestelle.DilucTextbox, cinquestelle.VentiTextbox, cinquestelle.QiqiTextbox, cinquestelle.KeqingTextbox, cinquestelle.MonaTextbox, cinquestelle.KleeTextbox, cinquestelle.TartagliaTextbox };

                var iArray5StarsWeaponsCheckbox = new[] { cinquestelleweapons.AmosCheckbox, cinquestelleweapons.AquFavoCheckbox, cinquestelleweapons.KunwuCheckbox, cinquestelleweapons.LostPrayerCheckbox, cinquestelleweapons.PrimordialCheckbox, cinquestelleweapons.GravestoneCheckbox, cinquestelleweapons.SkyAtlasCheckbox, cinquestelleweapons.SkyBladeCheckbox, cinquestelleweapons.SkyHarpCheckbox, cinquestelleweapons.SkyPrideCheckbox, cinquestelleweapons.SkySpineCheckbox, cinquestelleweapons.MemoryDustCheckbox };
                var iArray5StarsWeaponsTextbox = new[] { cinquestelleweapons.AmosTextbox, cinquestelleweapons.AquFavoTextbox, cinquestelleweapons.KunwuTextbox, cinquestelleweapons.LostPrayerTextbox, cinquestelleweapons.PrimordialTextbox, cinquestelleweapons.GravestoneTextbox, cinquestelleweapons.SkyAtlasTextbox, cinquestelleweapons.SkyBladeTextbox, cinquestelleweapons.SkyHarpTextbox, cinquestelleweapons.SkyPrideTextbox, cinquestelleweapons.SkySpineTextbox, cinquestelleweapons.MemoryDustTextbox };

                var iArray4StarsWeaponsCheckbox = new[] { quattrostelleweapons.AlleyCheckbox, quattrostelleweapons.BCliffAmuCheckbox, quattrostelleweapons.BCliffLongSwCheckbox, quattrostelleweapons.BCliffPoleCheckbox, quattrostelleweapons.BCliffSlasherCheckbox, quattrostelleweapons.BCliffWarbowCheckbox, quattrostelleweapons.CompBowCheckbox, quattrostelleweapons.CrescPikeCheckbox, quattrostelleweapons.DeathmatchCheckbox, quattrostelleweapons.DraBaneCheckbox, quattrostelleweapons.EyePercCheckbox, quattrostelleweapons.FavoCodexCheckbox, quattrostelleweapons.FavoGreatSwCheckbox, quattrostelleweapons.FavoLanceCheckbox, quattrostelleweapons.FavoSwordCheckbox, quattrostelleweapons.FavoWarbowCheckbox, quattrostelleweapons.IronStingCheckbox, quattrostelleweapons.LionRoarCheckbox, quattrostelleweapons.LithicBladeCheckbox, quattrostelleweapons.LithicSpearCheckbox, quattrostelleweapons.MappaMareCheckbox, quattrostelleweapons.ProtoAmiCheckbox, quattrostelleweapons.ProtoCrescCheckbox, quattrostelleweapons.ProtoGrudgeCheckbox, quattrostelleweapons.ProtoMaliceCheckbox, quattrostelleweapons.ProtoRancourCheckbox, quattrostelleweapons.RainslasherCheckbox, quattrostelleweapons.RoyalBowCheckbox, quattrostelleweapons.RoyalGreatSwCheckbox, quattrostelleweapons.RoyalGrimoCheckbox, quattrostelleweapons.RoyalLongSwCheckbox, quattrostelleweapons.RustCheckbox, quattrostelleweapons.SacriBowCheckbox, quattrostelleweapons.SacriFragCheckbox, quattrostelleweapons.SacriGreatSwCheckbox, quattrostelleweapons.SacriSwordCheckbox, quattrostelleweapons.SerpSpineCheckbox, quattrostelleweapons.SolarPearlCheckbox, quattrostelleweapons.SwordDescCheckbox, quattrostelleweapons.AlleyFlashCheckbox, quattrostelleweapons.TheBellCheckbox, quattrostelleweapons.BlackSwordCheckbox, quattrostelleweapons.TheFluteCheckbox, quattrostelleweapons.StringlessCheckbox, quattrostelleweapons.VirideHuntCheckbox, quattrostelleweapons.WidsithCheckbox, quattrostelleweapons.WhiteblindCheckbox, quattrostelleweapons.WineSongCheckbox };
                var iArray4StarsWeaponsTextbox = new[] { quattrostelleweapons.AlleyTextbox, quattrostelleweapons.BCliffAmuTextbox, quattrostelleweapons.BCliffLongSwTextbox, quattrostelleweapons.BCliffPoleTextbox, quattrostelleweapons.BCliffSlasherTextbox, quattrostelleweapons.BCliffWarbowTextbox, quattrostelleweapons.CompBowTextbox, quattrostelleweapons.CrescPikeTextbox, quattrostelleweapons.DeathmatchTextbox, quattrostelleweapons.DraBaneTextbox, quattrostelleweapons.EyePercTextbox, quattrostelleweapons.FavoCodexTextbox, quattrostelleweapons.FavoGreatSwTextbox, quattrostelleweapons.FavoLanceTextbox, quattrostelleweapons.FavoSwordTextbox, quattrostelleweapons.FavoWarbowTextbox, quattrostelleweapons.IronStingTextbox, quattrostelleweapons.LionRoarTextbox, quattrostelleweapons.LithicBladeTextbox, quattrostelleweapons.LithicSpearTextbox, quattrostelleweapons.MappaMareTextbox, quattrostelleweapons.ProtoAmiTextbox, quattrostelleweapons.ProtoCrescTextbox, quattrostelleweapons.ProtoGrudgeTextbox, quattrostelleweapons.ProtoMaliceTextbox, quattrostelleweapons.ProtoRancourTextbox, quattrostelleweapons.RainslasherTextbox, quattrostelleweapons.RoyalBowTextbox, quattrostelleweapons.RoyalGreatSwTextbox, quattrostelleweapons.RoyalGrimoTextbox, quattrostelleweapons.RoyalLongSwTextbox, quattrostelleweapons.RustTextbox, quattrostelleweapons.SacriBowTextbox, quattrostelleweapons.SacriFragTextbox, quattrostelleweapons.SacriGreatSwTextbox, quattrostelleweapons.SacriSwordTextbox, quattrostelleweapons.SerpSpineTextbox, quattrostelleweapons.SolarPearlTextbox, quattrostelleweapons.SwordDescTextbox, quattrostelleweapons.AlleyFlashTextbox, quattrostelleweapons.TheBellTextbox, quattrostelleweapons.BlackSwordTextbox, quattrostelleweapons.TheFluteTextbox, quattrostelleweapons.StringlessTextbox, quattrostelleweapons.VirideHuntTextbox, quattrostelleweapons.WidsithTextbox, quattrostelleweapons.WhiteblindTextbox, quattrostelleweapons.WineSongTextbox };
                
                var iArray4StarsCheckbox = new[] { quattrostelle.AmberCheckbox, quattrostelle.BarbaraCheckbox, quattrostelle.BeidouCheckbox, quattrostelle.BennettCheckbox, quattrostelle.ChongyunCheckbox, quattrostelle.DionaCheckbox, quattrostelle.FischlCheckbox, quattrostelle.KaeyaCheckbox, quattrostelle.LisaCheckbox, quattrostelle.NingguangCheckbox, quattrostelle.NoelleCheckbox, quattrostelle.RazorCheckbox, quattrostelle.SucroseCheckbox, quattrostelle.XianglingCheckbox, quattrostelle.XingqiuCheckbox };
                var iArray4StarsTextbox = new[] { quattrostelle.AmberTextbox, quattrostelle.BarbaraTextbox, quattrostelle.BeidouTextbox, quattrostelle.BennettTextbox, quattrostelle.ChongyunTextbox, quattrostelle.DionaTextbox, quattrostelle.FischlTextbox, quattrostelle.KaeyaTextbox, quattrostelle.LisaTextbox, quattrostelle.NingguangTextbox, quattrostelle.NoelleTextbox, quattrostelle.RazorTextbox, quattrostelle.SucroseTextbox, quattrostelle.XianglingTextbox, quattrostelle.XingqiuTextbox };

                //pg 5 stelle
                for (int i = 0; i < iArray5StarsCheckbox.Length; i++)
                {

                    CheckBox cb = iArray5StarsCheckbox[i];
                    TextBox tb = iArray5StarsTextbox[i];

                    if (cb.IsChecked == true)
                    {
                        string OneFiveStar = "";
                        if ((tb.Text.Length == 0) || (tb.Text == "0"))
                            OneFiveStar = Characters5Stars[i];
                        else
                        {
                            int temp = int.Parse(tb.Text);
                            OneFiveStar = Characters5Stars[i] + " (Const. Lv. " + Convert.ToString(temp) +")";
                        }
                        Profile.Fivestars = Profile.Fivestars + OneFiveStar + ", ";
                    }
                }

                //armi 5 stelle
                for (int i = 0; i < iArray5StarsWeaponsCheckbox.Length; i++)
                {

                    CheckBox cb = iArray5StarsWeaponsCheckbox[i];
                    TextBox tb = iArray5StarsWeaponsTextbox[i];

                    if (cb.IsChecked == true)
                    {
                        string OneFiveStar = "";
                        if ((tb.Text.Length == 0) || (tb.Text == "1"))
                            OneFiveStar = Weapons5Stars[i];
                        else
                        {
                            int temp = int.Parse(tb.Text);
                            OneFiveStar = Weapons5Stars[i] + " (Refin. Lv. " + Convert.ToString(temp) + ")";
                        }
                        Profile.Fivestars = Profile.Fivestars + OneFiveStar + ", ";
                    }
                }

                //pg 4 stelle
                for (int i = 0; i < iArray4StarsCheckbox.Length; i++)
                {
                    CheckBox cb = iArray4StarsCheckbox[i];
                    TextBox tb = iArray4StarsTextbox[i];

                    if (cb.IsChecked == true)
                    {
                        string OneFourStar = "";
                        if ((tb.Text.Length == 0) || (tb.Text == "0"))
                            OneFourStar = Characters4Stars[i];
                        else
                        {
                            int temp = int.Parse(tb.Text);
                            OneFourStar = Characters4Stars[i] + " (Const. Lv. " + Convert.ToString(temp) + ")";
                        }

                        Profile.Fourstars = Profile.Fourstars + OneFourStar + ", ";
                    }
                }

                //armi 4 stelle
                for (int i = 0; i < iArray4StarsWeaponsCheckbox.Length; i++)
                {

                    CheckBox cb = iArray4StarsWeaponsCheckbox[i];
                    TextBox tb = iArray4StarsWeaponsTextbox[i];

                    if (cb.IsChecked == true)
                    {
                        string OneFourStars = "";
                        if ((tb.Text.Length == 0) || (tb.Text == "1"))
                            OneFourStars = Weapons4Stars[i];
                        else
                        {
                            int temp = int.Parse(tb.Text);
                            OneFourStars = Weapons4Stars[i] + " (Refin. Lv. " + Convert.ToString(temp) + ")";
                        }
                        Profile.Fourstars = Profile.Fourstars + OneFourStars + ", ";
                    }
                }

                if (Profile.Fourstars.EndsWith(", "))
                {

                    Profile.Fourstars = Profile.Fourstars.Remove(Profile.Fourstars.Length - 2);
                }
                if (Profile.Fivestars.EndsWith(", "))
                {
                    Profile.Fivestars = Profile.Fivestars.Remove(Profile.Fivestars.Length - 2);
                }



                using (SQLiteConnection connection = new SQLiteConnection(App.DatabasePath))
                {
                    connection.CreateTable<Account>();
                    connection.Insert(Profile);
                    MessageBox.Show("Account added to the database!", "Add Account", MessageBoxButton.OK, MessageBoxImage.Information);
                }


                this.Close();

            }
            else
            {
                MessageBox.Show("Make sure to fill all the fields correctly", "Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }

        }

        public void FiveStarsCanceled()
        {
            //rimuovi armi 5 stelle
            foreach (var child in cinquestelleweapons.Weapons.Children)
            {
                if (child.GetType() == typeof(CheckBox))
                    ((CheckBox)child).IsChecked = false;
                else if (child.GetType() == typeof(TextBox))
                    ((TextBox)child).Text = String.Empty;
            }

            //rimuovi pg 5 stelle
            foreach (var child in cinquestelle.Characters.Children)
            {
                if (child.GetType() == typeof(CheckBox))
                    ((CheckBox)child).IsChecked = false;
                else if (child.GetType() == typeof(TextBox))
                    ((TextBox)child).Text = String.Empty;
            }         
        }

        public void FourStarsCanceled()
        {
            //rimuovi armi 4 stelle
            foreach (CheckBox check in MethodsHelper.GetChildrenByType<CheckBox>(quattrostelleweapons))
                check.IsChecked = false;

            foreach (TextBox text in MethodsHelper.GetChildrenByType<TextBox>(quattrostelleweapons))
                text.Text = String.Empty;

            //rimuovi pg 4 stelle
            foreach (var child in quattrostelle.Characters.Children)
            {
                if (child.GetType() == typeof(CheckBox))
                    ((CheckBox)child).IsChecked = false;
                else if (child.GetType() == typeof(TextBox))
                    ((TextBox)child).Text = String.Empty;
            }
        }
    }
}
