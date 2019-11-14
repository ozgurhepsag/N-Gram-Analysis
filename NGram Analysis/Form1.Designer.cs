namespace NGram_Analysis
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
            this.groupBoxInput = new System.Windows.Forms.GroupBox();
            this.browseFileName = new System.Windows.Forms.TextBox();
            this.browseFileBtn = new System.Windows.Forms.Button();
            this.trigramDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.unigramDataGridView = new System.Windows.Forms.DataGridView();
            this.bigramDataGridView = new System.Windows.Forms.DataGridView();
            this.unigramMsec = new System.Windows.Forms.Label();
            this.bigramMsec = new System.Windows.Forms.Label();
            this.trigramMsec = new System.Windows.Forms.Label();
            this.groupBoxInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trigramDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unigramDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bigramDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxInput
            // 
            this.groupBoxInput.Controls.Add(this.browseFileName);
            this.groupBoxInput.Controls.Add(this.browseFileBtn);
            this.groupBoxInput.Location = new System.Drawing.Point(193, 29);
            this.groupBoxInput.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxInput.Name = "groupBoxInput";
            this.groupBoxInput.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxInput.Size = new System.Drawing.Size(920, 69);
            this.groupBoxInput.TabIndex = 3;
            this.groupBoxInput.TabStop = false;
            this.groupBoxInput.Text = "Select Your Corpus";
            // 
            // browseFileName
            // 
            this.browseFileName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.browseFileName.Location = new System.Drawing.Point(22, 23);
            this.browseFileName.Margin = new System.Windows.Forms.Padding(4);
            this.browseFileName.Name = "browseFileName";
            this.browseFileName.ReadOnly = true;
            this.browseFileName.Size = new System.Drawing.Size(782, 22);
            this.browseFileName.TabIndex = 0;
            this.browseFileName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // browseFileBtn
            // 
            this.browseFileBtn.Location = new System.Drawing.Point(812, 19);
            this.browseFileBtn.Margin = new System.Windows.Forms.Padding(4);
            this.browseFileBtn.Name = "browseFileBtn";
            this.browseFileBtn.Size = new System.Drawing.Size(100, 28);
            this.browseFileBtn.TabIndex = 0;
            this.browseFileBtn.Text = "Browse...";
            this.browseFileBtn.UseVisualStyleBackColor = true;
            this.browseFileBtn.Click += new System.EventHandler(this.BrowseFileBtn_Click);
            // 
            // trigramDataGridView
            // 
            this.trigramDataGridView.AllowUserToAddRows = false;
            this.trigramDataGridView.AllowUserToDeleteRows = false;
            this.trigramDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.trigramDataGridView.Location = new System.Drawing.Point(903, 157);
            this.trigramDataGridView.Name = "trigramDataGridView";
            this.trigramDataGridView.ReadOnly = true;
            this.trigramDataGridView.RowHeadersWidth = 51;
            this.trigramDataGridView.RowTemplate.Height = 24;
            this.trigramDataGridView.Size = new System.Drawing.Size(360, 346);
            this.trigramDataGridView.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(140, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Top Unigrams";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(583, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Top Bigrams";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(1019, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Top Trigrams";
            // 
            // unigramDataGridView
            // 
            this.unigramDataGridView.AllowUserToAddRows = false;
            this.unigramDataGridView.AllowUserToDeleteRows = false;
            this.unigramDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.unigramDataGridView.Location = new System.Drawing.Point(42, 157);
            this.unigramDataGridView.Name = "unigramDataGridView";
            this.unigramDataGridView.ReadOnly = true;
            this.unigramDataGridView.RowHeadersWidth = 51;
            this.unigramDataGridView.RowTemplate.Height = 24;
            this.unigramDataGridView.Size = new System.Drawing.Size(360, 346);
            this.unigramDataGridView.TabIndex = 12;
            // 
            // bigramDataGridView
            // 
            this.bigramDataGridView.AllowUserToAddRows = false;
            this.bigramDataGridView.AllowUserToDeleteRows = false;
            this.bigramDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bigramDataGridView.Location = new System.Drawing.Point(474, 157);
            this.bigramDataGridView.Name = "bigramDataGridView";
            this.bigramDataGridView.ReadOnly = true;
            this.bigramDataGridView.RowHeadersWidth = 51;
            this.bigramDataGridView.RowTemplate.Height = 24;
            this.bigramDataGridView.Size = new System.Drawing.Size(360, 346);
            this.bigramDataGridView.TabIndex = 13;
            // 
            // unigramMsec
            // 
            this.unigramMsec.AutoSize = true;
            this.unigramMsec.Location = new System.Drawing.Point(172, 521);
            this.unigramMsec.Name = "unigramMsec";
            this.unigramMsec.Size = new System.Drawing.Size(0, 17);
            this.unigramMsec.TabIndex = 14;
            // 
            // bigramMsec
            // 
            this.bigramMsec.AutoSize = true;
            this.bigramMsec.Location = new System.Drawing.Point(623, 521);
            this.bigramMsec.Name = "bigramMsec";
            this.bigramMsec.Size = new System.Drawing.Size(0, 17);
            this.bigramMsec.TabIndex = 15;
            // 
            // trigramMsec
            // 
            this.trigramMsec.AutoSize = true;
            this.trigramMsec.Location = new System.Drawing.Point(1059, 521);
            this.trigramMsec.Name = "trigramMsec";
            this.trigramMsec.Size = new System.Drawing.Size(0, 17);
            this.trigramMsec.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 563);
            this.Controls.Add(this.trigramMsec);
            this.Controls.Add(this.bigramMsec);
            this.Controls.Add(this.unigramMsec);
            this.Controls.Add(this.bigramDataGridView);
            this.Controls.Add(this.unigramDataGridView);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trigramDataGridView);
            this.Controls.Add(this.groupBoxInput);
            this.Name = "Form1";
            this.Text = "N-Gram Analysis";
            this.groupBoxInput.ResumeLayout(false);
            this.groupBoxInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trigramDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unigramDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bigramDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxInput;
        private System.Windows.Forms.TextBox browseFileName;
        private System.Windows.Forms.Button browseFileBtn;
        private System.Windows.Forms.DataGridView trigramDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView unigramDataGridView;
        private System.Windows.Forms.DataGridView bigramDataGridView;
        private System.Windows.Forms.Label unigramMsec;
        private System.Windows.Forms.Label bigramMsec;
        private System.Windows.Forms.Label trigramMsec;
    }
}

