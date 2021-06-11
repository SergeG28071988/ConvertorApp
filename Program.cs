using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertorApp
{
    #region Конвертор
    /* 
     * Напишем простой конвертор валют
     * (без возможности динамического выбора валюты пользователем).
     * Валюты заданы хардкодом и не изменются. Тип валют на выбор программиста. 
     */
    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            double UsdToRub = 71.74;
            double EurToRub = 87;
            double UsdToUah = 27.11 ;
            double USD;
            double EUR;

            Console.WriteLine("Введите сумму в USD: ");
            USD = double.Parse(Console.ReadLine());

            Console.WriteLine(USD + " USD в RUB = " + USD * UsdToRub);
            Console.WriteLine(USD + " USD в UAH = " + USD * UsdToUah);

            Console.WriteLine("Введите сумму в EUR: ");
            EUR = double.Parse(Console.ReadLine());

            Console.WriteLine(EUR + " EUR в RUB = " + EUR * EurToRub);

            Console.ReadKey();
        }
    }
}
