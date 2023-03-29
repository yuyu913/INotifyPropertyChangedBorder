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

namespace BorderVisible
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public static clsControl cls;
        public MainWindow()
        {
            InitializeComponent();
            cls = new clsControl();
            cls.tbList = new List<clsControl.myTextBox>();
            cls.btnList = new List<clsControl.myButton>();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            switch ((sender as Button).Content)
            {
                case "Add Button":
                    myControl.ucmyButton ucmybtn = new myControl.ucmyButton();
                    var btnNewData = cls.AddButton();
                    ucmybtn.DataContext = btnNewData;
                    wpInputControlArea.Children.Add(ucmybtn);
                    cls.btnList.Add(btnNewData);

                    break;
                case "Add TextBox":
                    myControl.ucmyTextBox ucmytb = new myControl.ucmyTextBox();
                    var tbNewData= cls.AddTextBox();
                    ucmytb.DataContext = tbNewData;
                    wpInputControlArea.Children.Add(ucmytb);
                    cls.tbList.Add(tbNewData);
                    break;
            }
        }
    }
}
