namespace WindowsFormsApplication3
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
            this.WishList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.clearBtn = new System.Windows.Forms.Button();
            this.fillBtn = new System.Windows.Forms.Button();
            this.countBtn = new System.Windows.Forms.Button();
            this.selection = new System.Windows.Forms.Label();
            this.selectionBox = new System.Windows.Forms.TextBox();
            this.Counttxt = new System.Windows.Forms.Label();
            this.Datab = new System.Windows.Forms.TextBox();
            this.sortBtn = new System.Windows.Forms.Button();
            this.CLoseBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WishList
            // 
            this.WishList.FormattingEnabled = true;
            this.WishList.Location = new System.Drawing.Point(33, 88);
            this.WishList.Name = "WishList";
            this.WishList.Size = new System.Drawing.Size(150, 199);
            this.WishList.TabIndex = 0;
            this.WishList.SelectedIndexChanged += new System.EventHandler(this.WishList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wish List";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(228, 169);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 2;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // fillBtn
            // 
            this.fillBtn.Location = new System.Drawing.Point(228, 88);
            this.fillBtn.Name = "fillBtn";
            this.fillBtn.Size = new System.Drawing.Size(75, 23);
            this.fillBtn.TabIndex = 3;
            this.fillBtn.Text = "Fill";
            this.fillBtn.UseVisualStyleBackColor = true;
            this.fillBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // countBtn
            // 
            this.countBtn.Location = new System.Drawing.Point(228, 208);
            this.countBtn.Name = "countBtn";
            this.countBtn.Size = new System.Drawing.Size(75, 23);
            this.countBtn.TabIndex = 4;
            this.countBtn.Text = "Count";
            this.countBtn.UseVisualStyleBackColor = true;
            this.countBtn.Click += new System.EventHandler(this.countBtn_Click);
            // 
            // selection
            // 
            this.selection.AutoSize = true;
            this.selection.Location = new System.Drawing.Point(30, 328);
            this.selection.Name = "selection";
            this.selection.Size = new System.Drawing.Size(54, 13);
            this.selection.TabIndex = 6;
            this.selection.Text = "Selection:";
            // 
            // selectionBox
            // 
            this.selectionBox.Location = new System.Drawing.Point(90, 325);
            this.selectionBox.Name = "selectionBox";
            this.selectionBox.Size = new System.Drawing.Size(123, 20);
            this.selectionBox.TabIndex = 7;
            this.selectionBox.TextChanged += new System.EventHandler(this.selectionBox_TextChanged);
            // 
            // Counttxt
            // 
            this.Counttxt.AutoSize = true;
            this.Counttxt.Location = new System.Drawing.Point(30, 365);
            this.Counttxt.Name = "Counttxt";
            this.Counttxt.Size = new System.Drawing.Size(38, 13);
            this.Counttxt.TabIndex = 8;
            this.Counttxt.Text = "Count:";
            // 
            // Datab
            // 
            this.Datab.Location = new System.Drawing.Point(90, 362);
            this.Datab.Name = "Datab";
            this.Datab.Size = new System.Drawing.Size(123, 20);
            this.Datab.TabIndex = 9;
            this.Datab.TextChanged += new System.EventHandler(this.Datab_TextChanged);
            // 
            // sortBtn
            // 
            this.sortBtn.Location = new System.Drawing.Point(228, 126);
            this.sortBtn.Name = "sortBtn";
            this.sortBtn.Size = new System.Drawing.Size(75, 23);
            this.sortBtn.TabIndex = 10;
            this.sortBtn.Text = "Sort";
            this.sortBtn.UseVisualStyleBackColor = true;
            this.sortBtn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // CLoseBtn
            // 
            this.CLoseBtn.Location = new System.Drawing.Point(228, 254);
            this.CLoseBtn.Name = "CLoseBtn";
            this.CLoseBtn.Size = new System.Drawing.Size(75, 23);
            this.CLoseBtn.TabIndex = 11;
            this.CLoseBtn.Text = "Close";
            this.CLoseBtn.UseVisualStyleBackColor = true;
            this.CLoseBtn.Click += new System.EventHandler(this.CLoseBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 442);
            this.Controls.Add(this.CLoseBtn);
            this.Controls.Add(this.sortBtn);
            this.Controls.Add(this.Datab);
            this.Controls.Add(this.Counttxt);
            this.Controls.Add(this.selectionBox);
            this.Controls.Add(this.selection);
            this.Controls.Add(this.countBtn);
            this.Controls.Add(this.fillBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WishList);
            this.Name = "Form1";
            this.Text = "Parawan Wish List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox WishList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button fillBtn;
        private System.Windows.Forms.Button countBtn;
        private System.Windows.Forms.Label selection;
        private System.Windows.Forms.TextBox selectionBox;
        private System.Windows.Forms.Label Counttxt;
        private System.Windows.Forms.TextBox Datab;
        private System.Windows.Forms.Button sortBtn;
        private System.Windows.Forms.Button CLoseBtn;
    }
}

