namespace MVZAssigner;

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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.Home = new System.Windows.Forms.TabPage();
            this.Add = new System.Windows.Forms.TabPage();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.maid = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.name = new MaterialSkin.Controls.MaterialTextBox();
            this.Assign = new System.Windows.Forms.TabPage();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.txtDest = new MaterialSkin.Controls.MaterialTextBox();
            this.btnAssign = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.htPassSmb = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.htPassUnix = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtRootPath = new MaterialSkin.Controls.MaterialTextBox();
            this.Settings = new System.Windows.Forms.TabPage();
            this.materialTabSelector2 = new MaterialSkin.Controls.MaterialTabSelector();
            this.btnAdd = new MaterialSkin.Controls.MaterialButton();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            this.txtServer = new MaterialSkin.Controls.MaterialLabel();
            this.materialMultiLineTextBox1 = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialMultiLineTextBox2 = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.statusStrip1.SuspendLayout();
            this.materialTabControl1.SuspendLayout();
            this.Add.SuspendLayout();
            this.Assign.SuspendLayout();
            this.Settings.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(3, 425);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(794, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Image = global::MVZAssigner.Properties.Resources.icons8_red_circle_48;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(123, 17);
            this.toolStripStatusLabel1.Text = "Connection Status:";
            this.toolStripStatusLabel1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.Home);
            this.materialTabControl1.Controls.Add(this.Add);
            this.materialTabControl1.Controls.Add(this.Assign);
            this.materialTabControl1.Controls.Add(this.Settings);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(2, 118);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(795, 304);
            this.materialTabControl1.TabIndex = 1;
            // 
            // Home
            // 
            this.Home.Location = new System.Drawing.Point(4, 24);
            this.Home.Name = "Home";
            this.Home.Padding = new System.Windows.Forms.Padding(3);
            this.Home.Size = new System.Drawing.Size(787, 276);
            this.Home.TabIndex = 0;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = true;
            // 
            // Add
            // 
            this.Add.Controls.Add(this.materialLabel8);
            this.Add.Controls.Add(this.materialMultiLineTextBox2);
            this.Add.Controls.Add(this.btnAdd);
            this.Add.Controls.Add(this.materialLabel5);
            this.Add.Controls.Add(this.maid);
            this.Add.Controls.Add(this.materialLabel1);
            this.Add.Controls.Add(this.name);
            this.Add.Location = new System.Drawing.Point(4, 24);
            this.Add.Name = "Add";
            this.Add.Padding = new System.Windows.Forms.Padding(3);
            this.Add.Size = new System.Drawing.Size(787, 276);
            this.Add.TabIndex = 1;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(17, 9);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(62, 19);
            this.materialLabel5.TabIndex = 3;
            this.materialLabel5.Text = "ID (Raw)";
            // 
            // maid
            // 
            this.maid.AnimateReadOnly = false;
            this.maid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maid.Depth = 0;
            this.maid.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.maid.LeadingIcon = null;
            this.maid.Location = new System.Drawing.Point(17, 31);
            this.maid.MaxLength = 50;
            this.maid.MouseState = MaterialSkin.MouseState.OUT;
            this.maid.Multiline = false;
            this.maid.Name = "maid";
            this.maid.Size = new System.Drawing.Size(114, 50);
            this.maid.TabIndex = 2;
            this.maid.Text = "";
            this.maid.TrailingIcon = null;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(17, 89);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(114, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Name, Vorname";
            // 
            // name
            // 
            this.name.AnimateReadOnly = false;
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name.Depth = 0;
            this.name.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.name.LeadingIcon = null;
            this.name.Location = new System.Drawing.Point(17, 111);
            this.name.MaxLength = 50;
            this.name.MouseState = MaterialSkin.MouseState.OUT;
            this.name.Multiline = false;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(236, 50);
            this.name.TabIndex = 0;
            this.name.Text = "";
            this.name.TrailingIcon = null;
            // 
            // Assign
            // 
            this.Assign.Controls.Add(this.materialLabel7);
            this.Assign.Controls.Add(this.materialMultiLineTextBox1);
            this.Assign.Controls.Add(this.materialLabel6);
            this.Assign.Controls.Add(this.txtDest);
            this.Assign.Controls.Add(this.btnAssign);
            this.Assign.Controls.Add(this.materialLabel4);
            this.Assign.Controls.Add(this.htPassSmb);
            this.Assign.Controls.Add(this.materialLabel3);
            this.Assign.Controls.Add(this.htPassUnix);
            this.Assign.Controls.Add(this.materialLabel2);
            this.Assign.Controls.Add(this.txtRootPath);
            this.Assign.Location = new System.Drawing.Point(4, 24);
            this.Assign.Name = "Assign";
            this.Assign.Size = new System.Drawing.Size(787, 276);
            this.Assign.TabIndex = 2;
            this.Assign.Text = "Assign";
            this.Assign.UseVisualStyleBackColor = true;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(262, 9);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(119, 19);
            this.materialLabel6.TabIndex = 10;
            this.materialLabel6.Text = "Destination Path";
            // 
            // txtDest
            // 
            this.txtDest.AnimateReadOnly = false;
            this.txtDest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDest.Depth = 0;
            this.txtDest.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDest.LeadingIcon = null;
            this.txtDest.Location = new System.Drawing.Point(262, 31);
            this.txtDest.MaxLength = 50;
            this.txtDest.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDest.Multiline = false;
            this.txtDest.Name = "txtDest";
            this.txtDest.Size = new System.Drawing.Size(236, 50);
            this.txtDest.TabIndex = 9;
            this.txtDest.Text = "";
            this.txtDest.TrailingIcon = null;
            // 
            // btnAssign
            // 
            this.btnAssign.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAssign.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAssign.Depth = 0;
            this.btnAssign.HighEmphasis = true;
            this.btnAssign.Icon = null;
            this.btnAssign.Location = new System.Drawing.Point(17, 234);
            this.btnAssign.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAssign.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAssign.Size = new System.Drawing.Size(73, 36);
            this.btnAssign.TabIndex = 8;
            this.btnAssign.Text = "Assign";
            this.btnAssign.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAssign.UseAccentColor = false;
            this.btnAssign.UseVisualStyleBackColor = true;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(262, 89);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(148, 19);
            this.materialLabel4.TabIndex = 7;
            this.materialLabel4.Text = "Smb Path .htpasswd";
            // 
            // htPassSmb
            // 
            this.htPassSmb.AnimateReadOnly = false;
            this.htPassSmb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.htPassSmb.Depth = 0;
            this.htPassSmb.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.htPassSmb.LeadingIcon = null;
            this.htPassSmb.Location = new System.Drawing.Point(262, 111);
            this.htPassSmb.MaxLength = 50;
            this.htPassSmb.MouseState = MaterialSkin.MouseState.OUT;
            this.htPassSmb.Multiline = false;
            this.htPassSmb.Name = "htPassSmb";
            this.htPassSmb.Size = new System.Drawing.Size(236, 50);
            this.htPassSmb.TabIndex = 6;
            this.htPassSmb.Text = "";
            this.htPassSmb.TrailingIcon = null;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(17, 89);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(146, 19);
            this.materialLabel3.TabIndex = 5;
            this.materialLabel3.Text = "Unix Path .htpasswd";
            // 
            // htPassUnix
            // 
            this.htPassUnix.AnimateReadOnly = false;
            this.htPassUnix.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.htPassUnix.Depth = 0;
            this.htPassUnix.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.htPassUnix.LeadingIcon = null;
            this.htPassUnix.Location = new System.Drawing.Point(17, 111);
            this.htPassUnix.MaxLength = 50;
            this.htPassUnix.MouseState = MaterialSkin.MouseState.OUT;
            this.htPassUnix.Multiline = false;
            this.htPassUnix.Name = "htPassUnix";
            this.htPassUnix.Size = new System.Drawing.Size(236, 50);
            this.htPassUnix.TabIndex = 4;
            this.htPassUnix.Text = "";
            this.htPassUnix.TrailingIcon = null;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(17, 9);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(50, 19);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "Source";
            // 
            // txtRootPath
            // 
            this.txtRootPath.AnimateReadOnly = false;
            this.txtRootPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRootPath.Depth = 0;
            this.txtRootPath.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtRootPath.LeadingIcon = null;
            this.txtRootPath.Location = new System.Drawing.Point(17, 31);
            this.txtRootPath.MaxLength = 50;
            this.txtRootPath.MouseState = MaterialSkin.MouseState.OUT;
            this.txtRootPath.Multiline = false;
            this.txtRootPath.Name = "txtRootPath";
            this.txtRootPath.Size = new System.Drawing.Size(236, 50);
            this.txtRootPath.TabIndex = 2;
            this.txtRootPath.Text = "";
            this.txtRootPath.TrailingIcon = null;
            // 
            // Settings
            // 
            this.Settings.Controls.Add(this.txtServer);
            this.Settings.Controls.Add(this.materialTextBox1);
            this.Settings.Controls.Add(this.materialButton1);
            this.Settings.Location = new System.Drawing.Point(4, 24);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(787, 276);
            this.Settings.TabIndex = 3;
            this.Settings.Text = "Settings";
            this.Settings.UseVisualStyleBackColor = true;
            // 
            // materialTabSelector2
            // 
            this.materialTabSelector2.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector2.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.materialTabSelector2.Depth = 0;
            this.materialTabSelector2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTabSelector2.Location = new System.Drawing.Point(0, 64);
            this.materialTabSelector2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector2.Name = "materialTabSelector2";
            this.materialTabSelector2.Size = new System.Drawing.Size(804, 48);
            this.materialTabSelector2.TabIndex = 4;
            this.materialTabSelector2.Text = "materialTabSelector2";
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAdd.Depth = 0;
            this.btnAdd.HighEmphasis = true;
            this.btnAdd.Icon = null;
            this.btnAdd.Location = new System.Drawing.Point(17, 234);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAdd.Size = new System.Drawing.Size(64, 36);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAdd.UseAccentColor = false;
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(17, 234);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(153, 36);
            this.materialButton1.TabIndex = 0;
            this.materialButton1.Text = "Test Connection";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            // 
            // materialTextBox1
            // 
            this.materialTextBox1.AnimateReadOnly = false;
            this.materialTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox1.Depth = 0;
            this.materialTextBox1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox1.LeadingIcon = null;
            this.materialTextBox1.Location = new System.Drawing.Point(17, 31);
            this.materialTextBox1.MaxLength = 50;
            this.materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox1.Multiline = false;
            this.materialTextBox1.Name = "materialTextBox1";
            this.materialTextBox1.Size = new System.Drawing.Size(358, 50);
            this.materialTextBox1.TabIndex = 1;
            this.materialTextBox1.Text = "";
            this.materialTextBox1.TrailingIcon = null;
            // 
            // txtServer
            // 
            this.txtServer.AutoSize = true;
            this.txtServer.Depth = 0;
            this.txtServer.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtServer.Location = new System.Drawing.Point(17, 9);
            this.txtServer.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(85, 19);
            this.txtServer.TabIndex = 4;
            this.txtServer.Text = "Servername";
            // 
            // materialMultiLineTextBox1
            // 
            this.materialMultiLineTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialMultiLineTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialMultiLineTextBox1.Depth = 0;
            this.materialMultiLineTextBox1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialMultiLineTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialMultiLineTextBox1.Location = new System.Drawing.Point(517, 31);
            this.materialMultiLineTextBox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialMultiLineTextBox1.Name = "materialMultiLineTextBox1";
            this.materialMultiLineTextBox1.Size = new System.Drawing.Size(267, 96);
            this.materialMultiLineTextBox1.TabIndex = 11;
            this.materialMultiLineTextBox1.Text = "";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.Location = new System.Drawing.Point(517, 9);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(49, 19);
            this.materialLabel7.TabIndex = 12;
            this.materialLabel7.Text = "Output";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.Location = new System.Drawing.Point(495, 9);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(49, 19);
            this.materialLabel8.TabIndex = 14;
            this.materialLabel8.Text = "Output";
            // 
            // materialMultiLineTextBox2
            // 
            this.materialMultiLineTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialMultiLineTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialMultiLineTextBox2.Depth = 0;
            this.materialMultiLineTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialMultiLineTextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialMultiLineTextBox2.Location = new System.Drawing.Point(495, 31);
            this.materialMultiLineTextBox2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialMultiLineTextBox2.Name = "materialMultiLineTextBox2";
            this.materialMultiLineTextBox2.Size = new System.Drawing.Size(267, 96);
            this.materialMultiLineTextBox2.TabIndex = 13;
            this.materialMultiLineTextBox2.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.materialTabSelector2);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Form1";
            this.Text = "MVZAssigner";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.materialTabControl1.ResumeLayout(false);
            this.Add.ResumeLayout(false);
            this.Add.PerformLayout();
            this.Assign.ResumeLayout(false);
            this.Assign.PerformLayout();
            this.Settings.ResumeLayout(false);
            this.Settings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private FolderBrowserDialog folderBrowserDialog1;
    private FolderBrowserDialog folderBrowserDialog2;
    private StatusStrip statusStrip1;
    private ToolStripStatusLabel toolStripStatusLabel1;
    private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
    private TabPage Home;
    private TabPage Add;
    private MaterialSkin.Controls.MaterialLabel materialLabel1;
    private MaterialSkin.Controls.MaterialTextBox name;
    private TabPage Assign;
    private MaterialSkin.Controls.MaterialLabel materialLabel2;
    private MaterialSkin.Controls.MaterialTextBox txtRootPath;
    private TabPage Settings;
    private MaterialSkin.Controls.MaterialLabel materialLabel4;
    private MaterialSkin.Controls.MaterialTextBox htPassSmb;
    private MaterialSkin.Controls.MaterialLabel materialLabel3;
    private MaterialSkin.Controls.MaterialTextBox htPassUnix;
    private MaterialSkin.Controls.MaterialLabel materialLabel5;
    private MaterialSkin.Controls.MaterialTextBox maid;
    private MaterialSkin.Controls.MaterialButton btnAssign;
    private MaterialSkin.Controls.MaterialLabel materialLabel6;
    private MaterialSkin.Controls.MaterialTextBox txtDest;
    private MaterialSkin.Controls.MaterialTabSelector materialTabSelector2;
    private MaterialSkin.Controls.MaterialButton btnAdd;
    private MaterialSkin.Controls.MaterialLabel txtServer;
    private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
    private MaterialSkin.Controls.MaterialButton materialButton1;
    private MaterialSkin.Controls.MaterialLabel materialLabel7;
    private MaterialSkin.Controls.MaterialMultiLineTextBox materialMultiLineTextBox1;
    private MaterialSkin.Controls.MaterialLabel materialLabel8;
    private MaterialSkin.Controls.MaterialMultiLineTextBox materialMultiLineTextBox2;
}
