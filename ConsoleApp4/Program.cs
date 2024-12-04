using System;
using BouquetFactoryLibrary;

namespace BouquetFactoryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Оберіть тип букета: Весілля, День Народження, Романтика");
            string вибір = Console.ReadLine()?.Trim();

            БукетФабрика фабрика;

            try
            {
                фабрика = вибір switch
                {
                    "Весілля" => new ФабрикаДляВесілля(),
                    "День Народження" => new ФабрикаДляДняНародження(),
                    "Романтика" => new ФабрикаДляРомантики(),
                    _ => throw new ArgumentException("Невідомий вибір. Будь ласка, оберіть 'Весілля', 'День Народження' або 'Романтика'.")
                };

                var букет = фабрика.СтворитиБукет();
                букет.Підготувати();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка: {ex.Message}");
            }
        }
    }
}
