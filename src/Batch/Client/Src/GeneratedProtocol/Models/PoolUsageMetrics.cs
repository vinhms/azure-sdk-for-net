// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using System.Linq;

    /// <summary>
    /// Usage metrics for a pool across an aggregation interval.
    /// </summary>
    public partial class PoolUsageMetrics
    {
        /// <summary>
        /// Initializes a new instance of the PoolUsageMetrics class.
        /// </summary>
        public PoolUsageMetrics() { }

        /// <summary>
        /// Initializes a new instance of the PoolUsageMetrics class.
        /// </summary>
        /// <param name="poolId">The id of the pool whose metrics are being
        /// aggregated.</param>
        /// <param name="startTime">The start time of the aggregation
        /// interval.</param>
        /// <param name="endTime">The end time of the aggregation
        /// interval.</param>
        /// <param name="vmSize">The size of virtual machines in the pool. All
        /// VMs in a pool are the same size.</param>
        /// <param name="totalCoreHours">The total core hours used in the pool
        /// during this aggregation interval.</param>
        /// <param name="dataIngressGiB">The cross data center network ingress
        /// in GiB to the pool during this interval.</param>
        /// <param name="dataEgressGiB">The cross data center network egress
        /// in GiB from the pool during this interval.</param>
        public PoolUsageMetrics(string poolId, System.DateTime startTime, System.DateTime endTime, string vmSize, double totalCoreHours, double dataIngressGiB, double dataEgressGiB)
        {
            PoolId = poolId;
            StartTime = startTime;
            EndTime = endTime;
            VmSize = vmSize;
            TotalCoreHours = totalCoreHours;
            DataIngressGiB = dataIngressGiB;
            DataEgressGiB = dataEgressGiB;
        }

        /// <summary>
        /// Gets or sets the id of the pool whose metrics are being aggregated.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "poolId")]
        public string PoolId { get; set; }

        /// <summary>
        /// Gets or sets the start time of the aggregation interval.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "startTime")]
        public System.DateTime StartTime { get; set; }

        /// <summary>
        /// Gets or sets the end time of the aggregation interval.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "endTime")]
        public System.DateTime EndTime { get; set; }

        /// <summary>
        /// Gets or sets the size of virtual machines in the pool. All VMs in
        /// a pool are the same size.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "vmSize")]
        public string VmSize { get; set; }

        /// <summary>
        /// Gets or sets the total core hours used in the pool during this
        /// aggregation interval.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "totalCoreHours")]
        public double TotalCoreHours { get; set; }

        /// <summary>
        /// Gets or sets the cross data center network ingress in GiB to the
        /// pool during this interval.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "dataIngressGiB")]
        public double DataIngressGiB { get; set; }

        /// <summary>
        /// Gets or sets the cross data center network egress in GiB from the
        /// pool during this interval.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "dataEgressGiB")]
        public double DataEgressGiB { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (PoolId == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "PoolId");
            }
            if (VmSize == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "VmSize");
            }
        }
    }
}
