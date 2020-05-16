// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.TimeSeriesInsights.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Defines headers for ExecuteHierarchiesBatchOperation operation.
    /// </summary>
    public partial class ExecuteHierarchiesBatchOperationHeaders
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ExecuteHierarchiesBatchOperationHeaders class.
        /// </summary>
        public ExecuteHierarchiesBatchOperationHeaders()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ExecuteHierarchiesBatchOperationHeaders class.
        /// </summary>
        /// <param name="serverRequestId">Server-generated request ID. Can be
        /// used to contact support to investigate a request.</param>
        public ExecuteHierarchiesBatchOperationHeaders(string serverRequestId = default(string))
        {
            ServerRequestId = serverRequestId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets server-generated request ID. Can be used to contact
        /// support to investigate a request.
        /// </summary>
        [JsonProperty(PropertyName = "x-ms-request-id")]
        public string ServerRequestId { get; set; }

    }
}
