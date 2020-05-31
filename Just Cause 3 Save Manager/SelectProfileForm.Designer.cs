namespace Just_Cause_3_Save_Manager
{
    partial class SelectProfileForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectProfileForm));
            this.selectProfileLbl = new System.Windows.Forms.Label();
            this.steamProfile = new System.Windows.Forms.ComboBox();
            this.continueBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // selectProfileLbl
            // 
            this.selectProfileLbl.AutoSize = true;
            this.selectProfileLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectProfileLbl.Location = new System.Drawing.Point(12, 9);
            this.selectProfileLbl.Name = "selectProfileLbl";
            this.selectProfileLbl.Size = new System.Drawing.Size(173, 18);
            this.selectProfileLbl.TabIndex = 0;
            this.selectProfileLbl.Text = "Select your Steam profile";
            // 
            // steamProfile
            // 
            this.steamProfile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.steamProfile.FormattingEnabled = true;
            this.steamProfile.Location = new System.Drawing.Point(15, 31);
            this.steamProfile.Name = "steamProfile";
            this.steamProfile.Size = new System.Drawing.Size(260, 21);
            this.steamProfile.TabIndex = 1;
            this.steamProfile.SelectedIndexChanged += new System.EventHandler(this.steamProfile_SelectedIndexChanged);
            // 
            // continueBtn
            // 
            this.continueBtn.Enabled = false;
            this.continueBtn.Location = new System.Drawing.Point(179, 58);
            this.continueBtn.Name = "continueBtn";
            this.continueBtn.Size = new System.Drawing.Size(96, 23);
            this.continueBtn.TabIndex = 2;
            this.continueBtn.Text = "Continue";
            this.continueBtn.UseVisualStyleBackColor = true;
            this.continueBtn.Click += new System.EventHandler(this.continueBtn_Click);
            // 
            // SelectProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 93);
            this.Controls.Add(this.continueBtn);
            this.Controls.Add(this.steamProfile);
            this.Controls.Add(this.selectProfileLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectProfileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JC3 Save Manager - Select Profile";
            this.Load += new System.EventHandler(this.SelectProfileForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label selectProfileLbl;
        private System.Windows.Forms.ComboBox steamProfile;
        private System.Windows.Forms.Button continueBtn;
    }
}

