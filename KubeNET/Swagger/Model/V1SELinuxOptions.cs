using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace KubeNET.Swagger.Model {

  /// <summary>
  /// SELinuxOptions are the labels to be applied to the container
  /// </summary>
  [DataContract]
  public class V1SELinuxOptions {
    
    /// <summary>
    /// User is a SELinux user label that applies to the container.
    /// </summary>
    /// <value>User is a SELinux user label that applies to the container.</value>
    [DataMember(Name="user", EmitDefaultValue=false)]
    public string User { get; set; }

    
    /// <summary>
    /// Role is a SELinux role label that applies to the container.
    /// </summary>
    /// <value>Role is a SELinux role label that applies to the container.</value>
    [DataMember(Name="role", EmitDefaultValue=false)]
    public string Role { get; set; }

    
    /// <summary>
    /// Type is a SELinux type label that applies to the container.
    /// </summary>
    /// <value>Type is a SELinux type label that applies to the container.</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    public string Type { get; set; }

    
    /// <summary>
    /// Level is SELinux level label that applies to the container.
    /// </summary>
    /// <value>Level is SELinux level label that applies to the container.</value>
    [DataMember(Name="level", EmitDefaultValue=false)]
    public string Level { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class V1SELinuxOptions {\n");
      
      sb.Append("  User: ").Append(User).Append("\n");
      
      sb.Append("  Role: ").Append(Role).Append("\n");
      
      sb.Append("  Type: ").Append(Type).Append("\n");
      
      sb.Append("  Level: ").Append(Level).Append("\n");
      
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
