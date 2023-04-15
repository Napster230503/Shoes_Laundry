namespace Shoes_Laundry.view
{
    partial class showdata
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(showdata));
            this.label1 = new System.Windows.Forms.Label();
            this.ordertable = new System.Windows.Forms.DataGridView();
            this.btnback = new System.Windows.Forms.Button();
            this.btn_show = new System.Windows.Forms.Button();
            this.txtSrc = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ordertable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(250, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "SHOES LAUNDRY";
            // 
            // ordertable
            // 
            this.ordertable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordertable.Location = new System.Drawing.Point(51, 123);
            this.ordertable.Name = "ordertable";
            this.ordertable.Size = new System.Drawing.Size(699, 350);
            this.ordertable.TabIndex = 2;
            this.ordertable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ordertable_CellContentClick);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.SlateGray;
            this.btnback.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.Location = new System.Drawing.Point(645, 514);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(105, 33);
            this.btnback.TabIndex = 4;
            this.btnback.Text = "BACK";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btn_show
            // 
            this.btn_show.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_show.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_show.Location = new System.Drawing.Point(51, 514);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(137, 33);
            this.btn_show.TabIndex = 5;
            this.btn_show.Text = "SHOW DATA";
            this.btn_show.UseVisualStyleBackColor = false;
            // 
            // txtSrc
            // 
            this.txtSrc.Location = new System.Drawing.Point(51, 97);
            this.txtSrc.Name = "txtSrc";
            this.txtSrc.Size = new System.Drawing.Size(188, 20);
            this.txtSrc.TabIndex = 6;
            this.txtSrc.TextChanged += new System.EventHandler(this.txtSrc_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(257, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "SEARCH";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // showdata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(800, 578);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSrc);
            this.Controls.Add(this.btn_show);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.ordertable);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "showdata";
            this.Text = "Database";
            this.Load += new System.EventHandler(this.showdatapage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ordertable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ordertable;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.TextBox txtSrc;
        private System.Windows.Forms.Button button1;
    }
}