using System;
using System.Windows.Forms;

namespace Lab3
{
	public class IKEAMyntAtare2000
	{
		public void starta()
		{
			MessageBox.Show ("Thanks for choosing the Cash option.");
		}

		public void stoppa()
		{
			MessageBox.Show ("Ending this transaction.");
		}

		public void betala(float pris)
		{
			MessageBox.Show ("Please pay: €" + pris + ",-");
		}
	}
}

