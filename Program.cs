using System;

namespace Home_work_A__Variables__Methods__References_
{
    class Program
    {
        //Main Program
        static void Main(string[] args)
        {
            int magazine = 30;
            int reserve = 90;

            //int total = magazine + reserve;

            string player1 = ("Joseph");

            //there are two ways to use two methods together:

            //Placing a Method's value into an integer
            int aggregate = sum(magazine, reserve);

            print(player1, aggregate);

            //placing the method directly into another method.
            //print(player1, sum(magazine, reserve));

            Console.Read();
        }


        //References start here

        //Adding magazine and reserve ammo
        static int sum(int x, int y)
        {
            int sum = x + y;
            return sum;
        }

        //Method for printing
        static void print(string player, int ammo)
        {
            Console.WriteLine("Total ammo for player " + player + " is " + ammo + ".");
        }
    }
}
