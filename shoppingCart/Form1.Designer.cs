
namespace shoppingCart
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
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.checkBoxShoes = new System.Windows.Forms.CheckBox();
            this.checkboxShirt = new System.Windows.Forms.CheckBox();
            this.checkBoxPants = new System.Windows.Forms.CheckBox();
            this.lblShirts = new System.Windows.Forms.Label();
            this.lblShoes = new System.Windows.Forms.Label();
            this.lblPants = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtGrandTotal = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txtShirtQuantity = new System.Windows.Forms.TextBox();
            this.txtShoesQuantity = new System.Windows.Forms.TextBox();
            this.txtPantsQuantity = new System.Windows.Forms.TextBox();
            this.txtPantsTotal = new System.Windows.Forms.TextBox();
            this.txtShoesTotal = new System.Windows.Forms.TextBox();
            this.txtShirtTotal = new System.Windows.Forms.TextBox();
            this.lblPantsPrice = new System.Windows.Forms.Label();
            this.lblShoesPrice = new System.Windows.Forms.Label();
            this.lblShirtPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.Green;
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescription.ForeColor = System.Drawing.SystemColors.Window;
            this.txtDescription.Location = new System.Drawing.Point(46, 45);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(152, 20);
            this.txtDescription.TabIndex = 0;
            this.txtDescription.Text = "Description";
            this.txtDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtQuantity
            // 
            this.txtQuantity.BackColor = System.Drawing.Color.Green;
            this.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuantity.ForeColor = System.Drawing.SystemColors.Window;
            this.txtQuantity.Location = new System.Drawing.Point(197, 45);
            this.txtQuantity.Multiline = true;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(163, 20);
            this.txtQuantity.TabIndex = 1;
            this.txtQuantity.Text = "Quantity";
            this.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.Green;
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotal.ForeColor = System.Drawing.SystemColors.Window;
            this.txtTotal.Location = new System.Drawing.Point(492, 45);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(150, 20);
            this.txtTotal.TabIndex = 2;
            this.txtTotal.Text = "Total";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.Green;
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrice.ForeColor = System.Drawing.SystemColors.Window;
            this.txtPrice.Location = new System.Drawing.Point(359, 45);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(135, 20);
            this.txtPrice.TabIndex = 3;
            this.txtPrice.Text = "Price";
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPrice.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // checkBoxShoes
            // 
            this.checkBoxShoes.AutoSize = true;
            this.checkBoxShoes.Location = new System.Drawing.Point(24, 140);
            this.checkBoxShoes.Name = "checkBoxShoes";
            this.checkBoxShoes.Size = new System.Drawing.Size(15, 14);
            this.checkBoxShoes.TabIndex = 4;
            this.checkBoxShoes.UseVisualStyleBackColor = true;
            this.checkBoxShoes.CheckedChanged += new System.EventHandler(this.checkBoxShoes_CheckedChanged);
            // 
            // checkboxShirt
            // 
            this.checkboxShirt.AutoSize = true;
            this.checkboxShirt.Location = new System.Drawing.Point(24, 91);
            this.checkboxShirt.Name = "checkboxShirt";
            this.checkboxShirt.Size = new System.Drawing.Size(15, 14);
            this.checkboxShirt.TabIndex = 5;
            this.checkboxShirt.UseVisualStyleBackColor = true;
            this.checkboxShirt.CheckedChanged += new System.EventHandler(this.checkboxShirt_CheckedChanged);
            // 
            // checkBoxPants
            // 
            this.checkBoxPants.AutoSize = true;
            this.checkBoxPants.Location = new System.Drawing.Point(24, 187);
            this.checkBoxPants.Name = "checkBoxPants";
            this.checkBoxPants.Size = new System.Drawing.Size(15, 14);
            this.checkBoxPants.TabIndex = 6;
            this.checkBoxPants.UseVisualStyleBackColor = true;
            this.checkBoxPants.CheckedChanged += new System.EventHandler(this.checkBoxPants_CheckedChanged_1);
            // 
            // lblShirts
            // 
            this.lblShirts.AutoSize = true;
            this.lblShirts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShirts.Location = new System.Drawing.Point(95, 91);
            this.lblShirts.Name = "lblShirts";
            this.lblShirts.Size = new System.Drawing.Size(44, 17);
            this.lblShirts.TabIndex = 7;
            this.lblShirts.Text = "Shirts";
            this.lblShirts.Click += new System.EventHandler(this.lblShirts_Click);
            // 
            // lblShoes
            // 
            this.lblShoes.AutoSize = true;
            this.lblShoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShoes.Location = new System.Drawing.Point(95, 140);
            this.lblShoes.Name = "lblShoes";
            this.lblShoes.Size = new System.Drawing.Size(48, 17);
            this.lblShoes.TabIndex = 8;
            this.lblShoes.Text = "Shoes";
            // 
            // lblPants
            // 
            this.lblPants.AutoSize = true;
            this.lblPants.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPants.Location = new System.Drawing.Point(95, 187);
            this.lblPants.Name = "lblPants";
            this.lblPants.Size = new System.Drawing.Size(44, 17);
            this.lblPants.TabIndex = 9;
            this.lblPants.Text = "Pants";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Green;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(359, 245);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(135, 20);
            this.textBox1.TabIndex = 13;
            this.textBox1.Text = "Grand Total";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGrandTotal
            // 
            this.txtGrandTotal.BackColor = System.Drawing.Color.Green;
            this.txtGrandTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGrandTotal.ForeColor = System.Drawing.SystemColors.Window;
            this.txtGrandTotal.Location = new System.Drawing.Point(492, 245);
            this.txtGrandTotal.Name = "txtGrandTotal";
            this.txtGrandTotal.Size = new System.Drawing.Size(150, 20);
            this.txtGrandTotal.TabIndex = 12;
            this.txtGrandTotal.Text = "0";
            this.txtGrandTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Green;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox3.Location = new System.Drawing.Point(197, 245);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(163, 20);
            this.textBox3.TabIndex = 11;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.Green;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox4.Location = new System.Drawing.Point(46, 245);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(152, 20);
            this.textBox4.TabIndex = 10;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtShirtQuantity
            // 
            this.txtShirtQuantity.Location = new System.Drawing.Point(225, 91);
            this.txtShirtQuantity.Name = "txtShirtQuantity";
            this.txtShirtQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtShirtQuantity.TabIndex = 14;
            this.txtShirtQuantity.TextChanged += new System.EventHandler(this.txtShirtQuantity_TextChanged);
            // 
            // txtShoesQuantity
            // 
            this.txtShoesQuantity.Location = new System.Drawing.Point(225, 140);
            this.txtShoesQuantity.Name = "txtShoesQuantity";
            this.txtShoesQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtShoesQuantity.TabIndex = 15;
            this.txtShoesQuantity.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtPantsQuantity
            // 
            this.txtPantsQuantity.Location = new System.Drawing.Point(225, 187);
            this.txtPantsQuantity.Name = "txtPantsQuantity";
            this.txtPantsQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtPantsQuantity.TabIndex = 16;
            this.txtPantsQuantity.TextChanged += new System.EventHandler(this.txtPantsQuantity_TextChanged);
            // 
            // txtPantsTotal
            // 
            this.txtPantsTotal.Location = new System.Drawing.Point(542, 187);
            this.txtPantsTotal.Name = "txtPantsTotal";
            this.txtPantsTotal.Size = new System.Drawing.Size(100, 20);
            this.txtPantsTotal.TabIndex = 19;
            // 
            // txtShoesTotal
            // 
            this.txtShoesTotal.Location = new System.Drawing.Point(542, 140);
            this.txtShoesTotal.Name = "txtShoesTotal";
            this.txtShoesTotal.Size = new System.Drawing.Size(100, 20);
            this.txtShoesTotal.TabIndex = 18;
            // 
            // txtShirtTotal
            // 
            this.txtShirtTotal.Location = new System.Drawing.Point(542, 91);
            this.txtShirtTotal.Name = "txtShirtTotal";
            this.txtShirtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtShirtTotal.TabIndex = 17;
            // 
            // lblPantsPrice
            // 
            this.lblPantsPrice.AutoSize = true;
            this.lblPantsPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPantsPrice.Location = new System.Drawing.Point(430, 190);
            this.lblPantsPrice.Name = "lblPantsPrice";
            this.lblPantsPrice.Size = new System.Drawing.Size(52, 17);
            this.lblPantsPrice.TabIndex = 22;
            this.lblPantsPrice.Text = "$14.95";
            // 
            // lblShoesPrice
            // 
            this.lblShoesPrice.AutoSize = true;
            this.lblShoesPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShoesPrice.Location = new System.Drawing.Point(430, 143);
            this.lblShoesPrice.Name = "lblShoesPrice";
            this.lblShoesPrice.Size = new System.Drawing.Size(52, 17);
            this.lblShoesPrice.TabIndex = 21;
            this.lblShoesPrice.Text = "$19.95";
            // 
            // lblShirtPrice
            // 
            this.lblShirtPrice.AutoSize = true;
            this.lblShirtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShirtPrice.Location = new System.Drawing.Point(430, 94);
            this.lblShirtPrice.Name = "lblShirtPrice";
            this.lblShirtPrice.Size = new System.Drawing.Size(44, 17);
            this.lblShirtPrice.TabIndex = 20;
            this.lblShirtPrice.Text = "$9.95";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPantsPrice);
            this.Controls.Add(this.lblShoesPrice);
            this.Controls.Add(this.lblShirtPrice);
            this.Controls.Add(this.txtPantsTotal);
            this.Controls.Add(this.txtShoesTotal);
            this.Controls.Add(this.txtShirtTotal);
            this.Controls.Add(this.txtPantsQuantity);
            this.Controls.Add(this.txtShoesQuantity);
            this.Controls.Add(this.txtShirtQuantity);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtGrandTotal);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.lblPants);
            this.Controls.Add(this.lblShoes);
            this.Controls.Add(this.lblShirts);
            this.Controls.Add(this.checkBoxPants);
            this.Controls.Add(this.checkboxShirt);
            this.Controls.Add(this.checkBoxShoes);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtDescription);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.CheckBox checkBoxShoes;
        private System.Windows.Forms.CheckBox checkboxShirt;
        private System.Windows.Forms.CheckBox checkBoxPants;
        private System.Windows.Forms.Label lblShirts;
        private System.Windows.Forms.Label lblShoes;
        private System.Windows.Forms.Label lblPants;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtGrandTotal;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox txtShirtQuantity;
        private System.Windows.Forms.TextBox txtShoesQuantity;
        private System.Windows.Forms.TextBox txtPantsQuantity;
        private System.Windows.Forms.TextBox txtPantsTotal;
        private System.Windows.Forms.TextBox txtShoesTotal;
        private System.Windows.Forms.TextBox txtShirtTotal;
        private System.Windows.Forms.Label lblPantsPrice;
        private System.Windows.Forms.Label lblShoesPrice;
        private System.Windows.Forms.Label lblShirtPrice;
    }
}

