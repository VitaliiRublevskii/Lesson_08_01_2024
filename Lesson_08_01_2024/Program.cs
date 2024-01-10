

using Lesson_08_01_2024;
//string path = "myFile.txt";
string path = "";


Console.Write(  "Выберите путь для сохранеия файла (1 - по умолчанию, 2 - пользовательский):  ");
int choice  = int.Parse(Console.ReadLine());
bool ch = true;



switch (choice)
{
    case 1:
        path = "myFile.txt";
        Console.WriteLine($" Файл сохранен по адресу : E:\\IT_STEP\\C#\\Lesson_08_01_2024\\Lesson_08_01_2024\\bin\\Debug\\net6.0\\myFile.txt"  );
        ch = false;
        using (Logger logger = new Logger())
        {
            logger.Start(path);
        }
        break;

    case 2:
        while (ch)
        {
            
            try
            {
                Console.Write("Введите путь : ");
                path = Console.ReadLine();
                if (path.Length > 0)
                {
                   ch = false;
                   Console.WriteLine(  " Адрес принят ");
                    using (Logger logger = new Logger())
                    {
                        logger.Start(path);
                    }
                }
                else
                {
                    throw new MyExc();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }

                
        }
        break;



}









/*
3) Предусмотреть ввод пользователем пути сохранения лог-файла /
Предоставить удобное меню с выбором вариантов по пути (или стандартный или пользовательский) при старте ПО

4) Разбить проект на 2 логгера в отдельных пространствах имен ( по пути)
 */
