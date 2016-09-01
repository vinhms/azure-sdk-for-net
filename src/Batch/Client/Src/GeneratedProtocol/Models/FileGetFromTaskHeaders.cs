// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using System.Linq;

    /// <summary>
    /// Defines headers for GetFromTask operation.
    /// </summary>
    public partial class FileGetFromTaskHeaders
    {
        /// <summary>
        /// Initializes a new instance of the FileGetFromTaskHeaders class.
        /// </summary>
        public FileGetFromTaskHeaders() { }

        /// <summary>
        /// Initializes a new instance of the FileGetFromTaskHeaders class.
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
        /// <param name="ocpCreationTime">The file creation time.</param>
        /// <param name="ocpBatchFileIsdirectory">Whether the object
        /// represents a directory.</param>
        /// <param name="ocpBatchFileUrl">The URL of the file.</param>
        /// <param name="ocpBatchFileMode">The file mode attribute in octal
        /// format.</param>
        /// <param name="contentType">The content type of the file.</param>
        /// <param name="contentLength">The length of the file.</param>
        public FileGetFromTaskHeaders(string clientRequestId = default(string), string requestId = default(string), string eTag = default(string), System.DateTime? lastModified = default(System.DateTime?), System.DateTime? ocpCreationTime = default(System.DateTime?), bool? ocpBatchFileIsdirectory = default(bool?), string ocpBatchFileUrl = default(string), string ocpBatchFileMode = default(string), string contentType = default(string), long? contentLength = default(long?))
        {
            ClientRequestId = clientRequestId;
            RequestId = requestId;
            ETag = eTag;
            LastModified = lastModified;
            OcpCreationTime = ocpCreationTime;
            OcpBatchFileIsdirectory = ocpBatchFileIsdirectory;
            OcpBatchFileUrl = ocpBatchFileUrl;
            OcpBatchFileMode = ocpBatchFileMode;
            ContentType = contentType;
            ContentLength = contentLength;
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
        /// Gets or sets the file creation time.
        /// </summary>
        [Newtonsoft.Json.JsonConverter(typeof(Microsoft.Rest.Serialization.DateTimeRfc1123JsonConverter))]
        [Newtonsoft.Json.JsonProperty(PropertyName = "ocp-creation-time")]
        public System.DateTime? OcpCreationTime { get; set; }

        /// <summary>
        /// Gets or sets whether the object represents a directory.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "ocp-batch-file-isdirectory")]
        public bool? OcpBatchFileIsdirectory { get; set; }

        /// <summary>
        /// Gets or sets the URL of the file.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "ocp-batch-file-url")]
        public string OcpBatchFileUrl { get; set; }

        /// <summary>
        /// Gets or sets the file mode attribute in octal format.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "ocp-batch-file-mode")]
        public string OcpBatchFileMode { get; set; }

        /// <summary>
        /// Gets or sets the content type of the file.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "Content-Type")]
        public string ContentType { get; set; }

        /// <summary>
        /// Gets or sets the length of the file.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "Content-Length")]
        public long? ContentLength { get; set; }

    }
}
