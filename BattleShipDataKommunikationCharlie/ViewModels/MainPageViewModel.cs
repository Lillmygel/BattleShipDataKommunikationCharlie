using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace BattleShipDataKommunikationCharlie.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        private SolidColorBrush[,] _MyPlayField;
        public SolidColorBrush[,] MyPlayField
        {
            get { return _MyPlayField; }
            set
            {
                if (_MyPlayField != value)
                {
                    _MyPlayField = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("MyPlayField"));
                    }
                }
            }
        }

        private SolidColorBrush[,] _OpponentsPlayField;
        public SolidColorBrush[,] OpponentsPlayField
        {
            get { return _OpponentsPlayField; }
            set
            {
                if (_OpponentsPlayField != value)
                {
                    _OpponentsPlayField = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("OpponentsPlayField"));
                    }
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
