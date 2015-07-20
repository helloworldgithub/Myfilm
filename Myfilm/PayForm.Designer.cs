namespace Myfilm
{
    partial class PayForm
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
            this.buttonpaymonye = new System.Windows.Forms.Button();
            this.buttonrecharge = new System.Windows.Forms.Button();
            this.textBoxtotalprice = new System.Windows.Forms.TextBox();
            this.textBoxleftmoney = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonpaymonye
            // 
            this.buttonpaymonye.Location = new System.Drawing.Point(42, 128);
            this.buttonpaymonye.Name = "buttonpaymonye";
            this.buttonpaymonye.Size = new System.Drawing.Size(75, 23);
            this.buttonpaymonye.TabIndex = 0;
            this.buttonpaymonye.Text = "立即订购";
            this.buttonpaymonye.UseVisualStyleBackColor = true;
            this.buttonpaymonye.Click += new System.EventHandler(this.buttonpaymonye_Click);
            // 
            // buttonrecharge
            // 
            this.buttonrecharge.Location = new System.Drawing.Point(150, 128);
            this.buttonrecharge.Name = "buttonrecharge";
            this.buttonrecharge.Size = new System.Drawing.Size(75, 23);
            this.buttonrecharge.TabIndex = 1;
            this.buttonrecharge.Text = "立即充值";
            this.buttonrecharge.UseVisualStyleBackColor = true;
            this.buttonrecharge.Click += new System.EventHandler(this.buttonrecharge_Click);
            // 
            // textBoxtotalprice
            // 
            this.textBoxtotalprice.Location = new System.Drawing.Point(125, 25);
            this.textBoxtotalprice.Name = "textBoxtotalprice";
            this.textBoxtotalprice.ReadOnly = true;
            this.textBoxtotalprice.Size = new System.Drawing.Size(100, 21);
            this.textBoxtotalprice.TabIndex = 2;
            // 
            // textBoxleftmoney
            // 
            this.textBoxleftmoney.Location = new System.Drawing.Point(125, 66);
            this.textBoxleftmoney.Name = "textBoxleftmoney";
            this.textBoxleftmoney.ReadOnly = true;
            this.textBoxleftmoney.Size = new System.Drawing.Size(100, 21);
            this.textBoxleftmoney.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "购票总价";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "当前余额";
            // 
            // PayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 177);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxleftmoney);
            this.Controls.Add(this.textBoxtotalprice);
            this.Controls.Add(this.buttonrecharge);
            this.Controls.Add(this.buttonpaymonye);
            this.Name = "PayForm";
            this.Text = "PayForm";
            this.Activated += new System.EventHandler(this.PayForm_Activated);
            this.Load += new System.EventHandler(this.PayForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonpaymonye;
        private System.Windows.Forms.Button buttonrecharge;
        private System.Windows.Forms.TextBox textBoxtotalprice;
        private System.Windows.Forms.TextBox textBoxleftmoney;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}