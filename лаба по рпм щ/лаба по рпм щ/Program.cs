using лаба_по_рпм_щ.Models;

            Student student1 = new Student();
            student1.Group = "ИСП-31-24";
            student1.Name = "Павел";
            student1.Id = 1;

            Console.WriteLine($" Имя студента - {student1.Name}, Группа - {student1.Group}, ID - {student1.Id}");

            Student student2 = new Student();
            student2.Name = "Елена";
            student2.Id = 2;
            student2.Group = "OIB-23-23";

            Console.WriteLine($" Имя студента - {student2.Name}, Группа - {student2.Group}, ID - {student2.Id}");

            Group group1 = new Group();
            group1.Id = 1;
            group1.Name = "ИСП-31-24";
            group1.Kurs = 3;
            group1.Specialnost = "ИСП";

            Console.WriteLine($" Название группы - {group1.Name}, Курс - {group1.Kurs}, ID - {group1.Id}, Специальность {group1.Specialnost} ");
        
           Period_Praktiki period1 = new Period_Praktiki();
            period1.Id = 1;
            period1.vid_praktiki = "Производственная";
            







