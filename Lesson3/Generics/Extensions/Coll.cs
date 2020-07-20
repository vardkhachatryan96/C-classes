using System.Collections.Generic;

namespace UC.Common.Extend
{
    /// <summary>
    /// The extended methods for collections
    /// </summary>
    public static class Coll
    {
        /// <summary>
        /// Put the value inside collection by key (replace if exists)
        /// </summary>
        /// <typeparam name="TKey">The type of key</typeparam>
        /// <typeparam name="TValue">The type of value</typeparam>
        /// <param name="dictionary">The target collection</param>
        /// <param name="key">The key</param>
        /// <param name="value">The value</param>
        public static void Put<TKey, TValue>(this Dictionary<TKey, TValue> dictionary, TKey key, TValue value)
        {
            // if value is already there, just replace
            if (dictionary.ContainsKey(key))
            {
                dictionary[key] = value;
                return;
            }

            // if key is not defined yet, add new value
            dictionary.Add(key, value);
        }

        /// <summary>
        /// Put all the values inside collection by key (replace if exists)
        /// </summary>
        /// <typeparam name="TKey">The type of key</typeparam>
        /// <typeparam name="TValue">The type of value</typeparam>
        /// <param name="dictionary">The target collection</param>
        /// <param name="other">The other collection</param>
        public static void PutRange<TKey, TValue>(this Dictionary<TKey, TValue> dictionary, Dictionary<TKey, TValue> other)
        {
            // safety check
            if (other == null || other.Count == 0)
            {
                return;
            }

            // for each key value pair 
            foreach (var kv in other)
            {
                Put(dictionary, kv.Key, kv.Value);
            }
        }

        /// <summary>
        /// Checks if collection has items
        /// </summary>
        /// <typeparam name="TValue">The type of value</typeparam>
        /// <param name="collection">The collection to check</param>
        /// <returns></returns>
        public static bool HasItems<TValue>(this ICollection<TValue> collection)
        {
            return collection != null && collection.Count > 0;
        }

        /// <summary>
        /// Checks if collection is null or empty
        /// </summary>
        /// <typeparam name="TValue">The type of value</typeparam>
        /// <param name="collection">The collection to check</param>
        /// <returns></returns>
        public static bool NoItems<TValue>(this ICollection<TValue> collection)
        {
            return collection == null || collection.Count == 0;
        }
    }
}
