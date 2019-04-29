namespace CS_LINQ
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
            this._lbN = new System.Windows.Forms.Label();
            this._tbN = new System.Windows.Forms.TextBox();
            this._btnRand = new System.Windows.Forms.Button();
            this._btnTask1 = new System.Windows.Forms.Button();
            this._rtbT = new System.Windows.Forms.RichTextBox();
            this._btnTest = new System.Windows.Forms.Button();
            this._btnClear = new System.Windows.Forms.Button();
            this._tbTask2 = new System.Windows.Forms.Button();
            this._cbOut = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // _lbN
            // 
            this._lbN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._lbN.AutoSize = true;
            this._lbN.Location = new System.Drawing.Point(585, 15);
            this._lbN.Name = "_lbN";
            this._lbN.Size = new System.Drawing.Size(93, 13);
            this._lbN.TabIndex = 1;
            this._lbN.Text = "Размер массива";
            // 
            // _tbN
            // 
            this._tbN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._tbN.Location = new System.Drawing.Point(588, 31);
            this._tbN.Name = "_tbN";
            this._tbN.Size = new System.Drawing.Size(90, 20);
            this._tbN.TabIndex = 2;
            // 
            // _btnRand
            // 
            this._btnRand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnRand.Location = new System.Drawing.Point(585, 96);
            this._btnRand.Name = "_btnRand";
            this._btnRand.Size = new System.Drawing.Size(197, 33);
            this._btnRand.TabIndex = 3;
            this._btnRand.Text = "Заполнить массив";
            this._btnRand.UseVisualStyleBackColor = true;
            this._btnRand.Click += new System.EventHandler(this._btnRand_Click);
            // 
            // _btnTask1
            // 
            this._btnTask1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnTask1.Location = new System.Drawing.Point(585, 135);
            this._btnTask1.Name = "_btnTask1";
            this._btnTask1.Size = new System.Drawing.Size(197, 35);
            this._btnTask1.TabIndex = 4;
            this._btnTask1.Text = "Выполнить";
            this._btnTask1.UseVisualStyleBackColor = true;
            this._btnTask1.Click += new System.EventHandler(this._btnTask1_Click);
            // 
            // _rtbT
            // 
            this._rtbT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._rtbT.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._rtbT.Location = new System.Drawing.Point(12, 15);
            this._rtbT.Name = "_rtbT";
            this._rtbT.Size = new System.Drawing.Size(567, 423);
            this._rtbT.TabIndex = 5;
            this._rtbT.Text = "";
            // 
            // _btnTest
            // 
            this._btnTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnTest.Location = new System.Drawing.Point(585, 57);
            this._btnTest.Name = "_btnTest";
            this._btnTest.Size = new System.Drawing.Size(197, 33);
            this._btnTest.TabIndex = 6;
            this._btnTest.Text = "Готовый массив";
            this._btnTest.UseVisualStyleBackColor = true;
            this._btnTest.Click += new System.EventHandler(this._btnTest_Click);
            // 
            // _btnClear
            // 
            this._btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnClear.Location = new System.Drawing.Point(684, 31);
            this._btnClear.Name = "_btnClear";
            this._btnClear.Size = new System.Drawing.Size(98, 20);
            this._btnClear.TabIndex = 7;
            this._btnClear.Text = "Sweep";
            this._btnClear.UseVisualStyleBackColor = true;
            this._btnClear.Click += new System.EventHandler(this._btnClear_Click);
            // 
            // _tbTask2
            // 
            this._tbTask2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._tbTask2.Location = new System.Drawing.Point(585, 176);
            this._tbTask2.Name = "_tbTask2";
            this._tbTask2.Size = new System.Drawing.Size(197, 35);
            this._tbTask2.TabIndex = 8;
            this._tbTask2.Text = "Выполнить параллельно";
            this._tbTask2.UseVisualStyleBackColor = true;
            this._tbTask2.Click += new System.EventHandler(this._tbTask2_Click);
            // 
            // _cbOut
            // 
            this._cbOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._cbOut.AutoSize = true;
            this._cbOut.Location = new System.Drawing.Point(588, 231);
            this._cbOut.Name = "_cbOut";
            this._cbOut.Size = new System.Drawing.Size(96, 17);
            this._cbOut.TabIndex = 9;
            this._cbOut.Text = "Вывод текста";
            this._cbOut.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 450);
            this.Controls.Add(this._cbOut);
            this.Controls.Add(this._tbTask2);
            this.Controls.Add(this._btnClear);
            this.Controls.Add(this._btnTest);
            this.Controls.Add(this._rtbT);
            this.Controls.Add(this._btnTask1);
            this.Controls.Add(this._btnRand);
            this.Controls.Add(this._tbN);
            this.Controls.Add(this._lbN);
            this.Name = "Form1";
            this.Text = "Бесединский П.С. 3-46";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label _lbN;
        private System.Windows.Forms.TextBox _tbN;
        private System.Windows.Forms.Button _btnRand;
        private System.Windows.Forms.Button _btnTask1;
        private System.Windows.Forms.RichTextBox _rtbT;
        private System.Windows.Forms.Button _btnTest;
        private System.Windows.Forms.Button _btnClear;
        private System.Windows.Forms.Button _tbTask2;
        private System.Windows.Forms.CheckBox _cbOut;
    }
}

