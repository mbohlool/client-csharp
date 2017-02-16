# io.kubernetes.csharp.Model.V1PodCondition
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LastProbeTime** | [**UnversionedTime**](UnversionedTime.md) | Last time we probed the condition. | [optional] 
**LastTransitionTime** | [**UnversionedTime**](UnversionedTime.md) | Last time the condition transitioned from one status to another. | [optional] 
**Message** | **string** | Human-readable message indicating details about last transition. | [optional] 
**Reason** | **string** | Unique, one-word, CamelCase reason for the condition&#39;s last transition. | [optional] 
**Status** | **string** | Status is the status of the condition. Can be True, False, Unknown. More info: http://kubernetes.io/docs/user-guide/pod-states#pod-conditions | 
**Type** | **string** | Type is the type of the condition. Currently only Ready. More info: http://kubernetes.io/docs/user-guide/pod-states#pod-conditions | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

