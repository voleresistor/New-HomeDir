namespace New_HomeDirFolder
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.userNameTxt = new System.Windows.Forms.TextBox();
            this.homedirRootTxt = new System.Windows.Forms.TextBox();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.homedirRootLabel = new System.Windows.Forms.Label();
            this.domainNameLabel = new System.Windows.Forms.Label();
            this.domainNameTxt = new System.Windows.Forms.TextBox();
            this.resultsTxt = new System.Windows.Forms.TextBox();
            this.createHomedir = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Controls.Add(this.userNameTxt, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.homedirRootTxt, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.userNameLabel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.homedirRootLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.domainNameTxt, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.resultsTxt, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.createHomedir, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.domainNameLabel, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(534, 311);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // userNameTxt
            // 
            this.userNameTxt.Location = new System.Drawing.Point(135, 49);
            this.userNameTxt.Name = "userNameTxt";
            this.userNameTxt.Size = new System.Drawing.Size(367, 20);
            this.userNameTxt.TabIndex = 2;
            // 
            // homedirRootTxt
            // 
            this.homedirRootTxt.Location = new System.Drawing.Point(135, 18);
            this.homedirRootTxt.Name = "homedirRootTxt";
            this.homedirRootTxt.Size = new System.Drawing.Size(367, 20);
            this.homedirRootTxt.TabIndex = 1;
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(29, 46);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Padding = new System.Windows.Forms.Padding(8, 5, 8, 8);
            this.userNameLabel.Size = new System.Drawing.Size(74, 26);
            this.userNameLabel.TabIndex = 0;
            this.userNameLabel.Text = "Username:";
            this.userNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // homedirRootLabel
            // 
            this.homedirRootLabel.AutoSize = true;
            this.homedirRootLabel.Location = new System.Drawing.Point(29, 15);
            this.homedirRootLabel.Name = "homedirRootLabel";
            this.homedirRootLabel.Padding = new System.Windows.Forms.Padding(8, 5, 8, 8);
            this.homedirRootLabel.Size = new System.Drawing.Size(86, 26);
            this.homedirRootLabel.TabIndex = 0;
            this.homedirRootLabel.Text = "Homedir root:";
            this.homedirRootLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // domainNameLabel
            // 
            this.domainNameLabel.AutoSize = true;
            this.domainNameLabel.Location = new System.Drawing.Point(29, 77);
            this.domainNameLabel.Name = "domainNameLabel";
            this.domainNameLabel.Padding = new System.Windows.Forms.Padding(8, 5, 8, 8);
            this.domainNameLabel.Size = new System.Drawing.Size(91, 26);
            this.domainNameLabel.TabIndex = 0;
            this.domainNameLabel.Text = "Domain name:";
            this.domainNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // domainNameTxt
            // 
            this.domainNameTxt.Location = new System.Drawing.Point(135, 80);
            this.domainNameTxt.Name = "domainNameTxt";
            this.domainNameTxt.Size = new System.Drawing.Size(367, 20);
            this.domainNameTxt.TabIndex = 3;
            // 
            // resultsTxt
            // 
            this.resultsTxt.Location = new System.Drawing.Point(135, 111);
            this.resultsTxt.Multiline = true;
            this.resultsTxt.Name = "resultsTxt";
            this.resultsTxt.ReadOnly = true;
            this.resultsTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.resultsTxt.Size = new System.Drawing.Size(367, 118);
            this.resultsTxt.TabIndex = 0;
            this.resultsTxt.TabStop = false;
            // 
            // createHomedir
            // 
            this.createHomedir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.createHomedir.Location = new System.Drawing.Point(135, 266);
            this.createHomedir.Name = "createHomedir";
            this.createHomedir.Size = new System.Drawing.Size(367, 25);
            this.createHomedir.TabIndex = 4;
            this.createHomedir.Text = "Create";
            this.createHomedir.UseVisualStyleBackColor = true;
            this.createHomedir.Click += new System.EventHandler(this.createHomedir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(534, 311);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "New-HomeDirFolder";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox homedirRootTxt;
        private System.Windows.Forms.Label homedirRootLabel;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.TextBox userNameTxt;
        private System.Windows.Forms.Label domainNameLabel;
        private System.Windows.Forms.TextBox domainNameTxt;
        private System.Windows.Forms.TextBox resultsTxt;
        private System.Windows.Forms.Button createHomedir;
    }
}

