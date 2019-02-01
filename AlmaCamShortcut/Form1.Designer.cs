namespace AlmaCamShortcut
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </s
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.BT_open_AlmaCam = new System.Windows.Forms.Button();
            this.LB_Server_List = new System.Windows.Forms.ComboBox();
            this.BT_open_WPM = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BT_open_AlmaCam
            // 
            this.BT_open_AlmaCam.Location = new System.Drawing.Point(12, 39);
            this.BT_open_AlmaCam.Name = "BT_open_AlmaCam";
            this.BT_open_AlmaCam.Size = new System.Drawing.Size(503, 23);
            this.BT_open_AlmaCam.TabIndex = 0;
            this.BT_open_AlmaCam.Text = "Open almacam on selected server";
            this.BT_open_AlmaCam.UseVisualStyleBackColor = true;
            this.BT_open_AlmaCam.Click += new System.EventHandler(this.BT_open_AlmaCam_Click);
            // 
            // LB_Server_List
            // 
            this.LB_Server_List.FormattingEnabled = true;
            this.LB_Server_List.Location = new System.Drawing.Point(12, 12);
            this.LB_Server_List.Name = "LB_Server_List";
            this.LB_Server_List.Size = new System.Drawing.Size(503, 21);
            this.LB_Server_List.TabIndex = 1;
            // 
            // BT_open_WPM
            // 
            this.BT_open_WPM.Location = new System.Drawing.Point(12, 68);
            this.BT_open_WPM.Name = "BT_open_WPM";
            this.BT_open_WPM.Size = new System.Drawing.Size(503, 23);
            this.BT_open_WPM.TabIndex = 0;
            this.BT_open_WPM.Text = "Open WPM";
            this.BT_open_WPM.Click += new System.EventHandler(this.BT_open_WPM_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 165);
            this.Controls.Add(this.BT_open_WPM);
            this.Controls.Add(this.LB_Server_List);
            this.Controls.Add(this.BT_open_AlmaCam);
            this.Name = "Form1";
            this.Text = "ShotCut";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BT_open_AlmaCam;
        private System.Windows.Forms.ComboBox LB_Server_List;
        private System.Windows.Forms.Button BT_open_WPM;
    }
}

