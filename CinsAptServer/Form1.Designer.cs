namespace CinsAptServer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
      

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.weather = new System.Windows.Forms.Label();
            this.currentWeatherText = new System.Windows.Forms.Label();
            this.currency = new System.Windows.Forms.Label();
            this.currencyText = new System.Windows.Forms.Label();
            this.CardReaderInfoText = new System.Windows.Forms.Label();
            this.cardReaderListbox = new System.Windows.Forms.ListBox();
            this.clientsListBox = new System.Windows.Forms.ListBox();
            this.connectionsText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // weather
            // 
            this.weather.AutoSize = true;
            this.weather.Location = new System.Drawing.Point(287, 21);
            this.weather.Name = "weather";
            this.weather.Size = new System.Drawing.Size(127, 20);
            this.weather.TabIndex = 0;
            this.weather.Text = "Current Weather : ";
          
            // 
            // currentWeatherText
            // 
            this.currentWeatherText.AutoSize = true;
            this.currentWeatherText.Location = new System.Drawing.Point(287, 52);
            this.currentWeatherText.Name = "currentWeatherText";
            this.currentWeatherText.Size = new System.Drawing.Size(33, 20);
            this.currentWeatherText.TabIndex = 1;
            this.currentWeatherText.Text = "null";
            // 
            // currency
            // 
            this.currency.AutoSize = true;
            this.currency.Location = new System.Drawing.Point(39, 21);
            this.currency.Name = "currency";
            this.currency.Size = new System.Drawing.Size(132, 20);
            this.currency.TabIndex = 2;
            this.currency.Text = "Currecy Exchange :";
            // 
            // currencyText
            // 
            this.currencyText.AutoSize = true;
            this.currencyText.Location = new System.Drawing.Point(39, 52);
            this.currencyText.Name = "currencyText";
            this.currencyText.Size = new System.Drawing.Size(33, 20);
            this.currencyText.TabIndex = 3;
            this.currencyText.Text = "null";
            // 
            // CardReaderInfoText
            // 
            this.CardReaderInfoText.AutoSize = true;
            this.CardReaderInfoText.Location = new System.Drawing.Point(50, 138);
            this.CardReaderInfoText.Name = "CardReaderInfoText";
            this.CardReaderInfoText.Size = new System.Drawing.Size(124, 20);
            this.CardReaderInfoText.TabIndex = 4;
            this.CardReaderInfoText.Text = "Card Reader Info:";
          
            // 
            // cardReaderListbox
            // 
            this.cardReaderListbox.FormattingEnabled = true;
            this.cardReaderListbox.ItemHeight = 20;
            this.cardReaderListbox.Location = new System.Drawing.Point(50, 161);
            this.cardReaderListbox.Name = "cardReaderListbox";
            this.cardReaderListbox.Size = new System.Drawing.Size(339, 204);
            this.cardReaderListbox.TabIndex = 5;
            // 
            // clientsListBox
            // 
            this.clientsListBox.FormattingEnabled = true;
            this.clientsListBox.ItemHeight = 20;
            this.clientsListBox.Location = new System.Drawing.Point(475, 127);
            this.clientsListBox.Name = "clientsListBox";
            this.clientsListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.clientsListBox.Size = new System.Drawing.Size(313, 244);
            this.clientsListBox.TabIndex = 9;
            this.clientsListBox.SelectedIndexChanged += new System.EventHandler(this.clientsListBox_SelectedIndexChanged);
            // 
            // connectionsText
            // 
            this.connectionsText.AutoSize = true;
            this.connectionsText.Location = new System.Drawing.Point(591, 104);
            this.connectionsText.Name = "connectionsText";
            this.connectionsText.Size = new System.Drawing.Size(93, 20);
            this.connectionsText.TabIndex = 10;
            this.connectionsText.Text = "Connections:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.connectionsText);
            this.Controls.Add(this.clientsListBox);
            this.Controls.Add(this.cardReaderListbox);
            this.Controls.Add(this.CardReaderInfoText);
            this.Controls.Add(this.currencyText);
            this.Controls.Add(this.currency);
            this.Controls.Add(this.currentWeatherText);
            this.Controls.Add(this.weather);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label weather;
        private Label currentWeatherText;
        private Label currency;
        private Label currencyText;
        private Label CardReaderInfoText;
        private ListBox cardReaderListbox;
        private ListBox clientsListBox;
        private Label connectionsText;
    }
}