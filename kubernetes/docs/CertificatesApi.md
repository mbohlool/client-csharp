# io.kubernetes.csharp.Api.CertificatesApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAPIGroup**](CertificatesApi.md#getapigroup) | **GET** /apis/certificates.k8s.io/ | 


<a name="getapigroup"></a>
# **GetAPIGroup**
> UnversionedAPIGroup GetAPIGroup ()



get information of a group

### Example
```csharp
using System;
using System.Diagnostics;
using io.kubernetes.csharp.Api;
using io.kubernetes.csharp.Client;
using io.kubernetes.csharp.Model;

namespace Example
{
    public class GetAPIGroupExample
    {
        public void main()
        {
            
            // Configure API key authorization: BearerToken
            Configuration.Default.ApiKey.Add("authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("authorization", "Bearer");

            var apiInstance = new CertificatesApi();

            try
            {
                UnversionedAPIGroup result = apiInstance.GetAPIGroup();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CertificatesApi.GetAPIGroup: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**UnversionedAPIGroup**](UnversionedAPIGroup.md)

### Authorization

[BearerToken](../README.md#BearerToken)

### HTTP request headers

 - **Content-Type**: application/json, application/yaml, application/vnd.kubernetes.protobuf
 - **Accept**: application/json, application/yaml, application/vnd.kubernetes.protobuf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

