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
    /// A StatefulSetSpec is the specification of a StatefulSet.
    /// </summary>
    [DataContract]
    public partial class V1beta1StatefulSetSpec :  IEquatable<V1beta1StatefulSetSpec>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1beta1StatefulSetSpec" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected V1beta1StatefulSetSpec() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="V1beta1StatefulSetSpec" /> class.
        /// </summary>
        /// <param name="Replicas">Replicas is the desired number of replicas of the given Template. These are replicas in the sense that they are instantiations of the same Template, but individual replicas also have a consistent identity. If unspecified, defaults to 1..</param>
        /// <param name="Selector">Selector is a label query over pods that should match the replica count. If empty, defaulted to labels on the pod template. More info: http://kubernetes.io/docs/user-guide/labels#label-selectors.</param>
        /// <param name="ServiceName">ServiceName is the name of the service that governs this StatefulSet. This service must exist before the StatefulSet, and is responsible for the network identity of the set. Pods get DNS/hostnames that follow the pattern: pod-specific-string.serviceName.default.svc.cluster.local where \&quot;pod-specific-string\&quot; is managed by the StatefulSet controller. (required).</param>
        /// <param name="Template">Template is the object that describes the pod that will be created if insufficient replicas are detected. Each pod stamped out by the StatefulSet will fulfill this Template, but have a unique identity from the rest of the StatefulSet. (required).</param>
        /// <param name="VolumeClaimTemplates">VolumeClaimTemplates is a list of claims that pods are allowed to reference. The StatefulSet controller is responsible for mapping network identities to claims in a way that maintains the identity of a pod. Every claim in this list must have at least one matching (by name) volumeMount in one container in the template. A claim in this list takes precedence over any volumes in the template, with the same name..</param>
        public V1beta1StatefulSetSpec(int? Replicas = default(int?), UnversionedLabelSelector Selector = default(UnversionedLabelSelector), string ServiceName = default(string), V1PodTemplateSpec Template = default(V1PodTemplateSpec), List<V1PersistentVolumeClaim> VolumeClaimTemplates = default(List<V1PersistentVolumeClaim>))
        {
            // to ensure "ServiceName" is required (not null)
            if (ServiceName == null)
            {
                throw new InvalidDataException("ServiceName is a required property for V1beta1StatefulSetSpec and cannot be null");
            }
            else
            {
                this.ServiceName = ServiceName;
            }
            // to ensure "Template" is required (not null)
            if (Template == null)
            {
                throw new InvalidDataException("Template is a required property for V1beta1StatefulSetSpec and cannot be null");
            }
            else
            {
                this.Template = Template;
            }
            this.Replicas = Replicas;
            this.Selector = Selector;
            this.VolumeClaimTemplates = VolumeClaimTemplates;
        }
        
        /// <summary>
        /// Replicas is the desired number of replicas of the given Template. These are replicas in the sense that they are instantiations of the same Template, but individual replicas also have a consistent identity. If unspecified, defaults to 1.
        /// </summary>
        /// <value>Replicas is the desired number of replicas of the given Template. These are replicas in the sense that they are instantiations of the same Template, but individual replicas also have a consistent identity. If unspecified, defaults to 1.</value>
        [DataMember(Name="replicas", EmitDefaultValue=false)]
        public int? Replicas { get; set; }
        /// <summary>
        /// Selector is a label query over pods that should match the replica count. If empty, defaulted to labels on the pod template. More info: http://kubernetes.io/docs/user-guide/labels#label-selectors
        /// </summary>
        /// <value>Selector is a label query over pods that should match the replica count. If empty, defaulted to labels on the pod template. More info: http://kubernetes.io/docs/user-guide/labels#label-selectors</value>
        [DataMember(Name="selector", EmitDefaultValue=false)]
        public UnversionedLabelSelector Selector { get; set; }
        /// <summary>
        /// ServiceName is the name of the service that governs this StatefulSet. This service must exist before the StatefulSet, and is responsible for the network identity of the set. Pods get DNS/hostnames that follow the pattern: pod-specific-string.serviceName.default.svc.cluster.local where \&quot;pod-specific-string\&quot; is managed by the StatefulSet controller.
        /// </summary>
        /// <value>ServiceName is the name of the service that governs this StatefulSet. This service must exist before the StatefulSet, and is responsible for the network identity of the set. Pods get DNS/hostnames that follow the pattern: pod-specific-string.serviceName.default.svc.cluster.local where \&quot;pod-specific-string\&quot; is managed by the StatefulSet controller.</value>
        [DataMember(Name="serviceName", EmitDefaultValue=false)]
        public string ServiceName { get; set; }
        /// <summary>
        /// Template is the object that describes the pod that will be created if insufficient replicas are detected. Each pod stamped out by the StatefulSet will fulfill this Template, but have a unique identity from the rest of the StatefulSet.
        /// </summary>
        /// <value>Template is the object that describes the pod that will be created if insufficient replicas are detected. Each pod stamped out by the StatefulSet will fulfill this Template, but have a unique identity from the rest of the StatefulSet.</value>
        [DataMember(Name="template", EmitDefaultValue=false)]
        public V1PodTemplateSpec Template { get; set; }
        /// <summary>
        /// VolumeClaimTemplates is a list of claims that pods are allowed to reference. The StatefulSet controller is responsible for mapping network identities to claims in a way that maintains the identity of a pod. Every claim in this list must have at least one matching (by name) volumeMount in one container in the template. A claim in this list takes precedence over any volumes in the template, with the same name.
        /// </summary>
        /// <value>VolumeClaimTemplates is a list of claims that pods are allowed to reference. The StatefulSet controller is responsible for mapping network identities to claims in a way that maintains the identity of a pod. Every claim in this list must have at least one matching (by name) volumeMount in one container in the template. A claim in this list takes precedence over any volumes in the template, with the same name.</value>
        [DataMember(Name="volumeClaimTemplates", EmitDefaultValue=false)]
        public List<V1PersistentVolumeClaim> VolumeClaimTemplates { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V1beta1StatefulSetSpec {\n");
            sb.Append("  Replicas: ").Append(Replicas).Append("\n");
            sb.Append("  Selector: ").Append(Selector).Append("\n");
            sb.Append("  ServiceName: ").Append(ServiceName).Append("\n");
            sb.Append("  Template: ").Append(Template).Append("\n");
            sb.Append("  VolumeClaimTemplates: ").Append(VolumeClaimTemplates).Append("\n");
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
            return this.Equals(obj as V1beta1StatefulSetSpec);
        }

        /// <summary>
        /// Returns true if V1beta1StatefulSetSpec instances are equal
        /// </summary>
        /// <param name="other">Instance of V1beta1StatefulSetSpec to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V1beta1StatefulSetSpec other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
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
                    this.ServiceName == other.ServiceName ||
                    this.ServiceName != null &&
                    this.ServiceName.Equals(other.ServiceName)
                ) && 
                (
                    this.Template == other.Template ||
                    this.Template != null &&
                    this.Template.Equals(other.Template)
                ) && 
                (
                    this.VolumeClaimTemplates == other.VolumeClaimTemplates ||
                    this.VolumeClaimTemplates != null &&
                    this.VolumeClaimTemplates.SequenceEqual(other.VolumeClaimTemplates)
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
                if (this.Replicas != null)
                    hash = hash * 59 + this.Replicas.GetHashCode();
                if (this.Selector != null)
                    hash = hash * 59 + this.Selector.GetHashCode();
                if (this.ServiceName != null)
                    hash = hash * 59 + this.ServiceName.GetHashCode();
                if (this.Template != null)
                    hash = hash * 59 + this.Template.GetHashCode();
                if (this.VolumeClaimTemplates != null)
                    hash = hash * 59 + this.VolumeClaimTemplates.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
