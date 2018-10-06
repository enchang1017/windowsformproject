namespace Homework1
{
    partial class StartUpForm
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
            this._customerSideButton = new System.Windows.Forms.Button();
            this._restaurantSideButton = new System.Windows.Forms.Button();
            this._exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _customerSideButton
            // 
            this._customerSideButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._customerSideButton.Location = new System.Drawing.Point(8, 7);
            this._customerSideButton.Name = "_customerSideButton";
            this._customerSideButton.Size = new System.Drawing.Size(785, 111);
            this._customerSideButton.TabIndex = 0;
            this._customerSideButton.Text = "Start the Customer Program(FrontEnd)";
            this._customerSideButton.UseVisualStyleBackColor = true;
            this._customerSideButton.Click += new System.EventHandler(this.ClickCustomerSideButton);
            // 
            // _restaurantSideButton
            // 
            this._restaurantSideButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._restaurantSideButton.Location = new System.Drawing.Point(8, 124);
            this._restaurantSideButton.Name = "_restaurantSideButton";
            this._restaurantSideButton.Size = new System.Drawing.Size(785, 111);
            this._restaurantSideButton.TabIndex = 1;
            this._restaurantSideButton.Text = "Start the Restaurant Program (Backend)";
            this._restaurantSideButton.UseVisualStyleBackColor = true;
            this._restaurantSideButton.Click += new System.EventHandler(this.ClickRestaurantSideButton);
            // 
            // _exitButton
            // 
            this._exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._exitButton.Location = new System.Drawing.Point(578, 241);
            this._exitButton.Name = "_exitButton";
            this._exitButton.Size = new System.Drawing.Size(215, 68);
            this._exitButton.TabIndex = 2;
            this._exitButton.Text = "Exit";
            this._exitButton.UseVisualStyleBackColor = true;
            this._exitButton.Click += new System.EventHandler(this.ClickExitButton);
            // 
            // SetUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 319);
            this.Controls.Add(this._exitButton);
            this.Controls.Add(this._restaurantSideButton);
            this.Controls.Add(this._customerSideButton);
            this.Name = "SetUpForm";
            this.Text = "SetUpForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _customerSideButton;
        private System.Windows.Forms.Button _restaurantSideButton;
        private System.Windows.Forms.Button _exitButton;
    }
}