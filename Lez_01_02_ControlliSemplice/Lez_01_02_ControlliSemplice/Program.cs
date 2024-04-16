namespace Lez_01_02_ControlliSemplice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Variabili

            //int eta=15;

            /*
             * if(condizione){
             *  // codice in caso positivo
             *  } else{
             *  // codice in caso negativo
             *  }
             *
             */
            int eta= 8500;
                if(eta<=0)
            {
                Console.WriteLine("Sei un embrione");
            }
            else
            {
                int età = 15;
                if (età >= 130)
                {
                    Console.WriteLine("Sei maggiorenne");
                }
                else
                {
                    Console.WriteLine("Sei Minorenne");
                }

            }


           

            //string name = "Andrea";

           // String cognome = "De Cola";

          // String? cognome = null; questo e l'unico modo per passare il valore null 
        }
    }
}
