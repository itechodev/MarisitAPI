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
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = MarisIT.Api.Client.OpenAPIDateConverter;

namespace MarisIT.Api.Model
{
    /// <summary>
    /// 0 &#x3D; Unknown, 1 &#x3D; Success, 2 &#x3D; ProviderEula, 3 &#x3D; ProviderAuthenticationFailed, 4 &#x3D; ProviderAuthorizationFailed, 5 &#x3D; ProviderEmptyCredits, 6 &#x3D; ProviderEmptyData, 7 &#x3D; ProviderUnknown, 8 &#x3D; ProviderInternalError, 9 &#x3D; ProviderRequestInvalid, 10 &#x3D; DataNotFound, 11 &#x3D; DataLackOfUsableTraceOrCredit, 12 &#x3D; DataTooManyResults, 13 &#x3D; DataValidation, 14 &#x3D; DataFailed, 15 &#x3D; WebTimeout, 16 &#x3D; WebInternalError, 17 &#x3D; WebUnkownError, 18 &#x3D; ProviderDeprecated, 19 &#x3D; Error, 20 &#x3D; PermissionDenied, 21 &#x3D; AccountSuspended, 22 &#x3D; AccountLocked, 23 &#x3D; EnquiriesDepleted, 24 &#x3D; ProviderOffline, 24 &#x3D; ApiDenied, 25 &#x3D; ProviderCongested
    /// </summary>
    /// <value>0 &#x3D; Unknown, 1 &#x3D; Success, 2 &#x3D; ProviderEula, 3 &#x3D; ProviderAuthenticationFailed, 4 &#x3D; ProviderAuthorizationFailed, 5 &#x3D; ProviderEmptyCredits, 6 &#x3D; ProviderEmptyData, 7 &#x3D; ProviderUnknown, 8 &#x3D; ProviderInternalError, 9 &#x3D; ProviderRequestInvalid, 10 &#x3D; DataNotFound, 11 &#x3D; DataLackOfUsableTraceOrCredit, 12 &#x3D; DataTooManyResults, 13 &#x3D; DataValidation, 14 &#x3D; DataFailed, 15 &#x3D; WebTimeout, 16 &#x3D; WebInternalError, 17 &#x3D; WebUnkownError, 18 &#x3D; ProviderDeprecated, 19 &#x3D; Error, 20 &#x3D; PermissionDenied, 21 &#x3D; AccountSuspended, 22 &#x3D; AccountLocked, 23 &#x3D; EnquiriesDepleted, 24 &#x3D; ProviderOffline, 24 &#x3D; ApiDenied, 25 &#x3D; ProviderCongested</value>
    
    public enum ApiReturnCode
    {
        /// <summary>
        /// Enum NUMBER_0 for value: 0
        /// </summary>
        NUMBER_0 = 0,

        /// <summary>
        /// Enum NUMBER_1 for value: 1
        /// </summary>
        NUMBER_1 = 1,

        /// <summary>
        /// Enum NUMBER_2 for value: 2
        /// </summary>
        NUMBER_2 = 2,

        /// <summary>
        /// Enum NUMBER_3 for value: 3
        /// </summary>
        NUMBER_3 = 3,

        /// <summary>
        /// Enum NUMBER_4 for value: 4
        /// </summary>
        NUMBER_4 = 4,

        /// <summary>
        /// Enum NUMBER_5 for value: 5
        /// </summary>
        NUMBER_5 = 5,

        /// <summary>
        /// Enum NUMBER_6 for value: 6
        /// </summary>
        NUMBER_6 = 6,

        /// <summary>
        /// Enum NUMBER_7 for value: 7
        /// </summary>
        NUMBER_7 = 7,

        /// <summary>
        /// Enum NUMBER_8 for value: 8
        /// </summary>
        NUMBER_8 = 8,

        /// <summary>
        /// Enum NUMBER_9 for value: 9
        /// </summary>
        NUMBER_9 = 9,

        /// <summary>
        /// Enum NUMBER_10 for value: 10
        /// </summary>
        NUMBER_10 = 10,

        /// <summary>
        /// Enum NUMBER_11 for value: 11
        /// </summary>
        NUMBER_11 = 11,

        /// <summary>
        /// Enum NUMBER_12 for value: 12
        /// </summary>
        NUMBER_12 = 12,

        /// <summary>
        /// Enum NUMBER_13 for value: 13
        /// </summary>
        NUMBER_13 = 13,

        /// <summary>
        /// Enum NUMBER_14 for value: 14
        /// </summary>
        NUMBER_14 = 14,

        /// <summary>
        /// Enum NUMBER_15 for value: 15
        /// </summary>
        NUMBER_15 = 15,

        /// <summary>
        /// Enum NUMBER_16 for value: 16
        /// </summary>
        NUMBER_16 = 16,

        /// <summary>
        /// Enum NUMBER_17 for value: 17
        /// </summary>
        NUMBER_17 = 17,

        /// <summary>
        /// Enum NUMBER_18 for value: 18
        /// </summary>
        NUMBER_18 = 18,

        /// <summary>
        /// Enum NUMBER_19 for value: 19
        /// </summary>
        NUMBER_19 = 19,

        /// <summary>
        /// Enum NUMBER_20 for value: 20
        /// </summary>
        NUMBER_20 = 20,

        /// <summary>
        /// Enum NUMBER_21 for value: 21
        /// </summary>
        NUMBER_21 = 21,

        /// <summary>
        /// Enum NUMBER_22 for value: 22
        /// </summary>
        NUMBER_22 = 22,

        /// <summary>
        /// Enum NUMBER_23 for value: 23
        /// </summary>
        NUMBER_23 = 23,

        /// <summary>
        /// Enum NUMBER_24 for value: 24
        /// </summary>
        NUMBER_24 = 24,

        /// <summary>
        /// Enum NUMBER_25 for value: 25
        /// </summary>
        NUMBER_25 = 25

    }

}
