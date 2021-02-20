using System;
using System.Collections.Generic;
using System.Text;

namespace Интер
{
    class Program 
    {
        static void Main(string[] args)
        {
            string[] code = WriteAndRead.Read(); 

            Сontrol(code); 
        }
        static void Сontrol(string[] code) 
        {
            for (int i = 0; i < code.Length; i++) 
            {
                string[] partsStr = code[i].Split(new char[] { ' ' }); 

                switch (partsStr[0]) 
                {

                    case "var": 
                        Data.peremenna.Add(partsStr[1]);
                        break;

                    case "mov":  
                        for (int j = 0; j < Data.peremenna.Count; j++)
                        {
                            if (Data.peremenna[j] == partsStr[2])  
                            {
                                Data.inch.Add(Data.inch[j]); 
                                break;
                            }
                            if (j == Data.peremenna.Count - 1) 
                            {
                                Data.inch.Add(Convert.ToInt32(partsStr[2])); 
                            }
                        }
                        break;

                    case "add": 
                        Data.numOperation = 1;
                        DataWork.SelectOperation(partsStr); 
                        break;

                    case "sub": 
                        Data.numOperation = 2;
                        DataWork.SelectOperation(partsStr); 
                        break;

                    case "div":  
                        Data.numOperation = 3;
                        DataWork.SelectOperation(partsStr); 
                        break;

                    case "mul": 
                        Data.numOperation = 4;
                        DataWork.SelectOperation(partsStr); 
                        break;

                    default:
                        WriteAndRead.Write(); 
                        break;
                }
            }
        }
    }
}