using System;
using System.Collections.Generic;

namespace ProgrammingBasics
{    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("1) Napisati program koji prihvata unos dva broja I vraca njihov zbir. \n" +
                "2) Napisati program koji uzima broj kao argument I vraca true ako je broj jednak ili veci od nule. U suprotnom vraca false. \n" +
                "3) Napisati program koji proverava I vraca true ako je ceo broj deljiv sa 5.U suprotnom, vraca false. \n" +
                "4) Napisati program koji uzima kao argumente 2 stringa, ime i prezime, spaja ih(Concatenate) I vracanovi string u formatu “prezime, ime” \n" +
                "5) Napisati program uzima broj kao argument I vraca “paran” ili “neparan” u zavisnosti od tipa \n" +
                "6) Napisati program koji vraca poslednji element iz liste. \n" +
                "7) Napraviti konzolnu aplikaciju koja ucitava 2 stringa i proverava da li su stringovi jednaki. \n" +
                "8) Napisati program koji vraca OSTATAK deljenja dva uneta broja. \n" +
                "9) Napisati program koji format papira A4(210×297 mm) prikazuje u inčima(1 inč = 2.54 cm). \n" +
                "10) Napisati program koji Celzijusove stepene pretvara u Farenhajtove po formuli f = 9c / 5 + 32 \n" +
                "11) Napraviti kalkulator konzolnu aplikaciju koja treba da ucitava dva broja kao i operator (+, -, *, /).U rezultatu treba da bude ispisano rezultat matematicke operacije unetih brojeva. \n" +
                "12) Napraviti konzolnu aplikaciju koja za zadati broj n, ispisuje zvezdice u obliku trougla. \n" +
                "13) Napisati program koristeci FOR petlju koji uzima jednocifreni broj kao argument, ispisuje brojeve od nula to tog broja kao I sumu tih brojeva. \n" +
                "14) Napisati program koristeci FOR petlju koji zadati string ispisuje u obrnutom redosledu. \n" +
                "15) Napisati program koristeci WHILE petlju koji racuna I ispisuje zbir prvih 5 prirodnih brojeva. \n" +
                "16) Napisati program koristeci SWITCH petlju koja ispisuje unet prirodan broj od 0 - 9. \n" +
                "17) Napisati program koristeci if/else koji odredjuje zavrsnu ocenu studenta na osnovu 3 stavke: prvi kolokvijum, drugi kolokvijum i zavrsni ispit. Svaka od 3 provere znanja nosi od 0 - 100 poena.Izracunati prosecan broj poena I na osnovu toga dodeliti ocenu studentu.Ocena <= 50 nedovoljan, od 51 - 60 sestica, od 61 - 70 sedmica, od 71 - 80 osmica, od 81 - 90 devetka, 91 + desetka.Ispisati ocenu na ekranu. \n" +
                "18) Koristeci if/else, napisati program koji prima 3 broja kao argumente I ispisuje najveci broj. \n" +
                "19) Napisati metod koji sortira niz brojeva od manjeg ka vecem broju. (Ne korisititi genericku SORT medodu, implementirati svoje resenje) \n" +
                "20) Napisati program koji proverava koliko se puta broj 5 pojavljuje u sledecem nizu 1, 6, 2, 5, 8, 5, 20, 12, 90, 5.8. \n" +
                "21) Ako imamo dva broja broja, x = 5, y = 10, napisati program koji ce odaditi swap(broju x dodeliti vrednost broja y i obrnuto). \n" +
                "22) Napraviti program koji od postojeceg stringa 'Good morning! Today is Monday.' pravi novi string tako sto ce sve praznine(whitespaces) zameniti sa dodnjom crtom. \n" +
                "23) Napisati program koji ce od unetog stringa napraviti novi string, tako sto ce prvi i poslednji karakter zameniti mesta. \n");

