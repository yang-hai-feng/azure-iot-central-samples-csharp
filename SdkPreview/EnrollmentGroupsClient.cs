// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Microsoft.Azure.IoTCentral.Preview.Models;

namespace Microsoft.Azure.IoTCentral.Preview
{
    /// <summary> The EnrollmentGroups service client. </summary>
    public partial class EnrollmentGroupsClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal EnrollmentGroupsRestClient RestClient { get; }

        /// <summary> Initializes a new instance of EnrollmentGroupsClient for mocking. </summary>
        protected EnrollmentGroupsClient()
        {
        }

        /// <summary> Initializes a new instance of EnrollmentGroupsClient. </summary>
        /// <param name="subdomain"> The application subdomain. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="baseDomain"> The base domain for all Azure IoT Central service requests. </param>
        /// <param name="options"> The options for configuring the client. </param>
        public EnrollmentGroupsClient(string subdomain, TokenCredential credential, string baseDomain = "azureiotcentral.com", AzureIoTCentralClientOptions options = null)
        {
            if (subdomain == null)
            {
                throw new ArgumentNullException(nameof(subdomain));
            }
            if (credential == null)
            {
                throw new ArgumentNullException(nameof(credential));
            }
            if (baseDomain == null)
            {
                throw new ArgumentNullException(nameof(baseDomain));
            }

            options ??= new AzureIoTCentralClientOptions();
            _clientDiagnostics = new ClientDiagnostics(options);
            string[] scopes = { "https://apps.azureiotcentral.com/.default" };
            _pipeline = HttpPipelineBuilder.Build(options, new BearerTokenAuthenticationPolicy(credential, scopes));
            RestClient = new EnrollmentGroupsRestClient(_clientDiagnostics, _pipeline, subdomain, baseDomain, options.Version);
        }

