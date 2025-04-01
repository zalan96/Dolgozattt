using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozat
{
	internal class FajlKezelo
	{
		public static void MentesMenu(List<MenuElem> menu, string filePath)
		{
			using (StreamWriter writer = new StreamWriter(filePath))
			{
				foreach (var elem in menu)
				{
					writer.WriteLine($"{elem.Nev};{elem.Ar};{elem.Kategoria}");
				}
			}
		}

		public static List<MenuElem> BetoltMenu(string filePath)
		{
			List<MenuElem> menu = new List<MenuElem>();
			using (StreamReader reader = new StreamReader(filePath))
			{
				string line;
				while ((line = reader.ReadLine()) != null)
				{
					var parts = line.Split(';');
					var elem = new MenuElem(parts[0], decimal.Parse(parts[1]), parts[2]);
					menu.Add(elem);
				}
			}
			return menu;
		}

		public static void MentesRendelesek(List<Rendeles> rendelesek, string filePath)
		{
			using (StreamWriter writer = new StreamWriter(filePath))
			{
				foreach (var rendeles in rendelesek)
				{
					writer.WriteLine(rendeles.VendegNev);
					foreach (var elem in rendeles.RendeltEtelek)
					{
						writer.WriteLine($"{elem.Nev};{elem.Ar};{elem.Kategoria}");
					}
				}
			}
		}

		public static List<Rendeles> BetoltRendelesek(string filePath)
		{
			List<Rendeles> rendelesek = new List<Rendeles>();
			using (StreamReader reader = new StreamReader(filePath))
			{
				string line;
				while ((line = reader.ReadLine()) != null)
				{
					var vendegNev = line;
					List<MenuElem> rendeltEtelek = new List<MenuElem>();
					while ((line = reader.ReadLine()) != null && line != "")
					{
						var parts = line.Split(';');
						var elem = new MenuElem(parts[0], decimal.Parse(parts[1]), parts[2]);
						rendeltEtelek.Add(elem);
					}
					rendelesek.Add(new Rendeles(vendegNev, rendeltEtelek));
				}
			}
			return rendelesek;
		}
	}
}

