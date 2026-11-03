

using System;
namespace дз
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //1
            Student student1 = new Student();
            student1.Group = "ИСП-31-24";
            student1.Name = "Павел";
            student1.Surname = "Бенок";
            student1.Id = 1;

            Console.WriteLine($" Имя студента - {student1.Name},Фамилия - {student1.Surname}, Группа - {student1.Group}, ID - {student1.Id}");

            Student student2 = new Student();
            student2.Name = "Анна";
            student2.Surname = "Смирнова";
            student2.Id = 2;
            student2.Group = "ОИБ-22-25";

            Console.WriteLine($" Имя студента - {student2.Name},Фамилия - {student2.Surname}, Группа - {student2.Group}, ID - {student2.Id}");
            //2
            Group group1 = new Group();
            group1.Name = "ИСП-31-24";
            group1.Id = 1;
            group1.Kurs = 3;
            group1.Speciality = "Информационные системы и программирование";

            Group group2 = new Group();
            group2.Name = "ОИБ-22-25";
            group2.Id = 2;
            group2.Kurs = 2;
            group2.Speciality = "Обсепечение информационной безопасности";

            Console.WriteLine($" Название группы - {group1.Name}, Курс - {group1.Kurs}, Специальность - {group1.Speciality}, ID - {group1.Id}");
            //3
            Napravlenie napravlenie1 = new Napravlenie();
            napravlenie1.Id = 1;
            napravlenie1.sostoyanie = "оформлено";
            napravlenie1.data_nachala = new DateOnly (2026 , 04 ,05);
            napravlenie1.data_okonchaniya = new DateOnly(2026, 04, 25);
            napravlenie1.stident_id = 1;
            napravlenie1.place_of_praktiki_id = 1;

            Console.WriteLine($" Айди направления - {napravlenie1.Id}, Состояние - {napravlenie1.sostoyanie}, Дата начала практики - {napravlenie1.data_nachala}, Дата окончания практики - {napravlenie1.data_okonchaniya}");
            //3
            Organizacia organizacia1 = new Organizacia();
            organizacia1.name = "АО УМПО";
            organizacia1.adress = "Г. Уфа, Улица Ленина 2";
            organizacia1.Id = 1;
            Console.WriteLine($" Название организации - {organizacia1.name}, адресс - {organizacia1.adress} , ID - {organizacia1.Id}");

            //4
            Rukovoditel_ot_kolledzha Rukovoditel_ot_kolledzha1 = new Rukovoditel_ot_kolledzha();
            Rukovoditel_ot_kolledzha1.name = "Семен";
            Rukovoditel_ot_kolledzha1.surname = "Ясупов";
            Rukovoditel_ot_kolledzha1.patronymic = "Иванович";
            Rukovoditel_ot_kolledzha1.Id = 1;
            Rukovoditel_ot_kolledzha1.specialnost = "Программирование";
            Console.WriteLine($" Имя руководителя - {Rukovoditel_ot_kolledzha1.name}, Фамилия - {Rukovoditel_ot_kolledzha1.surname}, Специальность - {Rukovoditel_ot_kolledzha1.specialnost}, ID - {Rukovoditel_ot_kolledzha1.Id}");
            
            //5
            Period_praktiki Period_praktiki1 = new Period_praktiki();
            Period_praktiki1.Id = 1;
            Period_praktiki1.vid_praktiki = "Производственная";
            Period_praktiki1.data_nachala = new DateOnly(2026, 04, 05);
            Period_praktiki1.data_okonchaniya = new DateOnly(2026, 04, 25);
            Console.WriteLine($" Вид практики - {Period_praktiki1.vid_praktiki}, дата начала - {Period_praktiki1.data_nachala}, дата окончания - {Period_praktiki1.data_okonchaniya}, ID - {Period_praktiki1.Id}");
            
            //6
            Nastavnik_ot_organizacii Nastavnik_ot_organizacii1 = new Nastavnik_ot_organizacii();
            Nastavnik_ot_organizacii1.Id = 1;
            Nastavnik_ot_organizacii1.name = "Кирилл";
            Nastavnik_ot_organizacii1.surname = "Углев";
            Nastavnik_ot_organizacii1.patronymic = "Иванович";
            Nastavnik_ot_organizacii1.organizacia_Id = 1;
            Nastavnik_ot_organizacii1.specialnost = "IT специалист";
            Console.WriteLine($" Имя наставника - {Nastavnik_ot_organizacii1.name}, Фамилия - {Nastavnik_ot_organizacii1.surname}, Специальность - {Nastavnik_ot_organizacii1.specialnost}, ID - {Nastavnik_ot_organizacii1.Id}");
            
            //7
            place_of_praktiki place_of_praktiki1 = new place_of_praktiki();
            place_of_praktiki1.Id = 1;
            place_of_praktiki1.name = "Подразделение АО УМПО Кабинет 307";
            place_of_praktiki1.organizacia_Id = 1;
            place_of_praktiki1.period_praktiki_Id = 1;
            place_of_praktiki1.vmestimost = 30;
            place_of_praktiki1.profile_rabot = "Разработка ПО";
            Console.WriteLine($" Название места практики {place_of_praktiki1.name}, ID места практики - {place_of_praktiki1.Id},Профиль работ места практики - {place_of_praktiki1.profile_rabot}, Вместимость - {place_of_praktiki1.vmestimost}, ID Организации - {place_of_praktiki1.organizacia_Id}");
            
            //8
            Otchet Otchet1 = new Otchet();
            Otchet1.Id = 1;
            Otchet1.napravlenie_Id = 1;
            Otchet1.data_sdachi = new DateOnly(2026, 04, 28);
            Otchet1.result_proverki = "принят";
            Otchet1.mark = 5 ;
            Console.WriteLine($" ID - {Otchet1.Id}, дата сдачи - {Otchet1.data_sdachi}, результат проверки - {Otchet1.result_proverki}, ID направления - {Otchet1.napravlenie_Id}, оценка - {Otchet1.mark} ");
        }
        

    }
}
    