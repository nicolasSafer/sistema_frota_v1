namespace sistema_frota_v1
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Manutenção = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.empresa_prefeitura = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.suporte = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.boas_vindas = new System.Windows.Forms.Label();
            this.Nome_usuario = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.sidebartimer = new System.Windows.Forms.Timer(this.components);
            this.sidebar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.White;
            this.sidebar.Controls.Add(this.panel2);
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Controls.Add(this.panel3);
            this.sidebar.Controls.Add(this.panel4);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(291, 388);
            this.sidebar.TabIndex = 1;
            this.sidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.Nome_usuario);
            this.panel2.Controls.Add(this.boas_vindas);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(287, 154);
            this.panel2.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Manutenção);
            this.panel1.Location = new System.Drawing.Point(3, 163);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 30);
            this.panel1.TabIndex = 4;
            // 
            // Manutenção
            // 
            this.Manutenção.BackColor = System.Drawing.Color.White;
            this.Manutenção.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Manutenção.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Manutenção.Image = global::sistema_frota_v1.Properties.Resources.icons8_manutenção_28;
            this.Manutenção.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Manutenção.Location = new System.Drawing.Point(-9, -8);
            this.Manutenção.Name = "Manutenção";
            this.Manutenção.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Manutenção.Size = new System.Drawing.Size(302, 47);
            this.Manutenção.TabIndex = 3;
            this.Manutenção.Text = "          Manutenção";
            this.Manutenção.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Manutenção.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.empresa_prefeitura);
            this.panel3.Location = new System.Drawing.Point(3, 199);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(287, 30);
            this.panel3.TabIndex = 5;
            // 
            // empresa_prefeitura
            // 
            this.empresa_prefeitura.BackColor = System.Drawing.Color.White;
            this.empresa_prefeitura.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.empresa_prefeitura.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.empresa_prefeitura.Image = global::sistema_frota_v1.Properties.Resources.icons8_project_diagram_281;
            this.empresa_prefeitura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.empresa_prefeitura.Location = new System.Drawing.Point(-9, -8);
            this.empresa_prefeitura.Name = "empresa_prefeitura";
            this.empresa_prefeitura.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.empresa_prefeitura.Size = new System.Drawing.Size(302, 47);
            this.empresa_prefeitura.TabIndex = 3;
            this.empresa_prefeitura.Text = "          Empresa/Prefeitura";
            this.empresa_prefeitura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.empresa_prefeitura.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.suporte);
            this.panel4.Location = new System.Drawing.Point(3, 235);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(287, 30);
            this.panel4.TabIndex = 5;
            // 
            // suporte
            // 
            this.suporte.BackColor = System.Drawing.Color.White;
            this.suporte.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.suporte.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.suporte.Image = global::sistema_frota_v1.Properties.Resources.icons8_error_28;
            this.suporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.suporte.Location = new System.Drawing.Point(-9, -8);
            this.suporte.Name = "suporte";
            this.suporte.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.suporte.Size = new System.Drawing.Size(302, 47);
            this.suporte.TabIndex = 3;
            this.suporte.Text = "          Suporte";
            this.suporte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.suporte.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::sistema_frota_v1.Properties.Resources.icons8_x_48;
            this.pictureBox1.Location = new System.Drawing.Point(9, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_2);
            // 
            // boas_vindas
            // 
            this.boas_vindas.AutoSize = true;
            this.boas_vindas.Font = new System.Drawing.Font("Segoe MDL2 Assets", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.boas_vindas.ForeColor = System.Drawing.Color.Red;
            this.boas_vindas.Location = new System.Drawing.Point(9, 68);
            this.boas_vindas.Name = "boas_vindas";
            this.boas_vindas.Size = new System.Drawing.Size(46, 29);
            this.boas_vindas.TabIndex = 2;
            this.boas_vindas.Text = "Olá";
            this.boas_vindas.Click += new System.EventHandler(this.boas_vindas_Click);
            // 
            // Nome_usuario
            // 
            this.Nome_usuario.AutoSize = true;
            this.Nome_usuario.Location = new System.Drawing.Point(9, 112);
            this.Nome_usuario.Name = "Nome_usuario";
            this.Nome_usuario.Size = new System.Drawing.Size(88, 15);
            this.Nome_usuario.TabIndex = 2;
            this.Nome_usuario.Text = " Nome_Usuario";
            this.Nome_usuario.Click += new System.EventHandler(this.Nome_usuario_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(39, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = " Gestão da frota de veiculos prefeitura municipal salvador-BA";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::sistema_frota_v1.Properties.Resources.icons8_waving_hand_emoji_28;
            this.pictureBox2.Location = new System.Drawing.Point(51, 68);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 29);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // sidebartimer
            // 
            this.sidebartimer.Tick += new System.EventHandler(this.sidebartimer_tiker);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(870, 388);
            this.Controls.Add(this.sidebar);
            this.Name = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.sidebar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ToolStripMenuItem empresaPrefeituraToolStripMenuItem;
        private ToolStripMenuItem manutençãoToolStripMenuItem;
        private ToolStripMenuItem suporteToolStripMenuItem;
        private ToolStripMenuItem ordensDeServiçoToolStripMenuItem;
        private ToolStripMenuItem credenciamentoToolStripMenuItem;
        private ToolStripMenuItem administradorToolStripMenuItem;
        private ToolStripMenuItem ordensDeServiçoToolStripMenuItem1;
        private ToolStripMenuItem credenciamentoToolStripMenuItem1;
        private ToolStripMenuItem administradorToolStripMenuItem1;
        private ToolStripMenuItem recuperarSenhaToolStripMenuItem;
        private ToolStripMenuItem fedbackToolStripMenuItem;
        private ToolStripMenuItem cadastrarGestorToolStripMenuItem;
        private ToolStripMenuItem vincularGestorNaSecretariaToolStripMenuItem;
        private ToolStripMenuItem gestoresToolStripMenuItem;
        private ToolStripMenuItem grupossecretariasToolStripMenuItem;
        private ToolStripMenuItem cadastrarVeiculosToolStripMenuItem;
        private ToolStripMenuItem cadastrarMotoristaToolStripMenuItem;
        private ToolStripMenuItem vincularVeiculoToolStripMenuItem;
        private ToolStripMenuItem removerVeiculoToolStripMenuItem;
        private ToolStripMenuItem removerMotoristaToolStripMenuItem;
        private ToolStripMenuItem gerenciarVeiculosToolStripMenuItem;
        private ToolStripMenuItem veiculosToolStripMenuItem;
        private ToolStripMenuItem motoristasToolStripMenuItem;
        private ToolStripMenuItem cadastarEmpenhoToolStripMenuItem;
        private ToolStripMenuItem vincularEmpenhoToolStripMenuItem;
        private ToolStripMenuItem administarEmpenhoToolStripMenuItem;
        private ToolStripMenuItem consultaToolStripMenuItem;
        private ToolStripMenuItem lançamentoToolStripMenuItem;
        private ToolStripMenuItem gerenciarDistribuiçãoToolStripMenuItem;
        private ToolStripMenuItem cancelamentoToolStripMenuItem;
        private ToolStripMenuItem avaliaçãoToolStripMenuItem;
        private ToolStripMenuItem execuçãoToolStripMenuItem;
        private ToolStripMenuItem fornecedoresToolStripMenuItem;
        private ToolStripMenuItem cadastrarToolStripMenuItem;
        private ToolStripMenuItem polosRegionaisToolStripMenuItem;
        private ToolStripMenuItem atuaçãoToolStripMenuItem;
        private ToolStripMenuItem cancelamentoOsAutorizadaToolStripMenuItem;
        private ToolStripMenuItem cadastrarFuncionarioToolStripMenuItem;
        private ToolStripMenuItem vincularFuncionarioToolStripMenuItem;
        private ToolStripMenuItem tiposToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private FlowLayoutPanel sidebar;
        private Panel panel2;
        private Panel panel1;
        private Button Manutenção;
        private Label boas_vindas;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Button empresa_prefeitura;
        private Panel panel4;
        private Button suporte;
        private Label Nome_usuario;
        private Label label2;
        private PictureBox pictureBox2;
        private System.Windows.Forms.Timer sidebartimer;
    }
}