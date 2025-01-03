// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.App.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Extensions;

    /// <summary>
    /// The configuration settings of the app registration for providers that have app ids and app secrets
    /// </summary>
    public partial class AppRegistration :
        Microsoft.Azure.PowerShell.Cmdlets.App.Models.IAppRegistration,
        Microsoft.Azure.PowerShell.Cmdlets.App.Models.IAppRegistrationInternal
    {

        /// <summary>Backing field for <see cref="AppId" /> property.</summary>
        private string _appId;

        /// <summary>The App ID of the app used for login.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Owned)]
        public string AppId { get => this._appId; set => this._appId = value; }

        /// <summary>Backing field for <see cref="AppSecretSettingName" /> property.</summary>
        private string _appSecretSettingName;

        /// <summary>The app setting name that contains the app secret.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Owned)]
        public string AppSecretSettingName { get => this._appSecretSettingName; set => this._appSecretSettingName = value; }

        /// <summary>Creates an new <see cref="AppRegistration" /> instance.</summary>
        public AppRegistration()
        {

        }
    }
    /// The configuration settings of the app registration for providers that have app ids and app secrets
    public partial interface IAppRegistration :
        Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.IJsonSerializable
    {
        /// <summary>The App ID of the app used for login.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The App ID of the app used for login.",
        SerializedName = @"appId",
        PossibleTypes = new [] { typeof(string) })]
        string AppId { get; set; }
        /// <summary>The app setting name that contains the app secret.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The app setting name that contains the app secret.",
        SerializedName = @"appSecretSettingName",
        PossibleTypes = new [] { typeof(string) })]
        string AppSecretSettingName { get; set; }

    }
    /// The configuration settings of the app registration for providers that have app ids and app secrets
    internal partial interface IAppRegistrationInternal

    {
        /// <summary>The App ID of the app used for login.</summary>
        string AppId { get; set; }
        /// <summary>The app setting name that contains the app secret.</summary>
        string AppSecretSettingName { get; set; }

    }
}