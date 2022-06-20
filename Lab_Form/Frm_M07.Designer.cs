
namespace Lab_Form
{
    partial class windo
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnRegister01 = new System.Windows.Forms.Button();
            this.btnRegister02 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.cmbDiscount = new System.Windows.Forms.ComboBox();
            this.btnDiscount = new System.Windows.Forms.Button();
            this.btn_Setproperty = new System.Windows.Forms.Button();
            this.btn_setbound = new System.Windows.Forms.Button();
            this.btn_mid = new System.Windows.Forms.Button();
            this.btn_Dialog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(356, 23);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "物件初始化";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(21, 11);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 35);
            this.button2.TabIndex = 1;
            this.button2.Text = "註冊事件";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnRegister01
            // 
            this.btnRegister01.Location = new System.Drawing.Point(21, 63);
            this.btnRegister01.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegister01.Name = "btnRegister01";
            this.btnRegister01.Size = new System.Drawing.Size(110, 35);
            this.btnRegister01.TabIndex = 2;
            this.btnRegister01.Text = "Register01";
            this.btnRegister01.UseVisualStyleBackColor = true;
            // 
            // btnRegister02
            // 
            this.btnRegister02.Location = new System.Drawing.Point(21, 115);
            this.btnRegister02.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegister02.Name = "btnRegister02";
            this.btnRegister02.Size = new System.Drawing.Size(110, 35);
            this.btnRegister02.TabIndex = 3;
            this.btnRegister02.Text = "Register02";
            this.btnRegister02.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(21, 167);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 35);
            this.button3.TabIndex = 4;
            this.button3.Text = "解除註冊";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(182, 77);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(111, 22);
            this.txtPrice.TabIndex = 5;
            // 
            // cmbDiscount
            // 
            this.cmbDiscount.FormattingEnabled = true;
            this.cmbDiscount.Items.AddRange(new object[] {
            "50%off",
            "20%off"});
            this.cmbDiscount.Location = new System.Drawing.Point(182, 117);
            this.cmbDiscount.Margin = new System.Windows.Forms.Padding(2);
            this.cmbDiscount.Name = "cmbDiscount";
            this.cmbDiscount.Size = new System.Drawing.Size(115, 20);
            this.cmbDiscount.TabIndex = 6;
            this.cmbDiscount.SelectedIndexChanged += new System.EventHandler(this.cmbDiscount_SelectedIndexChanged);
            // 
            // btnDiscount
            // 
            this.btnDiscount.Location = new System.Drawing.Point(178, 150);
            this.btnDiscount.Margin = new System.Windows.Forms.Padding(2);
            this.btnDiscount.Name = "btnDiscount";
            this.btnDiscount.Size = new System.Drawing.Size(117, 31);
            this.btnDiscount.TabIndex = 7;
            this.btnDiscount.Text = "計算價格";
            this.btnDiscount.UseVisualStyleBackColor = true;
            this.btnDiscount.Click += new System.EventHandler(this.btnDiscount_Click);
            // 
            // btn_Setproperty
            // 
            this.btn_Setproperty.Location = new System.Drawing.Point(356, 69);
            this.btn_Setproperty.Name = "btn_Setproperty";
            this.btn_Setproperty.Size = new System.Drawing.Size(112, 35);
            this.btn_Setproperty.TabIndex = 8;
            this.btn_Setproperty.Text = "set_property";
            this.btn_Setproperty.UseVisualStyleBackColor = true;
            this.btn_Setproperty.Click += new System.EventHandler(this.btn_Setproperty_Click);
            // 
            // btn_setbound
            // 
            this.btn_setbound.Location = new System.Drawing.Point(356, 130);
            this.btn_setbound.Name = "btn_setbound";
            this.btn_setbound.Size = new System.Drawing.Size(112, 31);
            this.btn_setbound.TabIndex = 9;
            this.btn_setbound.Text = "設定邊界";
            this.btn_setbound.UseVisualStyleBackColor = true;
            this.btn_setbound.Click += new System.EventHandler(this.btn_setbound_Click);
            // 
            // btn_mid
            // 
            this.btn_mid.Location = new System.Drawing.Point(356, 179);
            this.btn_mid.Name = "btn_mid";
            this.btn_mid.Size = new System.Drawing.Size(112, 33);
            this.btn_mid.TabIndex = 10;
            this.btn_mid.Text = "中斷";
            this.btn_mid.UseVisualStyleBackColor = true;
            this.btn_mid.Click += new System.EventHandler(this.btn_mid_Click);
            // 
            // btn_Dialog
            // 
            this.btn_Dialog.Location = new System.Drawing.Point(199, 23);
            this.btn_Dialog.Name = "btn_Dialog";
            this.btn_Dialog.Size = new System.Drawing.Size(94, 41);
            this.btn_Dialog.TabIndex = 11;
            this.btn_Dialog.Text = "dialog_result";
            this.btn_Dialog.UseVisualStyleBackColor = true;
            this.btn_Dialog.Click += new System.EventHandler(this.btn_Dialog_Click);
            // 
            // windo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 399);
            this.Controls.Add(this.btn_Dialog);
            this.Controls.Add(this.btn_mid);
            this.Controls.Add(this.btn_setbound);
            this.Controls.Add(this.btn_Setproperty);
            this.Controls.Add(this.btnDiscount);
            this.Controls.Add(this.cmbDiscount);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnRegister02);
            this.Controls.Add(this.btnRegister01);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "windo";
            this.Text = "Frm_M07";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnRegister01;
        private System.Windows.Forms.Button btnRegister02;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.ComboBox cmbDiscount;
        private System.Windows.Forms.Button btnDiscount;
        private System.Windows.Forms.Button btn_Setproperty;
        private System.Windows.Forms.Button btn_setbound;
        private System.Windows.Forms.Button btn_mid;
        private System.Windows.Forms.Button btn_Dialog;
    }
}