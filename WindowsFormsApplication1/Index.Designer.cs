namespace WindowsFormsApplication1
{
    partial class Index
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.groupBoxN = new System.Windows.Forms.GroupBox();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.groupBoxMax = new System.Windows.Forms.GroupBox();
            this.textBoxMax = new System.Windows.Forms.TextBox();
            this.groupBoxMin = new System.Windows.Forms.GroupBox();
            this.textBoxMin = new System.Windows.Forms.TextBox();
            this.buttonВычислить = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Xi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.КоличествоЗнаковПослеЗапитой = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBoxN.SuspendLayout();
            this.groupBoxMax.SuspendLayout();
            this.groupBoxMin.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonВычислить, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.groupBox4, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(758, 497);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel3.Controls.Add(this.groupBox5, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.groupBoxN, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.groupBoxMax, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.groupBoxMin, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(752, 114);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.checkedListBox);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox5.Location = new System.Drawing.Point(453, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(296, 108);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Вид распределения";
            // 
            // checkedListBox
            // 
            this.checkedListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBox.FormattingEnabled = true;
            this.checkedListBox.Items.AddRange(new object[] {
            "Betta",
            "Нормальное(Гаусса)",
            "Равновероятное"});
            this.checkedListBox.Location = new System.Drawing.Point(3, 23);
            this.checkedListBox.Name = "checkedListBox";
            this.checkedListBox.Size = new System.Drawing.Size(290, 82);
            this.checkedListBox.TabIndex = 0;
            // 
            // groupBoxN
            // 
            this.groupBoxN.Controls.Add(this.textBoxN);
            this.groupBoxN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxN.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxN.Location = new System.Drawing.Point(303, 3);
            this.groupBoxN.Name = "groupBoxN";
            this.groupBoxN.Size = new System.Drawing.Size(144, 108);
            this.groupBoxN.TabIndex = 2;
            this.groupBoxN.TabStop = false;
            this.groupBoxN.Text = "Количество значений:";
            // 
            // textBoxN
            // 
            this.textBoxN.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBoxN.Location = new System.Drawing.Point(3, 78);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(138, 27);
            this.textBoxN.TabIndex = 0;
            this.textBoxN.Text = "100";
            // 
            // groupBoxMax
            // 
            this.groupBoxMax.Controls.Add(this.textBoxMax);
            this.groupBoxMax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxMax.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxMax.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxMax.Location = new System.Drawing.Point(153, 3);
            this.groupBoxMax.Name = "groupBoxMax";
            this.groupBoxMax.Size = new System.Drawing.Size(144, 108);
            this.groupBoxMax.TabIndex = 1;
            this.groupBoxMax.TabStop = false;
            this.groupBoxMax.Text = "Значение максимума (Бета):";
            // 
            // textBoxMax
            // 
            this.textBoxMax.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBoxMax.Location = new System.Drawing.Point(3, 78);
            this.textBoxMax.Name = "textBoxMax";
            this.textBoxMax.Size = new System.Drawing.Size(138, 27);
            this.textBoxMax.TabIndex = 0;
            this.textBoxMax.Text = "5";
            // 
            // groupBoxMin
            // 
            this.groupBoxMin.Controls.Add(this.textBoxMin);
            this.groupBoxMin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxMin.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxMin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxMin.Location = new System.Drawing.Point(3, 3);
            this.groupBoxMin.Name = "groupBoxMin";
            this.groupBoxMin.Size = new System.Drawing.Size(144, 108);
            this.groupBoxMin.TabIndex = 0;
            this.groupBoxMin.TabStop = false;
            this.groupBoxMin.Text = "Значение минимума (Альфа):";
            // 
            // textBoxMin
            // 
            this.textBoxMin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBoxMin.Location = new System.Drawing.Point(3, 78);
            this.textBoxMin.Name = "textBoxMin";
            this.textBoxMin.Size = new System.Drawing.Size(138, 27);
            this.textBoxMin.TabIndex = 0;
            this.textBoxMin.Text = "1";
            // 
            // buttonВычислить
            // 
            this.buttonВычислить.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonВычислить.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonВычислить.Location = new System.Drawing.Point(3, 450);
            this.buttonВычислить.Name = "buttonВычислить";
            this.buttonВычислить.Size = new System.Drawing.Size(752, 44);
            this.buttonВычислить.TabIndex = 1;
            this.buttonВычислить.Text = "Вычислить";
            this.buttonВычислить.UseVisualStyleBackColor = true;
            this.buttonВычислить.Click += new System.EventHandler(this.buttonВычислить_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.groupBox4.Location = new System.Drawing.Point(3, 123);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(752, 321);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Введите значение x чтобы узнать значение y";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Xi,
            this.КоличествоЗнаковПослеЗапитой});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(746, 295);
            this.dataGridView1.TabIndex = 0;
            // 
            // Xi
            // 
            this.Xi.HeaderText = "X[i]";
            this.Xi.Name = "Xi";
            // 
            // КоличествоЗнаковПослеЗапитой
            // 
            this.КоличествоЗнаковПослеЗапитой.HeaderText = "Количество знаков после запитой";
            this.КоличествоЗнаковПослеЗапитой.Name = "КоличествоЗнаковПослеЗапитой";
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(758, 497);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "Index";
            this.Text = "Функциональная зависимость по выборке";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBoxN.ResumeLayout(false);
            this.groupBoxN.PerformLayout();
            this.groupBoxMax.ResumeLayout(false);
            this.groupBoxMax.PerformLayout();
            this.groupBoxMin.ResumeLayout(false);
            this.groupBoxMin.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox groupBoxN;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.GroupBox groupBoxMax;
        private System.Windows.Forms.TextBox textBoxMax;
        private System.Windows.Forms.GroupBox groupBoxMin;
        private System.Windows.Forms.TextBox textBoxMin;
        private System.Windows.Forms.Button buttonВычислить;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Xi;
        private System.Windows.Forms.DataGridViewTextBoxColumn КоличествоЗнаковПослеЗапитой;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckedListBox checkedListBox;


    }
}

