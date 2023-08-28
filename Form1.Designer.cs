namespace SieveOfEratosthenes
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.Label = new System.Windows.Forms.Label();
            this.Counter = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NumberBox = new System.Windows.Forms.TextBox();
            this.Primelst = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEnter
            // 
            this.btnEnter.Font = new System.Drawing.Font("ＭＳ 明朝", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnEnter.Location = new System.Drawing.Point(624, 27);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(90, 40);
            this.btnEnter.TabIndex = 0;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("ＭＳ 明朝", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnClear.Location = new System.Drawing.Point(735, 27);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 40);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("ＭＳ 明朝", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Label.Location = new System.Drawing.Point(57, 33);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(376, 28);
            this.Label.TabIndex = 2;
            this.Label.Text = "Please enter an integer ⇒";
            // 
            // Counter
            // 
            this.Counter.Font = new System.Drawing.Font("ＭＳ 明朝", 13F);
            this.Counter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Counter.Location = new System.Drawing.Point(440, 79);
            this.Counter.Name = "Counter";
            this.Counter.Size = new System.Drawing.Size(385, 42);
            this.Counter.TabIndex = 3;
            this.Counter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("ＭＳ 明朝", 16F);
            this.label3.Location = new System.Drawing.Point(58, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "Prime Number List";
            // 
            // NumberBox
            // 
            this.NumberBox.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.NumberBox.Location = new System.Drawing.Point(460, 27);
            this.NumberBox.Name = "NumberBox";
            this.NumberBox.Size = new System.Drawing.Size(129, 37);
            this.NumberBox.TabIndex = 5;
            this.NumberBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberBox_KeyPress);
            // 
            // Primelst
            // 
            this.Primelst.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.Primelst.Location = new System.Drawing.Point(58, 139);
            this.Primelst.Name = "Primelst";
            this.Primelst.Size = new System.Drawing.Size(781, 479);
            this.Primelst.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 653);
            this.Controls.Add(this.Primelst);
            this.Controls.Add(this.NumberBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Counter);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnEnter);
            this.Name = "MainForm";
            this.Text = "Sieve of Eratosthenes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Label Counter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NumberBox;
        private System.Windows.Forms.Label Primelst;
    }
}

