using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace llc_decorations
{
    internal class UserData
    {
        public static int Id { get; set; }
        public static string Surname { get; set; }
        public static string Name { get; set; }
        public static string Patronymic { get; set; }
        public static int RoleID { get; set; }

        // 1 - Клиент
        // 2 - Менеджер
        // 3 - Администратор
        // 4 - Гость
    }
}
