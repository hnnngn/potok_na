using Telegram.Bot.Types;

namespace PotokNewsAgency
{
    static class TelegramBotSettings
    {
        public const string BotName = "Новостное агентство Поток";
        public static ChatId MessagesSendingChatId { get; } = new ChatId(//chatid);
        public const string MessagesInitialSymbol = "⚡️";
        public const string BotKey = //botkey;
    }
}
