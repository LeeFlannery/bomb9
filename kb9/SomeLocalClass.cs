namespace kb9
{
    public static class SomeLocalClass
    {
        public static string SomeProcess()
        {
            int someInt = 58;
            string someString = "A";
            string str2 = string.Empty;
            int num = 65;
            while (num < 123)
            {
                str2 = str2 + ((char)num).ToString();
                System.Console.WriteLine("str2 " + str2);
                num += someInt;
            }
            System.Console.WriteLine("end " + str2 + " == " + someString + "       ?");
            return !(someString == str2) ? "Cue sad trombone noise..." : "Boo Yah! That's correct!";
        }
    }
}