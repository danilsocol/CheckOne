using System;
using System.Collections.Generic;
using System.Text;

namespace Интер
{
    class DataWork
    {
        public static void SelectOperation(string[] partsStr) 
        {
            for (int j = 0; j < Data.peremenna.Count; j++)            
            {
                if (Data.peremenna[j] + "," == partsStr[1])  
                {
                    bool swit = true; 

                    for (int k = 0; k < Data.peremenna.Count; k++) 
                    {
                        if (Data.peremenna[k] == partsStr[2]) 
                        {
                            Data.inch[j] = Calculations(Data.inch[j], Data.inch[k]);
                            swit = false; 
                            break;
                        }
                    }
                    if (swit) 
                    {
                        Data.inch[j] = Calculations(Data.inch[j], Convert.ToInt32(partsStr[2])); 
                        break;
                    }
                }
            }
        }

        public static int Calculations(int numOne, int numTwo)
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

                default: 
                    return -1;
            }
        }


    }
}