﻿namespace ContractOK
{
    partial class DetectedDisplay
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Method");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Class", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Namespace", new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.lbFixed01 = new System.Windows.Forms.Label();
            this.lbSetNumberNonconformances = new System.Windows.Forms.Label();
            this.lbFixed02 = new System.Windows.Forms.Label();
            this.lbFixed03 = new System.Windows.Forms.Label();
            this.listBox = new System.Windows.Forms.ListBox();
            this.lbFixed04 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tbTextSample = new System.Windows.Forms.TextBox();
            this.lbFixed05 = new System.Windows.Forms.Label();
            this.btSaveResults = new System.Windows.Forms.Button();
            this.btStackTrace = new System.Windows.Forms.Button();
            this.btCategorize = new System.Windows.Forms.Button();
            this.saveResultsBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // lbFixed01
            // 
            this.lbFixed01.AutoSize = true;
            this.lbFixed01.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbFixed01.Location = new System.Drawing.Point(23, 16);
            this.lbFixed01.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFixed01.Name = "lbFixed01";
            this.lbFixed01.Size = new System.Drawing.Size(118, 20);
            this.lbFixed01.TabIndex = 0;
            this.lbFixed01.Text = "Were detected";
            // 
            // lbSetNumberNonconformances
            // 
            this.lbSetNumberNonconformances.AutoSize = true;
            this.lbSetNumberNonconformances.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbSetNumberNonconformances.Location = new System.Drawing.Point(183, 16);
            this.lbSetNumberNonconformances.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSetNumberNonconformances.Name = "lbSetNumberNonconformances";
            this.lbSetNumberNonconformances.Size = new System.Drawing.Size(18, 20);
            this.lbSetNumberNonconformances.TabIndex = 1;
            this.lbSetNumberNonconformances.Text = "0";
            // 
            // lbFixed02
            // 
            this.lbFixed02.AutoSize = true;
            this.lbFixed02.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbFixed02.Location = new System.Drawing.Point(215, 16);
            this.lbFixed02.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFixed02.Name = "lbFixed02";
            this.lbFixed02.Size = new System.Drawing.Size(146, 20);
            this.lbFixed02.TabIndex = 2;
            this.lbFixed02.Text = "nonconformances.";
            // 
            // lbFixed03
            // 
            this.lbFixed03.AutoSize = true;
            this.lbFixed03.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbFixed03.Location = new System.Drawing.Point(57, 53);
            this.lbFixed03.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFixed03.Name = "lbFixed03";
            this.lbFixed03.Size = new System.Drawing.Size(145, 20);
            this.lbFixed03.TabIndex = 3;
            this.lbFixed03.Text = "Nonconformances";
            // 
            // listBox
            // 
            this.listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 17;
            this.listBox.Location = new System.Drawing.Point(24, 82);
            this.listBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(255, 310);
            this.listBox.TabIndex = 4;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lbFixed04
            // 
            this.lbFixed04.AutoSize = true;
            this.lbFixed04.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbFixed04.Location = new System.Drawing.Point(329, 53);
            this.lbFixed04.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFixed04.Name = "lbFixed04";
            this.lbFixed04.Size = new System.Drawing.Size(73, 20);
            this.lbFixed04.TabIndex = 5;
            this.lbFixed04.Text = "Location";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(307, 82);
            this.treeView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "SetMethod";
            treeNode1.Text = "Method";
            treeNode2.Name = "SetClass";
            treeNode2.Text = "Class";
            treeNode3.Name = "SetNamespace";
            treeNode3.Text = "Namespace";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.treeView1.Size = new System.Drawing.Size(241, 174);
            this.treeView1.TabIndex = 6;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // tbTextSample
            // 
            this.tbTextSample.Location = new System.Drawing.Point(583, 82);
            this.tbTextSample.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbTextSample.Multiline = true;
            this.tbTextSample.Name = "tbTextSample";
            this.tbTextSample.Size = new System.Drawing.Size(472, 319);
            this.tbTextSample.TabIndex = 7;
            // 
            // lbFixed05
            // 
            this.lbFixed05.AutoSize = true;
            this.lbFixed05.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lbFixed05.Location = new System.Drawing.Point(603, 53);
            this.lbFixed05.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFixed05.Name = "lbFixed05";
            this.lbFixed05.Size = new System.Drawing.Size(103, 20);
            this.lbFixed05.TabIndex = 8;
            this.lbFixed05.Text = "Test Sample";
            // 
            // btSaveResults
            // 
            this.btSaveResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btSaveResults.Location = new System.Drawing.Point(49, 438);
            this.btSaveResults.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btSaveResults.Name = "btSaveResults";
            this.btSaveResults.Size = new System.Drawing.Size(192, 39);
            this.btSaveResults.TabIndex = 9;
            this.btSaveResults.Text = "Save Results";
            this.btSaveResults.UseVisualStyleBackColor = true;
            this.btSaveResults.Click += new System.EventHandler(this.btSaveResults_Click);
            // 
            // btStackTrace
            // 
            this.btStackTrace.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btStackTrace.Location = new System.Drawing.Point(341, 438);
            this.btStackTrace.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btStackTrace.Name = "btStackTrace";
            this.btStackTrace.Size = new System.Drawing.Size(179, 38);
            this.btStackTrace.TabIndex = 10;
            this.btStackTrace.Text = "StackTrace";
            this.btStackTrace.UseVisualStyleBackColor = true;
            this.btStackTrace.Click += new System.EventHandler(this.btStackTrace_Click);
            // 
            // btCategorize
            // 
            this.btCategorize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btCategorize.Location = new System.Drawing.Point(721, 438);
            this.btCategorize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btCategorize.Name = "btCategorize";
            this.btCategorize.Size = new System.Drawing.Size(200, 39);
            this.btCategorize.TabIndex = 12;
            this.btCategorize.Text = "Categorize";
            this.btCategorize.UseVisualStyleBackColor = true;
            this.btCategorize.Click += new System.EventHandler(this.btCategorize_Click);
            // 
            // DetectedDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 505);
            this.Controls.Add(this.btCategorize);
            this.Controls.Add(this.btStackTrace);
            this.Controls.Add(this.btSaveResults);
            this.Controls.Add(this.lbFixed05);
            this.Controls.Add(this.tbTextSample);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.lbFixed04);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.lbFixed03);
            this.Controls.Add(this.lbFixed02);
            this.Controls.Add(this.lbSetNumberNonconformances);
            this.Controls.Add(this.lbFixed01);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "DetectedDisplay";
            this.Text = "Detection Screen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbFixed01;
        private System.Windows.Forms.Label lbSetNumberNonconformances;
        private System.Windows.Forms.Label lbFixed02;
        private System.Windows.Forms.Label lbFixed03;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label lbFixed04;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TextBox tbTextSample;
        private System.Windows.Forms.Label lbFixed05;
        private System.Windows.Forms.Button btSaveResults;
        private System.Windows.Forms.Button btStackTrace;
        private System.Windows.Forms.Button btCategorize;
        private System.Windows.Forms.FolderBrowserDialog saveResultsBrowser;
    }
}