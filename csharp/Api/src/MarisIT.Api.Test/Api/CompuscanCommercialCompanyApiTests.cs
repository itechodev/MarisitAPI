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
    ///  Class for testing CompuscanCommercialCompanyApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class CompuscanCommercialCompanyApiTests
    {
        private CompuscanCommercialCompanyApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CompuscanCommercialCompanyApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CompuscanCommercialCompanyApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' CompuscanCommercialCompanyApi
            //Assert.IsInstanceOf(typeof(CompuscanCommercialCompanyApi), instance);
        }

        
        /// <summary>
        /// Test CompuscanCompanyResult
        /// </summary>
        [Test]
        public void CompuscanCompanyResultTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ReferenceRequest referenceRequest = null;
            //var response = instance.CompuscanCompanyResult(referenceRequest);
            //Assert.IsInstanceOf(typeof(ApiReturnOfCompuscanCompuscanCompany), response, "response is ApiReturnOfCompuscanCompuscanCompany");
        }
        
        /// <summary>
        /// Test CompuscanCompanySearchByName
        /// </summary>
        [Test]
        public void CompuscanCompanySearchByNameTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CompuscanCompanyNameRequest compuscanCompanyNameRequest = null;
            //var response = instance.CompuscanCompanySearchByName(compuscanCompanyNameRequest);
            //Assert.IsInstanceOf(typeof(ApiReturnOfCompanySearchArray), response, "response is ApiReturnOfCompanySearchArray");
        }
        
        /// <summary>
        /// Test CompuscanCompanySearchByRegistration
        /// </summary>
        [Test]
        public void CompuscanCompanySearchByRegistrationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CompuscanCompanyRegistrationRequest compuscanCompanyRegistrationRequest = null;
            //var response = instance.CompuscanCompanySearchByRegistration(compuscanCompanyRegistrationRequest);
            //Assert.IsInstanceOf(typeof(ApiReturnOfCompanySearchArray), response, "response is ApiReturnOfCompanySearchArray");
        }
        
    }

}