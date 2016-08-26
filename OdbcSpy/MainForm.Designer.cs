namespace OdbcSpy
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ExecuteButton = new System.Windows.Forms.Button();
            this.Results = new System.Windows.Forms.TextBox();
            this.QueryBox = new System.Windows.Forms.TextBox();
            this.CopyButton = new System.Windows.Forms.Button();
            this.ConnectionStringBox = new System.Windows.Forms.TextBox();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExecuteButton
            // 
            this.ExecuteButton.Location = new System.Drawing.Point(555, 45);
            this.ExecuteButton.Name = "ExecuteButton";
            this.ExecuteButton.Size = new System.Drawing.Size(127, 27);
            this.ExecuteButton.TabIndex = 0;
            this.ExecuteButton.Text = "E&xecute query (F5)";
            this.ExecuteButton.UseVisualStyleBackColor = true;
            this.ExecuteButton.Click += new System.EventHandler(this.ExecuteButton_Click);
            // 
            // Results
            // 
            this.Results.AcceptsReturn = true;
            this.Results.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Results.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Results.Location = new System.Drawing.Point(12, 138);
            this.Results.Multiline = true;
            this.Results.Name = "Results";
            this.Results.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Results.Size = new System.Drawing.Size(670, 326);
            this.Results.TabIndex = 1;
            // 
            // QueryBox
            // 
            this.QueryBox.AcceptsReturn = true;
            this.QueryBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QueryBox.Location = new System.Drawing.Point(12, 45);
            this.QueryBox.Multiline = true;
            this.QueryBox.Name = "QueryBox";
            this.QueryBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.QueryBox.Size = new System.Drawing.Size(537, 87);
            this.QueryBox.TabIndex = 2;
            this.QueryBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.QueryBox_KeyUp);
            // 
            // CopyButton
            // 
            this.CopyButton.Location = new System.Drawing.Point(555, 105);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(127, 27);
            this.CopyButton.TabIndex = 3;
            this.CopyButton.Text = "&Copy results";
            this.CopyButton.UseVisualStyleBackColor = true;
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // ConnectionStringBox
            // 
            this.ConnectionStringBox.AcceptsReturn = true;
            this.ConnectionStringBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectionStringBox.Location = new System.Drawing.Point(12, 12);
            this.ConnectionStringBox.Multiline = true;
            this.ConnectionStringBox.Name = "ConnectionStringBox";
            this.ConnectionStringBox.Size = new System.Drawing.Size(537, 27);
            this.ConnectionStringBox.TabIndex = 4;
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(555, 12);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(127, 27);
            this.ConnectButton.TabIndex = 5;
            this.ConnectButton.Text = "Co&nnect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.Connect_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Enabled = false;
            this.cancelButton.Location = new System.Drawing.Point(555, 72);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(127, 27);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 476);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.ConnectionStringBox);
            this.Controls.Add(this.CopyButton);
            this.Controls.Add(this.QueryBox);
            this.Controls.Add(this.Results);
            this.Controls.Add(this.ExecuteButton);
            this.Name = "MainForm";
            this.Text = "ODBC Spy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExecuteButton;
        private System.Windows.Forms.TextBox Results;
        private System.Windows.Forms.TextBox QueryBox;
        private System.Windows.Forms.Button CopyButton;
        private System.Windows.Forms.TextBox ConnectionStringBox;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Button cancelButton;
    }
}

