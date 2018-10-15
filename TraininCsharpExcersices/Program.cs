using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraininCsharpExcersices
{
    /// <summary>
    /// Write a program and ask the user to enter a number. The number should be between 1 to 10. If the user enters 
    /// a valid number, display "Valid" on the console. Otherwise, display "Invalid". (This logic is used a lot in 
    /// applications where values entered into input boxes need to be validated.)
    /// </summary>

    class excersice1
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number between 1 to 10");

            var input = Console.ReadLine();
            int number = Convert.ToInt32(input);

            if (number > 1 && number < 10)
            {
                Console.WriteLine("is Valid");


            }
            else
                Console.WriteLine("not Valid");

            Console.ReadLine();
        }

    }

    /// <summary>
    /// Write a program which takes two numbers from the console and displays the maximum of the two.
    /// </summary>
    class excersice2
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");

            var input1 = Console.ReadLine();
            int number1 = Convert.ToInt32(input1);

            Console.WriteLine("Enter second number");

            var input2 = Console.ReadLine();
            int number2 = Convert.ToInt32(input2);

            var max = (number2 > number1) ? number2 : number1;

            Console.WriteLine(max);
            Console.ReadLine();
        }
    }

    /// <summary>
    /// Write a program and ask the user to enter the width and height of an image. Then tell if the image 
    /// is landscape or portrait.
    /// </summary>
    class excersice3
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter width number");

            var input1 = Console.ReadLine();
            int width = Convert.ToInt32(input1);

            Console.WriteLine("Enter height number");

            var input2 = Console.ReadLine();
            int height = Convert.ToInt32(input2);

            var max = (width > height) ? Orientation.lanscape : Orientation.portrait;

            Console.WriteLine(max);
            Console.ReadLine();
        }

        public enum Orientation
        {
            lanscape,
            portrait
        }
    }

    /// <summary>
    /// Your job is to write a program for a speed camera. For simplicity, ignore the details such as camera, sensors, 
    /// etc and focus purely on the logic. Write a program that asks the user to enter the speed limit. Once set, 
    /// the program asks for the speed of a car. If the user enters a value less than the speed limit, program should 
    /// display Ok on the console. If the value is above the speed limit, the program should calculate the number of 
    /// demerit points. For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on 
    /// the console. If the number of demerit points is above 12, the program should display License Suspended.
    /// </summary>
    class excersice4
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter speed limit");

            var input1 = Console.ReadLine();
            int speedlimit = Convert.ToInt32(input1);

            Console.WriteLine("Enter car speed");

            var input2 = Console.ReadLine();
            int carspeed = Convert.ToInt32(input2);



            if (speedlimit > carspeed)
            {
                Console.WriteLine("ok");
            }
            else
            {
                var extra = carspeed - speedlimit;
                var demrits = (extra / 5);
                if (demrits > 12)
                {
                    Console.WriteLine("license suspended you demertic =" + demrits);
                }
                else
                {
                    Console.WriteLine("your demerits less than 12=" + demrits);
                }
            }

            Console.ReadLine();
        }


    }

    /// 49 excersice 1
    ///  <summary>
    /// Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. 
    /// Display the result on the console.
    /// </summary>
    class Excersice491
    {

        static void Main(string[] args)
        {

            var count = 0;
            for (var i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                    count++;
            }

            Console.WriteLine("There are {0} numbers divisible by 3 between 1 and 100.", count);

            Console.ReadLine();
        }

    }

    /// <summary>
    /// Write a program and continuously ask the user to enter a number. The loop terminates when the user 
    /// enters “ok". Calculate the sum of all the previously entered numbers and display it on the console.
    /// </summary>
    class Excersice492
    {

        static void Main(string[] args)
        {
            var sum = 0;
            while (true)
            {
                Console.WriteLine("Enter a number\n if you want to stop enter 'ok'");
                var input = Console.ReadLine();
                if (input.ToLower() == "ok")
                    break;
                sum += Convert.ToInt32(input);
            }

            Console.WriteLine("this is the total sum = {0}", sum);

            Console.ReadLine();
        }





    }

    /// <summary>
    /// Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number. 
    /// If the user guesses the number, display “You won". Otherwise, display “You lost".
    /// </summary>

    class Excersice493
    {

        static void Main(string[] args)
        {
            var input = Convert.ToInt32(Console.ReadLine());

            var fact = 1;

            for (int i = 1; i <= input; i++)
            {
                fact *= i;

            }

            Console.WriteLine("this is the total sum = {0}", fact);
            Console.ReadLine();
        }

    }

    /// <summary>
    /// Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number. 
    /// If the user guesses the number, display “You won". Otherwise, display “You lost".
    /// </summary>
    class Excersice494
    {

        static void Main(string[] args)
        {

            var random = new Random();
            var number = random.Next(1, 10);


            for (int i = 1; i <= 4; i++)
            {

                Console.WriteLine("Enter a number, you have 4 chances");
                Console.WriteLine("secret is " + number);
                var input = Convert.ToInt32(Console.ReadLine());

                if (input == number)
                {
                    Console.WriteLine("you won");
                    return;
                }

                Console.WriteLine("try again");
            }

            Console.WriteLine("lost");
            Console.ReadLine();
        }


    }

    /// <summary>
    /// Write a program and ask the user to enter a series of numbers separated by comma. Find the maximum of the 
    /// numbers and display it on the result. For example, if the user enters “5, 3, 8, 1, 4", the program should 
    /// display 8 on the console.
    /// </summary>


    class Excersice495
    {

        static void Main(string[] args)
        {
            Console.WriteLine("enter numbers seperate by ,");
            var input = Console.ReadLine();
            var numbers = input.Split(',');

            //lets assume first number is a max

            var max = Convert.ToInt32(numbers[0]);

            foreach (var ste in numbers)
            {
                var number = Convert.ToInt32(ste);
                if (number > max)
                {
                    max = number;
                }


            }


            Console.WriteLine("max number is " + max);
            Console.ReadLine();
        }


    }
