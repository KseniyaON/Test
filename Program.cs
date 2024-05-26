using System;

namespace newFold
{
    class Program
    {
        static void Main(string[] args)
        {
            int M=10;
            int N=30;
        
        void Nature_Numbers(int M, int N)
        {
        if(M==N)  
        {
        Console.Write(M + " "); 
        return;
        }
        Console.Write(M + " ");
        Nature_Numbers (M+1,N);
        }
       Nature_Numbers (M,N);

        }
    }
}
