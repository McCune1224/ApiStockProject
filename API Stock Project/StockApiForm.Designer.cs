namespace API_Stock_Project
{
    partial class StockApiForm
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
            this.components = new System.ComponentModel.Container();
            this.outputInfoBox = new System.Windows.Forms.TextBox();
            this.stockInfoCollectionButton = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // outputInfoBox
            // 
            this.outputInfoBox.Location = new System.Drawing.Point(55, 85);
            this.outputInfoBox.Multiline = true;
            this.outputInfoBox.Name = "outputInfoBox";
            this.outputInfoBox.Size = new System.Drawing.Size(368, 234);
            this.outputInfoBox.TabIndex = 0;
            // 
            // stockInfoCollectionButton
            // 
            this.stockInfoCollectionButton.Location = new System.Drawing.Point(471, 185);
            this.stockInfoCollectionButton.Name = "stockInfoCollectionButton";
            this.stockInfoCollectionButton.Size = new System.Drawing.Size(122, 23);
            this.stockInfoCollectionButton.TabIndex = 1;
            this.stockInfoCollectionButton.Text = "Get Stock Info";
            this.stockInfoCollectionButton.UseVisualStyleBackColor = true;
            this.stockInfoCollectionButton.Click += new System.EventHandler(this.stockInfoCollectionButton_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(483, 101);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(480, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Insert Stock Symbol:\r\n";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // StockApiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.stockInfoCollectionButton);
            this.Controls.Add(this.outputInfoBox);
            this.Name = "StockApiForm";
            this.Text = "Stock Info API Form";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox outputInfoBox;
        private System.Windows.Forms.Button stockInfoCollectionButton;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

