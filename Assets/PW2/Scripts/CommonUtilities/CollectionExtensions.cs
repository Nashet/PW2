using System.Collections.Generic;

namespace PW2.Scripts.CommonUtilities
{
    public static class CollectionExtensions
    {
        public static T Random<T>(this IList<T> list)
        {
            return list[MyRandom.GetInt(list.Count)];
        }
    }
}