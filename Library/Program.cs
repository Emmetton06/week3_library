using Library;
class Program
{
    static void Main(string[] args)
    {
        Book book = new Book("C# for beginners1", "Bill Gates", 12345678);
        book.DisplayInfo();
        Book book1 = new Book("C# for Methods and classes", "Microsoft", 55667788);
        book1.DisplayInfo();

        Member member = new Member(1, "John Smith", "1 High Street", 0790090090);
        Member member1 = new Member(2, "Mary Jones", "102 Garden Road", 0790345666);

        Console.WriteLine("Current library members");
        member.DisplayInfo();
        member1.DisplayInfo();

        // Testing the validation logic with invalid data
        Member invalidMember = new Member(-5, "Rob0t C0p", "50 Main Street", 078112233);
    }
}







        