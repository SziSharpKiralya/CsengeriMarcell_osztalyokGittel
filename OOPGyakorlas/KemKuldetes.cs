using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPGyakorlas
{
	internal class KemKuldetes
	{
		private string kodnev;
		private int orszag;
		private int veszelySzint;
		private int sikerEsely;

		public string Kodnev { get => kodnev; set => kodnev = value; }
		public int Orszag { get => orszag; set => orszag = value; }
		public int VeszelySzint { get => veszelySzint; set => veszelySzint = value; }
		public int SikerEsely { get => sikerEsely; set => sikerEsely = value; }

		public KemKuldetes(string kodnev, int orszag, int veszelySzint, int sikerEsely)
		{
			this.kodnev = kodnev;
			this.orszag = orszag;
			this.veszelySzint = veszelySzint;
			this.sikerEsely = sikerEsely;
		}

		public KemKuldetes(string kodnev, int orszag)
		{
			this.kodnev = kodnev;
			this.orszag = orszag;
			this.veszelySzint = 5;
			this.sikerEsely = 50;
		}

		public string KuldetesInditasa()
		{
			return $"{kodnev} küldetés elkezdődött";
		}

		public void VeszelySzintNovelese(int mennyiseg)
		{
			veszelySzint += mennyiseg;
		}

		public void SikerEselyNovelese(int szazalek)
		{
			sikerEsely = sikerEsely * ((szazalek / 100)+1);
		}

		public override string? ToString()
		{
			return $"{kodnev} {orszag} {veszelySzint} {sikerEsely}";
		}
	}
}
