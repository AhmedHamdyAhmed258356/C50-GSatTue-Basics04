using System.Runtime.InteropServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace C50_GSatTue_Basics04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //Create a one-dimensional array double[] prices with the values 25.5, 40.0, 33.75. Print
            //the second price(index 1).
            //double[]bookprice={25.5,40.0,33.75};
            //Console.WriteLine(bookprice[1]);
            #endregion
            #region Q2
            //Create a 2x2 multidimensional array int[,] shelfCopies where shelf 0 has 3, 5 copies and
            // shelf 1 has 1, 4 copies.Print the number of copies on shelf 1, slot 0.
            //int[,] shelfcopies = { { 3, 5 }, { 1, 4 } };
            //Console.WriteLine(shelfcopies[1, 0]);
            #endregion
            #region Q3
            //Write a method called PrintWelcomeMessage that takes no parameters and prints
            //Welcome to the Library!".Call it from Main.
            // printwelcomemessage();
            #endregion
            #region Q4
            //Write a method PrintBookTitle(string title) that prints "Book title: " + title. Call it with
            // "Clean Code"
            // PrintBookTitle("clean code");
            #endregion
            #region Q5
            //Write a method AddBonusPages(int pages) that adds 50 to pages. Call it with a variable
            //int pages = 400; and print pages afterward. What do you expect to see, and why?
            //int pages = 400;
            //AddBonusPages(pages);
            //Console.WriteLine(pages); //printed=400 : why??=  Because int is a value type passed by value
            //,AddBonusPages only modifies a copy of bages and leaving the original variable in main
            #endregion
            #region Q6
            //Write a method ApplyDiscount(double[] prices) that subtracts 5 from prices[0]. Call it
            //ith double[] prices = { 25.5, 40.0 }; and print prices[0] afterward.What do you expect to
            //see, and why?
            double[] prices = { 25.5, 40.0 };
            ApplyDiscount(prices);
            Console.WriteLine(prices[0]); //printed=20.5 why?? Because arrays are reference type
                             //,so modifiying index 0 inside the method updatesoriginal array in memory
            #endregion
        }

        #region functions
        #region Q3
        //static void printwelcomemessage()
        //    {
        //        Console.WriteLine("welcome to the library!");
        //    }
        #endregion
        #region Q4
        //static void PrintBookTitle(string BookTitle) {
        //    Console.WriteLine("Book title:"+BookTitle); 
        //}
        #endregion
        #region Q5
        //static void AddBonusPages(int pages)
        //{
        //    pages += 50;
        //    Console.WriteLine();
        //}
        #endregion
        #region Q6
        static void ApplyDiscount(double[] prices)
        {
            prices[0] -= 5;
        }
        #endregion
        #endregion
    }
}