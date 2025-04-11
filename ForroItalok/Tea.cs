using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForroItalok
{
	internal class Tea : ForroItal
	{
		bool citrommal;

		public Tea(string nev, int cukor, int mennyiseg, bool citrommal) : base(nev, cukor, mennyiseg)
		{
			this.citrommal = citrommal;
		}
		public bool Citrommal { get => citrommal; set => citrommal = value; }
		public override string ToString()
		{
			return base.ToString() + (this.citrommal ? " citrommal" : " citrom nélkül");
		}
	}
}
