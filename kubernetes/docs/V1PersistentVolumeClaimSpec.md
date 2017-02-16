# io.kubernetes.csharp.Model.V1PersistentVolumeClaimSpec
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccessModes** | **List&lt;string&gt;** | AccessModes contains the desired access modes the volume should have. More info: http://kubernetes.io/docs/user-guide/persistent-volumes#access-modes-1 | [optional] 
**Resources** | [**V1ResourceRequirements**](V1ResourceRequirements.md) | Resources represents the minimum resources the volume should have. More info: http://kubernetes.io/docs/user-guide/persistent-volumes#resources | [optional] 
**Selector** | [**UnversionedLabelSelector**](UnversionedLabelSelector.md) | A label query over volumes to consider for binding. | [optional] 
**VolumeName** | **string** | VolumeName is the binding reference to the PersistentVolume backing this claim. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

