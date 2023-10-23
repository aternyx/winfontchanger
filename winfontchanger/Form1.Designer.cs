namespace winfontchanger
{
    partial class mainform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainform));
            toolbar_title = new System.Windows.Forms.Label();
            toolbar_dsgn = new System.Windows.Forms.Panel();
            toolbar = new System.Windows.Forms.Panel();
            minBtn = new System.Windows.Forms.Label();
            exitBtn = new System.Windows.Forms.Label();
            fontDialog1 = new System.Windows.Forms.FontDialog();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            fontfamily = new System.Windows.Forms.TextBox();
            fontfamilyChange = new System.Windows.Forms.Button();
            execute = new System.Windows.Forms.Button();
            resetDef = new System.Windows.Forms.Button();
            toolbar.SuspendLayout();
            SuspendLayout();
            // 
            // toolbar_title
            // 
            resources.ApplyResources(toolbar_title, "toolbar_title");
            toolbar_title.Name = "toolbar_title";
            toolbar_title.MouseMove += toolbar_title_MouseMove;
            // 
            // toolbar_dsgn
            // 
            toolbar_dsgn.BackColor = System.Drawing.Color.Maroon;
            resources.ApplyResources(toolbar_dsgn, "toolbar_dsgn");
            toolbar_dsgn.Name = "toolbar_dsgn";
            // 
            // toolbar
            // 
            toolbar.Controls.Add(minBtn);
            toolbar.Controls.Add(exitBtn);
            toolbar.Controls.Add(toolbar_title);
            toolbar.Controls.Add(toolbar_dsgn);
            resources.ApplyResources(toolbar, "toolbar");
            toolbar.Name = "toolbar";
            toolbar.MouseMove += toolbar_MouseMove;
            // 
            // minBtn
            // 
            minBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(minBtn, "minBtn");
            minBtn.Name = "minBtn";
            minBtn.Click += minBtn_Click;
            // 
            // exitBtn
            // 
            exitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(exitBtn, "exitBtn");
            exitBtn.Name = "exitBtn";
            exitBtn.Click += exitBtn_Click;
            // 
            // fontDialog1
            // 
            fontDialog1.ShowEffects = false;
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            // 
            // label5
            // 
            label5.BackColor = System.Drawing.Color.Transparent;
            label5.ForeColor = System.Drawing.Color.Silver;
            resources.ApplyResources(label5, "label5");
            label5.Name = "label5";
            // 
            // fontfamily
            // 
            fontfamily.BackColor = System.Drawing.Color.FromArgb(25, 25, 25);
            fontfamily.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            fontfamily.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(fontfamily, "fontfamily");
            fontfamily.Name = "fontfamily";
            fontfamily.TextChanged += fontfamily_TextChanged;
            // 
            // fontfamilyChange
            // 
            resources.ApplyResources(fontfamilyChange, "fontfamilyChange");
            fontfamilyChange.Name = "fontfamilyChange";
            fontfamilyChange.UseVisualStyleBackColor = true;
            fontfamilyChange.Click += button1_Click;
            // 
            // execute
            // 
            execute.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            resources.ApplyResources(execute, "execute");
            execute.Name = "execute";
            execute.UseVisualStyleBackColor = true;
            execute.Click += execute_Click;
            // 
            // resetDef
            // 
            resetDef.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            resources.ApplyResources(resetDef, "resetDef");
            resetDef.Name = "resetDef";
            resetDef.UseVisualStyleBackColor = true;
            resetDef.Click += resetDef_Click;
            // 
            // mainform
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Black;
            BackgroundImage = Properties.Resources.background;
            Controls.Add(resetDef);
            Controls.Add(execute);
            Controls.Add(fontfamilyChange);
            Controls.Add(fontfamily);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(toolbar);
            ForeColor = System.Drawing.Color.White;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            MaximizeBox = false;
            Name = "mainform";
            toolbar.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label toolbar_title;
        private System.Windows.Forms.Panel toolbar_dsgn;
        private System.Windows.Forms.Panel toolbar;
        private System.Windows.Forms.Label exitBtn;
        private System.Windows.Forms.Label minBtn;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox fontfamily;
        private System.Windows.Forms.Button fontfamilyChange;
        private System.Windows.Forms.Button execute;
        private System.Windows.Forms.Button resetDef;
    }
}
