namespace DbHelper
{
    partial class DbHelper
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DbHelper));
            this.lbl1 = new System.Windows.Forms.Label();
            this.txt = new System.Windows.Forms.TextBox();
            this.btn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.file = new System.Windows.Forms.ToolStripMenuItem();
            this.close = new System.Windows.Forms.ToolStripMenuItem();
            this.help = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.version = new System.Windows.Forms.ToolStripMenuItem();
            this.tab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbl2 = new System.Windows.Forms.Label();
            this.cnt = new System.Windows.Forms.TextBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tab.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(22, 60);
            this.lbl1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(179, 30);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "テーブル・カラム名";
            // 
            // txt
            // 
            this.txt.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt.Location = new System.Drawing.Point(217, 57);
            this.txt.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(690, 38);
            this.txt.TabIndex = 1;
            this.txt.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txt_PreviewKeyDown);
            // 
            // btn
            // 
            this.btn.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn.Location = new System.Drawing.Point(1097, 54);
            this.btn.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(194, 46);
            this.btn.TabIndex = 5;
            this.btn.Text = "DBエビデンス取得";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file,
            this.help});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1336, 40);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // file
            // 
            this.file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.close});
            this.file.Name = "file";
            this.file.Size = new System.Drawing.Size(103, 36);
            this.file.Text = "ファイル";
            // 
            // close
            // 
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(208, 44);
            this.close.Text = "閉じる";
            // 
            // help
            // 
            this.help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewHelp,
            this.version});
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(93, 36);
            this.help.Text = "ヘルプ";
            // 
            // viewHelp
            // 
            this.viewHelp.Name = "viewHelp";
            this.viewHelp.Size = new System.Drawing.Size(275, 44);
            this.viewHelp.Text = "ヘルプの表示";
            // 
            // version
            // 
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(275, 44);
            this.version.Text = "バージョン";
            // 
            // tab
            // 
            this.tab.Controls.Add(this.tabPage1);
            this.tab.Controls.Add(this.tabPage2);
            this.tab.Location = new System.Drawing.Point(27, 105);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(1282, 800);
            this.tab.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1266, 753);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tab1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(8, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1266, 753);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tab2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(919, 60);
            this.lbl2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(61, 30);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "直近";
            // 
            // cnt
            // 
            this.cnt.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnt.Location = new System.Drawing.Point(985, 57);
            this.cnt.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.cnt.Name = "cnt";
            this.cnt.Size = new System.Drawing.Size(53, 38);
            this.cnt.TabIndex = 3;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(1050, 60);
            this.lbl3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(37, 30);
            this.lbl3.TabIndex = 4;
            this.lbl3.Text = "件";
            // 
            // DbHelper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1336, 1059);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.cnt);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.tab);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "DbHelper";
            this.Text = "DbHelper";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem file;
        private System.Windows.Forms.ToolStripMenuItem close;
        private System.Windows.Forms.ToolStripMenuItem help;
        private System.Windows.Forms.ToolStripMenuItem viewHelp;
        private System.Windows.Forms.ToolStripMenuItem version;
        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox cnt;
        private System.Windows.Forms.Label lbl3;
    }
}

