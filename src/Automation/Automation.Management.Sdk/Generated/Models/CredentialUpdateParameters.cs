// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Automation.Models
{
    using System.Linq;

    /// <summary>
    /// The parameters supplied to the Update credential operation.
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class CredentialUpdateParameters
    {
        /// <summary>
        /// Initializes a new instance of the CredentialUpdateParameters class.
        /// </summary>
        public CredentialUpdateParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CredentialUpdateParameters class.
        /// </summary>

        /// <param name="name">Gets or sets the name of the credential.
        /// </param>

        /// <param name="userName">Gets or sets the user name of the credential.
        /// </param>

        /// <param name="password">Gets or sets the password of the credential.
        /// </param>

        /// <param name="description">Gets or sets the description of the credential.
        /// </param>
        public CredentialUpdateParameters(string name = default(string), string userName = default(string), string password = default(string), string description = default(string))

        {
            this.Name = name;
            this.UserName = userName;
            this.Password = password;
            this.Description = description;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets gets or sets the name of the credential.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        public string Name {get; set; }

        /// <summary>
        /// Gets or sets gets or sets the user name of the credential.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.userName")]
        public string UserName {get; set; }

        /// <summary>
        /// Gets or sets gets or sets the password of the credential.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.password")]
        public string Password {get; set; }

        /// <summary>
        /// Gets or sets gets or sets the description of the credential.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.description")]
        public string Description {get; set; }
    }
}