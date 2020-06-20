using Force.DeepCloner;

namespace UC.Common.Extend
{
    /// <summary>
    /// Set of extension methods for objects in general
    /// </summary>
    public static class Obj
    {
        /// <summary>
        /// Try cast given object to a given type
        /// </summary>
        /// <typeparam name="T">The target type</typeparam>
        /// <param name="source">The object to cast</param>
        /// <param name="result">[out] The result of cast</param>
        /// <returns>True if cast is successful</returns>
        public static bool TryCast<T>(this object source, out T result) where T : class
        {
            // default value
            result = default;

            // if not of type T
            if(!(source is T))
            {
                return false;
            }

            // cast 
            result = (T) source;

            // successful
            return true;
        }

        /// <summary>
        /// Cast value to the given type
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value"></param>
        /// <returns></returns>
        public static T As<T>(this object value)
        {
            if (!(value is T))
            {
                return default;
            }

            // cast
            return (T)value;
        }

        /// <summary>
        /// Check value is of type T
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool Is<T>(this object value)
        {
            return value is T;
        }

        /// <summary>
        /// Check value is not of type T
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsNot<T>(this object value)
        {
            return !Is<T>(value);
        }

        /// <summary>
        /// Deep clone object
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static T DeepCloneExt<T>(this T obj)
        {
            return obj.DeepClone();
        }
    }
}
