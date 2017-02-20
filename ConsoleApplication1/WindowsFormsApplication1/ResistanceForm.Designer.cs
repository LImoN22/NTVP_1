namespace WindowsFormsApplication1
{
    partial class ResistanceForm 
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RemoveObject = new System.Windows.Forms.Button();
            this.AddObject = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RemoveObject);
            this.groupBox1.Controls.Add(this.AddObject);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(106, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(519, 416);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // RemoveObject
            // 
            this.RemoveObject.Location = new System.Drawing.Point(165, 207);
            this.RemoveObject.Name = "RemoveObject";
            this.RemoveObject.Size = new System.Drawing.Size(116, 23);
            this.RemoveObject.TabIndex = 2;
            this.RemoveObject.Text = "RemoveObject";
            this.RemoveObject.UseVisualStyleBackColor = true;
            // 
            // AddObject
            // 
            this.AddObject.Location = new System.Drawing.Point(41, 207);
            this.AddObject.Name = "AddObject";
            this.AddObject.Size = new System.Drawing.Size(118, 23);
            this.AddObject.TabIndex = 1;
            this.AddObject.Text = "AddObject";
            this.AddObject.UseVisualStyleBackColor = true;
            this.AddObject.Click += new System.EventHandler(this.AddObject_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(41, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ResistanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 330);
            this.Controls.Add(this.groupBox1);
            this.Name = "ResistanceForm";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button RemoveObject;
        private System.Windows.Forms.Button AddObject;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

