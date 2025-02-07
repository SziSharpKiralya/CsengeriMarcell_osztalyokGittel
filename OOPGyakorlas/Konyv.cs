using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPGyakorlas
{
	internal class Konyv
	{
		private string cim;
		private string szerzo;
		private int kiadoEve;
		private int oldalSzam;
		private int ar;

		public string Cim { get => cim; set => cim = value; }
		public string Szerzo { get => szerzo; set => szerzo = value; }
		public int KiadoEve { get => kiadoEve; set => kiadoEve = value; }
		public int OldalSzam { get => oldalSzam; set => oldalSzam = value; }
		public int Ar { get => ar; set => ar = value; }

		public Konyv(string cim, string szerzo, int kiadoEve, int oldalSzam, int ar)
		{
			this.cim = cim;
			this.szerzo = szerzo;
			this.kiadoEve = kiadoEve;
			this.oldalSzam = oldalSzam;
			this.ar = ar;
		}

		public Konyv(string cim, string szerzo)
		{
			this.cim = cim;
			this.szerzo = szerzo;
			this.kiadoEve = DateTime.Now.Year;
			this.oldalSzam = 200;
			this.ar = 3000;
		}

		public void Arnoveles(int osszeg)
		{
			ar += osszeg;
		}

		public void Kedvezmeny(double szazalek)
		{
			int csokkentes = Convert.ToInt32(ar * (szazalek/100));
			ar -= csokkentes;
		}

		public int HanyOldalMaradt(int elolvasott)
		{
			return oldalSzam - elolvasott;
		}

		public override string? ToString()
		{
			return $"{cim} - {szerzo} / {oldalSzam} oldal / kiadva: {kiadoEve} / {ar}ft";
		}
	}
}
