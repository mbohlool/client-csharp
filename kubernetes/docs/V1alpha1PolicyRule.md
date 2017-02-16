# io.kubernetes.csharp.Model.V1alpha1PolicyRule
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ApiGroups** | **List&lt;string&gt;** | APIGroups is the name of the APIGroup that contains the resources.  If multiple API groups are specified, any action requested against one of the enumerated resources in any API group will be allowed. | [optional] 
**AttributeRestrictions** | [**RuntimeRawExtension**](RuntimeRawExtension.md) | AttributeRestrictions will vary depending on what the Authorizer/AuthorizationAttributeBuilder pair supports. If the Authorizer does not recognize how to handle the AttributeRestrictions, the Authorizer should report an error. | [optional] 
**NonResourceURLs** | **List&lt;string&gt;** | NonResourceURLs is a set of partial urls that a user should have access to.  *s are allowed, but only as the full, final step in the path This name is intentionally different than the internal type so that the DefaultConvert works nicely and because the ordering may be different. Since non-resource URLs are not namespaced, this field is only applicable for ClusterRoles referenced from a ClusterRoleBinding. Rules can either apply to API resources (such as \&quot;pods\&quot; or \&quot;secrets\&quot;) or non-resource URL paths (such as \&quot;/api\&quot;),  but not both. | [optional] 
**ResourceNames** | **List&lt;string&gt;** | ResourceNames is an optional white list of names that the rule applies to.  An empty set means that everything is allowed. | [optional] 
**Resources** | **List&lt;string&gt;** | Resources is a list of resources this rule applies to.  ResourceAll represents all resources. | [optional] 
**Verbs** | **List&lt;string&gt;** | Verbs is a list of Verbs that apply to ALL the ResourceKinds and AttributeRestrictions contained in this rule.  VerbAll represents all kinds. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)
