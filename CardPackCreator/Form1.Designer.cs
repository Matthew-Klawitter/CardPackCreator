namespace CardPackCreator
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
            this.components = new System.ComponentModel.Container();
            this.listView = new System.Windows.Forms.ListView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.addItem = new System.Windows.Forms.Button();
            this.removeSelected = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.setBox = new System.Windows.Forms.TextBox();
            this.descBox = new System.Windows.Forms.TextBox();
            this.facBox = new System.Windows.Forms.TextBox();
            this.valBox = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.logBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.rareBox = new System.Windows.Forms.ComboBox();
            this.toolStripMenuLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.Location = new System.Drawing.Point(321, 27);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(356, 194);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(883, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem
            // 
            this.toolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuSave,
            this.toolStripMenuLoad});
            this.toolStripMenuItem.Name = "toolStripMenuItem";
            this.toolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem.Text = "File";
            // 
            // toolStripMenuSave
            // 
            this.toolStripMenuSave.Name = "toolStripMenuSave";
            this.toolStripMenuSave.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuSave.Text = "Save";
            this.toolStripMenuSave.Click += new System.EventHandler(this.toolStripMenuSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter information below to create a card:";
            // 
            // addItem
            // 
            this.addItem.Location = new System.Drawing.Point(321, 227);
            this.addItem.Name = "addItem";
            this.addItem.Size = new System.Drawing.Size(75, 23);
            this.addItem.TabIndex = 3;
            this.addItem.Text = "Add";
            this.addItem.UseVisualStyleBackColor = true;
            this.addItem.Click += new System.EventHandler(this.add_Click);
            // 
            // removeSelected
            // 
            this.removeSelected.Location = new System.Drawing.Point(402, 227);
            this.removeSelected.Name = "removeSelected";
            this.removeSelected.Size = new System.Drawing.Size(75, 23);
            this.removeSelected.TabIndex = 4;
            this.removeSelected.Text = "Remove";
            this.removeSelected.UseVisualStyleBackColor = true;
            this.removeSelected.Click += new System.EventHandler(this.remove_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Title:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Set:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Description:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Faction:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Rarity:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Value:";
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(79, 72);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(197, 20);
            this.titleBox.TabIndex = 11;
            // 
            // setBox
            // 
            this.setBox.Location = new System.Drawing.Point(79, 98);
            this.setBox.Name = "setBox";
            this.setBox.Size = new System.Drawing.Size(197, 20);
            this.setBox.TabIndex = 12;
            // 
            // descBox
            // 
            this.descBox.Location = new System.Drawing.Point(79, 123);
            this.descBox.Name = "descBox";
            this.descBox.Size = new System.Drawing.Size(197, 20);
            this.descBox.TabIndex = 13;
            // 
            // facBox
            // 
            this.facBox.Location = new System.Drawing.Point(79, 149);
            this.facBox.Name = "facBox";
            this.facBox.Size = new System.Drawing.Size(197, 20);
            this.facBox.TabIndex = 14;
            // 
            // valBox
            // 
            this.valBox.Location = new System.Drawing.Point(79, 201);
            this.valBox.Name = "valBox";
            this.valBox.Size = new System.Drawing.Size(197, 20);
            this.valBox.TabIndex = 16;
            // 
            // logBox
            // 
            this.logBox.Location = new System.Drawing.Point(12, 277);
            this.logBox.Multiline = true;
            this.logBox.Name = "logBox";
            this.logBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logBox.Size = new System.Drawing.Size(665, 69);
            this.logBox.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 261);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Log:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // rareBox
            // 
            this.rareBox.FormattingEnabled = true;
            this.rareBox.Items.AddRange(new object[] {
            "Common",
            "Uncommon",
            "Rare",
            "Ultra-Rare"});
            this.rareBox.Location = new System.Drawing.Point(79, 175);
            this.rareBox.Name = "rareBox";
            this.rareBox.Size = new System.Drawing.Size(197, 21);
            this.rareBox.TabIndex = 20;
            // 
            // toolStripMenuLoad
            // 
            this.toolStripMenuLoad.Name = "toolStripMenuLoad";
            this.toolStripMenuLoad.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuLoad.Text = "Load";
            this.toolStripMenuLoad.Click += new System.EventHandler(this.toolStripMenuLoad_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 358);
            this.Controls.Add(this.rareBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.valBox);
            this.Controls.Add(this.facBox);
            this.Controls.Add(this.descBox);
            this.Controls.Add(this.setBox);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.removeSelected);
            this.Controls.Add(this.addItem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "CafeTCG Card Creator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addItem;
        private System.Windows.Forms.Button removeSelected;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.TextBox setBox;
        private System.Windows.Forms.TextBox descBox;
        private System.Windows.Forms.TextBox facBox;
        private System.Windows.Forms.TextBox valBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox logBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ComboBox rareBox;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuLoad;
    }
}

