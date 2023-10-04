// SMSSender smsSender = new SMSSender();
// smsSender.SendMessage();

// TwitterMessanger twitterMessanger = new TwitterMessanger();
// twitterMessanger.SendMessage();
ISendMessage sender = new SMSSender();
sender.SendMessage();

sender = new TwitterMessanger();
sender.SendMessage();

sender = new WhatsappSender();
sender.SendMessage();

// All the classed implement the IsendMessage interace SendMessage method