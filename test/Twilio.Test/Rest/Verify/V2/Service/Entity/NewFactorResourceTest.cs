/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using NSubstitute;
using NSubstitute.ExceptionExtensions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Rest.Verify.V2.Service.Entity;

namespace Twilio.Tests.Rest.Verify.V2.Service.Entity
{

    [TestFixture]
    public class NewFactorTest : TwilioTest
    {
        [Test]
        public void TestCreateRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Post,
                Twilio.Rest.Domain.Verify,
                "/v2/Services/VAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/Entities/identity/Factors",
                ""
            );
            request.AddPostParam("FriendlyName", Serialize("friendly_name"));
            request.AddPostParam("FactorType", Serialize(NewFactorResource.FactorTypesEnum.Push));
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                NewFactorResource.Create("VAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "identity", "friendly_name", NewFactorResource.FactorTypesEnum.Push, client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestCreatePushResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.Created,
                                         "{\"sid\": \"YFaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"service_sid\": \"VAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"entity_sid\": \"YEaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"identity\": \"ff483d1ff591898a9942916050d2ca3f\",\"binding\": {\"alg\": \"ES256\",\"public_key\": \"MFkwEwYHKoZIzj0CAQYIKoZIzj0DAQcDQgAE8GdwtibWe0kpgsFl6xPQBwhtwUEyeJkeozFmi2jiJDzxFSMwVy3kVR1h/dPVYOfgkC0EkfBRJ0J/6xW47FD5vA==\"},\"date_created\": \"2015-07-30T20:00:00Z\",\"date_updated\": \"2015-07-30T20:00:00Z\",\"friendly_name\": \"friendly_name\",\"status\": \"unverified\",\"factor_type\": \"push\",\"config\": {\"sdk_version\": \"1.0\",\"app_id\": \"com.example.myapp\",\"notification_platform\": \"fcm\",\"notification_token\": \"test_token\"},\"url\": \"https://verify.twilio.com/v2/Services/VAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Entities/ff483d1ff591898a9942916050d2ca3f/Factors/YFaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\"}"
                                     ));

            var response = NewFactorResource.Create("VAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "identity", "friendly_name", NewFactorResource.FactorTypesEnum.Push, client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestCreateTotpResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.Created,
                                         "{\"sid\": \"YFaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"service_sid\": \"VAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"entity_sid\": \"YEaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"identity\": \"ff483d1ff591898a9942916050d2ca3f\",\"binding\": {\"secret\": \"GEZDGNBVGY3TQOJQGEZDGNBVGY3TQOJQ\",\"uri\": \"otpauth://totp/The%20Issuer:My%20Account?secret=GEZDGNBVGY3TQOJQGEZDGNBVGY3TQOJQ&issuer=The%20Issuer&algorithm=SHA1&digits=4&period=40\"},\"date_created\": \"2015-07-30T20:00:00Z\",\"date_updated\": \"2015-07-30T20:00:00Z\",\"friendly_name\": \"friendly_name\",\"status\": \"unverified\",\"factor_type\": \"totp\",\"config\": {\"alg\": \"sha1\",\"skew\": 1,\"code_length\": 6,\"time_step\": 30},\"url\": \"https://verify.twilio.com/v2/Services/VAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Entities/ff483d1ff591898a9942916050d2ca3f/Factors/YFaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\"}"
                                     ));

            var response = NewFactorResource.Create("VAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "identity", "friendly_name", NewFactorResource.FactorTypesEnum.Push, client: twilioRestClient);
            Assert.NotNull(response);
        }
    }

}