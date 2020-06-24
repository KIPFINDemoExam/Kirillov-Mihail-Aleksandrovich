namespace DoeduSam
{
    partial class AddProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProductForm));
            this.ProductName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ProductDescription = new System.Windows.Forms.TextBox();
            this.ProductCoast = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.TextBox();
            this.AddProductPhoto = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.ProductManufacturer = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ProductCoast)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductName
            // 
            this.ProductName.Location = new System.Drawing.Point(252, 92);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(155, 20);
            this.ProductName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Описание";
            // 
            // ProductDescription
            // 
            this.ProductDescription.Location = new System.Drawing.Point(252, 195);
            this.ProductDescription.Name = "ProductDescription";
            this.ProductDescription.Size = new System.Drawing.Size(155, 20);
            this.ProductDescription.TabIndex = 2;
            // 
            // ProductCoast
            // 
            this.ProductCoast.Location = new System.Drawing.Point(252, 244);
            this.ProductCoast.Name = "ProductCoast";
            this.ProductCoast.Size = new System.Drawing.Size(155, 20);
            this.ProductCoast.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(249, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Цена";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(28, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(143, 122);
            this.panel1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(249, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Производитель";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(249, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Идентификатор";
            // 
            // Id
            // 
            this.Id.Location = new System.Drawing.Point(252, 43);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(69, 20);
            this.Id.TabIndex = 10;
            // 
            // AddProductPhoto
            // 
            this.AddProductPhoto.Location = new System.Drawing.Point(28, 174);
            this.AddProductPhoto.Name = "AddProductPhoto";
            this.AddProductPhoto.Size = new System.Drawing.Size(143, 23);
            this.AddProductPhoto.TabIndex = 12;
            this.AddProductPhoto.Text = "Добавить фотографию";
            this.AddProductPhoto.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(252, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(252, 280);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(68, 17);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "Активен";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(342, 312);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(65, 23);
            this.Cancel.TabIndex = 15;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // ProductManufacturer
            // 
            this.ProductManufacturer.FormattingEnabled = true;
            this.ProductManufacturer.Location = new System.Drawing.Point(252, 145);
            this.ProductManufacturer.Name = "ProductManufacturer";
            this.ProductManufacturer.Size = new System.Drawing.Size(155, 21);
            this.ProductManufacturer.TabIndex = 16;
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 373);
            this.Controls.Add(this.ProductManufacturer);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AddProductPhoto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ProductCoast);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ProductDescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProductName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddProductForm";
            this.Text = "Добавить товар";
            this.Load += new System.EventHandler(this.AddProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductCoast)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ProductName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ProductDescription;
        private System.Windows.Forms.NumericUpDown ProductCoast;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Id;
        private System.Windows.Forms.Button AddProductPhoto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.ComboBox ProductManufacturer;
    }
}