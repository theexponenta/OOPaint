namespace OOPaint
{
    partial class MainForm
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
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            открытьToolStripMenuItem = new ToolStripMenuItem();
            сохранитьToolStripMenuItem = new ToolStripMenuItem();
            сохранитьКакToolStripMenuItem = new ToolStripMenuItem();
            плагиныToolStripMenuItem = new ToolStripMenuItem();
            добавитьПлагинToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            lineToolButton = new ToolStripButton();
            ellipseToolButton = new ToolStripButton();
            rectangleToolButton = new ToolStripButton();
            toolStripButton5 = new ToolStripButton();
            polygonToolButton = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            pickColorButton = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            pictureBox = new PictureBox();
            colorDialog = new ColorDialog();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.White;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, плагиныToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(990, 28);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { открытьToolStripMenuItem, сохранитьToolStripMenuItem, сохранитьКакToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(59, 24);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            открытьToolStripMenuItem.Size = new Size(192, 26);
            открытьToolStripMenuItem.Text = "Открыть";
            // 
            // сохранитьToolStripMenuItem
            // 
            сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            сохранитьToolStripMenuItem.Size = new Size(192, 26);
            сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // сохранитьКакToolStripMenuItem
            // 
            сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            сохранитьКакToolStripMenuItem.Size = new Size(192, 26);
            сохранитьКакToolStripMenuItem.Text = "Сохранить как";
            // 
            // плагиныToolStripMenuItem
            // 
            плагиныToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { добавитьПлагинToolStripMenuItem });
            плагиныToolStripMenuItem.Name = "плагиныToolStripMenuItem";
            плагиныToolStripMenuItem.Size = new Size(85, 24);
            плагиныToolStripMenuItem.Text = "Плагины";
            // 
            // добавитьПлагинToolStripMenuItem
            // 
            добавитьПлагинToolStripMenuItem.Name = "добавитьПлагинToolStripMenuItem";
            добавитьПлагинToolStripMenuItem.Size = new Size(212, 26);
            добавитьПлагинToolStripMenuItem.Text = "Добавить плагин";
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = SystemColors.Control;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2, toolStripSeparator2, lineToolButton, ellipseToolButton, rectangleToolButton, toolStripButton5, polygonToolButton, toolStripSeparator1, pickColorButton, toolStripButton3 });
            toolStrip1.LayoutStyle = ToolStripLayoutStyle.Flow;
            toolStrip1.Location = new Point(0, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(990, 38);
            toolStrip1.Stretch = true;
            toolStrip1.TabIndex = 5;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.AutoSize = false;
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = Properties.Resources.undo;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(35, 35);
            toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            toolStripButton2.AutoSize = false;
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = Properties.Resources.redo1;
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(35, 35);
            toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.AutoSize = false;
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 38);
            // 
            // lineToolButton
            // 
            lineToolButton.AutoSize = false;
            lineToolButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            lineToolButton.Image = Properties.Resources.line_tool;
            lineToolButton.ImageTransparentColor = Color.Magenta;
            lineToolButton.Name = "lineToolButton";
            lineToolButton.Size = new Size(35, 35);
            lineToolButton.Text = "toolStripButton1";
            lineToolButton.Click += lineToolButton_Click;
            // 
            // ellipseToolButton
            // 
            ellipseToolButton.AutoSize = false;
            ellipseToolButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ellipseToolButton.Image = Properties.Resources.oval_tool;
            ellipseToolButton.ImageTransparentColor = Color.Magenta;
            ellipseToolButton.Name = "ellipseToolButton";
            ellipseToolButton.Size = new Size(35, 35);
            ellipseToolButton.Text = "toolStripButton2";
            ellipseToolButton.Click += ellipseToolButton_Click;
            // 
            // rectangleToolButton
            // 
            rectangleToolButton.AutoSize = false;
            rectangleToolButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            rectangleToolButton.Image = Properties.Resources.rectangle_tool;
            rectangleToolButton.ImageTransparentColor = Color.Magenta;
            rectangleToolButton.Name = "rectangleToolButton";
            rectangleToolButton.Size = new Size(35, 35);
            rectangleToolButton.Text = "toolStripButton3";
            rectangleToolButton.Click += rectangleToolButton_Click_1;
            // 
            // toolStripButton5
            // 
            toolStripButton5.AutoSize = false;
            toolStripButton5.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton5.Image = Properties.Resources.polyline;
            toolStripButton5.ImageTransparentColor = Color.Magenta;
            toolStripButton5.Name = "toolStripButton5";
            toolStripButton5.Size = new Size(35, 35);
            toolStripButton5.Text = "toolStripButton3";
            toolStripButton5.Click += polylineToolButton_Click;
            // 
            // polygonToolButton
            // 
            polygonToolButton.AutoSize = false;
            polygonToolButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            polygonToolButton.Image = Properties.Resources.polygon_tool;
            polygonToolButton.ImageTransparentColor = Color.Magenta;
            polygonToolButton.Name = "polygonToolButton";
            polygonToolButton.Size = new Size(35, 35);
            polygonToolButton.Text = "toolStripButton3";
            polygonToolButton.Click += polygonToolButton_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.AutoSize = false;
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 38);
            // 
            // pickColorButton
            // 
            pickColorButton.AutoSize = false;
            pickColorButton.BackColor = Color.Black;
            pickColorButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            pickColorButton.ImageTransparentColor = Color.Magenta;
            pickColorButton.Margin = new Padding(4, 5, 0, 2);
            pickColorButton.Name = "pickColorButton";
            pickColorButton.Size = new Size(28, 28);
            pickColorButton.Text = "toolStripButton1";
            pickColorButton.Click += pickColorButton_Click;
            // 
            // toolStripButton3
            // 
            toolStripButton3.AutoSize = false;
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton3.Image = Properties.Resources.thickness;
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(35, 35);
            toolStripButton3.Text = "toolStripButton3";
            // 
            // pictureBox
            // 
            pictureBox.BackColor = Color.White;
            pictureBox.Dock = DockStyle.Top;
            pictureBox.Location = new Point(0, 66);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(990, 524);
            pictureBox.TabIndex = 6;
            pictureBox.TabStop = false;
            pictureBox.Paint += pictureBox_Paint;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(990, 593);
            Controls.Add(pictureBox);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "OOPaint";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem открытьToolStripMenuItem;
        private ToolStripMenuItem сохранитьToolStripMenuItem;
        private ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton lineToolButton;
        private ToolStripButton ellipseToolButton;
        private ToolStripButton polygonToolButton;
        private PictureBox pictureBox;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton pickColorButton;
        private ColorDialog colorDialog;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private ToolStripMenuItem плагиныToolStripMenuItem;
        private ToolStripMenuItem добавитьПлагинToolStripMenuItem;
        private ToolStripButton rectangleToolButton;
        private ToolStripButton toolStripButton5;
    }
}
