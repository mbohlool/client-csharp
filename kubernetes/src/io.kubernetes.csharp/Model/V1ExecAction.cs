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
    /// ExecAction describes a \&quot;run in container\&quot; action.
    /// </summary>
    [DataContract]
    public partial class V1ExecAction :  IEquatable<V1ExecAction>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1ExecAction" /> class.
        /// </summary>
        /// <param name="Command">Command is the command line to execute inside the container, the working directory for the command  is root (&#39;/&#39;) in the container&#39;s filesystem. The command is simply exec&#39;d, it is not run inside a shell, so traditional shell instructions (&#39;|&#39;, etc) won&#39;t work. To use a shell, you need to explicitly call out to that shell. Exit status of 0 is treated as live/healthy and non-zero is unhealthy..</param>
        public V1ExecAction(List<string> Command = default(List<string>))
        {
            this.Command = Command;
        }
        
        /// <summary>
        /// Command is the command line to execute inside the container, the working directory for the command  is root (&#39;/&#39;) in the container&#39;s filesystem. The command is simply exec&#39;d, it is not run inside a shell, so traditional shell instructions (&#39;|&#39;, etc) won&#39;t work. To use a shell, you need to explicitly call out to that shell. Exit status of 0 is treated as live/healthy and non-zero is unhealthy.
        /// </summary>
        /// <value>Command is the command line to execute inside the container, the working directory for the command  is root (&#39;/&#39;) in the container&#39;s filesystem. The command is simply exec&#39;d, it is not run inside a shell, so traditional shell instructions (&#39;|&#39;, etc) won&#39;t work. To use a shell, you need to explicitly call out to that shell. Exit status of 0 is treated as live/healthy and non-zero is unhealthy.</value>
        [DataMember(Name="command", EmitDefaultValue=false)]
        public List<string> Command { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V1ExecAction {\n");
            sb.Append("  Command: ").Append(Command).Append("\n");
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
            return this.Equals(obj as V1ExecAction);
        }

        /// <summary>
        /// Returns true if V1ExecAction instances are equal
        /// </summary>
        /// <param name="other">Instance of V1ExecAction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V1ExecAction other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Command == other.Command ||
                    this.Command != null &&
                    this.Command.SequenceEqual(other.Command)
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
                if (this.Command != null)
                    hash = hash * 59 + this.Command.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}