namespace Day6
{
    internal class Program
    {
        /* 과제
        //배열 내림차순 정렬하는 함수
        static public float[] DescendingSort(float[] f)
        {
            float temp = 0.0f;

            //버블 정렬
            for (int i = 0; i < f.Length; i++)
            {
                for (int j = 0; j < f.Length - 1; j++)
                {
                    if (f[j] < f[j + 1])
                    {
                        temp = f[j];
                        f[j] = f[j + 1];
                        f[j + 1] = temp;
                    }
                }
            }
            return f;

        }

        //함수 오버라이딩
        static public int[] DescendingSort(int[] f)
        {
            int temp = 0;
            for (int i = 0; i < f.Length; i++)
            {
                for (int j = 0; j < f.Length - 1; j++)
                {
                    if (f[j] < f[j + 1])
                    {
                        temp = f[j];
                        f[j] = f[j + 1];
                        f[j + 1] = temp;

                    }

                }
            }
            return f;

        }


        static public int Assignment1(int a, int b, int c, int d)
        {
            int[] ints = { a, b, c, d };


            DescendingSort(ints);

            return ints[0];

        }

        static public float Assignment2(float a1, float a2, float a3, float a4, float a5)
        {
            float[] floats = { a1,a2,a3,a4,a5 };

            floats = DescendingSort(floats);

            return floats[0] + floats[1];
        }


        static public bool Assignment3(int a, int b)
        {
            bool flag=true;
            if (a > b) {
                if (a <= b + 99)
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                }
            }
            else
            {
                if (a +99 >= b)
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                }
            
            }

            return flag;

        }
        */
        enum Direction { Up, Down, Left, Right }

        public struct Monster
        {
            public string name;
            public int attack;

        }
        public static Monster MakeMonster(string mob)
        {

            Monster monster = new Monster();
            switch (mob)
            {
                

                case "오크":
                    monster.attack = 10;
                    monster.name = "오크";
                    break;
                case "슬라임":
                    monster.attack = 10;
                    monster.name = "슬라임";
                    break;
                default:
                    
                    break;
            }

            return monster;

        }

        static void Damage(ref int damage)
        {
            damage = damage + 10;
        }

        static void Main(string[] args)
        {
            /* 과제
            Console.WriteLine("과제1 " +Assignment1(3, 15, 8, 10));
            Console.WriteLine("과제2 " +Assignment2(3.0f, 15.7f, 8.0f, 10.0f, 1.0f));
            Console.WriteLine("과제3 " +Assignment3(103, 15));
            */
            
            MakeMonster("오크");


            ConsoleKey key = Console.ReadKey(true).Key;
          
            switch (key)
            {
                case ConsoleKey.A:
                case ConsoleKey.LeftArrow:
                    Console.WriteLine("좌");
                    break;
                case ConsoleKey.D:
                case ConsoleKey.RightArrow:
                    Console.WriteLine("우");
                    break;
                case ConsoleKey.W:
                case ConsoleKey.UpArrow:
                    Console.WriteLine("상");
                    break;
                case ConsoleKey.S:
                case ConsoleKey.DownArrow:
                    Console.WriteLine("하");
                    break;
            }

            int damage = 10;
            Damage(ref damage);
            Console.WriteLine(damage);


        }
    }
}
