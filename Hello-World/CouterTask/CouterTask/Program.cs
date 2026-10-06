namespace CouterTask
{
    internal class Program
    {
        
        
        static void Main(string[] args)
        {
            string seconds = "seconds";
            Counter counter = new Counter(seconds);
            Clock clock = new Clock(counter);
            
            for (int i = 0; i < 86500; i++)
            {
                
                Console.WriteLine(clock.Display());
                clock.Update();
                
            }
        }
    }
}
