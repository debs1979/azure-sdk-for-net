// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Dataset reference type. </summary>
    public partial class DatasetReference
    {
        /// <summary> Initializes a new instance of DatasetReference. </summary>
        /// <param name="referenceName"> Reference dataset name. </param>
        public DatasetReference(string referenceName)
        {
            if (referenceName == null)
            {
                throw new ArgumentNullException(nameof(referenceName));
            }

            Type = "DatasetReference";
            ReferenceName = referenceName;
        }

        /// <summary> Initializes a new instance of DatasetReference. </summary>
        /// <param name="type"> Dataset reference type. </param>
        /// <param name="referenceName"> Reference dataset name. </param>
        /// <param name="parameters"> Arguments for dataset. </param>
        internal DatasetReference(string type, string referenceName, IDictionary<string, object> parameters)
        {
            Type = type;
            ReferenceName = referenceName;
            Parameters = parameters;
        }

        /// <summary> Dataset reference type. </summary>
        public string Type { get; set; }
        /// <summary> Reference dataset name. </summary>
        public string ReferenceName { get; set; }
        /// <summary> Arguments for dataset. </summary>
        public IDictionary<string, object> Parameters { get; set; }
    }
}
