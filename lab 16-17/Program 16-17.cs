
        {

            long s = 0;
            int c = 0;
            Console.WriteLine("Вводите целые от -1000 до 1000; 0 завершает.");
            string line1 = Console.ReadLine();
            if (line1 == null) return;
            int value = int.Parse(line1);
            while (value != 0)
            {
                s += value;
                c++;
                line1 = Console.ReadLine();
                if (line1 == null)
                {
                    Console.WriteLine("Ввод завершён");
                    return;
                }
                value = int.Parse(line1);
            }
            Console.WriteLine($"Количество: {c}; сумма: {s}");





            int required = 7;
            long capacity = 1;
            int steps = 0;
            while (capacity < required)
            {
                capacity *= 2;
                steps++;
            }
            Console.WriteLine($"{capacity}; {steps}"); // 8; 3

            int[] values = { };
            int index = 0;
            while (index < values.Length && values[index] >= 0)
            {
                index++;
            }
            if (index < values.Length)
                Console.WriteLine($"Первое отрицательное: индекс {index}");
            else
                Console.WriteLine("Не найдено");






            long sum = 0;
            int count = 0;

            Console.WriteLine("Вводите целые от -1000 до 1000. Отрицательное завершает.");


            string li = Console.ReadLine();
            if (li == null) { Console.WriteLine("Ввод завершён"); return; }
            int value1 = int.Parse(li);

            while (value >= 0)
            {
                sum += value1;
                count++;


                li = Console.ReadLine();
                if (li == null) { Console.WriteLine("Ввод завершён"); return; }
                value1 = int.Parse(li);
            }

            Console.WriteLine($"Неотрицательных: {count}, сумма: {sum}");
            Console.WriteLine($"Завершающее отрицательное: {value1} (исключено)");






            int errors = 0;
                int warnings = 0;

                Console.WriteLine("Вводите коды событий. 999 завершает.");

                string line = Console.ReadLine();
                if (line == null) { Console.WriteLine("Ввод завершён"); return; }
                int code = int.Parse(line);

                while (code != 999)
                {
                    if (code == 2)
                        errors++;
                    else if (code == 1)
                        warnings++;

                    line = Console.ReadLine();
                    if (line == null) { Console.WriteLine("Ввод завершён"); return; }
                    code = int.Parse(line);
                }

                Console.WriteLine($"Ошибок (код 2): {errors}");
                Console.WriteLine($"Предупреждений (код 1): {warnings}");

            }

        
   

    

