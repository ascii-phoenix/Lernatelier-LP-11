using System;
using System.Windows.Forms;
using System.Collections.Generic;
using Microsoft.Extensions.AI;
using OllamaSharp;

namespace Ollama
{
    public partial class OllamaPane : UserControl
    {
        private IChatClient chatClient;

        public OllamaPane(IChatClient client)
        {
            InitializeComponent();
            chatClient = client;
        }

        private async void buttonSend_Click(object sender, EventArgs e)
        {
            string input = textBoxInput.Text;
            if (!string.IsNullOrWhiteSpace(input))
            {
                // Chat-Nachricht erstellen
            var messages = new List<ChatMessage>
            {
                new ChatMessage(ChatRole.User, input)
            };
            var response = await chatClient.GetResponseAsync(messages);
            textBoxOutput.Invoke((Action)(() => textBoxOutput.Text = response.Text));
            }
        }



        private void InitializeComponent()
        {
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();

            this.textBoxInput.Location = new System.Drawing.Point(10, 10);
            this.textBoxInput.Size = new System.Drawing.Size(280, 26);

            this.buttonSend.Location = new System.Drawing.Point(10, 45);
            this.buttonSend.Size = new System.Drawing.Size(75, 30);
            this.buttonSend.Text = "Send";
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);

            this.textBoxOutput.Location = new System.Drawing.Point(10, 85);
            this.textBoxOutput.Size = new System.Drawing.Size(280, 200);
            this.textBoxOutput.Multiline = true;

            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.textBoxOutput);
            this.Size = new System.Drawing.Size(300, 300);
            this.ResumeLayout(false);
        }

        private TextBox textBoxInput;
        private Button buttonSend;
        private TextBox textBoxOutput;
    }
}
