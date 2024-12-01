using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Liskov_Substitution_Principle
{
    /*
     * Принцип подстановки Барбары Лисков (Liskov Substitution Principle, LSP)
     * Функции, которые используют ссылки на базовые классы, должны иметь возможность 
     * использовать объекты производных классов, не зная об этом.
     */
    class Program
    {
        public static void TestClient(IRectangle rectangle)
        {
            // Функция не должна ничего знать об объекте производного класса
            // Необходимо свободно использовать абстракцию в коде без лишних проверок на тип. 
            // Использование операторов is и as должно быть очень веско обосновано, 
            // т.к. чаще всего они являются первыми признаками нарушения LSP.
            rectangle.Width = 3;
            rectangle.Height = 5;
            // начало "костыля"
            if(rectangle is Square)
                Assert.AreEqual(25, rectangle.GetRectangleArea());
            else 
                Assert.AreEqual(15, rectangle.GetRectangleArea());
            // конец "костыля"
            Console.WriteLine("Ok!");
            // Есть 2 варианта исправить ситуацию:
            // 1. Rectange и Square будут совсем разными типами
            // 2. Square агрегирует объект типа Rectangle.
            // С переопределением поведения базового типа нужно быть очень аккуратным!
        }

        static void Main(string[] args)
        {
            TestClient(new Rectangle());
            TestClient(new Square());
        }
    }
}
