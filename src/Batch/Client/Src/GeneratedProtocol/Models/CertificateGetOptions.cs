// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using System.Linq;

    /// <summary>
    /// Additional parameters for the Certificate_Get operation.
    /// </summary>
    public partial class CertificateGetOptions
    {
        /// <summary>
        /// Initializes a new instance of the CertificateGetOptions class.
        /// </summary>
        public CertificateGetOptions() { }

        /// <summary>
        /// Initializes a new instance of the CertificateGetOptions class.
        /// </summary>
        /// <param name="select">An OData $select clause.</param>
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
        public CertificateGetOptions(string select = default(string), int? timeout = default(int?), string clientRequestId = default(string), bool? returnClientRequestId = default(bool?), System.DateTime? ocpDate = default(System.DateTime?))
        {
            Select = select;
            Timeout = timeout;
            ClientRequestId = clientRequestId;
            ReturnClientRequestId = returnClientRequestId;
            OcpDate = ocpDate;
        }

        /// <summary>
        /// Gets or sets an OData $select clause.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "")]
        public string Select { get; set; }

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

    }
}
