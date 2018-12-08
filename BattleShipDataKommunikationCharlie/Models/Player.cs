using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShipDataKommunikationCharlie.Models
{
    public class Player : INotifyPropertyChanged
    {
        private string _Name;
        public string Name
        {
            get { return _Name; }
            set
            {
                if (_Name != value)
                {
                    _Name = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Name"));
                    }
                }
            }
        }

        private string _HostAddress;
        public string HostAddress
        {
            get { return _HostAddress; }
            set
            {
                if (_HostAddress != value)
                {
                    _HostAddress = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("HostAddress"));
                    }
                }
            }
        }

        private string _Port;
        public string Port
        {
            get { return _Port; }
            set
            {
                if (_Port != value)
                {
                    _Port = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Port"));
                    }
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
