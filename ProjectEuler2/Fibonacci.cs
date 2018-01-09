using System;

namespace ProjectEuler2
{
    internal class Fibonacci//이게 뭘까
    {
        private readonly long[] _memo = new long[100];//static 해줘야되나?//갯수가 100개면 충분하지 않은것 같다.

        private long fibonacci_func(int n)
        {
            //long answer = 0;
            if (n <= 1)
            {
                return n;
            }

            if (_memo[n] != 0)
            {
                return _memo[n];
            }

            return _memo[n] = fibonacci_func(n - 1) + fibonacci_func(n - 2);
            //return answer;
        }

        private static void Main(string[] args)
        {
            var c = new Fibonacci();
            long result = 0;
            var index = 0;
            while ((true))
            {
                if (c.fibonacci_func(index) > 4000000)
                    break;
                if (c.fibonacci_func(index) % 2 == 0)//짝수라면
                {
                    result += c.fibonacci_func(index);
                }

                index++;
            }
            
            Console.WriteLine(result);
            //Console.WriteLine("Hello World!");
        }
    }
}
