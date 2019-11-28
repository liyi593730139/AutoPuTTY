namespace AutoPuTTY
{
    partial class formMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
            this.tbPass = new System.Windows.Forms.TextBox();
            this.RightPanel = new System.Windows.Forms.Panel();
            this.bEye = new System.Windows.Forms.PictureBox();
            this.bOptions = new System.Windows.Forms.Button();
            this.lHost = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.tbHost = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lType = new System.Windows.Forms.Label();
            this.bDelete = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.bModify = new System.Windows.Forms.Button();
            this.lPass = new System.Windows.Forms.Label();
            this.lUser = new System.Windows.Forms.Label();
            this.lName = new System.Windows.Forms.Label();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmSystray = new System.Windows.Forms.ContextMenu();
            this.miRestore = new System.Windows.Forms.MenuItem();
            this.miClose = new System.Windows.Forms.MenuItem();
            this.cmList = new System.Windows.Forms.ContextMenu();
            this.pFind = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCase = new System.Windows.Forms.CheckBox();
            this.bClose = new System.Windows.Forms.PictureBox();
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.lbList = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.RightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bEye)).BeginInit();
            this.pFind.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bClose)).BeginInit();
            this.panel1.SuspendLayout();
            this.LeftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(23, 199);
            this.tbPass.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(323, 25);
            this.tbPass.TabIndex = 13;
            this.tbPass.UseSystemPasswordChar = true;
            this.tbPass.TextChanged += new System.EventHandler(this.tbPass_TextChanged);
            // 
            // RightPanel
            // 
            this.RightPanel.Controls.Add(this.bEye);
            this.RightPanel.Controls.Add(this.bOptions);
            this.RightPanel.Controls.Add(this.lHost);
            this.RightPanel.Controls.Add(this.cbType);
            this.RightPanel.Controls.Add(this.tbPass);
            this.RightPanel.Controls.Add(this.tbUser);
            this.RightPanel.Controls.Add(this.tbHost);
            this.RightPanel.Controls.Add(this.tbName);
            this.RightPanel.Controls.Add(this.lType);
            this.RightPanel.Controls.Add(this.bDelete);
            this.RightPanel.Controls.Add(this.bAdd);
            this.RightPanel.Controls.Add(this.bModify);
            this.RightPanel.Controls.Add(this.lPass);
            this.RightPanel.Controls.Add(this.lUser);
            this.RightPanel.Controls.Add(this.lName);
            this.RightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightPanel.Location = new System.Drawing.Point(576, 0);
            this.RightPanel.Margin = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(404, 409);
            this.RightPanel.TabIndex = 1;
            // 
            // bEye
            // 
            this.bEye.BackColor = System.Drawing.Color.Transparent;
            this.bEye.Image = global::AutoPuTTY.Properties.Resources.iconeyeshow;
            this.bEye.Location = new System.Drawing.Point(355, 199);
            this.bEye.Margin = new System.Windows.Forms.Padding(0);
            this.bEye.Name = "bEye";
            this.bEye.Size = new System.Drawing.Size(23, 25);
            this.bEye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.bEye.TabIndex = 21;
            this.bEye.TabStop = false;
            this.bEye.Click += new System.EventHandler(this.bEye_Click);
            this.bEye.DoubleClick += new System.EventHandler(this.bEye_Click);
            this.bEye.MouseEnter += new System.EventHandler(this.bEye_MouseEnter);
            this.bEye.MouseLeave += new System.EventHandler(this.bEye_MouseLeave);
            // 
            // bOptions
            // 
            this.bOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bOptions.Image = global::AutoPuTTY.Properties.Resources.iconoptions;
            this.bOptions.Location = new System.Drawing.Point(188, 320);
            this.bOptions.Margin = new System.Windows.Forms.Padding(0);
            this.bOptions.Name = "bOptions";
            this.bOptions.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.bOptions.Size = new System.Drawing.Size(43, 35);
            this.bOptions.TabIndex = 20;
            this.bOptions.UseCompatibleTextRendering = true;
            this.bOptions.UseVisualStyleBackColor = true;
            this.bOptions.Click += new System.EventHandler(this.bOptions_Click);
            // 
            // lHost
            // 
            this.lHost.AutoSize = true;
            this.lHost.Location = new System.Drawing.Point(24, 74);
            this.lHost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lHost.Name = "lHost";
            this.lHost.Size = new System.Drawing.Size(127, 15);
            this.lHost.TabIndex = 4;
            this.lHost.Text = "Hostname[:port]";
            // 
            // cbType
            // 
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(23, 250);
            this.cbType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(167, 23);
            this.cbType.TabIndex = 16;
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.cbType_SelectedIndexChanged);
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(23, 146);
            this.tbUser.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(355, 25);
            this.tbUser.TabIndex = 9;
            this.tbUser.TextChanged += new System.EventHandler(this.tbUser_TextChanged);
            // 
            // tbHost
            // 
            this.tbHost.Location = new System.Drawing.Point(23, 93);
            this.tbHost.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbHost.Name = "tbHost";
            this.tbHost.Size = new System.Drawing.Size(355, 25);
            this.tbHost.TabIndex = 6;
            this.tbHost.TextChanged += new System.EventHandler(this.tbHost_TextChanged);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(23, 40);
            this.tbName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(355, 25);
            this.tbName.TabIndex = 3;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // lType
            // 
            this.lType.AutoSize = true;
            this.lType.Location = new System.Drawing.Point(24, 232);
            this.lType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lType.Name = "lType";
            this.lType.Size = new System.Drawing.Size(39, 15);
            this.lType.TabIndex = 14;
            this.lType.Text = "Type";
            // 
            // bDelete
            // 
            this.bDelete.Enabled = false;
            this.bDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDelete.Image = global::AutoPuTTY.Properties.Resources.icondelete;
            this.bDelete.Location = new System.Drawing.Point(133, 320);
            this.bDelete.Margin = new System.Windows.Forms.Padding(0);
            this.bDelete.Name = "bDelete";
            this.bDelete.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.bDelete.Size = new System.Drawing.Size(43, 35);
            this.bDelete.TabIndex = 19;
            this.bDelete.UseCompatibleTextRendering = true;
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // bAdd
            // 
            this.bAdd.Enabled = false;
            this.bAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAdd.Image = global::AutoPuTTY.Properties.Resources.iconadd;
            this.bAdd.Location = new System.Drawing.Point(78, 320);
            this.bAdd.Margin = new System.Windows.Forms.Padding(0);
            this.bAdd.Name = "bAdd";
            this.bAdd.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.bAdd.Size = new System.Drawing.Size(43, 35);
            this.bAdd.TabIndex = 18;
            this.bAdd.UseCompatibleTextRendering = true;
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // bModify
            // 
            this.bModify.Enabled = false;
            this.bModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bModify.Image = global::AutoPuTTY.Properties.Resources.iconmodify;
            this.bModify.Location = new System.Drawing.Point(23, 320);
            this.bModify.Margin = new System.Windows.Forms.Padding(0);
            this.bModify.Name = "bModify";
            this.bModify.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.bModify.Size = new System.Drawing.Size(43, 35);
            this.bModify.TabIndex = 17;
            this.bModify.UseCompatibleTextRendering = true;
            this.bModify.UseVisualStyleBackColor = true;
            this.bModify.Click += new System.EventHandler(this.bModify_Click);
            // 
            // lPass
            // 
            this.lPass.AutoSize = true;
            this.lPass.Location = new System.Drawing.Point(24, 180);
            this.lPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lPass.Name = "lPass";
            this.lPass.Size = new System.Drawing.Size(71, 15);
            this.lPass.TabIndex = 10;
            this.lPass.Text = "Password";
            // 
            // lUser
            // 
            this.lUser.AutoSize = true;
            this.lUser.Location = new System.Drawing.Point(24, 127);
            this.lUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lUser.Name = "lUser";
            this.lUser.Size = new System.Drawing.Size(71, 15);
            this.lUser.TabIndex = 7;
            this.lUser.Text = "Username";
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(24, 21);
            this.lName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(39, 15);
            this.lName.TabIndex = 0;
            this.lName.Text = "Name";
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "AutoPuTTY";
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseClick);
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // cmSystray
            // 
            this.cmSystray.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.miRestore,
            this.miClose});
            // 
            // miRestore
            // 
            this.miRestore.Enabled = false;
            this.miRestore.Index = 0;
            this.miRestore.Text = "Restore";
            this.miRestore.Click += new System.EventHandler(this.miRestore_Click);
            // 
            // miClose
            // 
            this.miClose.Index = 1;
            this.miClose.Text = "Close";
            this.miClose.Click += new System.EventHandler(this.miClose_Click);
            // 
            // pFind
            // 
            this.pFind.BackColor = System.Drawing.Color.Transparent;
            this.pFind.Controls.Add(this.label1);
            this.pFind.Controls.Add(this.cbCase);
            this.pFind.Controls.Add(this.bClose);
            this.pFind.Controls.Add(this.tbFilter);
            this.pFind.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pFind.Location = new System.Drawing.Point(5, 375);
            this.pFind.Margin = new System.Windows.Forms.Padding(0);
            this.pFind.Name = "pFind";
            this.pFind.Size = new System.Drawing.Size(566, 29);
            this.pFind.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(566, 1);
            this.label1.TabIndex = 8;
            // 
            // cbCase
            // 
            this.cbCase.AutoSize = true;
            this.cbCase.Location = new System.Drawing.Point(232, 6);
            this.cbCase.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbCase.Name = "cbCase";
            this.cbCase.Size = new System.Drawing.Size(109, 19);
            this.cbCase.TabIndex = 7;
            this.cbCase.Text = "Match case";
            this.cbCase.UseVisualStyleBackColor = true;
            this.cbCase.CheckedChanged += new System.EventHandler(this.cbCase_CheckedChanged);
            // 
            // bClose
            // 
            this.bClose.BackColor = System.Drawing.Color.Transparent;
            this.bClose.Image = global::AutoPuTTY.Properties.Resources.close;
            this.bClose.Location = new System.Drawing.Point(3, 3);
            this.bClose.Margin = new System.Windows.Forms.Padding(0);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(27, 23);
            this.bClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.bClose.TabIndex = 6;
            this.bClose.TabStop = false;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            this.bClose.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bClose_MouseDown);
            this.bClose.MouseEnter += new System.EventHandler(this.bClose_MouseEnter);
            this.bClose.MouseLeave += new System.EventHandler(this.bClose_MouseLeave);
            // 
            // tbFilter
            // 
            this.tbFilter.Location = new System.Drawing.Point(32, 3);
            this.tbFilter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.Size = new System.Drawing.Size(141, 25);
            this.tbFilter.TabIndex = 4;
            this.tbFilter.TextChanged += new System.EventHandler(this.tbFilter_Changed);
            this.tbFilter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbFilter_KeyDown);
            this.tbFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFilter_KeyPress);
            // 
            // lbList
            // 
            this.lbList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lbList.Font = new System.Drawing.Font("YaHei Consolas Hybrid", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbList.IntegralHeight = false;
            this.lbList.ItemHeight = 20;
            this.lbList.Location = new System.Drawing.Point(5, 5);
            this.lbList.Margin = new System.Windows.Forms.Padding(0);
            this.lbList.Name = "lbList";
            this.lbList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbList.Size = new System.Drawing.Size(566, 370);
            this.lbList.Sorted = true;
            this.lbList.TabIndex = 0;
            this.lbList.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lbList_DrawItem);
            this.lbList.SelectedIndexChanged += new System.EventHandler(this.lbList_IndexChanged);
            this.lbList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbList_KeyDown);
            this.lbList.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lbList_KeyPress);
            this.lbList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbList_DoubleClick);
            this.lbList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbList_MouseClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LeftPanel);
            this.panel1.Controls.Add(this.RightPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(980, 409);
            this.panel1.TabIndex = 22;
            // 
            // LeftPanel
            // 
            this.LeftPanel.Controls.Add(this.lbList);
            this.LeftPanel.Controls.Add(this.pFind);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Padding = new System.Windows.Forms.Padding(5);
            this.LeftPanel.Size = new System.Drawing.Size(576, 409);
            this.LeftPanel.TabIndex = 22;
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(980, 409);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "formMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "—©«¡∆Ô øPUTTYπ‹¿Ì∆˜";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mainForm_KeyDown);
            this.Resize += new System.EventHandler(this.mainForm_Resize);
            this.RightPanel.ResumeLayout(false);
            this.RightPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bEye)).EndInit();
            this.pFind.ResumeLayout(false);
            this.pFind.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bClose)).EndInit();
            this.panel1.ResumeLayout(false);
            this.LeftPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Panel RightPanel;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Button bModify;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbHost;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.Label lUser;
        private System.Windows.Forms.Label lPass;
        public System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenu cmSystray;
        private System.Windows.Forms.MenuItem miRestore;
        private System.Windows.Forms.MenuItem miClose;
        private System.Windows.Forms.Label lType;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.ContextMenu cmList;
        private System.Windows.Forms.Label lHost;
        private System.Windows.Forms.Button bOptions;
        private System.Windows.Forms.Panel pFind;
        private System.Windows.Forms.TextBox tbFilter;
        private System.Windows.Forms.PictureBox bClose;
        private System.Windows.Forms.CheckBox cbCase;
        public System.Windows.Forms.ListBox lbList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox bEye;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel LeftPanel;
    }
}

