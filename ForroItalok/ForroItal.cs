using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForroItalok
{
	internal class ForroItal
	{
		string nev;
		int cukor;
		int mennyiseg;

		public ForroItal(string nev, int cukor, int mennyiseg)
		{
			this.nev = nev;
			this.cukor = cukor;
			this.mennyiseg = mennyiseg;
		}

		public override string ToString()
		{
			return $"{this.nev} {this.cukor} cukorral {this.mennyiseg} ml";
		}
	}
}
