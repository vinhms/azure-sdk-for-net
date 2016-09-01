// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using System.Linq;

    /// <summary>
    /// An user account on a compute node.
    /// </summary>
    public partial class ComputeNodeUser
    {
        /// <summary>
        /// Initializes a new instance of the ComputeNodeUser class.
        /// </summary>
        public ComputeNodeUser() { }

        /// <summary>
        /// Initializes a new instance of the ComputeNodeUser class.
        /// </summary>
        /// <param name="name">The user name of the account.</param>
        /// <param name="isAdmin">Whether the account should be an
        /// administrator on the compute node.</param>
        /// <param name="expiryTime">The time at which the account should
        /// expire.</param>
        /// <param name="password">The password of the account.</param>
        /// <param name="sshPublicKey">The SSH public key that can be used for
        /// remote login to the compute node.</param>
        public ComputeNodeUser(string name, bool? isAdmin = default(bool?), System.DateTime? expiryTime = default(System.DateTime?), string password = default(string), string sshPublicKey = default(string))
        {
            Name = name;
            IsAdmin = isAdmin;
            ExpiryTime = expiryTime;
            Password = password;
            SshPublicKey = sshPublicKey;
        }

        /// <summary>
        /// Gets or sets the user name of the account.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets whether the account should be an administrator on the
        /// compute node.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "isAdmin")]
        public bool? IsAdmin { get; set; }

        /// <summary>
        /// Gets or sets the time at which the account should expire.
        /// </summary>
        /// <remarks>
        /// If omitted, the default is 1 day from the current time.
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "expiryTime")]
        public System.DateTime? ExpiryTime { get; set; }

        /// <summary>
        /// Gets or sets the password of the account.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "password")]
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets the SSH public key that can be used for remote login
        /// to the compute node.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "sshPublicKey")]
        public string SshPublicKey { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Name");
            }
        }
    }
}
