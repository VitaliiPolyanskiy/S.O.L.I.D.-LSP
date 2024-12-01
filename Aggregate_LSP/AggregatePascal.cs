namespace Aggregate_LSP
{
    class AggregatePascal : IAggregate
    {
        List<int> list = new List<int>();

        public AggregatePascal(int size)
        {
            for (int i = 0; i < size; i++)
            {
                list.Add(i);
            }
        }
        public int GetCount()
        {
            return list.Count();
        }
        public int this[int index]
        {
            get
            {
                if (index >= 1 && index <= list.Count())
                {
                    return list[index - 1];
                }
                else
                {
                    throw new Exception("\nНекорректный индекс! " + index);
                }
            }
            set
            {
                if (index >= 1 && index <= list.Count())
                {
                    list[index - 1] = value;
                }
                else
                {
                    throw new Exception("\nНекорректный индекс! " + index);
                }
            }
        }
    }
}
