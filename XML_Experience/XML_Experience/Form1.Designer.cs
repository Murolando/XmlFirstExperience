namespace XML_Experience
{
    partial class Main_form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_form));
            this.lv_users = new System.Windows.Forms.ListView();
            this.Ser_but = new System.Windows.Forms.Button();
            this.Deser_but = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.User_text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Sex_comb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Add_but = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Age_num = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Age_num)).BeginInit();
            this.SuspendLayout();
            // 
            // lv_users
            // 
            this.lv_users.HideSelection = false;
            resources.ApplyResources(this.lv_users, "lv_users");
            this.lv_users.Name = "lv_users";
            this.lv_users.UseCompatibleStateImageBehavior = false;
            this.lv_users.View = System.Windows.Forms.View.List;
            this.lv_users.SelectedIndexChanged += new System.EventHandler(this.lv_users_SelectedIndexChanged);
            // 
            // Ser_but
            // 
            this.Ser_but.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Ser_but.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            resources.ApplyResources(this.Ser_but, "Ser_but");
            this.Ser_but.Name = "Ser_but";
            this.Ser_but.UseVisualStyleBackColor = false;
            this.Ser_but.Click += new System.EventHandler(this.Ser_but_Click);
            // 
            // Deser_but
            // 
            this.Deser_but.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Deser_but.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            resources.ApplyResources(this.Deser_but, "Deser_but");
            this.Deser_but.Name = "Deser_but";
            this.Deser_but.UseVisualStyleBackColor = false;
            this.Deser_but.Click += new System.EventHandler(this.Deser_but_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // User_text
            // 
            resources.ApplyResources(this.User_text, "User_text");
            this.User_text.Name = "User_text";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // Sex_comb
            // 
            this.Sex_comb.FormattingEnabled = true;
            this.Sex_comb.Items.AddRange(new object[] {
            resources.GetString("Sex_comb.Items"),
            resources.GetString("Sex_comb.Items1"),
            resources.GetString("Sex_comb.Items2")});
            resources.ApplyResources(this.Sex_comb, "Sex_comb");
            this.Sex_comb.Name = "Sex_comb";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // Add_but
            // 
            this.Add_but.BackColor = System.Drawing.Color.Red;
            this.Add_but.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            resources.ApplyResources(this.Add_but, "Add_but");
            this.Add_but.Name = "Add_but";
            this.Add_but.UseVisualStyleBackColor = false;
            this.Add_but.Click += new System.EventHandler(this.Add_but_Click);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.Add_but);
            this.panel1.Controls.Add(this.Age_num);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Sex_comb);
            this.panel1.Controls.Add(this.User_text);
            this.panel1.Name = "panel1";
            // 
            // Age_num
            // 
            resources.ApplyResources(this.Age_num, "Age_num");
            this.Age_num.Name = "Age_num";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // Main_form
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Deser_but);
            this.Controls.Add(this.Ser_but);
            this.Controls.Add(this.lv_users);
            this.Controls.Add(this.panel1);
            this.Name = "Main_form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Age_num)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv_users;
        private System.Windows.Forms.Button Ser_but;
        private System.Windows.Forms.Button Deser_but;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox User_text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Sex_comb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Add_but;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown Age_num;
        private System.Windows.Forms.Label label4;
    }
}

