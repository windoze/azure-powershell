// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Extensions;

    /// <summary>
    /// If update State is HasPrerequisite, this property contains an array of objects describing prerequisite updates before
    /// installing this update. Otherwise, it is empty.
    /// </summary>
    public partial class UpdatePrerequisite :
        Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IUpdatePrerequisite,
        Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IUpdatePrerequisiteInternal
    {

        /// <summary>Backing field for <see cref="PackageName" /> property.</summary>
        private string _packageName;

        /// <summary>Friendly name of the prerequisite.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Origin(Microsoft.Azure.PowerShell.Cmdlets.StackHCI.PropertyOrigin.Owned)]
        public string PackageName { get => this._packageName; set => this._packageName = value; }

        /// <summary>Backing field for <see cref="UpdateType" /> property.</summary>
        private string _updateType;

        /// <summary>Updatable component type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Origin(Microsoft.Azure.PowerShell.Cmdlets.StackHCI.PropertyOrigin.Owned)]
        public string UpdateType { get => this._updateType; set => this._updateType = value; }

        /// <summary>Backing field for <see cref="Version" /> property.</summary>
        private string _version;

        /// <summary>Version of the prerequisite.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Origin(Microsoft.Azure.PowerShell.Cmdlets.StackHCI.PropertyOrigin.Owned)]
        public string Version { get => this._version; set => this._version = value; }

        /// <summary>Creates an new <see cref="UpdatePrerequisite" /> instance.</summary>
        public UpdatePrerequisite()
        {

        }
    }
    /// If update State is HasPrerequisite, this property contains an array of objects describing prerequisite updates before
    /// installing this update. Otherwise, it is empty.
    public partial interface IUpdatePrerequisite :
        Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.IJsonSerializable
    {
        /// <summary>Friendly name of the prerequisite.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Friendly name of the prerequisite.",
        SerializedName = @"packageName",
        PossibleTypes = new [] { typeof(string) })]
        string PackageName { get; set; }
        /// <summary>Updatable component type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Updatable component type.",
        SerializedName = @"updateType",
        PossibleTypes = new [] { typeof(string) })]
        string UpdateType { get; set; }
        /// <summary>Version of the prerequisite.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Version of the prerequisite.",
        SerializedName = @"version",
        PossibleTypes = new [] { typeof(string) })]
        string Version { get; set; }

    }
    /// If update State is HasPrerequisite, this property contains an array of objects describing prerequisite updates before
    /// installing this update. Otherwise, it is empty.
    internal partial interface IUpdatePrerequisiteInternal

    {
        /// <summary>Friendly name of the prerequisite.</summary>
        string PackageName { get; set; }
        /// <summary>Updatable component type.</summary>
        string UpdateType { get; set; }
        /// <summary>Version of the prerequisite.</summary>
        string Version { get; set; }

    }
}