using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3
{
    public abstract class Betaling
    {
        public abstract void Connect();

        public abstract int BeginTransaction(float amount);

        public abstract bool EndTransaction(int id);
    }
}
