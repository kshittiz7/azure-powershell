// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using System.Linq;

    /// <summary>
    /// Execute pipeline activity.
    /// </summary>
    [Newtonsoft.Json.JsonObject("ExecutePipeline")]
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class ExecutePipelineActivity : ControlActivity
    {
        /// <summary>
        /// Initializes a new instance of the ExecutePipelineActivity class.
        /// </summary>
        public ExecutePipelineActivity()
        {
            this.Pipeline = new PipelineReference();
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ExecutePipelineActivity class.
        /// </summary>

        /// <param name="additionalProperties">A pipeline activity.
        /// </param>

        /// <param name="name">Activity name.
        /// </param>

        /// <param name="description">Activity description.
        /// </param>

        /// <param name="state">Activity state. This is an optional property and if not provided, the state
        /// will be Active by default.
        /// Possible values include: &#39;Active&#39;, &#39;Inactive&#39;</param>

        /// <param name="onInactiveMarkAs">Status result of the activity when the state is set to Inactive. This is an
        /// optional property and if not provided when the activity is inactive, the
        /// status will be Succeeded by default.
        /// Possible values include: &#39;Succeeded&#39;, &#39;Failed&#39;, &#39;Skipped&#39;</param>

        /// <param name="dependsOn">Activity depends on condition.
        /// </param>

        /// <param name="userProperties">Activity user properties.
        /// </param>

        /// <param name="policy">Execute pipeline activity policy.
        /// </param>

        /// <param name="pipeline">Pipeline reference.
        /// </param>

        /// <param name="parameters">Pipeline parameters.
        /// </param>

        /// <param name="waitOnCompletion">Defines whether activity execution will wait for the dependent pipeline
        /// execution to finish. Default is false.
        /// </param>
        public ExecutePipelineActivity(string name, PipelineReference pipeline, System.Collections.Generic.IDictionary<string, object> additionalProperties = default(System.Collections.Generic.IDictionary<string, object>), string description = default(string), string state = default(string), string onInactiveMarkAs = default(string), System.Collections.Generic.IList<ActivityDependency> dependsOn = default(System.Collections.Generic.IList<ActivityDependency>), System.Collections.Generic.IList<UserProperty> userProperties = default(System.Collections.Generic.IList<UserProperty>), ExecutePipelineActivityPolicy policy = default(ExecutePipelineActivityPolicy), System.Collections.Generic.IDictionary<string, object> parameters = default(System.Collections.Generic.IDictionary<string, object>), bool? waitOnCompletion = default(bool?))

        : base(name, additionalProperties, description, state, onInactiveMarkAs, dependsOn, userProperties)
        {
            this.Policy = policy;
            this.Pipeline = pipeline;
            this.Parameters = parameters;
            this.WaitOnCompletion = waitOnCompletion;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets execute pipeline activity policy.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "policy")]
        public ExecutePipelineActivityPolicy Policy {get; set; }

        /// <summary>
        /// Gets or sets pipeline reference.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "typeProperties.pipeline")]
        public PipelineReference Pipeline {get; set; }

        /// <summary>
        /// Gets or sets pipeline parameters.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "typeProperties.parameters")]
        public System.Collections.Generic.IDictionary<string, object> Parameters {get; set; }

        /// <summary>
        /// Gets or sets defines whether activity execution will wait for the dependent
        /// pipeline execution to finish. Default is false.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "typeProperties.waitOnCompletion")]
        public bool? WaitOnCompletion {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (this.Pipeline == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Pipeline");
            }

            if (this.Pipeline != null)
            {
                this.Pipeline.Validate();
            }

        }
    }
}