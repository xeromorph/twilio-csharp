/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Conversations.V1
{

    /// <summary>
    /// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
    ///
    /// CreateUserOptions
    /// </summary>
    public class CreateUserOptions : IOptions<UserResource>
    {
        /// <summary>
        /// The string that identifies the resource's User
        /// </summary>
        public string Identity { get; }
        /// <summary>
        /// The string that you assigned to describe the resource
        /// </summary>
        public string FriendlyName { get; set; }
        /// <summary>
        /// The JSON Object string that stores application-specific data
        /// </summary>
        public string Attributes { get; set; }
        /// <summary>
        /// The SID of the Role to assign to the user
        /// </summary>
        public string RoleSid { get; set; }

        /// <summary>
        /// Construct a new CreateUserOptions
        /// </summary>
        /// <param name="identity"> The string that identifies the resource's User </param>
        public CreateUserOptions(string identity)
        {
            Identity = identity;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Identity != null)
            {
                p.Add(new KeyValuePair<string, string>("Identity", Identity));
            }

            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }

            if (Attributes != null)
            {
                p.Add(new KeyValuePair<string, string>("Attributes", Attributes));
            }

            if (RoleSid != null)
            {
                p.Add(new KeyValuePair<string, string>("RoleSid", RoleSid.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
    ///
    /// UpdateUserOptions
    /// </summary>
    public class UpdateUserOptions : IOptions<UserResource>
    {
        /// <summary>
        /// The SID of the User resource to update
        /// </summary>
        public string PathSid { get; }
        /// <summary>
        /// The string that you assigned to describe the resource
        /// </summary>
        public string FriendlyName { get; set; }
        /// <summary>
        /// The JSON Object string that stores application-specific data
        /// </summary>
        public string Attributes { get; set; }
        /// <summary>
        /// The SID of the Role to assign to the user
        /// </summary>
        public string RoleSid { get; set; }

        /// <summary>
        /// Construct a new UpdateUserOptions
        /// </summary>
        /// <param name="pathSid"> The SID of the User resource to update </param>
        public UpdateUserOptions(string pathSid)
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

            if (Attributes != null)
            {
                p.Add(new KeyValuePair<string, string>("Attributes", Attributes));
            }

            if (RoleSid != null)
            {
                p.Add(new KeyValuePair<string, string>("RoleSid", RoleSid.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
    ///
    /// DeleteUserOptions
    /// </summary>
    public class DeleteUserOptions : IOptions<UserResource>
    {
        /// <summary>
        /// The SID of  the User resource to delete
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new DeleteUserOptions
        /// </summary>
        /// <param name="pathSid"> The SID of  the User resource to delete </param>
        public DeleteUserOptions(string pathSid)
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
    /// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
    ///
    /// FetchUserOptions
    /// </summary>
    public class FetchUserOptions : IOptions<UserResource>
    {
        /// <summary>
        /// The SID of the User resource to fetch
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchUserOptions
        /// </summary>
        /// <param name="pathSid"> The SID of the User resource to fetch </param>
        public FetchUserOptions(string pathSid)
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
    /// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
    ///
    /// ReadUserOptions
    /// </summary>
    public class ReadUserOptions : ReadOptions<UserResource>
    {
        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

}