namespace sk92
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> LastNames = new List<string>
            {
                "Иванов",
                "Петров",
                "Сидоров",
                "Лопаткин",
                "Метак"
            };

            UserService userService = new UserService();
            userService.UserNumberReaderEvent += Sorting;
            userService.ReadUserNumber(LastNames);
        }

        static void Sorting(int number, List<string> LastNames)
        {
            switch (number)
            {
                case 1: SortLastNames(LastNames); break;
                case 2: SortLastNamesDesc(LastNames); break;
            }
        }

        static void SortLastNamesDesc(List<string> LastNames)
        {
            var SortedLastNames = LastNames.OrderByDescending(x => x);
            foreach (string lastname in SortedLastNames)
            { 
                Console.WriteLine(lastname);
            }
        }

        static void SortLastNames(List<string> LastNames)
        {
            var SortedLastNames = LastNames.OrderBy(x => x);
            foreach (string lastname in SortedLastNames)
            {
                Console.WriteLine(lastname);
            }
        }
    }
}