
namespace ActivationKeyGenerator
{
    partial class frmMain
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
            this.listCodes = new System.Windows.Forms.ListView();
            this.codeType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.code = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.isValid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.radioItunes = new System.Windows.Forms.RadioButton();
            this.radioGooglePlay = new System.Windows.Forms.RadioButton();
            this.radioSteam = new System.Windows.Forms.RadioButton();
            this.radioWindowsActivation = new System.Windows.Forms.RadioButton();
            this.lblCodeType = new System.Windows.Forms.Label();
            this.btnGetCodes = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.radioAll = new System.Windows.Forms.RadioButton();
            this.radioValid = new System.Windows.Forms.RadioButton();
            this.radioNotValid = new System.Windows.Forms.RadioButton();
            this.radioBoth = new System.Windows.Forms.RadioButton();
            this.groupboxValidity = new System.Windows.Forms.GroupBox();
            this.groupboxValidity.SuspendLayout();
            this.SuspendLayout();
            // 
            // listCodes
            // 
            this.listCodes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.codeType,
            this.code,
            this.isValid});
            this.listCodes.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.listCodes.GridLines = true;
            this.listCodes.HideSelection = false;
            this.listCodes.Location = new System.Drawing.Point(289, 0);
            this.listCodes.Name = "listCodes";
            this.listCodes.Size = new System.Drawing.Size(510, 449);
            this.listCodes.TabIndex = 0;
            this.listCodes.UseCompatibleStateImageBehavior = false;
            this.listCodes.View = System.Windows.Forms.View.Details;
            // 
            // codeType
            // 
            this.codeType.Text = "Type";
            this.codeType.Width = 200;
            // 
            // code
            // 
            this.code.Text = "Code";
            this.code.Width = 200;
            // 
            // isValid
            // 
            this.isValid.Text = "Valid";
            this.isValid.Width = 100;
            // 
            // radioItunes
            // 
            this.radioItunes.AutoSize = true;
            this.radioItunes.Location = new System.Drawing.Point(12, 106);
            this.radioItunes.Name = "radioItunes";
            this.radioItunes.Size = new System.Drawing.Size(54, 17);
            this.radioItunes.TabIndex = 1;
            this.radioItunes.TabStop = true;
            this.radioItunes.Text = "Itunes";
            this.radioItunes.UseVisualStyleBackColor = true;
            // 
            // radioGooglePlay
            // 
            this.radioGooglePlay.AutoSize = true;
            this.radioGooglePlay.Location = new System.Drawing.Point(12, 81);
            this.radioGooglePlay.Name = "radioGooglePlay";
            this.radioGooglePlay.Size = new System.Drawing.Size(82, 17);
            this.radioGooglePlay.TabIndex = 2;
            this.radioGooglePlay.TabStop = true;
            this.radioGooglePlay.Text = "Google Play";
            this.radioGooglePlay.UseVisualStyleBackColor = true;
            // 
            // radioSteam
            // 
            this.radioSteam.AutoSize = true;
            this.radioSteam.Location = new System.Drawing.Point(97, 58);
            this.radioSteam.Name = "radioSteam";
            this.radioSteam.Size = new System.Drawing.Size(55, 17);
            this.radioSteam.TabIndex = 3;
            this.radioSteam.TabStop = true;
            this.radioSteam.Text = "Steam";
            this.radioSteam.UseVisualStyleBackColor = true;
            // 
            // radioWindowsActivation
            // 
            this.radioWindowsActivation.AutoSize = true;
            this.radioWindowsActivation.Location = new System.Drawing.Point(97, 81);
            this.radioWindowsActivation.Name = "radioWindowsActivation";
            this.radioWindowsActivation.Size = new System.Drawing.Size(119, 17);
            this.radioWindowsActivation.TabIndex = 4;
            this.radioWindowsActivation.TabStop = true;
            this.radioWindowsActivation.Text = "Windows Activation";
            this.radioWindowsActivation.UseVisualStyleBackColor = true;
            // 
            // lblCodeType
            // 
            this.lblCodeType.AutoSize = true;
            this.lblCodeType.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblCodeType.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblCodeType.Location = new System.Drawing.Point(3, 16);
            this.lblCodeType.Name = "lblCodeType";
            this.lblCodeType.Size = new System.Drawing.Size(91, 19);
            this.lblCodeType.TabIndex = 5;
            this.lblCodeType.Text = "Code Type";
            // 
            // btnGetCodes
            // 
            this.btnGetCodes.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnGetCodes.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetCodes.ForeColor = System.Drawing.Color.White;
            this.btnGetCodes.Location = new System.Drawing.Point(7, 140);
            this.btnGetCodes.Name = "btnGetCodes";
            this.btnGetCodes.Size = new System.Drawing.Size(96, 31);
            this.btnGetCodes.TabIndex = 6;
            this.btnGetCodes.Text = "Get Codes";
            this.btnGetCodes.UseVisualStyleBackColor = false;
            this.btnGetCodes.Click += new System.EventHandler(this.btnGetCodes_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnClear.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(120, 140);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(96, 31);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // radioAll
            // 
            this.radioAll.AutoSize = true;
            this.radioAll.Location = new System.Drawing.Point(12, 58);
            this.radioAll.Name = "radioAll";
            this.radioAll.Size = new System.Drawing.Size(36, 17);
            this.radioAll.TabIndex = 8;
            this.radioAll.TabStop = true;
            this.radioAll.Text = "All";
            this.radioAll.UseVisualStyleBackColor = true;
            // 
            // radioValid
            // 
            this.radioValid.AutoSize = true;
            this.radioValid.Location = new System.Drawing.Point(6, 31);
            this.radioValid.Name = "radioValid";
            this.radioValid.Size = new System.Drawing.Size(48, 17);
            this.radioValid.TabIndex = 10;
            this.radioValid.TabStop = true;
            this.radioValid.Text = "Valid";
            this.radioValid.UseVisualStyleBackColor = true;
            // 
            // radioNotValid
            // 
            this.radioNotValid.AutoSize = true;
            this.radioNotValid.Location = new System.Drawing.Point(6, 54);
            this.radioNotValid.Name = "radioNotValid";
            this.radioNotValid.Size = new System.Drawing.Size(68, 17);
            this.radioNotValid.TabIndex = 11;
            this.radioNotValid.TabStop = true;
            this.radioNotValid.Text = "Not Valid";
            this.radioNotValid.UseVisualStyleBackColor = true;
            // 
            // radioBoth
            // 
            this.radioBoth.AutoSize = true;
            this.radioBoth.Location = new System.Drawing.Point(6, 77);
            this.radioBoth.Name = "radioBoth";
            this.radioBoth.Size = new System.Drawing.Size(47, 17);
            this.radioBoth.TabIndex = 12;
            this.radioBoth.TabStop = true;
            this.radioBoth.Text = "Both";
            this.radioBoth.UseVisualStyleBackColor = true;
            // 
            // groupboxValidity
            // 
            this.groupboxValidity.Controls.Add(this.radioBoth);
            this.groupboxValidity.Controls.Add(this.radioValid);
            this.groupboxValidity.Controls.Add(this.radioNotValid);
            this.groupboxValidity.Location = new System.Drawing.Point(12, 177);
            this.groupboxValidity.Name = "groupboxValidity";
            this.groupboxValidity.Size = new System.Drawing.Size(200, 100);
            this.groupboxValidity.TabIndex = 13;
            this.groupboxValidity.TabStop = false;
            this.groupboxValidity.Text = "Validity";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupboxValidity);
            this.Controls.Add(this.radioAll);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnGetCodes);
            this.Controls.Add(this.lblCodeType);
            this.Controls.Add(this.radioWindowsActivation);
            this.Controls.Add(this.radioSteam);
            this.Controls.Add(this.radioGooglePlay);
            this.Controls.Add(this.radioItunes);
            this.Controls.Add(this.listCodes);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupboxValidity.ResumeLayout(false);
            this.groupboxValidity.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listCodes;
        private System.Windows.Forms.ColumnHeader codeType;
        private System.Windows.Forms.ColumnHeader code;
        private System.Windows.Forms.ColumnHeader isValid;
        private System.Windows.Forms.RadioButton radioItunes;
        private System.Windows.Forms.RadioButton radioGooglePlay;
        private System.Windows.Forms.RadioButton radioSteam;
        private System.Windows.Forms.RadioButton radioWindowsActivation;
        private System.Windows.Forms.Label lblCodeType;
        private System.Windows.Forms.Button btnGetCodes;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.RadioButton radioAll;
        private System.Windows.Forms.RadioButton radioValid;
        private System.Windows.Forms.RadioButton radioNotValid;
        private System.Windows.Forms.RadioButton radioBoth;
        private System.Windows.Forms.GroupBox groupboxValidity;
    }
}