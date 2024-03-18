using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CalculaSuperheroe.Pages
{
	public class IndexModel : PageModel
	{
		[BindProperty]

		public bool HasErrorN { get; set; }
		public bool HasErrorM { get; set; }
		public string nombre { get; set; }
		public string mes { get; set; }
		public string Superheroe { get; set; }


		public string GetSuperhero(string nombre, string mes)
		{
			char primeraLetra = nombre.ToUpper()[0];
			string Superheroe = "";

			switch (primeraLetra)
			{
				case 'A':
					Superheroe = "Captain";
					break;
				case 'B':
					Superheroe = "Wonder";
					break;
				case 'C':
					Superheroe = "Super";
					break;

				case 'D':
					Superheroe = "Phantom";
					break;

				case 'E':
					Superheroe = "Dark";
					break;

				case 'F':
					Superheroe = "Incredible";
					break;

				case 'G':
					Superheroe = "Professor";
					break;

				case 'H':
					Superheroe = "Iron";
					break;

				case 'I':
					Superheroe = "Hawk";
					break;

				case 'J':
					Superheroe = "Archer";
					break;

				case 'K':
					Superheroe = "Steel";
					break;

				case 'L':
					Superheroe = "Bolt";
					break;

				case 'M':
					Superheroe = "Atomic";
					break;

				case 'N':
					Superheroe = "Torch";
					break;

				case 'O':
					Superheroe = "Space";
					break;

				case 'P':
					Superheroe = "Mega";
					break;

				case 'Q':
					Superheroe = "Turbo";
					break;

				case 'R':
					Superheroe = "Fantastic";
					break;

				case 'S':
					Superheroe = "Invisible";
					break;

				case 'T':
					Superheroe = "Night";
					break;

				case 'U':
					Superheroe = "Silver";
					break;

				case 'V':
					Superheroe = "Aqua";
					break;

				case 'W':
					Superheroe = "Amazing";
					break;

				case 'X':
					Superheroe = "Giant";
					break;

				case 'Y':
					Superheroe = "Rock";
					break;

				case 'Z':
					Superheroe = "Power";
					break;

				default:
					Superheroe = "Desconocido";
					break;
			}

			switch (mes)
			{
				case "Enero":
					Superheroe += " Shield";
					break;

				case "Febrero":
					Superheroe += " Arrow";
					break;

				case "marzo":
					Superheroe += " Justice";
					break;

				case "abril":
					Superheroe += " Thunder";
					break;

				case "Mayo":
					Superheroe += " Rider";
					break;

				case "Junio":
					Superheroe += " Falcon";
					break;

				case "Julio":
					Superheroe += " Ninja";
					break;

				case "Agosto":
					Superheroe += " Spider";
					break;

				case "Septiembre":
					Superheroe += " Beast";
					break;

				case "Octubre":
					Superheroe += " Blade";
					break;

				case "Noviembre":
					Superheroe += " Hulk";
					break;

				case "Diciembre":
					Superheroe += " Doom";
					break;

				default:
					Superheroe = "Mes no válido";
					HasErrorM = true;
					break;
			}

			return Superheroe;

		}
		public void OnPost(string nombre, string mes)
		{
			if (string.IsNullOrWhiteSpace(mes))
			{
				HasErrorM = true;
			}
			else if (string.IsNullOrWhiteSpace(nombre))
			{
				HasErrorN = true;
			}
			else
			{
				Superheroe = GetSuperhero(nombre, mes);
			}

		}
		public void OnGet()
		{

		}
	}
}
