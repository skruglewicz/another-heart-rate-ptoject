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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Request to get or delete multiple time series hierarchies. Exactly one
    /// of "hierarchyIds" or "names" must be set.
    /// </summary>
    public partial class HierarchiesRequestBatchGetDelete
    {
        /// <summary>
        /// Initializes a new instance of the HierarchiesRequestBatchGetDelete
        /// class.
        /// </summary>
        public HierarchiesRequestBatchGetDelete()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the HierarchiesRequestBatchGetDelete
        /// class.
        /// </summary>
        /// <param name="hierarchyIds">List of hierarchy IDs.</param>
        /// <param name="names">List of hierarchy names.</param>
        public HierarchiesRequestBatchGetDelete(IList<System.Guid?> hierarchyIds = default(IList<System.Guid?>), IList<string> names = default(IList<string>))
        {
            HierarchyIds = hierarchyIds;
            Names = names;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets list of hierarchy IDs.
        /// </summary>
        [JsonProperty(PropertyName = "hierarchyIds")]
        public IList<System.Guid?> HierarchyIds { get; set; }

        /// <summary>
        /// Gets or sets list of hierarchy names.
        /// </summary>
        [JsonProperty(PropertyName = "names")]
        public IList<string> Names { get; set; }

    }
}
