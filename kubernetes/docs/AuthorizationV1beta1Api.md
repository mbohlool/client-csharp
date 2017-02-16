# io.kubernetes.csharp.Api.AuthorizationV1beta1Api

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateNamespacedLocalSubjectAccessReview**](AuthorizationV1beta1Api.md#createnamespacedlocalsubjectaccessreview) | **POST** /apis/authorization.k8s.io/v1beta1/namespaces/{namespace}/localsubjectaccessreviews | 
[**CreateSelfSubjectAccessReview**](AuthorizationV1beta1Api.md#createselfsubjectaccessreview) | **POST** /apis/authorization.k8s.io/v1beta1/selfsubjectaccessreviews | 
[**CreateSubjectAccessReview**](AuthorizationV1beta1Api.md#createsubjectaccessreview) | **POST** /apis/authorization.k8s.io/v1beta1/subjectaccessreviews | 
[**GetAPIResources**](AuthorizationV1beta1Api.md#getapiresources) | **GET** /apis/authorization.k8s.io/v1beta1/ | 


<a name="createnamespacedlocalsubjectaccessreview"></a>
# **CreateNamespacedLocalSubjectAccessReview**
> V1beta1LocalSubjectAccessReview CreateNamespacedLocalSubjectAccessReview (V1beta1LocalSubjectAccessReview body, string _namespace, string pretty = null)



create a LocalSubjectAccessReview

### Example
```csharp
using System;
using System.Diagnostics;
using io.kubernetes.csharp.Api;
using io.kubernetes.csharp.Client;
using io.kubernetes.csharp.Model;

namespace Example
{
    public class CreateNamespacedLocalSubjectAccessReviewExample
    {
        public void main()
        {
            
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new AuthorizationV1beta1Api();
            var body = new V1beta1LocalSubjectAccessReview(); // V1beta1LocalSubjectAccessReview | 
            var _namespace = _namespace_example;  // string | object name and auth scope, such as for teams and projects
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 

            try
            {
                V1beta1LocalSubjectAccessReview result = apiInstance.CreateNamespacedLocalSubjectAccessReview(body, _namespace, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationV1beta1Api.CreateNamespacedLocalSubjectAccessReview: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**V1beta1LocalSubjectAccessReview**](V1beta1LocalSubjectAccessReview.md)|  | 
 **_namespace** | **string**| object name and auth scope, such as for teams and projects | 
 **pretty** | **string**| If &#39;true&#39;, then the output is pretty printed. | [optional] 

### Return type

[**V1beta1LocalSubjectAccessReview**](V1beta1LocalSubjectAccessReview.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createselfsubjectaccessreview"></a>
# **CreateSelfSubjectAccessReview**
> V1beta1SelfSubjectAccessReview CreateSelfSubjectAccessReview (V1beta1SelfSubjectAccessReview body, string pretty = null)



create a SelfSubjectAccessReview

### Example
```csharp
using System;
using System.Diagnostics;
using io.kubernetes.csharp.Api;
using io.kubernetes.csharp.Client;
using io.kubernetes.csharp.Model;

namespace Example
{
    public class CreateSelfSubjectAccessReviewExample
    {
        public void main()
        {
            
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new AuthorizationV1beta1Api();
            var body = new V1beta1SelfSubjectAccessReview(); // V1beta1SelfSubjectAccessReview | 
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 

            try
            {
                V1beta1SelfSubjectAccessReview result = apiInstance.CreateSelfSubjectAccessReview(body, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationV1beta1Api.CreateSelfSubjectAccessReview: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**V1beta1SelfSubjectAccessReview**](V1beta1SelfSubjectAccessReview.md)|  | 
 **pretty** | **string**| If &#39;true&#39;, then the output is pretty printed. | [optional] 

### Return type

[**V1beta1SelfSubjectAccessReview**](V1beta1SelfSubjectAccessReview.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: */*
 - **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createsubjectaccessreview"></a>
# **CreateSubjectAccessReview**
> V1beta1SubjectAccessReview CreateSubjectAccessReview (V1beta1SubjectAccessReview body, string pretty = null)



create a SubjectAccessReview

### Example
```csharp
using System;
using System.Diagnostics;
using io.kubernetes.csharp.Api;
using io.kubernetes.csharp.Client;
using io.kubernetes.csharp.Model;

namespace Example
{
    public class CreateSubjectAccessReviewExample
    {
        public void main()
        {
            
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new AuthorizationV1beta1Api();
            var body = new V1beta1SubjectAccessReview(); // V1beta1SubjectAccessReview | 
            var pretty = pretty_example;  // string | If 'true', then the output is pretty printed. (optional) 

            try
            {
                V1beta1SubjectAccessReview result = apiInstance.CreateSubjectAccessReview(body, pretty);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationV1beta1Api.CreateSubjectAccessReview: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**V1beta1SubjectAccessReview**](V1beta1SubjectAccessReview.md)|  | 
 **pretty** | **string**| If &#39;true&#39;, then the output is pretty printed. | [optional] 

### Return type

[**V1beta1SubjectAccessReview**](V1beta1SubjectAccessReview.md)

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

            var apiInstance = new AuthorizationV1beta1Api();

            try
            {
                UnversionedAPIResourceList result = apiInstance.GetAPIResources();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationV1beta1Api.GetAPIResources: " + e.Message );
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

