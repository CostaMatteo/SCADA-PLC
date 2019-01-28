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
using System.Windows.Shapes;

using Gestione_impianto___Telecamera_WPF.Custom_Element;

namespace Gestione_impianto___Telecamera_WPF
{
    /// <summary>
    /// Logica di interazione per GestioneManuale.xaml
    /// </summary>
    public partial class GestioneManuale : Window
    {

        public GestioneManuale()
        {
            InitializeComponent();
            nstMain.OnClick += NstMain_OnClick;
            
            nstOne.OnClick += NstOne_OnClick;
            nstTwo.OnClick += NstTwo_OnClick;

            /*
            vntY.onClick += VntY_OnClickLeft;
            vntY.onClickRight += VntY_OnClickRight;
            */
            pstMain.OnClick += PstMain_OnClick;
            pstSecondario.OnClick += PstSecondario_OnClick;
        }

        private void PstSecondario_OnClick(Switch sender, bool value)
        {
            PLController.TabVar["pstSecondario"].Value = value;
        }

        private void PstMain_OnClick(Switch sender, bool value)
        {
            PLController.TabVar["pstPrincipale"].Value = value;
        }

        private void Ventosa_OnClick(Switch sender, bool value)
        {
            PLController.TabVar["ventosa"].Value = value;
        }
        
        private void VntY_OnClickRight(cstButton sender)
        {
           PLController.TabVar["ventosaYp"].Value = !(bool) PLController.TabVar["ventosaYp"].Value;
        }

        private void VntY_OnClickLeft(cstButton sender)
        {
            PLController.TabVar["ventosaYm"].Value = !(bool)PLController.TabVar["ventosaYm"].Value;
        }
        

        private void VntZ_OnClick(Switch sender, bool value)
        {
            PLController.TabVar["ventosaZ"].Value = value;
        }

        private void VntX_OnClick(Switch sender, bool value)
        {
            PLController.TabVar["ventosaX"].Value = value;
        }

        private void NstTwo_OnClick(Switch sender, bool value)
        {
            PLController.TabVar["nstTwo"].Value = value;
        }

        private void NstOne_OnClick(Switch sender, bool value)
        {
            PLController.TabVar["nstOne"].Value = value;
        }

        private void NstMain_OnClick(Switch sender, bool value)
        {
            PLController.TabVar["nstMain"].Value = value;
        }
    }
}
