// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataMigration.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Results for query analysis comparison between the source and target
    /// </summary>
    public partial class QueryAnalysisValidationResult
    {
        /// <summary>
        /// Initializes a new instance of the QueryAnalysisValidationResult
        /// class.
        /// </summary>
        public QueryAnalysisValidationResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the QueryAnalysisValidationResult
        /// class.
        /// </summary>
        /// <param name="queryResults">List of queries executed and it's
        /// execution results in source and target</param>
        /// <param name="validationErrors">Errors that are part of the
        /// execution</param>
        public QueryAnalysisValidationResult(QueryExecutionResult queryResults = default(QueryExecutionResult), ValidationError validationErrors = default(ValidationError))
        {
            QueryResults = queryResults;
            ValidationErrors = validationErrors;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets list of queries executed and it's execution results in
        /// source and target
        /// </summary>
        [JsonProperty(PropertyName = "queryResults")]
        public QueryExecutionResult QueryResults { get; set; }

        /// <summary>
        /// Gets or sets errors that are part of the execution
        /// </summary>
        [JsonProperty(PropertyName = "validationErrors")]
        public ValidationError ValidationErrors { get; set; }

    }
}