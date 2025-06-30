namespace _03._Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfPeople = int.Parse(Console.ReadLine());
            int capacityOfPeople = int.Parse(Console.ReadLine());

            int courses = (int)Math.Ceiling((double)numOfPeople / capacityOfPeople);

            Console.WriteLine(courses);
        }
    }
}
