
namespace POS
{
    partial class frm_main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.login_as_menu_item = new System.Windows.Forms.ToolStripMenuItem();
            this.setting_menu_item = new System.Windows.Forms.ToolStripMenuItem();
            this.sale_menu_item = new System.Windows.Forms.ToolStripMenuItem();
            this.inventory_menu_item = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.login_as_menu_item,
            this.inventory_menu_item,
            this.setting_menu_item,
            this.sale_menu_item});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // login_as_menu_item
            // 
            this.login_as_menu_item.Name = "login_as_menu_item";
            this.login_as_menu_item.Size = new System.Drawing.Size(65, 20);
            this.login_as_menu_item.Text = "Login As";
            // 
            // setting_menu_item
            // 
            this.setting_menu_item.Name = "setting_menu_item";
            this.setting_menu_item.Size = new System.Drawing.Size(56, 20);
            this.setting_menu_item.Text = "Setting";
            this.setting_menu_item.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // sale_menu_item
            // 
            this.sale_menu_item.Name = "sale_menu_item";
            this.sale_menu_item.Size = new System.Drawing.Size(40, 20);
            this.sale_menu_item.Text = "Sale";
            // 
            // inventory_menu_item
            // 
            this.inventory_menu_item.Name = "inventory_menu_item";
            this.inventory_menu_item.Size = new System.Drawing.Size(69, 20);
            this.inventory_menu_item.Text = "Inventory";
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_main";
            this.Text = "frm_main";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem login_as_menu_item;
        private System.Windows.Forms.ToolStripMenuItem setting_menu_item;
        private System.Windows.Forms.ToolStripMenuItem sale_menu_item;
        private System.Windows.Forms.ToolStripMenuItem inventory_menu_item;
    }
}