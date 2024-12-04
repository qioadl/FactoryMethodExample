using System;
using System.Collections.Generic;

namespace BouquetFactoryLibrary
{
    // Продукт (Abstract Product)
    public abstract class Букет
    {
        public string Назва { get; set; }
        public List<string> Квіти { get; set; } = new List<string>();

        public abstract void Підготувати();
    }

    // Реальні продукти
    public class БукетДляВесілля : Букет
    {
        public БукетДляВесілля()
        {
            Назва = "Весільний букет";
        }

        public override void Підготувати()
        {
            Квіти.Add("Троянди");
            Квіти.Add("Лілії");
            Console.WriteLine($"Підготовка {Назва}:");
            Console.WriteLine(string.Join(", ", Квіти));
        }
    }

    public class БукетДляДняНародження : Букет
    {
        public БукетДляДняНародження()
        {
            Назва = "Букет для дня народження";
        }

        public override void Підготувати()
        {
            Квіти.Add("Соняшники");
            Квіти.Add("Гербери");
            Console.WriteLine($"Підготовка {Назва}:");
            Console.WriteLine(string.Join(", ", Квіти));
        }
    }

    public class БукетДляРомантики : Букет
    {
        public БукетДляРомантики()
        {
            Назва = "Романтичний букет";
        }

        public override void Підготувати()
        {
            Квіти.Add("Червоні троянди");
            Квіти.Add("Орхідеї");
            Console.WriteLine($"Підготовка {Назва}:");
            Console.WriteLine(string.Join(", ", Квіти));
        }
    }

    // Фабрика (Creator)
    public abstract class БукетФабрика
    {
        public abstract Букет СтворитиБукет();
    }

    public class ФабрикаДляВесілля : БукетФабрика
    {
        public override Букет СтворитиБукет()
        {
            return new БукетДляВесілля();
        }
    }

    public class ФабрикаДляДняНародження : БукетФабрика
    {
        public override Букет СтворитиБукет()
        {
            return new БукетДляДняНародження();
        }
    }

    public class ФабрикаДляРомантики : БукетФабрика
    {
        public override Букет СтворитиБукет()
        {
            return new БукетДляРомантики();
        }
    }
}
