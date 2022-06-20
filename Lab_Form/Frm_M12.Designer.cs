
namespace Lab_Form
{
    partial class Frm_M12
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
            this.btn_Math = new System.Windows.Forms.Button();
            this.label_count = new System.Windows.Forms.Label();
            this.text_plus = new System.Windows.Forms.Button();
            this.group_box = new System.Windows.Forms.GroupBox();
            this.btn_locovar = new System.Windows.Forms.Button();
            this.btn_var = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_static_count = new System.Windows.Forms.Button();
            this.btn_instance = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_frm = new System.Windows.Forms.Button();
            this.group_box.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Math
            // 
            this.btn_Math.Location = new System.Drawing.Point(48, 95);
            this.btn_Math.Name = "btn_Math";
            this.btn_Math.Size = new System.Drawing.Size(75, 23);
            this.btn_Math.TabIndex = 0;
            this.btn_Math.Text = "+-*/";
            this.btn_Math.UseVisualStyleBackColor = true;
            this.btn_Math.Click += new System.EventHandler(this.btn_Math_Click);
            // 
            // label_count
            // 
            this.label_count.AutoSize = true;
            this.label_count.Location = new System.Drawing.Point(46, 44);
            this.label_count.Name = "label_count";
            this.label_count.Size = new System.Drawing.Size(40, 12);
            this.label_count.TabIndex = 1;
            this.label_count.Text = "count:0";
            this.label_count.Click += new System.EventHandler(this.label_count_Click);
            // 
            // text_plus
            // 
            this.text_plus.Location = new System.Drawing.Point(48, 154);
            this.text_plus.Name = "text_plus";
            this.text_plus.Size = new System.Drawing.Size(75, 23);
            this.text_plus.TabIndex = 2;
            this.text_plus.Text = "count++";
            this.text_plus.UseVisualStyleBackColor = true;
            this.text_plus.Click += new System.EventHandler(this.text_plus_Click);
            // 
            // group_box
            // 
            this.group_box.Controls.Add(this.btn_var);
            this.group_box.Controls.Add(this.btn_locovar);
            this.group_box.Location = new System.Drawing.Point(212, 56);
            this.group_box.Name = "group_box";
            this.group_box.Size = new System.Drawing.Size(226, 112);
            this.group_box.TabIndex = 3;
            this.group_box.TabStop = false;
            this.group_box.Text = "Local_Variable";
            // 
            // btn_locovar
            // 
            this.btn_locovar.Location = new System.Drawing.Point(74, 21);
            this.btn_locovar.Name = "btn_locovar";
            this.btn_locovar.Size = new System.Drawing.Size(75, 23);
            this.btn_locovar.TabIndex = 0;
            this.btn_locovar.Text = "Local_Var";
            this.btn_locovar.UseVisualStyleBackColor = true;
            this.btn_locovar.Click += new System.EventHandler(this.btn_locovar_Click);
            // 
            // btn_var
            // 
            this.btn_var.Location = new System.Drawing.Point(74, 73);
            this.btn_var.Name = "btn_var";
            this.btn_var.Size = new System.Drawing.Size(75, 23);
            this.btn_var.TabIndex = 1;
            this.btn_var.Text = "Var";
            this.btn_var.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_static_count);
            this.groupBox1.Controls.Add(this.btn_instance);
            this.groupBox1.Location = new System.Drawing.Point(212, 223);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 112);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "static";
            // 
            // btn_static_count
            // 
            this.btn_static_count.Location = new System.Drawing.Point(74, 73);
            this.btn_static_count.Name = "btn_static_count";
            this.btn_static_count.Size = new System.Drawing.Size(75, 23);
            this.btn_static_count.TabIndex = 1;
            this.btn_static_count.Text = "static count";
            this.btn_static_count.UseVisualStyleBackColor = true;
            this.btn_static_count.Click += new System.EventHandler(this.btn_static_count_Click);
            // 
            // btn_instance
            // 
            this.btn_instance.Location = new System.Drawing.Point(74, 21);
            this.btn_instance.Name = "btn_instance";
            this.btn_instance.Size = new System.Drawing.Size(75, 23);
            this.btn_instance.TabIndex = 0;
            this.btn_instance.Text = "instance count";
            this.btn_instance.UseVisualStyleBackColor = true;
            this.btn_instance.Click += new System.EventHandler(this.btn_instance_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(444, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "Instance Count:0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(444, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "Static Count:0";
            // 
            // btn_frm
            // 
            this.btn_frm.Location = new System.Drawing.Point(286, 341);
            this.btn_frm.Name = "btn_frm";
            this.btn_frm.Size = new System.Drawing.Size(75, 23);
            this.btn_frm.TabIndex = 1;
            this.btn_frm.Text = "btn_Frm2";
            this.btn_frm.UseVisualStyleBackColor = true;
            this.btn_frm.Click += new System.EventHandler(this.btn_frm_Click);
            // 
            // Frm_M12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_frm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.group_box);
            this.Controls.Add(this.text_plus);
            this.Controls.Add(this.label_count);
            this.Controls.Add(this.btn_Math);
            this.Name = "Frm_M12";
            this.Text = "Frm_M12";
            this.group_box.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Math;
        private System.Windows.Forms.Label label_count;
        private System.Windows.Forms.Button text_plus;
        private System.Windows.Forms.GroupBox group_box;
        private System.Windows.Forms.Button btn_var;
        private System.Windows.Forms.Button btn_locovar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_static_count;
        private System.Windows.Forms.Button btn_instance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_frm;
    }
}