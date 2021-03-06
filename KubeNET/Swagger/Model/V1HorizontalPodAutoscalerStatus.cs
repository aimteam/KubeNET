using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace KubeNET.Swagger.Model {

  /// <summary>
  /// current status of a horizontal pod autoscaler
  /// </summary>
  [DataContract]
  public class V1HorizontalPodAutoscalerStatus {
    
    /// <summary>
    /// most recent generation observed by this autoscaler.
    /// </summary>
    /// <value>most recent generation observed by this autoscaler.</value>
    [DataMember(Name="observedGeneration", EmitDefaultValue=false)]
    public int? ObservedGeneration { get; set; }

    
    /// <summary>
    /// last time the HorizontalPodAutoscaler scaled the number of pods; used by the autoscaler to control how often the number of pods is changed.
    /// </summary>
    /// <value>last time the HorizontalPodAutoscaler scaled the number of pods; used by the autoscaler to control how often the number of pods is changed.</value>
    [DataMember(Name="lastScaleTime", EmitDefaultValue=false)]
    public string LastScaleTime { get; set; }

    
    /// <summary>
    /// current number of replicas of pods managed by this autoscaler.
    /// </summary>
    /// <value>current number of replicas of pods managed by this autoscaler.</value>
    [DataMember(Name="currentReplicas", EmitDefaultValue=false)]
    public int? CurrentReplicas { get; set; }

    
    /// <summary>
    /// desired number of replicas of pods managed by this autoscaler.
    /// </summary>
    /// <value>desired number of replicas of pods managed by this autoscaler.</value>
    [DataMember(Name="desiredReplicas", EmitDefaultValue=false)]
    public int? DesiredReplicas { get; set; }

    
    /// <summary>
    /// current average CPU utilization over all pods, represented as a percentage of requested CPU, e.g. 70 means that an average pod is using now 70% of its requested CPU.
    /// </summary>
    /// <value>current average CPU utilization over all pods, represented as a percentage of requested CPU, e.g. 70 means that an average pod is using now 70% of its requested CPU.</value>
    [DataMember(Name="currentCPUUtilizationPercentage", EmitDefaultValue=false)]
    public int? CurrentCPUUtilizationPercentage { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class V1HorizontalPodAutoscalerStatus {\n");
      
      sb.Append("  ObservedGeneration: ").Append(ObservedGeneration).Append("\n");
      
      sb.Append("  LastScaleTime: ").Append(LastScaleTime).Append("\n");
      
      sb.Append("  CurrentReplicas: ").Append(CurrentReplicas).Append("\n");
      
      sb.Append("  DesiredReplicas: ").Append(DesiredReplicas).Append("\n");
      
      sb.Append("  CurrentCPUUtilizationPercentage: ").Append(CurrentCPUUtilizationPercentage).Append("\n");
      
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
