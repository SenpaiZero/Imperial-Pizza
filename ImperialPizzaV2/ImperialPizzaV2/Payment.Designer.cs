
namespace ImperialPizzaV2
{
    partial class Payment
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
            this.Pay = new ReaLTaiizor.Forms.NightForm();
            this.backBtn = new ReaLTaiizor.Controls.LostButton();
            this.CheckOut = new ReaLTaiizor.Controls.LostButton();
            this.materialCheckBox1 = new ReaLTaiizor.Controls.MaterialCheckBox();
            this.nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            this.Address = new System.Windows.Forms.TextBox();
            this.PhoneNumber = new ReaLTaiizor.Controls.MaterialTextBox();
            this.EmailAddress = new ReaLTaiizor.Controls.MaterialTextBox();
            this.Name = new ReaLTaiizor.Controls.MaterialTextBox();
            this.Date = new ReaLTaiizor.Controls.MaterialTextBox();
            this.CardNumber = new ReaLTaiizor.Controls.MaterialTextBox();
            this.CVV = new ReaLTaiizor.Controls.MaterialTextBox();
            this.lostPanel1 = new ReaLTaiizor.Controls.LostPanel();
            this.nightTextBox1 = new ReaLTaiizor.Controls.NightTextBox();
            this.Pay.SuspendLayout();
            this.lostPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pay
            // 
            this.Pay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(48)))), ((int)(((byte)(51)))));
            this.Pay.Controls.Add(this.backBtn);
            this.Pay.Controls.Add(this.CheckOut);
            this.Pay.Controls.Add(this.materialCheckBox1);
            this.Pay.Controls.Add(this.nightControlBox1);
            this.Pay.Controls.Add(this.Address);
            this.Pay.Controls.Add(this.PhoneNumber);
            this.Pay.Controls.Add(this.EmailAddress);
            this.Pay.Controls.Add(this.Name);
            this.Pay.Controls.Add(this.Date);
            this.Pay.Controls.Add(this.CardNumber);
            this.Pay.Controls.Add(this.CVV);
            this.Pay.Controls.Add(this.lostPanel1);
            this.Pay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pay.DrawIcon = false;
            this.Pay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Pay.HeadColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(61)))));
            this.Pay.Location = new System.Drawing.Point(0, 0);
            this.Pay.MinimumSize = new System.Drawing.Size(100, 42);
            this.Pay.Name = "Pay";
            this.Pay.Padding = new System.Windows.Forms.Padding(0, 31, 0, 0);
            this.Pay.Size = new System.Drawing.Size(836, 444);
            this.Pay.TabIndex = 0;
            this.Pay.Text = "PAYMENT";
            this.Pay.TextAlignment = ReaLTaiizor.Forms.NightForm.Alignment.Center;
            this.Pay.TitleBarTextColor = System.Drawing.Color.Gainsboro;
            this.Pay.Click += new System.EventHandler(this.Pay_Click);
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.backBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.backBtn.ForeColor = System.Drawing.Color.White;
            this.backBtn.HoverColor = System.Drawing.SystemColors.ControlDarkDark;
            this.backBtn.Image = null;
            this.backBtn.Location = new System.Drawing.Point(418, 364);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(147, 53);
            this.backBtn.TabIndex = 15;
            this.backBtn.Text = "GO BACK";
            this.backBtn.Click += new System.EventHandler(this.lostButton1_Click);
            // 
            // CheckOut
            // 
            this.CheckOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.CheckOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckOut.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CheckOut.ForeColor = System.Drawing.Color.White;
            this.CheckOut.HoverColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CheckOut.Image = null;
            this.CheckOut.Location = new System.Drawing.Point(231, 364);
            this.CheckOut.Name = "CheckOut";
            this.CheckOut.Size = new System.Drawing.Size(147, 53);
            this.CheckOut.TabIndex = 14;
            this.CheckOut.Text = "ORDER NOW";
            this.CheckOut.Click += new System.EventHandler(this.CheckOut_Click);
            // 
            // materialCheckBox1
            // 
            this.materialCheckBox1.AutoSize = true;
            this.materialCheckBox1.Depth = 0;
            this.materialCheckBox1.Location = new System.Drawing.Point(22, 364);
            this.materialCheckBox1.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBox1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialCheckBox1.Name = "materialCheckBox1";
            this.materialCheckBox1.Ripple = true;
            this.materialCheckBox1.Size = new System.Drawing.Size(153, 37);
            this.materialCheckBox1.TabIndex = 13;
            this.materialCheckBox1.Text = "Cash on Delivery";
            this.materialCheckBox1.UseVisualStyleBackColor = true;
            // 
            // nightControlBox1
            // 
            this.nightControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nightControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.nightControlBox1.CloseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.nightControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nightControlBox1.DefaultLocation = true;
            this.nightControlBox1.DisableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.nightControlBox1.DisableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.nightControlBox1.EnableCloseColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.EnableMaximizeButton = true;
            this.nightControlBox1.EnableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.EnableMinimizeButton = true;
            this.nightControlBox1.EnableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.Location = new System.Drawing.Point(697, 0);
            this.nightControlBox1.MaximizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MaximizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.MinimizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MinimizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.Name = "nightControlBox1";
            this.nightControlBox1.Size = new System.Drawing.Size(139, 31);
            this.nightControlBox1.TabIndex = 12;
            this.nightControlBox1.Click += new System.EventHandler(this.nightControlBox1_Click);
            // 
            // Address
            // 
            this.Address.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(46)))), ((int)(((byte)(49)))));
            this.Address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Address.ForeColor = System.Drawing.Color.Gray;
            this.Address.Location = new System.Drawing.Point(533, 64);
            this.Address.Multiline = true;
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(303, 205);
            this.Address.TabIndex = 11;
            this.Address.Text = "FULL ADDRESS";
            this.Address.MouseClick += new System.Windows.Forms.MouseEventHandler(this.multi_MouseClick);
            this.Address.TextChanged += new System.EventHandler(this.multi_TextChanged);
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PhoneNumber.Depth = 0;
            this.PhoneNumber.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.PhoneNumber.ForeColor = System.Drawing.Color.Gray;
            this.PhoneNumber.Hint = "Phone Number";
            this.PhoneNumber.Location = new System.Drawing.Point(22, 221);
            this.PhoneNumber.MaxLength = 50;
            this.PhoneNumber.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.PhoneNumber.Multiline = false;
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(456, 50);
            this.PhoneNumber.TabIndex = 9;
            this.PhoneNumber.Text = "";
            // 
            // EmailAddress
            // 
            this.EmailAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmailAddress.Depth = 0;
            this.EmailAddress.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.EmailAddress.ForeColor = System.Drawing.Color.Gray;
            this.EmailAddress.Hint = "Email Address";
            this.EmailAddress.Location = new System.Drawing.Point(22, 143);
            this.EmailAddress.MaxLength = 50;
            this.EmailAddress.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.EmailAddress.Multiline = false;
            this.EmailAddress.Name = "EmailAddress";
            this.EmailAddress.Size = new System.Drawing.Size(456, 50);
            this.EmailAddress.TabIndex = 8;
            this.EmailAddress.Text = "";
            // 
            // Name
            // 
            this.Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Name.Depth = 0;
            this.Name.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Name.ForeColor = System.Drawing.Color.Gray;
            this.Name.Hint = "Name";
            this.Name.Location = new System.Drawing.Point(22, 64);
            this.Name.MaxLength = 50;
            this.Name.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.Name.Multiline = false;
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(456, 50);
            this.Name.TabIndex = 7;
            this.Name.Text = "";
            // 
            // Date
            // 
            this.Date.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Date.Depth = 0;
            this.Date.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Date.ForeColor = System.Drawing.Color.Gray;
            this.Date.Hint = "DD/YY";
            this.Date.Location = new System.Drawing.Point(378, 297);
            this.Date.MaxLength = 50;
            this.Date.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.Date.Multiline = false;
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(100, 50);
            this.Date.TabIndex = 6;
            this.Date.Text = "";
            // 
            // CardNumber
            // 
            this.CardNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CardNumber.Depth = 0;
            this.CardNumber.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.CardNumber.ForeColor = System.Drawing.Color.Gray;
            this.CardNumber.Hint = "Card Number";
            this.CardNumber.Location = new System.Drawing.Point(22, 297);
            this.CardNumber.MaxLength = 50;
            this.CardNumber.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.CardNumber.Multiline = false;
            this.CardNumber.Name = "CardNumber";
            this.CardNumber.Size = new System.Drawing.Size(341, 50);
            this.CardNumber.TabIndex = 5;
            this.CardNumber.Text = "";
            // 
            // CVV
            // 
            this.CVV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CVV.Depth = 0;
            this.CVV.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.CVV.ForeColor = System.Drawing.Color.Gray;
            this.CVV.Hint = "CVV";
            this.CVV.Location = new System.Drawing.Point(499, 297);
            this.CVV.MaxLength = 50;
            this.CVV.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.CVV.Multiline = false;
            this.CVV.Name = "CVV";
            this.CVV.Size = new System.Drawing.Size(100, 50);
            this.CVV.TabIndex = 4;
            this.CVV.Text = "";
            // 
            // lostPanel1
            // 
            this.lostPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.lostPanel1.Controls.Add(this.nightTextBox1);
            this.lostPanel1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lostPanel1.ForeColor = System.Drawing.Color.White;
            this.lostPanel1.Location = new System.Drawing.Point(614, 280);
            this.lostPanel1.Name = "lostPanel1";
            this.lostPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.lostPanel1.ShowText = true;
            this.lostPanel1.Size = new System.Drawing.Size(222, 111);
            this.lostPanel1.TabIndex = 3;
            this.lostPanel1.Text = "TOTAL PRICE";
            // 
            // nightTextBox1
            // 
            this.nightTextBox1.ActiveBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(93)))), ((int)(((byte)(89)))));
            this.nightTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(67)))));
            this.nightTextBox1.BaseBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(67)))));
            this.nightTextBox1.ColorBordersOnEnter = true;
            this.nightTextBox1.DisableBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(80)))));
            this.nightTextBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.nightTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(131)))), ((int)(((byte)(140)))));
            this.nightTextBox1.Image = null;
            this.nightTextBox1.Location = new System.Drawing.Point(40, 33);
            this.nightTextBox1.MaxLength = 32767;
            this.nightTextBox1.Multiline = false;
            this.nightTextBox1.Name = "nightTextBox1";
            this.nightTextBox1.ReadOnly = true;
            this.nightTextBox1.ShortcutsEnabled = true;
            this.nightTextBox1.ShowBottomBorder = true;
            this.nightTextBox1.ShowTopBorder = true;
            this.nightTextBox1.Size = new System.Drawing.Size(145, 50);
            this.nightTextBox1.TabIndex = 1;
            this.nightTextBox1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.nightTextBox1.UseSystemPasswordChar = false;
            this.nightTextBox1.Watermark = "";
            this.nightTextBox1.WatermarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(120)))), ((int)(((byte)(129)))));
            this.nightTextBox1.TextChanged += new System.EventHandler(this.nightTextBox1_TextChanged);
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 444);
            this.Controls.Add(this.Pay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1440, 860);
            this.nightTextBox1.Name = "Pay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.Payment_Load);
            this.Pay.ResumeLayout(false);
            this.Pay.PerformLayout();
            this.lostPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Forms.NightForm Pay;
        private ReaLTaiizor.Controls.NightTextBox nightTextBox1;
        private ReaLTaiizor.Controls.MaterialTextBox PhoneNumber;
        private ReaLTaiizor.Controls.MaterialTextBox EmailAddress;
        private ReaLTaiizor.Controls.MaterialTextBox Name;
        private ReaLTaiizor.Controls.MaterialTextBox Date;
        private ReaLTaiizor.Controls.MaterialTextBox CardNumber;
        private ReaLTaiizor.Controls.MaterialTextBox CVV;
        private ReaLTaiizor.Controls.LostPanel lostPanel1;
        private System.Windows.Forms.TextBox Address;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private ReaLTaiizor.Controls.LostButton CheckOut;
        private ReaLTaiizor.Controls.MaterialCheckBox materialCheckBox1;
        private ReaLTaiizor.Controls.LostButton backBtn;
    }
}