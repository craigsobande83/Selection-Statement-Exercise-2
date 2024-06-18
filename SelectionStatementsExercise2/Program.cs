namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what is your favorite school subject?");

            var subject = Console.ReadLine();

            switch (subject)
            {
                case "Physics":
                    Console.WriteLine(" Physics is a tough subject!");
                    break;
                case "Biology":
                    Console.WriteLine(" Biolgy is too intense and graphic");
                    break;
                case "English":
                    Console.WriteLine(" English is an interesting subject!");
                    break;

                case "Maths":
                    Console.WriteLine("Maths is a great subject!");
                    break;
                case " Chemisty":
                    Console.WriteLine(" The best subject  ever !");
                    break;

                default:
                    Console.WriteLine($"This is a new subject, i havent taken it before , {subject} sounds fun ");
                    break;








            }
        }
    }
}