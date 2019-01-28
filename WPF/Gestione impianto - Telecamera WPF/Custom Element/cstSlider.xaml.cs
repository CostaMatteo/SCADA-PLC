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
    /// Logica di interazione per cstSlider.xaml
    /// </summary>
    public partial class cstSlider : UserControl
    {
        private int value = 0;
        public int Value
        {
            get
            {
                return value;
            }
            set
            {
                if (value <= MaxValue)
                    this.value = value;
                else if(value >= MinValue)
                    this.value = value;
            }
        }
        public int Steps = 1;
        public int MinValue = 0;
        public int MaxValue = 10;

        public cstSlider()
        {
            InitializeComponent();
        }

        public void Add(object num = null)
        {
            if (num == null)
                Value = Value + Steps;
            else
                Value = Value + (int) num;
        }
        public void Remove(object num = null)
        {
            if (num == null)
                Value = Value - Steps;
            else
                Value = Value - (int)num;
        }
    }
}
