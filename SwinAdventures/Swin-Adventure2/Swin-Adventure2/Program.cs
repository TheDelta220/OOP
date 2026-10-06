

namespace Swin_Adventure2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string studentId = "103995219";
            string firstName = "Callum";
            string lastName = "Fennessy";

            IdentifiableObject obj = new IdentifiableObject(new[] { "007", "James" });
            string tutorialId = "123";
            
            string firstId = obj.FirstId;

            if (firstId == studentId)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

        }
    }
}
