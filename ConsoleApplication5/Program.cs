using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example 4
{
    class Program
    {
        static bool IsPrime(string x)
        {
            //получаем числовое занчение числа
        int a=int.Parse(x);
            int cnt=0;
            //находим количество значений чисел(делителей)
            for(int i=0; i<a; ++i){
                if(a % i == 0){
                    cnt++;
                }
            }
            if(cnt==2) return true;
            return false;
        }
        static void Main(string[] args){
            for(int i=0; i<=args.Length; ++i)

        }
    }
}
