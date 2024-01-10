using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_08_01_2024
{
    internal class MyExc : Exception
    {
        public MyExc(): base("Не указан путь файла !!!") { }
    }
}
