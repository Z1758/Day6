using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Day6_Assignment
{
    internal class Program
    {


  

        static public int Assignment1(int num)
        {
            int sum = 0;
            for (int i = 0; i <= num; i++) {

                if (i % 3 == 0)
                {
                    sum += i;
                }
                else if (i % 5 == 0)
                {
                    sum += i;

                }
            }

            return sum;
        }
      
        static public int Assignment2(int num)
        {
            int sum = 0;

            string str = num.ToString();

            for(int i = 0;i<str.Length; i++ )
            {
                //문자열을 배열로 int.Parse 할때 다시 문자열로 형변환 해줘야 한다
                sum+=int.Parse(str[i].ToString());
            }
            return sum;
        }

        //반복문 피보나치
        static public int Assignment3_Fibonacci(int num)
        {
            if (num == 1||num == 2)
            {
                return 1;
            }

            int x = 1;
            int y = 1;
            int sum = 0;

            for (int i = 0; i < num - 2; i++)
            {
                sum = x + y;
                x = y;
                y = sum;      
            }


            return sum;
        }

        //일반재귀 피보나치
        static int Fibonacci(int num)
        {
            if (num <= 1)
            {
                return num;
            }

            return Fibonacci(num - 1) + Fibonacci(num - 2);
        }


        //꼬리재귀 피보나치
        //매개변수 num이 반복문의 i 
        static int FibonacciTail(int num, int x , int y )
        {
            if (num == 1)
                return x;
            if (num == 2)
                return y;

            int sum = x + y;
            x = y;
            y = sum;

            return FibonacciTail(num - 1, x, y);
        }


   

        static void Main(string[] args)
        {
            Console.WriteLine("심화 1 " + Assignment1(15));
            Console.WriteLine("심화 2 " + Assignment2(5611));
            Console.WriteLine("심화 4 " + Assignment3_Fibonacci(11));

            Console.WriteLine("재귀 " + Fibonacci(11));
            Console.WriteLine("꼬리재귀 "+ FibonacciTail(11, 1,1));

        }
    }
}
