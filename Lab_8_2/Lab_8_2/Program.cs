using System;

namespace Lab_8_2
{
    delegate int Number();
    delegate int MediumCalc(Number[] arrayX);

    class Program
    {


        static void Main(string[] args)
        {

            MediumCalc mediumCalc = (arrayX) =>
            {
                int sum = 0;
                foreach (var d in arrayX)
                    sum += d();
                return (int)sum / arrayX.Length;
            };


            Number[] arrayX = new Number[2];
            Random rand = new Random();
         

            for(int i = 0; i < arrayX.Length; i++)
            {
            


                arrayX[i] = rand.Next;
               
                
            }

         Console.Write(" " + arrayX[1].Invoke() + " " + arrayX[1].Invoke()); 



            Console.WriteLine(" = " + mediumCalc(arrayX));
            Console.ReadKey();


        }

     
        

            
    }
}
