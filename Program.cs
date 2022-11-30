using System;
using System.Collections.Generic;
using System.ComponentModel;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types.ReplyMarkups;

namespace TGBOT
{
    internal class Program
    {
        private static string token { get; set; } = "5423240339:AAEOIqvXI4VniwyIQvYCy4G6bg_zPcw5X9k";
        private static TelegramBotClient client;
        static void Main(string[] args)
        {
            client = new TelegramBotClient(token);
            client.StartReceiving();
            client.OnMessage += OnMessageHandler;
            Console.ReadLine();
            client.StopReceiving();
        }

        private static async void OnMessageHandler(object sender, MessageEventArgs e)
        {
            var msg = e.Message;
            if (msg.Text != null) 
            {
                Console.WriteLine($"Получено сообщение: {msg.Text}");
                switch (msg.Text)
                {
                    case "Хатчбек":
                        await client.()
                        
                }
            }
        }

        private static IReplyMarkup GetButtons()
        {
            return new ReplyKeyboardMarkup
            {
                Keyboard = new List<List<KeyboardButton>>
                {
                    new List<KeyboardButton>{ new KeyboardButton {Text = "Хатчбек"}, new KeyboardButton { Text = "Седан"} }
                }
            };
        }
    }
}
