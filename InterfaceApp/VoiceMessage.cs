namespace InterfaceApp
{
    public class VoiceMessage : Message
    {
        public VoiceMessage(string sender, string type) {
            this.sender = sender;
            this.type = type;
        }

        public override void Play()
        {
            if (sender is not null &&  type is not null)
            Console.WriteLine($"{ToString(sender,  type)}");
        }
    }
}