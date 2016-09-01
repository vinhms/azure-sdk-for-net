// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using System.Linq;

    /// <summary>
    /// Information about an error when scheduling a task.
    /// </summary>
    public partial class TaskSchedulingError
    {
        /// <summary>
        /// Initializes a new instance of the TaskSchedulingError class.
        /// </summary>
        public TaskSchedulingError() { }

        /// <summary>
        /// Initializes a new instance of the TaskSchedulingError class.
        /// </summary>
        /// <param name="category">The category of the task scheduling
        /// error.</param>
        /// <param name="code">An identifier for the task scheduling error.
        /// Codes are invariant and are intended to be consumed
        /// programmatically.</param>
        /// <param name="message">A message describing the task scheduling
        /// error, intended to be suitable for display in a user
        /// interface.</param>
        /// <param name="details">The list of additional error details related
        /// to the scheduling error.</param>
        public TaskSchedulingError(SchedulingErrorCategory category, string code = default(string), string message = default(string), System.Collections.Generic.IList<NameValuePair> details = default(System.Collections.Generic.IList<NameValuePair>))
        {
            Category = category;
            Code = code;
            Message = message;
            Details = details;
        }

        /// <summary>
        /// Gets or sets the category of the task scheduling error.
        /// </summary>
        /// <remarks>
        /// Possible values include: 'usererror', 'servererror', 'unmapped'
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "category")]
        public SchedulingErrorCategory Category { get; set; }

        /// <summary>
        /// Gets or sets an identifier for the task scheduling error. Codes
        /// are invariant and are intended to be consumed programmatically.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets a message describing the task scheduling error,
        /// intended to be suitable for display in a user interface.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets the list of additional error details related to the
        /// scheduling error.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "details")]
        public System.Collections.Generic.IList<NameValuePair> Details { get; set; }

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
