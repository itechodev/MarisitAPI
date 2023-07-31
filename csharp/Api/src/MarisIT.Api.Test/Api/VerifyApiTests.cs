/*
 * MarisIT API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: v6
 * Contact: development@marisit.co.za
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using MarisIT.Api.Client;
using MarisIT.Api.Api;
using MarisIT.Api.Model;

namespace MarisIT.Api.Test
{
    /// <summary>
    ///  Class for testing VerifyApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class VerifyApiTests
    {
        private VerifyApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new VerifyApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of VerifyApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' VerifyApi
            //Assert.IsInstanceOf(typeof(VerifyApi), instance);
        }

        
        /// <summary>
        /// Test CriminalCheck
        /// </summary>
        [Test]
        public void CriminalCheckTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //VerifyVerifyIdRequest verifyVerifyIdRequest = null;
            //var response = instance.CriminalCheck(verifyVerifyIdRequest);
            //Assert.IsInstanceOf(typeof(ApiReturnOfVerifyReferenceResponse), response, "response is ApiReturnOfVerifyReferenceResponse");
        }
        
        /// <summary>
        /// Test CriminalCheckReport
        /// </summary>
        [Test]
        public void CriminalCheckReportTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ReferenceRequest referenceRequest = null;
            //var response = instance.CriminalCheckReport(referenceRequest);
            //Assert.IsInstanceOf(typeof(ApiReturnOfApiReturnOfVerifyResultsCriminalCheckResultView), response, "response is ApiReturnOfApiReturnOfVerifyResultsCriminalCheckResultView");
        }
        
        /// <summary>
        /// Test DeathCertificate
        /// </summary>
        [Test]
        public void DeathCertificateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //VerifyVerifyIdRequest verifyVerifyIdRequest = null;
            //var response = instance.DeathCertificate(verifyVerifyIdRequest);
            //Assert.IsInstanceOf(typeof(ApiReturnOfVerifyReferenceResponse), response, "response is ApiReturnOfVerifyReferenceResponse");
        }
        
        /// <summary>
        /// Test DeathCertificateReport
        /// </summary>
        [Test]
        public void DeathCertificateReportTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ReferenceRequest referenceRequest = null;
            //var response = instance.DeathCertificateReport(referenceRequest);
            //Assert.IsInstanceOf(typeof(ApiReturnOfApiReturnOfVerifyResultsNoModel), response, "response is ApiReturnOfApiReturnOfVerifyResultsNoModel");
        }
        
        /// <summary>
        /// Test DriversLicence
        /// </summary>
        [Test]
        public void DriversLicenceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //VerifyVerifyIdRequest verifyVerifyIdRequest = null;
            //var response = instance.DriversLicence(verifyVerifyIdRequest);
            //Assert.IsInstanceOf(typeof(ApiReturnOfVerifyReferenceResponse), response, "response is ApiReturnOfVerifyReferenceResponse");
        }
        
        /// <summary>
        /// Test DriversLicenceReport
        /// </summary>
        [Test]
        public void DriversLicenceReportTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ReferenceRequest referenceRequest = null;
            //var response = instance.DriversLicenceReport(referenceRequest);
            //Assert.IsInstanceOf(typeof(ApiReturnOfApiReturnOfApiReturnOfVerifyResultsDriversLicenceReportView), response, "response is ApiReturnOfApiReturnOfApiReturnOfVerifyResultsDriversLicenceReportView");
        }
        
        /// <summary>
        /// Test MatricCertificate
        /// </summary>
        [Test]
        public void MatricCertificateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //VerifyMatricCertificateRequest verifyMatricCertificateRequest = null;
            //var response = instance.MatricCertificate(verifyMatricCertificateRequest);
            //Assert.IsInstanceOf(typeof(ApiReturnOfVerifyReferenceResponse), response, "response is ApiReturnOfVerifyReferenceResponse");
        }
        
        /// <summary>
        /// Test MatricCertificateReport
        /// </summary>
        [Test]
        public void MatricCertificateReportTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ReferenceRequest referenceRequest = null;
            //var response = instance.MatricCertificateReport(referenceRequest);
            //Assert.IsInstanceOf(typeof(ApiReturnOfApiReturnOfVerifyResultsMatricVerifyView), response, "response is ApiReturnOfApiReturnOfVerifyResultsMatricVerifyView");
        }
        
    }

}
