
namespace Housing_Prediction_Value_Tool
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textboxRooms = new System.Windows.Forms.TextBox();
            this.textboxValue = new System.Windows.Forms.TextBox();
            this.textboxType = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.labelNumData = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(423, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(365, 319);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(423, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(365, 27);
            this.button1.TabIndex = 1;
            this.button1.Text = "EXPORT TO CSV";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number of Rooms";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(409, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Property Type (h-house, th-terraced house, f-flat, b-bungalow, u-undefined)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Value of Property";
            // 
            // textboxRooms
            // 
            this.textboxRooms.Location = new System.Drawing.Point(12, 73);
            this.textboxRooms.MaxLength = 9;
            this.textboxRooms.Name = "textboxRooms";
            this.textboxRooms.Size = new System.Drawing.Size(100, 23);
            this.textboxRooms.TabIndex = 5;
            this.textboxRooms.Text = "Min no rooms";
            this.textboxRooms.TextChanged += new System.EventHandler(this.textboxRooms_TextChanged);
            // 
            // textboxValue
            // 
            this.textboxValue.Location = new System.Drawing.Point(12, 160);
            this.textboxValue.Name = "textboxValue";
            this.textboxValue.Size = new System.Drawing.Size(100, 23);
            this.textboxValue.TabIndex = 6;
            // 
            // textboxType
            // 
            this.textboxType.Location = new System.Drawing.Point(12, 222);
            this.textboxType.Name = "textboxType";
            this.textboxType.Size = new System.Drawing.Size(100, 23);
            this.textboxType.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 337);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(405, 27);
            this.button2.TabIndex = 8;
            this.button2.Text = "SUBMIT TO DATATABLE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelNumData
            // 
            this.labelNumData.AutoSize = true;
            this.labelNumData.Location = new System.Drawing.Point(281, 12);
            this.labelNumData.Name = "labelNumData";
            this.labelNumData.Size = new System.Drawing.Size(115, 15);
            this.labelNumData.TabIndex = 9;
            this.labelNumData.Text = "Number of Entries: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 376);
            this.Controls.Add(this.labelNumData);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textboxType);
            this.Controls.Add(this.textboxValue);
            this.Controls.Add(this.textboxRooms);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Housing Prediction Value tool (HPVt)";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textboxRooms;
        private System.Windows.Forms.TextBox textboxValue;
        private System.Windows.Forms.TextBox textboxType;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelNumData;
    }
}

