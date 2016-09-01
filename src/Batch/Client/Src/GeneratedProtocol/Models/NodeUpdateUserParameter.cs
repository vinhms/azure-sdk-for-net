// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using System.Linq;

    /// <summary>
    /// Parameters for a ComputeNodeOperations.UpdateUser request.
    /// </summary>
    public partial class NodeUpdateUserParameter
    {
        /// <summary>
        /// Initializes a new instance of the NodeUpdateUserParameter class.
        /// </summary>
        public NodeUpdateUserParameter() { }

        /// <summary>
        /// Initializes a new instance of the NodeUpdateUserParameter class.
        /// </summary>
        /// <param name="password">The password of the account.</param>
        /// <param name="expiryTime">The time at which the account should
        /// expire.</param>
        /// <param name="sshPublicKey">The SSH public key that can be used for
        /// remote login to the compute node.</param>
        public NodeUpdateUserParameter(string password = default(string), System.DateTime? expiryTime = default(System.DateTime?), string sshPublicKey = default(string))
        {
            Password = password;
            ExpiryTime = expiryTime;
            SshPublicKey = sshPublicKey;
        }

        /// <summary>
        /// Gets or sets the password of the account.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "password")]
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets the time at which the account should expire.
        /// </summary>
        /// <remarks>
        /// If omitted, the default is 1 day from the current time.
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "expiryTime")]
        public System.DateTime? ExpiryTime { get; set; }

        /// <summary>
        /// Gets or sets the SSH public key that can be used for remote login
        /// to the compute node.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "sshPublicKey")]
        public string SshPublicKey { get; set; }

    }
}
