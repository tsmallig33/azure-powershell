// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Extensions;

    /// <summary>implicitGrantSettings</summary>
    public partial class MicrosoftGraphImplicitGrantSettings :
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphImplicitGrantSettings,
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Models.ApiV10.IMicrosoftGraphImplicitGrantSettingsInternal
    {

        /// <summary>Backing field for <see cref="EnableAccessTokenIssuance" /> property.</summary>
        private bool? _enableAccessTokenIssuance;

        /// <summary>
        /// Specifies whether this web application can request an access token using the OAuth 2.0 implicit flow.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public bool? EnableAccessTokenIssuance { get => this._enableAccessTokenIssuance; set => this._enableAccessTokenIssuance = value; }

        /// <summary>Backing field for <see cref="EnableIdTokenIssuance" /> property.</summary>
        private bool? _enableIdTokenIssuance;

        /// <summary>
        /// Specifies whether this web application can request an ID token using the OAuth 2.0 implicit flow.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Origin(Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.PropertyOrigin.Owned)]
        public bool? EnableIdTokenIssuance { get => this._enableIdTokenIssuance; set => this._enableIdTokenIssuance = value; }

        /// <summary>Creates an new <see cref="MicrosoftGraphImplicitGrantSettings" /> instance.</summary>
        public MicrosoftGraphImplicitGrantSettings()
        {

        }
    }
    /// implicitGrantSettings
    public partial interface IMicrosoftGraphImplicitGrantSettings :
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.IAssociativeArray<global::System.Object>
    {
        /// <summary>
        /// Specifies whether this web application can request an access token using the OAuth 2.0 implicit flow.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies whether this web application can request an access token using the OAuth 2.0 implicit flow.",
        SerializedName = @"enableAccessTokenIssuance",
        PossibleTypes = new [] { typeof(bool) })]
        bool? EnableAccessTokenIssuance { get; set; }
        /// <summary>
        /// Specifies whether this web application can request an ID token using the OAuth 2.0 implicit flow.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Resources.MSGraph.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies whether this web application can request an ID token using the OAuth 2.0 implicit flow.",
        SerializedName = @"enableIdTokenIssuance",
        PossibleTypes = new [] { typeof(bool) })]
        bool? EnableIdTokenIssuance { get; set; }

    }
    /// implicitGrantSettings
    internal partial interface IMicrosoftGraphImplicitGrantSettingsInternal

    {
        /// <summary>
        /// Specifies whether this web application can request an access token using the OAuth 2.0 implicit flow.
        /// </summary>
        bool? EnableAccessTokenIssuance { get; set; }
        /// <summary>
        /// Specifies whether this web application can request an ID token using the OAuth 2.0 implicit flow.
        /// </summary>
        bool? EnableIdTokenIssuance { get; set; }

    }
}