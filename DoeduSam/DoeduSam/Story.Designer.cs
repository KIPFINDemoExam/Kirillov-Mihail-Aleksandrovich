namespace DoeduSam
{
    partial class Story
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Story));
            this.StoryList = new System.Windows.Forms.ListView();
            this.ProductFilter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ReturnToProductsList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StoryList
            // 
            this.StoryList.HideSelection = false;
            this.StoryList.Location = new System.Drawing.Point(12, 54);
            this.StoryList.Name = "StoryList";
            this.StoryList.Size = new System.Drawing.Size(544, 403);
            this.StoryList.TabIndex = 1;
            this.StoryList.UseCompatibleStateImageBehavior = false;
            // 
            // ProductFilter
            // 
            this.ProductFilter.FormattingEnabled = true;
            this.ProductFilter.Location = new System.Drawing.Point(12, 27);
            this.ProductFilter.Name = "ProductFilter";
            this.ProductFilter.Size = new System.Drawing.Size(121, 21);
            this.ProductFilter.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Товар";
            // 
            // ReturnToProductsList
            // 
            this.ReturnToProductsList.Location = new System.Drawing.Point(139, 27);
            this.ReturnToProductsList.Name = "ReturnToProductsList";
            this.ReturnToProductsList.Size = new System.Drawing.Size(75, 23);
            this.ReturnToProductsList.TabIndex = 4;
            this.ReturnToProductsList.Text = "Назад";
            this.ReturnToProductsList.UseVisualStyleBackColor = true;
            this.ReturnToProductsList.Click += new System.EventHandler(this.ReturnToProductsList_Click);
            // 
            // Story
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 475);
            this.Controls.Add(this.ReturnToProductsList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProductFilter);
            this.Controls.Add(this.StoryList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Story";
            this.Text = "История продаж";
            this.Load += new System.EventHandler(this.Story_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView StoryList;
        private System.Windows.Forms.ComboBox ProductFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ReturnToProductsList;
    }
}