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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.weatherLabel = new System.Windows.Forms.Label();
            this.degreeLabel = new System.Windows.Forms.Label();
            this.usdLabel = new System.Windows.Forms.Label();
            this.eurLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
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
            this.currentWeatherText.Size = new System.Drawing.Size(61, 20);
            this.currentWeatherText.TabIndex = 1;
            this.currentWeatherText.Text = "Degree:";
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
            this.currencyText.Size = new System.Drawing.Size(41, 20);
            this.currencyText.TabIndex = 3;
            this.currencyText.Text = "USD:";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "EUR:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(287, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Weather: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(287, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "City:";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(326, 82);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(33, 20);
            this.cityLabel.TabIndex = 14;
            this.cityLabel.Text = "null";
            // 
            // weatherLabel
            // 
            this.weatherLabel.AutoSize = true;
            this.weatherLabel.Location = new System.Drawing.Point(356, 116);
            this.weatherLabel.Name = "weatherLabel";
            this.weatherLabel.Size = new System.Drawing.Size(33, 20);
            this.weatherLabel.TabIndex = 15;
            this.weatherLabel.Text = "null";
            // 
            // degreeLabel
            // 
            this.degreeLabel.AutoSize = true;
            this.degreeLabel.Location = new System.Drawing.Point(356, 52);
            this.degreeLabel.Name = "degreeLabel";
            this.degreeLabel.Size = new System.Drawing.Size(33, 20);
            this.degreeLabel.TabIndex = 16;
            this.degreeLabel.Text = "null";
            // 
            // usdLabel
            // 
            this.usdLabel.AutoSize = true;
            this.usdLabel.Location = new System.Drawing.Point(96, 52);
            this.usdLabel.Name = "usdLabel";
            this.usdLabel.Size = new System.Drawing.Size(33, 20);
            this.usdLabel.TabIndex = 17;
            this.usdLabel.Text = "null";
            // 
            // eurLabel
            // 
            this.eurLabel.AutoSize = true;
            this.eurLabel.Location = new System.Drawing.Point(96, 82);
            this.eurLabel.Name = "eurLabel";
            this.eurLabel.Size = new System.Drawing.Size(33, 20);
            this.eurLabel.TabIndex = 18;
            this.eurLabel.Text = "null";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(663, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 29);
            this.button1.TabIndex = 19;
            this.button1.Text = "Start Chat Srv";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.eurLabel);
            this.Controls.Add(this.usdLabel);
            this.Controls.Add(this.degreeLabel);
            this.Controls.Add(this.weatherLabel);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private Label label1;
        private Label label2;
        private Label label3;
        private Label cityLabel;
        private Label weatherLabel;
        private Label degreeLabel;
        private Label usdLabel;
        private Label eurLabel;
        private Button button1;
    }
}