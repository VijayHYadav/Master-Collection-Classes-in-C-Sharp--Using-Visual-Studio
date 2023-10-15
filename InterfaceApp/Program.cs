using InterfaceApp;

// CheckAccount ch = new CheckAccount();
// ch.BankAccount();
// ch.Savings();
// ch.AmountCredited(20);

TextMessage textMessage = new TextMessage("V!j4y", "Hi There");
textMessage.Play();

FaxMessage faxMessage = new FaxMessage("V!j4y Y4d4v", "Hi There");
faxMessage.Play();

VoiceMessage voiceMessage = new VoiceMessage("V!j4y", "Hi There");
voiceMessage.Play();