/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// NewSigningKeyResource
/// </summary>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.Api.V2010.Account
{

    public class NewSigningKeyResource : Resource
    {
        private static Request BuildCreateRequest(CreateNewSigningKeyOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.PathAccountSid ?? client.AccountSid) + "/SigningKeys.json",
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary>
        /// Create a new Signing Key for the account making the request.
        /// </summary>
        /// <param name="options"> Create NewSigningKey parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of NewSigningKey </returns>
        public static NewSigningKeyResource Create(CreateNewSigningKeyOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Create a new Signing Key for the account making the request.
        /// </summary>
        /// <param name="options"> Create NewSigningKey parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of NewSigningKey </returns>
        public static async System.Threading.Tasks.Task<NewSigningKeyResource> CreateAsync(CreateNewSigningKeyOptions options,
                                                                                           ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Create a new Signing Key for the account making the request.
        /// </summary>
        /// <param name="pathAccountSid"> The SID of the Account that will be responsible for the new Key resource </param>
        /// <param name="friendlyName"> A string to describe the resource </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of NewSigningKey </returns>
        public static NewSigningKeyResource Create(string pathAccountSid = null,
                                                   string friendlyName = null,
                                                   ITwilioRestClient client = null)
        {
            var options = new CreateNewSigningKeyOptions(){PathAccountSid = pathAccountSid, FriendlyName = friendlyName};
            return Create(options, client);
        }

        #if !NET35
        /// <summary>
        /// Create a new Signing Key for the account making the request.
        /// </summary>
        /// <param name="pathAccountSid"> The SID of the Account that will be responsible for the new Key resource </param>
        /// <param name="friendlyName"> A string to describe the resource </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of NewSigningKey </returns>
        public static async System.Threading.Tasks.Task<NewSigningKeyResource> CreateAsync(string pathAccountSid = null,
                                                                                           string friendlyName = null,
                                                                                           ITwilioRestClient client = null)
        {
            var options = new CreateNewSigningKeyOptions(){PathAccountSid = pathAccountSid, FriendlyName = friendlyName};
            return await CreateAsync(options, client);
        }
        #endif

        /// <summary>
        /// Converts a JSON string into a NewSigningKeyResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> NewSigningKeyResource object represented by the provided JSON </returns>
        public static NewSigningKeyResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<NewSigningKeyResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// The unique string that identifies the resource
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// The string that you assigned to describe the resource
        /// </summary>
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }
        /// <summary>
        /// The RFC 2822 date and time in GMT that the resource was created
        /// </summary>
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }
        /// <summary>
        /// The RFC 2822 date and time in GMT that the resource was last updated
        /// </summary>
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }
        /// <summary>
        /// The secret your application uses to sign Access Tokens and to authenticate to the REST API.
        /// </summary>
        [JsonProperty("secret")]
        public string Secret { get; private set; }

        private NewSigningKeyResource()
        {

        }
    }

}