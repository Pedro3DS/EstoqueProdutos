namespace EstoqueProdutos
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.btnProductsScreen = new System.Windows.Forms.Button();
            this.btnAddScreen = new System.Windows.Forms.Button();
            this.btnUpdateScreen = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnProductsScreen
            // 
            this.btnProductsScreen.FlatAppearance.BorderSize = 0;
            this.btnProductsScreen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnProductsScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductsScreen.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductsScreen.Location = new System.Drawing.Point(12, 12);
            this.btnProductsScreen.Name = "btnProductsScreen";
            this.btnProductsScreen.Size = new System.Drawing.Size(442, 49);
            this.btnProductsScreen.TabIndex = 0;
            this.btnProductsScreen.Text = "Produtos";
            this.btnProductsScreen.UseVisualStyleBackColor = true;
            this.btnProductsScreen.Click += new System.EventHandler(this.btnProductsScreen_Click);
            // 
            // btnAddScreen
            // 
            this.btnAddScreen.FlatAppearance.BorderSize = 0;
            this.btnAddScreen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAddScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddScreen.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddScreen.Location = new System.Drawing.Point(470, 12);
            this.btnAddScreen.Name = "btnAddScreen";
            this.btnAddScreen.Size = new System.Drawing.Size(442, 49);
            this.btnAddScreen.TabIndex = 1;
            this.btnAddScreen.Text = "Adicionar Produtos";
            this.btnAddScreen.UseVisualStyleBackColor = true;
            this.btnAddScreen.Click += new System.EventHandler(this.btnAddScreen_Click);
            // 
            // btnUpdateScreen
            // 
            this.btnUpdateScreen.FlatAppearance.BorderSize = 0;
            this.btnUpdateScreen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnUpdateScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateScreen.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateScreen.Location = new System.Drawing.Point(928, 12);
            this.btnUpdateScreen.Name = "btnUpdateScreen";
            this.btnUpdateScreen.Size = new System.Drawing.Size(442, 49);
            this.btnUpdateScreen.TabIndex = 2;
            this.btnUpdateScreen.Text = "Modificar Produtos";
            this.btnUpdateScreen.UseVisualStyleBackColor = true;
            this.btnUpdateScreen.Click += new System.EventHandler(this.btnUpdateScreen_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Location = new System.Drawing.Point(12, 67);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1358, 674);
            this.mainPanel.TabIndex = 3;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 753);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.btnUpdateScreen);
            this.Controls.Add(this.btnAddScreen);
            this.Controls.Add(this.btnProductsScreen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estoque de Produtos";
            this.Load += new System.EventHandler(this.main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProductsScreen;
        private System.Windows.Forms.Button btnAddScreen;
        private System.Windows.Forms.Button btnUpdateScreen;
        private System.Windows.Forms.Panel mainPanel;
    }
}

