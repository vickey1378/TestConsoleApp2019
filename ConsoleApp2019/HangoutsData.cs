using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2019
{
    public class ConversationId
    {
        public string id { get; set; }
    }

    public class Id
    {
        public string id { get; set; }
    }

    public class ParticipantId
    {
        public string gaia_id { get; set; }
        public string chat_id { get; set; }
    }

    public class SelfReadState
    {
        public ParticipantId participant_id { get; set; }
        public string latest_read_timestamp { get; set; }
    }

    public class InviterId
    {
        public string gaia_id { get; set; }
        public string chat_id { get; set; }
    }

    public class DeliveryMedium
    {
        public string medium_type { get; set; }
    }

    public class DeliveryMediumOption
    {
        public DeliveryMedium delivery_medium { get; set; }
        public bool current_default { get; set; }
    }

    public class SelfConversationState
    {
        public SelfReadState self_read_state { get; set; }
        public string status { get; set; }
        public string notification_level { get; set; }
        public List<string> view { get; set; }
        public InviterId inviter_id { get; set; }
        public string invite_timestamp { get; set; }
        public string sort_timestamp { get; set; }
        public string active_timestamp { get; set; }
        public List<DeliveryMediumOption> delivery_medium_option { get; set; }
        public bool is_guest { get; set; }
    }

    public class ParticipantId2
    {
        public string gaia_id { get; set; }
        public string chat_id { get; set; }
    }

    public class ReadState
    {
        public ParticipantId2 participant_id { get; set; }
        public string latest_read_timestamp { get; set; }
    }

    public class CurrentParticipant
    {
        public string gaia_id { get; set; }
        public string chat_id { get; set; }
    }

    public class Id2
    {
        public string gaia_id { get; set; }
        public string chat_id { get; set; }
    }

    public class ParticipantData
    {
        public Id2 id { get; set; }
        public string fallback_name { get; set; }
        public string invitation_status { get; set; }
        public string participant_type { get; set; }
        public string new_invitation_status { get; set; }
        public bool in_different_customer_as_requester { get; set; }
        public string domain_id { get; set; }
    }

    public class Conversation3
    {
        public Id id { get; set; }
        public string type { get; set; }
        public SelfConversationState self_conversation_state { get; set; }
        public List<ReadState> read_state { get; set; }
        public bool has_active_hangout { get; set; }
        public string otr_status { get; set; }
        public string otr_toggle { get; set; }
        public List<CurrentParticipant> current_participant { get; set; }
        public List<ParticipantData> participant_data { get; set; }
        public bool fork_on_external_invite { get; set; }
        public List<string> network_type { get; set; }
        public string force_history_state { get; set; }
        public string group_link_sharing_status { get; set; }
        public string name { get; set; }
    }

    public class Conversation2
    {
        public ConversationId conversation_id { get; set; }
        public Conversation3 conversation { get; set; }
    }

    public class ConversationId2
    {
        public string id { get; set; }
    }

    public class SenderId
    {
        public string gaia_id { get; set; }
        public string chat_id { get; set; }
    }

    public class UserId
    {
        public string gaia_id { get; set; }
        public string chat_id { get; set; }
    }

    public class SelfEventState
    {
        public UserId user_id { get; set; }
        public string notification_level { get; set; }
        public string client_generated_id { get; set; }
    }

    public class Segment
    {
        public string type { get; set; }
        public string text { get; set; }
    }

    public class MessageContent
    {
        public List<Segment> segment { get; set; }
    }

    public class ChatMessage
    {
        public MessageContent message_content { get; set; }
    }

    public class DeliveryMedium2
    {
        public string medium_type { get; set; }
    }

    public class ConversationRename
    {
        public string new_name { get; set; }
        public string old_name { get; set; }
    }

    public class Event
    {
        public ConversationId2 conversation_id { get; set; }
        public SenderId sender_id { get; set; }
        public string timestamp { get; set; }
        public SelfEventState self_event_state { get; set; }
        public ChatMessage chat_message { get; set; }
        public string event_id { get; set; }
        public bool advances_sort_timestamp { get; set; }
        public string event_otr { get; set; }
        public DeliveryMedium2 delivery_medium { get; set; }
        public string event_type { get; set; }
        public string event_version { get; set; }
        public ConversationRename conversation_rename { get; set; }
    }

    public class Conversation
    {
        public Conversation2 conversation { get; set; }
        public List<Event> events { get; set; }
    }

    public class HangoutData
    {
        public List<Conversation> conversations { get; set; }
    }
}
