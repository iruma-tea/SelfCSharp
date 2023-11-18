namespace SelfCSharp.Chap01 
{
    internal class Person
    {
        public string? firstName;

        public string? lastName;

        public string Show(int Age)
        {
            return $"名前は{lastName}{firstName}、{Age}歳です。";
        }
    }

    internal class PersonClient
    {
        static void Main(string[] args)
        {
            var p = new Person();
            p.firstName = "太郎";
            p.lastName = "山田";
            Console.WriteLine(p.Show(20));
        }
    }
}