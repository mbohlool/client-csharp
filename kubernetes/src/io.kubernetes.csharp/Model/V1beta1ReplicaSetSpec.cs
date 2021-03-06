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
    /// ReplicaSetSpec is the specification of a ReplicaSet.
    /// </summary>
    [DataContract]
    public partial class V1beta1ReplicaSetSpec :  IEquatable<V1beta1ReplicaSetSpec>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1beta1ReplicaSetSpec" /> class.
        /// </summary>
        /// <param name="MinReadySeconds">Minimum number of seconds for which a newly created pod should be ready without any of its container crashing, for it to be considered available. Defaults to 0 (pod will be considered available as soon as it is ready).</param>
        /// <param name="Replicas">Replicas is the number of desired replicas. This is a pointer to distinguish between explicit zero and unspecified. Defaults to 1. More info: http://kubernetes.io/docs/user-guide/replication-controller#what-is-a-replication-controller.</param>
        /// <param name="Selector">Selector is a label query over pods that should match the replica count. If the selector is empty, it is defaulted to the labels present on the pod template. Label keys and values that must match in order to be controlled by this replica set. More info: http://kubernetes.io/docs/user-guide/labels#label-selectors.</param>
        /// <param name="Template">Template is the object that describes the pod that will be created if insufficient replicas are detected. More info: http://kubernetes.io/docs/user-guide/replication-controller#pod-template.</param>
        public V1beta1ReplicaSetSpec(int? MinReadySeconds = default(int?), int? Replicas = default(int?), UnversionedLabelSelector Selector = default(UnversionedLabelSelector), V1PodTemplateSpec Template = default(V1PodTemplateSpec))
        {
            this.MinReadySeconds = MinReadySeconds;
            this.Replicas = Replicas;
            this.Selector = Selector;
            this.Template = Template;
        }
        
        /// <summary>
        /// Minimum number of seconds for which a newly created pod should be ready without any of its container crashing, for it to be considered available. Defaults to 0 (pod will be considered available as soon as it is ready)
        /// </summary>
        /// <value>Minimum number of seconds for which a newly created pod should be ready without any of its container crashing, for it to be considered available. Defaults to 0 (pod will be considered available as soon as it is ready)</value>
        [DataMember(Name="minReadySeconds", EmitDefaultValue=false)]
        public int? MinReadySeconds { get; set; }
        /// <summary>
        /// Replicas is the number of desired replicas. This is a pointer to distinguish between explicit zero and unspecified. Defaults to 1. More info: http://kubernetes.io/docs/user-guide/replication-controller#what-is-a-replication-controller
        /// </summary>
        /// <value>Replicas is the number of desired replicas. This is a pointer to distinguish between explicit zero and unspecified. Defaults to 1. More info: http://kubernetes.io/docs/user-guide/replication-controller#what-is-a-replication-controller</value>
        [DataMember(Name="replicas", EmitDefaultValue=false)]
        public int? Replicas { get; set; }
        /// <summary>
        /// Selector is a label query over pods that should match the replica count. If the selector is empty, it is defaulted to the labels present on the pod template. Label keys and values that must match in order to be controlled by this replica set. More info: http://kubernetes.io/docs/user-guide/labels#label-selectors
        /// </summary>
        /// <value>Selector is a label query over pods that should match the replica count. If the selector is empty, it is defaulted to the labels present on the pod template. Label keys and values that must match in order to be controlled by this replica set. More info: http://kubernetes.io/docs/user-guide/labels#label-selectors</value>
        [DataMember(Name="selector", EmitDefaultValue=false)]
        public UnversionedLabelSelector Selector { get; set; }
        /// <summary>
        /// Template is the object that describes the pod that will be created if insufficient replicas are detected. More info: http://kubernetes.io/docs/user-guide/replication-controller#pod-template
        /// </summary>
        /// <value>Template is the object that describes the pod that will be created if insufficient replicas are detected. More info: http://kubernetes.io/docs/user-guide/replication-controller#pod-template</value>
        [DataMember(Name="template", EmitDefaultValue=false)]
        public V1PodTemplateSpec Template { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V1beta1ReplicaSetSpec {\n");
            sb.Append("  MinReadySeconds: ").Append(MinReadySeconds).Append("\n");
            sb.Append("  Replicas: ").Append(Replicas).Append("\n");
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
            return this.Equals(obj as V1beta1ReplicaSetSpec);
        }

        /// <summary>
        /// Returns true if V1beta1ReplicaSetSpec instances are equal
        /// </summary>
        /// <param name="other">Instance of V1beta1ReplicaSetSpec to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V1beta1ReplicaSetSpec other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.MinReadySeconds == other.MinReadySeconds ||
                    this.MinReadySeconds != null &&
                    this.MinReadySeconds.Equals(other.MinReadySeconds)
                ) && 
                (
                    this.Replicas == other.Replicas ||
                    this.Replicas != null &&
                    this.Replicas.Equals(other.Replicas)
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
                if (this.MinReadySeconds != null)
                    hash = hash * 59 + this.MinReadySeconds.GetHashCode();
                if (this.Replicas != null)
                    hash = hash * 59 + this.Replicas.GetHashCode();
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
