namespace Menus
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menu_geral = new System.Windows.Forms.MenuStrip();
            this.mmu_file = new System.Windows.Forms.ToolStripMenuItem();
            this.mmu_new = new System.Windows.Forms.ToolStripMenuItem();
            this.mmu_open = new System.Windows.Forms.ToolStripMenuItem();
            this.mmu_new_project = new System.Windows.Forms.ToolStripMenuItem();
            this.mmu_new_file = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mmu_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propetiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mmu_combo_1 = new System.Windows.Forms.ToolStripComboBox();
            this.label_resultado = new System.Windows.Forms.Label();
            this.menu_geral.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu_geral
            // 
            this.menu_geral.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mmu_file,
            this.editToolStripMenuItem,
            this.mmu_combo_1});
            this.menu_geral.Location = new System.Drawing.Point(0, 0);
            this.menu_geral.Name = "menu_geral";
            this.menu_geral.Size = new System.Drawing.Size(429, 27);
            this.menu_geral.TabIndex = 0;
            this.menu_geral.Text = "menuStrip1";
            // 
            // mmu_file
            // 
            this.mmu_file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mmu_new,
            this.mmu_open,
            this.toolStripSeparator1,
            this.mmu_exit});
            this.mmu_file.Name = "mmu_file";
            this.mmu_file.Size = new System.Drawing.Size(37, 23);
            this.mmu_file.Text = "File";
            // 
            // mmu_new
            // 
            this.mmu_new.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mmu_new_project,
            this.mmu_new_file});
            this.mmu_new.Name = "mmu_new";
            this.mmu_new.Size = new System.Drawing.Size(180, 22);
            this.mmu_new.Text = "New";
            // 
            // mmu_open
            // 
            this.mmu_open.Name = "mmu_open";
            this.mmu_open.Size = new System.Drawing.Size(180, 22);
            this.mmu_open.Text = "Open";
            this.mmu_open.Click += new System.EventHandler(this.mmu_open_Click);
            // 
            // mmu_new_project
            // 
            this.mmu_new_project.Name = "mmu_new_project";
            this.mmu_new_project.Size = new System.Drawing.Size(180, 22);
            this.mmu_new_project.Text = "Project";
            // 
            // mmu_new_file
            // 
            this.mmu_new_file.Name = "mmu_new_file";
            this.mmu_new_file.Size = new System.Drawing.Size(180, 22);
            this.mmu_new_file.Text = "File";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // mmu_exit
            // 
            this.mmu_exit.Name = "mmu_exit";
            this.mmu_exit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mmu_exit.Size = new System.Drawing.Size(180, 22);
            this.mmu_exit.Text = "Exit";
            this.mmu_exit.Click += new System.EventHandler(this.mmu_exit_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(173, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.propetiesToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 23);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            // 
            // propetiesToolStripMenuItem
            // 
            this.propetiesToolStripMenuItem.Name = "propetiesToolStripMenuItem";
            this.propetiesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.propetiesToolStripMenuItem.Text = "Propeties";
            this.propetiesToolStripMenuItem.Click += new System.EventHandler(this.propetiesToolStripMenuItem_Click);
            // 
            // mmu_combo_1
            // 
            this.mmu_combo_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mmu_combo_1.Name = "mmu_combo_1";
            this.mmu_combo_1.Size = new System.Drawing.Size(121, 23);
            this.mmu_combo_1.SelectedIndexChanged += new System.EventHandler(this.mmu_combo_1_SelectedIndexChanged);
            this.mmu_combo_1.Click += new System.EventHandler(this.mmu_combo_1_Click);
            // 
            // label_resultado
            // 
            this.label_resultado.AutoSize = true;
            this.label_resultado.Location = new System.Drawing.Point(208, 71);
            this.label_resultado.Name = "label_resultado";
            this.label_resultado.Size = new System.Drawing.Size(35, 13);
            this.label_resultado.TabIndex = 2;
            this.label_resultado.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 231);
            this.Controls.Add(this.label_resultado);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menu_geral);
            this.MainMenuStrip = this.menu_geral;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menu_geral.ResumeLayout(false);
            this.menu_geral.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu_geral;
        private System.Windows.Forms.ToolStripMenuItem mmu_file;
        private System.Windows.Forms.ToolStripMenuItem mmu_new;
        private System.Windows.Forms.ToolStripMenuItem mmu_open;
        private System.Windows.Forms.ToolStripMenuItem mmu_new_project;
        private System.Windows.Forms.ToolStripMenuItem mmu_new_file;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mmu_exit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propetiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox mmu_combo_1;
        private System.Windows.Forms.Label label_resultado;
    }
}

