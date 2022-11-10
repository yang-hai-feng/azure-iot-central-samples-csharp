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
    /// <summary> The Exports service client. </summary>
    public partial class ExportsClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal ExportsRestClient RestClient { get; }

        /// <summary> Initializes a new instance of ExportsClient for mocking. </summary>
        protected ExportsClient()
        {
        }

        /// <summary> Initializes a new instance of ExportsClient. </summary>
        /// <param name="subdomain"> The application subdomain. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="baseDomain"> The base domain for all Azure IoT Central service requests. </param>
        /// <param name="options"> The options for configuring the client. </param>
        public ExportsClient(string subdomain, TokenCredential credential, string baseDomain = "azureiotcentral.com", AzureIoTCentralClientOptions options = null)
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
            RestClient = new ExportsRestClient(_clientDiagnostics, _pipeline, subdomain, baseDomain, options.Version);
        }

        /// <summary> Initializes a new instance of ExportsClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subdomain"> The application subdomain. </param>
        /// <param name="baseDomain"> The base domain for all Azure IoT Central service requests. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/>, <paramref name="pipeline"/>, <paramref name="subdomain"/>, <paramref name="baseDomain"/> or <paramref name="apiVersion"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subdomain"/> is an empty string, and was expected to be non-empty. </exception>
        internal ExportsClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subdomain, string baseDomain = "azureiotcentral.com", string apiVersion = "2022-10-31-preview")
        {
            RestClient = new ExportsRestClient(clientDiagnostics, pipeline, subdomain, baseDomain, apiVersion);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Get an export by ID. </summary>
        /// <param name="exportId"> Unique ID for the export. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<Export>> GetAsync(string exportId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExportsClient.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(exportId, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get an export by ID. </summary>
        /// <param name="exportId"> Unique ID for the export. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<Export> Get(string exportId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExportsClient.Get");
            scope.Start();
            try
            {
                return RestClient.Get(exportId, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create or update an export. </summary>
        /// <param name="exportId"> Unique ID for the export. </param>
        /// <param name="body"> Export body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks> Create or update a definition for exporting data. Also used to connect or disconnect an export from destinations. </remarks>
        public virtual async Task<Response<Export>> CreateAsync(string exportId, Export body, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExportsClient.Create");
            scope.Start();
            try
            {
                return await RestClient.CreateAsync(exportId, body, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create or update an export. </summary>
        /// <param name="exportId"> Unique ID for the export. </param>
        /// <param name="body"> Export body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks> Create or update a definition for exporting data. Also used to connect or disconnect an export from destinations. </remarks>
        public virtual Response<Export> Create(string exportId, Export body, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExportsClient.Create");
            scope.Start();
            try
            {
                return RestClient.Create(exportId, body, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Patch an export. </summary>
        /// <param name="exportId"> Unique ID for the export. </param>
        /// <param name="body"> Export patch body. </param>
        /// <param name="ifMatch"> Only perform the operation if the entity&apos;s etag matches one of the etags provided or * is provided. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks> Perform an incremental update to an export. </remarks>
        public virtual async Task<Response<Export>> UpdateAsync(string exportId, object body, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExportsClient.Update");
            scope.Start();
            try
            {
                return await RestClient.UpdateAsync(exportId, body, ifMatch, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Patch an export. </summary>
        /// <param name="exportId"> Unique ID for the export. </param>
        /// <param name="body"> Export patch body. </param>
        /// <param name="ifMatch"> Only perform the operation if the entity&apos;s etag matches one of the etags provided or * is provided. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <remarks> Perform an incremental update to an export. </remarks>
        public virtual Response<Export> Update(string exportId, object body, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExportsClient.Update");
            scope.Start();
            try
            {
                return RestClient.Update(exportId, body, ifMatch, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Delete an export. </summary>
        /// <param name="exportId"> Unique ID for the export. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> RemoveAsync(string exportId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExportsClient.Remove");
            scope.Start();
            try
            {
                return await RestClient.RemoveAsync(exportId, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Delete an export. </summary>
        /// <param name="exportId"> Unique ID for the export. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Remove(string exportId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExportsClient.Remove");
            scope.Start();
            try
            {
                return RestClient.Remove(exportId, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get the list of exports in an application. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<Export> ListAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<Export>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ExportsClient.List");
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
            async Task<Page<Export>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ExportsClient.List");
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

        /// <summary> Get the list of exports in an application. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<Export> List(CancellationToken cancellationToken = default)
        {
            Page<Export> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ExportsClient.List");
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
            Page<Export> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ExportsClient.List");
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

        /// <summary> List all destinations connected to the given export. </summary>
        /// <param name="exportId"> Unique ID for the export. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="exportId"/> is null. </exception>
        public virtual AsyncPageable<Destination> ListDestinationsAsync(string exportId, CancellationToken cancellationToken = default)
        {
            if (exportId == null)
            {
                throw new ArgumentNullException(nameof(exportId));
            }

            async Task<Page<Destination>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ExportsClient.ListDestinations");
                scope.Start();
                try
                {
                    var response = await RestClient.ListDestinationsAsync(exportId, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<Destination>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ExportsClient.ListDestinations");
                scope.Start();
                try
                {
                    var response = await RestClient.ListDestinationsNextPageAsync(nextLink, exportId, cancellationToken).ConfigureAwait(false);
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

        /// <summary> List all destinations connected to the given export. </summary>
        /// <param name="exportId"> Unique ID for the export. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="exportId"/> is null. </exception>
        public virtual Pageable<Destination> ListDestinations(string exportId, CancellationToken cancellationToken = default)
        {
            if (exportId == null)
            {
                throw new ArgumentNullException(nameof(exportId));
            }

            Page<Destination> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ExportsClient.ListDestinations");
                scope.Start();
                try
                {
                    var response = RestClient.ListDestinations(exportId, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<Destination> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ExportsClient.ListDestinations");
                scope.Start();
                try
                {
                    var response = RestClient.ListDestinationsNextPage(nextLink, exportId, cancellationToken);
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