namespace Homework1
{
    partial class RestaurantSide
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
            this._sign = new System.Windows.Forms.Label();
            this._checkButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _sign
            // 
            this._sign.AutoSize = true;
            this._sign.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._sign.Location = new System.Drawing.Point(176, 128);
            this._sign.Name = "_sign";
            this._sign.Size = new System.Drawing.Size(451, 73);
            this._sign.TabIndex = 0;
            this._sign.Text = "Coming Soon!";
            this._sign.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _checkButton
            // 
            this._checkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._checkButton.Location = new System.Drawing.Point(310, 249);
            this._checkButton.Name = "_checkButton";
            this._checkButton.Size = new System.Drawing.Size(151, 26);
            this._checkButton.TabIndex = 1;
            this._checkButton.Text = "OK";
            this._checkButton.UseVisualStyleBackColor = true;
            this._checkButton.Click += new System.EventHandler(this.ClickCheckButton);
            // 
            // RestaurantSide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._checkButton);
            this.Controls.Add(this._sign);
            this.Name = "RestaurantSide";
            this.Text = "RestaurantSide";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _sign;
        private System.Windows.Forms.Button _checkButton;
    }
}