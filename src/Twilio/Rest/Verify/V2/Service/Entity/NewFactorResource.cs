/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
///
/// NewFactorResource
/// </summary>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Types;

namespace Twilio.Rest.Verify.V2.Service.Entity
{

    public class NewFactorResource : Resource
    {
        public sealed class FactorStatusesEnum : StringEnum
        {
            private FactorStatusesEnum(string value) : base(value) {}
            public FactorStatusesEnum() {}
            public static implicit operator FactorStatusesEnum(string value)
            {
                return new FactorStatusesEnum(value);
            }

            public static readonly FactorStatusesEnum Unverified = new FactorStatusesEnum("unverified");
            public static readonly FactorStatusesEnum Verified = new FactorStatusesEnum("verified");
        }

        public sealed class FactorTypesEnum : StringEnum
        {
            private FactorTypesEnum(string value) : base(value) {}
            public FactorTypesEnum() {}
            public static implicit operator FactorTypesEnum(string value)
            {
                return new FactorTypesEnum(value);
            }

            public static readonly FactorTypesEnum Push = new FactorTypesEnum("push");
            public static readonly FactorTypesEnum Totp = new FactorTypesEnum("totp");
        }

        public sealed class NotificationPlatformsEnum : StringEnum
        {
            private NotificationPlatformsEnum(string value) : base(value) {}
            public NotificationPlatformsEnum() {}
            public static implicit operator NotificationPlatformsEnum(string value)
            {
                return new NotificationPlatformsEnum(value);
            }

            public static readonly NotificationPlatformsEnum Apn = new NotificationPlatformsEnum("apn");
            public static readonly NotificationPlatformsEnum Fcm = new NotificationPlatformsEnum("fcm");
        }

        public sealed class TotpAlgorithmsEnum : StringEnum
        {
            private TotpAlgorithmsEnum(string value) : base(value) {}
            public TotpAlgorithmsEnum() {}
            public static implicit operator TotpAlgorithmsEnum(string value)
            {
                return new TotpAlgorithmsEnum(value);
            }

            public static readonly TotpAlgorithmsEnum Sha1 = new TotpAlgorithmsEnum("sha1");
            public static readonly TotpAlgorithmsEnum Sha256 = new TotpAlgorithmsEnum("sha256");
            public static readonly TotpAlgorithmsEnum Sha512 = new TotpAlgorithmsEnum("sha512");
        }

