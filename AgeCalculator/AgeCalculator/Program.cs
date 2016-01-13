using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age
{
    class Program
    {
        static void Main(string[] args)
        {
            var running = true;
            while (running)
            {
                try
                {
                    Console.Write(" What is your birthday? Enter date in Format (MM/DD/YYYY)");



                    String BdayInput = Console.ReadLine();
                    DateTime Bday = DateTime.ParseExact(BdayInput, "MM/dd/yyyy", null);
                    TimeSpan Diff = DateTime.Now.Subtract(Bday);
                    float NumDays = Diff.Days;
                             float NumYears = NumDays / 365;

                          float NumWeeksRem = (NumDays % 365);
                float NumWeeks = NumWeeksRem / 7;

                     float NumDaysLeft= (NumWeeksRem % 7);

                    Console.WriteLine((int)NumYears + "years");

                    Console.WriteLine((int)NumWeeks + "weeks");
                    Console.WriteLine((int)NumDaysLeft + "days");

                         running = false;


                    Console.ReadLine();
                }
                catch (FormatException)
                {
                    Console.WriteLine("Wrong format entered. Please enter in format MM/DD/YY");
                }
            }
        }
    }
}





                   





                   


                    

                

        
        
    



          
            



       

     

       



