using System.Drawing;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Channels;

namespace assignment2_c_
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region question1:
            //q1 Declare string title = "clean code";. Call title.ToUpper() and store it in a new variable upperTitle. Print
            // both title and upperTitle to show that title did not change

            string title = "clean code";
            string title1 = title.ToUpper();
            Console.WriteLine(title);
            Console.WriteLine(title1);

            #endregion
            #region question2
            //q2 Declare two separate string variables, both set to the literal "Clean Code". Use ReferenceEquals()
            //to check if they point to the same object in memory.
            string str1 = "clean code";
            string str2 = "clean code";

            Console.WriteLine(object.ReferenceEquals(str1,str2));
            #endregion
            #region question3
            //Create a StringBuilder, Append() the text "Book List", then Append() " - Updated" onto the same
            //object.Print the final result.

            StringBuilder sb = new StringBuilder("Book List");
            sb = sb.Append("- Updated");
            Console.WriteLine( sb);


            #endregion


            #region question4
            //Using the StringBuilder from the question above, use Replace() to change "Book List" into "Library".
           // Print the result

                        
            sb = sb.Replace("Book List","library");
            Console.WriteLine(sb);


            #endregion

            #region question5
            //Given string title = "Clean Code"; and int pages = 464;, build the sentence "Book: Clean Code,
            //Pages: 464" using the + operator.

            string Title = "Clean Code";
            int pages = 464;
            Console.WriteLine("book: "+ Title + " pages: "+ pages);



            #endregion

            #region question6
            //Build the same sentence as above, but using string interpolation ($"...").

            
            Console.WriteLine($"book: { Title}  pages:{ pages}");



            #endregion


            #region question7
            //Build the same sentence again, but using string.Format().

            Console.WriteLine(string.Format("book:{0},pages:{1},",Title,pages));


            #endregion


            #region question8
            //Given int pages = 464;, write an if / else statement that prints  if pages is greater than
            //300, otherwise prints "Short Book"
            if (pages >= 300)
            {
                Console.WriteLine("long book");
            }
            else {
                Console.WriteLine( "shortbook");
            }


            #endregion




            #region question9
            //Given int pages = 464; and bool isAvailable = true;, print "You can borrow this book" only if pages is
            //greater than 300 and isAvailable is true.Use the && operator.
            bool isAvailable = true;
            if (pages >= 300&& isAvailable==true)
            {
                Console.WriteLine("You can borrow this book");
            }



            #endregion




            #region question10
            //Given string title = "Refactoring";, write a switch statement that prints "Great choice!" if the title is
            //"Clean Code", "Nice pick!" if it's "Refactoring", and "Never heard of it" for anything else.
            string title2= "Refactoring";
            switch (title2) {
                case "Clean Code":
                    Console.WriteLine("Great choice!");
                    break;
                case "Refactoring":
                    Console.WriteLine("Nice pick!");
                    break;

            }


            #endregion


            #region question11
            //Given int pages = 464;, use the ternary operator to store "Long Book" or "Short Book" into a
            // variable sizeLabel(same rule as question 8: long if pages > 300).

            string sizeLabel = pages > 300 ? "Long Book" : "Short Book";

            Console.WriteLine(sizeLabel);


            #endregion



            //#region question12
            //Given string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };, use a for loop
            //to print each book with its position number, like 1.Clean Code

            //string[] book = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

            //for (int i = 0; i < book.Length; i++) {
            //    Console.WriteLine(i+1 + book[i]);
            //}

            //#endregion


            //#region question13
            ////Using the same books array, use a while loop to print every book title.
            //string[] book = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            //int i = 0;

            //while( i < book.Length)
            //{
            //    Console.WriteLine(i + 1 + book[i]);
            //    i++;
            //}

            //#endregion


            //#region question14
            ////Write a do-while loop that prints "Checking book..." exactly 3 times
            //int i = 0;

            //do
            //{
            //    Console.WriteLine("Checking book...");
            //    i++;
            //}
            //while (i < 3);
            //#endregion

            //#region question 15
            ////Using the same books array, use a foreach loop to print every book title.
            //string[] book = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            //foreach (string book1 in book)
            //{
            //    Console.WriteLine(book1);
            //}
            //#endregion





            // #region question 16
            // //Using the same books array, loop through it and print each title, but stop completely (break) once
            //// you reach "Refactoring".

            // string[] book = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            // foreach (string book1 in book)
            // {
            //     Console.WriteLine(book1);

            //     if (book1 == "Refactoring")
            //     {
            //         break;
            //     }
            // }
            // #endregion









            //#region question 17
            ////Using the same books array, print every title except "The Pragmatic Programmer" (skip it with
            //// continue, don't stop the loop).
            //string[] book = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

            //foreach (string book1 in book)
            //{
            //    if (book1 == "The Pragmatic Programmer")
            //    {
            //        continue;
            //    }

            //    Console.WriteLine(book1);
            //}
            //#endregion


            #region question 18
            //Write a method PrintFirstBook() that prints the first book in the books array. If the array is empty,
            //use return to exit the method early instead of printing anything.

            string[] book = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };


            static void PrintFirstBook(string[] book)
            {
                Console.WriteLine(book[0]);
            }
        
            #endregion














        }
    }
    }