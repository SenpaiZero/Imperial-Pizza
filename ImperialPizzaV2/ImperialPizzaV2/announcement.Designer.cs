
namespace ImperialPizzaV2
{
    partial class announcement
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
            this.DRINK = new ReaLTaiizor.Forms.NightForm();
            this.bigLabel2 = new ReaLTaiizor.Controls.BigLabel();
            this.lostButton1 = new ReaLTaiizor.Controls.LostButton();
            this.DRINK.SuspendLayout();
            this.SuspendLayout();
            // 
            // DRINK
            // 
            this.DRINK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(48)))), ((int)(((byte)(51)))));
            this.DRINK.Controls.Add(this.lostButton1);
            this.DRINK.Controls.Add(this.bigLabel2);
            this.DRINK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DRINK.DrawIcon = false;
            this.DRINK.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DRINK.HeadColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(61)))));
            this.DRINK.Location = new System.Drawing.Point(0, 0);
            this.DRINK.MinimumSize = new System.Drawing.Size(100, 42);
            this.DRINK.Name = "DRINK";
            this.DRINK.Padding = new System.Windows.Forms.Padding(0, 31, 0, 0);
            this.DRINK.Size = new System.Drawing.Size(500, 300);
            this.DRINK.TabIndex = 1;
            this.DRINK.TextAlignment = ReaLTaiizor.Forms.NightForm.Alignment.Center;
            this.DRINK.TitleBarTextColor = System.Drawing.Color.Gainsboro;
            // 
            // bigLabel2
            // 
            this.bigLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel2.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.bigLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bigLabel2.Location = new System.Drawing.Point(3, 50);
            this.bigLabel2.Name = "bigLabel2";
            this.bigLabel2.Size = new System.Drawing.Size(485, 193);
            this.bigLabel2.TabIndex = 16;
            this.bigLabel2.Text = "Sorry po sir kung makalat yung codes. Isang araw ko\r\nlang po nagawa kinapos po ng" +
    " oras. Naubos po sa\r\nils ng android tsaka ibang subject po";
            this.bigLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lostButton1
            // 
            this.lostButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.lostButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lostButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lostButton1.ForeColor = System.Drawing.Color.White;
            this.lostButton1.HoverColor = System.Drawing.Color.DodgerBlue;
            this.lostButton1.Image = null;
            this.lostButton1.Location = new System.Drawing.Point(178, 224);
            this.lostButton1.Name = "lostButton1";
            this.lostButton1.Size = new System.Drawing.Size(120, 40);
            this.lostButton1.TabIndex = 17;
            this.lostButton1.Text = "CONTINUE";
            this.lostButton1.Click += new System.EventHandler(this.lostButton1_Click);
            // 
            // announcement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 300);
            this.Controls.Add(this.DRINK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1440, 860);
            this.Name = "announcement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "announcement";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.announcement_Load);
            this.DRINK.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Forms.NightForm DRINK;
        private ReaLTaiizor.Controls.BigLabel bigLabel2;
        private ReaLTaiizor.Controls.LostButton lostButton1;
    }
}