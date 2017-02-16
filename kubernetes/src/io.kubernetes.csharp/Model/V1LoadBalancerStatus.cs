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
    /// LoadBalancerStatus represents the status of a load-balancer.
    /// </summary>
    [DataContract]
    public partial class V1LoadBalancerStatus :  IEquatable<V1LoadBalancerStatus>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1LoadBalancerStatus" /> class.
        /// </summary>
        /// <param name="Ingress">Ingress is a list containing ingress points for the load-balancer. Traffic intended for the service should be sent to these ingress points..</param>
        public V1LoadBalancerStatus(List<V1LoadBalancerIngress> Ingress = default(List<V1LoadBalancerIngress>))
        {
            this.Ingress = Ingress;
        }
        
        /// <summary>
        /// Ingress is a list containing ingress points for the load-balancer. Traffic intended for the service should be sent to these ingress points.
        /// </summary>
        /// <value>Ingress is a list containing ingress points for the load-balancer. Traffic intended for the service should be sent to these ingress points.</value>
        [DataMember(Name="ingress", EmitDefaultValue=false)]
        public List<V1LoadBalancerIngress> Ingress { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V1LoadBalancerStatus {\n");
            sb.Append("  Ingress: ").Append(Ingress).Append("\n");
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
            return this.Equals(obj as V1LoadBalancerStatus);
        }

        /// <summary>
        /// Returns true if V1LoadBalancerStatus instances are equal
        /// </summary>
        /// <param name="other">Instance of V1LoadBalancerStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V1LoadBalancerStatus other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Ingress == other.Ingress ||
                    this.Ingress != null &&
                    this.Ingress.SequenceEqual(other.Ingress)
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
                if (this.Ingress != null)
                    hash = hash * 59 + this.Ingress.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
