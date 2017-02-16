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
    /// Event is a report of an event somewhere in the cluster.
    /// </summary>
    [DataContract]
    public partial class V1Event :  IEquatable<V1Event>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1Event" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected V1Event() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="V1Event" /> class.
        /// </summary>
        /// <param name="ApiVersion">APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: http://releases.k8s.io/HEAD/docs/devel/api-conventions.md#resources.</param>
        /// <param name="Count">The number of times this event has occurred..</param>
        /// <param name="FirstTimestamp">The time at which the event was first recorded. (Time of server receipt is in TypeMeta.).</param>
        /// <param name="InvolvedObject">The object that this event is about. (required).</param>
        /// <param name="Kind">Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: http://releases.k8s.io/HEAD/docs/devel/api-conventions.md#types-kinds.</param>
        /// <param name="LastTimestamp">The time at which the most recent occurrence of this event was recorded..</param>
        /// <param name="Message">A human-readable description of the status of this operation..</param>
        /// <param name="Metadata">Standard object&#39;s metadata. More info: http://releases.k8s.io/HEAD/docs/devel/api-conventions.md#metadata (required).</param>
        /// <param name="Reason">This should be a short, machine understandable string that gives the reason for the transition into the object&#39;s current status..</param>
        /// <param name="Source">The component reporting this event. Should be a short machine understandable string..</param>
        /// <param name="Type">Type of this event (Normal, Warning), new types could be added in the future.</param>
        public V1Event(string ApiVersion = default(string), int? Count = default(int?), UnversionedTime FirstTimestamp = default(UnversionedTime), V1ObjectReference InvolvedObject = default(V1ObjectReference), string Kind = default(string), UnversionedTime LastTimestamp = default(UnversionedTime), string Message = default(string), V1ObjectMeta Metadata = default(V1ObjectMeta), string Reason = default(string), V1EventSource Source = default(V1EventSource), string Type = default(string))
        {
            // to ensure "InvolvedObject" is required (not null)
            if (InvolvedObject == null)
            {
                throw new InvalidDataException("InvolvedObject is a required property for V1Event and cannot be null");
            }
            else
            {
                this.InvolvedObject = InvolvedObject;
            }
            // to ensure "Metadata" is required (not null)
            if (Metadata == null)
            {
                throw new InvalidDataException("Metadata is a required property for V1Event and cannot be null");
            }
            else
            {
                this.Metadata = Metadata;
            }
            this.ApiVersion = ApiVersion;
            this.Count = Count;
            this.FirstTimestamp = FirstTimestamp;
            this.Kind = Kind;
            this.LastTimestamp = LastTimestamp;
            this.Message = Message;
            this.Reason = Reason;
            this.Source = Source;
            this.Type = Type;
        }
        
        /// <summary>
        /// APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: http://releases.k8s.io/HEAD/docs/devel/api-conventions.md#resources
        /// </summary>
        /// <value>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: http://releases.k8s.io/HEAD/docs/devel/api-conventions.md#resources</value>
        [DataMember(Name="apiVersion", EmitDefaultValue=false)]
        public string ApiVersion { get; set; }
        /// <summary>
        /// The number of times this event has occurred.
        /// </summary>
        /// <value>The number of times this event has occurred.</value>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public int? Count { get; set; }
        /// <summary>
        /// The time at which the event was first recorded. (Time of server receipt is in TypeMeta.)
        /// </summary>
        /// <value>The time at which the event was first recorded. (Time of server receipt is in TypeMeta.)</value>
        [DataMember(Name="firstTimestamp", EmitDefaultValue=false)]
        public UnversionedTime FirstTimestamp { get; set; }
        /// <summary>
        /// The object that this event is about.
        /// </summary>
        /// <value>The object that this event is about.</value>
        [DataMember(Name="involvedObject", EmitDefaultValue=false)]
        public V1ObjectReference InvolvedObject { get; set; }
        /// <summary>
        /// Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: http://releases.k8s.io/HEAD/docs/devel/api-conventions.md#types-kinds
        /// </summary>
        /// <value>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: http://releases.k8s.io/HEAD/docs/devel/api-conventions.md#types-kinds</value>
        [DataMember(Name="kind", EmitDefaultValue=false)]
        public string Kind { get; set; }
        /// <summary>
        /// The time at which the most recent occurrence of this event was recorded.
        /// </summary>
        /// <value>The time at which the most recent occurrence of this event was recorded.</value>
        [DataMember(Name="lastTimestamp", EmitDefaultValue=false)]
        public UnversionedTime LastTimestamp { get; set; }
        /// <summary>
        /// A human-readable description of the status of this operation.
        /// </summary>
        /// <value>A human-readable description of the status of this operation.</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }
        /// <summary>
        /// Standard object&#39;s metadata. More info: http://releases.k8s.io/HEAD/docs/devel/api-conventions.md#metadata
        /// </summary>
        /// <value>Standard object&#39;s metadata. More info: http://releases.k8s.io/HEAD/docs/devel/api-conventions.md#metadata</value>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public V1ObjectMeta Metadata { get; set; }
        /// <summary>
        /// This should be a short, machine understandable string that gives the reason for the transition into the object&#39;s current status.
        /// </summary>
        /// <value>This should be a short, machine understandable string that gives the reason for the transition into the object&#39;s current status.</value>
        [DataMember(Name="reason", EmitDefaultValue=false)]
        public string Reason { get; set; }
        /// <summary>
        /// The component reporting this event. Should be a short machine understandable string.
        /// </summary>
        /// <value>The component reporting this event. Should be a short machine understandable string.</value>
        [DataMember(Name="source", EmitDefaultValue=false)]
        public V1EventSource Source { get; set; }
        /// <summary>
        /// Type of this event (Normal, Warning), new types could be added in the future
        /// </summary>
        /// <value>Type of this event (Normal, Warning), new types could be added in the future</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V1Event {\n");
            sb.Append("  ApiVersion: ").Append(ApiVersion).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  FirstTimestamp: ").Append(FirstTimestamp).Append("\n");
            sb.Append("  InvolvedObject: ").Append(InvolvedObject).Append("\n");
            sb.Append("  Kind: ").Append(Kind).Append("\n");
            sb.Append("  LastTimestamp: ").Append(LastTimestamp).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
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
            return this.Equals(obj as V1Event);
        }

        /// <summary>
        /// Returns true if V1Event instances are equal
        /// </summary>
        /// <param name="other">Instance of V1Event to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V1Event other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ApiVersion == other.ApiVersion ||
                    this.ApiVersion != null &&
                    this.ApiVersion.Equals(other.ApiVersion)
                ) && 
                (
                    this.Count == other.Count ||
                    this.Count != null &&
                    this.Count.Equals(other.Count)
                ) && 
                (
                    this.FirstTimestamp == other.FirstTimestamp ||
                    this.FirstTimestamp != null &&
                    this.FirstTimestamp.Equals(other.FirstTimestamp)
                ) && 
                (
                    this.InvolvedObject == other.InvolvedObject ||
                    this.InvolvedObject != null &&
                    this.InvolvedObject.Equals(other.InvolvedObject)
                ) && 
                (
                    this.Kind == other.Kind ||
                    this.Kind != null &&
                    this.Kind.Equals(other.Kind)
                ) && 
                (
                    this.LastTimestamp == other.LastTimestamp ||
                    this.LastTimestamp != null &&
                    this.LastTimestamp.Equals(other.LastTimestamp)
                ) && 
                (
                    this.Message == other.Message ||
                    this.Message != null &&
                    this.Message.Equals(other.Message)
                ) && 
                (
                    this.Metadata == other.Metadata ||
                    this.Metadata != null &&
                    this.Metadata.Equals(other.Metadata)
                ) && 
                (
                    this.Reason == other.Reason ||
                    this.Reason != null &&
                    this.Reason.Equals(other.Reason)
                ) && 
                (
                    this.Source == other.Source ||
                    this.Source != null &&
                    this.Source.Equals(other.Source)
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
                if (this.ApiVersion != null)
                    hash = hash * 59 + this.ApiVersion.GetHashCode();
                if (this.Count != null)
                    hash = hash * 59 + this.Count.GetHashCode();
                if (this.FirstTimestamp != null)
                    hash = hash * 59 + this.FirstTimestamp.GetHashCode();
                if (this.InvolvedObject != null)
                    hash = hash * 59 + this.InvolvedObject.GetHashCode();
                if (this.Kind != null)
                    hash = hash * 59 + this.Kind.GetHashCode();
                if (this.LastTimestamp != null)
                    hash = hash * 59 + this.LastTimestamp.GetHashCode();
                if (this.Message != null)
                    hash = hash * 59 + this.Message.GetHashCode();
                if (this.Metadata != null)
                    hash = hash * 59 + this.Metadata.GetHashCode();
                if (this.Reason != null)
                    hash = hash * 59 + this.Reason.GetHashCode();
                if (this.Source != null)
                    hash = hash * 59 + this.Source.GetHashCode();
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
