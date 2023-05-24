namespace LocadoraClassic.View
{
    partial class frmMenu
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
            if (disposing && (components != null))
            {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.realizarLocaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioDiárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaNegraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faturamentoDoDiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faturamentoDoMêsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gráficosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gráficoPizzaDeClientesPorEndereçoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gráficoDeBarraDeAtrasadosPorMêsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.locaçãoToolStripMenuItem,
            this.relatóriosToolStripMenuItem,
            this.gráficosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generoToolStripMenuItem,
            this.categoriaToolStripMenuItem,
            this.filmeToolStripMenuItem,
            this.clienteToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // generoToolStripMenuItem
            // 
            this.generoToolStripMenuItem.Name = "generoToolStripMenuItem";
            this.generoToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.generoToolStripMenuItem.Text = "Gênero";
            this.generoToolStripMenuItem.Click += new System.EventHandler(this.gêneroToolStripMenuItem_Click);
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.categoriaToolStripMenuItem.Text = "Categoria";
            this.categoriaToolStripMenuItem.Click += new System.EventHandler(this.categoriaToolStripMenuItem_Click);
            // 
            // filmeToolStripMenuItem
            // 
            this.filmeToolStripMenuItem.Name = "filmeToolStripMenuItem";
            this.filmeToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.filmeToolStripMenuItem.Text = "Filme";
            this.filmeToolStripMenuItem.Click += new System.EventHandler(this.filmeToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // locaçãoToolStripMenuItem
            // 
            this.locaçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.realizarLocaçãoToolStripMenuItem,
            this.relatórioDiárioToolStripMenuItem});
            this.locaçãoToolStripMenuItem.Name = "locaçãoToolStripMenuItem";
            this.locaçãoToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.locaçãoToolStripMenuItem.Text = "Locação";
            // 
            // realizarLocaçãoToolStripMenuItem
            // 
            this.realizarLocaçãoToolStripMenuItem.Name = "realizarLocaçãoToolStripMenuItem";
            this.realizarLocaçãoToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.realizarLocaçãoToolStripMenuItem.Text = "Realizar Locação";
            this.realizarLocaçãoToolStripMenuItem.Click += new System.EventHandler(this.realizarLocaçãoToolStripMenuItem_Click);
            // 
            // relatórioDiárioToolStripMenuItem
            // 
            this.relatórioDiárioToolStripMenuItem.Name = "relatórioDiárioToolStripMenuItem";
            this.relatórioDiárioToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.relatórioDiárioToolStripMenuItem.Text = "Relatório Diário";
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaNegraToolStripMenuItem,
            this.faturamentoDoDiaToolStripMenuItem,
            this.faturamentoDoMêsToolStripMenuItem});
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // listaNegraToolStripMenuItem
            // 
            this.listaNegraToolStripMenuItem.Name = "listaNegraToolStripMenuItem";
            this.listaNegraToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.listaNegraToolStripMenuItem.Text = "Pendentes";
            this.listaNegraToolStripMenuItem.Click += new System.EventHandler(this.listaNegraToolStripMenuItem_Click);
            // 
            // faturamentoDoDiaToolStripMenuItem
            // 
            this.faturamentoDoDiaToolStripMenuItem.Name = "faturamentoDoDiaToolStripMenuItem";
            this.faturamentoDoDiaToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.faturamentoDoDiaToolStripMenuItem.Text = "Faturamento do Dia";
            // 
            // faturamentoDoMêsToolStripMenuItem
            // 
            this.faturamentoDoMêsToolStripMenuItem.Name = "faturamentoDoMêsToolStripMenuItem";
            this.faturamentoDoMêsToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.faturamentoDoMêsToolStripMenuItem.Text = "Faturamento do Mês";
            // 
            // gráficosToolStripMenuItem
            // 
            this.gráficosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gráficoPizzaDeClientesPorEndereçoToolStripMenuItem,
            this.gráficoDeBarraDeAtrasadosPorMêsToolStripMenuItem});
            this.gráficosToolStripMenuItem.Name = "gráficosToolStripMenuItem";
            this.gráficosToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.gráficosToolStripMenuItem.Text = "Gráficos";
            // 
            // gráficoPizzaDeClientesPorEndereçoToolStripMenuItem
            // 
            this.gráficoPizzaDeClientesPorEndereçoToolStripMenuItem.Name = "gráficoPizzaDeClientesPorEndereçoToolStripMenuItem";
            this.gráficoPizzaDeClientesPorEndereçoToolStripMenuItem.Size = new System.Drawing.Size(275, 22);
            this.gráficoPizzaDeClientesPorEndereçoToolStripMenuItem.Text = "Gráfico Pizza de Clientes por Endereço";
            // 
            // gráficoDeBarraDeAtrasadosPorMêsToolStripMenuItem
            // 
            this.gráficoDeBarraDeAtrasadosPorMêsToolStripMenuItem.Name = "gráficoDeBarraDeAtrasadosPorMêsToolStripMenuItem";
            this.gráficoDeBarraDeAtrasadosPorMêsToolStripMenuItem.Size = new System.Drawing.Size(275, 22);
            this.gráficoDeBarraDeAtrasadosPorMêsToolStripMenuItem.Text = "Gráfico de Barra de Atrasados por Mês";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Locadora Classic";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem locaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem realizarLocaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatórioDiárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaNegraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faturamentoDoDiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faturamentoDoMêsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gráficosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gráficoPizzaDeClientesPorEndereçoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gráficoDeBarraDeAtrasadosPorMêsToolStripMenuItem;
    }
}

