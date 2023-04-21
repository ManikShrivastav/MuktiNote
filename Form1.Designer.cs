namespace VisualProgrammingManik
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
            this.Project = new System.Windows.Forms.Label();
            this.titlelabel = new System.Windows.Forms.Label();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txttitle = new System.Windows.Forms.TextBox();
            this.txtmessage = new System.Windows.Forms.TextBox();
            this.Addbtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.ReadBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.designer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Project
            // 
            this.Project.AutoSize = true;
            this.Project.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Project.Location = new System.Drawing.Point(195, 21);
            this.Project.Name = "Project";
            this.Project.Size = new System.Drawing.Size(197, 28);
            this.Project.TabIndex = 0;
            this.Project.Text = "Note Taking App";
            // 
            // titlelabel
            // 
            this.titlelabel.AutoSize = true;
            this.titlelabel.Location = new System.Drawing.Point(24, 84);
            this.titlelabel.Name = "titlelabel";
            this.titlelabel.Size = new System.Drawing.Size(38, 20);
            this.titlelabel.TabIndex = 1;
            this.titlelabel.Text = "Title";
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Location = new System.Drawing.Point(24, 159);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(67, 20);
            this.MessageLabel.TabIndex = 2;
            this.MessageLabel.Text = "Message";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(374, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(187, 183);
            this.dataGridView1.TabIndex = 3;
            // 
            // txttitle
            // 
            this.txttitle.Location = new System.Drawing.Point(132, 84);
            this.txttitle.Name = "txttitle";
            this.txttitle.Size = new System.Drawing.Size(217, 27);
            this.txttitle.TabIndex = 4;
            // 
            // txtmessage
            // 
            this.txtmessage.Location = new System.Drawing.Point(132, 159);
            this.txtmessage.Multiline = true;
            this.txtmessage.Name = "txtmessage";
            this.txtmessage.Size = new System.Drawing.Size(217, 165);
            this.txtmessage.TabIndex = 5;
            // 
            // Addbtn
            // 
            this.Addbtn.Location = new System.Drawing.Point(73, 395);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(94, 29);
            this.Addbtn.TabIndex = 6;
            this.Addbtn.Tag = "";
            this.Addbtn.Text = "New";
            this.Addbtn.UseVisualStyleBackColor = true;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(195, 395);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(94, 29);
            this.SaveBtn.TabIndex = 7;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // ReadBtn
            // 
            this.ReadBtn.Location = new System.Drawing.Point(311, 395);
            this.ReadBtn.Name = "ReadBtn";
            this.ReadBtn.Size = new System.Drawing.Size(94, 29);
            this.ReadBtn.TabIndex = 8;
            this.ReadBtn.Text = "Read";
            this.ReadBtn.UseVisualStyleBackColor = true;
            this.ReadBtn.Click += new System.EventHandler(this.ReadBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(426, 395);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(94, 29);
            this.DeleteBtn.TabIndex = 9;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // designer
            // 
            this.designer.AutoSize = true;
            this.designer.Font = new System.Drawing.Font("Kristen ITC", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.designer.Location = new System.Drawing.Point(424, 449);
            this.designer.Name = "designer";
            this.designer.Size = new System.Drawing.Size(137, 18);
            this.designer.TabIndex = 10;
            this.designer.Text = "By Manik Shrivastav";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 495);
            this.Controls.Add(this.designer);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.ReadBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.Addbtn);
            this.Controls.Add(this.txtmessage);
            this.Controls.Add(this.txttitle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.MessageLabel);
            this.Controls.Add(this.titlelabel);
            this.Controls.Add(this.Project);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Project;
        private Label titlelabel;
        private Label MessageLabel;
        private DataGridView dataGridView1;
        private TextBox txttitle;
        private TextBox txtmessage;
        private Button Addbtn;
        private Button SaveBtn;
        private Button ReadBtn;
        private Button DeleteBtn;
        private Label designer;
    }
}