// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Resources.Models
{

    /// <summary>
    /// Defines values for ValidationLevel.
    /// </summary>


    public static class ValidationLevel
    {
        /// <summary>
        /// Static analysis of the template is performed.
        /// </summary>
        public const string Template = "Template";
        /// <summary>
        /// Static analysis of the template is performed and resource declarations are
        /// sent to resource providers for semantic validation. Validates that the
        /// caller has RBAC write permissions on each resource.
        /// </summary>
        public const string Provider = "Provider";
        /// <summary>
        /// Static analysis of the template is performed and resource declarations are
        /// sent to resource providers for semantic validation. Skips validating that
        /// the caller has RBAC write permissions on each resource.
        /// </summary>
        public const string ProviderNoRbac = "ProviderNoRbac";
    }
}