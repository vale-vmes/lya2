namespace AnalizadorLexico
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rtxLineas = new System.Windows.Forms.RichTextBox();
            this.btnAnalizador = new System.Windows.Forms.Button();
            this.btnGuardarTokens = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.GuardarPrograma = new System.Windows.Forms.Button();
            this.rtxFuente = new System.Windows.Forms.RichTextBox();
            this.btnCargarPrograma = new System.Windows.Forms.Button();
            this.rtxToken = new System.Windows.Forms.RichTextBox();
            this.rtxLinea2 = new System.Windows.Forms.RichTextBox();
            this.tabPestania = new System.Windows.Forms.TabControl();
            this.tabAnalizador = new System.Windows.Forms.TabPage();
            this.tabSintactico = new System.Windows.Forms.TabPage();
            this.rtxTokenSintaxis = new System.Windows.Forms.RichTextBox();
            this.btnSintactico = new System.Windows.Forms.Button();
            this.rtxCinta = new System.Windows.Forms.RichTextBox();
            this.tabTabla = new System.Windows.Forms.TabPage();
            this.dgvTablaSimbolos = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNumErrores = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvErrores = new System.Windows.Forms.DataGridView();
            this.tabMatriz = new System.Windows.Forms.TabPage();
            this.dgvMatriz = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPestania.SuspendLayout();
            this.tabAnalizador.SuspendLayout();
            this.tabSintactico.SuspendLayout();
            this.tabTabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaSimbolos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvErrores)).BeginInit();
            this.tabMatriz.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz)).BeginInit();
            this.SuspendLayout();
            // 
            // rtxLineas
            // 
            this.rtxLineas.BackColor = System.Drawing.SystemColors.ControlText;
            this.rtxLineas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxLineas.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxLineas.ForeColor = System.Drawing.Color.Lime;
            this.rtxLineas.Location = new System.Drawing.Point(605, 21);
            this.rtxLineas.Name = "rtxLineas";
            this.rtxLineas.Size = new System.Drawing.Size(51, 406);
            this.rtxLineas.TabIndex = 25;
            this.rtxLineas.Text = "";
            // 
            // btnAnalizador
            // 
            this.btnAnalizador.BackColor = System.Drawing.SystemColors.Control;
            this.btnAnalizador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnalizador.Location = new System.Drawing.Point(476, 185);
            this.btnAnalizador.Name = "btnAnalizador";
            this.btnAnalizador.Size = new System.Drawing.Size(123, 86);
            this.btnAnalizador.TabIndex = 24;
            this.btnAnalizador.Text = "Analizador Léxico";
            this.btnAnalizador.UseVisualStyleBackColor = false;
            this.btnAnalizador.Click += new System.EventHandler(this.btnAnalizador_Click);
            // 
            // btnGuardarTokens
            // 
            this.btnGuardarTokens.BackColor = System.Drawing.SystemColors.Control;
            this.btnGuardarTokens.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarTokens.Location = new System.Drawing.Point(918, 434);
            this.btnGuardarTokens.Name = "btnGuardarTokens";
            this.btnGuardarTokens.Size = new System.Drawing.Size(170, 30);
            this.btnGuardarTokens.TabIndex = 23;
            this.btnGuardarTokens.Text = "Guardar Tokens";
            this.btnGuardarTokens.UseVisualStyleBackColor = false;
            this.btnGuardarTokens.Click += new System.EventHandler(this.btnGuardarTokens_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.Control;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Location = new System.Drawing.Point(476, 430);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(123, 34);
            this.btnLimpiar.TabIndex = 22;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // GuardarPrograma
            // 
            this.GuardarPrograma.BackColor = System.Drawing.SystemColors.Control;
            this.GuardarPrograma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GuardarPrograma.Location = new System.Drawing.Point(170, 431);
            this.GuardarPrograma.Name = "GuardarPrograma";
            this.GuardarPrograma.Size = new System.Drawing.Size(89, 31);
            this.GuardarPrograma.TabIndex = 21;
            this.GuardarPrograma.Text = "Guardar";
            this.GuardarPrograma.UseVisualStyleBackColor = false;
            this.GuardarPrograma.Click += new System.EventHandler(this.GuardarPrograma_Click);
            // 
            // rtxFuente
            // 
            this.rtxFuente.BackColor = System.Drawing.SystemColors.InfoText;
            this.rtxFuente.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxFuente.ForeColor = System.Drawing.Color.Lime;
            this.rtxFuente.Location = new System.Drawing.Point(75, 21);
            this.rtxFuente.Name = "rtxFuente";
            this.rtxFuente.Size = new System.Drawing.Size(395, 406);
            this.rtxFuente.TabIndex = 19;
            this.rtxFuente.Text = "";
            // 
            // btnCargarPrograma
            // 
            this.btnCargarPrograma.BackColor = System.Drawing.SystemColors.Control;
            this.btnCargarPrograma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarPrograma.Location = new System.Drawing.Point(75, 431);
            this.btnCargarPrograma.Name = "btnCargarPrograma";
            this.btnCargarPrograma.Size = new System.Drawing.Size(89, 32);
            this.btnCargarPrograma.TabIndex = 20;
            this.btnCargarPrograma.Text = "Cargar";
            this.btnCargarPrograma.UseVisualStyleBackColor = false;
            this.btnCargarPrograma.Click += new System.EventHandler(this.btnCargarPrograma_Click);
            // 
            // rtxToken
            // 
            this.rtxToken.BackColor = System.Drawing.SystemColors.InfoText;
            this.rtxToken.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxToken.ForeColor = System.Drawing.Color.Lime;
            this.rtxToken.Location = new System.Drawing.Point(662, 21);
            this.rtxToken.Name = "rtxToken";
            this.rtxToken.Size = new System.Drawing.Size(426, 407);
            this.rtxToken.TabIndex = 26;
            this.rtxToken.Text = "";
            // 
            // rtxLinea2
            // 
            this.rtxLinea2.BackColor = System.Drawing.SystemColors.ControlText;
            this.rtxLinea2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxLinea2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxLinea2.ForeColor = System.Drawing.Color.Lime;
            this.rtxLinea2.Location = new System.Drawing.Point(15, 21);
            this.rtxLinea2.Name = "rtxLinea2";
            this.rtxLinea2.Size = new System.Drawing.Size(54, 406);
            this.rtxLinea2.TabIndex = 27;
            this.rtxLinea2.Text = "";
            // 
            // tabPestania
            // 
            this.tabPestania.Controls.Add(this.tabAnalizador);
            this.tabPestania.Controls.Add(this.tabSintactico);
            this.tabPestania.Controls.Add(this.tabTabla);
            this.tabPestania.Controls.Add(this.tabMatriz);
            this.tabPestania.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPestania.Location = new System.Drawing.Point(5, 12);
            this.tabPestania.Name = "tabPestania";
            this.tabPestania.SelectedIndex = 0;
            this.tabPestania.Size = new System.Drawing.Size(1116, 508);
            this.tabPestania.TabIndex = 28;
            // 
            // tabAnalizador
            // 
            this.tabAnalizador.BackColor = System.Drawing.Color.Thistle;
            this.tabAnalizador.Controls.Add(this.btnLimpiar);
            this.tabAnalizador.Controls.Add(this.btnCargarPrograma);
            this.tabAnalizador.Controls.Add(this.rtxToken);
            this.tabAnalizador.Controls.Add(this.rtxFuente);
            this.tabAnalizador.Controls.Add(this.rtxLineas);
            this.tabAnalizador.Controls.Add(this.GuardarPrograma);
            this.tabAnalizador.Controls.Add(this.btnAnalizador);
            this.tabAnalizador.Controls.Add(this.btnGuardarTokens);
            this.tabAnalizador.Controls.Add(this.rtxLinea2);
            this.tabAnalizador.Location = new System.Drawing.Point(4, 28);
            this.tabAnalizador.Name = "tabAnalizador";
            this.tabAnalizador.Padding = new System.Windows.Forms.Padding(3);
            this.tabAnalizador.Size = new System.Drawing.Size(1108, 476);
            this.tabAnalizador.TabIndex = 0;
            this.tabAnalizador.Text = "Analizador Léxico";
            // 
            // tabSintactico
            // 
            this.tabSintactico.BackColor = System.Drawing.Color.Thistle;
            this.tabSintactico.Controls.Add(this.rtxTokenSintaxis);
            this.tabSintactico.Controls.Add(this.btnSintactico);
            this.tabSintactico.Controls.Add(this.rtxCinta);
            this.tabSintactico.Location = new System.Drawing.Point(4, 28);
            this.tabSintactico.Name = "tabSintactico";
            this.tabSintactico.Padding = new System.Windows.Forms.Padding(3);
            this.tabSintactico.Size = new System.Drawing.Size(1108, 476);
            this.tabSintactico.TabIndex = 3;
            this.tabSintactico.Text = "Analizador Sintáctico";
            // 
            // rtxTokenSintaxis
            // 
            this.rtxTokenSintaxis.BackColor = System.Drawing.SystemColors.InfoText;
            this.rtxTokenSintaxis.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxTokenSintaxis.ForeColor = System.Drawing.Color.Lime;
            this.rtxTokenSintaxis.Location = new System.Drawing.Point(12, 17);
            this.rtxTokenSintaxis.Name = "rtxTokenSintaxis";
            this.rtxTokenSintaxis.Size = new System.Drawing.Size(536, 413);
            this.rtxTokenSintaxis.TabIndex = 22;
            this.rtxTokenSintaxis.Text = "";
            // 
            // btnSintactico
            // 
            this.btnSintactico.Location = new System.Drawing.Point(315, 436);
            this.btnSintactico.Name = "btnSintactico";
            this.btnSintactico.Size = new System.Drawing.Size(472, 32);
            this.btnSintactico.TabIndex = 21;
            this.btnSintactico.Text = "Analizador síntáctico";
            this.btnSintactico.UseVisualStyleBackColor = true;
            this.btnSintactico.Click += new System.EventHandler(this.btnSintactico_Click);
            // 
            // rtxCinta
            // 
            this.rtxCinta.BackColor = System.Drawing.SystemColors.InfoText;
            this.rtxCinta.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxCinta.ForeColor = System.Drawing.Color.Lime;
            this.rtxCinta.Location = new System.Drawing.Point(554, 17);
            this.rtxCinta.Name = "rtxCinta";
            this.rtxCinta.Size = new System.Drawing.Size(536, 413);
            this.rtxCinta.TabIndex = 20;
            this.rtxCinta.Text = "";
            // 
            // tabTabla
            // 
            this.tabTabla.Controls.Add(this.dgvTablaSimbolos);
            this.tabTabla.Controls.Add(this.label2);
            this.tabTabla.Controls.Add(this.lblNumErrores);
            this.tabTabla.Controls.Add(this.label1);
            this.tabTabla.Controls.Add(this.dgvErrores);
            this.tabTabla.Location = new System.Drawing.Point(4, 28);
            this.tabTabla.Name = "tabTabla";
            this.tabTabla.Padding = new System.Windows.Forms.Padding(3);
            this.tabTabla.Size = new System.Drawing.Size(1108, 476);
            this.tabTabla.TabIndex = 2;
            this.tabTabla.Text = "Tablas";
            this.tabTabla.UseVisualStyleBackColor = true;
            // 
            // dgvTablaSimbolos
            // 
            this.dgvTablaSimbolos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTablaSimbolos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablaSimbolos.Location = new System.Drawing.Point(449, 6);
            this.dgvTablaSimbolos.Name = "dgvTablaSimbolos";
            this.dgvTablaSimbolos.Size = new System.Drawing.Size(653, 433);
            this.dgvTablaSimbolos.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(711, 446);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tabla de simbolos";
            // 
            // lblNumErrores
            // 
            this.lblNumErrores.AutoSize = true;
            this.lblNumErrores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumErrores.Location = new System.Drawing.Point(283, 446);
            this.lblNumErrores.Name = "lblNumErrores";
            this.lblNumErrores.Size = new System.Drawing.Size(19, 20);
            this.lblNumErrores.TabIndex = 3;
            this.lblNumErrores.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 446);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cantidad de errores: ";
            // 
            // dgvErrores
            // 
            this.dgvErrores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvErrores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvErrores.Location = new System.Drawing.Point(6, 6);
            this.dgvErrores.Name = "dgvErrores";
            this.dgvErrores.Size = new System.Drawing.Size(437, 433);
            this.dgvErrores.TabIndex = 1;
            // 
            // tabMatriz
            // 
            this.tabMatriz.Controls.Add(this.dgvMatriz);
            this.tabMatriz.Location = new System.Drawing.Point(4, 28);
            this.tabMatriz.Name = "tabMatriz";
            this.tabMatriz.Padding = new System.Windows.Forms.Padding(3);
            this.tabMatriz.Size = new System.Drawing.Size(1108, 476);
            this.tabMatriz.TabIndex = 1;
            this.tabMatriz.Text = "Matriz";
            this.tabMatriz.UseVisualStyleBackColor = true;
            // 
            // dgvMatriz
            // 
            this.dgvMatriz.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvMatriz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatriz.Location = new System.Drawing.Point(6, 6);
            this.dgvMatriz.Name = "dgvMatriz";
            this.dgvMatriz.Size = new System.Drawing.Size(1096, 421);
            this.dgvMatriz.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(315, 436);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(472, 32);
            this.button1.TabIndex = 21;
            this.button1.Text = "Analizador síntáctico";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnSintactico_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1133, 532);
            this.Controls.Add(this.tabPestania);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GAREV";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPestania.ResumeLayout(false);
            this.tabAnalizador.ResumeLayout(false);
            this.tabSintactico.ResumeLayout(false);
            this.tabTabla.ResumeLayout(false);
            this.tabTabla.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaSimbolos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvErrores)).EndInit();
            this.tabMatriz.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriz)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxLineas;
        private System.Windows.Forms.Button btnAnalizador;
        private System.Windows.Forms.Button btnGuardarTokens;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button GuardarPrograma;
        private System.Windows.Forms.RichTextBox rtxFuente;
        private System.Windows.Forms.Button btnCargarPrograma;
        private System.Windows.Forms.RichTextBox rtxToken;
        private System.Windows.Forms.RichTextBox rtxLinea2;
        private System.Windows.Forms.TabControl tabPestania;
        private System.Windows.Forms.TabPage tabAnalizador;
        private System.Windows.Forms.TabPage tabMatriz;
        private System.Windows.Forms.DataGridView dgvMatriz;
        private System.Windows.Forms.TabPage tabTabla;
        private System.Windows.Forms.DataGridView dgvErrores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNumErrores;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvTablaSimbolos;
        private System.Windows.Forms.TabPage tabSintactico;
        private System.Windows.Forms.Button btnSintactico;
        private System.Windows.Forms.RichTextBox rtxCinta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox rtxTokenSintaxis;
    }
}

