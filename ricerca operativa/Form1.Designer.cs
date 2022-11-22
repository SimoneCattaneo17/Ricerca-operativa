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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Tabella = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.flatNumericUpDown2 = new FlatNumericUpDown();
            this.flatNumericUpDown1 = new FlatNumericUpDown();
            this.rjButtons4 = new Client.RJButtons();
            this.rjButtons3 = new Client.RJButtons();
            this.rjButtons2 = new Client.RJButtons();
            this.rjButtons1 = new Client.RJButtons();
            ((System.ComponentModel.ISupportInitialize)(this.Tabella)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flatNumericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flatNumericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // Tabella
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            this.Tabella.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Tabella.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tabella.BackgroundColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Tabella.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Tabella.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Tabella.DefaultCellStyle = dataGridViewCellStyle3;
            this.Tabella.Location = new System.Drawing.Point(16, 87);
            this.Tabella.Margin = new System.Windows.Forms.Padding(4);
            this.Tabella.Name = "Tabella";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Tabella.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Tabella.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            this.Tabella.RowsDefaultCellStyle = dataGridViewCellStyle5;
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
            this.label1.ForeColor = System.Drawing.SystemColors.MenuText;
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
            this.label2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label2.Location = new System.Drawing.Point(247, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Consumatori";
            // 
            // flatNumericUpDown2
            // 
            this.flatNumericUpDown2.BackColor = System.Drawing.Color.Coral;
            this.flatNumericUpDown2.BorderColor = System.Drawing.Color.SteelBlue;
            this.flatNumericUpDown2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flatNumericUpDown2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.flatNumericUpDown2.Location = new System.Drawing.Point(210, 33);
            this.flatNumericUpDown2.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.flatNumericUpDown2.Name = "flatNumericUpDown2";
            this.flatNumericUpDown2.Size = new System.Drawing.Size(160, 22);
            this.flatNumericUpDown2.TabIndex = 16;
            this.flatNumericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.flatNumericUpDown2.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // flatNumericUpDown1
            // 
            this.flatNumericUpDown1.BackColor = System.Drawing.Color.Coral;
            this.flatNumericUpDown1.BorderColor = System.Drawing.Color.SteelBlue;
            this.flatNumericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flatNumericUpDown1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.flatNumericUpDown1.Location = new System.Drawing.Point(16, 33);
            this.flatNumericUpDown1.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.flatNumericUpDown1.Name = "flatNumericUpDown1";
            this.flatNumericUpDown1.Size = new System.Drawing.Size(160, 22);
            this.flatNumericUpDown1.TabIndex = 15;
            this.flatNumericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.flatNumericUpDown1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // rjButtons4
            // 
            this.rjButtons4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rjButtons4.BackColor = System.Drawing.Color.Coral;
            this.rjButtons4.FlatAppearance.BorderSize = 0;
            this.rjButtons4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButtons4.ForeColor = System.Drawing.SystemColors.MenuText;
            this.rjButtons4.Location = new System.Drawing.Point(901, 21);
            this.rjButtons4.Name = "rjButtons4";
            this.rjButtons4.Size = new System.Drawing.Size(150, 45);
            this.rjButtons4.TabIndex = 14;
            this.rjButtons4.Text = "Minimi costi";
            this.rjButtons4.UseVisualStyleBackColor = false;
            this.rjButtons4.Click += new System.EventHandler(this.rjButtons4_Click);
            // 
            // rjButtons3
            // 
            this.rjButtons3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rjButtons3.BackColor = System.Drawing.Color.Coral;
            this.rjButtons3.FlatAppearance.BorderSize = 0;
            this.rjButtons3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButtons3.ForeColor = System.Drawing.SystemColors.MenuText;
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
            this.rjButtons2.BackColor = System.Drawing.Color.Coral;
            this.rjButtons2.FlatAppearance.BorderSize = 0;
            this.rjButtons2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButtons2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.rjButtons2.Location = new System.Drawing.Point(564, 21);
            this.rjButtons2.Name = "rjButtons2";
            this.rjButtons2.Size = new System.Drawing.Size(150, 45);
            this.rjButtons2.TabIndex = 12;
            this.rjButtons2.Text = "Riempi tabella";
            this.rjButtons2.UseVisualStyleBackColor = false;
            this.rjButtons2.Click += new System.EventHandler(this.rjButtons2_Click);
            // 
            // rjButtons1
            // 
            this.rjButtons1.BackColor = System.Drawing.Color.Coral;
            this.rjButtons1.FlatAppearance.BorderSize = 0;
            this.rjButtons1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButtons1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.rjButtons1.Location = new System.Drawing.Point(393, 21);
            this.rjButtons1.Name = "rjButtons1";
            this.rjButtons1.Size = new System.Drawing.Size(150, 45);
            this.rjButtons1.TabIndex = 11;
            this.rjButtons1.Text = "Crea tabella";
            this.rjButtons1.UseVisualStyleBackColor = false;
            this.rjButtons1.Click += new System.EventHandler(this.rjButtons1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
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
            this.MinimumSize = new System.Drawing.Size(1085, 601);
            this.Name = "Form1";
            this.Text = "Ricerca Operativa";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Tabella)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flatNumericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flatNumericUpDown1)).EndInit();
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

