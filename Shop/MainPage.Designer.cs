
namespace Shop
{
    partial class MainPage
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
            this.headerPanel = new System.Windows.Forms.Panel();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.addNewProductBtn = new System.Windows.Forms.Button();
            this.backPanelSearchTxt = new System.Windows.Forms.Panel();
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.seatchBtn = new System.Windows.Forms.Button();
            this.logoTxt = new System.Windows.Forms.Label();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.priceGB = new System.Windows.Forms.GroupBox();
            this.selectedPriceBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.priceToTxt = new System.Windows.Forms.TextBox();
            this.priceFromTxt = new System.Windows.Forms.TextBox();
            this.brandGB = new System.Windows.Forms.GroupBox();
            this.typeOfSweetsGB = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.nothingFoundedLabel = new System.Windows.Forms.Label();
            this.delBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.headerPanel.SuspendLayout();
            this.searchPanel.SuspendLayout();
            this.backPanelSearchTxt.SuspendLayout();
            this.infoPanel.SuspendLayout();
            this.priceGB.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.headerPanel.Controls.Add(this.searchPanel);
            this.headerPanel.Controls.Add(this.logoTxt);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1058, 105);
            this.headerPanel.TabIndex = 0;
            // 
            // searchPanel
            // 
            this.searchPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.searchPanel.Controls.Add(this.addNewProductBtn);
            this.searchPanel.Controls.Add(this.backPanelSearchTxt);
            this.searchPanel.Controls.Add(this.seatchBtn);
            this.searchPanel.Location = new System.Drawing.Point(314, 0);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(744, 105);
            this.searchPanel.TabIndex = 1;
            // 
            // addNewProductBtn
            // 
            this.addNewProductBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addNewProductBtn.Location = new System.Drawing.Point(624, 30);
            this.addNewProductBtn.Name = "addNewProductBtn";
            this.addNewProductBtn.Size = new System.Drawing.Size(117, 44);
            this.addNewProductBtn.TabIndex = 4;
            this.addNewProductBtn.Text = "Додати";
            this.addNewProductBtn.UseVisualStyleBackColor = true;
            this.addNewProductBtn.Click += new System.EventHandler(this.addNewProduct_Click);
            // 
            // backPanelSearchTxt
            // 
            this.backPanelSearchTxt.BackColor = System.Drawing.SystemColors.Window;
            this.backPanelSearchTxt.Controls.Add(this.searchTxt);
            this.backPanelSearchTxt.Location = new System.Drawing.Point(19, 32);
            this.backPanelSearchTxt.Margin = new System.Windows.Forms.Padding(0);
            this.backPanelSearchTxt.Name = "backPanelSearchTxt";
            this.backPanelSearchTxt.Padding = new System.Windows.Forms.Padding(14, 4, 14, 4);
            this.backPanelSearchTxt.Size = new System.Drawing.Size(480, 40);
            this.backPanelSearchTxt.TabIndex = 2;
            // 
            // searchTxt
            // 
            this.searchTxt.AccessibleDescription = "";
            this.searchTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchTxt.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.searchTxt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.searchTxt.Location = new System.Drawing.Point(17, 7);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(446, 25);
            this.searchTxt.TabIndex = 0;
            this.searchTxt.Text = "Я шукаю...";
            this.searchTxt.Click += new System.EventHandler(this.searchTxt_Click);
            this.searchTxt.Leave += new System.EventHandler(this.searchTxt_Leave);
            // 
            // seatchBtn
            // 
            this.seatchBtn.AutoSize = true;
            this.seatchBtn.FlatAppearance.BorderSize = 0;
            this.seatchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.seatchBtn.Location = new System.Drawing.Point(498, 30);
            this.seatchBtn.Margin = new System.Windows.Forms.Padding(0);
            this.seatchBtn.Name = "seatchBtn";
            this.seatchBtn.Size = new System.Drawing.Size(113, 44);
            this.seatchBtn.TabIndex = 1;
            this.seatchBtn.Text = "Знайти";
            this.seatchBtn.UseVisualStyleBackColor = true;
            this.seatchBtn.Click += new System.EventHandler(this.seatchBtn_Click);
            // 
            // logoTxt
            // 
            this.logoTxt.Dock = System.Windows.Forms.DockStyle.Left;
            this.logoTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logoTxt.Location = new System.Drawing.Point(0, 0);
            this.logoTxt.Name = "logoTxt";
            this.logoTxt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.logoTxt.Size = new System.Drawing.Size(314, 105);
            this.logoTxt.TabIndex = 0;
            this.logoTxt.Text = "Sweet Shop";
            this.logoTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // infoPanel
            // 
            this.infoPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.infoPanel.Controls.Add(this.priceGB);
            this.infoPanel.Controls.Add(this.brandGB);
            this.infoPanel.Controls.Add(this.typeOfSweetsGB);
            this.infoPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.infoPanel.Location = new System.Drawing.Point(0, 105);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.infoPanel.Size = new System.Drawing.Size(314, 564);
            this.infoPanel.TabIndex = 1;
            // 
            // priceGB
            // 
            this.priceGB.Controls.Add(this.selectedPriceBtn);
            this.priceGB.Controls.Add(this.label2);
            this.priceGB.Controls.Add(this.priceToTxt);
            this.priceGB.Controls.Add(this.priceFromTxt);
            this.priceGB.Dock = System.Windows.Forms.DockStyle.Top;
            this.priceGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceGB.Location = new System.Drawing.Point(3, 10);
            this.priceGB.Name = "priceGB";
            this.priceGB.Size = new System.Drawing.Size(308, 80);
            this.priceGB.TabIndex = 1;
            this.priceGB.TabStop = false;
            this.priceGB.Text = "Ціна";
            // 
            // selectedPriceBtn
            // 
            this.selectedPriceBtn.Location = new System.Drawing.Point(230, 35);
            this.selectedPriceBtn.Name = "selectedPriceBtn";
            this.selectedPriceBtn.Size = new System.Drawing.Size(72, 38);
            this.selectedPriceBtn.TabIndex = 2;
            this.selectedPriceBtn.Text = "OK";
            this.selectedPriceBtn.UseVisualStyleBackColor = true;
            this.selectedPriceBtn.Click += new System.EventHandler(this.selectedPriceBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "-";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // priceToTxt
            // 
            this.priceToTxt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.priceToTxt.Location = new System.Drawing.Point(126, 36);
            this.priceToTxt.Name = "priceToTxt";
            this.priceToTxt.Size = new System.Drawing.Size(97, 34);
            this.priceToTxt.TabIndex = 3;
            this.priceToTxt.TextChanged += new System.EventHandler(this.PriceFieldsValidation_TextChanged);
            this.priceToTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.WriteOnlyNumbers_KeyPress);
            // 
            // priceFromTxt
            // 
            this.priceFromTxt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.priceFromTxt.Location = new System.Drawing.Point(3, 36);
            this.priceFromTxt.Name = "priceFromTxt";
            this.priceFromTxt.Size = new System.Drawing.Size(95, 34);
            this.priceFromTxt.TabIndex = 2;
            this.priceFromTxt.TextChanged += new System.EventHandler(this.PriceFieldsValidation_TextChanged);
            this.priceFromTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.WriteOnlyNumbers_KeyPress);
            // 
            // brandGB
            // 
            this.brandGB.AutoSize = true;
            this.brandGB.Dock = System.Windows.Forms.DockStyle.Top;
            this.brandGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.brandGB.Location = new System.Drawing.Point(3, 5);
            this.brandGB.Name = "brandGB";
            this.brandGB.Size = new System.Drawing.Size(308, 5);
            this.brandGB.TabIndex = 0;
            this.brandGB.TabStop = false;
            this.brandGB.Text = "Бренд";
            // 
            // typeOfSweetsGB
            // 
            this.typeOfSweetsGB.AutoSize = true;
            this.typeOfSweetsGB.Dock = System.Windows.Forms.DockStyle.Top;
            this.typeOfSweetsGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeOfSweetsGB.Location = new System.Drawing.Point(3, 0);
            this.typeOfSweetsGB.Name = "typeOfSweetsGB";
            this.typeOfSweetsGB.Size = new System.Drawing.Size(308, 5);
            this.typeOfSweetsGB.TabIndex = 0;
            this.typeOfSweetsGB.TabStop = false;
            this.typeOfSweetsGB.Text = "Вид солодощів";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.nothingFoundedLabel);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(314, 105);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(744, 564);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // nothingFoundedLabel
            // 
            this.nothingFoundedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nothingFoundedLabel.Location = new System.Drawing.Point(3, 0);
            this.nothingFoundedLabel.Name = "nothingFoundedLabel";
            this.nothingFoundedLabel.Size = new System.Drawing.Size(741, 116);
            this.nothingFoundedLabel.TabIndex = 0;
            this.nothingFoundedLabel.Text = "Нічого не знайдено";
            this.nothingFoundedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nothingFoundedLabel.Visible = false;
            // 
            // delBtn
            // 
            this.delBtn.Location = new System.Drawing.Point(0, 35);
            this.delBtn.Margin = new System.Windows.Forms.Padding(0);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(120, 35);
            this.delBtn.TabIndex = 1;
            this.delBtn.Text = "Видалити";
            this.delBtn.UseVisualStyleBackColor = true;
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(0, 0);
            this.editBtn.Margin = new System.Windows.Forms.Padding(0);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(120, 35);
            this.editBtn.TabIndex = 0;
            this.editBtn.Text = "Редагувати";
            this.editBtn.UseVisualStyleBackColor = true;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 669);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.infoPanel);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximumSize = new System.Drawing.Size(1080, 720);
            this.MinimumSize = new System.Drawing.Size(1080, 720);
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shop";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.headerPanel.ResumeLayout(false);
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.backPanelSearchTxt.ResumeLayout(false);
            this.backPanelSearchTxt.PerformLayout();
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            this.priceGB.ResumeLayout(false);
            this.priceGB.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.Label logoTxt;
        private System.Windows.Forms.Panel backPanelSearchTxt;
        private System.Windows.Forms.TextBox searchTxt;
        private System.Windows.Forms.Button seatchBtn;
        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.GroupBox typeOfSweetsGB;
        private System.Windows.Forms.GroupBox priceGB;
        private System.Windows.Forms.Button selectedPriceBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox priceToTxt;
        private System.Windows.Forms.TextBox priceFromTxt;
        private System.Windows.Forms.GroupBox brandGB;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button addNewProductBtn;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Label nothingFoundedLabel;
    }
}

