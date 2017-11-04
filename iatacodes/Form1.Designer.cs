namespace iatacodes
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
            this.btnGetAirportInfo = new System.Windows.Forms.Button();
            this.txtAirportCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGetAirportInfo
            // 
            this.btnGetAirportInfo.Location = new System.Drawing.Point(116, 89);
            this.btnGetAirportInfo.Name = "btnGetAirportInfo";
            this.btnGetAirportInfo.Size = new System.Drawing.Size(129, 23);
            this.btnGetAirportInfo.TabIndex = 0;
            this.btnGetAirportInfo.Text = "Get Airport Information";
            this.btnGetAirportInfo.UseVisualStyleBackColor = true;
            this.btnGetAirportInfo.Click += new System.EventHandler(this.btnGetAirportInfo_Click);
            // 
            // txtAirportCode
            // 
            this.txtAirportCode.Location = new System.Drawing.Point(87, 35);
            this.txtAirportCode.Name = "txtAirportCode";
            this.txtAirportCode.Size = new System.Drawing.Size(221, 20);
            this.txtAirportCode.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Airport Code:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 186);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAirportCode);
            this.Controls.Add(this.btnGetAirportInfo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetAirportInfo;
        private System.Windows.Forms.TextBox txtAirportCode;
        private System.Windows.Forms.Label label2;
    }
}

