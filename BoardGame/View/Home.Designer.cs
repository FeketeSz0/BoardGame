namespace Zh
{
    partial class Stage
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
            this.GameSizeMenu = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(170, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(470, 35);
            this.label2.TabIndex = 7;
            this.label2.Text = "Choose map size in the Combo Box";
            // 
            // Stage
            // 
            this.ClientSize = new System.Drawing.Size(1012, 188);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GameSizeMenu);
            this.Name = "Stage";
            this.Text = "BoardGame Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.ComboBox GameSizeMenu;
        private System.Windows.Forms.Label label2;
    }
}

