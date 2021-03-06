# io.kubernetes.csharp.Api.BatchV1Api

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateNamespacedJob**](BatchV1Api.md#createnamespacedjob) | **POST** /apis/batch/v1/namespaces/{namespace}/jobs | 
[**DeleteCollectionNamespacedJob**](BatchV1Api.md#deletecollectionnamespacedjob) | **DELETE** /apis/batch/v1/namespaces/{namespace}/jobs | 
[**DeleteNamespacedJob**](BatchV1Api.md#deletenamespacedjob) | **DELETE** /apis/batch/v1/namespaces/{namespace}/jobs/{name} | 
[**GetAPIResources**](BatchV1Api.md#getapiresources) | **GET** /apis/batch/v1/ | 
[**ListJobForAllNamespaces**](BatchV1Api.md#listjobforallnamespaces) | **GET** /apis/batch/v1/jobs | 
[**ListNamespacedJob**](BatchV1Api.md#listnamespacedjob) | **GET** /apis/batch/v1/namespaces/{namespace}/jobs | 
[**PatchNamespacedJob**](BatchV1Api.md#patchnamespacedjob) | **PATCH** /apis/batch/v1/namespaces/{namespace}/jobs/{name} | 
[**PatchNamespacedJobStatus**](BatchV1Api.md#patchnamespacedjobstatus) | **PATCH** /apis/batch/v1/namespaces/{namespace}/jobs/{name}/status | 
[**ReadNamespacedJob**](BatchV1Api.md#readnamespacedjob) | **GET** /apis/batch/v1/namespaces/{namespace}/jobs/{name} | 
[**ReadNamespacedJobStatus**](BatchV1Api.md#readnamespacedjobstatus) | **GET** /apis/batch/v1/namespaces/{namespace}/jobs/{name}/status | 
[**ReplaceNamespacedJob**](BatchV1Api.md#replacenamespacedjob) | **PUT** /apis/batch/v1/namespaces/{namespace}/jobs/{name} | 
[**ReplaceNamespacedJobStatus**](BatchV1Api.md#replacenamespacedjobstatus) | **PUT** /apis/batch/v1/namespaces/{namespace}/jobs/{name}/status | 


<a name="createnamespacedjob"></a>
# **CreateNamespacedJob**
> V1Job CreateNamespacedJob (string _namespace, V1Job body, string pretty = null)



create a Job

### Example
```csharp
using System;
using System.Diagnostics;
using io.kubernetes.csharp.Api;
using io.kubernetes.csharp.Client;
using io.kubernetes.csharp.Model;

namespace Example
{
    public class CreateNamespacedJobExample
    {
        public void main()
        {
            
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new BatchV1Api();
            var _namespace = _namespace_example;  // string | object name and auth scope, such as for teams and projects
            var body = new V1Job(); // V1Job | 
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 

            try
            {
                V1Job result = apiInstance.CreateNamespacedJob(_namespace, body, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BatchV1Api.CreateNamespacedJob: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **_namespace** | **string**| object name and auth scope, such as for teams and projects | 
 **body** | [**V1Job**](V1Job.md)|  | 
 **pretty** | **string**| If &#39;true&#39;, then the output is pretty printed. | [optional] 

### Return type

[**V1Job**](V1Job.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecollectionnamespacedjob"></a>
# **DeleteCollectionNamespacedJob**
> UnversionedStatus DeleteCollectionNamespacedJob (string _namespace, string pretty = null, string fieldSelector = null, string labelSelector = null, string resourceVersion = null, int? timeoutSeconds = null, bool? watch = null)



delete collection of Job

### Example
```csharp
using System;
using System.Diagnostics;
using io.kubernetes.csharp.Api;
using io.kubernetes.csharp.Client;
using io.kubernetes.csharp.Model;

namespace Example
{
    public class DeleteCollectionNamespacedJobExample
    {
        public void main()
        {
            
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new BatchV1Api();
            var _namespace = _namespace_example;  // string | object name and auth scope, such as for teams and projects
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 
            var fieldSelector = fieldSelector_example;  // string | A selector to restrict the list of returned objects by their fields. Defaults to everything. (optional) 
            var labelSelector = labelSelector_example;  // string | A selector to restrict the list of returned objects by their labels. Defaults to everything. (optional) 
            var resourceVersion = resourceVersion_example;  // string | When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. (optional) 
            var timeoutSeconds = 56;  // int? | Timeout for the list/watch call. (optional) 
            var watch = true;  // bool? | Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion. (optional) 

            try
            {
                UnversionedStatus result = apiInstance.DeleteCollectionNamespacedJob(_namespace, pretty, fieldSelector, labelSelector, resourceVersion, timeoutSeconds, watch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BatchV1Api.DeleteCollectionNamespacedJob: " + e.Message );
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

<a name="deletenamespacedjob"></a>
# **DeleteNamespacedJob**
> UnversionedStatus DeleteNamespacedJob (string name, string _namespace, V1DeleteOptions body, string pretty = null, int? gracePeriodSeconds = null, bool? orphanDependents = null)



delete a Job

### Example
```csharp
using System;
using System.Diagnostics;
using io.kubernetes.csharp.Api;
using io.kubernetes.csharp.Client;
using io.kubernetes.csharp.Model;

namespace Example
{
    public class DeleteNamespacedJobExample
    {
        public void main()
        {
            
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new BatchV1Api();
            var name = name_example;  // string | name of the Job
            var _namespace = _namespace_example;  // string | object name and auth scope, such as for teams and projects
            var body = new V1DeleteOptions(); // V1DeleteOptions | 
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 
            var gracePeriodSeconds = 56;  // int? | The duration in seconds before the object should be deleted. Value must be non-negative integer. The value zero indicates delete immediately. If this value is nil, the default grace period for the specified type will be used. Defaults to a per object value if not specified. zero means delete immediately. (optional) 
            var orphanDependents = true;  // bool? | Should the dependent objects be orphaned. If true/false, the \"orphan\" finalizer will be added to/removed from the object's finalizers list. (optional) 

            try
            {
                UnversionedStatus result = apiInstance.DeleteNamespacedJob(name, _namespace, body, pretty, gracePeriodSeconds, orphanDependents);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BatchV1Api.DeleteNamespacedJob: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| name of the Job | 
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

            var apiInstance = new BatchV1Api();

            try
            {
                UnversionedAPIResourceList result = apiInstance.GetAPIResources();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BatchV1Api.GetAPIResources: " + e.Message );
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

<a name="listjobforallnamespaces"></a>
# **ListJobForAllNamespaces**
> V1JobList ListJobForAllNamespaces (string fieldSelector = null, string labelSelector = null, string pretty = null, string resourceVersion = null, int? timeoutSeconds = null, bool? watch = null)



list or watch objects of kind Job

### Example
```csharp
using System;
using System.Diagnostics;
using io.kubernetes.csharp.Api;
using io.kubernetes.csharp.Client;
using io.kubernetes.csharp.Model;

namespace Example
{
    public class ListJobForAllNamespacesExample
    {
        public void main()
        {
            
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new BatchV1Api();
            var fieldSelector = fieldSelector_example;  // string | A selector to restrict the list of returned objects by their fields. Defaults to everything. (optional) 
            var labelSelector = labelSelector_example;  // string | A selector to restrict the list of returned objects by their labels. Defaults to everything. (optional) 
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 
            var resourceVersion = resourceVersion_example;  // string | When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. (optional) 
            var timeoutSeconds = 56;  // int? | Timeout for the list/watch call. (optional) 
            var watch = true;  // bool? | Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion. (optional) 

            try
            {
                V1JobList result = apiInstance.ListJobForAllNamespaces(fieldSelector, labelSelector, pretty, resourceVersion, timeoutSeconds, watch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BatchV1Api.ListJobForAllNamespaces: " + e.Message );
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

[**V1JobList**](V1JobList.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf, application/json;stream=watch, application/vnd.kubernetes.protobuf;stream=watch

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listnamespacedjob"></a>
# **ListNamespacedJob**
> V1JobList ListNamespacedJob (string _namespace, string pretty = null, string fieldSelector = null, string labelSelector = null, string resourceVersion = null, int? timeoutSeconds = null, bool? watch = null)



list or watch objects of kind Job

### Example
```csharp
using System;
using System.Diagnostics;
using io.kubernetes.csharp.Api;
using io.kubernetes.csharp.Client;
using io.kubernetes.csharp.Model;

namespace Example
{
    public class ListNamespacedJobExample
    {
        public void main()
        {
            
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new BatchV1Api();
            var _namespace = _namespace_example;  // string | object name and auth scope, such as for teams and projects
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 
            var fieldSelector = fieldSelector_example;  // string | A selector to restrict the list of returned objects by their fields. Defaults to everything. (optional) 
            var labelSelector = labelSelector_example;  // string | A selector to restrict the list of returned objects by their labels. Defaults to everything. (optional) 
            var resourceVersion = resourceVersion_example;  // string | When specified with a watch call, shows changes that occur after that particular version of a resource. Defaults to changes from the beginning of history. (optional) 
            var timeoutSeconds = 56;  // int? | Timeout for the list/watch call. (optional) 
            var watch = true;  // bool? | Watch for changes to the described resources and return them as a stream of add, update, and remove notifications. Specify resourceVersion. (optional) 

            try
            {
                V1JobList result = apiInstance.ListNamespacedJob(_namespace, pretty, fieldSelector, labelSelector, resourceVersion, timeoutSeconds, watch);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BatchV1Api.ListNamespacedJob: " + e.Message );
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

[**V1JobList**](V1JobList.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf, application/json;stream=watch, application/vnd.kubernetes.protobuf;stream=watch

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchnamespacedjob"></a>
# **PatchNamespacedJob**
> V1Job PatchNamespacedJob (string name, string _namespace, UnversionedPatch body, string pretty = null)



partially update the specified Job

### Example
```csharp
using System;
using System.Diagnostics;
using io.kubernetes.csharp.Api;
using io.kubernetes.csharp.Client;
using io.kubernetes.csharp.Model;

namespace Example
{
    public class PatchNamespacedJobExample
    {
        public void main()
        {
            
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new BatchV1Api();
            var name = name_example;  // string | name of the Job
            var _namespace = _namespace_example;  // string | object name and auth scope, such as for teams and projects
            var body = new UnversionedPatch(); // UnversionedPatch | 
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 

            try
            {
                V1Job result = apiInstance.PatchNamespacedJob(name, _namespace, body, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BatchV1Api.PatchNamespacedJob: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| name of the Job | 
 **_namespace** | **string**| object name and auth scope, such as for teams and projects | 
 **body** | [**UnversionedPatch**](UnversionedPatch.md)|  | 
 **pretty** | **string**| If &#39;true&#39;, then the output is pretty printed. | [optional] 

### Return type

[**V1Job**](V1Job.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/merge-patch+json, application/strategic-merge-patch+json
 - **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchnamespacedjobstatus"></a>
# **PatchNamespacedJobStatus**
> V1Job PatchNamespacedJobStatus (string name, string _namespace, UnversionedPatch body, string pretty = null)



partially update status of the specified Job

### Example
```csharp
using System;
using System.Diagnostics;
using io.kubernetes.csharp.Api;
using io.kubernetes.csharp.Client;
using io.kubernetes.csharp.Model;

namespace Example
{
    public class PatchNamespacedJobStatusExample
    {
        public void main()
        {
            
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new BatchV1Api();
            var name = name_example;  // string | name of the Job
            var _namespace = _namespace_example;  // string | object name and auth scope, such as for teams and projects
            var body = new UnversionedPatch(); // UnversionedPatch | 
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 

            try
            {
                V1Job result = apiInstance.PatchNamespacedJobStatus(name, _namespace, body, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BatchV1Api.PatchNamespacedJobStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| name of the Job | 
 **_namespace** | **string**| object name and auth scope, such as for teams and projects | 
 **body** | [**UnversionedPatch**](UnversionedPatch.md)|  | 
 **pretty** | **string**| If &#39;true&#39;, then the output is pretty printed. | [optional] 

### Return type

[**V1Job**](V1Job.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/merge-patch+json, application/strategic-merge-patch+json
 - **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readnamespacedjob"></a>
# **ReadNamespacedJob**
> V1Job ReadNamespacedJob (string name, string _namespace, string pretty = null, bool? exact = null, bool? export = null)



read the specified Job

### Example
```csharp
using System;
using System.Diagnostics;
using io.kubernetes.csharp.Api;
using io.kubernetes.csharp.Client;
using io.kubernetes.csharp.Model;

namespace Example
{
    public class ReadNamespacedJobExample
    {
        public void main()
        {
            
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new BatchV1Api();
            var name = name_example;  // string | name of the Job
            var _namespace = _namespace_example;  // string | object name and auth scope, such as for teams and projects
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 
            var exact = true;  // bool? | Should the export be exact.  Exact export maintains cluster-specific fields like 'Namespace' (optional) 
            var export = true;  // bool? | Should this value be exported.  Export strips fields that a user can not specify. (optional) 

            try
            {
                V1Job result = apiInstance.ReadNamespacedJob(name, _namespace, pretty, exact, export);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BatchV1Api.ReadNamespacedJob: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| name of the Job | 
 **_namespace** | **string**| object name and auth scope, such as for teams and projects | 
 **pretty** | **string**| If &#39;true&#39;, then the output is pretty printed. | [optional] 
 **exact** | **bool?**| Should the export be exact.  Exact export maintains cluster-specific fields like &#39;Namespace&#39; | [optional] 
 **export** | **bool?**| Should this value be exported.  Export strips fields that a user can not specify. | [optional] 

### Return type

[**V1Job**](V1Job.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readnamespacedjobstatus"></a>
# **ReadNamespacedJobStatus**
> V1Job ReadNamespacedJobStatus (string name, string _namespace, string pretty = null)



read status of the specified Job

### Example
```csharp
using System;
using System.Diagnostics;
using io.kubernetes.csharp.Api;
using io.kubernetes.csharp.Client;
using io.kubernetes.csharp.Model;

namespace Example
{
    public class ReadNamespacedJobStatusExample
    {
        public void main()
        {
            
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new BatchV1Api();
            var name = name_example;  // string | name of the Job
            var _namespace = _namespace_example;  // string | object name and auth scope, such as for teams and projects
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 

            try
            {
                V1Job result = apiInstance.ReadNamespacedJobStatus(name, _namespace, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BatchV1Api.ReadNamespacedJobStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| name of the Job | 
 **_namespace** | **string**| object name and auth scope, such as for teams and projects | 
 **pretty** | **string**| If &#39;true&#39;, then the output is pretty printed. | [optional] 

### Return type

[**V1Job**](V1Job.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="replacenamespacedjob"></a>
# **ReplaceNamespacedJob**
> V1Job ReplaceNamespacedJob (string name, string _namespace, V1Job body, string pretty = null)



replace the specified Job

### Example
```csharp
using System;
using System.Diagnostics;
using io.kubernetes.csharp.Api;
using io.kubernetes.csharp.Client;
using io.kubernetes.csharp.Model;

namespace Example
{
    public class ReplaceNamespacedJobExample
    {
        public void main()
        {
            
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new BatchV1Api();
            var name = name_example;  // string | name of the Job
            var _namespace = _namespace_example;  // string | object name and auth scope, such as for teams and projects
            var body = new V1Job(); // V1Job | 
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 

            try
            {
                V1Job result = apiInstance.ReplaceNamespacedJob(name, _namespace, body, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BatchV1Api.ReplaceNamespacedJob: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| name of the Job | 
 **_namespace** | **string**| object name and auth scope, such as for teams and projects | 
 **body** | [**V1Job**](V1Job.md)|  | 
 **pretty** | **string**| If &#39;true&#39;, then the output is pretty printed. | [optional] 

### Return type

[**V1Job**](V1Job.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="replacenamespacedjobstatus"></a>
# **ReplaceNamespacedJobStatus**
> V1Job ReplaceNamespacedJobStatus (string name, string _namespace, V1Job body, string pretty = null)



replace status of the specified Job

### Example
```csharp
using System;
using System.Diagnostics;
using io.kubernetes.csharp.Api;
using io.kubernetes.csharp.Client;
using io.kubernetes.csharp.Model;

namespace Example
{
    public class ReplaceNamespacedJobStatusExample
    {
        public void main()
        {
            
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new BatchV1Api();
            var name = name_example;  // string | name of the Job
            var _namespace = _namespace_example;  // string | object name and auth scope, such as for teams and projects
            var body = new V1Job(); // V1Job | 
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 

            try
            {
                V1Job result = apiInstance.ReplaceNamespacedJobStatus(name, _namespace, body, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BatchV1Api.ReplaceNamespacedJobStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| name of the Job | 
 **_namespace** | **string**| object name and auth scope, such as for teams and projects | 
 **body** | [**V1Job**](V1Job.md)|  | 
 **pretty** | **string**| If &#39;true&#39;, then the output is pretty printed. | [optional] 

### Return type

[**V1Job**](V1Job.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

