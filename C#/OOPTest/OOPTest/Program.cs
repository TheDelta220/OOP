namespace OOPTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string studentID = "103995219";
            int[] B = { 13, 5, 3, 29 };
            FileSystem Unicron = new FileSystem();
            for (int i = 0; i < B[0]; i++)
            {
                string fileName = $"{studentID}-{i:D2}";
                File file = new File(fileName, "txt", 100 + i);
                Unicron.Add(file);
            }

            Folder alien = new Folder("Alien");
            for (int i = 0; i < B[1]; i++)
            {
             string Nfile = $"{studentID}-{i:D2}";
                File file = new File(Nfile, "txt", 100 + i);
                alien.Add(file);
            }
            Unicron.Add(alien);

            Folder Thomas = new Folder("Thomas");
            Folder Bruce = new Folder("Bruce");
            for (int i = 0; i < B[2]; i++)
            {
                string Nfile = $"{studentID}-{i:D2}";
                File file = new File(Nfile, "txt", 100 + i);
                Bruce.Add(file);
            }
            Thomas.Add(Bruce);
            Unicron.Add(Thomas);

            for (int i = 0;i < B[3]; i++)
            {
                Folder Luffy = new Folder("Luffy");
                Unicron.Add(Luffy);
            }

            Unicron.PrintContents();

        }
    }
}
