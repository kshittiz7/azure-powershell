// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Resources.Models
{
    using System.Linq;

    /// <summary>
    /// The Deployment stack validation result details.
    /// </summary>
    public partial class DeploymentStackValidateProperties
    {
        /// <summary>
        /// Initializes a new instance of the DeploymentStackValidateProperties class.
        /// </summary>
        public DeploymentStackValidateProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DeploymentStackValidateProperties class.
        /// </summary>

        /// <param name="actionOnUnmanage">Defines the behavior of resources that are no longer managed after the
        /// Deployment stack is updated or deleted.
        /// </param>

        /// <param name="correlationId">The correlation id of the Deployment stack validate operation. It is in
        /// GUID format and is used for tracing.
        /// </param>

        /// <param name="denySettings">The Deployment stack deny settings.
        /// </param>

        /// <param name="deploymentScope">The Deployment stack deployment scope.
        /// </param>

        /// <param name="description">The Deployment stack validation description.
        /// </param>

        /// <param name="parameters">Deployment parameters.
        /// </param>

        /// <param name="templateLink">The URI of the template.
        /// </param>

        /// <param name="validatedResources">The array of resources that were validated.
        /// </param>
        public DeploymentStackValidateProperties(ActionOnUnmanage actionOnUnmanage = default(ActionOnUnmanage), string correlationId = default(string), DenySettings denySettings = default(DenySettings), string deploymentScope = default(string), string description = default(string), System.Collections.Generic.IDictionary<string, DeploymentParameter> parameters = default(System.Collections.Generic.IDictionary<string, DeploymentParameter>), DeploymentStacksTemplateLink templateLink = default(DeploymentStacksTemplateLink), System.Collections.Generic.IList<ResourceReference> validatedResources = default(System.Collections.Generic.IList<ResourceReference>))

        {
            this.ActionOnUnmanage = actionOnUnmanage;
            this.CorrelationId = correlationId;
            this.DenySettings = denySettings;
            this.DeploymentScope = deploymentScope;
            this.Description = description;
            this.Parameters = parameters;
            this.TemplateLink = templateLink;
            this.ValidatedResources = validatedResources;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets defines the behavior of resources that are no longer managed
        /// after the Deployment stack is updated or deleted.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "actionOnUnmanage")]
        public ActionOnUnmanage ActionOnUnmanage {get; set; }

        /// <summary>
        /// Gets or sets the correlation id of the Deployment stack validate operation.
        /// It is in GUID format and is used for tracing.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "correlationId")]
        public string CorrelationId {get; set; }

        /// <summary>
        /// Gets or sets the Deployment stack deny settings.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "denySettings")]
        public DenySettings DenySettings {get; set; }

        /// <summary>
        /// Gets or sets the Deployment stack deployment scope.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "deploymentScope")]
        public string DeploymentScope {get; set; }

        /// <summary>
        /// Gets or sets the Deployment stack validation description.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "description")]
        public string Description {get; set; }

        /// <summary>
        /// Gets or sets deployment parameters.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "parameters")]
        public System.Collections.Generic.IDictionary<string, DeploymentParameter> Parameters {get; set; }

        /// <summary>
        /// Gets or sets the URI of the template.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "templateLink")]
        public DeploymentStacksTemplateLink TemplateLink {get; set; }

        /// <summary>
        /// Gets or sets the array of resources that were validated.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "validatedResources")]
        public System.Collections.Generic.IList<ResourceReference> ValidatedResources {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.ActionOnUnmanage != null)
            {
                this.ActionOnUnmanage.Validate();
            }

            if (this.DenySettings != null)
            {
                this.DenySettings.Validate();
            }


            if (this.Parameters != null)
            {
                foreach (var valueElement in this.Parameters.Values)
                {
                    if (valueElement != null)
                    {
                        valueElement.Validate();
                    }
                }
            }


        }
    }
}