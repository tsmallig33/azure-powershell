// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Automation.Models
{
    using System.Linq;

    /// <summary>
    /// The parameters supplied to the create or update automation account
    /// operation.
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class AutomationAccountCreateOrUpdateParameters
    {
        /// <summary>
        /// Initializes a new instance of the AutomationAccountCreateOrUpdateParameters class.
        /// </summary>
        public AutomationAccountCreateOrUpdateParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AutomationAccountCreateOrUpdateParameters class.
        /// </summary>

        /// <param name="name">Gets or sets name of the resource.
        /// </param>

        /// <param name="location">Gets or sets the location of the resource.
        /// </param>

        /// <param name="identity">Sets the identity property for automation account
        /// </param>

        /// <param name="tags">Gets or sets the tags attached to the resource.
        /// </param>

        /// <param name="sku">Gets or sets account SKU.
        /// </param>

        /// <param name="encryption">Set the encryption properties for the automation account
        /// </param>

        /// <param name="publicNetworkAccess">Indicates whether traffic on the non-ARM endpoint (Webhook/Agent) is
        /// allowed from the public internet
        /// </param>

        /// <param name="disableLocalAuth">Indicates whether requests using non-AAD authentication are blocked
        /// </param>
        public AutomationAccountCreateOrUpdateParameters(string name = default(string), string location = default(string), Identity identity = default(Identity), System.Collections.Generic.IDictionary<string, string> tags = default(System.Collections.Generic.IDictionary<string, string>), Sku sku = default(Sku), EncryptionProperties encryption = default(EncryptionProperties), bool? publicNetworkAccess = default(bool?), bool? disableLocalAuth = default(bool?))

        {
            this.Name = name;
            this.Location = location;
            this.Identity = identity;
            this.Tags = tags;
            this.Sku = sku;
            this.Encryption = encryption;
            this.PublicNetworkAccess = publicNetworkAccess;
            this.DisableLocalAuth = disableLocalAuth;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets gets or sets name of the resource.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        public string Name {get; set; }

        /// <summary>
        /// Gets or sets gets or sets the location of the resource.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "location")]
        public string Location {get; set; }

        /// <summary>
        /// Gets or sets sets the identity property for automation account
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "identity")]
        public Identity Identity {get; set; }

        /// <summary>
        /// Gets or sets gets or sets the tags attached to the resource.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "tags")]
        public System.Collections.Generic.IDictionary<string, string> Tags {get; set; }

        /// <summary>
        /// Gets or sets gets or sets account SKU.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.sku")]
        public Sku Sku {get; set; }

        /// <summary>
        /// Gets or sets set the encryption properties for the automation account
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.encryption")]
        public EncryptionProperties Encryption {get; set; }

        /// <summary>
        /// Gets or sets indicates whether traffic on the non-ARM endpoint
        /// (Webhook/Agent) is allowed from the public internet
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.publicNetworkAccess")]
        public bool? PublicNetworkAccess {get; set; }

        /// <summary>
        /// Gets or sets indicates whether requests using non-AAD authentication are
        /// blocked
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.disableLocalAuth")]
        public bool? DisableLocalAuth {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {




            if (this.Sku != null)
            {
                this.Sku.Validate();
            }

        }
    }
}