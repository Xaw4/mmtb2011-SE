using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Account
{
    interface Changeable
    {
        void registerObserver(ChangeObserver observer);
        void removeObserver(ChangeObserver observer);

        void notifyObservers(ChangedEvent e);
    }
}
