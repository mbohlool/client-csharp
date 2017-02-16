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

namespace io.kubernetes.csharp.Test
{
    /// <summary>
    ///  Class for testing LogsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class LogsApiTests
    {
        private LogsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new LogsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of LogsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' LogsApi
            //Assert.IsInstanceOfType(typeof(LogsApi), instance, "instance is a LogsApi");
        }

        
        /// <summary>
        /// Test LogFileHandler
        /// </summary>
        [Test]
        public void LogFileHandlerTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string logpath = null;
            //instance.LogFileHandler(logpath);
            
        }
        
        /// <summary>
        /// Test LogFileListHandler
        /// </summary>
        [Test]
        public void LogFileListHandlerTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.LogFileListHandler();
            
        }
        
    }

}