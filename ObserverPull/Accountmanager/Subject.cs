//Hubert Scharfetter
//Andreas Wallinger

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


    interface Subject
    {
        void registerObserver(Observer o);

        bool removeObserver(Observer o); 

        void notifyObserver(); 
    }

