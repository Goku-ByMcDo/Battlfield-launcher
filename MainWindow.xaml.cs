using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;

namespace Launcher
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void playbf5_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Vous devez copié l'éxécutable de bf3 et le collé dans le dossiée nommée 'game' ou  a même le dossié du launcher du  launcher ensuite allez dans 'MainWindow.xaml.cs' à la ligne 31 supprimé ce message et mettais 'bf5.exe' et relancer le launcher.");
        }

        private void playbf1_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("C:\Users\Megaport\Desktop\Launcher\bf1.exe");
        }

        private void playbf4_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("C:\Users\Megaport\Desktop\Launcher\bf4.exe");
        }

        private void playbf3_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Vous devez copié l'éxécutable de bf3 et le collé dans le dossiée nommée 'game' ou a même le dossier du launcher du  launcher ensuite allez dans 'MainWindow.xaml.cs' à la ligne 46 supprimé ce message et mettais 'bf3.exe' et relancer le launcher.");
        }

        private void github_Click(object sender, RoutedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://github.com/Goku-ByMcDo")
            {
                UseShellExecute = true
            });

        }
    }
}
