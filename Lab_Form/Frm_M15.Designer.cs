
namespace Lab_Form
{
    partial class Frm_M15
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
            this.btn_value = new System.Windows.Forms.Button();
            this.txt_reference = new System.Windows.Forms.Button();
            this.txt_refer = new System.Windows.Forms.TextBox();
            this.butt_str = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_value
            // 
            this.btn_value.Location = new System.Drawing.Point(39, 38);
            this.btn_value.Name = "btn_value";
            this.btn_value.Size = new System.Drawing.Size(195, 77);
            this.btn_value.TabIndex = 0;
            this.btn_value.Text = "value_type";
            this.btn_value.UseVisualStyleBackColor = true;
            this.btn_value.Click += new System.EventHandler(this.btn_value_Click);
            // 
            // txt_reference
            // 
            this.txt_reference.Location = new System.Drawing.Point(324, 65);
            this.txt_reference.Name = "txt_reference";
            this.txt_reference.Size = new System.Drawing.Size(75, 23);
            this.txt_reference.TabIndex = 1;
            this.txt_reference.Text = "reference";
            this.txt_reference.UseVisualStyleBackColor = true;
            this.txt_reference.Click += new System.EventHandler(this.txt_reference_Click);
            // 
            // txt_refer
            // 
            this.txt_refer.Location = new System.Drawing.Point(311, 121);
            this.txt_refer.Name = "txt_refer";
            this.txt_refer.Size = new System.Drawing.Size(100, 22);
            this.txt_refer.TabIndex = 2;
            // 
            // butt_str
            // 
            this.butt_str.Location = new System.Drawing.Point(280, 209);
            this.butt_str.Name = "butt_str";
            this.butt_str.Size = new System.Drawing.Size(75, 23);
            this.butt_str.TabIndex = 3;
            this.butt_str.Text = "but_str";
            this.butt_str.UseVisualStyleBackColor = true;
            this.butt_str.Click += new System.EventHandler(this.butt_str_Click);
            // 
            // Frm_M15
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butt_str);
            this.Controls.Add(this.txt_refer);
            this.Controls.Add(this.txt_reference);
            this.Controls.Add(this.btn_value);
            this.Name = "Frm_M15";
            this.Text = "Frm_M15";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_value;
        private System.Windows.Forms.Button txt_reference;
        private System.Windows.Forms.TextBox txt_refer;
        private System.Windows.Forms.Button butt_str;
    }
}