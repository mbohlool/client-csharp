/* 
 * Kubernetes
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1.5.1-660c2a2
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using io.kubernetes.csharp.Client;
using io.kubernetes.csharp.Api;
using io.kubernetes.csharp.Model;

namespace io.kubernetes.csharp.Test
{
    /// <summary>
    ///  Class for testing CertificatesV1alpha1Api
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class CertificatesV1alpha1ApiTests
    {
        private CertificatesV1alpha1Api instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CertificatesV1alpha1Api();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CertificatesV1alpha1Api
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' CertificatesV1alpha1Api
            //Assert.IsInstanceOfType(typeof(CertificatesV1alpha1Api), instance, "instance is a CertificatesV1alpha1Api");
        }

        
        /// <summary>
        /// Test CreateCertificateSigningRequest
        /// </summary>
        [Test]
        public void CreateCertificateSigningRequestTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //V1alpha1CertificateSigningRequest body = null;
            //string pretty = null;
            //var response = instance.CreateCertificateSigningRequest(body, pretty);
            //Assert.IsInstanceOf<V1alpha1CertificateSigningRequest> (response, "response is V1alpha1CertificateSigningRequest");
        }
        
        /// <summary>
        /// Test DeleteCertificateSigningRequest
        /// </summary>
        [Test]
        public void DeleteCertificateSigningRequestTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //V1DeleteOptions body = null;
            //string pretty = null;
            //int? gracePeriodSeconds = null;
            //bool? orphanDependents = null;
            //var response = instance.DeleteCertificateSigningRequest(name, body, pretty, gracePeriodSeconds, orphanDependents);
            //Assert.IsInstanceOf<UnversionedStatus> (response, "response is UnversionedStatus");
        }
        
        /// <summary>
        /// Test DeleteCollectionCertificateSigningRequest
        /// </summary>
        [Test]
        public void DeleteCollectionCertificateSigningRequestTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string pretty = null;
            //string fieldSelector = null;
            //string labelSelector = null;
            //string resourceVersion = null;
            //int? timeoutSeconds = null;
            //bool? watch = null;
            //var response = instance.DeleteCollectionCertificateSigningRequest(pretty, fieldSelector, labelSelector, resourceVersion, timeoutSeconds, watch);
            //Assert.IsInstanceOf<UnversionedStatus> (response, "response is UnversionedStatus");
        }
        
        /// <summary>
        /// Test GetAPIResources
        /// </summary>
        [Test]
        public void GetAPIResourcesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetAPIResources();
            //Assert.IsInstanceOf<UnversionedAPIResourceList> (response, "response is UnversionedAPIResourceList");
        }
        
        /// <summary>
        /// Test ListCertificateSigningRequest
        /// </summary>
        [Test]
        public void ListCertificateSigningRequestTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string pretty = null;
            //string fieldSelector = null;
            //string labelSelector = null;
            //string resourceVersion = null;
            //int? timeoutSeconds = null;
            //bool? watch = null;
            //var response = instance.ListCertificateSigningRequest(pretty, fieldSelector, labelSelector, resourceVersion, timeoutSeconds, watch);
            //Assert.IsInstanceOf<V1alpha1CertificateSigningRequestList> (response, "response is V1alpha1CertificateSigningRequestList");
        }
        
        /// <summary>
        /// Test PatchCertificateSigningRequest
        /// </summary>
        [Test]
        public void PatchCertificateSigningRequestTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //UnversionedPatch body = null;
            //string pretty = null;
            //var response = instance.PatchCertificateSigningRequest(name, body, pretty);
            //Assert.IsInstanceOf<V1alpha1CertificateSigningRequest> (response, "response is V1alpha1CertificateSigningRequest");
        }
        
        /// <summary>
        /// Test ReadCertificateSigningRequest
        /// </summary>
        [Test]
        public void ReadCertificateSigningRequestTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //string pretty = null;
            //bool? exact = null;
            //bool? export = null;
            //var response = instance.ReadCertificateSigningRequest(name, pretty, exact, export);
            //Assert.IsInstanceOf<V1alpha1CertificateSigningRequest> (response, "response is V1alpha1CertificateSigningRequest");
        }
        
        /// <summary>
        /// Test ReplaceCertificateSigningRequest
        /// </summary>
        [Test]
        public void ReplaceCertificateSigningRequestTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //V1alpha1CertificateSigningRequest body = null;
            //string pretty = null;
            //var response = instance.ReplaceCertificateSigningRequest(name, body, pretty);
            //Assert.IsInstanceOf<V1alpha1CertificateSigningRequest> (response, "response is V1alpha1CertificateSigningRequest");
        }
        
        /// <summary>
        /// Test ReplaceCertificateSigningRequestApproval
        /// </summary>
        [Test]
        public void ReplaceCertificateSigningRequestApprovalTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //V1alpha1CertificateSigningRequest body = null;
            //string name = null;
            //string pretty = null;
            //var response = instance.ReplaceCertificateSigningRequestApproval(body, name, pretty);
            //Assert.IsInstanceOf<V1alpha1CertificateSigningRequest> (response, "response is V1alpha1CertificateSigningRequest");
        }
        
        /// <summary>
        /// Test ReplaceCertificateSigningRequestStatus
        /// </summary>
        [Test]
        public void ReplaceCertificateSigningRequestStatusTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //V1alpha1CertificateSigningRequest body = null;
            //string name = null;
            //string pretty = null;
            //var response = instance.ReplaceCertificateSigningRequestStatus(body, name, pretty);
            //Assert.IsInstanceOf<V1alpha1CertificateSigningRequest> (response, "response is V1alpha1CertificateSigningRequest");
        }
        
    }

}
