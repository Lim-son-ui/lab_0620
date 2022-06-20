
namespace Lab_Form
{
    partial class Frm_M04
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
            this.btnOpenHelloForm = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenHelloForm
            // 
            this.btnOpenHelloForm.Location = new System.Drawing.Point(540, 32);
            this.btnOpenHelloForm.Name = "btnOpenHelloForm";
            this.btnOpenHelloForm.Size = new System.Drawing.Size(159, 59);
            this.btnOpenHelloForm.TabIndex = 0;
            this.btnOpenHelloForm.Text = "Open Hello Form";
            this.btnOpenHelloForm.UseVisualStyleBackColor = true;
            this.btnOpenHelloForm.Click += new System.EventHandler(this.btnOpenHelloForm_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(540, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 59);
            this.button1.TabIndex = 1;
            this.button1.Text = "My First Method";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(540, 162);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 59);
            this.button2.TabIndex = 2;
            this.button2.Text = "Method";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(540, 227);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(159, 59);
            this.button3.TabIndex = 3;
            this.button3.Text = "Return Method";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(540, 292);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(159, 59);
            this.button4.TabIndex = 4;
            this.button4.Text = "封裝";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(540, 357);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(159, 59);
            this.button5.TabIndex = 5;
            this.button5.Text = "Partial Class";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Frm_M04
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnOpenHelloForm);
            this.Name = "Frm_M04";
            this.Text = "Frm_M04";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenHelloForm;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}