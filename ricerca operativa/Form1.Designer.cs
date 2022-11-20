namespace ricerca_operativa
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Tabella = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rjButtons4 = new Client.RJButtons();
            this.rjButtons3 = new Client.RJButtons();
            this.rjButtons2 = new Client.RJButtons();
            this.rjButtons1 = new Client.RJButtons();
            this.flatNumericUpDown1 = new FlatNumericUpDown();
            this.flatNumericUpDown2 = new FlatNumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.Tabella)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flatNumericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flatNumericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // Tabella
            // 
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Window;
            this.Tabella.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
            this.Tabella.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tabella.BackgroundColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Tabella.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.Tabella.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Tabella.DefaultCellStyle = dataGridViewCellStyle23;
            this.Tabella.Location = new System.Drawing.Point(16, 87);
            this.Tabella.Margin = new System.Windows.Forms.Padding(4);
            this.Tabella.Name = "Tabella";
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Tabella.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.Tabella.RowHeadersWidth = 51;
            dataGridViewCellStyle25.BackColor = System.Drawing.SystemColors.Window;
            this.Tabella.RowsDefaultCellStyle = dataGridViewCellStyle25;
            this.Tabella.Size = new System.Drawing.Size(1035, 452);
            this.Tabella.TabIndex = 0;
            this.Tabella.AllowUserToAddRowsChanged += new System.EventHandler(this.False);
            this.Tabella.AllowUserToDeleteRowsChanged += new System.EventHandler(this.False);
            this.Tabella.AllowUserToOrderColumnsChanged += new System.EventHandler(this.False);
            this.Tabella.AllowUserToResizeColumnsChanged += new System.EventHandler(this.False);
            this.Tabella.AllowUserToResizeRowsChanged += new System.EventHandler(this.False);
            this.Tabella.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.Tabella.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.Tabella_EditingControlShowing);
            this.Tabella.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tabella_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(56, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Produttori";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(247, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Consumatori";
            // 
            // rjButtons4
            // 
            this.rjButtons4.BackColor = System.Drawing.Color.SteelBlue;
            this.rjButtons4.FlatAppearance.BorderSize = 0;
            this.rjButtons4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButtons4.ForeColor = System.Drawing.SystemColors.Window;
            this.rjButtons4.Location = new System.Drawing.Point(561, 21);
            this.rjButtons4.Name = "rjButtons4";
            this.rjButtons4.Size = new System.Drawing.Size(150, 45);
            this.rjButtons4.TabIndex = 14;
            this.rjButtons4.Text = "Minimi costi";
            this.rjButtons4.UseVisualStyleBackColor = false;
            this.rjButtons4.Click += new System.EventHandler(this.rjButtons4_Click);
            // 
            // rjButtons3
            // 
            this.rjButtons3.BackColor = System.Drawing.Color.SteelBlue;
            this.rjButtons3.FlatAppearance.BorderSize = 0;
            this.rjButtons3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButtons3.ForeColor = System.Drawing.SystemColors.Window;
            this.rjButtons3.Location = new System.Drawing.Point(731, 21);
            this.rjButtons3.Name = "rjButtons3";
            this.rjButtons3.Size = new System.Drawing.Size(150, 45);
            this.rjButtons3.TabIndex = 13;
            this.rjButtons3.Text = "Nord-Ovest";
            this.rjButtons3.UseVisualStyleBackColor = false;
            this.rjButtons3.Click += new System.EventHandler(this.rjButtons3_Click);
            // 
            // rjButtons2
            // 
            this.rjButtons2.BackColor = System.Drawing.Color.SteelBlue;
            this.rjButtons2.FlatAppearance.BorderSize = 0;
            this.rjButtons2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButtons2.ForeColor = System.Drawing.SystemColors.Window;
            this.rjButtons2.Location = new System.Drawing.Point(901, 21);
            this.rjButtons2.Name = "rjButtons2";
            this.rjButtons2.Size = new System.Drawing.Size(150, 45);
            this.rjButtons2.TabIndex = 12;
            this.rjButtons2.Text = "Riempi tabella";
            this.rjButtons2.UseVisualStyleBackColor = false;
            this.rjButtons2.Click += new System.EventHandler(this.rjButtons2_Click);
            // 
            // rjButtons1
            // 
            this.rjButtons1.BackColor = System.Drawing.Color.SteelBlue;
            this.rjButtons1.FlatAppearance.BorderSize = 0;
            this.rjButtons1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButtons1.ForeColor = System.Drawing.SystemColors.Window;
            this.rjButtons1.Location = new System.Drawing.Point(393, 21);
            this.rjButtons1.Name = "rjButtons1";
            this.rjButtons1.Size = new System.Drawing.Size(150, 45);
            this.rjButtons1.TabIndex = 11;
            this.rjButtons1.Text = "Crea tabella";
            this.rjButtons1.UseVisualStyleBackColor = false;
            this.rjButtons1.Click += new System.EventHandler(this.rjButtons1_Click);
            // 
            // flatNumericUpDown1
            // 
            this.flatNumericUpDown1.BackColor = System.Drawing.Color.SteelBlue;
            this.flatNumericUpDown1.BorderColor = System.Drawing.Color.SteelBlue;
            this.flatNumericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flatNumericUpDown1.ForeColor = System.Drawing.SystemColors.Window;
            this.flatNumericUpDown1.Location = new System.Drawing.Point(16, 33);
            this.flatNumericUpDown1.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.flatNumericUpDown1.Name = "flatNumericUpDown1";
            this.flatNumericUpDown1.Size = new System.Drawing.Size(160, 22);
            this.flatNumericUpDown1.TabIndex = 15;
            this.flatNumericUpDown1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // flatNumericUpDown2
            // 
            this.flatNumericUpDown2.BackColor = System.Drawing.Color.SteelBlue;
            this.flatNumericUpDown2.BorderColor = System.Drawing.Color.SteelBlue;
            this.flatNumericUpDown2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flatNumericUpDown2.ForeColor = System.Drawing.SystemColors.Window;
            this.flatNumericUpDown2.Location = new System.Drawing.Point(210, 33);
            this.flatNumericUpDown2.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.flatNumericUpDown2.Name = "flatNumericUpDown2";
            this.flatNumericUpDown2.Size = new System.Drawing.Size(160, 22);
            this.flatNumericUpDown2.TabIndex = 16;
            this.flatNumericUpDown2.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.flatNumericUpDown2);
            this.Controls.Add(this.flatNumericUpDown1);
            this.Controls.Add(this.rjButtons4);
            this.Controls.Add(this.rjButtons3);
            this.Controls.Add(this.rjButtons2);
            this.Controls.Add(this.rjButtons1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tabella);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Ricerca Operativa";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Tabella)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flatNumericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flatNumericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Tabella;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Client.RJButtons rjButtons1;
        private Client.RJButtons rjButtons2;
        private Client.RJButtons rjButtons3;
        private Client.RJButtons rjButtons4;
        private FlatNumericUpDown flatNumericUpDown1;
        private FlatNumericUpDown flatNumericUpDown2;
    }
}

