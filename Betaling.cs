using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3
{
    public abstract class Betaling
    {
        protected abstract void Connect();

        protected abstract int BeginTransaction(float amount);

        protected abstract bool EndTransaction(int id);

        public void HandlePayment(float amount)
        {
            Connect();
            int id = BeginTransaction(amount);
            EndTransaction(id);
        }
    }
}
