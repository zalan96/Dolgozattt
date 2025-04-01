namespace Dolgozat
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Etterem etterem = new Etterem();
			etterem.Menu = FajlKezelo.MentesMenu();

			Vendeg vendeg1 = new Vendeg("Kiss Péter");

			MenuElem burger = new MenuElem("Sajtburger", 1500, "Étel");
			MenuElem cola = new MenuElem("Kóla", 500, "Ital");

			etterem.HozzaadMenuElem(burger);
			etterem.HozzaadMenuElem(cola);

			etterem.HozzaadRendeles();

			vendeg1.Rendel(burger);
			vendeg1.Rendel(cola);

			etterem.UjRendeles(vendeg1);

			FajlKezelo.MentesMenu(etterem.Menu);
			FajlKezelo.MentesRendelesek(etterem.Rendelesek);
		}
	}
}
