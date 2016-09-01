// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol
{
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// CertificateOperations operations.
    /// </summary>
    public partial interface ICertificateOperations
    {
        /// <summary>
        /// Adds a certificate to the specified account.
        /// </summary>
        /// <param name='certificate'>
        /// The certificate to be added.
        /// </param>
        /// <param name='certificateAddOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="BatchErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationHeaderResponse<CertificateAddHeaders>> AddWithHttpMessagesAsync(CertificateAddParameter certificate, CertificateAddOptions certificateAddOptions = default(CertificateAddOptions), System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Lists all of the certificates that have been added to the
        /// specified account.
        /// </summary>
        /// <param name='certificateListOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="BatchErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<Microsoft.Rest.Azure.IPage<Certificate>,CertificateListHeaders>> ListWithHttpMessagesAsync(CertificateListOptions certificateListOptions = default(CertificateListOptions), System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Cancels a failed deletion of a certificate from the specified
        /// account.
        /// </summary>
        /// <param name='thumbprintAlgorithm'>
        /// The algorithm used to derive the thumbprint parameter. This must
        /// be sha1.
        /// </param>
        /// <param name='thumbprint'>
        /// The thumbprint of the certificate being deleted.
        /// </param>
        /// <param name='certificateCancelDeletionOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="BatchErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationHeaderResponse<CertificateCancelDeletionHeaders>> CancelDeletionWithHttpMessagesAsync(string thumbprintAlgorithm, string thumbprint, CertificateCancelDeletionOptions certificateCancelDeletionOptions = default(CertificateCancelDeletionOptions), System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Deletes a certificate from the specified account.
        /// </summary>
        /// <param name='thumbprintAlgorithm'>
        /// The algorithm used to derive the thumbprint parameter. This must
        /// be sha1.
        /// </param>
        /// <param name='thumbprint'>
        /// The thumbprint of the certificate to be deleted.
        /// </param>
        /// <param name='certificateDeleteOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="BatchErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationHeaderResponse<CertificateDeleteHeaders>> DeleteWithHttpMessagesAsync(string thumbprintAlgorithm, string thumbprint, CertificateDeleteOptions certificateDeleteOptions = default(CertificateDeleteOptions), System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Gets information about the specified certificate.
        /// </summary>
        /// <param name='thumbprintAlgorithm'>
        /// The algorithm used to derive the thumbprint parameter. This must
        /// be sha1.
        /// </param>
        /// <param name='thumbprint'>
        /// The thumbprint of the certificate to get.
        /// </param>
        /// <param name='certificateGetOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="BatchErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<Certificate,CertificateGetHeaders>> GetWithHttpMessagesAsync(string thumbprintAlgorithm, string thumbprint, CertificateGetOptions certificateGetOptions = default(CertificateGetOptions), System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Lists all of the certificates that have been added to the
        /// specified account.
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='certificateListNextOptions'>
        /// Additional parameters for the operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="BatchErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<Microsoft.Rest.Azure.IPage<Certificate>,CertificateListHeaders>> ListNextWithHttpMessagesAsync(string nextPageLink, CertificateListNextOptions certificateListNextOptions = default(CertificateListNextOptions), System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    }
}
