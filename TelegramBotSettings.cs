using Telegram.Bot.Types;

namespace PotokNewsAgency
{
    static class TelegramBotSettings
    {
        public const string BotName = "Новостное агентство Поток";
        public static ChatId MessagesSendingChatId { get; } = new ChatId(-1001697443849);
        public const string MessagesInitialSymbol = "⚡️";
        public const string BotKey = "5346570676:AAEoCAGccKZG0ANg00Wb4EoBbI_sIXJsxB8";
    }
}