        private static Request BuildCreateRequest(CreateNewFactorOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Verify,
                "/v2/Services/" + options.PathServiceSid + "/Entities/" + options.PathIdentity + "/Factors",
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary>
        /// Create a new Factor for the Entity
        /// </summary>
        /// <param name="options"> Create NewFactor parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of NewFactor </returns>
        public static NewFactorResource Create(CreateNewFactorOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Create a new Factor for the Entity
        /// </summary>
        /// <param name="options"> Create NewFactor parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of NewFactor </returns>
        public static async System.Threading.Tasks.Task<NewFactorResource> CreateAsync(CreateNewFactorOptions options,
                                                                                       ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Create a new Factor for the Entity
        /// </summary>
        /// <param name="pathServiceSid"> Service Sid. </param>
        /// <param name="pathIdentity"> Unique external identifier of the Entity </param>
        /// <param name="friendlyName"> The friendly name of this Factor </param>
        /// <param name="factorType"> The Type of this Factor </param>
        /// <param name="bindingAlg"> The algorithm used when `factor_type` is `push` </param>
        /// <param name="bindingPublicKey"> The public key encoded in Base64 </param>
        /// <param name="configAppId"> The ID that uniquely identifies your app in the Google or Apple store </param>
        /// <param name="configNotificationPlatform"> The transport technology used to generate the Notification Token </param>
        /// <param name="configNotificationToken"> For APN, the device token. For FCM the registration token </param>
        /// <param name="configSdkVersion"> The Verify Push SDK version used to configure the factor </param>
        /// <param name="bindingSecret"> The shared secret in Base32 </param>
        /// <param name="configTimeStep"> How often, in seconds, are TOTP codes generated </param>
        /// <param name="configSkew"> The number of past and future time-steps valid at a given time </param>
        /// <param name="configCodeLength"> Number of digits for generated TOTP codes </param>
        /// <param name="configAlg"> The algorithm used to derive the TOTP codes </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of NewFactor </returns>
        public static NewFactorResource Create(string pathServiceSid,
                                               string pathIdentity,
                                               string friendlyName,
                                               NewFactorResource.FactorTypesEnum factorType,
                                               string bindingAlg = null,
                                               string bindingPublicKey = null,
                                               string configAppId = null,
                                               NewFactorResource.NotificationPlatformsEnum configNotificationPlatform = null,
                                               string configNotificationToken = null,
                                               string configSdkVersion = null,
                                               string bindingSecret = null,
                                               int? configTimeStep = null,
                                               int? configSkew = null,
                                               int? configCodeLength = null,
                                               NewFactorResource.TotpAlgorithmsEnum configAlg = null,
                                               ITwilioRestClient client = null)
        {
            var options = new CreateNewFactorOptions(pathServiceSid, pathIdentity, friendlyName, factorType){BindingAlg = bindingAlg, BindingPublicKey = bindingPublicKey, ConfigAppId = configAppId, ConfigNotificationPlatform = configNotificationPlatform, ConfigNotificationToken = configNotificationToken, ConfigSdkVersion = configSdkVersion, BindingSecret = bindingSecret, ConfigTimeStep = configTimeStep, ConfigSkew = configSkew, ConfigCodeLength = configCodeLength, ConfigAlg = configAlg};
            return Create(options, client);
        }

        #if !NET35
        /// <summary>
        /// Create a new Factor for the Entity
        /// </summary>
        /// <param name="pathServiceSid"> Service Sid. </param>
        /// <param name="pathIdentity"> Unique external identifier of the Entity </param>
        /// <param name="friendlyName"> The friendly name of this Factor </param>
        /// <param name="factorType"> The Type of this Factor </param>
        /// <param name="bindingAlg"> The algorithm used when `factor_type` is `push` </param>
        /// <param name="bindingPublicKey"> The public key encoded in Base64 </param>
        /// <param name="configAppId"> The ID that uniquely identifies your app in the Google or Apple store </param>
        /// <param name="configNotificationPlatform"> The transport technology used to generate the Notification Token </param>
        /// <param name="configNotificationToken"> For APN, the device token. For FCM the registration token </param>
        /// <param name="configSdkVersion"> The Verify Push SDK version used to configure the factor </param>
        /// <param name="bindingSecret"> The shared secret in Base32 </param>
        /// <param name="configTimeStep"> How often, in seconds, are TOTP codes generated </param>
        /// <param name="configSkew"> The number of past and future time-steps valid at a given time </param>
        /// <param name="configCodeLength"> Number of digits for generated TOTP codes </param>
        /// <param name="configAlg"> The algorithm used to derive the TOTP codes </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of NewFactor </returns>
        public static async System.Threading.Tasks.Task<NewFactorResource> CreateAsync(string pathServiceSid,
                                                                                       string pathIdentity,
                                                                                       string friendlyName,
                                                                                       NewFactorResource.FactorTypesEnum factorType,
                                                                                       string bindingAlg = null,
                                                                                       string bindingPublicKey = null,
                                                                                       string configAppId = null,
                                                                                       NewFactorResource.NotificationPlatformsEnum configNotificationPlatform = null,
                                                                                       string configNotificationToken = null,
                                                                                       string configSdkVersion = null,
                                                                                       string bindingSecret = null,
                                                                                       int? configTimeStep = null,
                                                                                       int? configSkew = null,
                                                                                       int? configCodeLength = null,
                                                                                       NewFactorResource.TotpAlgorithmsEnum configAlg = null,
                                                                                       ITwilioRestClient client = null)
        {
            var options = new CreateNewFactorOptions(pathServiceSid, pathIdentity, friendlyName, factorType){BindingAlg = bindingAlg, BindingPublicKey = bindingPublicKey, ConfigAppId = configAppId, ConfigNotificationPlatform = configNotificationPlatform, ConfigNotificationToken = configNotificationToken, ConfigSdkVersion = configSdkVersion, BindingSecret = bindingSecret, ConfigTimeStep = configTimeStep, ConfigSkew = configSkew, ConfigCodeLength = configCodeLength, ConfigAlg = configAlg};
            return await CreateAsync(options, client);
        }
        #endif

        /// <summary>
        /// Converts a JSON string into a NewFactorResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> NewFactorResource object represented by the provided JSON </returns>
        public static NewFactorResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<NewFactorResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// A string that uniquely identifies this Factor.
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// Account Sid.
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// Service Sid.
        /// </summary>
        [JsonProperty("service_sid")]
        public string ServiceSid { get; private set; }
        /// <summary>
        /// Entity Sid.
        /// </summary>
        [JsonProperty("entity_sid")]
        public string EntitySid { get; private set; }
        /// <summary>
        /// Unique external identifier of the Entity
        /// </summary>
        [JsonProperty("identity")]
        public string Identity { get; private set; }
        /// <summary>
        /// Unique external identifier of the Entity
        /// </summary>
        [JsonProperty("binding")]
        public object Binding { get; private set; }
        /// <summary>
        /// The date this Factor was created
        /// </summary>
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }
        /// <summary>
        /// The date this Factor was updated
        /// </summary>
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }
        /// <summary>
        /// A human readable description of this resource.
        /// </summary>
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }
        /// <summary>
        /// The Status of this Factor
        /// </summary>
        [JsonProperty("status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NewFactorResource.FactorStatusesEnum Status { get; private set; }
        /// <summary>
        /// The Type of this Factor
        /// </summary>
        [JsonProperty("factor_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NewFactorResource.FactorTypesEnum FactorType { get; private set; }
        /// <summary>
        /// Binding for a `factor_type`.
        /// </summary>
        [JsonProperty("config")]
        public object Config { get; private set; }
        /// <summary>
        /// The URL of this resource.
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }

        private NewFactorResource()
        {

        }
    }

}