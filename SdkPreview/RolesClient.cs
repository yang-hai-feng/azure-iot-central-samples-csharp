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
    /// <summary> The Roles service client. </summary>
    public partial class RolesClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal RolesRestClient RestClient { get; }

        /// <summary> Initializes a new instance of RolesClient for mocking. </summary>
        protected RolesClient()
        {
        }

        /// <summary> Initializes a new instance of RolesClient. </summary>
        /// <param name="subdomain"> The application subdomain. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="baseDomain"> The base domain for all Azure IoT Central service requests. </param>
        /// <param name="options"> The options for configuring the client. </param>
        public RolesClient(string subdomain, TokenCredential credential, string baseDomain = "azureiotcentral.com", AzureIoTCentralClientOptions options = null)
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
            RestClient = new RolesRestClient(_clientDiagnostics, _pipeline, subdomain, baseDomain, options.Version);
        }

        /// <summary> Initializes a new instance of RolesClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subdomain"> The application subdomain. </param>
        /// <param name="baseDomain"> The base domain for all Azure IoT Central service requests. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/>, <paramref name="pipeline"/>, <paramref name="subdomain"/>, <paramref name="baseDomain"/> or <paramref name="apiVersion"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subdomain"/> is an empty string, and was expected to be non-empty. </exception>
        internal RolesClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subdomain, string baseDomain = "azureiotcentral.com", string apiVersion = "2022-10-31-preview")
        {
            RestClient = new RolesRestClient(clientDiagnostics, pipeline, subdomain, baseDomain, apiVersion);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Get a role by ID. </summary>
        /// <param name="roleId"> Unique ID for the role. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<Role>> GetAsync(string roleId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("RolesClient.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(roleId, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get a role by ID. </summary>
        /// <param name="roleId"> Unique ID for the role. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<Role> Get(string roleId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("RolesClient.Get");
            scope.Start();
            try
            {
                return RestClient.Get(roleId, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get the list of roles in an application. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<Role> ListAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<Role>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("RolesClient.List");
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
            async Task<Page<Role>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("RolesClient.List");
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

        /// <summary> Get the list of roles in an application. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<Role> List(CancellationToken cancellationToken = default)
        {
            Page<Role> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("RolesClient.List");
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
            Page<Role> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("RolesClient.List");
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
