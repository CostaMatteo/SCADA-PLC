using Gestione_impianto___Telecamera_WPF.Custom_Element;
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

namespace Gestione_impianto___Telecamera_WPF
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //btnManuale.OnClick += ApriGestioneManuale;
            //swt_Connessione.OnClick += Swt_Connessione_OnClick;
            //btnManuale.onClick += ApriGestioneManuale;
        }

        private void Swt_Connessione_OnClick(Switch sender, bool value)
        {
            if (value)
            {
                PLController.Init(Environment.CurrentDirectory + @"\variabili.json");
                GestioneManuale frm = new GestioneManuale();

                MessageBox.Show(PLController.Write("Blocco_dati_1.nstMain", true).ToString());
                //frm.ShowDialog();
            }
            else
                PLController.Close();

        }

        private void ApriGestioneManuale(cstButton sender)
        {
            GestioneManuale frm = new GestioneManuale();

            frm.ShowDialog();
        }

        private void swt_Connessione_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
