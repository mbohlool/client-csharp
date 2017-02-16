# io.kubernetes.csharp.Api.AutoscalingV1Api

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateNamespacedHorizontalPodAutoscaler**](AutoscalingV1Api.md#createnamespacedhorizontalpodautoscaler) | **POST** /apis/autoscaling/v1/namespaces/{namespace}/horizontalpodautoscalers | 
[**DeleteCollectionNamespacedHorizontalPodAutoscaler**](AutoscalingV1Api.md#deletecollectionnamespacedhorizontalpodautoscaler) | **DELETE** /apis/autoscaling/v1/namespaces/{namespace}/horizontalpodautoscalers | 
[**DeleteNamespacedHorizontalPodAutoscaler**](AutoscalingV1Api.md#deletenamespacedhorizontalpodautoscaler) | **DELETE** /apis/autoscaling/v1/namespaces/{namespace}/horizontalpodautoscalers/{name} | 
[**GetAPIResources**](AutoscalingV1Api.md#getapiresources) | **GET** /apis/autoscaling/v1/ | 
[**ListHorizontalPodAutoscalerForAllNamespaces**](AutoscalingV1Api.md#listhorizontalpodautoscalerforallnamespaces) | **GET** /apis/autoscaling/v1/horizontalpodautoscalers | 
[**ListNamespacedHorizontalPodAutoscaler**](AutoscalingV1Api.md#listnamespacedhorizontalpodautoscaler) | **GET** /apis/autoscaling/v1/namespaces/{namespace}/horizontalpodautoscalers | 
[**PatchNamespacedHorizontalPodAutoscaler**](AutoscalingV1Api.md#patchnamespacedhorizontalpodautoscaler) | **PATCH** /apis/autoscaling/v1/namespaces/{namespace}/horizontalpodautoscalers/{name} | 
[**PatchNamespacedHorizontalPodAutoscalerStatus**](AutoscalingV1Api.md#patchnamespacedhorizontalpodautoscalerstatus) | **PATCH** /apis/autoscaling/v1/namespaces/{namespace}/horizontalpodautoscalers/{name}/status | 
[**ReadNamespacedHorizontalPodAutoscaler**](AutoscalingV1Api.md#readnamespacedhorizontalpodautoscaler) | **GET** /apis/autoscaling/v1/namespaces/{namespace}/horizontalpodautoscalers/{name} | 
[**ReadNamespacedHorizontalPodAutoscalerStatus**](AutoscalingV1Api.md#readnamespacedhorizontalpodautoscalerstatus) | **GET** /apis/autoscaling/v1/namespaces/{namespace}/horizontalpodautoscalers/{name}/status | 
[**ReplaceNamespacedHorizontalPodAutoscaler**](AutoscalingV1Api.md#replacenamespacedhorizontalpodautoscaler) | **PUT** /apis/autoscaling/v1/namespaces/{namespace}/horizontalpodautoscalers/{name} | 
[**ReplaceNamespacedHorizontalPodAutoscalerStatus**](AutoscalingV1Api.md#replacenamespacedhorizontalpodautoscalerstatus) | **PUT** /apis/autoscaling/v1/namespaces/{namespace}/horizontalpodautoscalers/{name}/status | 


<a name="createnamespacedhorizontalpodautoscaler"></a>
# **CreateNamespacedHorizontalPodAutoscaler**
> V1HorizontalPodAutoscaler CreateNamespacedHorizontalPodAutoscaler (string _namespace, V1HorizontalPodAutoscaler body, string pretty = null)



create a HorizontalPodAutoscaler

### Example
```csharp
using System;
using System.Diagnostics;
using io.kubernetes.csharp.Api;
using io.kubernetes.csharp.Client;
using io.kubernetes.csharp.Model;

namespace Example
{
    public class CreateNamespacedHorizontalPodAutoscalerExample
    {
        public void main()
        {
            
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new AutoscalingV1Api();
            var _namespace = _namespace_example;  // string | object name and auth scope, such as for teams and projects
            var body = new V1HorizontalPodAutoscaler(); // V1HorizontalPodAutoscaler | 
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 

            try
            {
                V1HorizontalPodAutoscaler result = apiInstance.CreateNamespacedHorizontalPodAutoscaler(_namespace, body, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AutoscalingV1Api.CreateNamespacedHorizontalPodAutoscaler: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **_namespace** | **string**| object name and auth scope, such as for teams and projects | 
 **body** | [**V1HorizontalPodAutoscaler**](V1HorizontalPodAutoscaler.md)|  | 
 **pretty** | **string**| If &#39;true&#39;, then the output is pretty printed. | [optional] 

### Return type

[**V1HorizontalPodAutoscaler**](V1HorizontalPodAutoscaler.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecollectionnamespacedhorizontalpodautoscaler"></a>
# **DeleteCollectionNamespacedHorizontalPodAutoscaler**
> UnversionedStatus DeleteCollectionNamespacedHorizontalPodAutoscaler (string _namespace, string pretty = null, string fieldSelector = null, string labelSelector = null, string resourceVersion = null, int? timeoutSeconds = null, bool? watch = null)



delete collection of HorizontalPodAutoscaler

### Example
```csharp
using System;
using System.Diagnostics;
using io.kubernetes.csharp.Api;
using io.kubernetes.csharp.Client;
using io.kubernetes.csharp.Model;

namespace Example
{
    public class DeleteCollectionNamespacedHorizontalPodAutoscalerExample
    {
        public void main()
        {
            
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new AutoscalingV1Api();
            var _namespace = _namespace_example;  // string | object name and auth scope, such as for teams and projects
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 
            var fieldSelector = fieldSelector_example;  // string | A selector to restrict the list of returned objects by their fields. Defaults to everything. (optional) 
            var labelSelector = labelSelector_example;  // string | A selector to restrict the list of returned objects by their labels. Defaults to everything. (optional) 
            var resourceVersion = resourceVersion_example;  // string | When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. (optional) 
            var timeoutSeconds = 56;  // int? | Timeout for the list/watch call. (optional) 
            var watch = true;  // bool? | Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion. (optional) 

            try
            {
                UnversionedStatus result = apiInstance.DeleteCollectionNamespacedHorizontalPodAutoscaler(_namespace, pretty, fieldSelector, labelSelector, resourceVersion, timeoutSeconds, watch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AutoscalingV1Api.DeleteCollectionNamespacedHorizontalPodAutoscaler: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **_namespace** | **string**| object name and auth scope, such as for teams and projects | 
 **pretty** | **string**| If &#39;true&#39;, then the output is pretty printed. | [optional] 
 **fieldSelector** | **string**| A selector to restrict the list of returned objects by their fields. Defaults to everything. | [optional] 
 **labelSelector** | **string**| A selector to restrict the list of returned objects by their labels. Defaults to everything. | [optional] 
 **resourceVersion** | **string**| When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. | [optional] 
 **timeoutSeconds** | **int?**| Timeout for the list/watch call. | [optional] 
 **watch** | **bool?**| Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion. | [optional] 

### Return type

[**UnversionedStatus**](UnversionedStatus.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletenamespacedhorizontalpodautoscaler"></a>
# **DeleteNamespacedHorizontalPodAutoscaler**
> UnversionedStatus DeleteNamespacedHorizontalPodAutoscaler (string name, string _namespace, V1DeleteOptions body, string pretty = null, int? gracePeriodSeconds = null, bool? orphanDependents = null)



delete a HorizontalPodAutoscaler

### Example
```csharp
using System;
using System.Diagnostics;
using io.kubernetes.csharp.Api;
using io.kubernetes.csharp.Client;
using io.kubernetes.csharp.Model;

namespace Example
{
    public class DeleteNamespacedHorizontalPodAutoscalerExample
    {
        public void main()
        {
            
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new AutoscalingV1Api();
            var name = name_example;  // string | name of the HorizontalPodAutoscaler
            var _namespace = _namespace_example;  // string | object name and auth scope, such as for teams and projects
            var body = new V1DeleteOptions(); // V1DeleteOptions | 
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 
            var gracePeriodSeconds = 56;  // int? | The duration in seconds before the object should be deleted. Value must be non-negative integer. The value zero indicates delete immediately. If this value is nil, the default grace period for the specified type will be used. Defaults to a per object value if not specified. zero means delete immediately. (optional) 
            var orphanDependents = true;  // bool? | Should the dependent objects be orphaned. If true/false, the \"orphan\" finalizer will be added to/removed from the object's finalizers list. (optional) 

            try
            {
                UnversionedStatus result = apiInstance.DeleteNamespacedHorizontalPodAutoscaler(name, _namespace, body, pretty, gracePeriodSeconds, orphanDependents);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AutoscalingV1Api.DeleteNamespacedHorizontalPodAutoscaler: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| name of the HorizontalPodAutoscaler | 
 **_namespace** | **string**| object name and auth scope, such as for teams and projects | 
 **body** | [**V1DeleteOptions**](V1DeleteOptions.md)|  | 
 **pretty** | **string**| If &#39;true&#39;, then the output is pretty printed. | [optional] 
 **gracePeriodSeconds** | **int?**| The duration in seconds before the object should be deleted. Value must be non-negative integer. The value zero indicates delete immediately. If this value is nil, the default grace period for the specified type will be used. Defaults to a per object value if not specified. zero means delete immediately. | [optional] 
 **orphanDependents** | **bool?**| Should the dependent objects be orphaned. If true/false, the \&quot;orphan\&quot; finalizer will be added to/removed from the object&#39;s finalizers list. | [optional] 

### Return type

[**UnversionedStatus**](UnversionedStatus.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getapiresources"></a>
# **GetAPIResources**
> UnversionedAPIResourceList GetAPIResources ()



get available resources

### Example
```csharp
using System;
using System.Diagnostics;
using io.kubernetes.csharp.Api;
using io.kubernetes.csharp.Client;
using io.kubernetes.csharp.Model;

namespace Example
{
    public class GetAPIResourcesExample
    {
        public void main()
        {
            
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new AutoscalingV1Api();

            try
            {
                UnversionedAPIResourceList result = apiInstance.GetAPIResources();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AutoscalingV1Api.GetAPIResources: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**UnversionedAPIResourceList**](UnversionedAPIResourceList.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: application/json, application/yaml, application/vnd.kubernetes.protobuf
 - **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listhorizontalpodautoscalerforallnamespaces"></a>
# **ListHorizontalPodAutoscalerForAllNamespaces**
> V1HorizontalPodAutoscalerList ListHorizontalPodAutoscalerForAllNamespaces (string fieldSelector = null, string labelSelector = null, string pretty = null, string resourceVersion = null, int? timeoutSeconds = null, bool? watch = null)



list or watch objects of kind HorizontalPodAutoscaler

### Example
```csharp
using System;
using System.Diagnostics;
using io.kubernetes.csharp.Api;
using io.kubernetes.csharp.Client;
using io.kubernetes.csharp.Model;

namespace Example
{
    public class ListHorizontalPodAutoscalerForAllNamespacesExample
    {
        public void main()
        {
            
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new AutoscalingV1Api();
            var fieldSelector = fieldSelector_example;  // string | A selector to restrict the list of returned objects by their fields. Defaults to everything. (optional) 
            var labelSelector = labelSelector_example;  // string | A selector to restrict the list of returned objects by their labels. Defaults to everything. (optional) 
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 
            var resourceVersion = resourceVersion_example;  // string | When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. (optional) 
            var timeoutSeconds = 56;  // int? | Timeout for the list/watch call. (optional) 
            var watch = true;  // bool? | Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion. (optional) 

            try
            {
                V1HorizontalPodAutoscalerList result = apiInstance.ListHorizontalPodAutoscalerForAllNamespaces(fieldSelector, labelSelector, pretty, resourceVersion, timeoutSeconds, watch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AutoscalingV1Api.ListHorizontalPodAutoscalerForAllNamespaces: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **fieldSelector** | **string**| A selector to restrict the list of returned objects by their fields. Defaults to everything. | [optional] 
 **labelSelector** | **string**| A selector to restrict the list of returned objects by their labels. Defaults to everything. | [optional] 
 **pretty** | **string**| If &#39;true&#39;, then the output is pretty printed. | [optional] 
 **resourceVersion** | **string**| When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. | [optional] 
 **timeoutSeconds** | **int?**| Timeout for the list/watch call. | [optional] 
 **watch** | **bool?**| Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion. | [optional] 

### Return type

[**V1HorizontalPodAutoscalerList**](V1HorizontalPodAutoscalerList.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf, application/json;stream=watch, application/vnd.kubernetes.protobuf;stream=watch

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listnamespacedhorizontalpodautoscaler"></a>
# **ListNamespacedHorizontalPodAutoscaler**
> V1HorizontalPodAutoscalerList ListNamespacedHorizontalPodAutoscaler (string _namespace, string pretty = null, string fieldSelector = null, string labelSelector = null, string resourceVersion = null, int? timeoutSeconds = null, bool? watch = null)



list or watch objects of kind HorizontalPodAutoscaler

### Example
```csharp
using System;
using System.Diagnostics;
using io.kubernetes.csharp.Api;
using io.kubernetes.csharp.Client;
using io.kubernetes.csharp.Model;

namespace Example
{
    public class ListNamespacedHorizontalPodAutoscalerExample
    {
        public void main()
        {
            
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new AutoscalingV1Api();
            var _namespace = _namespace_example;  // string | object name and auth scope, such as for teams and projects
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 
            var fieldSelector = fieldSelector_example;  // string | A selector to restrict the list of returned objects by their fields. Defaults to everything. (optional) 
            var labelSelector = labelSelector_example;  // string | A selector to restrict the list of returned objects by their labels. Defaults to everything. (optional) 
            var resourceVersion = resourceVersion_example;  // string | When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. (optional) 
            var timeoutSeconds = 56;  // int? | Timeout for the list/watch call. (optional) 
            var watch = true;  // bool? | Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion. (optional) 

            try
            {
                V1HorizontalPodAutoscalerList result = apiInstance.ListNamespacedHorizontalPodAutoscaler(_namespace, pretty, fieldSelector, labelSelector, resourceVersion, timeoutSeconds, watch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AutoscalingV1Api.ListNamespacedHorizontalPodAutoscaler: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **_namespace** | **string**| object name and auth scope, such as for teams and projects | 
 **pretty** | **string**| If &#39;true&#39;, then the output is pretty printed. | [optional] 
 **fieldSelector** | **string**| A selector to restrict the list of returned objects by their fields. Defaults to everything. | [optional] 
 **labelSelector** | **string**| A selector to restrict the list of returned objects by their labels. Defaults to everything. | [optional] 
 **resourceVersion** | **string**| When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. | [optional] 
 **timeoutSeconds** | **int?**| Timeout for the list/watch call. | [optional] 
 **watch** | **bool?**| Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion. | [optional] 

### Return type

[**V1HorizontalPodAutoscalerList**](V1HorizontalPodAutoscalerList.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf, application/json;stream=watch, application/vnd.kubernetes.protobuf;stream=watch

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchnamespacedhorizontalpodautoscaler"></a>
# **PatchNamespacedHorizontalPodAutoscaler**
> V1HorizontalPodAutoscaler PatchNamespacedHorizontalPodAutoscaler (string name, string _namespace, UnversionedPatch body, string pretty = null)



partially update the specified HorizontalPodAutoscaler

### Example
```csharp
using System;
using System.Diagnostics;
using io.kubernetes.csharp.Api;
using io.kubernetes.csharp.Client;
using io.kubernetes.csharp.Model;

namespace Example
{
    public class PatchNamespacedHorizontalPodAutoscalerExample
    {
        public void main()
        {
            
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new AutoscalingV1Api();
            var name = name_example;  // string | name of the HorizontalPodAutoscaler
            var _namespace = _namespace_example;  // string | object name and auth scope, such as for teams and projects
            var body = new UnversionedPatch(); // UnversionedPatch | 
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 

            try
            {
                V1HorizontalPodAutoscaler result = apiInstance.PatchNamespacedHorizontalPodAutoscaler(name, _namespace, body, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AutoscalingV1Api.PatchNamespacedHorizontalPodAutoscaler: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| name of the HorizontalPodAutoscaler | 
 **_namespace** | **string**| object name and auth scope, such as for teams and projects | 
 **body** | [**UnversionedPatch**](UnversionedPatch.md)|  | 
 **pretty** | **string**| If &#39;true&#39;, then the output is pretty printed. | [optional] 

### Return type

[**V1HorizontalPodAutoscaler**](V1HorizontalPodAutoscaler.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/merge-patch+json, application/strategic-merge-patch+json
 - **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchnamespacedhorizontalpodautoscalerstatus"></a>
# **PatchNamespacedHorizontalPodAutoscalerStatus**
> V1HorizontalPodAutoscaler PatchNamespacedHorizontalPodAutoscalerStatus (string name, string _namespace, UnversionedPatch body, string pretty = null)



partially update status of the specified HorizontalPodAutoscaler

### Example
```csharp
using System;
using System.Diagnostics;
using io.kubernetes.csharp.Api;
using io.kubernetes.csharp.Client;
using io.kubernetes.csharp.Model;

namespace Example
{
    public class PatchNamespacedHorizontalPodAutoscalerStatusExample
    {
        public void main()
        {
            
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new AutoscalingV1Api();
            var name = name_example;  // string | name of the HorizontalPodAutoscaler
            var _namespace = _namespace_example;  // string | object name and auth scope, such as for teams and projects
            var body = new UnversionedPatch(); // UnversionedPatch | 
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 

            try
            {
                V1HorizontalPodAutoscaler result = apiInstance.PatchNamespacedHorizontalPodAutoscalerStatus(name, _namespace, body, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AutoscalingV1Api.PatchNamespacedHorizontalPodAutoscalerStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| name of the HorizontalPodAutoscaler | 
 **_namespace** | **string**| object name and auth scope, such as for teams and projects | 
 **body** | [**UnversionedPatch**](UnversionedPatch.md)|  | 
 **pretty** | **string**| If &#39;true&#39;, then the output is pretty printed. | [optional] 

### Return type

[**V1HorizontalPodAutoscaler**](V1HorizontalPodAutoscaler.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/merge-patch+json, application/strategic-merge-patch+json
 - **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readnamespacedhorizontalpodautoscaler"></a>
# **ReadNamespacedHorizontalPodAutoscaler**
> V1HorizontalPodAutoscaler ReadNamespacedHorizontalPodAutoscaler (string name, string _namespace, string pretty = null, bool? exact = null, bool? export = null)



read the specified HorizontalPodAutoscaler

### Example
```csharp
using System;
using System.Diagnostics;
using io.kubernetes.csharp.Api;
using io.kubernetes.csharp.Client;
using io.kubernetes.csharp.Model;

namespace Example
{
    public class ReadNamespacedHorizontalPodAutoscalerExample
    {
        public void main()
        {
            
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new AutoscalingV1Api();
            var name = name_example;  // string | name of the HorizontalPodAutoscaler
            var _namespace = _namespace_example;  // string | object name and auth scope, such as for teams and projects
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 
            var exact = true;  // bool? | Should the export be exact.  Exact export maintains cluster-specific fields like 'Namespace' (optional) 
            var export = true;  // bool? | Should this value be exported.  Export strips fields that a user can not specify. (optional) 

            try
            {
                V1HorizontalPodAutoscaler result = apiInstance.ReadNamespacedHorizontalPodAutoscaler(name, _namespace, pretty, exact, export);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AutoscalingV1Api.ReadNamespacedHorizontalPodAutoscaler: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| name of the HorizontalPodAutoscaler | 
 **_namespace** | **string**| object name and auth scope, such as for teams and projects | 
 **pretty** | **string**| If &#39;true&#39;, then the output is pretty printed. | [optional] 
 **exact** | **bool?**| Should the export be exact.  Exact export maintains cluster-specific fields like &#39;Namespace&#39; | [optional] 
 **export** | **bool?**| Should this value be exported.  Export strips fields that a user can not specify. | [optional] 

### Return type

[**V1HorizontalPodAutoscaler**](V1HorizontalPodAutoscaler.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readnamespacedhorizontalpodautoscalerstatus"></a>
# **ReadNamespacedHorizontalPodAutoscalerStatus**
> V1HorizontalPodAutoscaler ReadNamespacedHorizontalPodAutoscalerStatus (string name, string _namespace, string pretty = null)



read status of the specified HorizontalPodAutoscaler

### Example
```csharp
using System;
using System.Diagnostics;
using io.kubernetes.csharp.Api;
using io.kubernetes.csharp.Client;
using io.kubernetes.csharp.Model;

namespace Example
{
    public class ReadNamespacedHorizontalPodAutoscalerStatusExample
    {
        public void main()
        {
            
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new AutoscalingV1Api();
            var name = name_example;  // string | name of the HorizontalPodAutoscaler
            var _namespace = _namespace_example;  // string | object name and auth scope, such as for teams and projects
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 

            try
            {
                V1HorizontalPodAutoscaler result = apiInstance.ReadNamespacedHorizontalPodAutoscalerStatus(name, _namespace, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AutoscalingV1Api.ReadNamespacedHorizontalPodAutoscalerStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| name of the HorizontalPodAutoscaler | 
 **_namespace** | **string**| object name and auth scope, such as for teams and projects | 
 **pretty** | **string**| If &#39;true&#39;, then the output is pretty printed. | [optional] 

### Return type

[**V1HorizontalPodAutoscaler**](V1HorizontalPodAutoscaler.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="replacenamespacedhorizontalpodautoscaler"></a>
# **ReplaceNamespacedHorizontalPodAutoscaler**
> V1HorizontalPodAutoscaler ReplaceNamespacedHorizontalPodAutoscaler (string name, string _namespace, V1HorizontalPodAutoscaler body, string pretty = null)



replace the specified HorizontalPodAutoscaler

### Example
```csharp
using System;
using System.Diagnostics;
using io.kubernetes.csharp.Api;
using io.kubernetes.csharp.Client;
using io.kubernetes.csharp.Model;

namespace Example
{
    public class ReplaceNamespacedHorizontalPodAutoscalerExample
    {
        public void main()
        {
            
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new AutoscalingV1Api();
            var name = name_example;  // string | name of the HorizontalPodAutoscaler
            var _namespace = _namespace_example;  // string | object name and auth scope, such as for teams and projects
            var body = new V1HorizontalPodAutoscaler(); // V1HorizontalPodAutoscaler | 
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 

            try
            {
                V1HorizontalPodAutoscaler result = apiInstance.ReplaceNamespacedHorizontalPodAutoscaler(name, _namespace, body, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AutoscalingV1Api.ReplaceNamespacedHorizontalPodAutoscaler: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| name of the HorizontalPodAutoscaler | 
 **_namespace** | **string**| object name and auth scope, such as for teams and projects | 
 **body** | [**V1HorizontalPodAutoscaler**](V1HorizontalPodAutoscaler.md)|  | 
 **pretty** | **string**| If &#39;true&#39;, then the output is pretty printed. | [optional] 

### Return type

[**V1HorizontalPodAutoscaler**](V1HorizontalPodAutoscaler.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="replacenamespacedhorizontalpodautoscalerstatus"></a>
# **ReplaceNamespacedHorizontalPodAutoscalerStatus**
> V1HorizontalPodAutoscaler ReplaceNamespacedHorizontalPodAutoscalerStatus (string name, string _namespace, V1HorizontalPodAutoscaler body, string pretty = null)



replace status of the specified HorizontalPodAutoscaler

### Example
```csharp
using System;
using System.Diagnostics;
using io.kubernetes.csharp.Api;
using io.kubernetes.csharp.Client;
using io.kubernetes.csharp.Model;

namespace Example
{
    public class ReplaceNamespacedHorizontalPodAutoscalerStatusExample
    {
        public void main()
        {
            
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new AutoscalingV1Api();
            var name = name_example;  // string | name of the HorizontalPodAutoscaler
            var _namespace = _namespace_example;  // string | object name and auth scope, such as for teams and projects
            var body = new V1HorizontalPodAutoscaler(); // V1HorizontalPodAutoscaler | 
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 

            try
            {
                V1HorizontalPodAutoscaler result = apiInstance.ReplaceNamespacedHorizontalPodAutoscalerStatus(name, _namespace, body, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AutoscalingV1Api.ReplaceNamespacedHorizontalPodAutoscalerStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| name of the HorizontalPodAutoscaler | 
 **_namespace** | **string**| object name and auth scope, such as for teams and projects | 
 **body** | [**V1HorizontalPodAutoscaler**](V1HorizontalPodAutoscaler.md)|  | 
 **pretty** | **string**| If &#39;true&#39;, then the output is pretty printed. | [optional] 

### Return type

[**V1HorizontalPodAutoscaler**](V1HorizontalPodAutoscaler.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

