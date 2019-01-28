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
    /// Logica di interazione per Switch.xaml
    /// </summary>
    public partial class Switch : UserControl
    {
        public bool Value = false;
        public delegate void SwitchEvent(Switch sender, bool value);

        public event SwitchEvent OnClick;
        public Switch()
        {
            InitializeComponent();

            OnClick += (Switch sender, bool value) => { };
        }

        private void Ellipse_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (!Value)
            {
                btn.Margin = new Thickness(0, 0, 3, 0);
                btn.HorizontalAlignment = HorizontalAlignment.Right;
                this.Value = true;
                btn.Fill = new SolidColorBrush(Color.FromRgb(16, 165, 232));
                brd.BorderBrush = new SolidColorBrush(Color.FromRgb(16, 165, 232));
            }
            else
            {
                btn.Margin = new Thickness(3, 0, 0, 0);
                btn.HorizontalAlignment = HorizontalAlignment.Left;
                this.Value = false;
                btn.Fill = new SolidColorBrush(Color.FromRgb(178, 194, 212));
                brd.BorderBrush = new SolidColorBrush(Color.FromRgb(178, 194, 212));
            }

            OnClick(this, Value);
        }
    }
}
