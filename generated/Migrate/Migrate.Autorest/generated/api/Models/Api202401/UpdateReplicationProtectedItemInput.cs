// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>Update replication protected item input.</summary>
    public partial class UpdateReplicationProtectedItemInput :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IUpdateReplicationProtectedItemInput,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IUpdateReplicationProtectedItemInputInternal
    {

        /// <summary>
        /// The selected option to enable RDP\SSH on target vm after failover. String value of SrsDataContract.EnableRDPOnTargetOption
        /// enum.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string EnableRdpOnTargetOption { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IUpdateReplicationProtectedItemInputPropertiesInternal)Property).EnableRdpOnTargetOption; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IUpdateReplicationProtectedItemInputPropertiesInternal)Property).EnableRdpOnTargetOption = value ?? null; }

        /// <summary>License type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.LicenseType? LicenseType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IUpdateReplicationProtectedItemInputPropertiesInternal)Property).LicenseType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IUpdateReplicationProtectedItemInputPropertiesInternal)Property).LicenseType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.LicenseType)""); }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IUpdateReplicationProtectedItemInputProperties Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IUpdateReplicationProtectedItemInputInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.UpdateReplicationProtectedItemInputProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProviderSpecificDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IUpdateReplicationProtectedItemProviderInput Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IUpdateReplicationProtectedItemInputInternal.ProviderSpecificDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IUpdateReplicationProtectedItemInputPropertiesInternal)Property).ProviderSpecificDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IUpdateReplicationProtectedItemInputPropertiesInternal)Property).ProviderSpecificDetail = value; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IUpdateReplicationProtectedItemInputProperties _property;

        /// <summary>Update replication protected item properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IUpdateReplicationProtectedItemInputProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.UpdateReplicationProtectedItemInputProperties()); set => this._property = value; }

        /// <summary>The class type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string ProviderSpecificDetailInstanceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IUpdateReplicationProtectedItemInputPropertiesInternal)Property).ProviderSpecificDetailInstanceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IUpdateReplicationProtectedItemInputPropertiesInternal)Property).ProviderSpecificDetailInstanceType = value ?? null; }

        /// <summary>The target availability set Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string RecoveryAvailabilitySetId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IUpdateReplicationProtectedItemInputPropertiesInternal)Property).RecoveryAvailabilitySetId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IUpdateReplicationProtectedItemInputPropertiesInternal)Property).RecoveryAvailabilitySetId = value ?? null; }

        /// <summary>Target Azure VM name given by the user.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string RecoveryAzureVMName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IUpdateReplicationProtectedItemInputPropertiesInternal)Property).RecoveryAzureVMName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IUpdateReplicationProtectedItemInputPropertiesInternal)Property).RecoveryAzureVMName = value ?? null; }

        /// <summary>Target Azure VM size.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string RecoveryAzureVMSize { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IUpdateReplicationProtectedItemInputPropertiesInternal)Property).RecoveryAzureVMSize; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IUpdateReplicationProtectedItemInputPropertiesInternal)Property).RecoveryAzureVMSize = value ?? null; }

        /// <summary>Target Azure Network Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string SelectedRecoveryAzureNetworkId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IUpdateReplicationProtectedItemInputPropertiesInternal)Property).SelectedRecoveryAzureNetworkId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IUpdateReplicationProtectedItemInputPropertiesInternal)Property).SelectedRecoveryAzureNetworkId = value ?? null; }

        /// <summary>
        /// The selected source nic Id which will be used as the primary nic during failover.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string SelectedSourceNicId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IUpdateReplicationProtectedItemInputPropertiesInternal)Property).SelectedSourceNicId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IUpdateReplicationProtectedItemInputPropertiesInternal)Property).SelectedSourceNicId = value ?? null; }

        /// <summary>The Azure Network Id for test failover.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public string SelectedTfoAzureNetworkId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IUpdateReplicationProtectedItemInputPropertiesInternal)Property).SelectedTfoAzureNetworkId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IUpdateReplicationProtectedItemInputPropertiesInternal)Property).SelectedTfoAzureNetworkId = value ?? null; }

        /// <summary>The list of VM nic details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IVMNicInputDetails[] VMNic { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IUpdateReplicationProtectedItemInputPropertiesInternal)Property).VMNic; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IUpdateReplicationProtectedItemInputPropertiesInternal)Property).VMNic = value ?? null /* arrayOf */; }

        /// <summary>Creates an new <see cref="UpdateReplicationProtectedItemInput" /> instance.</summary>
        public UpdateReplicationProtectedItemInput()
        {

        }
    }
    /// Update replication protected item input.
    public partial interface IUpdateReplicationProtectedItemInput :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The selected option to enable RDP\SSH on target vm after failover. String value of SrsDataContract.EnableRDPOnTargetOption
        /// enum.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The selected option to enable RDP\SSH on target vm after failover. String value of SrsDataContract.EnableRDPOnTargetOption enum.",
        SerializedName = @"enableRdpOnTargetOption",
        PossibleTypes = new [] { typeof(string) })]
        string EnableRdpOnTargetOption { get; set; }
        /// <summary>License type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"License type.",
        SerializedName = @"licenseType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.LicenseType) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.LicenseType? LicenseType { get; set; }
        /// <summary>The class type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The class type.",
        SerializedName = @"instanceType",
        PossibleTypes = new [] { typeof(string) })]
        string ProviderSpecificDetailInstanceType { get; set; }
        /// <summary>The target availability set Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The target availability set Id.",
        SerializedName = @"recoveryAvailabilitySetId",
        PossibleTypes = new [] { typeof(string) })]
        string RecoveryAvailabilitySetId { get; set; }
        /// <summary>Target Azure VM name given by the user.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Target Azure VM name given by the user.",
        SerializedName = @"recoveryAzureVMName",
        PossibleTypes = new [] { typeof(string) })]
        string RecoveryAzureVMName { get; set; }
        /// <summary>Target Azure VM size.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Target Azure VM size.",
        SerializedName = @"recoveryAzureVMSize",
        PossibleTypes = new [] { typeof(string) })]
        string RecoveryAzureVMSize { get; set; }
        /// <summary>Target Azure Network Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Target Azure Network Id.",
        SerializedName = @"selectedRecoveryAzureNetworkId",
        PossibleTypes = new [] { typeof(string) })]
        string SelectedRecoveryAzureNetworkId { get; set; }
        /// <summary>
        /// The selected source nic Id which will be used as the primary nic during failover.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The selected source nic Id which will be used as the primary nic during failover.",
        SerializedName = @"selectedSourceNicId",
        PossibleTypes = new [] { typeof(string) })]
        string SelectedSourceNicId { get; set; }
        /// <summary>The Azure Network Id for test failover.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The Azure Network Id for test failover.",
        SerializedName = @"selectedTfoAzureNetworkId",
        PossibleTypes = new [] { typeof(string) })]
        string SelectedTfoAzureNetworkId { get; set; }
        /// <summary>The list of VM nic details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of VM nic details.",
        SerializedName = @"vmNics",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IVMNicInputDetails) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IVMNicInputDetails[] VMNic { get; set; }

    }
    /// Update replication protected item input.
    internal partial interface IUpdateReplicationProtectedItemInputInternal

    {
        /// <summary>
        /// The selected option to enable RDP\SSH on target vm after failover. String value of SrsDataContract.EnableRDPOnTargetOption
        /// enum.
        /// </summary>
        string EnableRdpOnTargetOption { get; set; }
        /// <summary>License type.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.LicenseType? LicenseType { get; set; }
        /// <summary>Update replication protected item properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IUpdateReplicationProtectedItemInputProperties Property { get; set; }
        /// <summary>The provider specific input to update replication protected item.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IUpdateReplicationProtectedItemProviderInput ProviderSpecificDetail { get; set; }
        /// <summary>The class type.</summary>
        string ProviderSpecificDetailInstanceType { get; set; }
        /// <summary>The target availability set Id.</summary>
        string RecoveryAvailabilitySetId { get; set; }
        /// <summary>Target Azure VM name given by the user.</summary>
        string RecoveryAzureVMName { get; set; }
        /// <summary>Target Azure VM size.</summary>
        string RecoveryAzureVMSize { get; set; }
        /// <summary>Target Azure Network Id.</summary>
        string SelectedRecoveryAzureNetworkId { get; set; }
        /// <summary>
        /// The selected source nic Id which will be used as the primary nic during failover.
        /// </summary>
        string SelectedSourceNicId { get; set; }
        /// <summary>The Azure Network Id for test failover.</summary>
        string SelectedTfoAzureNetworkId { get; set; }
        /// <summary>The list of VM nic details.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IVMNicInputDetails[] VMNic { get; set; }

    }
}