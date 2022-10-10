
namespace slot_machine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imgslot = new System.Windows.Forms.PictureBox();
            this.img1 = new System.Windows.Forms.PictureBox();
            this.img2 = new System.Windows.Forms.PictureBox();
            this.img3 = new System.Windows.Forms.PictureBox();
            this.btnleva = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgslot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img3)).BeginInit();
            this.SuspendLayout();
            // 
            // imgslot
            // 
            this.imgslot.Image = ((System.Drawing.Image)(resources.GetObject("imgslot.Image")));
            this.imgslot.Location = new System.Drawing.Point(-117, -26);
            this.imgslot.Name = "imgslot";
            this.imgslot.Size = new System.Drawing.Size(1020, 500);
            this.imgslot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgslot.TabIndex = 0;
            this.imgslot.TabStop = false;
            // 
            // img1
            // 
            this.img1.Image = ((System.Drawing.Image)(resources.GetObject("img1.Image")));
            this.img1.Location = new System.Drawing.Point(139, 139);
            this.img1.Name = "img1";
            this.img1.Size = new System.Drawing.Size(116, 155);
            this.img1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img1.TabIndex = 1;
            this.img1.TabStop = false;
            // 
            // img2
            // 
            this.img2.Image = ((System.Drawing.Image)(resources.GetObject("img2.Image")));
            this.img2.Location = new System.Drawing.Point(298, 139);
            this.img2.Name = "img2";
            this.img2.Size = new System.Drawing.Size(127, 162);
            this.img2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img2.TabIndex = 2;
            this.img2.TabStop = false;
            // 
            // img3
            // 
            this.img3.Image = ((System.Drawing.Image)(resources.GetObject("img3.Image")));
            this.img3.Location = new System.Drawing.Point(463, 139);
            this.img3.Name = "img3";
            this.img3.Size = new System.Drawing.Size(121, 155);
            this.img3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img3.TabIndex = 3;
            this.img3.TabStop = false;
            // 
            // btnleva
            // 
            this.btnleva.BackColor = System.Drawing.Color.Transparent;
            this.btnleva.Location = new System.Drawing.Point(728, 74);
            this.btnleva.Name = "btnleva";
            this.btnleva.Size = new System.Drawing.Size(60, 47);
            this.btnleva.TabIndex = 4;
            this.btnleva.Text = "Gioca!";
            this.btnleva.UseVisualStyleBackColor = false;
            this.btnleva.Click += new System.EventHandler(this.btnleva_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnleva);
            this.Controls.Add(this.img3);
            this.Controls.Add(this.img2);
            this.Controls.Add(this.img1);
            this.Controls.Add(this.imgslot);
            this.Name = "Form1";
            this.Text = "Slot Machine!1!!1";
            ((System.ComponentModel.ISupportInitialize)(this.imgslot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgslot;
        private System.Windows.Forms.PictureBox img1;
        private System.Windows.Forms.PictureBox img2;
        private System.Windows.Forms.PictureBox img3;
        private System.Windows.Forms.Button btnleva;
    }
}

