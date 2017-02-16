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
    /// ContainerStatus contains details for the current status of this container.
    /// </summary>
    [DataContract]
    public partial class V1ContainerStatus :  IEquatable<V1ContainerStatus>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1ContainerStatus" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected V1ContainerStatus() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="V1ContainerStatus" /> class.
        /// </summary>
        /// <param name="ContainerID">Container&#39;s ID in the format &#39;docker://&lt;container_id&gt;&#39;. More info: http://kubernetes.io/docs/user-guide/container-environment#container-information.</param>
        /// <param name="Image">The image the container is running. More info: http://kubernetes.io/docs/user-guide/images (required).</param>
        /// <param name="ImageID">ImageID of the container&#39;s image. (required).</param>
        /// <param name="LastState">Details about the container&#39;s last termination condition..</param>
        /// <param name="Name">This must be a DNS_LABEL. Each container in a pod must have a unique name. Cannot be updated. (required).</param>
        /// <param name="Ready">Specifies whether the container has passed its readiness probe. (required).</param>
        /// <param name="RestartCount">The number of times the container has been restarted, currently based on the number of dead containers that have not yet been removed. Note that this is calculated from dead containers. But those containers are subject to garbage collection. This value will get capped at 5 by GC. (required).</param>
        /// <param name="State">Details about the container&#39;s current condition..</param>
        public V1ContainerStatus(string ContainerID = default(string), string Image = default(string), string ImageID = default(string), V1ContainerState LastState = default(V1ContainerState), string Name = default(string), bool? Ready = default(bool?), int? RestartCount = default(int?), V1ContainerState State = default(V1ContainerState))
        {
            // to ensure "Image" is required (not null)
            if (Image == null)
            {
                throw new InvalidDataException("Image is a required property for V1ContainerStatus and cannot be null");
            }
            else
            {
                this.Image = Image;
            }
            // to ensure "ImageID" is required (not null)
            if (ImageID == null)
            {
                throw new InvalidDataException("ImageID is a required property for V1ContainerStatus and cannot be null");
            }
            else
            {
                this.ImageID = ImageID;
            }
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for V1ContainerStatus and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "Ready" is required (not null)
            if (Ready == null)
            {
                throw new InvalidDataException("Ready is a required property for V1ContainerStatus and cannot be null");
            }
            else
            {
                this.Ready = Ready;
            }
            // to ensure "RestartCount" is required (not null)
            if (RestartCount == null)
            {
                throw new InvalidDataException("RestartCount is a required property for V1ContainerStatus and cannot be null");
            }
            else
            {
                this.RestartCount = RestartCount;
            }
            this.ContainerID = ContainerID;
            this.LastState = LastState;
            this.State = State;
        }
        
        /// <summary>
        /// Container&#39;s ID in the format &#39;docker://&lt;container_id&gt;&#39;. More info: http://kubernetes.io/docs/user-guide/container-environment#container-information
        /// </summary>
        /// <value>Container&#39;s ID in the format &#39;docker://&lt;container_id&gt;&#39;. More info: http://kubernetes.io/docs/user-guide/container-environment#container-information</value>
        [DataMember(Name="containerID", EmitDefaultValue=false)]
        public string ContainerID { get; set; }
        /// <summary>
        /// The image the container is running. More info: http://kubernetes.io/docs/user-guide/images
        /// </summary>
        /// <value>The image the container is running. More info: http://kubernetes.io/docs/user-guide/images</value>
        [DataMember(Name="image", EmitDefaultValue=false)]
        public string Image { get; set; }
        /// <summary>
        /// ImageID of the container&#39;s image.
        /// </summary>
        /// <value>ImageID of the container&#39;s image.</value>
        [DataMember(Name="imageID", EmitDefaultValue=false)]
        public string ImageID { get; set; }
        /// <summary>
        /// Details about the container&#39;s last termination condition.
        /// </summary>
        /// <value>Details about the container&#39;s last termination condition.</value>
        [DataMember(Name="lastState", EmitDefaultValue=false)]
        public V1ContainerState LastState { get; set; }
        /// <summary>
        /// This must be a DNS_LABEL. Each container in a pod must have a unique name. Cannot be updated.
        /// </summary>
        /// <value>This must be a DNS_LABEL. Each container in a pod must have a unique name. Cannot be updated.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Specifies whether the container has passed its readiness probe.
        /// </summary>
        /// <value>Specifies whether the container has passed its readiness probe.</value>
        [DataMember(Name="ready", EmitDefaultValue=false)]
        public bool? Ready { get; set; }
        /// <summary>
        /// The number of times the container has been restarted, currently based on the number of dead containers that have not yet been removed. Note that this is calculated from dead containers. But those containers are subject to garbage collection. This value will get capped at 5 by GC.
        /// </summary>
        /// <value>The number of times the container has been restarted, currently based on the number of dead containers that have not yet been removed. Note that this is calculated from dead containers. But those containers are subject to garbage collection. This value will get capped at 5 by GC.</value>
        [DataMember(Name="restartCount", EmitDefaultValue=false)]
        public int? RestartCount { get; set; }
        /// <summary>
        /// Details about the container&#39;s current condition.
        /// </summary>
        /// <value>Details about the container&#39;s current condition.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public V1ContainerState State { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V1ContainerStatus {\n");
            sb.Append("  ContainerID: ").Append(ContainerID).Append("\n");
            sb.Append("  Image: ").Append(Image).Append("\n");
            sb.Append("  ImageID: ").Append(ImageID).Append("\n");
            sb.Append("  LastState: ").Append(LastState).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Ready: ").Append(Ready).Append("\n");
            sb.Append("  RestartCount: ").Append(RestartCount).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
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
            return this.Equals(obj as V1ContainerStatus);
        }

        /// <summary>
        /// Returns true if V1ContainerStatus instances are equal
        /// </summary>
        /// <param name="other">Instance of V1ContainerStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V1ContainerStatus other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ContainerID == other.ContainerID ||
                    this.ContainerID != null &&
                    this.ContainerID.Equals(other.ContainerID)
                ) && 
                (
                    this.Image == other.Image ||
                    this.Image != null &&
                    this.Image.Equals(other.Image)
                ) && 
                (
                    this.ImageID == other.ImageID ||
                    this.ImageID != null &&
                    this.ImageID.Equals(other.ImageID)
                ) && 
                (
                    this.LastState == other.LastState ||
                    this.LastState != null &&
                    this.LastState.Equals(other.LastState)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Ready == other.Ready ||
                    this.Ready != null &&
                    this.Ready.Equals(other.Ready)
                ) && 
                (
                    this.RestartCount == other.RestartCount ||
                    this.RestartCount != null &&
                    this.RestartCount.Equals(other.RestartCount)
                ) && 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
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
                if (this.ContainerID != null)
                    hash = hash * 59 + this.ContainerID.GetHashCode();
                if (this.Image != null)
                    hash = hash * 59 + this.Image.GetHashCode();
                if (this.ImageID != null)
                    hash = hash * 59 + this.ImageID.GetHashCode();
                if (this.LastState != null)
                    hash = hash * 59 + this.LastState.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Ready != null)
                    hash = hash * 59 + this.Ready.GetHashCode();
                if (this.RestartCount != null)
                    hash = hash * 59 + this.RestartCount.GetHashCode();
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
