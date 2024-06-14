using System;

 // Compiler version 4.0, .NET Framework 4.5


 namespace Dcoder
 {
   public class PrimeNumCheck
   {
   public static void Main(string[] args)
    {
        int n, divider , cnt=0;
Console.WriteLine("enter a number: ");
      n=  Convert.ToInt32(Console.ReadLine() );
     divider =n -1;
     
        while ( divider >1 && n!=2 )
        {
            if(n% divider == 0)
            {
              cnt++;
              Console.WriteLine ($"{n} is not prime. ");
              break;
            
            }
            
            divider-- ;
        }
        
        
        if( ( cnt==0 || n==2) &&  n!= 1 )
           Console.WriteLine ($"{n} is prime. ");
        else if(n==1)
         Console.WriteLine ($"{n} is not prime. ");
     
         
              
          }
         
    }
 }
