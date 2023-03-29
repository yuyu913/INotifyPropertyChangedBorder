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
using BorderVisible.Controller;

namespace BorderVisible.myControl
{
    /// <summary>
    /// ucmyButton.xaml 的互動邏輯
    /// </summary>
    public partial class ucmyButton : UserControl
    {
        clsControl cls;
        public ucmyButton()
        {
            InitializeComponent();
            cls = MainWindow.cls;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var btnData = this.DataContext as clsControl.myButton;
            foreach (var lst in cls.btnList)
            {
                if(lst.ID==btnData.ID)
                {
                    lst.BorderBrushColor = "Red";
                }
                else
                {
                    lst.BorderBrushColor = "Transparent";
                }
            }

        }
    }
}
