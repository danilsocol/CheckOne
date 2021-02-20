using System;
using System.Collections.Generic;
using System.Text;

namespace Интер
{
    class DataWork
    {
        public static void SelectOperation(string[] partsStr) // смотрим что над чем проимходят операции, переменная и переменная или переменная и число
        {
            for (int j = 0; j < Data.peremenna.Count; j++) //проверяем есть ли такая переменная в листе  
            {
                if (Data.peremenna[j] + "," == partsStr[1]) // если есть такая переменная если да то
                {
                    bool swit = true; // проверка будет ли операция вида: переменная и переменная

                    for (int k = 0; k < Data.peremenna.Count; k++) // проверяем вид операции : переменная и переменная
                    {
                        if (Data.peremenna[k] == partsStr[2]) // если ли вторая переменная в списке
                        {
                            Data.inch[j] = Calculations(Data.inch[j], Data.inch[k]);// отправляемся в метод где будем производить операции
                            swit = false; // если это переция вида : переменная и переменная , то переключаем swit, чтоб код не взял название переменной как значение 
                            break;
                        }
                    }
                    if (swit) // если это тип переменная и число то с 17 до 25 строчку то код не проводит никаких операций
                    {
                        Data.inch[j] = Calculations(Data.inch[j], Convert.ToInt32(partsStr[2])); // отправляемся в метод где будем производить операции 
                        break;
                    }
                }
            }
        }

        public static int Calculations(int numOne, int numTwo)// переменная где будут происходить операции
        {
            switch (Data.numOperation)
            {
                case (1):
                    return numOne + numTwo;

                case (2):
                    return numOne - numTwo;

                case (3):
                    return numOne / numTwo;

                case (4):
                    return numOne * numTwo;

                default: // если нет операций выдаем ошибочное число чтоб программа сдохла
                    return -1;
            }
        }


    }
}