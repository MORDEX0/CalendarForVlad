using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;


namespace Calendar6.View_Model
{
    internal class Dates : INotifyPropertyChanged
    {
        private DateTime _Date = DateTime.Now;
        public ButtonCommand RightClick { get; set; }
        public ButtonCommand LeftClick { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string prop = null)
        {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

        public String Date
        {
            get { return ($"{_Date.ToString("Y")}"); }
            set 
            {
                _Date = Convert.ToDateTime(value);
                OnPropertyChanged();

            }
        }

        public void Click_Right()
        {
            _Date.AddMonths(1);
            MessageBox.Show("Sosi");
            
        }
        public void Click_Left()
        {
            _Date.AddMonths(-1);
            MessageBox.Show("Sosi");
        }

        public Dates()
        {
            RightClick = new ButtonCommand(_ => Click_Right());
            LeftClick = new ButtonCommand(_ => Click_Left());
        }

    }
}