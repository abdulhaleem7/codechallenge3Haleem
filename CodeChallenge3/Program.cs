using System;

namespace CodeChallenge3
{
    class Program
    {
        static void Main(string[] args)
        {
            //addition();
            //  division();
            //contigious();
            Palindrom();
        }
        static void addition()
        {
            int[] num = { 10,2,5,3};

            bool isdivisor = false;
            for (int i = 0; i < num.Length; i++)
            {

                for (int j = 0; j < num.Length; j++)
                {
                    if (num[i] == num[j] * 2)
                    {
                        isdivisor = true;
                    }
                    
                    
                }
                              
            }
            Console.WriteLine(isdivisor);
        }
        static void division()
        {
            int num = 21;
            int div = 0;
            int sum = 0;
            bool iseqaul = true;
            for (int divider = 1; divider <= num / 2; divider++)
            {
                if (num % divider == 0)
                {
                    div= divider;
                    sum += divider;

                   // Console.Write(div+ " ");
                    
                }
                
            }
            if (sum==num)
            {
                
            }
            else
            {
                iseqaul = false;
            }
            Console.WriteLine(iseqaul);

        }
        static void contigious()
        {
          

            
                int[] num = { 1, 12, -5, -6, 50, 3 };
                //int max;
                int k = 4;
                 double y = 0;
                int sum = 0;
                for (int i = 0; i <= num.Length - k; i++)
                {


                // int sum = 0;
                sum = 0;
                    for (int j = i; j < k+i; j++)
                    {
                        
                        sum += num[j];   

                    }
                    if (sum > y)
                    {
                      y = sum;
                    }


                }
                  Console.WriteLine(y/k);

        }
        public static void Palindrom()
        {
            var s = "levvelt";
            if (Ispalindrome(s))
            {
                Console.WriteLine(true);
                return;
            }
            for (int i = 0; i <s.Length; i++)
            {
                var newstring = s.Remove(i, 1);
                if (Ispalindrome(newstring))
                {
                    Console.WriteLine(true);
                    return;
                }
            }
            Console.WriteLine(false);
        }
        static bool Ispalindrome(string s)
        {
            
           
            for (int i = 0; i < s.Length / 2; i++)
            {
                if (s[i] != s[s.Length - 1 - i])
                {
                    return false;
                }
               
            }
            return true;
        }
    }
}
