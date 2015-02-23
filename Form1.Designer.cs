namespace CSharp_String_Variables_in_CSharp.NET
{
    partial class Form1
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
            this.btnStrings = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.lblYourNameIs = new System.Windows.Forms.Label();
            this.txtYourNameIs = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnStrings
            // 
            this.btnStrings.Location = new System.Drawing.Point(90, 175);
            this.btnStrings.Name = "btnStrings";
            this.btnStrings.Size = new System.Drawing.Size(120, 30);
            this.btnStrings.TabIndex = 2;
            this.btnStrings.Text = "Get Text Box Data";
            this.btnStrings.UseVisualStyleBackColor = true;
            this.btnStrings.Click += new System.EventHandler(this.btnStrings_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(10, 50);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // txtBox
            // 
            this.txtBox.Location = new System.Drawing.Point(90, 50);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(133, 20);
            this.txtBox.TabIndex = 1;
            // 
            // lblYourNameIs
            // 
            this.lblYourNameIs.AutoSize = true;
            this.lblYourNameIs.Location = new System.Drawing.Point(87, 117);
            this.lblYourNameIs.Name = "lblYourNameIs";
            this.lblYourNameIs.Size = new System.Drawing.Size(74, 13);
            this.lblYourNameIs.TabIndex = 3;
            this.lblYourNameIs.Text = "Your name is: ";
            // 
            // txtYourNameIs
            // 
            this.txtYourNameIs.Location = new System.Drawing.Point(90, 94);
            this.txtYourNameIs.Name = "txtYourNameIs";
            this.txtYourNameIs.Size = new System.Drawing.Size(133, 20);
            this.txtYourNameIs.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.txtYourNameIs);
            this.Controls.Add(this.lblYourNameIs);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnStrings);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStrings;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.Label lblYourNameIs;
        private System.Windows.Forms.TextBox txtYourNameIs;
    }
}

