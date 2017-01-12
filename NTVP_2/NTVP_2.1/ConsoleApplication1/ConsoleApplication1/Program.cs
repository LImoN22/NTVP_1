using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using System.ComponentModel.DataAnnotations;

namespace ConsoleApplication1
{
    class Program
    {
        public static void Main(string[] args)
        {
 
   //менюшка
         int m;
         m = 0;
              do
                {
                    Console.WriteLine("TIME TO CHOOSE:");
                    Console.WriteLine("  1. Индуктивное сопротивление");
                    Console.WriteLine("  2. Ёмкостное сопротивление");
                    Console.WriteLine("  3. Резистивное сопротивление");
                    Console.WriteLine("  4. выход");
                    string i = Console.ReadLine();
                     
                     try 
                     {
                      m = Convert.ToInt32(i);
                     }
                
                    catch(FormatException)  
                    {
                      Console.WriteLine("Fail to input , try more");
                    }


                  if (m == 4) 
                      break;

                   Console.WriteLine("\n");

                   switch (m)
                      {
                            // расчёт катушки
                          case 1:
                                InductionMethod();  
                           break;
                            // расчёт конденсатора 
                            case 2:
                                CapasityMethod();
                             break ; 
                            // расчёт сопротивления
                            case 3:
                                 ResistanceMethod();
                             break ; 
                      }
                  
                        Console.Write("\n\t\tНажмите любую клавишу...\n");
                        Console.ReadLine();
                        Console.Clear();
                }
                while (m != 4);
                
            }


        public static void InductionMethod()
        {
            double frequencyCheckResult;
            frequencyCheckResult = 0;
            double inductionCheckResult;
            inductionCheckResult = 0; 

            // ввод частоты   
           bool result_f = false;
           while (!result_f)
            {
               Console.WriteLine("Введите F (гц):\n");
               string frequencyValue = Console.ReadLine();
               result_f = double.TryParse(frequencyValue, out frequencyCheckResult);

                if (result_f)
                {

                   Console.WriteLine("Converted '{0}' to {1}.", frequencyValue, frequencyCheckResult);
                }
                else
                {

                    Console.WriteLine("Attempted ->'{0}' failed.",
                   frequencyValue == null ? "<null>" : frequencyValue);
                }
            }

            // Ввод индуктивности
            bool result_l = false;
            while (!result_l)
            {
               Console.WriteLine("Введите L (мкГн) :\n");
               string inductionValue = Console.ReadLine();
               result_l = double.TryParse(inductionValue, out inductionCheckResult);

               if (result_l)
                {

                    Console.WriteLine("Converted '{0}' to {1}.", inductionValue, inductionCheckResult);
                }
               else
                {

                    Console.WriteLine("Attempted ->'{0}' failed.",
                    inductionValue == null ? "<null>" : inductionValue);
                }
            }

            InductResCalc Object_InductResCalc = new InductResCalc(frequencyCheckResult, inductionCheckResult);
            Console.WriteLine("Индуктивное сопротивление = {0}", Object_InductResCalc.ResistanceCalculation);
            
        }

        public static void CapasityMethod()
        {
            double frequencyCheckResult;
            frequencyCheckResult = 0;
            double capacityCheckResult;
            capacityCheckResult = 0;
            bool result_f = false;
            while (!result_f)
            {
                // ввод частоты 
                Console.WriteLine("Введите F (гц):\n");
                string frequencyValue = Console.ReadLine();
                result_f = double.TryParse(frequencyValue, out frequencyCheckResult);

                if (result_f)
                {

                    Console.WriteLine("Converted '{0}' to {1}.", frequencyValue, frequencyCheckResult);
                }
                else
                {

                    Console.WriteLine("Attempted ->'{0}' failed.",
                   frequencyValue == null ? "<null>" : frequencyValue);
                }
            }

            bool result_c = false;
            while (!result_c)
            {
                // ввод ёмкости 
                Console.WriteLine("Введите C (мкФ) :\n");
                string capacityValue = Console.ReadLine();
                result_c = double.TryParse(capacityValue, out capacityCheckResult);

                if (result_c)
                {

                    Console.WriteLine("Converted '{0}' to {1}.", capacityValue, capacityCheckResult);
                }
                else
                {

                    Console.WriteLine("Attempted ->'{0}' failed.",
                   capacityValue == null ? "<null>" : capacityValue);
                }
            }

            CapacityResCalc Object_CapacityResCalc = new CapacityResCalc(frequencyCheckResult, capacityCheckResult);
            Console.WriteLine("Ёмкостное сопротивление = {0}", Object_CapacityResCalc.ResistanceCalculation);
            
        }

        public static void ResistanceMethod()
        {
            double resistanceCheckResult;
            resistanceCheckResult = 0; 
            bool result_r = false;
            while (!result_r)
            {
                Console.WriteLine("Введите R (Oм):\n");
                string resistanceValue = Console.ReadLine();
                result_r = double.TryParse(resistanceValue, out resistanceCheckResult);

                if (result_r)
                {

                    Console.WriteLine("Converted '{0}' to {1}.", resistanceValue, resistanceCheckResult);
                }
                else
                {

                    Console.WriteLine("Attempted ->'{0}' failed.",
                   resistanceValue == null ? "<null>" : resistanceValue);
                }
            }

            ResistanceResCalc Object_ResistanceResCalc = new ResistanceResCalc(resistanceCheckResult);
            Console.WriteLine("Резистивность = {0}", Object_ResistanceResCalc.ResistanceCalculation);
        }

    }
}

