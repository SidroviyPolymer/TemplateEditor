namespace LBTemplate
{
    partial class Form1
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
            this.lb_Group = new System.Windows.Forms.Label();
            this.cb_Group = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_Student = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rtb_Template = new System.Windows.Forms.RichTextBox();
            this.ofd_OpenTemplate = new System.Windows.Forms.OpenFileDialog();
            this.btn_LoadTemplate = new System.Windows.Forms.Button();
            this.btn_ClearTemplate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_Group
            // 
            this.lb_Group.AutoSize = true;
            this.lb_Group.Location = new System.Drawing.Point(12, 9);
            this.lb_Group.Name = "lb_Group";
            this.lb_Group.Size = new System.Drawing.Size(42, 13);
            this.lb_Group.TabIndex = 0;
            this.lb_Group.Text = "Группа";
            // 
            // cb_Group
            // 
            this.cb_Group.FormattingEnabled = true;
            this.cb_Group.Location = new System.Drawing.Point(60, 6);
            this.cb_Group.Name = "cb_Group";
            this.cb_Group.Size = new System.Drawing.Size(237, 21);
            this.cb_Group.TabIndex = 1;
            this.cb_Group.SelectedIndexChanged += new System.EventHandler(this.cb_Group_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ученик";
            // 
            // cb_Student
            // 
            this.cb_Student.FormattingEnabled = true;
            this.cb_Student.Location = new System.Drawing.Point(60, 45);
            this.cb_Student.Name = "cb_Student";
            this.cb_Student.Size = new System.Drawing.Size(237, 21);
            this.cb_Student.TabIndex = 3;
            this.cb_Student.SelectedIndexChanged += new System.EventHandler(this.cb_Student_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Имя";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Мужик?";
            // 
            // rtb_Template
            // 
            this.rtb_Template.Location = new System.Drawing.Point(303, 6);
            this.rtb_Template.Name = "rtb_Template";
            this.rtb_Template.ReadOnly = true;
            this.rtb_Template.Size = new System.Drawing.Size(317, 348);
            this.rtb_Template.TabIndex = 8;
            this.rtb_Template.Text = "";
            // 
            // ofd_OpenTemplate
            // 
            this.ofd_OpenTemplate.Filter = "Текстовый документ|*.txt";
            // 
            // btn_LoadTemplate
            // 
            this.btn_LoadTemplate.Location = new System.Drawing.Point(15, 73);
            this.btn_LoadTemplate.Name = "btn_LoadTemplate";
            this.btn_LoadTemplate.Size = new System.Drawing.Size(281, 23);
            this.btn_LoadTemplate.TabIndex = 9;
            this.btn_LoadTemplate.Text = "Загрузить шаблон";
            this.btn_LoadTemplate.UseVisualStyleBackColor = true;
            this.btn_LoadTemplate.Click += new System.EventHandler(this.btn_LoadTemplate_Click);
            // 
            // btn_ClearTemplate
            // 
            this.btn_ClearTemplate.Location = new System.Drawing.Point(16, 102);
            this.btn_ClearTemplate.Name = "btn_ClearTemplate";
            this.btn_ClearTemplate.Size = new System.Drawing.Size(281, 23);
            this.btn_ClearTemplate.TabIndex = 10;
            this.btn_ClearTemplate.Text = "Очистить шаблон";
            this.btn_ClearTemplate.UseVisualStyleBackColor = true;
            this.btn_ClearTemplate.Click += new System.EventHandler(this.btn_ClearTemplate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 363);
            this.Controls.Add(this.btn_ClearTemplate);
            this.Controls.Add(this.btn_LoadTemplate);
            this.Controls.Add(this.rtb_Template);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_Student);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_Group);
            this.Controls.Add(this.lb_Group);
            this.Name = "Form1";
            this.Text = "Генератор шаблонов";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Group;
        private System.Windows.Forms.ComboBox cb_Group;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_Student;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rtb_Template;
        private System.Windows.Forms.OpenFileDialog ofd_OpenTemplate;
        private System.Windows.Forms.Button btn_LoadTemplate;
        private System.Windows.Forms.Button btn_ClearTemplate;
    }
}

