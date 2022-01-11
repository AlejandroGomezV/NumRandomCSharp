
namespace NumeroRandom
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.listGenerados = new System.Windows.Forms.ListView();
            this.listBloqueados = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnrandom = new System.Windows.Forms.Button();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnbloquear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(795, 707);
            this.dataGridView1.TabIndex = 0;
            // 
            // listGenerados
            // 
            this.listGenerados.HideSelection = false;
            this.listGenerados.Location = new System.Drawing.Point(823, 90);
            this.listGenerados.Name = "listGenerados";
            this.listGenerados.Size = new System.Drawing.Size(121, 629);
            this.listGenerados.TabIndex = 1;
            this.listGenerados.UseCompatibleStateImageBehavior = false;
            // 
            // listBloqueados
            // 
            this.listBloqueados.HideSelection = false;
            this.listBloqueados.Location = new System.Drawing.Point(976, 108);
            this.listBloqueados.Name = "listBloqueados";
            this.listBloqueados.Size = new System.Drawing.Size(121, 611);
            this.listBloqueados.TabIndex = 2;
            this.listBloqueados.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(823, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Numeros generados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(976, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Numeros bloqueados";
            // 
            // btnrandom
            // 
            this.btnrandom.Location = new System.Drawing.Point(823, 32);
            this.btnrandom.Name = "btnrandom";
            this.btnrandom.Size = new System.Drawing.Size(121, 23);
            this.btnrandom.TabIndex = 5;
            this.btnrandom.Text = "Generar nuevo";
            this.btnrandom.UseVisualStyleBackColor = true;
            this.btnrandom.Click += new System.EventHandler(this.btnrandom_Click);
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(976, 61);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(65, 23);
            this.txtNum.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(976, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Bloquear numero";
            // 
            // btnbloquear
            // 
            this.btnbloquear.Location = new System.Drawing.Point(1057, 61);
            this.btnbloquear.Name = "btnbloquear";
            this.btnbloquear.Size = new System.Drawing.Size(40, 23);
            this.btnbloquear.TabIndex = 8;
            this.btnbloquear.Text = "+";
            this.btnbloquear.UseVisualStyleBackColor = true;
            this.btnbloquear.Click += new System.EventHandler(this.btnbloquear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 731);
            this.Controls.Add(this.btnbloquear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.btnrandom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBloqueados);
            this.Controls.Add(this.listGenerados);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListView listGenerados;
        private System.Windows.Forms.ListView listBloqueados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnrandom;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnbloquear;
    }
}

