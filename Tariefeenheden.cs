using System;

namespace Lab3
{
    public static class Tariefeenheden
    {
        public static int[,] Stations;

		public static String[] getStations()
		{
			return new String[] {
				"Utrecht Centraal",
				"Gouda",
				"Geldermalsen",
				"Hilversum",
				"Duivendrecht",
				"Weesp"
			};
        }

        public static void Tabel()
        {
            Stations = new int[getStations().Length, getStations().Length];
            
            for(int i = 0; i < getStations().Length; i++)
            {
                Stations[i, i] = 0;
            }

            //Utrecht Centraal
            Stations[0, 1] = 32; Stations[0, 2] = 26; Stations[0, 3] = 18; Stations[0, 4] = 31; Stations[0, 5] = 33;
            //Gouda
            Stations[1, 2] = 58; Stations[1, 3] = 50; Stations[1, 4] = 54; Stations[1, 5] = 57;
            //Geldermalsen
            Stations[2, 3] = 44; Stations[2, 4] = 57; Stations[2, 5] = 59;
            //Hilversum
            Stations[3, 4] = 18; Stations[3, 5] = 15;
            //Duivendrecht
            Stations[4, 5] = 3;
            //Weesp
            //Heeft nog niks.

            //voor het vullen van de andere helft van de tabel.
            for (int x = 0; x < getStations().Length; x++)
            {
                for (int y = 0; y < getStations().Length; y++)
                {
                    Stations[y, x] = Stations[x, y];
                }
            }
        }

		public static int getTariefeenheden(String from, String to) 
		{
            int beginstation = Array.IndexOf(getStations(), from);
            int eindstation = Array.IndexOf(getStations(), to);

            return Stations[eindstation, beginstation];
		}
	}
}

