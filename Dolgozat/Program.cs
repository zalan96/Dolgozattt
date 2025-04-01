namespace Dolgozat
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Etterem etterem = new Etterem();
			etterem.Menu = FajlKezelo.BetoltMenu("menu.txt");

			Vendeg vendeg1 = new Vendeg("Kiss Péter");

			MenuElem burger = new MenuElem("Sajtburger", 1500, "Étel");
			MenuElem cola = new MenuElem("Kóla", 500, "Ital");

			etterem.HozzaadMenuElem(burger);
			etterem.HozzaadMenuElem(cola);

			vendeg1.Rendel(burger);
			vendeg1.Rendel(cola);

			Rendeles rendeles1 = new Rendeles(vendeg1.Nev, vendeg1.Rendelesek);
			etterem.HozzaadRendeles(rendeles1);

			FajlKezelo.MentesMenu(etterem.Menu, "menu.txt");
			FajlKezelo.MentesRendelesek(etterem.Rendelesek, "rendelesek.txt");
		}
	}
}