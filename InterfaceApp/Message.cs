namespace InterfaceApp
{
    public abstract class Message
    {
        public string? sender;
        private readonly int messageID;
        public string? type;
        private static int totalMessages =  0;
        public Message()
        {
            messageID = ++totalMessages;
        }
        public Message(string sender, string type)
        {
            this.sender = sender;
            this.type = type;
            messageID = ++totalMessages;
        }

        protected string ToString(string sender, string type)
        {
            switch(type)
            {
                case "Fax Message":
                    return type + " from " + sender + " With ID = " + messageID;
                case "Text Message":
                    return type + " from " + sender + " With ID = " + messageID;
                default:
                    return type + " from " + sender + " With ID = " + messageID;

            }
        }

        public abstract void Play(); 
    }
}