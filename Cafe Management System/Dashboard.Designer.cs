namespace Cafe_Management_System
{
    partial class Dashboard
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
            this.components = new System.ComponentModel.Container();
            Guna.UI2.AnimatorNS.Animation animation2 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.logoutBtn = new System.Windows.Forms.LinkLabel();
            this.exitBtn = new Guna.UI2.WinForms.Guna2GradientCircleButton();
            this.removeItemsBtn = new Guna.UI2.WinForms.Guna2Button();
            this.updateItemsBtn = new Guna.UI2.WinForms.Guna2Button();
            this.addItmesBtn = new Guna.UI2.WinForms.Guna2Button();
            this.placeOrderBtn = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uC_RemoveItems1 = new Cafe_Management_System.allUserControls.UC_RemoveItems();
            this.uC_UpdateItem1 = new Cafe_Management_System.allUserControls.UC_UpdateItem();
            this.uC_PlaceOrder1 = new Cafe_Management_System.UC_PlaceOrder();
            this.uC_AddItems1 = new Cafe_Management_System.allUserControls.UC_AddItems();
            this.uC_Welcome1 = new Cafe_Management_System.allUserControls.UC_Welcome();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            this.guna2Elipse6 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse7 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.logoutBtn);
            this.panel1.Controls.Add(this.exitBtn);
            this.panel1.Controls.Add(this.removeItemsBtn);
            this.panel1.Controls.Add(this.updateItemsBtn);
            this.panel1.Controls.Add(this.addItmesBtn);
            this.panel1.Controls.Add(this.placeOrderBtn);
            this.guna2Transition1.SetDecoration(this.panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 514);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // logoutBtn
            // 
            this.logoutBtn.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.logoutBtn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.logoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.LinkColor = System.Drawing.Color.White;
            this.logoutBtn.Location = new System.Drawing.Point(91, 464);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(68, 20);
            this.logoutBtn.TabIndex = 5;
            this.logoutBtn.TabStop = true;
            this.logoutBtn.Text = "LogOut";
            this.logoutBtn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogoutBtn_LinkClicked);
            // 
            // exitBtn
            // 
            this.exitBtn.CheckedState.Parent = this.exitBtn;
            this.exitBtn.CustomImages.Parent = this.exitBtn;
            this.guna2Transition1.SetDecoration(this.exitBtn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.exitBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.exitBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.exitBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.exitBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.exitBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.exitBtn.DisabledState.Parent = this.exitBtn;
            this.exitBtn.FillColor = System.Drawing.Color.SaddleBrown;
            this.exitBtn.FillColor2 = System.Drawing.Color.SaddleBrown;
            this.exitBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.Color.White;
            this.exitBtn.HoverState.Parent = this.exitBtn;
            this.exitBtn.Location = new System.Drawing.Point(3, 0);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.exitBtn.ShadowDecoration.Parent = this.exitBtn;
            this.exitBtn.Size = new System.Drawing.Size(31, 33);
            this.exitBtn.TabIndex = 4;
            this.exitBtn.Text = "X";
            this.exitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // removeItemsBtn
            // 
            this.removeItemsBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.removeItemsBtn.BorderRadius = 15;
            this.removeItemsBtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.removeItemsBtn.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.removeItemsBtn.CheckedState.Parent = this.removeItemsBtn;
            this.removeItemsBtn.CustomImages.Parent = this.removeItemsBtn;
            this.guna2Transition1.SetDecoration(this.removeItemsBtn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.removeItemsBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.removeItemsBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.removeItemsBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.removeItemsBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.removeItemsBtn.DisabledState.Parent = this.removeItemsBtn;
            this.removeItemsBtn.FillColor = System.Drawing.Color.SeaGreen;
            this.removeItemsBtn.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeItemsBtn.ForeColor = System.Drawing.Color.White;
            this.removeItemsBtn.HoverState.Parent = this.removeItemsBtn;
            this.removeItemsBtn.Location = new System.Drawing.Point(20, 249);
            this.removeItemsBtn.Name = "removeItemsBtn";
            this.removeItemsBtn.ShadowDecoration.Parent = this.removeItemsBtn;
            this.removeItemsBtn.Size = new System.Drawing.Size(202, 41);
            this.removeItemsBtn.TabIndex = 3;
            this.removeItemsBtn.Text = "Remove Items";
            this.removeItemsBtn.Click += new System.EventHandler(this.RemoveItemsBtn_Click);
            // 
            // updateItemsBtn
            // 
            this.updateItemsBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.updateItemsBtn.BorderRadius = 15;
            this.updateItemsBtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.updateItemsBtn.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.updateItemsBtn.CheckedState.Parent = this.updateItemsBtn;
            this.updateItemsBtn.CustomImages.Parent = this.updateItemsBtn;
            this.guna2Transition1.SetDecoration(this.updateItemsBtn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.updateItemsBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.updateItemsBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.updateItemsBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.updateItemsBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.updateItemsBtn.DisabledState.Parent = this.updateItemsBtn;
            this.updateItemsBtn.FillColor = System.Drawing.Color.SeaGreen;
            this.updateItemsBtn.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateItemsBtn.ForeColor = System.Drawing.Color.White;
            this.updateItemsBtn.HoverState.Parent = this.updateItemsBtn;
            this.updateItemsBtn.Location = new System.Drawing.Point(20, 182);
            this.updateItemsBtn.Name = "updateItemsBtn";
            this.updateItemsBtn.ShadowDecoration.Parent = this.updateItemsBtn;
            this.updateItemsBtn.Size = new System.Drawing.Size(202, 41);
            this.updateItemsBtn.TabIndex = 2;
            this.updateItemsBtn.Text = "Update Items";
            this.updateItemsBtn.Click += new System.EventHandler(this.UpdateItemsBtn_Click);
            // 
            // addItmesBtn
            // 
            this.addItmesBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.addItmesBtn.BorderRadius = 15;
            this.addItmesBtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.addItmesBtn.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.addItmesBtn.CheckedState.Parent = this.addItmesBtn;
            this.addItmesBtn.CustomImages.Parent = this.addItmesBtn;
            this.guna2Transition1.SetDecoration(this.addItmesBtn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.addItmesBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addItmesBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addItmesBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addItmesBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addItmesBtn.DisabledState.Parent = this.addItmesBtn;
            this.addItmesBtn.FillColor = System.Drawing.Color.SeaGreen;
            this.addItmesBtn.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItmesBtn.ForeColor = System.Drawing.Color.White;
            this.addItmesBtn.HoverState.Parent = this.addItmesBtn;
            this.addItmesBtn.Location = new System.Drawing.Point(20, 116);
            this.addItmesBtn.Name = "addItmesBtn";
            this.addItmesBtn.ShadowDecoration.Parent = this.addItmesBtn;
            this.addItmesBtn.Size = new System.Drawing.Size(202, 41);
            this.addItmesBtn.TabIndex = 1;
            this.addItmesBtn.Text = "Add Items";
            this.addItmesBtn.Click += new System.EventHandler(this.AddItmesBtn_Click);
            // 
            // placeOrderBtn
            // 
            this.placeOrderBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.placeOrderBtn.BorderRadius = 15;
            this.placeOrderBtn.CheckedState.FillColor = System.Drawing.Color.White;
            this.placeOrderBtn.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.placeOrderBtn.CheckedState.Parent = this.placeOrderBtn;
            this.placeOrderBtn.CustomImages.Parent = this.placeOrderBtn;
            this.guna2Transition1.SetDecoration(this.placeOrderBtn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.placeOrderBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.placeOrderBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.placeOrderBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.placeOrderBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.placeOrderBtn.DisabledState.Parent = this.placeOrderBtn;
            this.placeOrderBtn.FillColor = System.Drawing.Color.SeaGreen;
            this.placeOrderBtn.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeOrderBtn.ForeColor = System.Drawing.Color.White;
            this.placeOrderBtn.HoverState.Parent = this.placeOrderBtn;
            this.placeOrderBtn.Location = new System.Drawing.Point(20, 49);
            this.placeOrderBtn.Name = "placeOrderBtn";
            this.placeOrderBtn.ShadowDecoration.Parent = this.placeOrderBtn;
            this.placeOrderBtn.Size = new System.Drawing.Size(202, 41);
            this.placeOrderBtn.TabIndex = 0;
            this.placeOrderBtn.Text = "Place Order";
            this.placeOrderBtn.Click += new System.EventHandler(this.PlaceOrderBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.uC_RemoveItems1);
            this.panel2.Controls.Add(this.uC_UpdateItem1);
            this.panel2.Controls.Add(this.uC_PlaceOrder1);
            this.panel2.Controls.Add(this.uC_AddItems1);
            this.panel2.Controls.Add(this.uC_Welcome1);
            this.guna2Transition1.SetDecoration(this.panel2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel2.Location = new System.Drawing.Point(211, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(781, 514);
            this.panel2.TabIndex = 1;
            // 
            // uC_RemoveItems1
            // 
            this.uC_RemoveItems1.BackColor = System.Drawing.Color.White;
            this.guna2Transition1.SetDecoration(this.uC_RemoveItems1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.uC_RemoveItems1.Location = new System.Drawing.Point(-3, -3);
            this.uC_RemoveItems1.Name = "uC_RemoveItems1";
            this.uC_RemoveItems1.Size = new System.Drawing.Size(781, 514);
            this.uC_RemoveItems1.TabIndex = 4;
            this.uC_RemoveItems1.Load += new System.EventHandler(this.UC_RemoveItems1_Load);
            // 
            // uC_UpdateItem1
            // 
            this.uC_UpdateItem1.BackColor = System.Drawing.Color.White;
            this.guna2Transition1.SetDecoration(this.uC_UpdateItem1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.uC_UpdateItem1.Location = new System.Drawing.Point(0, 0);
            this.uC_UpdateItem1.Name = "uC_UpdateItem1";
            this.uC_UpdateItem1.Size = new System.Drawing.Size(781, 514);
            this.uC_UpdateItem1.TabIndex = 3;
            // 
            // uC_PlaceOrder1
            // 
            this.uC_PlaceOrder1.BackColor = System.Drawing.Color.White;
            this.guna2Transition1.SetDecoration(this.uC_PlaceOrder1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.uC_PlaceOrder1.Location = new System.Drawing.Point(-3, 0);
            this.uC_PlaceOrder1.Name = "uC_PlaceOrder1";
            this.uC_PlaceOrder1.Size = new System.Drawing.Size(781, 514);
            this.uC_PlaceOrder1.TabIndex = 2;
            // 
            // uC_AddItems1
            // 
            this.uC_AddItems1.BackColor = System.Drawing.Color.White;
            this.guna2Transition1.SetDecoration(this.uC_AddItems1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.uC_AddItems1.Location = new System.Drawing.Point(0, -3);
            this.uC_AddItems1.Name = "uC_AddItems1";
            this.uC_AddItems1.Size = new System.Drawing.Size(781, 514);
            this.uC_AddItems1.TabIndex = 1;
            // 
            // uC_Welcome1
            // 
            this.uC_Welcome1.BackColor = System.Drawing.Color.White;
            this.guna2Transition1.SetDecoration(this.uC_Welcome1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.uC_Welcome1.Location = new System.Drawing.Point(-3, 3);
            this.uC_Welcome1.Name = "uC_Welcome1";
            this.uC_Welcome1.Size = new System.Drawing.Size(781, 514);
            this.uC_Welcome1.TabIndex = 0;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 30;
            this.guna2Elipse2.TargetControl = this.panel2;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 30;
            this.guna2Elipse3.TargetControl = this.panel2;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.BorderRadius = 30;
            this.guna2Elipse4.TargetControl = this.panel2;
            // 
            // guna2Elipse5
            // 
            this.guna2Elipse5.BorderRadius = 30;
            this.guna2Elipse5.TargetControl = this.panel2;
            // 
            // guna2Transition1
            // 
            this.guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizSlide;
            this.guna2Transition1.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.guna2Transition1.DefaultAnimation = animation2;
            // 
            // guna2Elipse6
            // 
            this.guna2Elipse6.BorderRadius = 30;
            this.guna2Elipse6.TargetControl = this.panel2;
            // 
            // guna2Elipse7
            // 
            this.guna2Elipse7.BorderRadius = 30;
            this.guna2Elipse7.TargetControl = this.panel1;
            // 
            // pictureBox1
            // 
            this.guna2Transition1.SetDecoration(this.pictureBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(58, 330);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1004, 538);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button placeOrderBtn;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2GradientCircleButton exitBtn;
        private Guna.UI2.WinForms.Guna2Button removeItemsBtn;
        private Guna.UI2.WinForms.Guna2Button updateItemsBtn;
        private Guna.UI2.WinForms.Guna2Button addItmesBtn;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private System.Windows.Forms.LinkLabel logoutBtn;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private allUserControls.UC_Welcome uC_Welcome1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private allUserControls.UC_AddItems uC_AddItems1;
        private UC_PlaceOrder uC_PlaceOrder1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse6;
        private allUserControls.UC_UpdateItem uC_UpdateItem1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse7;
        private allUserControls.UC_RemoveItems uC_RemoveItems1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}