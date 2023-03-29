using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace BorderVisible.Controller
{
    public class clsControl
    {
        public List<myButton> btnList { set; get; } = null;
        public List<myTextBox> tbList { set; get; } = null;
        public class myButton : INotifyPropertyChanged

        {
            public string ID { set; get; }
            public string Content { set; get; }
            public string BorderBrushColor
            {
                set
                {
                    _BorderBrushColor = value;
                    OnPropertyChanged("BorderBrushColor");
                }
                get { return _BorderBrushColor; }
            }
            string _BorderBrushColor;

            public myButton()
            {
                this.ID = Guid.NewGuid().ToString();
                this.Content = "按鈕";
                this.BorderBrushColor = " = Transparent";
            }


            #region Binding屬性變動事件
            public event PropertyChangedEventHandler PropertyChanged;
            private void OnPropertyChanged(string propertyName)
            {
                if (this.PropertyChanged != null)
                {
                    this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
                }
            }
            #endregion

        }
        public class myTextBox
        {
            public string ID { set; get; }
            public string Content { set; get; }
            public string BorderBrushColor { set; get; }
            public myTextBox()
            {
                this.ID = Guid.NewGuid().ToString();
                this.Content = "";
                this.BorderBrushColor = " = Transparent";
            }
        }

        public myTextBox AddTextBox()
        {
            myTextBox myTB = new myTextBox();

            return myTB;
        }
        public myButton AddButton()
        {
            myButton myBtn = new myButton();

            return myBtn;
        }



    }
}
