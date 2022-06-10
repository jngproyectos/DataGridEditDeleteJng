namespace DataEdit
{
    partial class MsgBox
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
            this.pL1 = new System.Windows.Forms.Panel();
            this.pL2 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblMsg = new System.Windows.Forms.Label();
            this.pbError = new System.Windows.Forms.PictureBox();
            this.pbWar = new System.Windows.Forms.PictureBox();
            this.pbQue = new System.Windows.Forms.PictureBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQue)).BeginInit();
            this.SuspendLayout();
            // 
            // pL1
            // 
            this.pL1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pL1.Location = new System.Drawing.Point(-1, 64);
            this.pL1.Name = "pL1";
            this.pL1.Size = new System.Drawing.Size(422, 4);
            this.pL1.TabIndex = 0;
            // 
            // pL2
            // 
            this.pL2.BackColor = System.Drawing.Color.Silver;
            this.pL2.Location = new System.Drawing.Point(-1, 155);
            this.pL2.Name = "pL2";
            this.pL2.Size = new System.Drawing.Size(422, 4);
            this.pL2.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(68, 25);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(62, 23);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "label1";
            // 
            // lblMsg
            // 
            this.lblMsg.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.ForeColor = System.Drawing.Color.White;
            this.lblMsg.Location = new System.Drawing.Point(12, 80);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(396, 64);
            this.lblMsg.TabIndex = 3;
            this.lblMsg.Text = "label1";
            // 
            // pbError
            // 
            this.pbError.Image = global::DataEdit.Properties.Resources.error1;
            this.pbError.Location = new System.Drawing.Point(12, 12);
            this.pbError.Name = "pbError";
            this.pbError.Size = new System.Drawing.Size(50, 50);
            this.pbError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbError.TabIndex = 6;
            this.pbError.TabStop = false;
            this.pbError.Visible = false;
            // 
            // pbWar
            // 
            this.pbWar.Image = global::DataEdit.Properties.Resources.warning1;
            this.pbWar.Location = new System.Drawing.Point(12, 12);
            this.pbWar.Name = "pbWar";
            this.pbWar.Size = new System.Drawing.Size(50, 50);
            this.pbWar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbWar.TabIndex = 5;
            this.pbWar.TabStop = false;
            this.pbWar.Visible = false;
            // 
            // pbQue
            // 
            this.pbQue.Image = global::DataEdit.Properties.Resources.question;
            this.pbQue.Location = new System.Drawing.Point(12, 12);
            this.pbQue.Name = "pbQue";
            this.pbQue.Size = new System.Drawing.Size(50, 50);
            this.pbQue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbQue.TabIndex = 4;
            this.pbQue.TabStop = false;
            this.pbQue.Visible = false;
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(230)))));
            this.btnOk.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(230)))));
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.Location = new System.Drawing.Point(243, 165);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(85, 30);
            this.btnOk.TabIndex = 7;
            this.btnOk.Text = "Aceptar";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            this.btnOk.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btnOk.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(230)))));
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(230)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(328, 165);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 30);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            this.btnCancel.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btnCancel.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // MsgBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(420, 200);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.pbError);
            this.Controls.Add(this.pbWar);
            this.Controls.Add(this.pbQue);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pL2);
            this.Controls.Add(this.pL1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MsgBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MsgBox";
            ((System.ComponentModel.ISupportInitialize)(this.pbError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pL1;
        private System.Windows.Forms.Panel pL2;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.PictureBox pbQue;
        private System.Windows.Forms.PictureBox pbWar;
        private System.Windows.Forms.PictureBox pbError;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}