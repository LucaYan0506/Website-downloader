
namespace Website_downloader
{
    partial class Form1
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
            this.downloadBtn = new System.Windows.Forms.Button();
            this.f_nameTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.urlTxt = new System.Windows.Forms.TextBox();
            this.displayBtn = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.protocolComboBx = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // downloadBtn
            // 
            this.downloadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downloadBtn.Location = new System.Drawing.Point(733, 14);
            this.downloadBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.downloadBtn.Name = "downloadBtn";
            this.downloadBtn.Size = new System.Drawing.Size(112, 30);
            this.downloadBtn.TabIndex = 3;
            this.downloadBtn.Text = "Download";
            this.downloadBtn.UseVisualStyleBackColor = true;
            this.downloadBtn.Click += new System.EventHandler(this.download_btn_Click);
            // 
            // f_nameTxt
            // 
            this.f_nameTxt.Location = new System.Drawing.Point(175, 48);
            this.f_nameTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.f_nameTxt.Name = "f_nameTxt";
            this.f_nameTxt.Size = new System.Drawing.Size(552, 26);
            this.f_nameTxt.TabIndex = 2;
            this.f_nameTxt.Text = "name of the html file";
            this.f_nameTxt.Enter += new System.EventHandler(this.f_nameTxt_Enter);
            this.f_nameTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.f_nameTxt_KeyDown);
            this.f_nameTxt.Leave += new System.EventHandler(this.f_nameTxt_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Save the html file as";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Website url";
            // 
            // urlTxt
            // 
            this.urlTxt.Location = new System.Drawing.Point(261, 16);
            this.urlTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.urlTxt.Name = "urlTxt";
            this.urlTxt.Size = new System.Drawing.Size(466, 26);
            this.urlTxt.TabIndex = 1;
            this.urlTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.urlTxt_Keydown);
            this.urlTxt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.urlTxt_KeyUp);
            // 
            // displayBtn
            // 
            this.displayBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayBtn.Location = new System.Drawing.Point(733, 44);
            this.displayBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.displayBtn.Name = "displayBtn";
            this.displayBtn.Size = new System.Drawing.Size(112, 30);
            this.displayBtn.TabIndex = 4;
            this.displayBtn.Text = "Display";
            this.displayBtn.UseVisualStyleBackColor = true;
            this.displayBtn.Click += new System.EventHandler(this.displayBtn_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.webBrowser1.Location = new System.Drawing.Point(0, 92);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(858, 419);
            this.webBrowser1.TabIndex = 5;
            // 
            // protocolComboBx
            // 
            this.protocolComboBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.protocolComboBx.FormattingEnabled = true;
            this.protocolComboBx.Location = new System.Drawing.Point(175, 17);
            this.protocolComboBx.Name = "protocolComboBx";
            this.protocolComboBx.Size = new System.Drawing.Size(79, 26);
            this.protocolComboBx.TabIndex = 6;
            this.protocolComboBx.Text = "HTTPS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 511);
            this.Controls.Add(this.protocolComboBx);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.f_nameTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.urlTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.displayBtn);
            this.Controls.Add(this.downloadBtn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(874, 0);
            this.Name = "Form1";
            this.Text = "Website downloader";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button downloadBtn;
        private System.Windows.Forms.TextBox f_nameTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox urlTxt;
        private System.Windows.Forms.Button displayBtn;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ComboBox protocolComboBx;
    }
}

