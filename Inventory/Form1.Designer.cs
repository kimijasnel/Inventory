using System;

namespace Inventory
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
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblSKU = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnSaveProd = new Guna.UI2.WinForms.Guna2Button();
            this.btnGo_Back = new Guna.UI2.WinForms.Guna2Button();
            this.txtProdName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSKU = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.SuspendLayout();
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(9, 18);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(110, 21);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "Product Name";
            // 
            // lblSKU
            // 
            this.lblSKU.AutoSize = true;
            this.lblSKU.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSKU.Location = new System.Drawing.Point(12, 95);
            this.lblSKU.Name = "lblSKU";
            this.lblSKU.Size = new System.Drawing.Size(39, 21);
            this.lblSKU.TabIndex = 2;
            this.lblSKU.Text = "SKU";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(12, 173);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(53, 21);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Status";
            // 
            // btnSaveProd
            // 
            this.btnSaveProd.AutoRoundedCorners = true;
            this.btnSaveProd.BackColor = System.Drawing.Color.White;
            this.btnSaveProd.BorderRadius = 14;
            this.btnSaveProd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveProd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveProd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSaveProd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSaveProd.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSaveProd.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveProd.ForeColor = System.Drawing.Color.Black;
            this.btnSaveProd.Location = new System.Drawing.Point(623, 249);
            this.btnSaveProd.Name = "btnSaveProd";
            this.btnSaveProd.Size = new System.Drawing.Size(126, 31);
            this.btnSaveProd.TabIndex = 9;
            this.btnSaveProd.Text = "Save Product";
            this.btnSaveProd.Click += new System.EventHandler(this.btnSaveProd_Click);
            // 
            // btnGo_Back
            // 
            this.btnGo_Back.AutoRoundedCorners = true;
            this.btnGo_Back.BorderRadius = 14;
            this.btnGo_Back.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGo_Back.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGo_Back.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGo_Back.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGo_Back.FillColor = System.Drawing.Color.LightBlue;
            this.btnGo_Back.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGo_Back.ForeColor = System.Drawing.Color.Black;
            this.btnGo_Back.Location = new System.Drawing.Point(517, 249);
            this.btnGo_Back.Name = "btnGo_Back";
            this.btnGo_Back.Size = new System.Drawing.Size(100, 31);
            this.btnGo_Back.TabIndex = 10;
            this.btnGo_Back.Text = "Go Back";
            // 
            // txtProdName
            // 
            this.txtProdName.AutoRoundedCorners = true;
            this.txtProdName.BorderColor = System.Drawing.Color.Silver;
            this.txtProdName.BorderRadius = 17;
            this.txtProdName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProdName.DefaultText = "";
            this.txtProdName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtProdName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtProdName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProdName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProdName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProdName.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProdName.Location = new System.Drawing.Point(13, 43);
            this.txtProdName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtProdName.Name = "txtProdName";
            this.txtProdName.PasswordChar = '\0';
            this.txtProdName.PlaceholderText = "";
            this.txtProdName.SelectedText = "";
            this.txtProdName.Size = new System.Drawing.Size(736, 36);
            this.txtProdName.TabIndex = 11;
            // 
            // txtSKU
            // 
            this.txtSKU.AutoRoundedCorners = true;
            this.txtSKU.BorderColor = System.Drawing.Color.Silver;
            this.txtSKU.BorderRadius = 17;
            this.txtSKU.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSKU.DefaultText = "";
            this.txtSKU.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSKU.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSKU.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSKU.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSKU.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSKU.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSKU.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSKU.Location = new System.Drawing.Point(13, 120);
            this.txtSKU.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSKU.Name = "txtSKU";
            this.txtSKU.PasswordChar = '\0';
            this.txtSKU.PlaceholderText = "";
            this.txtSKU.SelectedText = "";
            this.txtSKU.Size = new System.Drawing.Size(736, 36);
            this.txtSKU.TabIndex = 12;
            // 
            // cmbStatus
            // 
            this.cmbStatus.AutoRoundedCorners = true;
            this.cmbStatus.BackColor = System.Drawing.Color.Transparent;
            this.cmbStatus.BorderColor = System.Drawing.Color.Silver;
            this.cmbStatus.BorderRadius = 17;
            this.cmbStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbStatus.Font = new System.Drawing.Font("Segoe UI Emoji", 12F);
            this.cmbStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbStatus.ItemHeight = 30;
            this.cmbStatus.Items.AddRange(new object[] {
            "Status1",
            "Status2",
            "Status3"});
            this.cmbStatus.Location = new System.Drawing.Point(16, 197);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(733, 36);
            this.cmbStatus.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(761, 292);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.txtSKU);
            this.Controls.Add(this.txtProdName);
            this.Controls.Add(this.btnGo_Back);
            this.Controls.Add(this.btnSaveProd);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblSKU);
            this.Controls.Add(this.lblProductName);
            this.Name = "Form1";
            this.Text = "Product";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        #endregion

        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblSKU;
        private System.Windows.Forms.Label lblStatus;
        private Guna.UI2.WinForms.Guna2Button btnSaveProd;
        private Guna.UI2.WinForms.Guna2Button btnGo_Back;
        private Guna.UI2.WinForms.Guna2TextBox txtProdName;
        private Guna.UI2.WinForms.Guna2TextBox txtSKU;
        private Guna.UI2.WinForms.Guna2ComboBox cmbStatus;
    }
}

