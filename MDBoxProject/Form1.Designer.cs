namespace MDBoxProject
{
    partial class mainForm
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
            this.btnMaxPos = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(81, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.TestButtonClick);
            // 
            // btnMaxPos
            // 
            this.btnMaxPos.Location = new System.Drawing.Point(42, 38);
            this.btnMaxPos.Name = "btnMaxPos";
            this.btnMaxPos.Size = new System.Drawing.Size(75, 52);
            this.btnMaxPos.TabIndex = 1;
            this.btnMaxPos.Text = "Go To Max Position";
            this.btnMaxPos.UseVisualStyleBackColor = true;
            this.btnMaxPos.Click += new System.EventHandler(this.GoToMaxClick);
            // 
            // btnZero
            // 
            this.btnZero.Location = new System.Drawing.Point(142, 38);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(75, 52);
            this.btnZero.TabIndex = 2;
            this.btnZero.Text = "Go To Zero";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.GoToZeroClick);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 140);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btnMaxPos);
            this.Controls.Add(this.button1);
            this.Name = "mainForm";
            this.Text = "MDBox Controller";
            this.Load += new System.EventHandler(this.FormLoad);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnMaxPos;
        private System.Windows.Forms.Button btnZero;
    }
}

