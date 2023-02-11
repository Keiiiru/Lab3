




namespace Main
{
    
  public class Ask
    {
        
        public string? Numbers { get; set; }
        public List<double>? fractions;
    }

    public class question
    {
        public double a, b;
        public  List<Ask> Nums;
        
        public question()
        {
            Nums = new List<Ask>()
            {
                new Ask()
                {
                    Numbers = "Введите а",
                    fractions = new List<double>(){ a, b }

                }


            };
        }
    }
    



}