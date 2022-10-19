
namespace Notepad_
{
    partial class NotePad
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TabPage tabPage1;
            this.TextBox = new System.Windows.Forms.RichTextBox();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextChooseAllMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextCutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextCopyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextPasteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewWindowMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAllMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chooseAllMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.FontSizeBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            tabPage1 = new System.Windows.Forms.TabPage();
            tabPage1.SuspendLayout();
            this.contextMenu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(this.TextBox);
            tabPage1.Location = new System.Drawing.Point(4, 24);
            tabPage1.Margin = new System.Windows.Forms.Padding(0);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3);
            tabPage1.Size = new System.Drawing.Size(797, 395);
            tabPage1.TabIndex = 1;
            tabPage1.Text = "Безымянный";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // TextBox
            // 
            this.TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox.BackColor = System.Drawing.SystemColors.Window;
            this.TextBox.ContextMenuStrip = this.contextMenu;
            this.TextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBox.Location = new System.Drawing.Point(-3, 0);
            this.TextBox.Margin = new System.Windows.Forms.Padding(0);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(804, 399);
            this.TextBox.TabIndex = 0;
            this.TextBox.Text = "";
            this.TextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // contextMenu
            // 
            this.contextMenu.BackColor = System.Drawing.SystemColors.Window;
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextChooseAllMenuItem,
            this.contextCutMenuItem,
            this.contextCopyMenuItem,
            this.contextPasteMenuItem});
            this.contextMenu.Name = "contextMenuStrip1";
            this.contextMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenu.Size = new System.Drawing.Size(241, 92);
            // 
            // contextChooseAllMenuItem
            // 
            this.contextChooseAllMenuItem.Name = "contextChooseAllMenuItem";
            this.contextChooseAllMenuItem.Size = new System.Drawing.Size(240, 22);
            this.contextChooseAllMenuItem.Text = "Выделить весь текст    CTRL+A";
            this.contextChooseAllMenuItem.Click += new System.EventHandler(this.ChooseAll_Click);
            // 
            // contextCutMenuItem
            // 
            this.contextCutMenuItem.Name = "contextCutMenuItem";
            this.contextCutMenuItem.Size = new System.Drawing.Size(240, 22);
            this.contextCutMenuItem.Text = "Вырезать                        CTRL+X";
            this.contextCutMenuItem.Click += new System.EventHandler(this.Cut_Click);
            // 
            // contextCopyMenuItem
            // 
            this.contextCopyMenuItem.Name = "contextCopyMenuItem";
            this.contextCopyMenuItem.Size = new System.Drawing.Size(240, 22);
            this.contextCopyMenuItem.Text = "Копировать                   CTRL+C";
            this.contextCopyMenuItem.Click += new System.EventHandler(this.Copy_Click);
            // 
            // contextPasteMenuItem
            // 
            this.contextPasteMenuItem.Name = "contextPasteMenuItem";
            this.contextPasteMenuItem.Size = new System.Drawing.Size(240, 22);
            this.contextPasteMenuItem.Text = "Вставить                         CTRL+V";
            this.contextPasteMenuItem.Click += new System.EventHandler(this.Paste_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Window;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.editMenuItem,
            this.settingsMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(194, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewMenuItem,
            this.createNewWindowMenuItem,
            this.saveMenuItem,
            this.saveAllMenuItem,
            this.openMenuItem,
            this.closeMenuItem,
            this.closeFileMenuItem});
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileMenuItem.Text = "Файл";
            this.fileMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // createNewMenuItem
            // 
            this.createNewMenuItem.Name = "createNewMenuItem";
            this.createNewMenuItem.Size = new System.Drawing.Size(267, 22);
            this.createNewMenuItem.Text = "Создать в новой вкладке    CTRL+N";
            this.createNewMenuItem.Click += new System.EventHandler(this.CreateTabMenuItem_Click);
            // 
            // createNewWindowMenuItem
            // 
            this.createNewWindowMenuItem.Name = "createNewWindowMenuItem";
            this.createNewWindowMenuItem.Size = new System.Drawing.Size(267, 22);
            this.createNewWindowMenuItem.Text = "Создать в новом окне         CTRL+W";
            this.createNewWindowMenuItem.Click += new System.EventHandler(this.CreateWindowMenuItem_Click);
            // 
            // saveMenuItem
            // 
            this.saveMenuItem.Name = "saveMenuItem";
            this.saveMenuItem.Size = new System.Drawing.Size(267, 22);
            this.saveMenuItem.Text = "Сохранить файл                   CTRL+S";
            this.saveMenuItem.Click += new System.EventHandler(this.SaveMenuItem_Click);
            // 
            // saveAllMenuItem
            // 
            this.saveAllMenuItem.Name = "saveAllMenuItem";
            this.saveAllMenuItem.Size = new System.Drawing.Size(267, 22);
            this.saveAllMenuItem.Text = "Сохранить все файлы         CTRL+D";
            this.saveAllMenuItem.Click += new System.EventHandler(this.SaveAllMenuItem_Click);
            // 
            // openMenuItem
            // 
            this.openMenuItem.Name = "openMenuItem";
            this.openMenuItem.Size = new System.Drawing.Size(267, 22);
            this.openMenuItem.Text = "Открыть                                  CTRL+O";
            this.openMenuItem.Click += new System.EventHandler(this.OpenMenuItem_Click);
            // 
            // closeMenuItem
            // 
            this.closeMenuItem.Name = "closeMenuItem";
            this.closeMenuItem.Size = new System.Drawing.Size(267, 22);
            this.closeMenuItem.Text = "Закрыть окно                        CTRL+E";
            this.closeMenuItem.Click += new System.EventHandler(this.CloseWindowMenuItem_Click);
            // 
            // closeFileMenuItem
            // 
            this.closeFileMenuItem.Name = "closeFileMenuItem";
            this.closeFileMenuItem.Size = new System.Drawing.Size(267, 22);
            this.closeFileMenuItem.Text = "Закрыть файл                       CTRL+Q";
            this.closeFileMenuItem.Click += new System.EventHandler(this.CloseTabMenuItem_Click);
            // 
            // editMenuItem
            // 
            this.editMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chooseAllMenuItem,
            this.cutMenuItem,
            this.copyMenuItem,
            this.pasteMenuItem});
            this.editMenuItem.Name = "editMenuItem";
            this.editMenuItem.Size = new System.Drawing.Size(59, 20);
            this.editMenuItem.Text = "Правка";
            // 
            // chooseAllMenuItem
            // 
            this.chooseAllMenuItem.Name = "chooseAllMenuItem";
            this.chooseAllMenuItem.Size = new System.Drawing.Size(240, 22);
            this.chooseAllMenuItem.Text = "Выделить весь текст    CTRL+A";
            this.chooseAllMenuItem.Click += new System.EventHandler(this.ChooseAll_Click);
            // 
            // cutMenuItem
            // 
            this.cutMenuItem.Name = "cutMenuItem";
            this.cutMenuItem.Size = new System.Drawing.Size(240, 22);
            this.cutMenuItem.Text = "Вырезать                        CTRL+X";
            this.cutMenuItem.Click += new System.EventHandler(this.Cut_Click);
            // 
            // copyMenuItem
            // 
            this.copyMenuItem.Name = "copyMenuItem";
            this.copyMenuItem.Size = new System.Drawing.Size(240, 22);
            this.copyMenuItem.Text = "Копировать                   CTRL+C";
            this.copyMenuItem.Click += new System.EventHandler(this.Copy_Click);
            // 
            // pasteMenuItem
            // 
            this.pasteMenuItem.Name = "pasteMenuItem";
            this.pasteMenuItem.Size = new System.Drawing.Size(240, 22);
            this.pasteMenuItem.Text = "Вставить                         CTRL+V";
            this.pasteMenuItem.Click += new System.EventHandler(this.Paste_Click);
            // 
            // settingsMenuItem
            // 
            this.settingsMenuItem.Name = "settingsMenuItem";
            this.settingsMenuItem.Size = new System.Drawing.Size(79, 20);
            this.settingsMenuItem.Text = "Настройки";
            this.settingsMenuItem.Click += new System.EventHandler(this.SettingsMenuItem_Click);
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(tabPage1);
            this.tabControl.Location = new System.Drawing.Point(0, 27);
            this.tabControl.Name = "tabControl";
            this.tabControl.Padding = new System.Drawing.Point(0, 0);
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(805, 423);
            this.tabControl.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // FontSizeBox
            // 
            this.FontSizeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FontSizeBox.FormattingEnabled = true;
            this.FontSizeBox.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "36",
            "48",
            "72"});
            this.FontSizeBox.Location = new System.Drawing.Point(348, 4);
            this.FontSizeBox.Name = "FontSizeBox";
            this.FontSizeBox.Size = new System.Drawing.Size(57, 23);
            this.FontSizeBox.TabIndex = 2;
            this.FontSizeBox.SelectedIndexChanged += new System.EventHandler(this.FontSize_SelectedIndexChanged);
            this.FontSizeBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SaveSelection_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(233, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Размер шрифта";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Window;
            this.button1.BackgroundImage = global::Notepad_.Properties.Resources.free_icon_italic_20878241;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.Location = new System.Drawing.Point(443, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 33);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.ForeColorChanged += new System.EventHandler(this.ItalicButton_StyleChanged);
            this.button1.Click += new System.EventHandler(this.ItalicButton_Click);
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SaveSelection_MouseDown);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Notepad_.Properties.Resources.bold;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Location = new System.Drawing.Point(494, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 33);
            this.button2.TabIndex = 5;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.ForeColorChanged += new System.EventHandler(this.ItalicButton_StyleChanged);
            this.button2.Click += new System.EventHandler(this.BoldButton_Click);
            this.button2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SaveSelection_MouseDown);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::Notepad_.Properties.Resources.underline;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.Location = new System.Drawing.Point(543, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(30, 33);
            this.button3.TabIndex = 6;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.ForeColorChanged += new System.EventHandler(this.ItalicButton_StyleChanged);
            this.button3.Click += new System.EventHandler(this.UnderLineButton_Click);
            this.button3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SaveSelection_MouseDown);
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::Notepad_.Properties.Resources.cross_out;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button4.Location = new System.Drawing.Point(593, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(30, 33);
            this.button4.TabIndex = 7;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.ForeColorChanged += new System.EventHandler(this.ItalicButton_StyleChanged);
            this.button4.Click += new System.EventHandler(this.StrikeOutButton_Click);
            this.button4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SaveSelection_MouseDown);
            // 
            // NotePad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FontSizeBox);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(256, 256);
            this.Name = "NotePad";
            this.ShowIcon = false;
            this.Text = "NotePad+";
            this.Load += new System.EventHandler(this.Form1_Load);
            tabPage1.ResumeLayout(false);
            this.contextMenu.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewWindowMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAllMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chooseAllMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openMenuItem;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.RichTextBox TextBox;
        private System.Windows.Forms.ToolStripMenuItem closeMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem contextChooseAllMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contextCutMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contextCopyMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contextPasteMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeFileMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox FontSizeBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

