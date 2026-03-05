namespace DatabaseService.Client
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
            btnConnect = new Button();
            btnGetVersion = new Button();
            btnDisconnect = new Button();
            txtResult = new TextBox();
            SuspendLayout();
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(299, 160);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(75, 23);
            btnConnect.TabIndex = 0;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click_1;
            // 
            // btnGetVersion
            // 
            btnGetVersion.Location = new Point(639, 113);
            btnGetVersion.Name = "btnGetVersion";
            btnGetVersion.Size = new Size(75, 23);
            btnGetVersion.TabIndex = 1;
            btnGetVersion.Text = "GetVersion";
            btnGetVersion.UseVisualStyleBackColor = true;
            btnGetVersion.Click += btnGetVersion_Click_1;
            // 
            // btnDisconnect
            // 
            btnDisconnect.Location = new Point(445, 160);
            btnDisconnect.Name = "btnDisconnect";
            btnDisconnect.Size = new Size(75, 23);
            btnDisconnect.TabIndex = 2;
            btnDisconnect.Text = "Disconnect";
            btnDisconnect.UseVisualStyleBackColor = true;
            btnDisconnect.Click += btnDisconnect_Click_1;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(180, 114);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(424, 23);
            txtResult.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtResult);
            Controls.Add(btnDisconnect);
            Controls.Add(btnGetVersion);
            Controls.Add(btnConnect);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConnect;
        private Button btnGetVersion;
        private Button btnDisconnect;
        private TextBox txtResult;
    }
}
