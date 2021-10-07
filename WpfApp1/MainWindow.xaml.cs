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

namespace WpfApp1
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.tbx_aura_res.TextChanged += tbx_aura_res_TextChanged;
            this.tbx_effic.TextChanged += tbx_aura_res_TextChanged;
        }

        private void tbx_aura_res_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                label.Content = this.CalcReservation();
            }
            catch (Exception ex)
            {

            }
        }

        private string CalcReservation()
        {
            try
            {
                return (Convert.ToDouble(tbx_aura_res.Text) * (1 / (1 + (Convert.ToDouble(tbx_effic.Text) / 100)))).ToString();
            }
            catch { return "0"; }
        }
    }
}
