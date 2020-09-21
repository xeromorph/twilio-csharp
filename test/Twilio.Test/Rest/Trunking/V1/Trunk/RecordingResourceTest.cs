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
using Twilio.Rest.Trunking.V1.Trunk;

namespace Twilio.Tests.Rest.Trunking.V1.Trunk
{

    [TestFixture]
    public class RecordingTest : TwilioTest
    {
        [Test]
        public void TestFetchRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Get,
                Twilio.Rest.Domain.Trunking,
                "/v1/Trunks/TKXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/Recording",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                RecordingResource.Fetch("TKXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestFetchResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"mode\": \"do-not-record\",\"trim\": \"do-not-trim\",\"url\": \"https://trunking.twilio.com/v1/Trunks/TKaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Recording\",\"trunk_sid\": \"TKaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\"}"
                                     ));

            var response = RecordingResource.Fetch("TKXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestUpdateRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Post,
                Twilio.Rest.Domain.Trunking,
                "/v1/Trunks/TKXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/Recording",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                RecordingResource.Update("TKXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestUpdateResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"mode\": \"do-not-record\",\"trim\": \"do-not-trim\",\"url\": \"https://trunking.twilio.com/v1/Trunks/TKaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Recording\",\"trunk_sid\": \"TKaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\"}"
                                     ));

            var response = RecordingResource.Update("TKXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
            Assert.NotNull(response);
        }
    }

}