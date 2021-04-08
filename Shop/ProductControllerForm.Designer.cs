
namespace Shop
{
    partial class ProductControllerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductControllerForm));
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.selectImgBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.priceTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.brandComBox = new System.Windows.Forms.ComboBox();
            this.typeComBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(215, 39);
            this.nameTxt.Margin = new System.Windows.Forms.Padding(5);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(172, 34);
            this.nameTxt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Назва продукту:";
            // 
            // selectImgBtn
            // 
            this.selectImgBtn.Location = new System.Drawing.Point(394, 235);
            this.selectImgBtn.Margin = new System.Windows.Forms.Padding(5);
            this.selectImgBtn.Name = "selectImgBtn";
            this.selectImgBtn.Size = new System.Drawing.Size(264, 48);
            this.selectImgBtn.TabIndex = 2;
            this.selectImgBtn.Text = "Вибрати фотографію";
            this.selectImgBtn.UseVisualStyleBackColor = true;
            this.selectImgBtn.Click += new System.EventHandler(this.selectImgBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(420, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 215);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ціна:";
            // 
            // priceTxt
            // 
            this.priceTxt.Location = new System.Drawing.Point(215, 83);
            this.priceTxt.Margin = new System.Windows.Forms.Padding(5);
            this.priceTxt.Name = "priceTxt";
            this.priceTxt.Size = new System.Drawing.Size(172, 34);
            this.priceTxt.TabIndex = 4;
            this.priceTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.priceTxt_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 130);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Бренд:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 177);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "Вид:";
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(19, 235);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(5);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(154, 48);
            this.saveBtn.TabIndex = 12;
            this.saveBtn.Text = "Зберегти";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // brandComBox
            // 
            this.brandComBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.brandComBox.FormattingEnabled = true;
            this.brandComBox.Location = new System.Drawing.Point(215, 127);
            this.brandComBox.Margin = new System.Windows.Forms.Padding(5);
            this.brandComBox.Name = "brandComBox";
            this.brandComBox.Size = new System.Drawing.Size(172, 37);
            this.brandComBox.TabIndex = 13;
            // 
            // typeComBox
            // 
            this.typeComBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeComBox.FormattingEnabled = true;
            this.typeComBox.Location = new System.Drawing.Point(215, 174);
            this.typeComBox.Margin = new System.Windows.Forms.Padding(5);
            this.typeComBox.Name = "typeComBox";
            this.typeComBox.Size = new System.Drawing.Size(172, 37);
            this.typeComBox.TabIndex = 14;
            // 
            // ProductControllerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 303);
            this.Controls.Add(this.typeComBox);
            this.Controls.Add(this.brandComBox);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.priceTxt);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.selectImgBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameTxt);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximumSize = new System.Drawing.Size(690, 350);
            this.MinimumSize = new System.Drawing.Size(690, 350);
            this.Name = "ProductControllerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Додавання нового продукту";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProductControllerForm_FormClosing);
            this.Load += new System.EventHandler(this.ProductControllerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button selectImgBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox priceTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.ComboBox brandComBox;
        private System.Windows.Forms.ComboBox typeComBox;
    }
}