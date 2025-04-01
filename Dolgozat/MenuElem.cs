using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozat
{
	internal class MenuElem
	{
			public string Nev { get; set; }
			public decimal Ar { get; set; }
			public string Kategoria { get; set; }

			public MenuElem(string nev, decimal ar, string kategoria)
			{
				Nev = nev;
				Ar = ar;
				Kategoria = kategoria;
			}
	}
}