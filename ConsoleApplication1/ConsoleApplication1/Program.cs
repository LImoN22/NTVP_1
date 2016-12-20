using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using System.ComponentModel.DataAnnotations;


namespace ConsoleApplication1
{
   /* public class InnerValidation
    {
        [Required]
        [Range(0.00001, 99999999.99999999)]
        public double F_val { get; set; }
        [Required]
       [Range(0.00001 , 99999999.99999999)]
        public double L_val { get; set; }
    */                                                      // класс для ограничения диапазона, если будет не достаточно проверок
    //                                                         больше проверок богу проверок
        

 
    
    class Program
    {
        public static void Main(string[] args)
        {
            double FrequencyCheckResult;
            FrequencyCheckResult = 0;
            double InductionCheckResult;
            InductionCheckResult = 0; 
           double CapacityCheckResult;
           CapacityCheckResult = 0; 
           
  
   
            //for (; ; )
            //{
            int i;
                do
                {
                   
                    Console.WriteLine("TIME TO CHOOSE:");
                    Console.WriteLine("  1. Индуктивное сопротивление");
                    Console.WriteLine("  2. Ёмкостное сопротивление");
                    Console.WriteLine("  3. Резистивное сопротивление");
                    Console.WriteLine("  4. выход");
                    i = int.Parse(Console.ReadLine());
                    

                    if (i == 4) break;

                    Console.WriteLine("\n");

                    switch (i)
                    {

                            // расчёт катушки
          case 1:
                            
                            bool result_f = false;
                             while (!result_f)
                             {
                                 Console.WriteLine("Введите F (гц):\n");
                                 string FrequencyValue = Console.ReadLine();
                                 result_f = double.TryParse(FrequencyValue, out FrequencyCheckResult);

                                 if (result_f)
                                 {

                                     Console.WriteLine("Converted '{0}' to {1}.", FrequencyValue, FrequencyCheckResult);
                                  
                                     /*  // вызов класса проверки диапазона.
                                      * 
                                      * InnerValidation inner_1 = new InnerValidation { F_val = FrequencyCheckResult };
                                          var results_1 = new List<ValidationResult>();
                                          var context_1 = new ValidationContext(inner_1);
                                          if (!Validator.TryValidateObject(inner_1, context_1, results_1, true))              
                                          {
                                              foreach (var error in results_1)
                                              {
                                                  Console.WriteLine(error.ErrorMessage);
                                              }
                                          }
                                      */ 
                                 }
                                 else
                                 {

                                     Console.WriteLine("Attempted ->'{0}' failed.",
                                    FrequencyValue == null ? "<null>" : FrequencyValue);
                                 }
                             }
                              
                           
                             bool result_l = false;
                             while (!result_l)
                             {
                                 Console.WriteLine("Введите L (мкГн) :\n");
                                 string InductionValue = Console.ReadLine();
                                 result_l = double.TryParse(InductionValue, out InductionCheckResult);
                                 if (result_l)
                                 {

                                     Console.WriteLine("Converted '{0}' to {1}.", InductionValue, InductionCheckResult);
                                 }
                                 else
                                 {

                                     Console.WriteLine("Attempted ->'{0}' failed.",
                                    InductionValue == null ? "<null>" : InductionValue);
                                 }
                             }

                           /*     InnerValidation inner = new InnerValidation {L_val = InductionCheckResult};
                            var results = new List<ValidationResult>();
            var context = new ValidationContext(inner);
            if (!Validator.TryValidateObject(inner, context, results, true))               //снова вызов этого непонятного класса с диапазоном
                            * 
            {
                foreach (var error in results)
                { 
                    Console.WriteLine(error.ErrorMessage);
                }
            }
*/ 


            InductResCalc Object_InductResCalc = new InductResCalc(FrequencyCheckResult, InductionCheckResult);
            Console.WriteLine("Индуктивное сопротивление = {0}", Object_InductResCalc.Calculation);
            break; 



// расчёт конденсатора 
              case 2:
                             result_f = false;
                             while (!result_f)
                             {
                                 Console.WriteLine("Введите F (гц):\n");
                                 string FrequencyValue = Console.ReadLine();
                                 result_f = double.TryParse(FrequencyValue, out FrequencyCheckResult);

                                 if (result_f)
                                 {

                                     Console.WriteLine("Converted '{0}' to {1}.", FrequencyValue, FrequencyCheckResult);
                                 }
                                 else
                                 {

                                     Console.WriteLine("Attempted ->'{0}' failed.",
                                    FrequencyValue == null ? "<null>" : FrequencyValue);
                                 }
                             }

                             bool result_c = false;
                             while (!result_c)
                             {
                                 Console.WriteLine("Введите C (мкГн) :\n");
                                 string CapacityValue = Console.ReadLine();
                                 result_c = double.TryParse(CapacityValue, out CapacityCheckResult);
                                 if (result_c)
                                 {

                                     Console.WriteLine("Converted '{0}' to {1}.", CapacityValue, CapacityCheckResult);
                                 }
                                 else
                                 {

                                     Console.WriteLine("Attempted ->'{0}' failed.",
                                    CapacityValue == null ? "<null>" : CapacityValue);
                                 }
                             }

                             CapacityMath Object_CapacityResCalc = new CapacityMath(FrequencyCheckResult, CapacityCheckResult);
            Console.WriteLine("Ёмкостное сопротивление = {0}", Object_CapacityResCalc.Calculation);
            break;
                          
                        case 3:
                            Console.WriteLine("The for:\n");
                            Console.Write("for(init; condition; iteration)");
                            Console.WriteLine(" statement;");
                            break;
                        default:
                            Console.WriteLine("shiiiiet happens");
                            break;
                    }
                    Console.Write("\n\n\t\t\tНажмите любую клавишу...\n");
                    Console.ReadLine();
                    Console.Clear();
                }
                while (i != 4);
                
            }
        //}
        
    }
}

