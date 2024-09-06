
namespace DICOMSEND
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.UploadButton = new System.Windows.Forms.Button();
            this.ConsoleBox = new System.Windows.Forms.TextBox();
            this.FolderButton = new System.Windows.Forms.Button();
            this.FolderPathBox = new System.Windows.Forms.TextBox();
            this.LabelHost = new System.Windows.Forms.Label();
            this.HostBox = new System.Windows.Forms.TextBox();
            this.LablePort = new System.Windows.Forms.Label();
            this.PortBox = new System.Windows.Forms.TextBox();
            this.LabelAEC = new System.Windows.Forms.Label();
            this.AECBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.IDBox = new System.Windows.Forms.TextBox();
            this.AETBox = new System.Windows.Forms.TextBox();
            this.labelPatientID = new System.Windows.Forms.Label();
            this.LabelAET = new System.Windows.Forms.Label();
            this.LabelCount = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UploadButton
            // 
            this.UploadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UploadButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UploadButton.Location = new System.Drawing.Point(654, 20);
            this.UploadButton.Name = "UploadButton";
            this.UploadButton.Size = new System.Drawing.Size(100, 66);
            this.UploadButton.TabIndex = 8;
            this.UploadButton.TabStop = false;
            this.UploadButton.Text = "Upload";
            this.UploadButton.UseVisualStyleBackColor = true;
            this.UploadButton.Click += new System.EventHandler(this.Upload_Click);
            // 
            // ConsoleBox
            // 
            this.ConsoleBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConsoleBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsoleBox.Location = new System.Drawing.Point(12, 148);
            this.ConsoleBox.MaxLength = 2147483647;
            this.ConsoleBox.Multiline = true;
            this.ConsoleBox.Name = "ConsoleBox";
            this.ConsoleBox.ReadOnly = true;
            this.ConsoleBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ConsoleBox.Size = new System.Drawing.Size(760, 348);
            this.ConsoleBox.TabIndex = 5;
            this.ConsoleBox.TabStop = false;
            // 
            // FolderButton
            // 
            this.FolderButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FolderButton.Location = new System.Drawing.Point(6, 20);
            this.FolderButton.Name = "FolderButton";
            this.FolderButton.Size = new System.Drawing.Size(85, 29);
            this.FolderButton.TabIndex = 0;
            this.FolderButton.TabStop = false;
            this.FolderButton.Text = "Folder\r\n";
            this.FolderButton.UseVisualStyleBackColor = true;
            this.FolderButton.Click += new System.EventHandler(this.FolderButton_Click);
            // 
            // FolderPathBox
            // 
            this.FolderPathBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FolderPathBox.Location = new System.Drawing.Point(97, 20);
            this.FolderPathBox.Name = "FolderPathBox";
            this.FolderPathBox.Size = new System.Drawing.Size(374, 22);
            this.FolderPathBox.TabIndex = 1;
            // 
            // LabelHost
            // 
            this.LabelHost.AutoSize = true;
            this.LabelHost.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelHost.Location = new System.Drawing.Point(12, 61);
            this.LabelHost.Name = "LabelHost";
            this.LabelHost.Size = new System.Drawing.Size(34, 16);
            this.LabelHost.TabIndex = 4;
            this.LabelHost.Text = "Host";
            // 
            // HostBox
            // 
            this.HostBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HostBox.Location = new System.Drawing.Point(52, 55);
            this.HostBox.Name = "HostBox";
            this.HostBox.Size = new System.Drawing.Size(138, 22);
            this.HostBox.TabIndex = 3;
            // 
            // LablePort
            // 
            this.LablePort.AutoSize = true;
            this.LablePort.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LablePort.Location = new System.Drawing.Point(203, 61);
            this.LablePort.Name = "LablePort";
            this.LablePort.Size = new System.Drawing.Size(31, 16);
            this.LablePort.TabIndex = 4;
            this.LablePort.Text = "Port";
            // 
            // PortBox
            // 
            this.PortBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PortBox.Location = new System.Drawing.Point(240, 55);
            this.PortBox.Name = "PortBox";
            this.PortBox.Size = new System.Drawing.Size(59, 22);
            this.PortBox.TabIndex = 4;
            // 
            // LabelAEC
            // 
            this.LabelAEC.AutoSize = true;
            this.LabelAEC.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelAEC.Location = new System.Drawing.Point(481, 61);
            this.LabelAEC.Name = "LabelAEC";
            this.LabelAEC.Size = new System.Drawing.Size(34, 16);
            this.LabelAEC.TabIndex = 4;
            this.LabelAEC.Text = "AEC";
            // 
            // AECBox
            // 
            this.AECBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AECBox.Location = new System.Drawing.Point(521, 55);
            this.AECBox.Name = "AECBox";
            this.AECBox.Size = new System.Drawing.Size(121, 22);
            this.AECBox.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.UploadButton);
            this.groupBox1.Controls.Add(this.IDBox);
            this.groupBox1.Controls.Add(this.AETBox);
            this.groupBox1.Controls.Add(this.AECBox);
            this.groupBox1.Controls.Add(this.FolderPathBox);
            this.groupBox1.Controls.Add(this.labelPatientID);
            this.groupBox1.Controls.Add(this.LabelAET);
            this.groupBox1.Controls.Add(this.LabelAEC);
            this.groupBox1.Controls.Add(this.FolderButton);
            this.groupBox1.Controls.Add(this.PortBox);
            this.groupBox1.Controls.Add(this.LabelHost);
            this.groupBox1.Controls.Add(this.LablePort);
            this.groupBox1.Controls.Add(this.HostBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 94);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Config";
            // 
            // IDBox
            // 
            this.IDBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IDBox.Location = new System.Drawing.Point(521, 20);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(121, 22);
            this.IDBox.TabIndex = 2;
            // 
            // AETBox
            // 
            this.AETBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AETBox.Location = new System.Drawing.Point(350, 55);
            this.AETBox.Name = "AETBox";
            this.AETBox.Size = new System.Drawing.Size(121, 22);
            this.AETBox.TabIndex = 5;
            // 
            // labelPatientID
            // 
            this.labelPatientID.AutoSize = true;
            this.labelPatientID.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPatientID.Location = new System.Drawing.Point(492, 23);
            this.labelPatientID.Name = "labelPatientID";
            this.labelPatientID.Size = new System.Drawing.Size(19, 16);
            this.labelPatientID.TabIndex = 4;
            this.labelPatientID.Text = "ID";
            // 
            // LabelAET
            // 
            this.LabelAET.AutoSize = true;
            this.LabelAET.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelAET.Location = new System.Drawing.Point(312, 61);
            this.LabelAET.Name = "LabelAET";
            this.LabelAET.Size = new System.Drawing.Size(32, 16);
            this.LabelAET.TabIndex = 4;
            this.LabelAET.Text = "AET";
            // 
            // LabelCount
            // 
            this.LabelCount.AutoSize = true;
            this.LabelCount.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.LabelCount.Location = new System.Drawing.Point(18, 119);
            this.LabelCount.Name = "LabelCount";
            this.LabelCount.Size = new System.Drawing.Size(0, 20);
            this.LabelCount.TabIndex = 7;
            this.LabelCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 510);
            this.Controls.Add(this.LabelCount);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ConsoleBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "DICOM Uploader";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UploadButton;
        private System.Windows.Forms.TextBox ConsoleBox;
        private System.Windows.Forms.Button FolderButton;
        private System.Windows.Forms.TextBox FolderPathBox;
        private System.Windows.Forms.Label LabelHost;
        private System.Windows.Forms.TextBox HostBox;
        private System.Windows.Forms.Label LablePort;
        private System.Windows.Forms.TextBox PortBox;
        private System.Windows.Forms.Label LabelAEC;
        private System.Windows.Forms.TextBox AECBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox IDBox;
        private System.Windows.Forms.Label labelPatientID;
        private System.Windows.Forms.Label LabelCount;
        private System.Windows.Forms.TextBox AETBox;
        private System.Windows.Forms.Label LabelAET;
    }
}

