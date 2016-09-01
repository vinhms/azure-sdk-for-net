// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using System.Linq;

    /// <summary>
    /// Specifies how tasks should be distributed across compute nodes.
    /// </summary>
    public partial class TaskSchedulingPolicy
    {
        /// <summary>
        /// Initializes a new instance of the TaskSchedulingPolicy class.
        /// </summary>
        public TaskSchedulingPolicy() { }

        /// <summary>
        /// Initializes a new instance of the TaskSchedulingPolicy class.
        /// </summary>
        /// <param name="nodeFillType">How tasks should be distributed across
        /// compute nodes</param>
        public TaskSchedulingPolicy(ComputeNodeFillType nodeFillType)
        {
            NodeFillType = nodeFillType;
        }

        /// <summary>
        /// Gets or sets how tasks should be distributed across compute nodes
        /// </summary>
        /// <remarks>
        /// Possible values include: 'spread', 'pack', 'unmapped'
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "nodeFillType")]
        public ComputeNodeFillType NodeFillType { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}
