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
    ///  Class for testing VersionApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class VersionApiTests
    {
        private VersionApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new VersionApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of VersionApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' VersionApi
            //Assert.IsInstanceOfType(typeof(VersionApi), instance, "instance is a VersionApi");
        }

        
        /// <summary>
        /// Test GetCode
        /// </summary>
        [Test]
        public void GetCodeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetCode();
            //Assert.IsInstanceOf<VersionInfo> (response, "response is VersionInfo");
        }
        
    }

}
