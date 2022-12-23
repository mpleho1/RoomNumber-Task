namespace RoomNumber
{
    class Program
    {
        private static RoomNumbers roomNumbers = new RoomNumbers();

        static void Main(string[] args)
        {
            bool isInputValid = true;

            do
            {
                Console.WriteLine("Write in the number of your room:");
                var inputFromUser = Console.ReadLine();
                int parseResult;

                bool result = int.TryParse(inputFromUser, out parseResult);

                if (result)
                {
                    isInputValid = !(parseResult <= 0 || parseResult > 1000000);
                    int sets = roomNumbers.numberOfSets(parseResult);
                    Console.WriteLine(sets.ToString() + " sets are required.");
                }
                else
                {
                    isInputValid = false;                     
                }
            } while (!isInputValid);
        }
    }
}