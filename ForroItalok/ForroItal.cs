using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForroItalok
{
	internal class ForroItal
	{
		protected string nev;
		protected int cukor;
		protected int ar; // el tudjuk érni, privátban nem lehet
		public string Nev { get => nev; set => nev = value; }
		public int Cukor { get => cukor; set => cukor = value; }
		public int Ar { get => ar; set => ar = value; }

		public ForroItal(string nev, int cukor, int ar)
		{
			this.nev = nev;
			this.cukor = cukor;
			this.ar = ar;
		}
		public virtual void Aremeles() // virtual - overridera más osztályokban
		{
			this.ar += 50;
		}
		public override string ToString()
		{
			return $"{this.nev} {this.cukor} cukorral {this.ar} ft";
		}
	}
}
