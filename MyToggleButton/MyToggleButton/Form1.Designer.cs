
namespace MyToggleButton
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
            this.openToggle5 = new MyToggleButton.OpenToggle();
            this.openToggle4 = new MyToggleButton.OpenToggle();
            this.openToggle3 = new MyToggleButton.OpenToggle();
            this.openToggle2 = new MyToggleButton.OpenToggle();
            this.openToggle1 = new MyToggleButton.OpenToggle();
            this.SuspendLayout();
            // 
            // openToggle5
            // 
            this.openToggle5.BorderColor = System.Drawing.Color.LightGray;
            this.openToggle5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openToggle5.ForeColor = System.Drawing.Color.White;
            this.openToggle5.IsOn = false;
            this.openToggle5.Location = new System.Drawing.Point(198, 249);
            this.openToggle5.Name = "openToggle5";
            this.openToggle5.OffColor = System.Drawing.Color.DarkGray;
            this.openToggle5.OffText = "OFF";
            this.openToggle5.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.openToggle5.OnText = "ON";
            this.openToggle5.Size = new System.Drawing.Size(14, 9);
            this.openToggle5.TabIndex = 4;
            this.openToggle5.Text = "openToggle5";
            this.openToggle5.TextEnabled = true;
            // 
            // openToggle4
            // 
            this.openToggle4.BorderColor = System.Drawing.Color.LightGray;
            this.openToggle4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openToggle4.ForeColor = System.Drawing.Color.White;
            this.openToggle4.IsOn = false;
            this.openToggle4.Location = new System.Drawing.Point(323, 79);
            this.openToggle4.Name = "openToggle4";
            this.openToggle4.OffColor = System.Drawing.Color.DarkGray;
            this.openToggle4.OffText = "OFF";
            this.openToggle4.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.openToggle4.OnText = "ON";
            this.openToggle4.Size = new System.Drawing.Size(210, 107);
            this.openToggle4.TabIndex = 3;
            this.openToggle4.Text = "openToggle4";
            this.openToggle4.TextEnabled = true;
            // 
            // openToggle3
            // 
            this.openToggle3.BorderColor = System.Drawing.Color.LightGray;
            this.openToggle3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openToggle3.ForeColor = System.Drawing.Color.White;
            this.openToggle3.IsOn = false;
            this.openToggle3.Location = new System.Drawing.Point(563, 79);
            this.openToggle3.Name = "openToggle3";
            this.openToggle3.OffColor = System.Drawing.Color.DarkGray;
            this.openToggle3.OffText = "OFF";
            this.openToggle3.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.openToggle3.OnText = "ON";
            this.openToggle3.Size = new System.Drawing.Size(210, 107);
            this.openToggle3.TabIndex = 2;
            this.openToggle3.Text = "openToggle3";
            this.openToggle3.TextEnabled = true;
            // 
            // openToggle2
            // 
            this.openToggle2.BackColor = System.Drawing.Color.SandyBrown;
            this.openToggle2.BorderColor = System.Drawing.Color.LightGray;
            this.openToggle2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openToggle2.ForeColor = System.Drawing.Color.White;
            this.openToggle2.IsOn = false;
            this.openToggle2.Location = new System.Drawing.Point(83, 249);
            this.openToggle2.Name = "openToggle2";
            this.openToggle2.OffColor = System.Drawing.Color.DarkGray;
            this.openToggle2.OffText = "OFF";
            this.openToggle2.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.openToggle2.OnText = "ON";
            this.openToggle2.Size = new System.Drawing.Size(716, 360);
            this.openToggle2.TabIndex = 1;
            this.openToggle2.Text = "openToggle2";
            this.openToggle2.TextEnabled = true;
            // 
            // openToggle1
            // 
            this.openToggle1.BorderColor = System.Drawing.Color.LightGray;
            this.openToggle1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openToggle1.ForeColor = System.Drawing.Color.White;
            this.openToggle1.IsOn = false;
            this.openToggle1.Location = new System.Drawing.Point(70, 95);
            this.openToggle1.Name = "openToggle1";
            this.openToggle1.OffColor = System.Drawing.Color.DarkGray;
            this.openToggle1.OffText = "OFF";
            this.openToggle1.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.openToggle1.OnText = "ON";
            this.openToggle1.Size = new System.Drawing.Size(178, 91);
            this.openToggle1.TabIndex = 0;
            this.openToggle1.Text = "openToggle1";
            this.openToggle1.TextEnabled = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(979, 691);
            this.Controls.Add(this.openToggle5);
            this.Controls.Add(this.openToggle4);
            this.Controls.Add(this.openToggle3);
            this.Controls.Add(this.openToggle2);
            this.Controls.Add(this.openToggle1);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Name = "Form1";
            this.Text = "MyToggleButton";
            this.ResumeLayout(false);

        }

        #endregion

        private OpenToggle openToggle1;
        private OpenToggle openToggle2;
        private OpenToggle openToggle3;
        private OpenToggle openToggle4;
        private OpenToggle openToggle5;
    }
}

