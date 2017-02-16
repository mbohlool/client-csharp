/* 
 * Kubernetes
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1.5.1-660c2a2
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace io.kubernetes.csharp.Model
{
    /// <summary>
    /// JobSpec describes how the job execution will look like.
    /// </summary>
    [DataContract]
    public partial class V2alpha1JobSpec :  IEquatable<V2alpha1JobSpec>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V2alpha1JobSpec" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected V2alpha1JobSpec() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="V2alpha1JobSpec" /> class.
        /// </summary>
        /// <param name="ActiveDeadlineSeconds">Optional duration in seconds relative to the startTime that the job may be active before the system tries to terminate it; value must be positive integer.</param>
        /// <param name="Completions">Completions specifies the desired number of successfully finished pods the job should be run with.  Setting to nil means that the success of any pod signals the success of all pods, and allows parallelism to have any positive value.  Setting to 1 means that parallelism is limited to 1 and the success of that pod signals the success of the job. More info: http://kubernetes.io/docs/user-guide/jobs.</param>
        /// <param name="ManualSelector">ManualSelector controls generation of pod labels and pod selectors. Leave &#x60;manualSelector&#x60; unset unless you are certain what you are doing. When false or unset, the system pick labels unique to this job and appends those labels to the pod template.  When true, the user is responsible for picking unique labels and specifying the selector.  Failure to pick a unique label may cause this and other jobs to not function correctly.  However, You may see &#x60;manualSelector&#x3D;true&#x60; in jobs that were created with the old &#x60;extensions/v1beta1&#x60; API. More info: http://releases.k8s.io/HEAD/docs/design/selector-generation.md.</param>
        /// <param name="Parallelism">Parallelism specifies the maximum desired number of pods the job should run at any given time. The actual number of pods running in steady state will be less than this number when ((.spec.completions - .status.successful) &lt; .spec.parallelism), i.e. when the work left to do is less than max parallelism. More info: http://kubernetes.io/docs/user-guide/jobs.</param>
        /// <param name="Selector">Selector is a label query over pods that should match the pod count. Normally, the system sets this field for you. More info: http://kubernetes.io/docs/user-guide/labels#label-selectors.</param>
        /// <param name="Template">Template is the object that describes the pod that will be created when executing a job. More info: http://kubernetes.io/docs/user-guide/jobs (required).</param>
        public V2alpha1JobSpec(long? ActiveDeadlineSeconds = default(long?), int? Completions = default(int?), bool? ManualSelector = default(bool?), int? Parallelism = default(int?), UnversionedLabelSelector Selector = default(UnversionedLabelSelector), V1PodTemplateSpec Template = default(V1PodTemplateSpec))
        {
            // to ensure "Template" is required (not null)
            if (Template == null)
            {
                throw new InvalidDataException("Template is a required property for V2alpha1JobSpec and cannot be null");
            }
            else
            {
                this.Template = Template;
            }
            this.ActiveDeadlineSeconds = ActiveDeadlineSeconds;
            this.Completions = Completions;
            this.ManualSelector = ManualSelector;
            this.Parallelism = Parallelism;
            this.Selector = Selector;
        }
        
        /// <summary>
        /// Optional duration in seconds relative to the startTime that the job may be active before the system tries to terminate it; value must be positive integer
        /// </summary>
        /// <value>Optional duration in seconds relative to the startTime that the job may be active before the system tries to terminate it; value must be positive integer</value>
        [DataMember(Name="activeDeadlineSeconds", EmitDefaultValue=false)]
        public long? ActiveDeadlineSeconds { get; set; }
        /// <summary>
        /// Completions specifies the desired number of successfully finished pods the job should be run with.  Setting to nil means that the success of any pod signals the success of all pods, and allows parallelism to have any positive value.  Setting to 1 means that parallelism is limited to 1 and the success of that pod signals the success of the job. More info: http://kubernetes.io/docs/user-guide/jobs
        /// </summary>
        /// <value>Completions specifies the desired number of successfully finished pods the job should be run with.  Setting to nil means that the success of any pod signals the success of all pods, and allows parallelism to have any positive value.  Setting to 1 means that parallelism is limited to 1 and the success of that pod signals the success of the job. More info: http://kubernetes.io/docs/user-guide/jobs</value>
        [DataMember(Name="completions", EmitDefaultValue=false)]
        public int? Completions { get; set; }
        /// <summary>
        /// ManualSelector controls generation of pod labels and pod selectors. Leave &#x60;manualSelector&#x60; unset unless you are certain what you are doing. When false or unset, the system pick labels unique to this job and appends those labels to the pod template.  When true, the user is responsible for picking unique labels and specifying the selector.  Failure to pick a unique label may cause this and other jobs to not function correctly.  However, You may see &#x60;manualSelector&#x3D;true&#x60; in jobs that were created with the old &#x60;extensions/v1beta1&#x60; API. More info: http://releases.k8s.io/HEAD/docs/design/selector-generation.md
        /// </summary>
        /// <value>ManualSelector controls generation of pod labels and pod selectors. Leave &#x60;manualSelector&#x60; unset unless you are certain what you are doing. When false or unset, the system pick labels unique to this job and appends those labels to the pod template.  When true, the user is responsible for picking unique labels and specifying the selector.  Failure to pick a unique label may cause this and other jobs to not function correctly.  However, You may see &#x60;manualSelector&#x3D;true&#x60; in jobs that were created with the old &#x60;extensions/v1beta1&#x60; API. More info: http://releases.k8s.io/HEAD/docs/design/selector-generation.md</value>
        [DataMember(Name="manualSelector", EmitDefaultValue=false)]
        public bool? ManualSelector { get; set; }
        /// <summary>
        /// Parallelism specifies the maximum desired number of pods the job should run at any given time. The actual number of pods running in steady state will be less than this number when ((.spec.completions - .status.successful) &lt; .spec.parallelism), i.e. when the work left to do is less than max parallelism. More info: http://kubernetes.io/docs/user-guide/jobs
        /// </summary>
        /// <value>Parallelism specifies the maximum desired number of pods the job should run at any given time. The actual number of pods running in steady state will be less than this number when ((.spec.completions - .status.successful) &lt; .spec.parallelism), i.e. when the work left to do is less than max parallelism. More info: http://kubernetes.io/docs/user-guide/jobs</value>
        [DataMember(Name="parallelism", EmitDefaultValue=false)]
        public int? Parallelism { get; set; }
        /// <summary>
        /// Selector is a label query over pods that should match the pod count. Normally, the system sets this field for you. More info: http://kubernetes.io/docs/user-guide/labels#label-selectors
        /// </summary>
        /// <value>Selector is a label query over pods that should match the pod count. Normally, the system sets this field for you. More info: http://kubernetes.io/docs/user-guide/labels#label-selectors</value>
        [DataMember(Name="selector", EmitDefaultValue=false)]
        public UnversionedLabelSelector Selector { get; set; }
        /// <summary>
        /// Template is the object that describes the pod that will be created when executing a job. More info: http://kubernetes.io/docs/user-guide/jobs
        /// </summary>
        /// <value>Template is the object that describes the pod that will be created when executing a job. More info: http://kubernetes.io/docs/user-guide/jobs</value>
        [DataMember(Name="template", EmitDefaultValue=false)]
        public V1PodTemplateSpec Template { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V2alpha1JobSpec {\n");
            sb.Append("  ActiveDeadlineSeconds: ").Append(ActiveDeadlineSeconds).Append("\n");
            sb.Append("  Completions: ").Append(Completions).Append("\n");
            sb.Append("  ManualSelector: ").Append(ManualSelector).Append("\n");
            sb.Append("  Parallelism: ").Append(Parallelism).Append("\n");
            sb.Append("  Selector: ").Append(Selector).Append("\n");
            sb.Append("  Template: ").Append(Template).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as V2alpha1JobSpec);
        }

        /// <summary>
        /// Returns true if V2alpha1JobSpec instances are equal
        /// </summary>
        /// <param name="other">Instance of V2alpha1JobSpec to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V2alpha1JobSpec other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ActiveDeadlineSeconds == other.ActiveDeadlineSeconds ||
                    this.ActiveDeadlineSeconds != null &&
                    this.ActiveDeadlineSeconds.Equals(other.ActiveDeadlineSeconds)
                ) && 
                (
                    this.Completions == other.Completions ||
                    this.Completions != null &&
                    this.Completions.Equals(other.Completions)
                ) && 
                (
                    this.ManualSelector == other.ManualSelector ||
                    this.ManualSelector != null &&
                    this.ManualSelector.Equals(other.ManualSelector)
                ) && 
                (
                    this.Parallelism == other.Parallelism ||
                    this.Parallelism != null &&
                    this.Parallelism.Equals(other.Parallelism)
                ) && 
                (
                    this.Selector == other.Selector ||
                    this.Selector != null &&
                    this.Selector.Equals(other.Selector)
                ) && 
                (
                    this.Template == other.Template ||
                    this.Template != null &&
                    this.Template.Equals(other.Template)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.ActiveDeadlineSeconds != null)
                    hash = hash * 59 + this.ActiveDeadlineSeconds.GetHashCode();
                if (this.Completions != null)
                    hash = hash * 59 + this.Completions.GetHashCode();
                if (this.ManualSelector != null)
                    hash = hash * 59 + this.ManualSelector.GetHashCode();
                if (this.Parallelism != null)
                    hash = hash * 59 + this.Parallelism.GetHashCode();
                if (this.Selector != null)
                    hash = hash * 59 + this.Selector.GetHashCode();
                if (this.Template != null)
                    hash = hash * 59 + this.Template.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}