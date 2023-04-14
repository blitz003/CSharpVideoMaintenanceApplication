
namespace VideoMaintenace
{
    partial class frmVideoMaintenance
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
            this.dgvVideos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxVideoID = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxDownload = new System.Windows.Forms.TextBox();
            this.textBoxSalePrice = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.textBoxFee = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVideos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVideos
            // 
            this.dgvVideos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVideos.Location = new System.Drawing.Point(40, 31);
            this.dgvVideos.Name = "dgvVideos";
            this.dgvVideos.RowHeadersWidth = 62;
            this.dgvVideos.RowTemplate.Height = 28;
            this.dgvVideos.Size = new System.Drawing.Size(932, 320);
            this.dgvVideos.TabIndex = 0;
            this.dgvVideos.SelectionChanged += new System.EventHandler(this.dgvVideos_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 468);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Video ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(126, 545);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(114, 618);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 37);
            this.label3.TabIndex = 3;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(62, 691);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 37);
            this.label4.TabIndex = 4;
            this.label4.Text = "Download";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(58, 769);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 37);
            this.label5.TabIndex = 5;
            this.label5.Text = "Genre ID";
            // 
            // textBoxVideoID
            // 
            this.textBoxVideoID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxVideoID.Location = new System.Drawing.Point(258, 465);
            this.textBoxVideoID.Name = "textBoxVideoID";
            this.textBoxVideoID.ReadOnly = true;
            this.textBoxVideoID.Size = new System.Drawing.Size(253, 44);
            this.textBoxVideoID.TabIndex = 6;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTitle.Location = new System.Drawing.Point(258, 538);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.ReadOnly = true;
            this.textBoxTitle.Size = new System.Drawing.Size(253, 44);
            this.textBoxTitle.TabIndex = 7;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrice.Location = new System.Drawing.Point(258, 615);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.ReadOnly = true;
            this.textBoxPrice.Size = new System.Drawing.Size(253, 44);
            this.textBoxPrice.TabIndex = 8;
            // 
            // textBoxDownload
            // 
            this.textBoxDownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDownload.Location = new System.Drawing.Point(258, 691);
            this.textBoxDownload.Name = "textBoxDownload";
            this.textBoxDownload.ReadOnly = true;
            this.textBoxDownload.Size = new System.Drawing.Size(253, 44);
            this.textBoxDownload.TabIndex = 9;
            // 
            // textBoxSalePrice
            // 
            this.textBoxSalePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSalePrice.Location = new System.Drawing.Point(258, 769);
            this.textBoxSalePrice.Name = "textBoxSalePrice";
            this.textBoxSalePrice.ReadOnly = true;
            this.textBoxSalePrice.Size = new System.Drawing.Size(253, 44);
            this.textBoxSalePrice.TabIndex = 10;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(640, 465);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(314, 97);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add Video";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(640, 608);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(314, 114);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit Application";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // textBoxFee
            // 
            this.textBoxFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFee.Location = new System.Drawing.Point(258, 830);
            this.textBoxFee.Name = "textBoxFee";
            this.textBoxFee.ReadOnly = true;
            this.textBoxFee.Size = new System.Drawing.Size(253, 44);
            this.textBoxFee.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(132, 837);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 37);
            this.label6.TabIndex = 13;
            this.label6.Text = "Fee";
            // 
            // frmVideoMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 895);
            this.Controls.Add(this.textBoxFee);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.textBoxSalePrice);
            this.Controls.Add(this.textBoxDownload);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.textBoxVideoID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvVideos);
            this.Name = "frmVideoMaintenance";
            this.Text = "Video Maintenance";
            this.Load += new System.EventHandler(this.frmVideoMaintenance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVideos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVideos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxVideoID;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxDownload;
        private System.Windows.Forms.TextBox textBoxSalePrice;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox textBoxFee;
        private System.Windows.Forms.Label label6;
    }
}

