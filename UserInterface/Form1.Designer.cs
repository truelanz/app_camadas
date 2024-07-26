namespace UserInterface
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataUser = new System.Windows.Forms.DataGridView();
            this.ADD = new System.Windows.Forms.Button();
            this.UPDATE = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textAge = new System.Windows.Forms.TextBox();
            this.comboSex = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataUser)).BeginInit();
            this.SuspendLayout();
            // 
            // textName
            // 
            this.textName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textName.Location = new System.Drawing.Point(121, 27);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(484, 23);
            this.textName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "User Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(146, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "Age";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(374, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 14);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sex";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dataUser
            // 
            this.dataUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataUser.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataUser.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataUser.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataUser.EnableHeadersVisualStyles = false;
            this.dataUser.GridColor = System.Drawing.Color.Black;
            this.dataUser.Location = new System.Drawing.Point(58, 187);
            this.dataUser.Name = "dataUser";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataUser.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataUser.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataUser.RowTemplate.Height = 50;
            this.dataUser.Size = new System.Drawing.Size(564, 179);
            this.dataUser.TabIndex = 6;
            this.dataUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataUser_CellContentClick);
            // 
            // ADD
            // 
            this.ADD.BackColor = System.Drawing.Color.LightGreen;
            this.ADD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADD.Location = new System.Drawing.Point(58, 141);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(95, 30);
            this.ADD.TabIndex = 7;
            this.ADD.Text = "ADD";
            this.ADD.UseVisualStyleBackColor = false;
            this.ADD.Click += new System.EventHandler(this.ADD_Click);
            // 
            // UPDATE
            // 
            this.UPDATE.BackColor = System.Drawing.Color.LightSkyBlue;
            this.UPDATE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UPDATE.Location = new System.Drawing.Point(293, 141);
            this.UPDATE.Name = "UPDATE";
            this.UPDATE.Size = new System.Drawing.Size(98, 30);
            this.UPDATE.TabIndex = 8;
            this.UPDATE.Text = "UPDATE";
            this.UPDATE.UseVisualStyleBackColor = false;
            this.UPDATE.Click += new System.EventHandler(this.UPDATE_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Tomato;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(519, 141);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 30);
            this.button3.TabIndex = 9;
            this.button3.Text = "REMOVE";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.REMOVE_Click);
            // 
            // textAge
            // 
            this.textAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textAge.Location = new System.Drawing.Point(179, 70);
            this.textAge.Name = "textAge";
            this.textAge.Size = new System.Drawing.Size(120, 23);
            this.textAge.TabIndex = 10;
            // 
            // comboSex
            // 
            this.comboSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboSex.FormattingEnabled = true;
            this.comboSex.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.comboSex.Location = new System.Drawing.Point(408, 71);
            this.comboSex.Name = "comboSex";
            this.comboSex.Size = new System.Drawing.Size(127, 24);
            this.comboSex.TabIndex = 11;
            this.comboSex.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(678, 511);
            this.Controls.Add(this.comboSex);
            this.Controls.Add(this.textAge);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.UPDATE);
            this.Controls.Add(this.ADD);
            this.Controls.Add(this.dataUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textName);
            this.Name = "Form1";
            this.Text = "USERS";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataUser;
        private System.Windows.Forms.Button ADD;
        private System.Windows.Forms.Button UPDATE;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textAge;
        private System.Windows.Forms.ComboBox comboSex;
    }
}

