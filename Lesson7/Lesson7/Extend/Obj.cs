namespace Lesson7.Extend
{
    public static class Obj
    {
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
    }
}
