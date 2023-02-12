
namespace ADO_TaskLearn
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_Save2 = new System.Windows.Forms.Button();
            this.button_Save3 = new System.Windows.Forms.Button();
            this.button_AllGroups = new System.Windows.Forms.Button();
            this.button_AllStudents = new System.Windows.Forms.Button();
            this.button_AllSubject = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(57, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(475, 272);
            this.dataGridView1.TabIndex = 0;
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(695, 67);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(104, 38);
            this.button_Save.TabIndex = 2;
            this.button_Save.Text = "Сохранить изменения";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // button_Save2
            // 
            this.button_Save2.Location = new System.Drawing.Point(695, 131);
            this.button_Save2.Name = "button_Save2";
            this.button_Save2.Size = new System.Drawing.Size(104, 38);
            this.button_Save2.TabIndex = 4;
            this.button_Save2.Text = "Сохранить изменения";
            this.button_Save2.UseVisualStyleBackColor = true;
            this.button_Save2.Click += new System.EventHandler(this.button_Save2_Click);
            // 
            // button_Save3
            // 
            this.button_Save3.Location = new System.Drawing.Point(695, 201);
            this.button_Save3.Name = "button_Save3";
            this.button_Save3.Size = new System.Drawing.Size(104, 38);
            this.button_Save3.TabIndex = 6;
            this.button_Save3.Text = "Сохранить изменения";
            this.button_Save3.UseVisualStyleBackColor = true;
            this.button_Save3.Click += new System.EventHandler(this.button_Save3_Click);
            // 
            // button_AllGroups
            // 
            this.button_AllGroups.Location = new System.Drawing.Point(557, 67);
            this.button_AllGroups.Name = "button_AllGroups";
            this.button_AllGroups.Size = new System.Drawing.Size(108, 38);
            this.button_AllGroups.TabIndex = 1;
            this.button_AllGroups.Text = "Все группы";
            this.button_AllGroups.UseVisualStyleBackColor = true;
            this.button_AllGroups.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_AllStudents
            // 
            this.button_AllStudents.Location = new System.Drawing.Point(557, 131);
            this.button_AllStudents.Name = "button_AllStudents";
            this.button_AllStudents.Size = new System.Drawing.Size(108, 38);
            this.button_AllStudents.TabIndex = 3;
            this.button_AllStudents.Text = "Все студенты";
            this.button_AllStudents.UseVisualStyleBackColor = true;
            this.button_AllStudents.Click += new System.EventHandler(this.button_AllStudents_Click);
            // 
            // button_AllSubject
            // 
            this.button_AllSubject.Location = new System.Drawing.Point(557, 201);
            this.button_AllSubject.Name = "button_AllSubject";
            this.button_AllSubject.Size = new System.Drawing.Size(108, 38);
            this.button_AllSubject.TabIndex = 5;
            this.button_AllSubject.Text = "Все предметы";
            this.button_AllSubject.UseVisualStyleBackColor = true;
            this.button_AllSubject.Click += new System.EventHandler(this.button_AllSubject_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 543);
            this.Controls.Add(this.button_Save3);
            this.Controls.Add(this.button_AllSubject);
            this.Controls.Add(this.button_Save2);
            this.Controls.Add(this.button_AllStudents);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.button_AllGroups);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_Save2;
        private System.Windows.Forms.Button button_Save3;
        private System.Windows.Forms.Button button_AllGroups;
        private System.Windows.Forms.Button button_AllStudents;
        private System.Windows.Forms.Button button_AllSubject;
    }
}

