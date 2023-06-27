namespace Cafe_Management_System.allUserControls
{
    partial class UC_AddItems
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.categoryTxt = new Guna.UI2.WinForms.Guna2ComboBox();
            this.itemNameTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.itemPriceTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.addItemBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(298, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add New Items";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(207, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(207, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Item Name";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(207, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Price";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // categoryTxt
            // 
            this.categoryTxt.BackColor = System.Drawing.Color.Transparent;
            this.categoryTxt.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.categoryTxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryTxt.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.categoryTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.categoryTxt.FocusedState.Parent = this.categoryTxt;
            this.categoryTxt.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.categoryTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.categoryTxt.HoverState.Parent = this.categoryTxt;
            this.categoryTxt.ItemHeight = 30;
            this.categoryTxt.Items.AddRange(new object[] {
            "Hot Beverages",
            "Cold Beverages",
            "Salads",
            "Fruit Juices",
            "Soda",
            "waffles",
            "Sandwiches",
            "burgers",
            "Cakes"});
            this.categoryTxt.ItemsAppearance.Parent = this.categoryTxt;
            this.categoryTxt.Location = new System.Drawing.Point(211, 160);
            this.categoryTxt.Name = "categoryTxt";
            this.categoryTxt.ShadowDecoration.Parent = this.categoryTxt;
            this.categoryTxt.Size = new System.Drawing.Size(341, 36);
            this.categoryTxt.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.categoryTxt.TabIndex = 4;
            // 
            // itemNameTxt
            // 
            this.itemNameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.itemNameTxt.DefaultText = "";
            this.itemNameTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.itemNameTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.itemNameTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.itemNameTxt.DisabledState.Parent = this.itemNameTxt;
            this.itemNameTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.itemNameTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.itemNameTxt.FocusedState.Parent = this.itemNameTxt;
            this.itemNameTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemNameTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.itemNameTxt.HoverState.Parent = this.itemNameTxt;
            this.itemNameTxt.Location = new System.Drawing.Point(211, 246);
            this.itemNameTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.itemNameTxt.Name = "itemNameTxt";
            this.itemNameTxt.PasswordChar = '\0';
            this.itemNameTxt.PlaceholderText = "";
            this.itemNameTxt.SelectedText = "";
            this.itemNameTxt.ShadowDecoration.Parent = this.itemNameTxt;
            this.itemNameTxt.Size = new System.Drawing.Size(341, 37);
            this.itemNameTxt.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.itemNameTxt.TabIndex = 5;
            this.itemNameTxt.TextChanged += new System.EventHandler(this.Guna2TextBox1_TextChanged);
            // 
            // itemPriceTxt
            // 
            this.itemPriceTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.itemPriceTxt.DefaultText = "";
            this.itemPriceTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.itemPriceTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.itemPriceTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.itemPriceTxt.DisabledState.Parent = this.itemPriceTxt;
            this.itemPriceTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.itemPriceTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.itemPriceTxt.FocusedState.Parent = this.itemPriceTxt;
            this.itemPriceTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemPriceTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.itemPriceTxt.HoverState.Parent = this.itemPriceTxt;
            this.itemPriceTxt.Location = new System.Drawing.Point(208, 343);
            this.itemPriceTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.itemPriceTxt.Name = "itemPriceTxt";
            this.itemPriceTxt.PasswordChar = '\0';
            this.itemPriceTxt.PlaceholderText = "";
            this.itemPriceTxt.SelectedText = "";
            this.itemPriceTxt.ShadowDecoration.Parent = this.itemPriceTxt;
            this.itemPriceTxt.Size = new System.Drawing.Size(341, 37);
            this.itemPriceTxt.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.itemPriceTxt.TabIndex = 6;
            // 
            // addItemBtn
            // 
            this.addItemBtn.BorderRadius = 20;
            this.addItemBtn.CheckedState.Parent = this.addItemBtn;
            this.addItemBtn.CustomImages.Parent = this.addItemBtn;
            this.addItemBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addItemBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addItemBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addItemBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addItemBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addItemBtn.DisabledState.Parent = this.addItemBtn;
            this.addItemBtn.FillColor2 = System.Drawing.Color.Sienna;
            this.addItemBtn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItemBtn.ForeColor = System.Drawing.Color.White;
            this.addItemBtn.HoverState.Parent = this.addItemBtn;
            this.addItemBtn.Location = new System.Drawing.Point(275, 421);
            this.addItemBtn.Name = "addItemBtn";
            this.addItemBtn.ShadowDecoration.Parent = this.addItemBtn;
            this.addItemBtn.Size = new System.Drawing.Size(180, 45);
            this.addItemBtn.TabIndex = 7;
            this.addItemBtn.Text = "Add Item";
            this.addItemBtn.Click += new System.EventHandler(this.AddItemBtn_Click);
            this.addItemBtn.Leave += new System.EventHandler(this.AddItemBtn_Leave);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // UC_AddItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.addItemBtn);
            this.Controls.Add(this.itemPriceTxt);
            this.Controls.Add(this.itemNameTxt);
            this.Controls.Add(this.categoryTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UC_AddItems";
            this.Size = new System.Drawing.Size(781, 514);
            this.Load += new System.EventHandler(this.UC_AddItems_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox categoryTxt;
        private Guna.UI2.WinForms.Guna2TextBox itemNameTxt;
        private Guna.UI2.WinForms.Guna2TextBox itemPriceTxt;
        private Guna.UI2.WinForms.Guna2GradientButton addItemBtn;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
