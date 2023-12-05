namespace Caesarcipher
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Old = new System.Windows.Forms.TextBox();
            this.New = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.encode = new System.Windows.Forms.RadioButton();
            this.decode = new System.Windows.Forms.RadioButton();
            this.shift = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.shift);
            this.groupBox1.Controls.Add(this.decode);
            this.groupBox1.Controls.Add(this.encode);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.New);
            this.groupBox1.Controls.Add(this.Old);
            this.groupBox1.Location = new System.Drawing.Point(3, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(469, 405);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Old
            // 
            this.Old.Location = new System.Drawing.Point(31, 67);
            this.Old.Multiline = true;
            this.Old.Name = "Old";
            this.Old.Size = new System.Drawing.Size(105, 103);
            this.Old.TabIndex = 0;
            this.Old.TextChanged += new System.EventHandler(this.Old_TextChanged_1);
            // 
            // New
            // 
            this.New.Location = new System.Drawing.Point(240, 67);
            this.New.Multiline = true;
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(105, 103);
            this.New.TabIndex = 2;
            this.New.TextChanged += new System.EventHandler(this.New_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(373, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // encode
            // 
            this.encode.AutoSize = true;
            this.encode.Location = new System.Drawing.Point(152, 113);
            this.encode.Name = "encode";
            this.encode.Size = new System.Drawing.Size(47, 16);
            this.encode.TabIndex = 4;
            this.encode.TabStop = true;
            this.encode.Text = "加密";
            this.encode.UseVisualStyleBackColor = true;
            this.encode.CheckedChanged += new System.EventHandler(this.encode_CheckedChanged);
            // 
            // decode
            // 
            this.decode.AutoSize = true;
            this.decode.Location = new System.Drawing.Point(152, 154);
            this.decode.Name = "decode";
            this.decode.Size = new System.Drawing.Size(47, 16);
            this.decode.TabIndex = 5;
            this.decode.TabStop = true;
            this.decode.Text = "解密";
            this.decode.UseVisualStyleBackColor = true;
            this.decode.CheckedChanged += new System.EventHandler(this.decode_CheckedChanged);
            // 
            // shift
            // 
            this.shift.Location = new System.Drawing.Point(142, 67);
            this.shift.Name = "shift";
            this.shift.Size = new System.Drawing.Size(91, 22);
            this.shift.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 25F);
            this.label1.Location = new System.Drawing.Point(58, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 34);
            this.label1.TabIndex = 7;
            this.label1.Text = "原文　";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 25F);
            this.label2.Location = new System.Drawing.Point(58, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 34);
            this.label2.TabIndex = 8;
            this.label2.Text = "密文　";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 25F);
            this.label3.Location = new System.Drawing.Point(58, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 34);
            this.label3.TabIndex = 9;
            this.label3.Text = "偏移　";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 12F);
            this.label4.Location = new System.Drawing.Point(28, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "原文";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 12F);
            this.label5.Location = new System.Drawing.Point(237, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "密文";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 408);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox shift;
        private System.Windows.Forms.RadioButton decode;
        private System.Windows.Forms.RadioButton encode;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox New;
        private System.Windows.Forms.TextBox Old;
    }
}

