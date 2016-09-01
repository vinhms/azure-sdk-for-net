// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using System.Linq;

    /// <summary>
    /// An error encountered by the Batch service when deleting a certificate.
    /// </summary>
    public partial class DeleteCertificateError
    {
        /// <summary>
        /// Initializes a new instance of the DeleteCertificateError class.
        /// </summary>
        public DeleteCertificateError() { }

        /// <summary>
        /// Initializes a new instance of the DeleteCertificateError class.
        /// </summary>
        /// <param name="code">An identifier for the certificate deletion
        /// error. Codes are invariant and are intended to be consumed
        /// programmatically.</param>
        /// <param name="message">A message describing the certificate
        /// deletion error, intended to be suitable for display in a user
        /// interface.</param>
        /// <param name="values">A list of additional error details related to
        /// the certificate deletion error.</param>
        public DeleteCertificateError(string code = default(string), string message = default(string), System.Collections.Generic.IList<NameValuePair> values = default(System.Collections.Generic.IList<NameValuePair>))
        {
            Code = code;
            Message = message;
            Values = values;
        }

        /// <summary>
        /// Gets or sets an identifier for the certificate deletion error.
        /// Codes are invariant and are intended to be consumed
        /// programmatically.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets a message describing the certificate deletion error,
        /// intended to be suitable for display in a user interface.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets a list of additional error details related to the
        /// certificate deletion error.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "values")]
        public System.Collections.Generic.IList<NameValuePair> Values { get; set; }

    }
}