        /// <summary> Initializes a new instance of EnrollmentGroupsClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subdomain"> The application subdomain. </param>
        /// <param name="baseDomain"> The base domain for all Azure IoT Central service requests. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/>, <paramref name="pipeline"/>, <paramref name="subdomain"/>, <paramref name="baseDomain"/> or <paramref name="apiVersion"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subdomain"/> is an empty string, and was expected to be non-empty. </exception>
        internal EnrollmentGroupsClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subdomain, string baseDomain = "azureiotcentral.com", string apiVersion = "2022-10-31-preview")
        {
            RestClient = new EnrollmentGroupsRestClient(clientDiagnostics, pipeline, subdomain, baseDomain, apiVersion);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Get an enrollment group by ID. </summary>
        /// <param name="enrollmentGroupId"> Unique ID of the enrollment group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks> Get details about an enrollment group by ID. </remarks>
        public virtual async Task<Response<EnrollmentGroup>> GetAsync(string enrollmentGroupId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("EnrollmentGroupsClient.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(enrollmentGroupId, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get an enrollment group by ID. </summary>
        /// <param name="enrollmentGroupId"> Unique ID of the enrollment group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks> Get details about an enrollment group by ID. </remarks>
        public virtual Response<EnrollmentGroup> Get(string enrollmentGroupId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("EnrollmentGroupsClient.Get");
            scope.Start();
            try
            {
                return RestClient.Get(enrollmentGroupId, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create an enrollment group. </summary>
        /// <param name="enrollmentGroupId"> Unique ID of the enrollment group. </param>
        /// <param name="body"> Enrollment group body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks> Create an enrollment group. </remarks>
        public virtual async Task<Response<EnrollmentGroup>> CreateAsync(string enrollmentGroupId, EnrollmentGroup body, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("EnrollmentGroupsClient.Create");
            scope.Start();
            try
            {
                return await RestClient.CreateAsync(enrollmentGroupId, body, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create an enrollment group. </summary>
        /// <param name="enrollmentGroupId"> Unique ID of the enrollment group. </param>
        /// <param name="body"> Enrollment group body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks> Create an enrollment group. </remarks>
        public virtual Response<EnrollmentGroup> Create(string enrollmentGroupId, EnrollmentGroup body, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("EnrollmentGroupsClient.Create");
            scope.Start();
            try
            {
                return RestClient.Create(enrollmentGroupId, body, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Update an enrollment group. </summary>
        /// <param name="enrollmentGroupId"> Unique ID of the enrollment group. </param>
        /// <param name="body"> Enrollment group patch body. </param>
        /// <param name="ifMatch"> Only perform the operation if the entity&apos;s etag matches one of the etags provided or * is provided. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks> Update an enrollment group. </remarks>
        public virtual async Task<Response<EnrollmentGroup>> UpdateAsync(string enrollmentGroupId, object body, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("EnrollmentGroupsClient.Update");
            scope.Start();
            try
            {
                return await RestClient.UpdateAsync(enrollmentGroupId, body, ifMatch, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Update an enrollment group. </summary>
        /// <param name="enrollmentGroupId"> Unique ID of the enrollment group. </param>
        /// <param name="body"> Enrollment group patch body. </param>
        /// <param name="ifMatch"> Only perform the operation if the entity&apos;s etag matches one of the etags provided or * is provided. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks> Update an enrollment group. </remarks>
        public virtual Response<EnrollmentGroup> Update(string enrollmentGroupId, object body, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("EnrollmentGroupsClient.Update");
            scope.Start();
            try
            {
                return RestClient.Update(enrollmentGroupId, body, ifMatch, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Delete an enrollment group. </summary>
        /// <param name="enrollmentGroupId"> Unique ID of the enrollment group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks> Delete an enrollment group by ID. </remarks>
        public virtual async Task<Response> RemoveAsync(string enrollmentGroupId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("EnrollmentGroupsClient.Remove");
            scope.Start();
            try
            {
                return await RestClient.RemoveAsync(enrollmentGroupId, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Delete an enrollment group. </summary>
        /// <param name="enrollmentGroupId"> Unique ID of the enrollment group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks> Delete an enrollment group by ID. </remarks>
        public virtual Response Remove(string enrollmentGroupId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("EnrollmentGroupsClient.Remove");
            scope.Start();
            try
            {
                return RestClient.Remove(enrollmentGroupId, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get the primary or secondary x509 certificate of an enrollment group. </summary>
        /// <param name="enrollmentGroupId"> Unique ID of the enrollment group. </param>
        /// <param name="entry"> Entry of certificate only support primary and secondary. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks> Get details about the primary or secondary x509 certificate of an enrollment group, if it exists. </remarks>
        public virtual async Task<Response<SigningX509Certificate>> GetX509Async(string enrollmentGroupId, CertificateEntry entry, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("EnrollmentGroupsClient.GetX509");
            scope.Start();
            try
            {
                return await RestClient.GetX509Async(enrollmentGroupId, entry, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get the primary or secondary x509 certificate of an enrollment group. </summary>
        /// <param name="enrollmentGroupId"> Unique ID of the enrollment group. </param>
        /// <param name="entry"> Entry of certificate only support primary and secondary. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks> Get details about the primary or secondary x509 certificate of an enrollment group, if it exists. </remarks>
        public virtual Response<SigningX509Certificate> GetX509(string enrollmentGroupId, CertificateEntry entry, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("EnrollmentGroupsClient.GetX509");
            scope.Start();
            try
            {
                return RestClient.GetX509(enrollmentGroupId, entry, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Sets the primary or secondary x509 certificate of an enrollment group. </summary>
        /// <param name="enrollmentGroupId"> Unique ID of the enrollment group. </param>
        /// <param name="entry"> Entry of certificate only support primary and secondary. </param>
        /// <param name="body"> Certificate definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks> Sets the primary or secondary x509 certificate of an enrollment group. </remarks>
        public virtual async Task<Response<SigningX509Certificate>> CreateX509Async(string enrollmentGroupId, CertificateEntry entry, SigningX509Certificate body, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("EnrollmentGroupsClient.CreateX509");
            scope.Start();
            try
            {
                return await RestClient.CreateX509Async(enrollmentGroupId, entry, body, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Sets the primary or secondary x509 certificate of an enrollment group. </summary>
        /// <param name="enrollmentGroupId"> Unique ID of the enrollment group. </param>
        /// <param name="entry"> Entry of certificate only support primary and secondary. </param>
        /// <param name="body"> Certificate definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks> Sets the primary or secondary x509 certificate of an enrollment group. </remarks>
        public virtual Response<SigningX509Certificate> CreateX509(string enrollmentGroupId, CertificateEntry entry, SigningX509Certificate body, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("EnrollmentGroupsClient.CreateX509");
            scope.Start();
            try
            {
                return RestClient.CreateX509(enrollmentGroupId, entry, body, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Removes the primary or secondary x509 certificate of an enrollment group. </summary>
        /// <param name="enrollmentGroupId"> Unique ID of the enrollment group. </param>
        /// <param name="entry"> Entry of certificate only support primary and secondary. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks> Removes the primary or secondary x509 certificate of an enrollment group. </remarks>
        public virtual async Task<Response> RemoveX509Async(string enrollmentGroupId, CertificateEntry entry, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("EnrollmentGroupsClient.RemoveX509");
            scope.Start();
            try
            {
                return await RestClient.RemoveX509Async(enrollmentGroupId, entry, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Removes the primary or secondary x509 certificate of an enrollment group. </summary>
        /// <param name="enrollmentGroupId"> Unique ID of the enrollment group. </param>
        /// <param name="entry"> Entry of certificate only support primary and secondary. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks> Removes the primary or secondary x509 certificate of an enrollment group. </remarks>
        public virtual Response RemoveX509(string enrollmentGroupId, CertificateEntry entry, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("EnrollmentGroupsClient.RemoveX509");
            scope.Start();
            try
            {
                return RestClient.RemoveX509(enrollmentGroupId, entry, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Generate a verification code for the primary or secondary x509 certificate of an enrollment group. </summary>
        /// <param name="enrollmentGroupId"> Unique ID of the enrollment group. </param>
        /// <param name="entry"> Entry of certificate only support primary and secondary. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks> Generate a verification code for the primary or secondary x509 certificate of an enrollment group. </remarks>
        public virtual async Task<Response<X509VerificationCode>> GenerateVerificationCodeX509Async(string enrollmentGroupId, CertificateEntry entry, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("EnrollmentGroupsClient.GenerateVerificationCodeX509");
            scope.Start();
            try
            {
                return await RestClient.GenerateVerificationCodeX509Async(enrollmentGroupId, entry, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Generate a verification code for the primary or secondary x509 certificate of an enrollment group. </summary>
        /// <param name="enrollmentGroupId"> Unique ID of the enrollment group. </param>
        /// <param name="entry"> Entry of certificate only support primary and secondary. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks> Generate a verification code for the primary or secondary x509 certificate of an enrollment group. </remarks>
        public virtual Response<X509VerificationCode> GenerateVerificationCodeX509(string enrollmentGroupId, CertificateEntry entry, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("EnrollmentGroupsClient.GenerateVerificationCodeX509");
            scope.Start();
            try
            {
                return RestClient.GenerateVerificationCodeX509(enrollmentGroupId, entry, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Verify the primary or secondary x509 certificate of an enrollment group. </summary>
        /// <param name="enrollmentGroupId"> Unique ID of the enrollment group. </param>
        /// <param name="entry"> Entry of certificate only support primary and secondary. </param>
        /// <param name="body"> Certificate for the signed verification code. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks> Verify the primary or secondary x509 certificate of an enrollment group by providing a certificate with the signed verification code. </remarks>
        public virtual async Task<Response> VerifyX509Async(string enrollmentGroupId, CertificateEntry entry, X509VerificationCertificate body, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("EnrollmentGroupsClient.VerifyX509");
            scope.Start();
            try
            {
                return await RestClient.VerifyX509Async(enrollmentGroupId, entry, body, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Verify the primary or secondary x509 certificate of an enrollment group. </summary>
        /// <param name="enrollmentGroupId"> Unique ID of the enrollment group. </param>
        /// <param name="entry"> Entry of certificate only support primary and secondary. </param>
        /// <param name="body"> Certificate for the signed verification code. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks> Verify the primary or secondary x509 certificate of an enrollment group by providing a certificate with the signed verification code. </remarks>
        public virtual Response VerifyX509(string enrollmentGroupId, CertificateEntry entry, X509VerificationCertificate body, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("EnrollmentGroupsClient.VerifyX509");
            scope.Start();
            try
            {
                return RestClient.VerifyX509(enrollmentGroupId, entry, body, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get the list of enrollment groups in an application. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<EnrollmentGroup> ListAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<EnrollmentGroup>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("EnrollmentGroupsClient.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListAsync(cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<EnrollmentGroup>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("EnrollmentGroupsClient.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListNextPageAsync(nextLink, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Get the list of enrollment groups in an application. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<EnrollmentGroup> List(CancellationToken cancellationToken = default)
        {
            Page<EnrollmentGroup> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("EnrollmentGroupsClient.List");
                scope.Start();
                try
                {
                    var response = RestClient.List(cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<EnrollmentGroup> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("EnrollmentGroupsClient.List");
                scope.Start();
                try
                {
                    var response = RestClient.ListNextPage(nextLink, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }
    }
}
