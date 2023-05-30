namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txt_pri_dns = new System.Windows.Forms.TextBox();
            txt_second_dns = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            btn_setIP = new System.Windows.Forms.Button();
            btn_Auto = new System.Windows.Forms.Button();
            dnsComboBox = new System.Windows.Forms.ComboBox();
            label6 = new System.Windows.Forms.Label();
            interfaceComboBox = new System.Windows.Forms.ComboBox();
            label7 = new System.Windows.Forms.Label();
            btn_newProfile = new System.Windows.Forms.Button();
            btn_delete_config = new System.Windows.Forms.Button();
            label8 = new System.Windows.Forms.Label();
            txt_profile_name = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // txt_pri_dns
            // 
            txt_pri_dns.Location = new System.Drawing.Point(475, 12);
            txt_pri_dns.Name = "txt_pri_dns";
            txt_pri_dns.Size = new System.Drawing.Size(100, 23);
            txt_pri_dns.TabIndex = 3;
            // 
            // txt_second_dns
            // 
            txt_second_dns.Location = new System.Drawing.Point(475, 41);
            txt_second_dns.Name = "txt_second_dns";
            txt_second_dns.Size = new System.Drawing.Size(100, 23);
            txt_second_dns.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(327, 15);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(71, 15);
            label4.TabIndex = 8;
            label4.Text = "Primary Dns";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(327, 44);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(79, 15);
            label5.TabIndex = 9;
            label5.Text = "Secondry Dns";
            // 
            // btn_setIP
            // 
            btn_setIP.Location = new System.Drawing.Point(327, 67);
            btn_setIP.Name = "btn_setIP";
            btn_setIP.Size = new System.Drawing.Size(75, 23);
            btn_setIP.TabIndex = 10;
            btn_setIP.Text = "Set Config";
            btn_setIP.UseVisualStyleBackColor = true;
            btn_setIP.Click += btn_setIP_Click;
            // 
            // btn_Auto
            // 
            btn_Auto.Location = new System.Drawing.Point(327, 96);
            btn_Auto.Name = "btn_Auto";
            btn_Auto.Size = new System.Drawing.Size(100, 23);
            btn_Auto.TabIndex = 11;
            btn_Auto.Text = "DHCP(Auto)";
            btn_Auto.UseVisualStyleBackColor = true;
            btn_Auto.Click += btn_Auto_Click;
            // 
            // dnsComboBox
            // 
            dnsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            dnsComboBox.FormattingEnabled = true;
            dnsComboBox.Location = new System.Drawing.Point(109, 75);
            dnsComboBox.Name = "dnsComboBox";
            dnsComboBox.Size = new System.Drawing.Size(142, 23);
            dnsComboBox.TabIndex = 12;
            dnsComboBox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(12, 75);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(82, 15);
            label6.TabIndex = 13;
            label6.Text = "Saved Configs";
            // 
            // interfaceComboBox
            // 
            interfaceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            interfaceComboBox.FormattingEnabled = true;
            interfaceComboBox.Location = new System.Drawing.Point(109, 14);
            interfaceComboBox.Name = "interfaceComboBox";
            interfaceComboBox.Size = new System.Drawing.Size(189, 23);
            interfaceComboBox.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(2, 17);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(101, 15);
            label7.TabIndex = 15;
            label7.Text = "Network Interface";
            // 
            // btn_newProfile
            // 
            btn_newProfile.Location = new System.Drawing.Point(327, 180);
            btn_newProfile.Name = "btn_newProfile";
            btn_newProfile.Size = new System.Drawing.Size(106, 23);
            btn_newProfile.TabIndex = 16;
            btn_newProfile.Text = "Add New Config";
            btn_newProfile.UseVisualStyleBackColor = true;
            btn_newProfile.Click += newProfileButton_Click;
            // 
            // btn_delete_config
            // 
            btn_delete_config.FlatStyle = System.Windows.Forms.FlatStyle.System;
            btn_delete_config.Location = new System.Drawing.Point(109, 104);
            btn_delete_config.Name = "btn_delete_config";
            btn_delete_config.Size = new System.Drawing.Size(92, 23);
            btn_delete_config.TabIndex = 17;
            btn_delete_config.Text = "Delete Config";
            btn_delete_config.UseVisualStyleBackColor = true;
            btn_delete_config.Click += btn_delete_config_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(327, 159);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(78, 15);
            label8.TabIndex = 18;
            label8.Text = "Config Name";
            // 
            // txt_profile_name
            // 
            txt_profile_name.Location = new System.Drawing.Point(475, 156);
            txt_profile_name.Name = "txt_profile_name";
            txt_profile_name.Size = new System.Drawing.Size(100, 23);
            txt_profile_name.TabIndex = 19;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(587, 253);
            Controls.Add(txt_profile_name);
            Controls.Add(label8);
            Controls.Add(btn_delete_config);
            Controls.Add(btn_newProfile);
            Controls.Add(label7);
            Controls.Add(interfaceComboBox);
            Controls.Add(label6);
            Controls.Add(dnsComboBox);
            Controls.Add(btn_setIP);
            Controls.Add(btn_Auto);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txt_second_dns);
            Controls.Add(txt_pri_dns);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.TextBox txt_pri_dns;
        private System.Windows.Forms.TextBox txt_second_dns;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        //private System.Windows.Forms.Button btn_setIP_Click;
        private System.Windows.Forms.Button btn_Auto;
        private System.Windows.Forms.Button btn_setIP;
        private System.Windows.Forms.ComboBox dnsComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox interfaceComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_newProfile;
        private System.Windows.Forms.Button btn_delete_config;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_profile_name;
    }
}
