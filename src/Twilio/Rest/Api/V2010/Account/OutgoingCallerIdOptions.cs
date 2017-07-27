/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;

namespace Twilio.Rest.Api.V2010.Account 
{

    /// <summary>
    /// Fetch an outgoing-caller-id belonging to the account used to make the request
    /// </summary>
    public class FetchOutgoingCallerIdOptions : IOptions<OutgoingCallerIdResource> 
    {
        /// <summary>
        /// The account_sid
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// Fetch by unique outgoing-caller-id Sid
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchOutgoingCallerIdOptions
        /// </summary>
        ///
        /// <param name="pathSid"> Fetch by unique outgoing-caller-id Sid </param>
        public FetchOutgoingCallerIdOptions(string pathSid)
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

    /// <summary>
    /// Updates the caller-id
    /// </summary>
    public class UpdateOutgoingCallerIdOptions : IOptions<OutgoingCallerIdResource> 
    {
        /// <summary>
        /// The account_sid
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// Update by unique outgoing-caller-id Sid
        /// </summary>
        public string PathSid { get; }
        /// <summary>
        /// A human readable description of the caller ID
        /// </summary>
        public string FriendlyName { get; set; }

        /// <summary>
        /// Construct a new UpdateOutgoingCallerIdOptions
        /// </summary>
        ///
        /// <param name="pathSid"> Update by unique outgoing-caller-id Sid </param>
        public UpdateOutgoingCallerIdOptions(string pathSid)
        {
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }

            return p;
        }
    }

    /// <summary>
    /// Delete the caller-id specified from the account
    /// </summary>
    public class DeleteOutgoingCallerIdOptions : IOptions<OutgoingCallerIdResource> 
    {
        /// <summary>
        /// The account_sid
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// Delete by unique outgoing-caller-id Sid
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new DeleteOutgoingCallerIdOptions
        /// </summary>
        ///
        /// <param name="pathSid"> Delete by unique outgoing-caller-id Sid </param>
        public DeleteOutgoingCallerIdOptions(string pathSid)
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

    /// <summary>
    /// Retrieve a list of outgoing-caller-ids belonging to the account used to make the request
    /// </summary>
    public class ReadOutgoingCallerIdOptions : ReadOptions<OutgoingCallerIdResource> 
    {
        /// <summary>
        /// The account_sid
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// Filter by phone number
        /// </summary>
        public Types.PhoneNumber PhoneNumber { get; set; }
        /// <summary>
        /// Filter by friendly name
        /// </summary>
        public string FriendlyName { get; set; }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (PhoneNumber != null)
            {
                p.Add(new KeyValuePair<string, string>("PhoneNumber", PhoneNumber.ToString()));
            }

            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }

            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

}