// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using System.Linq;

    /// <summary>
    /// Specifies any dependencies of a task. Any task that is explicitly
    /// specified or within a dependency range must complete before the
    /// dependant task will be scheduled.
    /// </summary>
    public partial class TaskDependencies
    {
        /// <summary>
        /// Initializes a new instance of the TaskDependencies class.
        /// </summary>
        public TaskDependencies() { }

        /// <summary>
        /// Initializes a new instance of the TaskDependencies class.
        /// </summary>
        /// <param name="taskIds">The list of task ids that must complete
        /// before this task can be scheduled.</param>
        /// <param name="taskIdRanges">The list of task ranges that must
        /// complete before this task can be scheduled.</param>
        public TaskDependencies(System.Collections.Generic.IList<string> taskIds = default(System.Collections.Generic.IList<string>), System.Collections.Generic.IList<TaskIdRange> taskIdRanges = default(System.Collections.Generic.IList<TaskIdRange>))
        {
            TaskIds = taskIds;
            TaskIdRanges = taskIdRanges;
        }

        /// <summary>
        /// Gets or sets the list of task ids that must complete before this
        /// task can be scheduled.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "taskIds")]
        public System.Collections.Generic.IList<string> TaskIds { get; set; }

        /// <summary>
        /// Gets or sets the list of task ranges that must complete before
        /// this task can be scheduled.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "taskIdRanges")]
        public System.Collections.Generic.IList<TaskIdRange> TaskIdRanges { get; set; }

    }
}
