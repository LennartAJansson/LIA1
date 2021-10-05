namespace ConsoleApp1
{
    public record Person(int Id, string Firstname, string Lastname, string Email);

    public class PersonClass
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
    }

    internal class Test
    {
        public Test()
        {

        }

        public Test(bool b)
        {
            PersonClass o1 = new() { Id = 1, Firstname = "Kalle", Lastname = "Karlsson", Email = "" };
            o1.Email = "email";

            PersonClass o2 = new() { Id = 1, Firstname = "Kalle", Lastname = "Karlsson", Email = "" };
            o2.Email = "email";
            if (o1 == o2) { }

            Person p2 = new(2, "Olle", "Olsson", "");
            Person p3 = new(2, "Olle", "Olsson", "");// with { Email = "email" };
            if (p2 == p3) { }

            (int i, string f, string l, string e) = p3;

            System.Console.WriteLine(e);
        }

        ~Test()
        {
        }
    }
}
