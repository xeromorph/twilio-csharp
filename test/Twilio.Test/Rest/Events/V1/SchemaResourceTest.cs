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
using Twilio.Rest.Events.V1;

namespace Twilio.Tests.Rest.Events.V1
{

    [TestFixture]
    public class SchemaTest : TwilioTest
    {
        [Test]
        public void TestFetchRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Get,
                Twilio.Rest.Domain.Events,
                "/v1/Schemas/id",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                SchemaResource.Fetch("id", client: twilioRestClient);
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
                                         "{\"id\": \"DataTaps.TestEventSchema\",\"url\": \"https://events.twilio.com/v1/Schemas/DataTaps.TestEventSchema\",\"last_created\": \"2018-07-30T20:00:00Z\",\"last_version\": 1,\"links\": {\"versions\": \"https://events.twilio.com/v1/Schemas/DataTaps.TestEventSchema/Versions\"}}"
                                     ));

            var response = SchemaResource.Fetch("id", client: twilioRestClient);
            Assert.NotNull(response);
        }
    }

}