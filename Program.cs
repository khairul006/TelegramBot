using System;
using Telegram.Bot;

namespace TelegramBot 
{
    class Program
    {
        public static TelegramBotClient Client;

        [Obsolete]
        static void Main(string[] args)
        {
            Client = new TelegramBotClient("7009725948:AAFI0Zd7MkMbM_AYzvkvpJmzHrHgHEFCQ6s");
            Client.OnMessage += Client_OnMessage;
            Client.StartReceiving();
            Thread.Sleep(-1);
        }

        [Obsolete]
        private static void Client_OnMessage(object? sender, Telegram.Bot.Args.MessageEventArgs e)
        {
            var id = e.Message.Chat.Id;
            var text = e.Message.Text;

            //Client.SendTextMessageAsync(id, $"You said: {text}");

            text = text.Substring(1).ToLower();
            text = text.Split(' ')[0];
            switch (text)
            {
                case "now":
                    var response = DateTime.Now.ToString();
                    Client.SendTextMessageAsync(id, $"DateTime:\n{response}");
                    break;
            }

        }

       
    }
}

