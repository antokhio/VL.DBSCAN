using Stride.Core.Mathematics;

namespace VL.Dbscan
{
    /// <summary>
    /// Extension of TrackablePoint to support passing generics along with cluster
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class TrackablePointT<T> : TrackablePoint
    {
        private readonly T _value;
        /// <summary>
        /// Creates a GenericTrackablePoint from a Vector2 and T to be used with VL DBSCAN plugin
        /// </summary>
        /// <param name="vector"></param>
        /// <param name="value"></param>
        public TrackablePointT(Vector2 vector, T value) : base(vector) => _value = value;

        /// <summary>
        /// Gets T from GenericTrackablePoint
        /// </summary>
        /// <param name="point"></param>
        /// <returns></returns>
        public static T GetValue(TrackablePointT<T> point) => point._value;
    }
}
