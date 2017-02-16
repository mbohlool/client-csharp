/* 
 * Kubernetes
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1.5.1-660c2a2
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using io.kubernetes.csharp.Api;
using io.kubernetes.csharp.Model;
using io.kubernetes.csharp.Client;
using System.Reflection;

namespace io.kubernetes.csharp.Test
{
    /// <summary>
    ///  Class for testing V1ResourceQuotaStatus
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class V1ResourceQuotaStatusTests
    {
        // TODO uncomment below to declare an instance variable for V1ResourceQuotaStatus
        //private V1ResourceQuotaStatus instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of V1ResourceQuotaStatus
            //instance = new V1ResourceQuotaStatus();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of V1ResourceQuotaStatus
        /// </summary>
        [Test]
        public void V1ResourceQuotaStatusInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" V1ResourceQuotaStatus
            //Assert.IsInstanceOfType<V1ResourceQuotaStatus> (instance, "variable 'instance' is a V1ResourceQuotaStatus");
        }

        /// <summary>
        /// Test the property 'Hard'
        /// </summary>
        [Test]
        public void HardTest()
        {
            // TODO unit test for the property 'Hard'
        }
        /// <summary>
        /// Test the property 'Used'
        /// </summary>
        [Test]
        public void UsedTest()
        {
            // TODO unit test for the property 'Used'
        }

    }

}