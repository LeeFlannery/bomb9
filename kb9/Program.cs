namespace kb9
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // This method was used to observe the behavior of the mystery process
            // System.Console.WriteLine(SomeLocalClass.SomeProcess());
            System.Console.WriteLine(Bombed.SomeClass.SomeProcess(new SomethingConcrete()));
        }
    }
}