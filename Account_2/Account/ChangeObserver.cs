using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Account
{
    interface ChangeObserver
    {
        void update(ChangedEvent e);
    }
}
