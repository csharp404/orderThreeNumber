internal class Program
{
    private static void Main(string[] args)
    {
        int a, b, c;
        a = b = c = 1;
        Console.WriteLine("first number please :");
        if (int.TryParse(Console.ReadLine(),out int first))
        {
            Console.WriteLine("second number please");
            if(int.TryParse(Console.ReadLine(),out int sec))
            {
                Console.WriteLine("third number please");
                if(int.TryParse(Console.ReadLine(),out int third))
                {
                    if(first >= sec && first >=third)
                    {
                        c = first;
                        if(sec > third)
                        {
                            b=sec;
                            a = third;
                        }
                        else
                        {
                            b = third;
                            a= first;
                        }
                    }
                    else if(sec >= third && sec >= first)
                    {
                        c = sec;
                        if(first > third)
                        {
                            b = first;
                            a = third;
                        }
                        else
                        {
                            a = first;
                            b=third;
                        }
                    }
                    else if(third > first && third > sec)
                    {
                        c = third;

                        if(sec > first)
                        {
                            b = sec;
                            a = first;
                        }
                        else
                        {
                            a = sec;
                            b=first;
                        }
                    }

                    Console.WriteLine($"this is the 3 numbers in order: {a}, {b}, {c}");
                }
                else {
                    Console.WriteLine("invalid input!!");
                }
            }
            else
            {
                Console.WriteLine("invalid input!!");
            }
        }
        else
        {
            Console.WriteLine("invalid input!!");
        }


      

    }
}