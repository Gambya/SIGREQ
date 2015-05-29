namespace SIGREQ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criarRequisitoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.salvarProjetoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sairESalvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarRequisitoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarRequisitoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciarRequisitosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileDialogProj = new System.Windows.Forms.OpenFileDialog();
            this.stackholderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarStackholderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciarStackholderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarTiposDeStackholderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciarTiposDeStackholderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cronogramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoCronogramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciarCronogramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileDialogProjSave = new System.Windows.Forms.OpenFileDialog();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.btnCadStackHolder = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.cadastroToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.criarRequisitoToolStripMenuItem,
            this.salvarProjetoToolStripMenuItem,
            this.toolStripSeparator1,
            this.sairESalvarToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // criarRequisitoToolStripMenuItem
            // 
            this.criarRequisitoToolStripMenuItem.Name = "criarRequisitoToolStripMenuItem";
            this.criarRequisitoToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.criarRequisitoToolStripMenuItem.Text = "Novo Projeto";
            this.criarRequisitoToolStripMenuItem.Click += new System.EventHandler(this.criarRequisitoToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.btnCadStackHolder,
            this.toolStripButton2,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(784, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // salvarProjetoToolStripMenuItem
            // 
            this.salvarProjetoToolStripMenuItem.Name = "salvarProjetoToolStripMenuItem";
            this.salvarProjetoToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.salvarProjetoToolStripMenuItem.Text = "Salvar Projeto";
            this.salvarProjetoToolStripMenuItem.Click += new System.EventHandler(this.salvarProjetoToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
            // 
            // sairESalvarToolStripMenuItem
            // 
            this.sairESalvarToolStripMenuItem.Name = "sairESalvarToolStripMenuItem";
            this.sairESalvarToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.sairESalvarToolStripMenuItem.Text = "Sair e Salvar";
            this.sairESalvarToolStripMenuItem.Click += new System.EventHandler(this.sairESalvarToolStripMenuItem_Click);
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarRequisitoToolStripMenuItem,
            this.stackholderToolStripMenuItem,
            this.cronogramaToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // cadastrarRequisitoToolStripMenuItem
            // 
            this.cadastrarRequisitoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarRequisitoToolStripMenuItem1,
            this.gerenciarRequisitosToolStripMenuItem});
            this.cadastrarRequisitoToolStripMenuItem.Name = "cadastrarRequisitoToolStripMenuItem";
            this.cadastrarRequisitoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cadastrarRequisitoToolStripMenuItem.Text = "Requisito";
            // 
            // cadastrarRequisitoToolStripMenuItem1
            // 
            this.cadastrarRequisitoToolStripMenuItem1.Name = "cadastrarRequisitoToolStripMenuItem1";
            this.cadastrarRequisitoToolStripMenuItem1.Size = new System.Drawing.Size(181, 22);
            this.cadastrarRequisitoToolStripMenuItem1.Text = "Cadastrar Requisito";
            this.cadastrarRequisitoToolStripMenuItem1.Click += new System.EventHandler(this.cadastrarRequisitoToolStripMenuItem1_Click);
            // 
            // gerenciarRequisitosToolStripMenuItem
            // 
            this.gerenciarRequisitosToolStripMenuItem.Name = "gerenciarRequisitosToolStripMenuItem";
            this.gerenciarRequisitosToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.gerenciarRequisitosToolStripMenuItem.Text = "Gerenciar Requisitos";
            this.gerenciarRequisitosToolStripMenuItem.Click += new System.EventHandler(this.gerenciarRequisitosToolStripMenuItem_Click);
            // 
            // FileDialogProj
            // 
            this.FileDialogProj.FileName = "Novo Projeto";
            // 
            // stackholderToolStripMenuItem
            // 
            this.stackholderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarStackholderToolStripMenuItem,
            this.gerenciarStackholderToolStripMenuItem,
            this.cadastrarTiposDeStackholderToolStripMenuItem,
            this.gerenciarTiposDeStackholderToolStripMenuItem});
            this.stackholderToolStripMenuItem.Name = "stackholderToolStripMenuItem";
            this.stackholderToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.stackholderToolStripMenuItem.Text = "Stackholder";
            // 
            // cadastrarStackholderToolStripMenuItem
            // 
            this.cadastrarStackholderToolStripMenuItem.Name = "cadastrarStackholderToolStripMenuItem";
            this.cadastrarStackholderToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.cadastrarStackholderToolStripMenuItem.Text = "Cadastrar Stackholder";
            this.cadastrarStackholderToolStripMenuItem.Click += new System.EventHandler(this.cadastrarStackholderToolStripMenuItem_Click);
            // 
            // gerenciarStackholderToolStripMenuItem
            // 
            this.gerenciarStackholderToolStripMenuItem.Name = "gerenciarStackholderToolStripMenuItem";
            this.gerenciarStackholderToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.gerenciarStackholderToolStripMenuItem.Text = "Gerenciar Stackholder";
            this.gerenciarStackholderToolStripMenuItem.Click += new System.EventHandler(this.gerenciarStackholderToolStripMenuItem_Click);
            // 
            // cadastrarTiposDeStackholderToolStripMenuItem
            // 
            this.cadastrarTiposDeStackholderToolStripMenuItem.Name = "cadastrarTiposDeStackholderToolStripMenuItem";
            this.cadastrarTiposDeStackholderToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.cadastrarTiposDeStackholderToolStripMenuItem.Text = "Cadastrar Tipos de Stackholder";
            this.cadastrarTiposDeStackholderToolStripMenuItem.Click += new System.EventHandler(this.cadastrarTiposDeStackholderToolStripMenuItem_Click);
            // 
            // gerenciarTiposDeStackholderToolStripMenuItem
            // 
            this.gerenciarTiposDeStackholderToolStripMenuItem.Name = "gerenciarTiposDeStackholderToolStripMenuItem";
            this.gerenciarTiposDeStackholderToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.gerenciarTiposDeStackholderToolStripMenuItem.Text = "Gerenciar Tipos de Stackholder";
            this.gerenciarTiposDeStackholderToolStripMenuItem.Click += new System.EventHandler(this.gerenciarTiposDeStackholderToolStripMenuItem_Click);
            // 
            // cronogramaToolStripMenuItem
            // 
            this.cronogramaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoCronogramaToolStripMenuItem,
            this.gerenciarCronogramaToolStripMenuItem});
            this.cronogramaToolStripMenuItem.Name = "cronogramaToolStripMenuItem";
            this.cronogramaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cronogramaToolStripMenuItem.Text = "Cronograma";
            // 
            // novoCronogramaToolStripMenuItem
            // 
            this.novoCronogramaToolStripMenuItem.Name = "novoCronogramaToolStripMenuItem";
            this.novoCronogramaToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.novoCronogramaToolStripMenuItem.Text = "Novo Cronograma";
            this.novoCronogramaToolStripMenuItem.Click += new System.EventHandler(this.novoCronogramaToolStripMenuItem_Click);
            // 
            // gerenciarCronogramaToolStripMenuItem
            // 
            this.gerenciarCronogramaToolStripMenuItem.Name = "gerenciarCronogramaToolStripMenuItem";
            this.gerenciarCronogramaToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.gerenciarCronogramaToolStripMenuItem.Text = "Gerenciar Cronograma";
            this.gerenciarCronogramaToolStripMenuItem.Click += new System.EventHandler(this.gerenciarCronogramaToolStripMenuItem_Click);
            // 
            // FileDialogProjSave
            // 
            this.FileDialogProjSave.FileName = "openFileDialog1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Gerenciar Requisitos";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // btnCadStackHolder
            // 
            this.btnCadStackHolder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCadStackHolder.Image = ((System.Drawing.Image)(resources.GetObject("btnCadStackHolder.Image")));
            this.btnCadStackHolder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCadStackHolder.Name = "btnCadStackHolder";
            this.btnCadStackHolder.Size = new System.Drawing.Size(23, 22);
            this.btnCadStackHolder.Text = "Gerenciar Stackholders";
            this.btnCadStackHolder.Click += new System.EventHandler(this.btnCadStackHolder_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Gerenciar Tipos de Stackholders";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Gerenciar Cronograma";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SigReq";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem criarRequisitoToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton btnCadStackHolder;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripMenuItem salvarProjetoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem sairESalvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarRequisitoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarRequisitoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gerenciarRequisitosToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog FileDialogProj;
        private System.Windows.Forms.ToolStripMenuItem stackholderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarStackholderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciarStackholderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarTiposDeStackholderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciarTiposDeStackholderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cronogramaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoCronogramaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciarCronogramaToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog FileDialogProjSave;
    }
}

