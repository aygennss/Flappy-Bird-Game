namespace flappybird
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bird = new System.Windows.Forms.PictureBox();
            this.boruy = new System.Windows.Forms.PictureBox();
            this.borua = new System.Windows.Forms.PictureBox();
            this.zemin = new System.Windows.Forms.PictureBox();
            this.skortext = new System.Windows.Forms.Label();
            this.gametimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boruy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zemin)).BeginInit();
            this.SuspendLayout();
            // 
            // bird
            // 
            this.bird.Image = ((System.Drawing.Image)(resources.GetObject("bird.Image")));
            this.bird.Location = new System.Drawing.Point(41, 161);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(100, 50);
            this.bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bird.TabIndex = 0;
            this.bird.TabStop = false;
            // 
            // boruy
            // 
            this.boruy.Image = ((System.Drawing.Image)(resources.GetObject("boruy.Image")));
            this.boruy.Location = new System.Drawing.Point(397, 12);
            this.boruy.Name = "boruy";
            this.boruy.Size = new System.Drawing.Size(100, 100);
            this.boruy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boruy.TabIndex = 1;
            this.boruy.TabStop = false;
            // 
            // borua
            // 
            this.borua.Image = ((System.Drawing.Image)(resources.GetObject("borua.Image")));
            this.borua.Location = new System.Drawing.Point(261, 320);
            this.borua.Name = "borua";
            this.borua.Size = new System.Drawing.Size(100, 58);
            this.borua.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.borua.TabIndex = 2;
            this.borua.TabStop = false;
            // 
            // zemin
            // 
            this.zemin.Image = ((System.Drawing.Image)(resources.GetObject("zemin.Image")));
            this.zemin.Location = new System.Drawing.Point(0, 384);
            this.zemin.Name = "zemin";
            this.zemin.Size = new System.Drawing.Size(697, 104);
            this.zemin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.zemin.TabIndex = 3;
            this.zemin.TabStop = false;
            // 
            // skortext
            // 
            this.skortext.AutoSize = true;
            this.skortext.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.skortext.Location = new System.Drawing.Point(39, 491);
            this.skortext.Name = "skortext";
            this.skortext.Size = new System.Drawing.Size(102, 29);
            this.skortext.TabIndex = 4;
            this.skortext.Text = "Skor : 0";
            // 
            // gametimer
            // 
            this.gametimer.Enabled = true;
            this.gametimer.Tick += new System.EventHandler(this.gametimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(646, 528);
            this.Controls.Add(this.bird);
            this.Controls.Add(this.skortext);
            this.Controls.Add(this.zemin);
            this.Controls.Add(this.borua);
            this.Controls.Add(this.boruy);
            this.Name = "Form1";
            this.Text = "Flappy Bird Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeydown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyup);
            ((System.ComponentModel.ISupportInitialize)(this.bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boruy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zemin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox bird;
        private System.Windows.Forms.PictureBox boruy;
        private System.Windows.Forms.PictureBox borua;
        private System.Windows.Forms.PictureBox zemin;
        private System.Windows.Forms.Label skortext;
        private System.Windows.Forms.Timer gametimer;
    }
}

