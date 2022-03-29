namespace Session_4
{
    partial class EditRoleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditRoleForm));
            this.cancel_button = new System.Windows.Forms.Button();
            this.save_button = new System.Windows.Forms.Button();
            this.officebox_text = new System.Windows.Forms.ComboBox();
            this.lastname_text = new System.Windows.Forms.TextBox();
            this.firstname_text = new System.Windows.Forms.TextBox();
            this.email_text = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // cancel_button
            // 
            resources.ApplyResources(this.cancel_button, "cancel_button");
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // save_button
            // 
            this.save_button.DialogResult = System.Windows.Forms.DialogResult.OK;
            resources.ApplyResources(this.save_button, "save_button");
            this.save_button.Name = "save_button";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // officebox_text
            // 
            this.officebox_text.DisplayMember = "Title";
            resources.ApplyResources(this.officebox_text, "officebox_text");
            this.officebox_text.FormattingEnabled = true;
            this.officebox_text.Name = "officebox_text";
            this.officebox_text.ValueMember = "ID";
            // 
            // lastname_text
            // 
            resources.ApplyResources(this.lastname_text, "lastname_text");
            this.lastname_text.Name = "lastname_text";
            // 
            // firstname_text
            // 
            resources.ApplyResources(this.firstname_text, "firstname_text");
            this.firstname_text.Name = "firstname_text";
            // 
            // email_text
            // 
            resources.ApplyResources(this.email_text, "email_text");
            this.email_text.Name = "email_text";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // radioButton1
            // 
            resources.ApplyResources(this.radioButton1, "radioButton1");
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            resources.ApplyResources(this.radioButton2, "radioButton2");
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.TabStop = true;
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // EditRoleForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.officebox_text);
            this.Controls.Add(this.lastname_text);
            this.Controls.Add(this.firstname_text);
            this.Controls.Add(this.email_text);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditRoleForm";
            this.ShowIcon = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button cancel_button;
        public System.Windows.Forms.Button save_button;
        public System.Windows.Forms.ComboBox officebox_text;
        public System.Windows.Forms.TextBox lastname_text;
        public System.Windows.Forms.TextBox firstname_text;
        public System.Windows.Forms.TextBox email_text;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}