namespace Session_4
{
    partial class AdduserForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.email_text = new System.Windows.Forms.TextBox();
            this.firstname_text = new System.Windows.Forms.TextBox();
            this.password_text = new System.Windows.Forms.TextBox();
            this.lastname_text = new System.Windows.Forms.TextBox();
            this.officebox_text = new System.Windows.Forms.ComboBox();
            this.officesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.session3_4DataSet = new Session_4.Session3_4DataSet();
            this.officesTableAdapter = new Session_4.Session3_4DataSetTableAdapters.OfficesTableAdapter();
            this.save_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.officesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.session3_4DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "First name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(65, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Office";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(65, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Birthdate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(65, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Password";
            // 
            // email_text
            // 
            this.email_text.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_text.Location = new System.Drawing.Point(193, 18);
            this.email_text.Name = "email_text";
            this.email_text.Size = new System.Drawing.Size(197, 25);
            this.email_text.TabIndex = 6;
            // 
            // firstname_text
            // 
            this.firstname_text.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstname_text.Location = new System.Drawing.Point(193, 57);
            this.firstname_text.Name = "firstname_text";
            this.firstname_text.Size = new System.Drawing.Size(197, 25);
            this.firstname_text.TabIndex = 7;
            // 
            // password_text
            // 
            this.password_text.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_text.Location = new System.Drawing.Point(193, 219);
            this.password_text.Name = "password_text";
            this.password_text.Size = new System.Drawing.Size(197, 25);
            this.password_text.TabIndex = 8;
            // 
            // lastname_text
            // 
            this.lastname_text.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastname_text.Location = new System.Drawing.Point(193, 97);
            this.lastname_text.Name = "lastname_text";
            this.lastname_text.Size = new System.Drawing.Size(197, 25);
            this.lastname_text.TabIndex = 9;
            // 
            // officebox_text
            // 
            this.officebox_text.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.officesBindingSource, "ID", true));
            this.officebox_text.DataSource = this.officesBindingSource;
            this.officebox_text.DisplayMember = "Title";
            this.officebox_text.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.officebox_text.FormattingEnabled = true;
            this.officebox_text.Location = new System.Drawing.Point(193, 137);
            this.officebox_text.Name = "officebox_text";
            this.officebox_text.Size = new System.Drawing.Size(197, 27);
            this.officebox_text.TabIndex = 11;
            this.officebox_text.ValueMember = "ID";
            // 
            // officesBindingSource
            // 
            this.officesBindingSource.DataMember = "Offices";
            this.officesBindingSource.DataSource = this.session3_4DataSet;
            // 
            // session3_4DataSet
            // 
            this.session3_4DataSet.DataSetName = "Session3_4DataSet";
            this.session3_4DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // officesTableAdapter
            // 
            this.officesTableAdapter.ClearBeforeFill = true;
            // 
            // save_button
            // 
            this.save_button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.save_button.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_button.Location = new System.Drawing.Point(110, 257);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(106, 29);
            this.save_button.TabIndex = 12;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_button.Location = new System.Drawing.Point(259, 257);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(106, 29);
            this.cancel_button.TabIndex = 13;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Location = new System.Drawing.Point(193, 181);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(197, 22);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // AdduserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 295);
            this.ControlBox = false;
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.officebox_text);
            this.Controls.Add(this.lastname_text);
            this.Controls.Add(this.password_text);
            this.Controls.Add(this.firstname_text);
            this.Controls.Add(this.email_text);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdduserForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add User";
            this.Load += new System.EventHandler(this.AdduserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.officesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.session3_4DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Session3_4DataSet session3_4DataSet;
        private System.Windows.Forms.BindingSource officesBindingSource;
        private Session3_4DataSetTableAdapters.OfficesTableAdapter officesTableAdapter;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox email_text;
        public System.Windows.Forms.TextBox firstname_text;
        public System.Windows.Forms.TextBox password_text;
        public System.Windows.Forms.TextBox lastname_text;
        public System.Windows.Forms.ComboBox officebox_text;
        public System.Windows.Forms.Button save_button;
        public System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}