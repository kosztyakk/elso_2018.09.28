using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BejegyzesProject
{

    public class Bejegyzes {

        public string szerzo;
        public string tartalom;
        public int likeok = 0;
        public DateTime letrejott = DateTime.Now;
        public DateTime szerkeztve = DateTime.Now;


        public Bejegyzes(string Szerzo, string Tartalom)
        {
            szerzo = Szerzo;
            tartalom = Tartalom;

        }
        public void Like()
        {
            likeok++;

        }
        public string Kiir()
        {

            string eredmény = szerzo + " " + Convert.ToString(likeok) + " " + Convert.ToString(letrejott)+"\nSzerkesztve:"+Convert.ToString(szerkeztve)+"\n"+Convert.ToString(tartalom);
            
            return eredmény;
        }



        public string Szerzo
        {
            get
            {
                return this.szerzo;
            }
        }
        public string Tartalom
        {
            get {

                return this.tartalom;

            }
        }
        public DateTime Letrejott
        {
            get
            {

                return this.letrejott;
            }



        }
        public DateTime Szerkeztve
        {
            get
            {

                return this.szerkeztve;

            }



        }
    }


    class Program
    {



        static void Main(string[] args)
        {
            Bejegyzes rnd = new Bejegyzes("Ady Endre", "Útra kelünk. Megyünk az Őszbe...");
            Console.WriteLine(rnd.Kiir());
            rnd.Like();
            Console.ReadKey();
        }
    }
}
