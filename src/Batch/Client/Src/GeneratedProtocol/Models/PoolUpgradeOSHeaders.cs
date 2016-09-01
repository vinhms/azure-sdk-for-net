// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using System.Linq;

    /// <summary>
    /// Defines headers for UpgradeOS operation.
    /// </summary>
    public partial class PoolUpgradeOSHeaders
    {
        /// <summary>
        /// Initializes a new instance of the PoolUpgradeOSHeaders class.
        /// </summary>
        public PoolUpgradeOSHeaders() { }

        /// <summary>
        /// Initializes a new instance of the PoolUpgradeOSHeaders class.
        /// </summary>
        /// <param name="clientRequestId">The ClientRequestId provided by the
        /// client during the request, if present and requested to be
        /// returned.</param>
        /// <param name="requestId">The value that uniquely identifies a
        /// request.</param>
        /// <param name="eTag">The content of the ETag HTTP response
        /// header.</param>
        /// <param name="lastModified">The content of the Last-Modified HTTP
        /// response header.</param>
        /// <param name="dataServiceId">The OData id of the resource to which
        /// the request applied.</param>
        public PoolUpgradeOSHeaders(string clientRequestId = default(string), string requestId = default(string), string eTag = default(string), System.DateTime? lastModified = default(System.DateTime?), string dataServiceId = default(string))
        {
            ClientRequestId = clientRequestId;
            RequestId = requestId;
            ETag = eTag;
            LastModified = lastModified;
            DataServiceId = dataServiceId;
        }

        /// <summary>
        /// Gets or sets the ClientRequestId provided by the client during the
        /// request, if present and requested to be returned.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "client-request-id")]
        public string ClientRequestId { get; set; }

        /// <summary>
        /// Gets or sets the value that uniquely identifies a request.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "request-id")]
        public string RequestId { get; set; }

        /// <summary>
        /// Gets or sets the content of the ETag HTTP response header.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "ETag")]
        public string ETag { get; set; }

        /// <summary>
        /// Gets or sets the content of the Last-Modified HTTP response header.
        /// </summary>
        [Newtonsoft.Json.JsonConverter(typeof(Microsoft.Rest.Serialization.DateTimeRfc1123JsonConverter))]
        [Newtonsoft.Json.JsonProperty(PropertyName = "Last-Modified")]
        public System.DateTime? LastModified { get; set; }

        /// <summary>
        /// Gets or sets the OData id of the resource to which the request
        /// applied.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "DataServiceId")]
        public string DataServiceId { get; set; }

    }
}
