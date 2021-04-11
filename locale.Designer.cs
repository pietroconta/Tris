
namespace EzTris
{
    partial class locale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(locale));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.vs = new System.Windows.Forms.PictureBox();
            this.lbl_cpu = new System.Windows.Forms.Label();
            this.tmp = new System.Windows.Forms.Timer(this.components);
            this.tim = new System.Windows.Forms.Timer(this.components);
            this.lbl_utente = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_o = new System.Windows.Forms.Label();
            this.lbl_x = new System.Windows.Forms.Label();
            this.lbl_simb = new System.Windows.Forms.Label();
            this.wt = new System.Windows.Forms.Timer(this.components);
            this.lbl_trn = new System.Windows.Forms.Label();
            this.tab_tris = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tab_tris)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RosyBrown;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(-6, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(742, 25);
            this.panel2.TabIndex = 5;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(699, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "-";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(720, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // vs
            // 
            this.vs.Image = ((System.Drawing.Image)(resources.GetObject("vs.Image")));
            this.vs.Location = new System.Drawing.Point(230, 143);
            this.vs.Name = "vs";
            this.vs.Size = new System.Drawing.Size(250, 211);
            this.vs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.vs.TabIndex = 8;
            this.vs.TabStop = false;
            // 
            // lbl_cpu
            // 
            this.lbl_cpu.AutoSize = true;
            this.lbl_cpu.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cpu.Location = new System.Drawing.Point(496, 194);
            this.lbl_cpu.Name = "lbl_cpu";
            this.lbl_cpu.Size = new System.Drawing.Size(0, 63);
            this.lbl_cpu.TabIndex = 10;
            // 
            // tmp
            // 
            this.tmp.Tick += new System.EventHandler(this.tmp_Tick);
            // 
            // tim
            // 
            this.tim.Interval = 1000;
            this.tim.Tick += new System.EventHandler(this.tim_Tick);
            // 
            // lbl_utente
            // 
            this.lbl_utente.AutoSize = true;
            this.lbl_utente.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_utente.Location = new System.Drawing.Point(18, 194);
            this.lbl_utente.Name = "lbl_utente";
            this.lbl_utente.Size = new System.Drawing.Size(0, 63);
            this.lbl_utente.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(354, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 63);
            this.label1.TabIndex = 11;
            // 
            // lbl_o
            // 
            this.lbl_o.AutoSize = true;
            this.lbl_o.Font = new System.Drawing.Font("MV Boli", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_o.Location = new System.Drawing.Point(558, 228);
            this.lbl_o.Name = "lbl_o";
            this.lbl_o.Size = new System.Drawing.Size(39, 29);
            this.lbl_o.TabIndex = 12;
            this.lbl_o.Text = "O:";
            this.lbl_o.Visible = false;
            this.lbl_o.Click += new System.EventHandler(this.lbl_o_Click);
            // 
            // lbl_x
            // 
            this.lbl_x.AutoSize = true;
            this.lbl_x.Font = new System.Drawing.Font("MV Boli", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_x.ForeColor = System.Drawing.Color.Red;
            this.lbl_x.Location = new System.Drawing.Point(557, 163);
            this.lbl_x.Name = "lbl_x";
            this.lbl_x.Size = new System.Drawing.Size(39, 29);
            this.lbl_x.TabIndex = 13;
            this.lbl_x.Text = "X:";
            this.lbl_x.Visible = false;
            this.lbl_x.Click += new System.EventHandler(this.lbl_x_Click);
            // 
            // lbl_simb
            // 
            this.lbl_simb.AutoSize = true;
            this.lbl_simb.Font = new System.Drawing.Font("MV Boli", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_simb.ForeColor = System.Drawing.Color.Black;
            this.lbl_simb.Location = new System.Drawing.Point(12, 34);
            this.lbl_simb.Name = "lbl_simb";
            this.lbl_simb.Size = new System.Drawing.Size(79, 29);
            this.lbl_simb.TabIndex = 14;
            this.lbl_simb.Text = "Tu: X";
            this.lbl_simb.Visible = false;
            // 
            // wt
            // 
            this.wt.Interval = 2000;
            this.wt.Tick += new System.EventHandler(this.wt_Tick);
            // 
            // lbl_trn
            // 
            this.lbl_trn.AutoSize = true;
            this.lbl_trn.Font = new System.Drawing.Font("MV Boli", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_trn.ForeColor = System.Drawing.Color.Black;
            this.lbl_trn.Location = new System.Drawing.Point(12, 75);
            this.lbl_trn.Name = "lbl_trn";
            this.lbl_trn.Size = new System.Drawing.Size(118, 29);
            this.lbl_trn.TabIndex = 25;
            this.lbl_trn.Text = "Turno di:";
            this.lbl_trn.Visible = false;
            // 
            // tab_tris
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.tab_tris.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tab_tris.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tab_tris.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tab_tris.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tab_tris.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tab_tris.ColumnHeadersVisible = false;
            this.tab_tris.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tab_tris.DefaultCellStyle = dataGridViewCellStyle3;
            this.tab_tris.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tab_tris.Location = new System.Drawing.Point(189, 119);
            this.tab_tris.Name = "tab_tris";
            this.tab_tris.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tab_tris.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.tab_tris.RowHeadersVisible = false;
            this.tab_tris.ShowCellToolTips = false;
            this.tab_tris.Size = new System.Drawing.Size(327, 295);
            this.tab_tris.TabIndex = 6;
            this.tab_tris.Visible = false;
            this.tab_tris.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tab_tris_CellClick);
            this.tab_tris.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tab_tris_CellContentClick);
            // 
            // locale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 483);
            this.Controls.Add(this.lbl_trn);
            this.Controls.Add(this.lbl_simb);
            this.Controls.Add(this.lbl_x);
            this.Controls.Add(this.lbl_o);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_cpu);
            this.Controls.Add(this.lbl_utente);
            this.Controls.Add(this.vs);
            this.Controls.Add(this.tab_tris);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "locale";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.locale_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tab_tris)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox vs;
        private System.Windows.Forms.Label lbl_cpu;
        private System.Windows.Forms.Timer tmp;
        private System.Windows.Forms.Timer tim;
        private System.Windows.Forms.Label lbl_utente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_o;
        private System.Windows.Forms.Label lbl_x;
        private System.Windows.Forms.Label lbl_simb;
        private System.Windows.Forms.Timer wt;
        private System.Windows.Forms.Label lbl_trn;
        private System.Windows.Forms.DataGridView tab_tris;
    }
}