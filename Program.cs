using System;
using System.Collections.Generic;
using System.Linq;
namespace functionmethod
{
    class Program
    {
        static void Main(string[] args)
        {   Console.WriteLine("What Question Do you need to check? ");
            int part = int.Parse(Console.ReadLine());

            if((part==1)||(part==2)) {
            Console.Write("Enter Name!:");
            string name = Console.ReadLine();
            var tuple = greeting(name);
            Console.WriteLine(tuple.Item1);
            Console.WriteLine(tuple.Item2);}

            else if(part==3){Console.Write("Now, enter a number: ");
            int no1 = int.Parse(Console.ReadLine());
            Console.Write("And another number: ");
            int no2 = int.Parse(Console.ReadLine());
            int addition = basicadd(no1, no2);
            Console.WriteLine("The two numbers combined is " + addition);
            }

            else if(part==4){Console.WriteLine("Please Input a String: ");
            string userinput= Console.ReadLine();
            int answer = spacecount(userinput);
            Console.WriteLine("This string cointains " + answer + " spaces");
            }   

            //for the sake of breivty i started pre-filling the answers
            else if(part==5){int [] num = {5,7,3,2,9};
            Console.WriteLine("The total for the array is "+ num.Sum());
            }

            else if(part==6){
                Console.WriteLine("Enter a Number: ");
                int a= int.Parse(Console.ReadLine());
                Console.WriteLine("And another Number: ");
                int b= int.Parse(Console.ReadLine());
                var tuple = Switch(a,b);
                Console.WriteLine("Now the first number is "+ tuple.Item1 +" And the second is " +tuple.Item2);
            }
            else if(part==7){ 
            Console.Write("Enter first number: ");
            double x =double.Parse(Console.ReadLine());
            Console.Write("Enter Exponent: ");
            double y=double.Parse(Console.ReadLine());
            Console.WriteLine("Result:" + Math.Pow(x, y));}

            else if(part==8){
                Console.Write("Enter how many digits of the fibbonaci sequence:");
                int howmany = int.Parse(Console.ReadLine());
                List<int> sequence = fibbonaci(howmany);
                Console.WriteLine(String.Join(", ", sequence));
            }
            //so i figured out about here you can nest the input in the quotations rather than abusing the + key 
            else if(part==9){            
            Console.Write("Enter a new number: ");
            int input = int.Parse(Console.ReadLine());
            bool answer = prime(input);
            if (answer){
                Console.WriteLine("{0} Is a prime number", input);
            }
            else{
                Console.WriteLine("{0} Is not a prime number", input);
            }
            }
            else if(part==10){
                Console.WriteLine("I can count characters! write something: ");
                string howmany = Console.ReadLine();
                Console.WriteLine("This String contains {0} characters" ,howmany.Length);
                }                

        }
        public static Tuple<string,string> greeting(string name){
        string reply = ("Welcome Friend " + name);
        string reply2= ("Have a nice Day!");
        return new Tuple<string, string>(reply, reply2);

        }
        public static int basicadd(int no1, int no2){
        int answer = (no1+no2);
        return answer;
        }
        public static int spacecount (string input){
        int count = input.Count(a => a == ' ');
        return count;
        }
        public static Tuple<int, int> Switch(int no2, int no1){

        return new Tuple<int, int>(no1,no2);
        }
        public static List<int> fibbonaci(int howmany){
        List<int> sequence = new List<int>();             
        int first = 0;
        int second= 1;  
        sequence.Add(first);
        sequence.Add(second);
            int third = first + second;
            for(int i = 3; i <= howmany; i++){
                sequence.Add(third);
                first = second;
                second = third;
                third = first + second;
            }
        return sequence;
    }

        public static bool prime(int input){
        int number =0;
        for(int i = 1; i <= input; i++){
        if(input % i == 0){
        number++;
        }
        }
        if (number==2){
        
        return true;  
            }
        return false;
        }
    }
    
}
