using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoseleyCWK4
{
    class Program
    {    
      
           
            static void Main(string[] args)
        {
            double accountBalance= 1000.50;

            Console.WriteLine("\tWelcome to your Banking Application\n");

            Console.Write("Would you like to make a (D)eposit, (W)ithdrawal, or (Q)uit?  ");
            string userInput=Console.ReadLine();
            int counter = 0;
                       
           while (userInput!="Q")
            {
                 if (userInput=="D")
                    { accountBalance=MakeDeposit(accountBalance);
                    counter = counter + 1;
                     }

                else if (userInput=="W")
                    {accountBalance= MakeWithdrawal(accountBalance);
                    counter = counter + 1;
                     }

                else
                    { Console.Write("Please enter D, W, or Q. \n ");
                    Console.WriteLine();//intentionally blank
                     }
             
                Console.Write("Would you like to make a (D)eposit, (W)ithdrawal, or (Q)uit?  ");
                userInput = Console.ReadLine();
            }

            if (userInput == "Q")
            {
                Console.WriteLine();//intentionally blank
                Console.WriteLine("You have completed {0} transactions.", counter);
                Console.WriteLine("Your final balance is {0:C}.", accountBalance);
            }

            Console.ReadKey();
        }//end of Main

        static double MakeDeposit(double accountBalance)
        {
            Console.Write("How much would you like to deposit? $");
            double temporary;
            if (double.TryParse(Console.ReadLine(), out temporary)==false)
                { Console.Write("Try again: "); }
            temporary= accountBalance + temporary;
            Console.WriteLine("Your account balance is {0:C}", temporary);
            Console.WriteLine();//intentionally blank
            return temporary;
        }

        static double MakeWithdrawal(double accountBalance)
        {
            Console.Write("How much would you like to withdraw? $");
            double temp;
            if(double.TryParse(Console.ReadLine(), out temp) == false)
            { Console.Write("Try again: ");

            }
            temp = accountBalance - temp;
            if (temp < 0)
            {
                Console.WriteLine("You have a negative balance.  A fee of $25 has been assessed.");
                temp=temp - 25;
              
            }
            Console.WriteLine("Your account balance is {0:C}", temp);

          
           Console.WriteLine();//intentionally blank
            return temp;
        }



    }//end of Program
}
