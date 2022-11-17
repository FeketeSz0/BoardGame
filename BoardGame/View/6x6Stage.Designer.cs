namespace Zh
{
    partial class Form3
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.WinnerLabel = new System.Windows.Forms.Label();
            this.whoseturnLabel = new System.Windows.Forms.Label();
            this.turnLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GameSizeMenu = new System.Windows.Forms.ComboBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(730, 629);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.WinnerLabel);
            this.panel2.Controls.Add(this.whoseturnLabel);
            this.panel2.Controls.Add(this.turnLabel);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(748, 140);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(272, 344);
            this.panel2.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MidnightBlue;
            this.button1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(33, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 64);
            this.button1.TabIndex = 7;
            this.button1.Text = "Pass";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // WinnerLabel
            // 
            this.WinnerLabel.AutoSize = true;
            this.WinnerLabel.Font = new System.Drawing.Font("Roboto Black", 20F);
            this.WinnerLabel.Location = new System.Drawing.Point(22, 229);
            this.WinnerLabel.Name = "WinnerLabel";
            this.WinnerLabel.Size = new System.Drawing.Size(0, 65);
            this.WinnerLabel.TabIndex = 5;
            // 
            // whoseturnLabel
            // 
            this.whoseturnLabel.AutoSize = true;
            this.whoseturnLabel.Font = new System.Drawing.Font("Roboto Medium", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.whoseturnLabel.Location = new System.Drawing.Point(3, 24);
            this.whoseturnLabel.Name = "whoseturnLabel";
            this.whoseturnLabel.Size = new System.Drawing.Size(273, 44);
            this.whoseturnLabel.TabIndex = 6;
            this.whoseturnLabel.Text = "Player1 starts \r\n";
            // 
            // turnLabel
            // 
            this.turnLabel.AutoSize = true;
            this.turnLabel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.turnLabel.Location = new System.Drawing.Point(105, 68);
            this.turnLabel.Name = "turnLabel";
            this.turnLabel.Size = new System.Drawing.Size(35, 38);
            this.turnLabel.TabIndex = 5;
            this.turnLabel.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(4, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "Turns:";
            // 
            // GameSizeMenu
            // 
            this.GameSizeMenu.FormattingEnabled = true;
            this.GameSizeMenu.Items.AddRange(new object[] {
            "4x4",
            "6x6",
            "8x8"});
            this.GameSizeMenu.Location = new System.Drawing.Point(12, 12);
            this.GameSizeMenu.Name = "GameSizeMenu";
            this.GameSizeMenu.Size = new System.Drawing.Size(146, 33);
            this.GameSizeMenu.TabIndex = 5;
            this.GameSizeMenu.Text = "GameSize";
            this.GameSizeMenu.SelectedIndexChanged += new System.EventHandler(this.GameSizeMenu_SelectedIndexChanged);
            // 
            // Stage
            // 
            this.ClientSize = new System.Drawing.Size(1012, 967);
            this.Controls.Add(this.GameSizeMenu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Stage";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button playerone1;
        private System.Windows.Forms.Button playerone4;
        private System.Windows.Forms.Button playerone2;
        private System.Windows.Forms.Button playerone3;
        private System.Windows.Forms.Button playertwo4;
        private System.Windows.Forms.Button playertwo3;
        private System.Windows.Forms.Button playertwo2;
        private System.Windows.Forms.Button playertwo1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label whoseturnLabel;
        private System.Windows.Forms.Label turnLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label WinnerLabel;
        private System.Windows.Forms.ComboBox GameSizeMenu;
    }
}

