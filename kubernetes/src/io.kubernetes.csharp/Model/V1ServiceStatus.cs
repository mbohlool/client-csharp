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
    /// ServiceStatus represents the current status of a service.
    /// </summary>
    [DataContract]
    public partial class V1ServiceStatus :  IEquatable<V1ServiceStatus>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1ServiceStatus" /> class.
        /// </summary>
        /// <param name="LoadBalancer">LoadBalancer contains the current status of the load-balancer, if one is present..</param>
        public V1ServiceStatus(V1LoadBalancerStatus LoadBalancer = default(V1LoadBalancerStatus))
        {
            this.LoadBalancer = LoadBalancer;
        }
        
        /// <summary>
        /// LoadBalancer contains the current status of the load-balancer, if one is present.
        /// </summary>
        /// <value>LoadBalancer contains the current status of the load-balancer, if one is present.</value>
        [DataMember(Name="loadBalancer", EmitDefaultValue=false)]
        public V1LoadBalancerStatus LoadBalancer { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V1ServiceStatus {\n");
            sb.Append("  LoadBalancer: ").Append(LoadBalancer).Append("\n");
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
            return this.Equals(obj as V1ServiceStatus);
        }

        /// <summary>
        /// Returns true if V1ServiceStatus instances are equal
        /// </summary>
        /// <param name="other">Instance of V1ServiceStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V1ServiceStatus other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.LoadBalancer == other.LoadBalancer ||
                    this.LoadBalancer != null &&
                    this.LoadBalancer.Equals(other.LoadBalancer)
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
                if (this.LoadBalancer != null)
                    hash = hash * 59 + this.LoadBalancer.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
