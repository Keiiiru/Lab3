


namespace Result
{
    public class Result
    {
            public double GetResult()
            {
                Getter.Getter getter = new Getter.Getter();
                var input = getter.Get();
                double res = FractionResults(input.Item1) * FractionResults(input.Item2);
                
                return res; 
            }

        public double FractionResults(string frct)
        {
            double result = Convert.ToDouble(frct.Split('/')[0])/ Convert.ToDouble(frct.Split('/')[1]);
            return result;
        }

    }
}
          

            
    
    
    


    

        
    
