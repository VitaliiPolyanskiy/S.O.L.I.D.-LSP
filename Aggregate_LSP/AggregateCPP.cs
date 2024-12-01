namespace Aggregate_LSP
{
    class AggregateCPP : IAggregate
    {
        List<int> list = new List<int>();

        public AggregateCPP(int size)
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
                if (index >= 0 && index < list.Count())
                {
                    return list[index];
                }
                else
                {
                    throw new Exception("\nНекорректный индекс! " + index);
                }
            }
            set
            {
                if (index >= 0 && index < list.Count())
                {
                    list[index] = value;
                }
                else
                {
                    throw new Exception("\nНекорректный индекс! " + index);
                }
            }
        }
    }
}

