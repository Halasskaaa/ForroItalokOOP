using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForroItalok
{
	internal class Kave : ForroItal
	{
		string tej;
		// base: ősosztály konstruktorát hívjuk, és átadjuk az ősosztály konstruktoránaé az adatait
		public Kave(string nev, int cukor, int ar, string tej) : base(nev, cukor, ar)
		{
			this.tej = tej;
		}
		public string Tej { get => tej; set => tej = value; }
		public override void Aremeles()
		{
			this.ar += 100;
		}
		public override string ToString()
		{
			return base.ToString();
		}
	}
}
