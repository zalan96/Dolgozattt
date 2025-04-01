using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozat
{
	internal class Rendeles
	{
		public string VendegNev { get; set; }
		public List<MenuElem> RendeltEtelek { get; set; }
		public Rendeles(string vendegNev, List<MenuElem> rendeltEtelek)
		{
			VendegNev = vendegNev;
			RendeltEtelek = rendeltEtelek;
		}
		public decimal Vegosszeg()
		{
			decimal osszeg = 0;
			foreach (var etel in RendeltEtelek)
			{
				osszeg += etel.Ar;
			}
			return osszeg; 
		}
	}
}
