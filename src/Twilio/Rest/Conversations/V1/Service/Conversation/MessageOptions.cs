/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Conversations.V1.Service.Conversation
{

    /// <summary>
    /// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
    ///
    /// CreateMessageOptions
    /// </summary>
    public class CreateMessageOptions : IOptions<MessageResource>
    {
        /// <summary>
        /// The SID of the Conversation Service that the resource is associated with.
        /// </summary>
        public string PathChatServiceSid { get; }
        /// <summary>
        /// The unique ID of the Conversation for this message.
        /// </summary>
        public string PathConversationSid { get; }
        /// <summary>
        /// The channel specific identifier of the message's author.
        /// </summary>
        public string Author { get; set; }
        /// <summary>
        /// The content of the message.
        /// </summary>
        public string Body { get; set; }
        /// <summary>
        /// The date that this resource was created.
        /// </summary>
        public DateTime? DateCreated { get; set; }
        /// <summary>
        /// The date that this resource was last updated.
        /// </summary>
        public DateTime? DateUpdated { get; set; }
        /// <summary>
        /// A string metadata field you can use to store any data you wish.
        /// </summary>
        public string Attributes { get; set; }
        /// <summary>
        /// The Media SID to be attached to the new Message.
        /// </summary>
        public string MediaSid { get; set; }
        /// <summary>
        /// The X-Twilio-Webhook-Enabled HTTP request header
        /// </summary>
        public MessageResource.WebhookEnabledTypeEnum XTwilioWebhookEnabled { get; set; }

        /// <summary>
        /// Construct a new CreateMessageOptions
        /// </summary>
        /// <param name="pathChatServiceSid"> The SID of the Conversation Service that the resource is associated with. </param>
        /// <param name="pathConversationSid"> The unique ID of the Conversation for this message. </param>
        public CreateMessageOptions(string pathChatServiceSid, string pathConversationSid)
        {
            PathChatServiceSid = pathChatServiceSid;
            PathConversationSid = pathConversationSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Author != null)
            {
                p.Add(new KeyValuePair<string, string>("Author", Author));
            }

            if (Body != null)
            {
                p.Add(new KeyValuePair<string, string>("Body", Body));
            }

            if (DateCreated != null)
            {
                p.Add(new KeyValuePair<string, string>("DateCreated", Serializers.DateTimeIso8601(DateCreated)));
            }

            if (DateUpdated != null)
            {
                p.Add(new KeyValuePair<string, string>("DateUpdated", Serializers.DateTimeIso8601(DateUpdated)));
            }

            if (Attributes != null)
            {
                p.Add(new KeyValuePair<string, string>("Attributes", Attributes));
            }

            if (MediaSid != null)
            {
                p.Add(new KeyValuePair<string, string>("MediaSid", MediaSid.ToString()));
            }

            return p;
        }

        /// <summary>
        /// Generate the necessary header parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetHeaderParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (XTwilioWebhookEnabled != null)
            {
                p.Add(new KeyValuePair<string, string>("X-Twilio-Webhook-Enabled", XTwilioWebhookEnabled.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
    ///
    /// UpdateMessageOptions
    /// </summary>
    public class UpdateMessageOptions : IOptions<MessageResource>
    {
        /// <summary>
        /// The SID of the Conversation Service that the resource is associated with.
        /// </summary>
        public string PathChatServiceSid { get; }
        /// <summary>
        /// The unique ID of the Conversation for this message.
        /// </summary>
        public string PathConversationSid { get; }
        /// <summary>
        /// A 34 character string that uniquely identifies this resource.
        /// </summary>
        public string PathSid { get; }
        /// <summary>
        /// The channel specific identifier of the message's author.
        /// </summary>
        public string Author { get; set; }
        /// <summary>
        /// The content of the message.
        /// </summary>
        public string Body { get; set; }
        /// <summary>
        /// The date that this resource was created.
        /// </summary>
        public DateTime? DateCreated { get; set; }
        /// <summary>
        /// The date that this resource was last updated.
        /// </summary>
        public DateTime? DateUpdated { get; set; }
        /// <summary>
        /// A string metadata field you can use to store any data you wish.
        /// </summary>
        public string Attributes { get; set; }
        /// <summary>
        /// The X-Twilio-Webhook-Enabled HTTP request header
        /// </summary>
        public MessageResource.WebhookEnabledTypeEnum XTwilioWebhookEnabled { get; set; }

        /// <summary>
        /// Construct a new UpdateMessageOptions
        /// </summary>
        /// <param name="pathChatServiceSid"> The SID of the Conversation Service that the resource is associated with. </param>
        /// <param name="pathConversationSid"> The unique ID of the Conversation for this message. </param>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this resource. </param>
        public UpdateMessageOptions(string pathChatServiceSid, string pathConversationSid, string pathSid)
        {
            PathChatServiceSid = pathChatServiceSid;
            PathConversationSid = pathConversationSid;
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Author != null)
            {
                p.Add(new KeyValuePair<string, string>("Author", Author));
            }

            if (Body != null)
            {
                p.Add(new KeyValuePair<string, string>("Body", Body));
            }

            if (DateCreated != null)
            {
                p.Add(new KeyValuePair<string, string>("DateCreated", Serializers.DateTimeIso8601(DateCreated)));
            }

            if (DateUpdated != null)
            {
                p.Add(new KeyValuePair<string, string>("DateUpdated", Serializers.DateTimeIso8601(DateUpdated)));
            }

            if (Attributes != null)
            {
                p.Add(new KeyValuePair<string, string>("Attributes", Attributes));
            }

            return p;
        }

        /// <summary>
        /// Generate the necessary header parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetHeaderParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (XTwilioWebhookEnabled != null)
            {
                p.Add(new KeyValuePair<string, string>("X-Twilio-Webhook-Enabled", XTwilioWebhookEnabled.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
    ///
    /// DeleteMessageOptions
    /// </summary>
    public class DeleteMessageOptions : IOptions<MessageResource>
    {
        /// <summary>
        /// The SID of the Conversation Service that the resource is associated with.
        /// </summary>
        public string PathChatServiceSid { get; }
        /// <summary>
        /// The unique ID of the Conversation for this message.
        /// </summary>
        public string PathConversationSid { get; }
        /// <summary>
        /// A 34 character string that uniquely identifies this resource.
        /// </summary>
        public string PathSid { get; }
        /// <summary>
        /// The X-Twilio-Webhook-Enabled HTTP request header
        /// </summary>
        public MessageResource.WebhookEnabledTypeEnum XTwilioWebhookEnabled { get; set; }

        /// <summary>
        /// Construct a new DeleteMessageOptions
        /// </summary>
        /// <param name="pathChatServiceSid"> The SID of the Conversation Service that the resource is associated with. </param>
        /// <param name="pathConversationSid"> The unique ID of the Conversation for this message. </param>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this resource. </param>
        public DeleteMessageOptions(string pathChatServiceSid, string pathConversationSid, string pathSid)
        {
            PathChatServiceSid = pathChatServiceSid;
            PathConversationSid = pathConversationSid;
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

        /// <summary>
        /// Generate the necessary header parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetHeaderParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (XTwilioWebhookEnabled != null)
            {
                p.Add(new KeyValuePair<string, string>("X-Twilio-Webhook-Enabled", XTwilioWebhookEnabled.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
    ///
    /// FetchMessageOptions
    /// </summary>
    public class FetchMessageOptions : IOptions<MessageResource>
    {
        /// <summary>
        /// The SID of the Conversation Service that the resource is associated with.
        /// </summary>
        public string PathChatServiceSid { get; }
        /// <summary>
        /// The unique ID of the Conversation for this message.
        /// </summary>
        public string PathConversationSid { get; }
        /// <summary>
        /// A 34 character string that uniquely identifies this resource.
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchMessageOptions
        /// </summary>
        /// <param name="pathChatServiceSid"> The SID of the Conversation Service that the resource is associated with. </param>
        /// <param name="pathConversationSid"> The unique ID of the Conversation for this message. </param>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this resource. </param>
        public FetchMessageOptions(string pathChatServiceSid, string pathConversationSid, string pathSid)
        {
            PathChatServiceSid = pathChatServiceSid;
            PathConversationSid = pathConversationSid;
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
    /// ReadMessageOptions
    /// </summary>
    public class ReadMessageOptions : ReadOptions<MessageResource>
    {
        /// <summary>
        /// The SID of the Conversation Service that the resource is associated with.
        /// </summary>
        public string PathChatServiceSid { get; }
        /// <summary>
        /// The unique ID of the Conversation for messages.
        /// </summary>
        public string PathConversationSid { get; }

        /// <summary>
        /// Construct a new ReadMessageOptions
        /// </summary>
        /// <param name="pathChatServiceSid"> The SID of the Conversation Service that the resource is associated with. </param>
        /// <param name="pathConversationSid"> The unique ID of the Conversation for messages. </param>
        public ReadMessageOptions(string pathChatServiceSid, string pathConversationSid)
        {
            PathChatServiceSid = pathChatServiceSid;
            PathConversationSid = pathConversationSid;
        }

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