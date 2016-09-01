// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using System.Linq;

    /// <summary>
    /// Additional parameters for the Pool_RemoveNodes operation.
    /// </summary>
    public partial class PoolRemoveNodesOptions
    {
        /// <summary>
        /// Initializes a new instance of the PoolRemoveNodesOptions class.
        /// </summary>
        public PoolRemoveNodesOptions() { }

        /// <summary>
        /// Initializes a new instance of the PoolRemoveNodesOptions class.
        /// </summary>
        /// <param name="timeout">The maximum time that the server can spend
        /// processing the request, in seconds. The default is 30
        /// seconds.</param>
        /// <param name="clientRequestId">The caller-generated request
        /// identity, in the form of a GUID with no decoration such as curly
        /// braces, e.g. 9C4D50EE-2D56-4CD3-8152-34347DC9F2B0.</param>
        /// <param name="returnClientRequestId">Whether the server should
        /// return the client-request-id identifier in the response.</param>
        /// <param name="ocpDate">The time the request was issued. If not
        /// specified, this header will be automatically populated with the
        /// current system clock time.</param>
        /// <param name="ifMatch">An ETag is specified. Specify this header to
        /// perform the operation only if the resource's ETag is an exact
        /// match as specified.</param>
        /// <param name="ifNoneMatch">An ETag is specified. Specify this
        /// header to perform the operation only if the resource's ETag does
        /// not match the specified ETag.</param>
        /// <param name="ifModifiedSince">Specify this header to perform the
        /// operation only if the resource has been modified since the
        /// specified date/time.</param>
        /// <param name="ifUnmodifiedSince">Specify this header to perform the
        /// operation only if the resource has not been modified since the
        /// specified date/time.</param>
        public PoolRemoveNodesOptions(int? timeout = default(int?), string clientRequestId = default(string), bool? returnClientRequestId = default(bool?), System.DateTime? ocpDate = default(System.DateTime?), string ifMatch = default(string), string ifNoneMatch = default(string), System.DateTime? ifModifiedSince = default(System.DateTime?), System.DateTime? ifUnmodifiedSince = default(System.DateTime?))
        {
            Timeout = timeout;
            ClientRequestId = clientRequestId;
            ReturnClientRequestId = returnClientRequestId;
            OcpDate = ocpDate;
            IfMatch = ifMatch;
            IfNoneMatch = ifNoneMatch;
            IfModifiedSince = ifModifiedSince;
            IfUnmodifiedSince = ifUnmodifiedSince;
        }

        /// <summary>
        /// Gets or sets the maximum time that the server can spend processing
        /// the request, in seconds. The default is 30 seconds.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "")]
        public int? Timeout { get; set; }

        /// <summary>
        /// Gets or sets the caller-generated request identity, in the form of
        /// a GUID with no decoration such as curly braces, e.g.
        /// 9C4D50EE-2D56-4CD3-8152-34347DC9F2B0.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "")]
        public string ClientRequestId { get; set; }

        /// <summary>
        /// Gets or sets whether the server should return the
        /// client-request-id identifier in the response.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "")]
        public bool? ReturnClientRequestId { get; set; }

        /// <summary>
        /// Gets or sets the time the request was issued. If not specified,
        /// this header will be automatically populated with the current
        /// system clock time.
        /// </summary>
        [Newtonsoft.Json.JsonConverter(typeof(Microsoft.Rest.Serialization.DateTimeRfc1123JsonConverter))]
        [Newtonsoft.Json.JsonProperty(PropertyName = "")]
        public System.DateTime? OcpDate { get; set; }

        /// <summary>
        /// Gets or sets an ETag is specified. Specify this header to perform
        /// the operation only if the resource's ETag is an exact match as
        /// specified.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "")]
        public string IfMatch { get; set; }

        /// <summary>
        /// Gets or sets an ETag is specified. Specify this header to perform
        /// the operation only if the resource's ETag does not match the
        /// specified ETag.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "")]
        public string IfNoneMatch { get; set; }

        /// <summary>
        /// Gets or sets specify this header to perform the operation only if
        /// the resource has been modified since the specified date/time.
        /// </summary>
        [Newtonsoft.Json.JsonConverter(typeof(Microsoft.Rest.Serialization.DateTimeRfc1123JsonConverter))]
        [Newtonsoft.Json.JsonProperty(PropertyName = "")]
        public System.DateTime? IfModifiedSince { get; set; }

        /// <summary>
        /// Gets or sets specify this header to perform the operation only if
        /// the resource has not been modified since the specified date/time.
        /// </summary>
        [Newtonsoft.Json.JsonConverter(typeof(Microsoft.Rest.Serialization.DateTimeRfc1123JsonConverter))]
        [Newtonsoft.Json.JsonProperty(PropertyName = "")]
        public System.DateTime? IfUnmodifiedSince { get; set; }

    }
}
