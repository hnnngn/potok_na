using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Telegram.Bot;
using Telegram.Bot.Types.InputFiles;

namespace PotokNewsAgency
{
    public partial class Form1 : Form
    {
        private readonly TelegramBotClient client;

        public Form1()
        {
            InitializeComponent();
            client = new TelegramBotClient(TelegramBotSettings.BotKey);

            openCreationNewsPanelButton.Click += (o, e) =>
            {
                createNewsGBox.Visible = true;
            };

            closeCreationNewsPanelButton.Click += (o, e) =>
            {
                createNewsGBox.Visible = false;
            };
        }

        private async void sendButton_Click(object sender, EventArgs e)
        {
            string header = headerTBox.Text, mainBody = mainBodyRTBox.Text;
            if (string.IsNullOrEmpty(header) || string.IsNullOrEmpty(mainBody))
            {
                ShowWarningMessageBox("Не введен заголовок или основная часть новости.");
                return;
            }

            if (!string.IsNullOrEmpty(pathToPhotoTBox.Text))
            {
                using (FileStream fs = new FileStream(pathToPhotoTBox.Text, FileMode.Open, FileAccess.Read, FileShare.Read))
                    await client.SendPhotoAsync(TelegramBotSettings.MessagesSendingChatId, new InputOnlineFile(fs), GenerateSendingString(header, mainBody));
            }
            else
                await client.SendTextMessageAsync(TelegramBotSettings.MessagesSendingChatId, GenerateSendingString(header, mainBody));
        }

        private void addPhotosButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog selectPhotoDialog = new OpenFileDialog();
            selectPhotoDialog.Title = "Выбрать фотографию";
            selectPhotoDialog.Filter = "JPG-файл (*.jpg, *.jpeg)|*.jpg,*.jpeg|PNG-файл (*.png)|*.png";

            if (selectPhotoDialog.ShowDialog() == DialogResult.Cancel) return;

            pathToPhotoTBox.Text = selectPhotoDialog.FileName;
            viewSelectedPhotoPBox.Image = new Bitmap(pathToPhotoTBox.Text);
        }

        private string GenerateSendingString(string header, string mainBody) => $"{TelegramBotSettings.MessagesInitialSymbol} {header}\n\n{mainBody}";

        private DialogResult ShowWarningMessageBox(string msg) => MessageBox.Show(msg, caption: "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }
}
