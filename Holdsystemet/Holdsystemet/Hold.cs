using System;
namespace Holdsystemet
{
	public class Hold
	{
		public string Type { get; set; }
		public string Lokation { get; set; }
		public string Betegnelse { get; set; }
		public int OptagelsesAr { get; set; } = 2023;
		public bool VinterOptag { get; set; }
		public Dictionary<int, Studerende> Elever { get;set; }

		public Hold(string type, string lokation, string betegnelse, int optagelsesAr, bool vinteroptag)
		{
			Type = type;
			Lokation = lokation;
			Betegnelse = betegnelse;
			OptagelsesAr = optagelsesAr;
			Elever = new Dictionary<int, Studerende>();

		}

        public void Adderstuderende(Studerende studerende)
		{
			Elever.Add(studerende.ID, studerende);
		}

		public void SletStuderende(Studerende studerende)
		{
			Elever.Remove(studerende.ID);
		}

		public void PrintHoldetsElever()
		{
			foreach (var h in Elever.Values)
			{
				Console.WriteLine(h);
			}
		}

        public override string ToString()
        {
            return $"Uddannelse: {Type}, By: {Lokation},Retning: {Betegnelse}, År: {OptagelsesAr}, Optageget Studerende: {Elever}";
        }
    }
}

