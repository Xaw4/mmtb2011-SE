//Hubert Scharfetter
//Andreas Wallinger

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Account
{
    class LogObserver : ChangeObserver
    {
        public void update(ChangedEvent e)
        {
            Console.WriteLine("Change: {0}, New Balance: {1}", 
                                e.Changage, e.ActualValue);
        }
    }
}
