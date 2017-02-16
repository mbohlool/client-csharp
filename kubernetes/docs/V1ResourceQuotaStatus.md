# io.kubernetes.csharp.Model.V1ResourceQuotaStatus
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Hard** | [**Dictionary&lt;string, ResourceQuantity&gt;**](ResourceQuantity.md) | Hard is the set of enforced hard limits for each named resource. More info: http://releases.k8s.io/HEAD/docs/design/admission_control_resource_quota.md#admissioncontrol-plugin-resourcequota | [optional] 
**Used** | [**Dictionary&lt;string, ResourceQuantity&gt;**](ResourceQuantity.md) | Used is the current observed total usage of the resource in the namespace. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

