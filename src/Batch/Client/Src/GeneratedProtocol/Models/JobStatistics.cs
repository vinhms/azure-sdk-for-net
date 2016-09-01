// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using System.Linq;

    /// <summary>
    /// Resource usage statistics for a job.
    /// </summary>
    public partial class JobStatistics
    {
        /// <summary>
        /// Initializes a new instance of the JobStatistics class.
        /// </summary>
        public JobStatistics() { }

        /// <summary>
        /// Initializes a new instance of the JobStatistics class.
        /// </summary>
        /// <param name="url">The URL of the statistics.</param>
        /// <param name="startTime">The start time of the time range covered
        /// by the statistics.</param>
        /// <param name="lastUpdateTime">The time at which the statistics were
        /// last updated. All statistics are limited to the range between
        /// startTime and lastUpdateTime.</param>
        /// <param name="userCPUTime">The total user mode CPU time (summed
        /// across all cores and all compute nodes) consumed by all tasks in
        /// the job.</param>
        /// <param name="kernelCPUTime">The total kernel mode CPU time (summed
        /// across all cores and all compute nodes) consumed by all tasks in
        /// the job.</param>
        /// <param name="wallClockTime">The total wall clock time of all tasks
        /// in the job.</param>
        /// <param name="readIOps">The total number of disk read operations
        /// made by all tasks in the job.</param>
        /// <param name="writeIOps">The total number of disk write operations
        /// made by all tasks in the job.</param>
        /// <param name="readIOGiB">The total gibibytes read from disk by all
        /// tasks in the job.</param>
        /// <param name="writeIOGiB">The total gibibytes written to disk by
        /// all tasks in the job.</param>
        /// <param name="numSucceededTasks">The total number of tasks
        /// successfully completed in the job during the given time
        /// range.</param>
        /// <param name="numFailedTasks">The total number of tasks in the job
        /// that failed during the given time range.</param>
        /// <param name="numTaskRetries">The total number of retries on all
        /// the tasks in the job during the given time range.</param>
        /// <param name="waitTime">The total wait time of all tasks in the
        /// job.</param>
        public JobStatistics(string url, System.DateTime startTime, System.DateTime lastUpdateTime, System.TimeSpan userCPUTime, System.TimeSpan kernelCPUTime, System.TimeSpan wallClockTime, long readIOps, long writeIOps, double readIOGiB, double writeIOGiB, long numSucceededTasks, long numFailedTasks, long numTaskRetries, System.TimeSpan waitTime)
        {
            Url = url;
            StartTime = startTime;
            LastUpdateTime = lastUpdateTime;
            UserCPUTime = userCPUTime;
            KernelCPUTime = kernelCPUTime;
            WallClockTime = wallClockTime;
            ReadIOps = readIOps;
            WriteIOps = writeIOps;
            ReadIOGiB = readIOGiB;
            WriteIOGiB = writeIOGiB;
            NumSucceededTasks = numSucceededTasks;
            NumFailedTasks = numFailedTasks;
            NumTaskRetries = numTaskRetries;
            WaitTime = waitTime;
        }

        /// <summary>
        /// Gets or sets the URL of the statistics.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets the start time of the time range covered by the
        /// statistics.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "startTime")]
        public System.DateTime StartTime { get; set; }

        /// <summary>
        /// Gets or sets the time at which the statistics were last updated.
        /// All statistics are limited to the range between startTime and
        /// lastUpdateTime.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "lastUpdateTime")]
        public System.DateTime LastUpdateTime { get; set; }

        /// <summary>
        /// Gets or sets the total user mode CPU time (summed across all cores
        /// and all compute nodes) consumed by all tasks in the job.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "userCPUTime")]
        public System.TimeSpan UserCPUTime { get; set; }

        /// <summary>
        /// Gets or sets the total kernel mode CPU time (summed across all
        /// cores and all compute nodes) consumed by all tasks in the job.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "kernelCPUTime")]
        public System.TimeSpan KernelCPUTime { get; set; }

        /// <summary>
        /// Gets or sets the total wall clock time of all tasks in the job.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "wallClockTime")]
        public System.TimeSpan WallClockTime { get; set; }

        /// <summary>
        /// Gets or sets the total number of disk read operations made by all
        /// tasks in the job.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "readIOps")]
        public long ReadIOps { get; set; }

        /// <summary>
        /// Gets or sets the total number of disk write operations made by all
        /// tasks in the job.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "writeIOps")]
        public long WriteIOps { get; set; }

        /// <summary>
        /// Gets or sets the total gibibytes read from disk by all tasks in
        /// the job.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "readIOGiB")]
        public double ReadIOGiB { get; set; }

        /// <summary>
        /// Gets or sets the total gibibytes written to disk by all tasks in
        /// the job.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "writeIOGiB")]
        public double WriteIOGiB { get; set; }

        /// <summary>
        /// Gets or sets the total number of tasks successfully completed in
        /// the job during the given time range.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "numSucceededTasks")]
        public long NumSucceededTasks { get; set; }

        /// <summary>
        /// Gets or sets the total number of tasks in the job that failed
        /// during the given time range.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "numFailedTasks")]
        public long NumFailedTasks { get; set; }

        /// <summary>
        /// Gets or sets the total number of retries on all the tasks in the
        /// job during the given time range.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "numTaskRetries")]
        public long NumTaskRetries { get; set; }

        /// <summary>
        /// Gets or sets the total wait time of all tasks in the job.
        /// </summary>
        /// <remarks>
        /// The wait time for a task is defined as the elapsed time between
        /// the creation of the task and the start of task execution. (If the
        /// task is retried due to failures, the wait time is the time to the
        /// most recent task execution.)
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "waitTime")]
        public System.TimeSpan WaitTime { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Url == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Url");
            }
        }
    }
}