            while (true)
            {
                Console.WriteLine("Please enter desired task number:");
                var task = Convert.ToInt32(Console.ReadLine());

                switch (task)
                {
                    case 1:
                        Console.WriteLine("Please enter two numbers:");
                        var a = Convert.ToInt32(Console.ReadLine());
                        var b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Sum is {0}", NumberOperations.Sum(a, b));
                        break;

                    case 2:
                        Console.WriteLine("Please enter one number to examine whether it is positive:");
                        var c = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(NumberOperations.PositiveOrNegative(c));
                        break;

                    case 3:
                        Console.WriteLine("Please enter one number to examine whether it can be divided with number 5 without remainder:");
                        var d = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(NumberOperations.DivisionWithFive(d));
                        break;

                    case 4:
                        Console.WriteLine("Please write your first name:");
                        var name = Console.ReadLine();
                        Console.WriteLine("And now your second name:");
                        var surname = Console.ReadLine();
                        Console.WriteLine("Your full name is {0}.", StringOperations.NameConcat(name, surname));
                        break;
                    case 5:
                        Console.WriteLine("Please enter one number to examine whether it is even or odd:");
                        var e = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Number is {0}.", NumberOperations.EvenOrOdd(e));
                        break;

                    case 6:
                        var elements = new List<int>() { 1, 23, 4, 56, 7, 89 };
                        Console.WriteLine("List of elements: {0}", ListOperations.ListToString(elements));
                        Console.WriteLine("Last element from this list is {0}.", ListOperations.LastElement(elements));
                        break;
                    case 7:
                        Console.WriteLine("Please enter any two words:");
                        var firstWord = Console.ReadLine();
                        var secondWord = Console.ReadLine();
                        StringOperations.StringComparison(firstWord, secondWord);
                        break;

                    case 8:
                        Console.WriteLine("Please enter two numbers:");
                        var f = Convert.ToInt32(Console.ReadLine());
                        var g = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("By dividing them, the obtained remainder is {0}", NumberOperations.DivisionWithRemainder(f, g));
                        break;

                    case 9:
                        NumberOperations.Paper paper = NumberOperations.A4PaperToInches();
                        paper.PrintDimensions();
                        break;

                    case 10:
                        Console.WriteLine("Please enter number of degrees Celsius:");
                        var h = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Entered number of degrees Celsius expressed in Fahrenheit is {0}", NumberOperations.CelsiusToFahrenheit(h));
                        break;

                    case 11:
                        Console.WriteLine("Please enter the first number: ");
                        var num1 = Convert.ToSingle(Console.ReadLine());
                        Console.WriteLine("Please enter the second number: ");
                        var num2 = Convert.ToSingle(Console.ReadLine());
                        Console.WriteLine("Please enter an operand (+, -, /, *): ");
                        var oper = Console.ReadLine();
                        Console.WriteLine("Desired result is {0}", Calculator.OperationsWithNumbers(num1, num2, oper));
                        break;

                    case 12:
                        Console.WriteLine("Please enter one number to make triangle of stars");
                        var stars = Convert.ToInt32(Console.ReadLine());
                        NumberOperations.StarTriangle(stars);
                        break;

                    case 13:
                        Console.WriteLine("Please enter one number to see all numbers before it and their sum");
                        var num = Convert.ToInt32(Console.ReadLine());
                        NumberOperations.AllLessThen(num);
                        break;

                    case 14:
                        Console.WriteLine("Please enter some word to see it in reverse order");
                        var randomWord = Console.ReadLine();
                        Console.WriteLine("In reversed order it looks like {0}", StringOperations.ReverseLetterOrder(randomWord));
                        break;

                    case 15:
                        Console.WriteLine("First 5 natural numbers and their sum is: ");
                        NumberOperations.AllLessThen();
                        break;

                    case 16:
                        Console.WriteLine("Please enter one number:");
                        var randomNum = Convert.ToInt32(Console.ReadLine());
                        NumberOperations.EnteredNumber(randomNum);
                        break;

                    case 17:
                        Console.WriteLine("Grade from the first colloquium:");
                        var firstCol = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Grade from the second colloquium:");
                        var secondCol = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Grade from the final exam:");
                        var finalExam = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Students final grade is {0}", GradeScale.AverageGrade(firstCol, secondCol, finalExam));
                        break;

                    case 18:
                        Console.WriteLine("Please enter 3 different numbers to find the greatest of them");
                        var x = Convert.ToInt32(Console.ReadLine());
                        var y = Convert.ToInt32(Console.ReadLine());
                        var z = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("The greatest number is {0}", NumberOperations.NumbersComparison(x, y, z));
                        break;

                    case 19:
                        int[] arr1 = new int[] { 6, 4, 1, 9, 7, 5, 8, 3, 2 };
                        Console.WriteLine("Array that's going to be used for ascending sorting: {0}", ArrayOperations.ArrayToString(arr1));
                        Console.WriteLine("Sorted array: {0}", ArrayOperations.ArrayToString(ArrayOperations.SortingFromSmallestToLargest(arr1)));
                        break;

                    case 20:
                        float[] arr2 = new float[] { 1, 6, 2, 5, 8, 5, 20, 12, 90, 5.8f };
                        Console.WriteLine("Program will tell how many times number 5 is showing in array: {0}", ArrayOperations.ArrayToString(arr2));
                        Console.WriteLine("Number 5 was shown {0} times in array", ArrayOperations.AppearanceOfElement(arr2));
                        break;

                    case 21:
                        Console.WriteLine("Please enter number for parameter A:");
                        var swap1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Please enter number for parameter B:");
                        var swap2 = Convert.ToInt32(Console.ReadLine());
                        NumberOperations.ValuesSwapping(ref swap1, ref swap2);
                        Console.WriteLine("Those values are swapped: A = {0} and B = {1}", swap1, swap2);
                        break;

                    case 22:
                        string sentence = "Good morning! Today is Monday.";
                        Console.WriteLine("Program is going to replace whitespaces in strings with bottom line");
                        Console.WriteLine("Sentence 'Good morning! Today is Monday.' now looks like '{0}'", StringOperations.ReplacingChar(sentence));
                        break;

                    case 23:
                        Console.WriteLine("Please enter any word:");
                        var randomString = Console.ReadLine();
                        Console.WriteLine("First and last character are swapped: {0}", StringOperations.SwappingFirstAndLastChar(randomString));
                        break;

                    default:
                        Console.WriteLine("That task doesn't exist.");
                        break;
                }

                Console.WriteLine("Do you want to try again? (y)");
                var response = Console.ReadLine();
                if (response != "y")
                    break;
            }
        }
    }
}
