namespace ProjectVespar
{
    partial class vespar
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
            this.enable = new System.Windows.Forms.Button();
            this.disable = new System.Windows.Forms.Button();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.SuspendLayout();
            // 
            // enable
            // 
            this.enable.Location = new System.Drawing.Point(79, 180);
            this.enable.Name = "enable";
            this.enable.Size = new System.Drawing.Size(131, 28);
            this.enable.TabIndex = 0;
            this.enable.Text = "Enable";
            this.enable.UseVisualStyleBackColor = true;
            this.enable.Click += new System.EventHandler(this.enable_Click);
            // 
            // disable
            // 
            this.disable.Location = new System.Drawing.Point(79, 221);
            this.disable.Name = "disable";
            this.disable.Size = new System.Drawing.Size(131, 28);
            this.disable.TabIndex = 1;
            this.disable.Text = "Disable";
            this.disable.UseVisualStyleBackColor = true;
            this.disable.Click += new System.EventHandler(this.disable_Click);
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(260, 162);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // vespar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.disable);
            this.Controls.Add(this.enable);
            this.Name = "vespar";
            this.Text = "VESPAR";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button enable;
        private System.Windows.Forms.Button disable;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

