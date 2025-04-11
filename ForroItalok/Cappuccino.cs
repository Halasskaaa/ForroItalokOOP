using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForroItalok
{
	internal class Cappuccino : Kave
	{
		private bool tejszinhabbal;

		public Cappuccino(string nev, int cukor, int ar, string tej, bool tejszinhabbal) : base(nev, cukor, ar, tej)
		{
			this.tejszinhabbal = tejszinhabbal;
		}

	}
}
