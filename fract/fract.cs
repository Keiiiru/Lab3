namespace Getter
{

    public class Getter
    {
        
        public Tuple<string,string> Get() 
        {
            string a, b;
            Console.WriteLine("Введите дробь 1 > ");
            a = Console.ReadLine();

            Console.WriteLine("Введите дробь 2 > ");
            b = Console.ReadLine();

            return Tuple.Create(a, b);
        }
 
       

        
    }

    
}
