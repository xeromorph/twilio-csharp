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
using Twilio.Rest.Trusthub.V1;

namespace Twilio.Tests.Rest.Trusthub.V1
{

    [TestFixture]
    public class PoliciesTest : TwilioTest
    {
        [Test]
        public void TestReadRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Get,
                Twilio.Rest.Domain.Trusthub,
                "/v1/Policies",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                PoliciesResource.Read(client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestReadEmptyResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"results\": [],\"meta\": {\"page\": 0,\"page_size\": 50,\"first_page_url\": \"https://trusthub.twilio.com/v1/Policies?PageSize=50&Page=0\",\"previous_page_url\": null,\"url\": \"https://trusthub.twilio.com/v1/Policies?PageSize=50&Page=0\",\"next_page_url\": null,\"key\": \"results\"}}"
                                     ));

            var response = PoliciesResource.Read(client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestReadFullResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"results\": [{\"sid\": \"RNaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"friendly_name\": \"Australia: Local - Individual\",\"requirements\": {\"end_user\": [{\"name\": \"Individual\",\"type\": \"individual\",\"url\": \"https://trusthub.twilio.com/v1/Policies/individual\",\"fields\": [\"first_name\",\"last_name\"]}],\"supporting_document\": [[{\"name\": \"Address\",\"type\": \"document\",\"description\": \"The physical location of the individual or business. Must be within locality or region covered by the phone numbers prefix; a PO Box is not acceptable where a local address is required.\",\"accepted_documents\": [{\"name\": \"Address Validation\",\"type\": \"address\",\"url\": \"https://trusthub.twilio.com/v1/DocumentTypes/address\",\"fields\": []}]}]]},\"url\": \"https://trusthub.twilio.com/v1/Policies/RNaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\"}],\"meta\": {\"page\": 0,\"page_size\": 50,\"first_page_url\": \"https://trusthub.twilio.com/v1/Policies?PageSize=50&Page=0\",\"previous_page_url\": null,\"url\": \"https://trusthub.twilio.com/v1/Policies?PageSize=50&Page=0\",\"next_page_url\": null,\"key\": \"results\"}}"
                                     ));

            var response = PoliciesResource.Read(client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestFetchRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Get,
                Twilio.Rest.Domain.Trusthub,
                "/v1/Policies/RNXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                PoliciesResource.Fetch("RNXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
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
                                         "{\"sid\": \"RNaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"friendly_name\": \"Australia: Local - Individual\",\"requirements\": {\"end_user\": [{\"name\": \"Individual\",\"type\": \"individual\",\"url\": \"https://trusthub.twilio.com/v1/Policies/individual\",\"fields\": [\"first_name\",\"last_name\"]}],\"supporting_document\": [[{\"name\": \"Address\",\"type\": \"document\",\"description\": \"The physical location of the individual or business. Must be within locality or region covered by the phone numbers prefix; a PO Box is not acceptable where a local address is required.\",\"accepted_documents\": [{\"name\": \"Address Validation\",\"type\": \"address\",\"url\": \"https://trusthub.twilio.com/v1/DocumentTypes/address\",\"fields\": []}]}]]},\"url\": \"https://trusthub.twilio.com/v1/Policies/RNaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\"}"
                                     ));

            var response = PoliciesResource.Fetch("RNXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
            Assert.NotNull(response);
        }
    }

}