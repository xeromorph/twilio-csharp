/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Messaging.V1
{

    /// <summary>
    /// Fetch a list of all United States numbers that have been deactivated on a specific date.
    /// </summary>
    public class FetchDeactivationsOptions : IOptions<DeactivationsResource>
    {
        /// <summary>
        /// The date to retrieve deactivated numbers for.
        /// </summary>
        public DateTime? Date { get; set; }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Date != null)
            {
                p.Add(new KeyValuePair<string, string>("Date", Date.Value.ToString("yyyy-MM-dd")));
            }

            return p;
        }
    }

}