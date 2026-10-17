namespace _14_15_лаба
{
    internal class Program
    {
        
        
            static void Main()
            {
                Console.WriteLine("=== Упражнение 1: Проверка размера участников ===");
                CheckParticipants();

                Console.WriteLine("\n=== Упражнение 2: Подсчет цифр ===");
                Console.WriteLine("Число 0: " + CountDigits(0) + " цифра(ы)");
                Console.WriteLine("Число 7: " + CountDigits(7) + " цифра(ы)");
                Console.WriteLine("Число 1000: " + CountDigits(1000) + " цифра(ы)");

                Console.WriteLine("\n=== Задание А: Угадай 7 * 8 ===");
                TaskA();

                Console.WriteLine("\n=== Упражнение 3: Диалог с приветствием ===");
                GreetingDialog();

                Console.WriteLine("\n=== Задание Б: Подтверждение ===");
                TaskB();

                Console.WriteLine("\nНажмите любую клавишу для выхода...");
                Console.ReadKey();
            }



            static void CheckParticipants()
            {
                int size;
                bool valid;
                do
                {
                    Console.Write("Количество участников (1-30): ");
                    string input = Console.ReadLine();
                    if (input == null) { Console.WriteLine("Ввод завершён"); return; }

                    valid = int.TryParse(input, out size) && size >= 1 && size <= 30;

                    if (!valid)
                        Console.WriteLine("Нужно целое число от 1 до 30.");
                }
                while (!valid);

                Console.WriteLine($"Принято: {size}");
            }

            static int CountDigits(int number)
            {
                int count = 0;
                int remaining = number;

                do
                {
                    count++;
                    remaining = remaining / 10;
                }
                while (remaining > 0);

                return count;
            }

            static void TaskA()
            {
                int answer;
                int attempts = 0;
                bool valid;

                do
                {
                    attempts++;

                    Console.Write("Сколько будет 7 * 8? ");
                    string input = Console.ReadLine();

                    if (input == null)
                    {
                        Console.WriteLine("Ввод завершён");
                        return;
                    }
                    valid = int.TryParse(input, out answer) && answer == 56;

                    if (!valid)
                        Console.WriteLine("Неверно. Попробуйте снова.");
                }
                while (!valid);

                Console.WriteLine($"Верно! Вы угадали за {attempts} попыток.");
            }

            static void GreetingDialog()
            {
                string answer;
                do
                {
                    Console.WriteLine("Привет!");
                    Console.Write("Повторить? (да/нет): ");
                    answer = Console.ReadLine();
                }
                while (answer == "да" || answer == "Да");
                Console.WriteLine("До свидания!");
            }

            static void TaskB()
            {
                string input;
                int attempts = 0;

                do
                {
                    attempts++;

                    Console.Write("Введите слово 'подтверждаю' для продолжения: ");
                    input = Console.ReadLine();

                    if (input == null)
                    {
                        Console.WriteLine("Ввод завершён");
                        return;
                    }

                    if (!string.Equals(input, "подтверждаю", StringComparison.OrdinalIgnoreCase))
                        Console.WriteLine("Неверно. Попробуйте снова.");
                }
                while (!string.Equals(input, "подтверждаю", StringComparison.OrdinalIgnoreCase));

                Console.WriteLine($"Подтверждено! Количество попыток: {attempts}");
            }
        }
    }
    

