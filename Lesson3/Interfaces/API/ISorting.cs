namespace Interfaces.API
{
    /// <summary>
    /// The type of sorting modules
    /// </summary>
    public interface ISorting
    {
        /// <summary>
        /// The memory used while sorting
        /// </summary>
        long Memory { get; }

        /// <summary>
        /// The run time of algorithm
        /// </summary>
        long RunningTime { get; }

        /// <summary>
        /// Sorts input array
        /// </summary>
        /// <param name="inputArray">The input array to sort</param>
        /// <returns></returns>
        double[] Sort(double[] inputArray);
    }
}
