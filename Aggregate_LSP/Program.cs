namespace Aggregate_LSP
{
    /*
     * Принцип подстановки Барбары Лисков (Liskov Substitution Principle, LSP)
     * Функции, которые используют ссылки на базовые классы, должны иметь возможность 
     * использовать объекты производных классов, не зная об этом.
     */
    class Program
    {
        public static void TestClient(IAggregate aggregate)
        {
            // Функция не должна ничего знать об объекте производного класса
            // Необходимо свободно использовать абстракцию в коде без лишних проверок на тип. 
            // Использование оператора as  is  должно быть очень веско обосновано, 
            // т.к. чаще всего они являются первыми признаками нарушения LSP.

            // начало "костыля"
            if (aggregate as AggregateCPP != null)
            {
                aggregate[0] = 10;
                Console.WriteLine(aggregate[0]);
            }
            else if (aggregate as AggregatePascal != null)
            {
                aggregate[1] = 10;
                Console.WriteLine(aggregate[1]);
            }
            // конец "костыля"

        }

        static void Main(string[] args)
        {
            AggregateCPP aggrCPP = new AggregateCPP(10);
            TestClient(aggrCPP);
            AggregatePascal aggrPascal = new AggregatePascal(10);
            TestClient(aggrPascal);
        }
    }
}
