using System;  
  public class questionOne  
   {  
     public static void Main(string[] args)  
      {  
       int sum=0;
       int mod = 0;         
       Console.Write("Enter a number: ");      
       int N= int.Parse(Console.ReadLine());   
       if(10000000>N>10000){
          Console.Write("Please enter number between 10000 and 10000000"); 
       }else{
           while(N>0)      
       {      
        mod=N%10;      
        sum=sum+mod;      
        N=N/10;      
       }
       Console.Write("sum is: "+sum); 
       int new_sum = 0;
       if(sum >10){
           mod=sum%10;      
           new_sum=new_sum+mod;      
           sum=sum/10;
           Console.Write("Final Sum is= "+new_sum); 
       }else{
          Console.Write("Final Sum is= "+sum);  
       } 
       }              
     }  
  }