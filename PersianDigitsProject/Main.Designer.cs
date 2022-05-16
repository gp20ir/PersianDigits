
namespace PersianDigitsProject
{
    partial class Main
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
            this.BtnPersianDigits = new System.Windows.Forms.Button();
            this.txtMyNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnPersianDigits
            // 
            this.BtnPersianDigits.Location = new System.Drawing.Point(21, 69);
            this.BtnPersianDigits.Name = "BtnPersianDigits";
            this.BtnPersianDigits.Size = new System.Drawing.Size(232, 40);
            this.BtnPersianDigits.TabIndex = 0;
            this.BtnPersianDigits.Text = "Convert Persian Digits";
            this.BtnPersianDigits.UseVisualStyleBackColor = true;
            this.BtnPersianDigits.Click += new System.EventHandler(this.BtnPersianDigits_Click);
            // 
            // txtMyNumber
            // 
            this.txtMyNumber.Location = new System.Drawing.Point(21, 22);
            this.txtMyNumber.Name = "txtMyNumber";
            this.txtMyNumber.Size = new System.Drawing.Size(232, 21);
            this.txtMyNumber.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Result";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(109, 153);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(119, 13);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "............................";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 206);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMyNumber);
            this.Controls.Add(this.BtnPersianDigits);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "Main";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnPersianDigits;
        private System.Windows.Forms.TextBox txtMyNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResult;
    }
}

