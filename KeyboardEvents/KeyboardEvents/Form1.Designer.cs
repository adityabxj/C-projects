namespace PasswordGenerator
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
            this.numPadButton = new System.Windows.Forms.Button();
            this.alphabetButton = new System.Windows.Forms.Button();
            this.numberLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // numPadButton
            // 
            this.numPadButton.Font = new System.Drawing.Font("Old English Text MT", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPadButton.Location = new System.Drawing.Point(289, 195);
            this.numPadButton.Name = "numPadButton";
            this.numPadButton.Size = new System.Drawing.Size(242, 71);
            this.numPadButton.TabIndex = 0;
            this.numPadButton.Text = "Press me!";
            this.numPadButton.UseVisualStyleBackColor = true;
            this.numPadButton.Click += new System.EventHandler(this.numPadButton_Click);
            // 
            // alphabetButton
            // 
            this.alphabetButton.Font = new System.Drawing.Font("Old English Text MT", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alphabetButton.Location = new System.Drawing.Point(289, 293);
            this.alphabetButton.Name = "alphabetButton";
            this.alphabetButton.Size = new System.Drawing.Size(242, 78);
            this.alphabetButton.TabIndex = 1;
            this.alphabetButton.Text = "Press me too!";
            this.alphabetButton.UseVisualStyleBackColor = true;
            this.alphabetButton.Click += new System.EventHandler(this.alphabetButton_Click);
            // 
            // numberLabel
            // 
            this.numberLabel.Font = new System.Drawing.Font("Algerian", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberLabel.Location = new System.Drawing.Point(29, 76);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(782, 76);
            this.numberLabel.TabIndex = 2;
            this.numberLabel.Text = "Welcome :)";
            this.numberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(834, 498);
            this.Controls.Add(this.numberLabel);
            this.Controls.Add(this.alphabetButton);
            this.Controls.Add(this.numPadButton);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "KeyboardEvents";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button numPadButton;
        private System.Windows.Forms.Button alphabetButton;
        private System.Windows.Forms.Label numberLabel;
    }
}

