namespace Exemplos4.WinFormsApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabUsuarios;
        private System.Windows.Forms.DataGridView dataGridViewUsuarios;
        private System.Windows.Forms.Button btnUsuarioPrev;
        private System.Windows.Forms.Button btnUsuarioNext;
        private System.Windows.Forms.Label lblUsuarioPage;

        private System.Windows.Forms.TabPage tabMaquinas;
        private System.Windows.Forms.DataGridView dataGridViewMaquinas;
        private System.Windows.Forms.Button btnMaquinaPrev;
        private System.Windows.Forms.Button btnMaquinaNext;
        private System.Windows.Forms.Label lblMaquinaPage;

        private System.Windows.Forms.TabPage tabSoftwares;
        private System.Windows.Forms.DataGridView dataGridViewSoftwares;
        private System.Windows.Forms.Button btnSoftwarePrev;
        private System.Windows.Forms.Button btnSoftwareNext;
        private System.Windows.Forms.Label lblSoftwarePage;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabUsuarios = new System.Windows.Forms.TabPage();
            this.dataGridViewUsuarios = new System.Windows.Forms.DataGridView();
            this.btnUsuarioPrev = new System.Windows.Forms.Button();
            this.btnUsuarioNext = new System.Windows.Forms.Button();
            this.lblUsuarioPage = new System.Windows.Forms.Label();
            this.tabMaquinas = new System.Windows.Forms.TabPage();
            this.dataGridViewMaquinas = new System.Windows.Forms.DataGridView();
            this.btnMaquinaPrev = new System.Windows.Forms.Button();
            this.btnMaquinaNext = new System.Windows.Forms.Button();
            this.lblMaquinaPage = new System.Windows.Forms.Label();
            this.tabSoftwares = new System.Windows.Forms.TabPage();
            this.dataGridViewSoftwares = new System.Windows.Forms.DataGridView();
            this.btnSoftwarePrev = new System.Windows.Forms.Button();
            this.btnSoftwareNext = new System.Windows.Forms.Button();
            this.lblSoftwarePage = new System.Windows.Forms.Label();

            // Configuração do TabControl
            this.tabControl.SuspendLayout();
            this.tabUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).BeginInit();
            this.tabMaquinas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaquinas)).BeginInit();
            this.tabSoftwares.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSoftwares)).BeginInit();
            this.SuspendLayout();

            // 
            // tabUsuarios
            // 
            this.tabUsuarios.Controls.Add(this.dataGridViewUsuarios);
            this.tabUsuarios.Controls.Add(this.btnUsuarioPrev);
            this.tabUsuarios.Controls.Add(this.btnUsuarioNext);
            this.tabUsuarios.Controls.Add(this.lblUsuarioPage);
            this.tabUsuarios.Location = new System.Drawing.Point(4, 24);
            this.tabUsuarios.Name = "tabUsuarios";
            this.tabUsuarios.Padding = new System.Windows.Forms.Padding(3);
            this.tabUsuarios.Size = new System.Drawing.Size(592, 372);
            this.tabUsuarios.TabIndex = 0;
            this.tabUsuarios.Text = "Usuários";

            // 
            // dataGridViewUsuarios
            // 
            this.dataGridViewUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsuarios.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewUsuarios.Name = "dataGridViewUsuarios";
            this.dataGridViewUsuarios.Size = new System.Drawing.Size(580, 300);
            this.dataGridViewUsuarios.TabIndex = 0;

            // 
            // btnUsuarioPrev
            // 
            this.btnUsuarioPrev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUsuarioPrev.Location = new System.Drawing.Point(6, 312);
            this.btnUsuarioPrev.Name = "btnUsuarioPrev";
            this.btnUsuarioPrev.Size = new System.Drawing.Size(75, 23);
            this.btnUsuarioPrev.TabIndex = 1;
            this.btnUsuarioPrev.Text = "Anterior";
            this.btnUsuarioPrev.UseVisualStyleBackColor = true;
            this.btnUsuarioPrev.Click += new System.EventHandler(this.btnUsuarioPrev_Click);

            // 
            // btnUsuarioNext
            // 
            this.btnUsuarioNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUsuarioNext.Location = new System.Drawing.Point(87, 312);
            this.btnUsuarioNext.Name = "btnUsuarioNext";
            this.btnUsuarioNext.Size = new System.Drawing.Size(75, 23);
            this.btnUsuarioNext.TabIndex = 2;
            this.btnUsuarioNext.Text = "Próximo";
            this.btnUsuarioNext.UseVisualStyleBackColor = true;
            this.btnUsuarioNext.Click += new System.EventHandler(this.btnUsuarioNext_Click);

            // 
            // lblUsuarioPage
            // 
            this.lblUsuarioPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblUsuarioPage.AutoSize = true;
            this.lblUsuarioPage.Location = new System.Drawing.Point(168, 316);
            this.lblUsuarioPage.Name = "lblUsuarioPage";
            this.lblUsuarioPage.Size = new System.Drawing.Size(64, 15);
            this.lblUsuarioPage.TabIndex = 3;
            this.lblUsuarioPage.Text = "Página: 1";

            // 
            // tabMaquinas (Configuração Idêntica à tabUsuarios)
            // 
            this.tabMaquinas.Controls.Add(this.dataGridViewMaquinas);
            this.tabMaquinas.Controls.Add(this.btnMaquinaPrev);
            this.tabMaquinas.Controls.Add(this.btnMaquinaNext);
            this.tabMaquinas.Controls.Add(this.lblMaquinaPage);
            this.tabMaquinas.Location = new System.Drawing.Point(4, 24);
            this.tabMaquinas.Name = "tabMaquinas";
            this.tabMaquinas.Padding = new System.Windows.Forms.Padding(3);
            this.tabMaquinas.Size = new System.Drawing.Size(592, 372);
            this.tabMaquinas.TabIndex = 1;
            this.tabMaquinas.Text = "Máquinas";

            // ... (Repetir configurações dos controles para Máquinas)

            // 
            // tabSoftwares (Configuração Idêntica à tabUsuarios)
            // 
            this.tabSoftwares.Controls.Add(this.dataGridViewSoftwares);
            this.tabSoftwares.Controls.Add(this.btnSoftwarePrev);
            this.tabSoftwares.Controls.Add(this.btnSoftwareNext);
            this.tabSoftwares.Controls.Add(this.lblSoftwarePage);
            this.tabSoftwares.Location = new System.Drawing.Point(4, 24);
            this.tabSoftwares.Name = "tabSoftwares";
            this.tabSoftwares.Size = new System.Drawing.Size(592, 372);
            this.tabSoftwares.TabIndex = 2;
            this.tabSoftwares.Text = "Softwares";

            // ... (Repetir configurações dos controles para Softwares)

            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabUsuarios);
            this.tabControl.Controls.Add(this.tabMaquinas);
            this.tabControl.Controls.Add(this.tabSoftwares);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(600, 400);
            this.tabControl.TabIndex = 0;

            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Interface CRUD com Paginação";
            this.tabUsuarios.ResumeLayout(false);
            this.tabUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).EndInit();
            this.tabMaquinas.ResumeLayout(false);
            this.tabMaquinas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaquinas)).EndInit();
            this.tabSoftwares.ResumeLayout(false);
            this.tabSoftwares.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSoftwares)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}