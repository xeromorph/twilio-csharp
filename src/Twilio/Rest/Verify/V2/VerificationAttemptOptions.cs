/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Verify.V2
{

    /// <summary>
    /// List all the verification attempts for a given Account.
    /// </summary>
    public class ReadVerificationAttemptOptions : ReadOptions<VerificationAttemptResource>
    {
        /// <summary>
        /// Filter verification attempts after this date
        /// </summary>
        public DateTime? DateCreatedAfter { get; set; }
        /// <summary>
        /// Filter verification attempts befor this date
        /// </summary>
        public DateTime? DateCreatedBefore { get; set; }
        /// <summary>
        /// Destination of a verification
        /// </summary>
        public string ChannelDataTo { get; set; }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (DateCreatedAfter != null)
            {
                p.Add(new KeyValuePair<string, string>("DateCreatedAfter", Serializers.DateTimeIso8601(DateCreatedAfter)));
            }

            if (DateCreatedBefore != null)
            {
                p.Add(new KeyValuePair<string, string>("DateCreatedBefore", Serializers.DateTimeIso8601(DateCreatedBefore)));
            }

            if (ChannelDataTo != null)
            {
                p.Add(new KeyValuePair<string, string>("ChannelData.To", ChannelDataTo));
            }

            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// Fetch a specific verification attempt.
    /// </summary>
    public class FetchVerificationAttemptOptions : IOptions<VerificationAttemptResource>
    {
        /// <summary>
        /// Verification Attempt Sid.
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchVerificationAttemptOptions
        /// </summary>
        /// <param name="pathSid"> Verification Attempt Sid. </param>
        public FetchVerificationAttemptOptions(string pathSid)
        {
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

}