using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozat
{
	internal class Vendeg
	{
		public string Nev { get; set; }
		public List<MenuElem> Rendelesek { get; set; }
		public Vendeg(string nev)
		{
			Nev = nev;
			Rendelesek = new List<MenuElem>();
		}
		public void Rendel(MenuElem elem)
		{
			Rendelesek.Add(elem);
		}
		public decimal Fizet()
		{
			decimal vegosszeg = 0;
			foreach (var rendeles in Rendelesek)
			{
				vegosszeg += rendeles.Ar;
			}
			Rendelesek.Clear();
			return vegosszeg; 
		}
	}
}
