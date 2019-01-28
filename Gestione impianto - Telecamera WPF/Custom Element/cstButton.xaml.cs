using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace Gestione_impianto___Telecamera_WPF.Custom_Element
{
    /// <summary>
    /// Logica di interazione per cstButton.xaml
    /// </summary>
    public partial class cstButton : UserControl
    {
        public string text = "";



        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set
            {
                SetValue(TextProperty, value);
                //button.Content = value;
            }
        }

        public static readonly DependencyProperty TextProperty = DependencyProperty.Register("Text", typeof(string), typeof(cstButton));



        public delegate void customEvento(cstButton sender);

        public event customEvento onClick;
        public event customEvento onClickRight;
        public cstButton()
        {
            InitializeComponent();
            onClick += (cstButton sender) => { };
            onClickRight += (cstButton sender) => { };
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            onClick(this);
        }
    }
}
