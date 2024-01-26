namespace sk92
{
    public class UserService
    {
        public delegate void UserNumberReaderDelegate(int number, List<string> lastNames);
        public event UserNumberReaderDelegate UserNumberReaderEvent;

        public void ReadUserNumber(List<string> LastNames)
        {
            Console.WriteLine("Введите метод сортировки: 1 - по алфавиту, 2 - в обратном порядке:");
            int InputNumber = 0;
            bool IsCorrect = true;
            while (IsCorrect) 
            { 
                try
                {
                    InputNumber = Convert.ToInt32(Console.ReadLine());
                    if (InputNumber != 1 && InputNumber != 2)
                    {
                        throw new FormatException();
                    }
                    IsCorrect = false;
                }
                catch (FormatException) 
                {
                    Console.WriteLine("Введенено некорректное значение. Введите 1 или 2:");
                }
            }
            UserNumberReader(InputNumber, LastNames);
        }
 
        protected virtual void UserNumberReader(int number, List<string> lastNames) 
        {
            UserNumberReaderEvent?.Invoke(number, lastNames);
        }
    }
}