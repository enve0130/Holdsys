using System;
namespace Holdsystemet
{
	public class Studerende
	{
        private int id;
		public int ID
        {
            get => id;
            set
            {
                if (value > 0) id = value;
                else Console.WriteLine("Fejl: Sudie nummer må ikke være 0");
            }
        }

        private string navn;
        public string Navn
        {
            get => navn;
            set
            {
                if (value.Length >= 2) navn = value;
                else Console.WriteLine("Navn skal være mindst to bogstaver");
            }
        }
		public string Adresse { get; set; }

        private string cpr;
		public string CPR
        {
            get => cpr;
            set
            {
                if (value.Length != 11) Console.WriteLine("Cpr skal være med bindestreg og præcis 10 tal");
                else cpr = value;
            }
        }

		public Studerende(int id, string navn, string adresse, string cpr)
		{
			ID = id;
			Navn = navn;
			Adresse = adresse;
			CPR = cpr;
		}

        public override string ToString()
        {
            return $"Studienummer: {ID}, Navn: {Navn}, Adresse: {Adresse}, Cpr nummer: {CPR}"; 
        }
    }
}

