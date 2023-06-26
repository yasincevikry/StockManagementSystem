
namespace StockManagementSystem
{
    partial class FirstPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstPage));
            this.lblName = new Bunifu.UI.WinForms.BunifuLabel();
            this.circle = new Bunifu.UI.WinForms.BunifuCircleProgress();
            this.lblYüzde = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AllowParentOverrides = false;
            this.lblName.AutoEllipsis = false;
            this.lblName.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblName.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblName.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblName.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblName.Location = new System.Drawing.Point(181, 74);
            this.lblName.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.lblName.Name = "lblName";
            this.lblName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblName.Size = new System.Drawing.Size(310, 29);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Stock Management System";
            this.lblName.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblName.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // circle
            // 
            this.circle.Animated = false;
            this.circle.AnimationInterval = 1;
            this.circle.AnimationSpeed = 1;
            this.circle.BackColor = System.Drawing.Color.Transparent;
            this.circle.CircleMargin = 10;
            this.circle.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold);
            this.circle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circle.IsPercentage = false;
            this.circle.LineProgressThickness = 10;
            this.circle.LineThickness = 10;
            this.circle.Location = new System.Drawing.Point(235, 131);
            this.circle.Name = "circle";
            this.circle.ProgressAnimationSpeed = 200;
            this.circle.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.circle.ProgressColor = System.Drawing.Color.DodgerBlue;
            this.circle.ProgressColor2 = System.Drawing.Color.DodgerBlue;
            this.circle.ProgressEndCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round;
            this.circle.ProgressFillStyle = Bunifu.UI.WinForms.BunifuCircleProgress.FillStyles.Solid;
            this.circle.ProgressStartCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round;
            this.circle.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.circle.Size = new System.Drawing.Size(184, 184);
            this.circle.SubScriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circle.SubScriptMargin = new System.Windows.Forms.Padding(5, -20, 0, 0);
            this.circle.SubScriptText = "";
            this.circle.SuperScriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circle.SuperScriptMargin = new System.Windows.Forms.Padding(0);
            this.circle.SuperScriptText = "";
            this.circle.TabIndex = 16;
            this.circle.Text = "30";
            this.circle.TextMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.circle.Value = 30;
            this.circle.ValueByTransition = 30;
            this.circle.ValueMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            // 
            // lblYüzde
            // 
            this.lblYüzde.AutoSize = true;
            this.lblYüzde.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYüzde.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblYüzde.Location = new System.Drawing.Point(309, 335);
            this.lblYüzde.Name = "lblYüzde";
            this.lblYüzde.Size = new System.Drawing.Size(40, 34);
            this.lblYüzde.TabIndex = 17;
            this.lblYüzde.Text = "%";
            // 
            // FirstPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(707, 430);
            this.Controls.Add(this.lblYüzde);
            this.Controls.Add(this.circle);
            this.Controls.Add(this.lblName);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FirstPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuLabel lblName;
        private Bunifu.UI.WinForms.BunifuCircleProgress circle;
        private System.Windows.Forms.Label lblYüzde;
    }
}

