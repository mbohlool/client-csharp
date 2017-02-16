# io.kubernetes.csharp.Model.V1PersistentVolumeClaimStatus
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccessModes** | **List&lt;string&gt;** | AccessModes contains the actual access modes the volume backing the PVC has. More info: http://kubernetes.io/docs/user-guide/persistent-volumes#access-modes-1 | [optional] 
**Capacity** | [**Dictionary&lt;string, ResourceQuantity&gt;**](ResourceQuantity.md) | Represents the actual resources of the underlying volume. | [optional] 
**Phase** | **string** | Phase represents the current phase of PersistentVolumeClaim. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

