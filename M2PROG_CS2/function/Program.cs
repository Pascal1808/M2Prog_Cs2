namespace function
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
            program.Vraag1();
            program.Vraag2();
            program.Vraag3();
            program.Vraag4();
        }

        internal void Run()
        {
            Console.WriteLine("vraag 1");
        }

        internal void Vraag1()
        {
            Console.WriteLine("how long do you think you'd survive in a zombie apocalypse?");
            string antwoord = Console.ReadLine();

            Console.WriteLine(antwoord);
        }
        
        internal void Vraag2(){
            Console.WriteLine("What would you call a male ladybug?");
            string antwoord = Console.ReadLine();

            Console.WriteLine(antwoord);
        }

        internal void Vraag3()
        {
            Console.WriteLine("Why do round pizzas come in square boxes?");
            string antwoord = Console.ReadLine();

            Console.WriteLine(antwoord);
        }
        
        internal void Vraag4(){
            Console.WriteLine("What would you do if you won a million dollars?");
            string antwoord = Console.ReadLine();

            Console.WriteLine(antwoord);
        }
    }
}
