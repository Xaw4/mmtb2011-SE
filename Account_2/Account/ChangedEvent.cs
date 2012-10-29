//Hubert Scharfetter
//Andreas Wallinger

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Account
{
    class ChangedEvent
    {
        public double Changage { get; set; }
        public double ActualValue { get; set; }

        public ChangedEvent()
        {

        }

        public ChangedEvent(double changage, double actualValue){
            Changage = changage;
            ActualValue = actualValue;
        }
    }
}
