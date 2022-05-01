
namespace PotokNewsAgency
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openCreationNewsPanelButton = new System.Windows.Forms.Button();
            this.createNewsGBox = new System.Windows.Forms.GroupBox();
            this.closeCreationNewsPanelButton = new System.Windows.Forms.Button();
            this.sendButton = new System.Windows.Forms.Button();
            this.mainBodyRTBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.headerTBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addPhotosButton = new System.Windows.Forms.Button();
            this.pathToPhotoTBox = new System.Windows.Forms.TextBox();
            this.viewSelectedPhotoPBox = new System.Windows.Forms.PictureBox();
            this.createNewsGBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewSelectedPhotoPBox)).BeginInit();
            this.SuspendLayout();
            // 
            // openCreationNewsPanelButton
            // 
            this.openCreationNewsPanelButton.Location = new System.Drawing.Point(12, 12);
            this.openCreationNewsPanelButton.Name = "openCreationNewsPanelButton";
            this.openCreationNewsPanelButton.Size = new System.Drawing.Size(121, 23);
            this.openCreationNewsPanelButton.TabIndex = 0;
            this.openCreationNewsPanelButton.Text = "Создать новость";
            this.openCreationNewsPanelButton.UseCompatibleTextRendering = true;
            this.openCreationNewsPanelButton.UseVisualStyleBackColor = true;
            // 
            // createNewsGBox
            // 
            this.createNewsGBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.createNewsGBox.Controls.Add(this.viewSelectedPhotoPBox);
            this.createNewsGBox.Controls.Add(this.pathToPhotoTBox);
            this.createNewsGBox.Controls.Add(this.addPhotosButton);
            this.createNewsGBox.Controls.Add(this.closeCreationNewsPanelButton);
            this.createNewsGBox.Controls.Add(this.sendButton);
            this.createNewsGBox.Controls.Add(this.mainBodyRTBox);
            this.createNewsGBox.Controls.Add(this.label2);
            this.createNewsGBox.Controls.Add(this.headerTBox);
            this.createNewsGBox.Controls.Add(this.label1);
            this.createNewsGBox.Location = new System.Drawing.Point(227, 12);
            this.createNewsGBox.Name = "createNewsGBox";
            this.createNewsGBox.Size = new System.Drawing.Size(536, 295);
            this.createNewsGBox.TabIndex = 2;
            this.createNewsGBox.TabStop = false;
            this.createNewsGBox.Text = "Создать новость";
            this.createNewsGBox.Visible = false;
            // 
            // closeCreationNewsPanelButton
            // 
            this.closeCreationNewsPanelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closeCreationNewsPanelButton.Location = new System.Drawing.Point(427, 263);
            this.closeCreationNewsPanelButton.Name = "closeCreationNewsPanelButton";
            this.closeCreationNewsPanelButton.Size = new System.Drawing.Size(93, 23);
            this.closeCreationNewsPanelButton.TabIndex = 4;
            this.closeCreationNewsPanelButton.Text = "Закрыть";
            this.closeCreationNewsPanelButton.UseCompatibleTextRendering = true;
            this.closeCreationNewsPanelButton.UseVisualStyleBackColor = true;
            // 
            // sendButton
            // 
            this.sendButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sendButton.Location = new System.Drawing.Point(11, 263);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(93, 23);
            this.sendButton.TabIndex = 3;
            this.sendButton.Text = "Отправить";
            this.sendButton.UseCompatibleTextRendering = true;
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // mainBodyRTBox
            // 
            this.mainBodyRTBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainBodyRTBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainBodyRTBox.Location = new System.Drawing.Point(9, 82);
            this.mainBodyRTBox.Name = "mainBodyRTBox";
            this.mainBodyRTBox.Size = new System.Drawing.Size(511, 118);
            this.mainBodyRTBox.TabIndex = 3;
            this.mainBodyRTBox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Основная часть:";
            // 
            // headerTBox
            // 
            this.headerTBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.headerTBox.Location = new System.Drawing.Point(138, 28);
            this.headerTBox.Name = "headerTBox";
            this.headerTBox.Size = new System.Drawing.Size(382, 22);
            this.headerTBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Заголовок:";
            // 
            // addPhotosButton
            // 
            this.addPhotosButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addPhotosButton.Location = new System.Drawing.Point(340, 234);
            this.addPhotosButton.Name = "addPhotosButton";
            this.addPhotosButton.Size = new System.Drawing.Size(180, 23);
            this.addPhotosButton.TabIndex = 5;
            this.addPhotosButton.Text = "Добавить фотографию....\r\n";
            this.addPhotosButton.UseCompatibleTextRendering = true;
            this.addPhotosButton.UseVisualStyleBackColor = true;
            this.addPhotosButton.Click += new System.EventHandler(this.addPhotosButton_Click);
            // 
            // pathToPhotoTBox
            // 
            this.pathToPhotoTBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pathToPhotoTBox.Location = new System.Drawing.Point(138, 206);
            this.pathToPhotoTBox.Name = "pathToPhotoTBox";
            this.pathToPhotoTBox.Size = new System.Drawing.Size(381, 22);
            this.pathToPhotoTBox.TabIndex = 6;
            // 
            // viewSelectedPhotoPBox
            // 
            this.viewSelectedPhotoPBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.viewSelectedPhotoPBox.Image = ((System.Drawing.Image)(resources.GetObject("viewSelectedPhotoPBox.Image")));
            this.viewSelectedPhotoPBox.Location = new System.Drawing.Point(11, 207);
            this.viewSelectedPhotoPBox.Name = "viewSelectedPhotoPBox";
            this.viewSelectedPhotoPBox.Size = new System.Drawing.Size(100, 50);
            this.viewSelectedPhotoPBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.viewSelectedPhotoPBox.TabIndex = 7;
            this.viewSelectedPhotoPBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 347);
            this.Controls.Add(this.createNewsGBox);
            this.Controls.Add(this.openCreationNewsPanelButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Новостное агенство Поток - Панель управления";
            this.createNewsGBox.ResumeLayout(false);
            this.createNewsGBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewSelectedPhotoPBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openCreationNewsPanelButton;
        private System.Windows.Forms.GroupBox createNewsGBox;
        private System.Windows.Forms.Button closeCreationNewsPanelButton;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.RichTextBox mainBodyRTBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox headerTBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addPhotosButton;
        private System.Windows.Forms.TextBox pathToPhotoTBox;
        private System.Windows.Forms.PictureBox viewSelectedPhotoPBox;
    }
}

