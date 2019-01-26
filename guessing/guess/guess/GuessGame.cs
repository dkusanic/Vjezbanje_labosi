using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guess
{
    class GuessGame
    {
        public List<int> GeneriraniBrojevi { get; set; }
        public List<int> UneseniBrojevi { get; set; }
        public GuessGame()
        {
            GeneriraniBrojevi = new List<int>();
            UneseniBrojevi = new List<int>();
            GenerirajBrojeve();
        }

        private void GenerirajBrojeve()
        {
            for (int i=0; i<5; i++)
            {
                Random r = new Random();
                int randomNumber = r.Next(0, 20);
                if (!GeneriraniBrojevi.Contains(randomNumber))
                    GeneriraniBrojevi.Add(randomNumber);
            }
            
        }
        public bool ProvjeraIspravnosti()
        {
            return false;
        }
    }
}
