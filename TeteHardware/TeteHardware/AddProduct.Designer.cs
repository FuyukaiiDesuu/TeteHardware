﻿namespace TeteHardware
{
    partial class formAddProduct
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
            this.labelPstock = new System.Windows.Forms.Label();
            this.txtPstock = new System.Windows.Forms.TextBox();
            this.labelPdesc = new System.Windows.Forms.Label();
            this.txtPdesc = new System.Windows.Forms.TextBox();
            this.labelPstatus = new System.Windows.Forms.Label();
            this.labelPcat = new System.Windows.Forms.Label();
            this.labelPprice = new System.Windows.Forms.Label();
            this.comboPcat = new System.Windows.Forms.ComboBox();
            this.labelPname = new System.Windows.Forms.Label();
            this.labelPid = new System.Windows.Forms.Label();
            this.txtPprice = new System.Windows.Forms.TextBox();
            this.txtPname = new System.Windows.Forms.TextBox();
            this.txtPid = new System.Windows.Forms.TextBox();
            this.comboPstatus = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.labelAddProduct = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelPstock
            // 
            this.labelPstock.AutoSize = true;
            this.labelPstock.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPstock.ForeColor = System.Drawing.Color.White;
            this.labelPstock.Location = new System.Drawing.Point(53, 304);
            this.labelPstock.Name = "labelPstock";
            this.labelPstock.Size = new System.Drawing.Size(42, 19);
            this.labelPstock.TabIndex = 192;
            this.labelPstock.Text = "Stock";
            // 
            // txtPstock
            // 
            this.txtPstock.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPstock.Location = new System.Drawing.Point(198, 304);
            this.txtPstock.Name = "txtPstock";
            this.txtPstock.Size = new System.Drawing.Size(192, 25);
            this.txtPstock.TabIndex = 180;
            // 
            // labelPdesc
            // 
            this.labelPdesc.AutoSize = true;
            this.labelPdesc.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPdesc.ForeColor = System.Drawing.Color.White;
            this.labelPdesc.Location = new System.Drawing.Point(53, 180);
            this.labelPdesc.Name = "labelPdesc";
            this.labelPdesc.Size = new System.Drawing.Size(132, 19);
            this.labelPdesc.TabIndex = 191;
            this.labelPdesc.Text = "Product Description:";
            // 
            // txtPdesc
            // 
            this.txtPdesc.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPdesc.Location = new System.Drawing.Point(198, 180);
            this.txtPdesc.Multiline = true;
            this.txtPdesc.Name = "txtPdesc";
            this.txtPdesc.Size = new System.Drawing.Size(192, 78);
            this.txtPdesc.TabIndex = 178;
            // 
            // labelPstatus
            // 
            this.labelPstatus.AutoSize = true;
            this.labelPstatus.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPstatus.ForeColor = System.Drawing.Color.White;
            this.labelPstatus.Location = new System.Drawing.Point(53, 374);
            this.labelPstatus.Name = "labelPstatus";
            this.labelPstatus.Size = new System.Drawing.Size(101, 19);
            this.labelPstatus.TabIndex = 190;
            this.labelPstatus.Text = "Product Status:";
            // 
            // labelPcat
            // 
            this.labelPcat.AutoSize = true;
            this.labelPcat.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPcat.ForeColor = System.Drawing.Color.White;
            this.labelPcat.Location = new System.Drawing.Point(53, 269);
            this.labelPcat.Name = "labelPcat";
            this.labelPcat.Size = new System.Drawing.Size(125, 19);
            this.labelPcat.TabIndex = 186;
            this.labelPcat.Text = "Product Category:";
            // 
            // labelPprice
            // 
            this.labelPprice.AutoSize = true;
            this.labelPprice.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPprice.ForeColor = System.Drawing.Color.White;
            this.labelPprice.Location = new System.Drawing.Point(53, 339);
            this.labelPprice.Name = "labelPprice";
            this.labelPprice.Size = new System.Drawing.Size(43, 19);
            this.labelPprice.TabIndex = 187;
            this.labelPprice.Text = "Price:";
            // 
            // comboPcat
            // 
            this.comboPcat.AllowDrop = true;
            this.comboPcat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPcat.Font = new System.Drawing.Font("Tw Cen MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboPcat.FormattingEnabled = true;
            this.comboPcat.Location = new System.Drawing.Point(198, 269);
            this.comboPcat.Name = "comboPcat";
            this.comboPcat.Size = new System.Drawing.Size(192, 25);
            this.comboPcat.TabIndex = 179;
            // 
            // labelPname
            // 
            this.labelPname.AutoSize = true;
            this.labelPname.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPname.ForeColor = System.Drawing.Color.White;
            this.labelPname.Location = new System.Drawing.Point(53, 145);
            this.labelPname.Name = "labelPname";
            this.labelPname.Size = new System.Drawing.Size(103, 19);
            this.labelPname.TabIndex = 188;
            this.labelPname.Text = "Product Name:";
            // 
            // labelPid
            // 
            this.labelPid.AutoSize = true;
            this.labelPid.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPid.ForeColor = System.Drawing.Color.White;
            this.labelPid.Location = new System.Drawing.Point(53, 110);
            this.labelPid.Name = "labelPid";
            this.labelPid.Size = new System.Drawing.Size(78, 19);
            this.labelPid.TabIndex = 189;
            this.labelPid.Text = "Product ID:";
            // 
            // txtPprice
            // 
            this.txtPprice.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPprice.Location = new System.Drawing.Point(198, 339);
            this.txtPprice.Name = "txtPprice";
            this.txtPprice.Size = new System.Drawing.Size(192, 25);
            this.txtPprice.TabIndex = 181;
            // 
            // txtPname
            // 
            this.txtPname.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPname.Location = new System.Drawing.Point(198, 145);
            this.txtPname.Name = "txtPname";
            this.txtPname.Size = new System.Drawing.Size(192, 25);
            this.txtPname.TabIndex = 176;
            // 
            // txtPid
            // 
            this.txtPid.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPid.Location = new System.Drawing.Point(198, 110);
            this.txtPid.Name = "txtPid";
            this.txtPid.ReadOnly = true;
            this.txtPid.Size = new System.Drawing.Size(192, 25);
            this.txtPid.TabIndex = 177;
            // 
            // comboPstatus
            // 
            this.comboPstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPstatus.Font = new System.Drawing.Font("Tw Cen MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboPstatus.FormattingEnabled = true;
            this.comboPstatus.Location = new System.Drawing.Point(198, 374);
            this.comboPstatus.Name = "comboPstatus";
            this.comboPstatus.Size = new System.Drawing.Size(192, 25);
            this.comboPstatus.TabIndex = 182;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(152)))));
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(152)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(220)))), ((int)(((byte)(209)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(279, 428);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 40);
            this.btnCancel.TabIndex = 195;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(152)))));
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(152)))));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(220)))), ((int)(((byte)(209)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(182, 428);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(91, 40);
            this.btnClear.TabIndex = 194;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(152)))));
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(152)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(220)))), ((int)(((byte)(209)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(85, 428);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(91, 40);
            this.btnAdd.TabIndex = 193;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(152)))));
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.labelAddProduct);
            this.panel1.Location = new System.Drawing.Point(0, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 58);
            this.panel1.TabIndex = 196;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(152)))));
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(181)))), ((int)(((byte)(116)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Tw Cen MT", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(262, 17);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(63, 27);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // labelAddProduct
            // 
            this.labelAddProduct.AutoSize = true;
            this.labelAddProduct.Font = new System.Drawing.Font("Tw Cen MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddProduct.ForeColor = System.Drawing.Color.White;
            this.labelAddProduct.Location = new System.Drawing.Point(24, 13);
            this.labelAddProduct.Name = "labelAddProduct";
            this.labelAddProduct.Size = new System.Drawing.Size(205, 31);
            this.labelAddProduct.TabIndex = 101;
            this.labelAddProduct.Text = "Add New Product";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(181)))), ((int)(((byte)(116)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(152)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Tw Cen MT", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(421, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(29, 27);
            this.btnClose.TabIndex = 197;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // formAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(462, 495);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.labelPstock);
            this.Controls.Add(this.txtPstock);
            this.Controls.Add(this.labelPdesc);
            this.Controls.Add(this.txtPdesc);
            this.Controls.Add(this.labelPstatus);
            this.Controls.Add(this.labelPcat);
            this.Controls.Add(this.labelPprice);
            this.Controls.Add(this.comboPcat);
            this.Controls.Add(this.labelPname);
            this.Controls.Add(this.labelPid);
            this.Controls.Add(this.txtPprice);
            this.Controls.Add(this.txtPname);
            this.Controls.Add(this.txtPid);
            this.Controls.Add(this.comboPstatus);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "formAddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelPstock;
        private System.Windows.Forms.TextBox txtPstock;
        private System.Windows.Forms.Label labelPdesc;
        private System.Windows.Forms.TextBox txtPdesc;
        private System.Windows.Forms.Label labelPstatus;
        private System.Windows.Forms.Label labelPcat;
        private System.Windows.Forms.Label labelPprice;
        private System.Windows.Forms.ComboBox comboPcat;
        private System.Windows.Forms.Label labelPname;
        private System.Windows.Forms.Label labelPid;
        private System.Windows.Forms.TextBox txtPprice;
        private System.Windows.Forms.TextBox txtPname;
        private System.Windows.Forms.TextBox txtPid;
        private System.Windows.Forms.ComboBox comboPstatus;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label labelAddProduct;
        private System.Windows.Forms.Button btnClose;
    }
}