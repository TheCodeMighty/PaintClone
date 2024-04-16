namespace WinFormsLab
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
            menuStrip1 = new MenuStrip();
            fileMenuItem = new ToolStripMenuItem();
            newMenuItem = new ToolStripMenuItem();
            openMenuItem = new ToolStripMenuItem();
            saveMenuItem = new ToolStripMenuItem();
            saveAsMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            printMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            TextBox = new ToolStripTextBox();
            openedFilesMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            exitMenuItem = new ToolStripMenuItem();
            editMenuItem = new ToolStripMenuItem();
            cutMenuItem = new ToolStripMenuItem();
            copyMenuItem = new ToolStripMenuItem();
            pasteMenuItem = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            selectAllMenuItem = new ToolStripMenuItem();
            viewMenuItem = new ToolStripMenuItem();
            zoomToolStripMenuItem = new ToolStripMenuItem();
            zoomInMenuItem = new ToolStripMenuItem();
            zoomOutMenuItem = new ToolStripMenuItem();
            resetZoomMenuItem = new ToolStripMenuItem();
            imageMenuItem = new ToolStripMenuItem();
            colorsMenuItem = new ToolStripMenuItem();
            editColorMenuItem = new ToolStripMenuItem();
            invertColorsMenuItem = new ToolStripMenuItem();
            helpMenuItem = new ToolStripMenuItem();
            aboutMenuItem = new ToolStripMenuItem();
            statusBar = new StatusStrip();
            currentPositionStatusBarLabel = new ToolStripStatusLabel();
            selectionStatusBarLabel = new ToolStripStatusLabel();
            currentCanvasSizeLabel = new ToolStripStatusLabel();
            currentZoomStatusBarLabel = new ToolStripStatusLabel();
            canvasPanel = new Panel();
            Canvas = new PictureBox();
            toolPanel = new Panel();
            lineButton = new Button();
            selectButton = new Button();
            penButton = new Button();
            colorPalettePanel = new Panel();
            lastPickedColorButton = new Button();
            indigoButtonBottomPalette = new Button();
            blueButtonBottomPalette = new Button();
            royalBlueButtonBottomPalette = new Button();
            lightSkyBlueButtonBottomPalette = new Button();
            forestGreenButtonBottomPalette = new Button();
            greenYellowButtonBottomPlette = new Button();
            yellowButtonBottomPalette = new Button();
            goldButtonBottomPalette = new Button();
            darkOrangeButtonBottomPalette = new Button();
            redButtonBottomPalette = new Button();
            darkRedButtonBottomPalette = new Button();
            darkGreyButtonBottomPalette = new Button();
            dimGreyButtonBottomPalette = new Button();
            blackButtonBottomPalette = new Button();
            indigoButtonUpperPalette = new Button();
            blueButtonUpperPalette = new Button();
            royalBlueButtonUpperPalette = new Button();
            lightSkyBlueButtonUpperPalette = new Button();
            forestGreenButtonUpperPalette = new Button();
            greenYellowButtonBottomPalette = new Button();
            yellowButtonUpperPalette = new Button();
            goldButtonUpperPalette = new Button();
            darkOrangeButtonUpperPalette = new Button();
            redButtonUpperPalette = new Button();
            bdarkRedButtonUpperPalette = new Button();
            darkGreyButtonUpperPalette = new Button();
            dimGreyButtonUpperPalette = new Button();
            blackButtonUpperPalette = new Button();
            colorDialog1 = new ColorDialog();
            menuStrip1.SuspendLayout();
            statusBar.SuspendLayout();
            canvasPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Canvas).BeginInit();
            toolPanel.SuspendLayout();
            colorPalettePanel.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileMenuItem, editMenuItem, viewMenuItem, imageMenuItem, colorsMenuItem, helpMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(9, 3, 0, 3);
            menuStrip1.Size = new Size(1143, 35);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileMenuItem
            // 
            fileMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newMenuItem, openMenuItem, saveMenuItem, saveAsMenuItem, toolStripSeparator1, printMenuItem, toolStripSeparator2, TextBox, openedFilesMenuItem, toolStripSeparator3, exitMenuItem });
            fileMenuItem.Name = "fileMenuItem";
            fileMenuItem.Size = new Size(54, 29);
            fileMenuItem.Text = "File";
            // 
            // newMenuItem
            // 
            newMenuItem.Name = "newMenuItem";
            newMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            newMenuItem.Size = new Size(282, 34);
            newMenuItem.Text = "New";
            newMenuItem.Click += newMenuItem_Click;
            // 
            // openMenuItem
            // 
            openMenuItem.Name = "openMenuItem";
            openMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            openMenuItem.Size = new Size(282, 34);
            openMenuItem.Text = "Open";
            openMenuItem.Click += openMenuItem_Click;
            // 
            // saveMenuItem
            // 
            saveMenuItem.Name = "saveMenuItem";
            saveMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveMenuItem.Size = new Size(282, 34);
            saveMenuItem.Text = "Save";
            saveMenuItem.Click += saveMenuItem_Click;
            // 
            // saveAsMenuItem
            // 
            saveAsMenuItem.Name = "saveAsMenuItem";
            saveAsMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
            saveAsMenuItem.Size = new Size(282, 34);
            saveAsMenuItem.Text = "Save as";
            saveAsMenuItem.Click += saveAsMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(279, 6);
            // 
            // printMenuItem
            // 
            printMenuItem.Name = "printMenuItem";
            printMenuItem.ShortcutKeys = Keys.Control | Keys.P;
            printMenuItem.Size = new Size(282, 34);
            printMenuItem.Text = "Print";
            printMenuItem.Click += printMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(279, 6);
            // 
            // TextBox
            // 
            TextBox.Name = "TextBox";
            TextBox.Size = new Size(100, 31);
            TextBox.Text = "[Recent Files]";
            TextBox.Click += TextBox_Click;
            // 
            // openedFilesMenuItem
            // 
            openedFilesMenuItem.Name = "openedFilesMenuItem";
            openedFilesMenuItem.Size = new Size(282, 34);
            openedFilesMenuItem.Click += openedFilesMenuItem_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(279, 6);
            // 
            // exitMenuItem
            // 
            exitMenuItem.Name = "exitMenuItem";
            exitMenuItem.ShortcutKeys = Keys.Alt | Keys.F4;
            exitMenuItem.Size = new Size(282, 34);
            exitMenuItem.Text = "Exit";
            exitMenuItem.Click += exitMenuItem_Click;
            // 
            // editMenuItem
            // 
            editMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cutMenuItem, copyMenuItem, pasteMenuItem, toolStripSeparator4, selectAllMenuItem });
            editMenuItem.Name = "editMenuItem";
            editMenuItem.Size = new Size(58, 29);
            editMenuItem.Text = "Edit";
            // 
            // cutMenuItem
            // 
            cutMenuItem.Name = "cutMenuItem";
            cutMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            cutMenuItem.Size = new Size(245, 34);
            cutMenuItem.Text = "Cut";
            // 
            // copyMenuItem
            // 
            copyMenuItem.Name = "copyMenuItem";
            copyMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            copyMenuItem.Size = new Size(245, 34);
            copyMenuItem.Text = "Copy";
            // 
            // pasteMenuItem
            // 
            pasteMenuItem.Name = "pasteMenuItem";
            pasteMenuItem.ShortcutKeys = Keys.Control | Keys.V;
            pasteMenuItem.Size = new Size(245, 34);
            pasteMenuItem.Text = "Paste";
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(242, 6);
            // 
            // selectAllMenuItem
            // 
            selectAllMenuItem.Name = "selectAllMenuItem";
            selectAllMenuItem.ShortcutKeys = Keys.Control | Keys.A;
            selectAllMenuItem.Size = new Size(245, 34);
            selectAllMenuItem.Text = "Select all";
            selectAllMenuItem.Click += selectAllMenuItem_Click;
            // 
            // viewMenuItem
            // 
            viewMenuItem.DropDownItems.AddRange(new ToolStripItem[] { zoomToolStripMenuItem });
            viewMenuItem.Name = "viewMenuItem";
            viewMenuItem.Size = new Size(65, 29);
            viewMenuItem.Text = "View";
            // 
            // zoomToolStripMenuItem
            // 
            zoomToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { zoomInMenuItem, zoomOutMenuItem, resetZoomMenuItem });
            zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            zoomToolStripMenuItem.Size = new Size(162, 34);
            zoomToolStripMenuItem.Text = "Zoom";
            // 
            // zoomInMenuItem
            // 
            zoomInMenuItem.Name = "zoomInMenuItem";
            zoomInMenuItem.ShortcutKeyDisplayString = "Ctrl+";
            zoomInMenuItem.ShortcutKeys = Keys.Control | Keys.Oemplus;
            zoomInMenuItem.Size = new Size(243, 34);
            zoomInMenuItem.Text = "Zoom In";
            zoomInMenuItem.Click += zoomInMenuItem_Click;
            // 
            // zoomOutMenuItem
            // 
            zoomOutMenuItem.Name = "zoomOutMenuItem";
            zoomOutMenuItem.ShortcutKeyDisplayString = "Ctrl-";
            zoomOutMenuItem.ShortcutKeys = Keys.Control | Keys.OemMinus;
            zoomOutMenuItem.Size = new Size(243, 34);
            zoomOutMenuItem.Text = "Zoom Out";
            zoomOutMenuItem.Click += zoomOutMenuItem_Click;
            // 
            // resetZoomMenuItem
            // 
            resetZoomMenuItem.Name = "resetZoomMenuItem";
            resetZoomMenuItem.Size = new Size(243, 34);
            resetZoomMenuItem.Text = "Reset Zoom";
            resetZoomMenuItem.Click += resetZoomMenuItem_Click;
            // 
            // imageMenuItem
            // 
            imageMenuItem.Name = "imageMenuItem";
            imageMenuItem.Size = new Size(78, 29);
            imageMenuItem.Text = "Image";
            // 
            // colorsMenuItem
            // 
            colorsMenuItem.DropDownItems.AddRange(new ToolStripItem[] { editColorMenuItem, invertColorsMenuItem });
            colorsMenuItem.Name = "colorsMenuItem";
            colorsMenuItem.Size = new Size(79, 29);
            colorsMenuItem.Text = "Colors";
            // 
            // editColorMenuItem
            // 
            editColorMenuItem.Name = "editColorMenuItem";
            editColorMenuItem.Size = new Size(268, 34);
            editColorMenuItem.Text = "Edit colors...";
            editColorMenuItem.Click += editColorMenuItem_Click;
            // 
            // invertColorsMenuItem
            // 
            invertColorsMenuItem.Name = "invertColorsMenuItem";
            invertColorsMenuItem.ShortcutKeys = Keys.Control | Keys.I;
            invertColorsMenuItem.Size = new Size(268, 34);
            invertColorsMenuItem.Text = "Invert colors";
            invertColorsMenuItem.Click += invertColorsMenuItem_Click;
            // 
            // helpMenuItem
            // 
            helpMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutMenuItem });
            helpMenuItem.Name = "helpMenuItem";
            helpMenuItem.Size = new Size(65, 29);
            helpMenuItem.Text = "Help";
            // 
            // aboutMenuItem
            // 
            aboutMenuItem.Name = "aboutMenuItem";
            aboutMenuItem.ShortcutKeys = Keys.F12;
            aboutMenuItem.Size = new Size(205, 34);
            aboutMenuItem.Text = "About";
            // 
            // statusBar
            // 
            statusBar.ImageScalingSize = new Size(24, 24);
            statusBar.Items.AddRange(new ToolStripItem[] { currentPositionStatusBarLabel, selectionStatusBarLabel, currentCanvasSizeLabel, currentZoomStatusBarLabel });
            statusBar.Location = new Point(0, 722);
            statusBar.Name = "statusBar";
            statusBar.Padding = new Padding(1, 0, 20, 0);
            statusBar.Size = new Size(1143, 28);
            statusBar.TabIndex = 2;
            statusBar.Text = "statusStrip1";
            // 
            // currentPositionStatusBarLabel
            // 
            currentPositionStatusBarLabel.BackColor = SystemColors.ScrollBar;
            currentPositionStatusBarLabel.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
            currentPositionStatusBarLabel.BorderStyle = Border3DStyle.SunkenOuter;
            currentPositionStatusBarLabel.Margin = new Padding(2);
            currentPositionStatusBarLabel.Name = "currentPositionStatusBarLabel";
            currentPositionStatusBarLabel.Size = new Size(265, 24);
            currentPositionStatusBarLabel.Spring = true;
            currentPositionStatusBarLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // selectionStatusBarLabel
            // 
            selectionStatusBarLabel.BackColor = SystemColors.ScrollBar;
            selectionStatusBarLabel.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
            selectionStatusBarLabel.BorderStyle = Border3DStyle.SunkenOuter;
            selectionStatusBarLabel.Margin = new Padding(2);
            selectionStatusBarLabel.Name = "selectionStatusBarLabel";
            selectionStatusBarLabel.RightToLeftAutoMirrorImage = true;
            selectionStatusBarLabel.Size = new Size(265, 24);
            selectionStatusBarLabel.Spring = true;
            // 
            // currentCanvasSizeLabel
            // 
            currentCanvasSizeLabel.BackColor = SystemColors.ScrollBar;
            currentCanvasSizeLabel.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
            currentCanvasSizeLabel.BorderStyle = Border3DStyle.SunkenOuter;
            currentCanvasSizeLabel.Margin = new Padding(2);
            currentCanvasSizeLabel.Name = "currentCanvasSizeLabel";
            currentCanvasSizeLabel.Size = new Size(265, 24);
            currentCanvasSizeLabel.Spring = true;
            // 
            // currentZoomStatusBarLabel
            // 
            currentZoomStatusBarLabel.BackColor = SystemColors.ScrollBar;
            currentZoomStatusBarLabel.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
            currentZoomStatusBarLabel.BorderStyle = Border3DStyle.SunkenOuter;
            currentZoomStatusBarLabel.Margin = new Padding(2);
            currentZoomStatusBarLabel.Name = "currentZoomStatusBarLabel";
            currentZoomStatusBarLabel.Size = new Size(265, 24);
            currentZoomStatusBarLabel.Spring = true;
            currentZoomStatusBarLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // canvasPanel
            // 
            canvasPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            canvasPanel.AutoScroll = true;
            canvasPanel.Controls.Add(Canvas);
            canvasPanel.Location = new Point(180, 100);
            canvasPanel.Margin = new Padding(5);
            canvasPanel.Name = "canvasPanel";
            canvasPanel.Size = new Size(963, 611);
            canvasPanel.TabIndex = 3;
            // 
            // Canvas
            // 
            Canvas.Location = new Point(5, 13);
            Canvas.Margin = new Padding(5);
            Canvas.Name = "Canvas";
            Canvas.Size = new Size(800, 600);
            Canvas.SizeMode = PictureBoxSizeMode.StretchImage;
            Canvas.TabIndex = 0;
            Canvas.TabStop = false;
            // 
            // toolPanel
            // 
            toolPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            toolPanel.AutoSize = true;
            toolPanel.BackColor = SystemColors.MenuBar;
            toolPanel.Controls.Add(lineButton);
            toolPanel.Controls.Add(selectButton);
            toolPanel.Controls.Add(penButton);
            toolPanel.Location = new Point(0, 35);
            toolPanel.Margin = new Padding(0);
            toolPanel.Name = "toolPanel";
            toolPanel.Size = new Size(180, 676);
            toolPanel.TabIndex = 4;
            // 
            // lineButton
            // 
            lineButton.Location = new Point(31, 134);
            lineButton.Name = "lineButton";
            lineButton.Size = new Size(112, 34);
            lineButton.TabIndex = 2;
            lineButton.Text = "Line";
            lineButton.UseVisualStyleBackColor = true;
            lineButton.Click += lineButton_Click;
            // 
            // selectButton
            // 
            selectButton.Location = new Point(31, 78);
            selectButton.Name = "selectButton";
            selectButton.Size = new Size(112, 34);
            selectButton.TabIndex = 1;
            selectButton.Text = "Select";
            selectButton.UseVisualStyleBackColor = true;
            selectButton.Click += selectButton_Click;
            // 
            // penButton
            // 
            penButton.Location = new Point(31, 26);
            penButton.Name = "penButton";
            penButton.Size = new Size(112, 34);
            penButton.TabIndex = 0;
            penButton.Text = "Pen";
            penButton.UseVisualStyleBackColor = true;
            penButton.Click += penButton_Click;
            // 
            // colorPalettePanel
            // 
            colorPalettePanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            colorPalettePanel.AutoSize = true;
            colorPalettePanel.BackColor = SystemColors.MenuBar;
            colorPalettePanel.Controls.Add(lastPickedColorButton);
            colorPalettePanel.Controls.Add(indigoButtonBottomPalette);
            colorPalettePanel.Controls.Add(blueButtonBottomPalette);
            colorPalettePanel.Controls.Add(royalBlueButtonBottomPalette);
            colorPalettePanel.Controls.Add(lightSkyBlueButtonBottomPalette);
            colorPalettePanel.Controls.Add(forestGreenButtonBottomPalette);
            colorPalettePanel.Controls.Add(greenYellowButtonBottomPlette);
            colorPalettePanel.Controls.Add(yellowButtonBottomPalette);
            colorPalettePanel.Controls.Add(goldButtonBottomPalette);
            colorPalettePanel.Controls.Add(darkOrangeButtonBottomPalette);
            colorPalettePanel.Controls.Add(redButtonBottomPalette);
            colorPalettePanel.Controls.Add(darkRedButtonBottomPalette);
            colorPalettePanel.Controls.Add(darkGreyButtonBottomPalette);
            colorPalettePanel.Controls.Add(dimGreyButtonBottomPalette);
            colorPalettePanel.Controls.Add(blackButtonBottomPalette);
            colorPalettePanel.Controls.Add(indigoButtonUpperPalette);
            colorPalettePanel.Controls.Add(blueButtonUpperPalette);
            colorPalettePanel.Controls.Add(royalBlueButtonUpperPalette);
            colorPalettePanel.Controls.Add(lightSkyBlueButtonUpperPalette);
            colorPalettePanel.Controls.Add(forestGreenButtonUpperPalette);
            colorPalettePanel.Controls.Add(greenYellowButtonBottomPalette);
            colorPalettePanel.Controls.Add(yellowButtonUpperPalette);
            colorPalettePanel.Controls.Add(goldButtonUpperPalette);
            colorPalettePanel.Controls.Add(darkOrangeButtonUpperPalette);
            colorPalettePanel.Controls.Add(redButtonUpperPalette);
            colorPalettePanel.Controls.Add(bdarkRedButtonUpperPalette);
            colorPalettePanel.Controls.Add(darkGreyButtonUpperPalette);
            colorPalettePanel.Controls.Add(dimGreyButtonUpperPalette);
            colorPalettePanel.Controls.Add(blackButtonUpperPalette);
            colorPalettePanel.Location = new Point(180, 35);
            colorPalettePanel.Margin = new Padding(0);
            colorPalettePanel.Name = "colorPalettePanel";
            colorPalettePanel.Size = new Size(963, 73);
            colorPalettePanel.TabIndex = 5;
            // 
            // lastPickedColorButton
            // 
            lastPickedColorButton.Location = new Point(5, 3);
            lastPickedColorButton.Name = "lastPickedColorButton";
            lastPickedColorButton.Size = new Size(63, 65);
            lastPickedColorButton.TabIndex = 28;
            lastPickedColorButton.UseVisualStyleBackColor = true;
            // 
            // indigoButtonBottomPalette
            // 
            indigoButtonBottomPalette.BackColor = Color.Indigo;
            indigoButtonBottomPalette.Location = new Point(594, 38);
            indigoButtonBottomPalette.Margin = new Padding(5);
            indigoButtonBottomPalette.Name = "indigoButtonBottomPalette";
            indigoButtonBottomPalette.Size = new Size(30, 30);
            indigoButtonBottomPalette.TabIndex = 27;
            indigoButtonBottomPalette.UseVisualStyleBackColor = false;
            // 
            // blueButtonBottomPalette
            // 
            blueButtonBottomPalette.BackColor = Color.Blue;
            blueButtonBottomPalette.Location = new Point(554, 38);
            blueButtonBottomPalette.Margin = new Padding(5);
            blueButtonBottomPalette.Name = "blueButtonBottomPalette";
            blueButtonBottomPalette.Size = new Size(30, 30);
            blueButtonBottomPalette.TabIndex = 26;
            blueButtonBottomPalette.UseVisualStyleBackColor = false;
            // 
            // royalBlueButtonBottomPalette
            // 
            royalBlueButtonBottomPalette.BackColor = Color.RoyalBlue;
            royalBlueButtonBottomPalette.Location = new Point(514, 38);
            royalBlueButtonBottomPalette.Margin = new Padding(5);
            royalBlueButtonBottomPalette.Name = "royalBlueButtonBottomPalette";
            royalBlueButtonBottomPalette.Size = new Size(30, 30);
            royalBlueButtonBottomPalette.TabIndex = 25;
            royalBlueButtonBottomPalette.UseVisualStyleBackColor = false;
            // 
            // lightSkyBlueButtonBottomPalette
            // 
            lightSkyBlueButtonBottomPalette.BackColor = Color.LightSkyBlue;
            lightSkyBlueButtonBottomPalette.Location = new Point(474, 38);
            lightSkyBlueButtonBottomPalette.Margin = new Padding(5);
            lightSkyBlueButtonBottomPalette.Name = "lightSkyBlueButtonBottomPalette";
            lightSkyBlueButtonBottomPalette.Size = new Size(30, 30);
            lightSkyBlueButtonBottomPalette.TabIndex = 24;
            lightSkyBlueButtonBottomPalette.UseVisualStyleBackColor = false;
            // 
            // forestGreenButtonBottomPalette
            // 
            forestGreenButtonBottomPalette.BackColor = Color.ForestGreen;
            forestGreenButtonBottomPalette.Location = new Point(434, 38);
            forestGreenButtonBottomPalette.Margin = new Padding(5);
            forestGreenButtonBottomPalette.Name = "forestGreenButtonBottomPalette";
            forestGreenButtonBottomPalette.Size = new Size(30, 30);
            forestGreenButtonBottomPalette.TabIndex = 23;
            forestGreenButtonBottomPalette.UseVisualStyleBackColor = false;
            // 
            // greenYellowButtonBottomPlette
            // 
            greenYellowButtonBottomPlette.BackColor = Color.GreenYellow;
            greenYellowButtonBottomPlette.Location = new Point(394, 38);
            greenYellowButtonBottomPlette.Margin = new Padding(5);
            greenYellowButtonBottomPlette.Name = "greenYellowButtonBottomPlette";
            greenYellowButtonBottomPlette.Size = new Size(30, 30);
            greenYellowButtonBottomPlette.TabIndex = 22;
            greenYellowButtonBottomPlette.UseVisualStyleBackColor = false;
            // 
            // yellowButtonBottomPalette
            // 
            yellowButtonBottomPalette.BackColor = Color.Yellow;
            yellowButtonBottomPalette.Location = new Point(354, 38);
            yellowButtonBottomPalette.Margin = new Padding(5);
            yellowButtonBottomPalette.Name = "yellowButtonBottomPalette";
            yellowButtonBottomPalette.Size = new Size(30, 30);
            yellowButtonBottomPalette.TabIndex = 21;
            yellowButtonBottomPalette.UseVisualStyleBackColor = false;
            // 
            // goldButtonBottomPalette
            // 
            goldButtonBottomPalette.BackColor = Color.Gold;
            goldButtonBottomPalette.Location = new Point(314, 38);
            goldButtonBottomPalette.Margin = new Padding(5);
            goldButtonBottomPalette.Name = "goldButtonBottomPalette";
            goldButtonBottomPalette.Size = new Size(30, 30);
            goldButtonBottomPalette.TabIndex = 20;
            goldButtonBottomPalette.UseVisualStyleBackColor = false;
            // 
            // darkOrangeButtonBottomPalette
            // 
            darkOrangeButtonBottomPalette.BackColor = Color.DarkOrange;
            darkOrangeButtonBottomPalette.Location = new Point(274, 38);
            darkOrangeButtonBottomPalette.Margin = new Padding(5);
            darkOrangeButtonBottomPalette.Name = "darkOrangeButtonBottomPalette";
            darkOrangeButtonBottomPalette.Size = new Size(30, 30);
            darkOrangeButtonBottomPalette.TabIndex = 19;
            darkOrangeButtonBottomPalette.UseVisualStyleBackColor = false;
            // 
            // redButtonBottomPalette
            // 
            redButtonBottomPalette.BackColor = Color.Red;
            redButtonBottomPalette.Location = new Point(234, 38);
            redButtonBottomPalette.Margin = new Padding(5);
            redButtonBottomPalette.Name = "redButtonBottomPalette";
            redButtonBottomPalette.Size = new Size(30, 30);
            redButtonBottomPalette.TabIndex = 18;
            redButtonBottomPalette.UseVisualStyleBackColor = false;
            // 
            // darkRedButtonBottomPalette
            // 
            darkRedButtonBottomPalette.BackColor = Color.DarkRed;
            darkRedButtonBottomPalette.Location = new Point(194, 38);
            darkRedButtonBottomPalette.Margin = new Padding(5);
            darkRedButtonBottomPalette.Name = "darkRedButtonBottomPalette";
            darkRedButtonBottomPalette.Size = new Size(30, 30);
            darkRedButtonBottomPalette.TabIndex = 17;
            darkRedButtonBottomPalette.UseVisualStyleBackColor = false;
            // 
            // darkGreyButtonBottomPalette
            // 
            darkGreyButtonBottomPalette.BackColor = Color.DarkGray;
            darkGreyButtonBottomPalette.Location = new Point(154, 38);
            darkGreyButtonBottomPalette.Margin = new Padding(5);
            darkGreyButtonBottomPalette.Name = "darkGreyButtonBottomPalette";
            darkGreyButtonBottomPalette.Size = new Size(30, 30);
            darkGreyButtonBottomPalette.TabIndex = 16;
            darkGreyButtonBottomPalette.UseVisualStyleBackColor = false;
            // 
            // dimGreyButtonBottomPalette
            // 
            dimGreyButtonBottomPalette.BackColor = Color.DimGray;
            dimGreyButtonBottomPalette.Location = new Point(114, 38);
            dimGreyButtonBottomPalette.Margin = new Padding(5);
            dimGreyButtonBottomPalette.Name = "dimGreyButtonBottomPalette";
            dimGreyButtonBottomPalette.Size = new Size(30, 30);
            dimGreyButtonBottomPalette.TabIndex = 15;
            dimGreyButtonBottomPalette.UseVisualStyleBackColor = false;
            // 
            // blackButtonBottomPalette
            // 
            blackButtonBottomPalette.BackColor = Color.Black;
            blackButtonBottomPalette.Location = new Point(76, 38);
            blackButtonBottomPalette.Margin = new Padding(5);
            blackButtonBottomPalette.Name = "blackButtonBottomPalette";
            blackButtonBottomPalette.Size = new Size(30, 30);
            blackButtonBottomPalette.TabIndex = 14;
            blackButtonBottomPalette.UseVisualStyleBackColor = false;
            // 
            // indigoButtonUpperPalette
            // 
            indigoButtonUpperPalette.BackColor = Color.Indigo;
            indigoButtonUpperPalette.Location = new Point(594, 3);
            indigoButtonUpperPalette.Margin = new Padding(5);
            indigoButtonUpperPalette.Name = "indigoButtonUpperPalette";
            indigoButtonUpperPalette.Size = new Size(30, 30);
            indigoButtonUpperPalette.TabIndex = 13;
            indigoButtonUpperPalette.UseVisualStyleBackColor = false;
            // 
            // blueButtonUpperPalette
            // 
            blueButtonUpperPalette.BackColor = Color.Blue;
            blueButtonUpperPalette.Location = new Point(554, 3);
            blueButtonUpperPalette.Margin = new Padding(5);
            blueButtonUpperPalette.Name = "blueButtonUpperPalette";
            blueButtonUpperPalette.Size = new Size(30, 30);
            blueButtonUpperPalette.TabIndex = 12;
            blueButtonUpperPalette.UseVisualStyleBackColor = false;
            // 
            // royalBlueButtonUpperPalette
            // 
            royalBlueButtonUpperPalette.BackColor = Color.RoyalBlue;
            royalBlueButtonUpperPalette.Location = new Point(514, 3);
            royalBlueButtonUpperPalette.Margin = new Padding(5);
            royalBlueButtonUpperPalette.Name = "royalBlueButtonUpperPalette";
            royalBlueButtonUpperPalette.Size = new Size(30, 30);
            royalBlueButtonUpperPalette.TabIndex = 11;
            royalBlueButtonUpperPalette.UseVisualStyleBackColor = false;
            // 
            // lightSkyBlueButtonUpperPalette
            // 
            lightSkyBlueButtonUpperPalette.BackColor = Color.LightSkyBlue;
            lightSkyBlueButtonUpperPalette.Location = new Point(474, 3);
            lightSkyBlueButtonUpperPalette.Margin = new Padding(5);
            lightSkyBlueButtonUpperPalette.Name = "lightSkyBlueButtonUpperPalette";
            lightSkyBlueButtonUpperPalette.Size = new Size(30, 30);
            lightSkyBlueButtonUpperPalette.TabIndex = 10;
            lightSkyBlueButtonUpperPalette.UseVisualStyleBackColor = false;
            // 
            // forestGreenButtonUpperPalette
            // 
            forestGreenButtonUpperPalette.BackColor = Color.ForestGreen;
            forestGreenButtonUpperPalette.Location = new Point(434, 3);
            forestGreenButtonUpperPalette.Margin = new Padding(5);
            forestGreenButtonUpperPalette.Name = "forestGreenButtonUpperPalette";
            forestGreenButtonUpperPalette.Size = new Size(30, 30);
            forestGreenButtonUpperPalette.TabIndex = 9;
            forestGreenButtonUpperPalette.UseVisualStyleBackColor = false;
            // 
            // greenYellowButtonBottomPalette
            // 
            greenYellowButtonBottomPalette.BackColor = Color.GreenYellow;
            greenYellowButtonBottomPalette.Location = new Point(394, 3);
            greenYellowButtonBottomPalette.Margin = new Padding(5);
            greenYellowButtonBottomPalette.Name = "greenYellowButtonBottomPalette";
            greenYellowButtonBottomPalette.Size = new Size(30, 30);
            greenYellowButtonBottomPalette.TabIndex = 8;
            greenYellowButtonBottomPalette.UseVisualStyleBackColor = false;
            // 
            // yellowButtonUpperPalette
            // 
            yellowButtonUpperPalette.BackColor = Color.Yellow;
            yellowButtonUpperPalette.Location = new Point(354, 3);
            yellowButtonUpperPalette.Margin = new Padding(5);
            yellowButtonUpperPalette.Name = "yellowButtonUpperPalette";
            yellowButtonUpperPalette.Size = new Size(30, 30);
            yellowButtonUpperPalette.TabIndex = 7;
            yellowButtonUpperPalette.UseVisualStyleBackColor = false;
            // 
            // goldButtonUpperPalette
            // 
            goldButtonUpperPalette.BackColor = Color.Gold;
            goldButtonUpperPalette.Location = new Point(314, 3);
            goldButtonUpperPalette.Margin = new Padding(5);
            goldButtonUpperPalette.Name = "goldButtonUpperPalette";
            goldButtonUpperPalette.Size = new Size(30, 30);
            goldButtonUpperPalette.TabIndex = 6;
            goldButtonUpperPalette.UseVisualStyleBackColor = false;
            // 
            // darkOrangeButtonUpperPalette
            // 
            darkOrangeButtonUpperPalette.BackColor = Color.DarkOrange;
            darkOrangeButtonUpperPalette.Location = new Point(274, 3);
            darkOrangeButtonUpperPalette.Margin = new Padding(5);
            darkOrangeButtonUpperPalette.Name = "darkOrangeButtonUpperPalette";
            darkOrangeButtonUpperPalette.Size = new Size(30, 30);
            darkOrangeButtonUpperPalette.TabIndex = 5;
            darkOrangeButtonUpperPalette.UseVisualStyleBackColor = false;
            // 
            // redButtonUpperPalette
            // 
            redButtonUpperPalette.BackColor = Color.Red;
            redButtonUpperPalette.Location = new Point(234, 3);
            redButtonUpperPalette.Margin = new Padding(5);
            redButtonUpperPalette.Name = "redButtonUpperPalette";
            redButtonUpperPalette.Size = new Size(30, 30);
            redButtonUpperPalette.TabIndex = 4;
            redButtonUpperPalette.UseVisualStyleBackColor = false;
            // 
            // bdarkRedButtonUpperPalette
            // 
            bdarkRedButtonUpperPalette.BackColor = Color.DarkRed;
            bdarkRedButtonUpperPalette.Location = new Point(194, 3);
            bdarkRedButtonUpperPalette.Margin = new Padding(5);
            bdarkRedButtonUpperPalette.Name = "bdarkRedButtonUpperPalette";
            bdarkRedButtonUpperPalette.Size = new Size(30, 30);
            bdarkRedButtonUpperPalette.TabIndex = 3;
            bdarkRedButtonUpperPalette.UseVisualStyleBackColor = false;
            // 
            // darkGreyButtonUpperPalette
            // 
            darkGreyButtonUpperPalette.BackColor = Color.DarkGray;
            darkGreyButtonUpperPalette.Location = new Point(154, 3);
            darkGreyButtonUpperPalette.Margin = new Padding(5);
            darkGreyButtonUpperPalette.Name = "darkGreyButtonUpperPalette";
            darkGreyButtonUpperPalette.Size = new Size(30, 30);
            darkGreyButtonUpperPalette.TabIndex = 2;
            darkGreyButtonUpperPalette.UseVisualStyleBackColor = false;
            // 
            // dimGreyButtonUpperPalette
            // 
            dimGreyButtonUpperPalette.BackColor = Color.DimGray;
            dimGreyButtonUpperPalette.Location = new Point(114, 3);
            dimGreyButtonUpperPalette.Margin = new Padding(5);
            dimGreyButtonUpperPalette.Name = "dimGreyButtonUpperPalette";
            dimGreyButtonUpperPalette.Size = new Size(30, 30);
            dimGreyButtonUpperPalette.TabIndex = 1;
            dimGreyButtonUpperPalette.UseVisualStyleBackColor = false;
            // 
            // blackButtonUpperPalette
            // 
            blackButtonUpperPalette.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            blackButtonUpperPalette.BackColor = Color.Black;
            blackButtonUpperPalette.Location = new Point(76, 3);
            blackButtonUpperPalette.Name = "blackButtonUpperPalette";
            blackButtonUpperPalette.Size = new Size(30, 30);
            blackButtonUpperPalette.TabIndex = 0;
            blackButtonUpperPalette.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(colorPalettePanel);
            Controls.Add(toolPanel);
            Controls.Add(canvasPanel);
            Controls.Add(statusBar);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MS Paint";
            FormClosing += Form1_FormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusBar.ResumeLayout(false);
            statusBar.PerformLayout();
            canvasPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Canvas).EndInit();
            toolPanel.ResumeLayout(false);
            colorPalettePanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileMenuItem;
        private ToolStripMenuItem editMenuItem;
        private ToolStripMenuItem viewMenuItem;
        private ToolStripMenuItem imageMenuItem;
        private ToolStripMenuItem colorsMenuItem;
        private ToolStripMenuItem helpMenuItem;
        private ToolStripMenuItem newMenuItem;
        private ToolStripMenuItem openMenuItem;
        private ToolStripMenuItem saveMenuItem;
        private ToolStripMenuItem saveAsMenuItem;
        private ToolStripMenuItem printMenuItem;
        private ToolStripMenuItem exitMenuItem;
        private ToolStripMenuItem cutMenuItem;
        private ToolStripMenuItem copyMenuItem;
        private ToolStripMenuItem pasteMenuItem;
        private ToolStripMenuItem selectAllMenuItem;
        private StatusStrip statusBar;
        private ToolStripStatusLabel currentPositionStatusBarLabel;
        private ToolStripMenuItem editColorMenuItem;
        private ToolStripMenuItem invertColorsMenuItem;
        private ToolStripMenuItem aboutMenuItem;
        private Panel canvasPanel;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripSeparator toolStripSeparator4;
        private Panel toolPanel;
        private Panel colorPalettePanel;
        private Button lineButton;
        private Button selectButton;
        private Button penButton;
        private ToolStripStatusLabel currentCanvasSizeLabel;
        private ColorDialog colorDialog1;
        private ToolStripMenuItem zoomToolStripMenuItem;
        private ToolStripMenuItem zoomInMenuItem;
        private ToolStripMenuItem zoomOutMenuItem;
        private ToolStripMenuItem resetZoomMenuItem;
        private ToolStripStatusLabel selectionStatusBarLabel;
        private ToolStripStatusLabel currentZoomStatusBarLabel;
        private PictureBox Canvas;
        private Button indigoButtonUpperPalette;
        private Button blueButtonUpperPalette;
        private Button royalBlueButtonUpperPalette;
        private Button lightSkyBlueButtonUpperPalette;
        private Button forestGreenButtonUpperPalette;
        private Button greenYellowButtonBottomPalette;
        private Button yellowButtonUpperPalette;
        private Button goldButtonUpperPalette;
        private Button darkOrangeButtonUpperPalette;
        private Button redButtonUpperPalette;
        private Button bdarkRedButtonUpperPalette;
        private Button darkGreyButtonUpperPalette;
        private Button dimGreyButtonUpperPalette;
        private Button blackButtonUpperPalette;
        private Button indigoButtonBottomPalette;
        private Button blueButtonBottomPalette;
        private Button royalBlueButtonBottomPalette;
        private Button lightSkyBlueButtonBottomPalette;
        private Button forestGreenButtonBottomPalette;
        private Button greenYellowButtonBottomPlette;
        private Button yellowButtonBottomPalette;
        private Button goldButtonBottomPalette;
        private Button darkOrangeButtonBottomPalette;
        private Button redButtonBottomPalette;
        private Button darkRedButtonBottomPalette;
        private Button darkGreyButtonBottomPalette;
        private Button dimGreyButtonBottomPalette;
        private Button blackButtonBottomPalette;
        private Button lastPickedColorButton;
        private ToolStripMenuItem openedFilesMenuItem;
        private ToolStripTextBox TextBox;
    }
}