//    1- When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.

//If no one likes your post, it doesn't display anything.
//If only one person likes your post, it displays: [Friend's Name] likes your post.
//If two people like your post, it displays: [Friend 1] and[Friend 2] like your post.
//If more than two people like your post, it displays: [Friend 1], [Friend 2] and[Number of Other People] others like your post.

    class Exercises551
    {

        static void Main(string[] args)
        {
            var names = new List<String>();

            while (true)
            {
                Console.WriteLine("enter Name or hit Enter to quit");

                var input = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(input))
                    break;


                names.Add(input);



            }

            if (names.Count == 1)
                Console.WriteLine("{0} liked your post ", names[0]);

            else if (names.Count == 2)
                Console.WriteLine("{0},{1} liked your post", names[0], names[1]);

            else if (names.Count > 2)
                Console.WriteLine("{0},{1}, liked your post and number {2} others liked your post", names[0], names[1],
                    names.Count - 2);
            else
            {
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }

    /// Ask the user to enter their name. Use an array to reverse the name and then store the result in a new string. 
    /// Display the reversed name on the console.
    /// </summary>
    class Exercises552
    {

        static void Main(string[] args)
        {

            Console.Write("What's your name? ");
            var name = Console.ReadLine();
            //he will keep shifting the character pleces -1 until loop is done
            var array = new char[name.Length];
            for (var i = name.Length; i > 0; i--)
                array[name.Length - i] = name[i - 1];

            var reversed = new string(array);
            Console.WriteLine("Reversed name: " + reversed);





            Console.ReadLine();
        }





    }

    /// <summary>
    /// Write a program and ask the user to enter 5 numbers. If a number has been previously entered, display 
    /// an error message and ask the user to re-try. Once the user successfully enters 5 unique numbers, sort them 
    /// and display the result on the console.
    /// </summary>


    class Exercises553
    {

        static void Main(string[] args)
        {

            Console.Write("Please Enter 5 Numbers ");

            var numbers = new List<int>();

            while (numbers.Count < 5)
            {


                var input = Convert.ToInt32(Console.ReadLine());
                if (numbers.Contains(input))
                {
                    Console.WriteLine("Number {0} exists please enter new Number", input);
                    continue;

                    //continue forloop will keep going until pass the value condtion
                }

                numbers.Add(input);
            }


            numbers.Sort();
            Console.WriteLine("sorting numbers");
            foreach (var number in numbers)
            {

                Console.WriteLine(number);
            }

            Console.ReadLine();

        }


    }





    /// <summary>
    /// Write a program and ask the user to continuously enter a number or type "Quit" to exit. The list of numbers may 
    /// include duplicates. Display the unique numbers that the user has entered.
    /// </summary>

    class Exercises554
    {

        static void Main(string[] args)
        {

            Console.Write("Please Enter numbers or Quit to exit");

            var numbers = new List<int>();

            while (true)
            {


                var input = Console.ReadLine();
                if (input.ToLower() == "quit")
                {
                    break;

                    //continue forloop will keep going until pass the value condtion
                }

                numbers.Add(Convert.ToInt32(Console.ReadLine()));
            }



            var uniq = new List<int>();

            foreach (var number in numbers)
            {
                if (!uniq.Contains(number))
                    uniq.Add(number);
            }

            Console.WriteLine("sorted one");

            foreach (var numberq in uniq)
            {
                Console.WriteLine(numberq);
            }
            Console.ReadLine();


        }

    }


    /// <summary>
    /// Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10). If the list is 
    /// empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; otherwise, display 
    /// the 3 smallest numbers in the list.
    /// 
    /// </summary>

    class Exercises555
    {

        static void Main(string[] args)
        {

            Console.Write("Please Enter 5 numbers seprated by Coma");

            string[] elements;

            var input = Console.ReadLine();
            while (true)
            {


                if (!String.IsNullOrWhiteSpace(input))
                {
                    elements = input.Split(',');
                    if (elements.Length >= 5)
                        break;




                    Console.WriteLine("invalid list");
                }
            }

            var numbers = new List<int>();

            foreach (var elem in elements)
            {
                numbers.Add(Convert.ToInt32(elem));
            }

            var smallest = new List<int>();


            while (smallest.Count < 3)
            {
                //assume the smallest is first one

                var min = numbers[0];

                foreach (var number in numbers)
                {
                    if (number < min)
                        min = number;

                }
                smallest.Add(min);
                numbers.Remove(min);

            }

            Console.WriteLine("The 3 smallest numbers are: ");
            foreach (var number in smallest)
                Console.WriteLine(number);
            Console.ReadLine();
        }

    }


}




