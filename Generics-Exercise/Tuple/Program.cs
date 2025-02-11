namespace Tuple
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Задча 7
            //string[] firstInput = Console.ReadLine().Split();
            //string fullName = firstInput[0] + " " + firstInput[1];
            //string address = firstInput[2];

            //string[] secondInput = Console.ReadLine().Split();
            //string name = secondInput[0];
            //int litersOfBeer = int.Parse(secondInput[1]);

            //string[] thirdInput = Console.ReadLine().Split();
            //int intValue = int.Parse(thirdInput[0]);
            //double doubleValue = double.Parse(thirdInput[1]);

            //var firstTuple = new MyTuple<string, string>(fullName, address);
            //var secondTuple = new MyTuple<string, int>(name, litersOfBeer);
            //var thirdTuple = new MyTuple<int, double>(intValue, doubleValue);

            //Console.WriteLine(firstTuple);
            //Console.WriteLine(secondTuple);
            //Console.WriteLine(thirdTuple);

            //Задача 8

            string[] firstInput = Console.ReadLine().Split();
            string fullName = firstInput[0] + " " + firstInput[1];
            string address = firstInput[2];
            string town = firstInput[3];

            string[] secondInput = Console.ReadLine().Split();
            string name = secondInput[0];
            int litersOfBeer = int.Parse(secondInput[1]);
            bool isDrunk = secondInput[2] == "drunk";

            string[] thirdInput = Console.ReadLine().Split();
            string personName = thirdInput[0];
            double balance = double.Parse(thirdInput[1]);
            string bankName = thirdInput[2];

            var firstThreeuple = new Threeuple<string, string, string>(fullName, address, town);
            var secondThreeuple = new Threeuple<string, int, bool>(name, litersOfBeer, isDrunk);
            var thirdThreeuple = new Threeuple<string, double, string>(personName, balance, bankName);

            Console.WriteLine(firstThreeuple);
            Console.WriteLine(secondThreeuple);
            Console.WriteLine(thirdThreeuple);
        }
    }
}
