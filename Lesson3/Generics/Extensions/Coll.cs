using System;
using System.Linq;
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
        /// Get the value from collection by key if exists or get default
        /// </summary>
        /// <typeparam name="TKey">The type of key</typeparam>
        /// <typeparam name="TValue">The type of value</typeparam>
        /// <param name="dictionary">The target collection</param>
        /// <param name="key">The key</param>
        /// <param name="defaultValue">The default value</param>
        public static TValue GetOrDefault<TKey, TValue>(this Dictionary<TKey, TValue> dictionary, TKey key, TValue defaultValue = default)
        {
            // try get existing value
            if (dictionary.TryGetValue(key, out var existing))
            {
                return existing;
            }

            return defaultValue;
        }

        /// <summary>
        /// Get the value from collection by key if exists or get null
        /// </summary>
        /// <typeparam name="TKey">The type of key</typeparam>
        /// <typeparam name="TValue">The type of value</typeparam>
        /// <param name="dictionary">The target collection</param>
        /// <param name="key">The key</param>
        public static TValue GetOrNull<TKey, TValue>(this Dictionary<TKey, TValue> dictionary, TKey key) where TValue : class
        {
            return GetOrDefault(dictionary, key, null);
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
        /// Traverse all the elements of given dictionary
        /// </summary>
        /// <typeparam name="TKey">The type of key</typeparam>
        /// <typeparam name="TValue">The type of value</typeparam>
        /// <param name="dictionary">The target collection</param>
        /// <param name="action">The action to apply</param>
        public static void ForEach<TKey, TValue>(this Dictionary<TKey, TValue> dictionary, Action<KeyValuePair<TKey, TValue>> action)
        {
            // safety check
            if (action == null || dictionary == null)
            {
                return;
            }

            // for each key value pair 
            foreach (var kv in dictionary)
            {
                action.Invoke(kv);
            }
        }

        /// <summary>
        /// Traverse all the elements of given collection
        /// </summary>
        /// <typeparam name="TValue">The type of value</typeparam>
        /// <param name="collection">The target collection</param>
        /// <param name="action">The action to apply</param>
        public static void Each<TValue>(this IEnumerable<TValue> collection, Action<TValue> action)
        {
            // safety check
            if (action == null || collection == null)
            {
                return;
            }

            // for each key value pair 
            foreach (var item in collection)
            {
                action.Invoke(item);
            }
        }

        /// <summary>
        /// Add to value collection by key
        /// </summary>
        /// <typeparam name="TKey">The type of key</typeparam>
        /// <typeparam name="TValue">The type of value</typeparam>
        /// <param name="dictionary">The target collection</param>
        /// <param name="key">The key</param>
        /// <param name="value">The value</param>
        public static void AddValue<TKey, TValue>(this Dictionary<TKey, IList<TValue>> dictionary, TKey key, TValue value)
        {
            // if collection exists add and finish
            if (dictionary.TryGetValue(key, out var collection))
            {
                collection.Add(value);
                return;
            }

            // if no collection yet create it
            dictionary.Add(key, new List<TValue> { value });
        }

        /// <summary>
        /// Check if value is in collection by key
        /// </summary>
        /// <typeparam name="TKey">The type of key</typeparam>
        /// <typeparam name="TValue">The type of value</typeparam>
        /// <param name="dictionary">The target collection</param>
        /// <param name="key">The key</param>
        /// <param name="value">The value</param>
        public static bool ContainsValue<TKey, TValue>(this Dictionary<TKey, IList<TValue>> dictionary, TKey key, TValue value)
        {
            // check if collection present and item is in collection
            return dictionary.TryGetValue(key, out var collection) && collection.Contains(value);
        }

        /// <summary>
        /// Add to value collection by key
        /// </summary>
        /// <typeparam name="TKey">The type of key</typeparam>
        /// <typeparam name="TValue">The type of value</typeparam>
        /// <param name="dictionary">The target collection</param>
        /// <param name="key">The key</param>
        /// <param name="value">The value</param>
        public static void AddValue<TKey, TValue>(this Dictionary<TKey, ISet<TValue>> dictionary, TKey key, TValue value)
        {
            // if collection exists add and finish
            if (dictionary.TryGetValue(key, out var collection))
            {
                collection.Add(value);
                return;
            }

            // if no collection yet create it
            dictionary.Add(key, new HashSet<TValue> { value });
        }

        /// <summary>
        /// Check if value is in collection by key
        /// </summary>
        /// <typeparam name="TKey">The type of key</typeparam>
        /// <typeparam name="TValue">The type of value</typeparam>
        /// <param name="dictionary">The target collection</param>
        /// <param name="key">The key</param>
        /// <param name="value">The value</param>
        public static bool ContainsValue<TKey, TValue>(this Dictionary<TKey, ISet<TValue>> dictionary, TKey key, TValue value)
        {
            // check if collection present and item is in collection
            return dictionary.TryGetValue(key, out var collection) && collection.Contains(value);
        }

        /// <summary>
        /// Flattens sequence of sequences of the same element type
        /// </summary>
        /// <typeparam name="T">The element type</typeparam>
        /// <param name="enumerables">The sequence of sequences</param>
        /// <returns></returns>
        public static IEnumerable<T> Flatten<T>(this IEnumerable<IEnumerable<T>> enumerables)
        {
            return enumerables.Aggregate((first, second) => first.Concat(second));
        }

        /// <summary>
        /// Add range of elements to given collection
        /// </summary>
        /// <typeparam name="T">The element type</typeparam>
        /// <param name="collection">The target collection</param>
        /// <param name="items">The items to add</param>
        /// <returns></returns>
        public static void AddRange<T>(this ICollection<T> collection, IEnumerable<T> items)
        {
            foreach (var item in items)
            {
                collection.Add(item);
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

        /// <summary>
        /// Checks if collection is null or empty
        /// </summary>
        /// <typeparam name="TValue">The type of value</typeparam>
        /// <param name="collection">The collection to check</param>
        /// <returns></returns>
        public static bool NoItems<TValue>(this IEnumerable<TValue> collection)
        {
            if (collection == null)
            {
                return true;
            }

            if (collection.TryCast<ICollection<TValue>>(out var coll))
            {
                return coll.Count == 0;
            }

            return !collection.Any();
        }       
    }
}
