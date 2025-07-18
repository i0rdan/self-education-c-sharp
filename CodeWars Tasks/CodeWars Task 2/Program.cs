public static class Kata2
{
    public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
    {
        var listWithUniqueOrderItems = new List<T>();

        foreach (var item in iterable)
        {
            if (listWithUniqueOrderItems.Count == 0)
            {
                listWithUniqueOrderItems.Add(item);

                continue;
            }

            if (!listWithUniqueOrderItems.Last()!.Equals(item))
            {
                listWithUniqueOrderItems.Add(item);
            }
        }

        return listWithUniqueOrderItems;
    }
}
