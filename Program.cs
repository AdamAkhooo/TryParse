using System;

class Program{
    static void Main(string[]args){
        
        int result;
        if(!TryParse(Console.ReadLine(), out result))
        Console.WriteLine("Skriv in en siffra");
        else{
            Console.WriteLine(result);
            }
        
        
        
        
         static bool TryParse(string s, out int result){
            result =int.Parse(s);
            if(result != null){
                return true;
            }
            else{
                return false;
            }
        }
    }
}
