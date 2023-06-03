using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace check_in_for_the_flight_system
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sectors = new int[5] { 6, 15, 30, 15, 6 };
            int userPointSelect;
            int userSectorSelect;
            int userPlacesInSectorSelect;
            bool isOpen = true;

            while(isOpen)
            {

                Console.SetCursorPosition(0, 24);

                for (int i = 0; i < sectors.Length; i++)
                {
                    Console.WriteLine($"В секторе {(i + 1)} кол-во мест {sectors[i]}");
                }


                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Система регистрации пассажиров на рейс");
                Console.WriteLine("\n\n1 - Зарегистрировать пассажира\n\n2 - Информация о разработчике\n\n3 - Выйти из программы");
                Console.Write("\n\nПожалуйста, выберите действие: ");
                userPointSelect = Convert.ToInt32(Console.ReadLine());

                switch(userPointSelect)
                {
                    case 1:
                        Console.Write("Пожалуйста, выберите сектор: ");
                        userSectorSelect = Convert.ToInt32(Console.ReadLine()) - 1;
                        if (userSectorSelect > sectors.Length || userSectorSelect < 0)
                        {
                            Console.WriteLine("Выбран несуществующий сектор");
                            break;
                        }
                        Console.Write("Пожалуйста, выберите кол-во мест для бронирования: ");
                        userPlacesInSectorSelect = Convert.ToInt32(Console.ReadLine());
                        if (userPlacesInSectorSelect > sectors[userSectorSelect])
                        {
                            Console.WriteLine("Недостаточно мест в выбранном секторе");
                            break;
                        }
                        if (userPlacesInSectorSelect <= 0)
                        {
                            Console.WriteLine("Введено некорректное кол-во мест");
                            break;
                        }
                        sectors[userSectorSelect] -= userPlacesInSectorSelect;
                        Console.WriteLine($"Бронирование прошло успешно!");
                        break;
                    case 2:
                        Console.WriteLine("Vk: https://vk.com/sidorikv");
                        break;
                    case 3:
                        isOpen = false;
                        break;
                    default:
                        Console.WriteLine("Введена неверная команда");
                        break;
                }

                Console.ReadKey();
                Console.Clear();

            }
        }
    }
}
