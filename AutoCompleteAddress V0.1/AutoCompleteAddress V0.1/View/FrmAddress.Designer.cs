namespace AutoCompleteAddress.View
{
    partial class FrmAddress
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
            this.AddressGridView = new System.Windows.Forms.DataGridView();
            this.listBoxPredictionResults = new System.Windows.Forms.ListBox();
            this.lblUserInput = new System.Windows.Forms.Label();
            this.txtUserInput = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtZipCode = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblZipCode = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblStreetAddress = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AddressGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AddressGridView
            // 
            this.AddressGridView.AllowUserToAddRows = false;
            this.AddressGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AddressGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AddressGridView.Location = new System.Drawing.Point(471, 30);
            this.AddressGridView.Name = "AddressGridView";
            this.AddressGridView.Size = new System.Drawing.Size(683, 150);
            this.AddressGridView.TabIndex = 29;
            // 
            // listBoxPredictionResults
            // 
            this.listBoxPredictionResults.FormattingEnabled = true;
            this.listBoxPredictionResults.Location = new System.Drawing.Point(123, 49);
            this.listBoxPredictionResults.Name = "listBoxPredictionResults";
            this.listBoxPredictionResults.Size = new System.Drawing.Size(329, 69);
            this.listBoxPredictionResults.TabIndex = 28;
            this.listBoxPredictionResults.Visible = false;
            this.listBoxPredictionResults.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBoxPredictionResults_KeyDown);
            this.listBoxPredictionResults.MouseUp += new System.Windows.Forms.MouseEventHandler(this.listBoxPredictionResults_MouseUp);
            // 
            // lblUserInput
            // 
            this.lblUserInput.AutoSize = true;
            this.lblUserInput.Location = new System.Drawing.Point(42, 34);
            this.lblUserInput.Name = "lblUserInput";
            this.lblUserInput.Size = new System.Drawing.Size(56, 13);
            this.lblUserInput.TabIndex = 27;
            this.lblUserInput.Text = "User Input";
            // 
            // txtUserInput
            // 
            this.txtUserInput.Location = new System.Drawing.Point(123, 30);
            this.txtUserInput.Name = "txtUserInput";
            this.txtUserInput.Size = new System.Drawing.Size(329, 20);
            this.txtUserInput.TabIndex = 16;
            this.txtUserInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUserInput_KeyDown);
            this.txtUserInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtUserInput_KeyUp);
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(208, 58);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(244, 20);
            this.txtStreet.TabIndex = 20;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(123, 91);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(329, 20);
            this.txtCity.TabIndex = 22;
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(123, 124);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(100, 20);
            this.txtState.TabIndex = 24;
            // 
            // txtZipCode
            // 
            this.txtZipCode.Location = new System.Drawing.Point(319, 124);
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(133, 20);
            this.txtZipCode.TabIndex = 25;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(123, 157);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(329, 20);
            this.txtCountry.TabIndex = 26;
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(123, 58);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(79, 20);
            this.txtNum.TabIndex = 18;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(42, 160);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(43, 13);
            this.lblCountry.TabIndex = 23;
            this.lblCountry.Text = "Country";
            // 
            // lblZipCode
            // 
            this.lblZipCode.AutoSize = true;
            this.lblZipCode.Location = new System.Drawing.Point(247, 128);
            this.lblZipCode.Name = "lblZipCode";
            this.lblZipCode.Size = new System.Drawing.Size(49, 13);
            this.lblZipCode.TabIndex = 21;
            this.lblZipCode.Text = "Zip code";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(42, 128);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(32, 13);
            this.lblState.TabIndex = 19;
            this.lblState.Text = "State";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(42, 94);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(24, 13);
            this.lblCity.TabIndex = 17;
            this.lblCity.Text = "City";
            // 
            // lblStreetAddress
            // 
            this.lblStreetAddress.AutoSize = true;
            this.lblStreetAddress.Location = new System.Drawing.Point(42, 61);
            this.lblStreetAddress.Name = "lblStreetAddress";
            this.lblStreetAddress.Size = new System.Drawing.Size(75, 13);
            this.lblStreetAddress.TabIndex = 15;
            this.lblStreetAddress.Text = "Street address";
            // 
            // FrmAddress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 243);
            this.Controls.Add(this.AddressGridView);
            this.Controls.Add(this.listBoxPredictionResults);
            this.Controls.Add(this.lblUserInput);
            this.Controls.Add(this.txtUserInput);
            this.Controls.Add(this.txtStreet);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.txtZipCode);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.lblZipCode);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblStreetAddress);
            this.Name = "FrmAddress";
            this.Text = "FrmAddress";
            ((System.ComponentModel.ISupportInitialize)(this.AddressGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AddressGridView;
        private System.Windows.Forms.ListBox listBoxPredictionResults;
        private System.Windows.Forms.Label lblUserInput;
        private System.Windows.Forms.TextBox txtUserInput;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtZipCode;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblZipCode;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblStreetAddress;
    }
}