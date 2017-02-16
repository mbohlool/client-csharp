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
    /// PodCondition contains details for the current condition of this pod.
    /// </summary>
    [DataContract]
    public partial class V1PodCondition :  IEquatable<V1PodCondition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1PodCondition" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected V1PodCondition() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="V1PodCondition" /> class.
        /// </summary>
        /// <param name="LastProbeTime">Last time we probed the condition..</param>
        /// <param name="LastTransitionTime">Last time the condition transitioned from one status to another..</param>
        /// <param name="Message">Human-readable message indicating details about last transition..</param>
        /// <param name="Reason">Unique, one-word, CamelCase reason for the condition&#39;s last transition..</param>
        /// <param name="Status">Status is the status of the condition. Can be True, False, Unknown. More info: http://kubernetes.io/docs/user-guide/pod-states#pod-conditions (required).</param>
        /// <param name="Type">Type is the type of the condition. Currently only Ready. More info: http://kubernetes.io/docs/user-guide/pod-states#pod-conditions (required).</param>
        public V1PodCondition(UnversionedTime LastProbeTime = default(UnversionedTime), UnversionedTime LastTransitionTime = default(UnversionedTime), string Message = default(string), string Reason = default(string), string Status = default(string), string Type = default(string))
        {
            // to ensure "Status" is required (not null)
            if (Status == null)
            {
                throw new InvalidDataException("Status is a required property for V1PodCondition and cannot be null");
            }
            else
            {
                this.Status = Status;
            }
            // to ensure "Type" is required (not null)
            if (Type == null)
            {
                throw new InvalidDataException("Type is a required property for V1PodCondition and cannot be null");
            }
            else
            {
                this.Type = Type;
            }
            this.LastProbeTime = LastProbeTime;
            this.LastTransitionTime = LastTransitionTime;
            this.Message = Message;
            this.Reason = Reason;
        }
        
        /// <summary>
        /// Last time we probed the condition.
        /// </summary>
        /// <value>Last time we probed the condition.</value>
        [DataMember(Name="lastProbeTime", EmitDefaultValue=false)]
        public UnversionedTime LastProbeTime { get; set; }
        /// <summary>
        /// Last time the condition transitioned from one status to another.
        /// </summary>
        /// <value>Last time the condition transitioned from one status to another.</value>
        [DataMember(Name="lastTransitionTime", EmitDefaultValue=false)]
        public UnversionedTime LastTransitionTime { get; set; }
        /// <summary>
        /// Human-readable message indicating details about last transition.
        /// </summary>
        /// <value>Human-readable message indicating details about last transition.</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }
        /// <summary>
        /// Unique, one-word, CamelCase reason for the condition&#39;s last transition.
        /// </summary>
        /// <value>Unique, one-word, CamelCase reason for the condition&#39;s last transition.</value>
        [DataMember(Name="reason", EmitDefaultValue=false)]
        public string Reason { get; set; }
        /// <summary>
        /// Status is the status of the condition. Can be True, False, Unknown. More info: http://kubernetes.io/docs/user-guide/pod-states#pod-conditions
        /// </summary>
        /// <value>Status is the status of the condition. Can be True, False, Unknown. More info: http://kubernetes.io/docs/user-guide/pod-states#pod-conditions</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }
        /// <summary>
        /// Type is the type of the condition. Currently only Ready. More info: http://kubernetes.io/docs/user-guide/pod-states#pod-conditions
        /// </summary>
        /// <value>Type is the type of the condition. Currently only Ready. More info: http://kubernetes.io/docs/user-guide/pod-states#pod-conditions</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V1PodCondition {\n");
            sb.Append("  LastProbeTime: ").Append(LastProbeTime).Append("\n");
            sb.Append("  LastTransitionTime: ").Append(LastTransitionTime).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(obj as V1PodCondition);
        }

        /// <summary>
        /// Returns true if V1PodCondition instances are equal
        /// </summary>
        /// <param name="other">Instance of V1PodCondition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V1PodCondition other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.LastProbeTime == other.LastProbeTime ||
                    this.LastProbeTime != null &&
                    this.LastProbeTime.Equals(other.LastProbeTime)
                ) && 
                (
                    this.LastTransitionTime == other.LastTransitionTime ||
                    this.LastTransitionTime != null &&
                    this.LastTransitionTime.Equals(other.LastTransitionTime)
                ) && 
                (
                    this.Message == other.Message ||
                    this.Message != null &&
                    this.Message.Equals(other.Message)
                ) && 
                (
                    this.Reason == other.Reason ||
                    this.Reason != null &&
                    this.Reason.Equals(other.Reason)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
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
                if (this.LastProbeTime != null)
                    hash = hash * 59 + this.LastProbeTime.GetHashCode();
                if (this.LastTransitionTime != null)
                    hash = hash * 59 + this.LastTransitionTime.GetHashCode();
                if (this.Message != null)
                    hash = hash * 59 + this.Message.GetHashCode();
                if (this.Reason != null)
                    hash = hash * 59 + this.Reason.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
