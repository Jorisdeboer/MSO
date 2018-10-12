using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3
{
    class AdapterCoin : Betaling
    {
        private IKEAMyntAtare2000 coinMachine;

        public AdapterCoin()
        {
            coinMachine = new IKEAMyntAtare2000();
        }

	protected override void Connect()
        {
            coinMachine.starta();
        }

        protected override int BeginTransaction(float ammount)
        {
            coinMachine.betala(ammount);
            return 1;
        }

        protected override bool EndTransaction(int id)
        {
            coinMachine.stoppa();
            return true;
        }
    }
}
