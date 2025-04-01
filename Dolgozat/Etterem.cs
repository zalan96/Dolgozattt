using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozat
{
	internal class Etterem
	{
		public List<MenuElem> Menu { get; set; }
		public List<Rendeles> Rendelesek { get; set; }

		public Etterem()
		{
			Menu = new List<MenuElem>();
			Rendelesek = new List<Rendeles>();
		}
		public void HozzaadMenuElem(MenuElem elem)
		{
			Menu.Add(elem);
		}
		public void HozzaadRendeles(Rendeles rendeles)
		{
			Rendelesek.Add(rendeles);
		}
	}
}