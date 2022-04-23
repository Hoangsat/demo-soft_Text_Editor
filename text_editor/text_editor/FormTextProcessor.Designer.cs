namespace text_editor
{
    partial class FormTextProcessor
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTextProcessor));
            this.open_fd = new System.Windows.Forms.OpenFileDialog();
            this.save_fd = new System.Windows.Forms.SaveFileDialog();
            this.button_open_file = new System.Windows.Forms.Button();
            this.button_save_file = new System.Windows.Forms.Button();
            this.text_editor = new System.Windows.Forms.TextBox();
            this.text_pattern = new System.Windows.Forms.TextBox();
            this.button_replace = new System.Windows.Forms.Button();
            this.label_pattern = new System.Windows.Forms.Label();
            this.label_replace = new System.Windows.Forms.Label();
            this.text_replace = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // open_fd
            // 
            this.open_fd.FileName = "openFileDialog1";
            // 
            // button_open_file
            // 
            this.button_open_file.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_open_file.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_open_file.Location = new System.Drawing.Point(14, 12);
            this.button_open_file.Name = "button_open_file";
            this.button_open_file.Size = new System.Drawing.Size(94, 38);
            this.button_open_file.TabIndex = 0;
            this.button_open_file.Text = "Open file";
            this.button_open_file.UseVisualStyleBackColor = true;
            this.button_open_file.Click += new System.EventHandler(this.open_file_Click);
            // 
            // button_save_file
            // 
            this.button_save_file.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_save_file.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_save_file.Location = new System.Drawing.Point(135, 12);
            this.button_save_file.Name = "button_save_file";
            this.button_save_file.Size = new System.Drawing.Size(92, 38);
            this.button_save_file.TabIndex = 1;
            this.button_save_file.Text = "Save";
            this.button_save_file.UseVisualStyleBackColor = true;
            this.button_save_file.Click += new System.EventHandler(this.button_save_file_Click);
            // 
            // text_editor
            // 
            this.text_editor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_editor.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_editor.Location = new System.Drawing.Point(12, 75);
            this.text_editor.Multiline = true;
            this.text_editor.Name = "text_editor";
            this.text_editor.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.text_editor.Size = new System.Drawing.Size(707, 433);
            this.text_editor.TabIndex = 2;
            this.text_editor.WordWrap = false;
            // 
            // text_pattern
            // 
            this.text_pattern.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_pattern.Location = new System.Drawing.Point(250, 29);
            this.text_pattern.Name = "text_pattern";
            this.text_pattern.Size = new System.Drawing.Size(165, 24);
            this.text_pattern.TabIndex = 3;
            // 
            // button_replace
            // 
            this.button_replace.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_replace.Location = new System.Drawing.Point(616, 14);
            this.button_replace.Name = "button_replace";
            this.button_replace.Size = new System.Drawing.Size(90, 39);
            this.button_replace.TabIndex = 5;
            this.button_replace.Text = "Start";
            this.button_replace.UseVisualStyleBackColor = true;
            this.button_replace.Click += new System.EventHandler(this.button_replace_Click);
            
            // 
            // label_pattern
            // 
            this.label_pattern.AutoSize = true;
            this.label_pattern.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_pattern.Location = new System.Drawing.Point(268, 9);
            this.label_pattern.Name = "label_pattern";
            this.label_pattern.Size = new System.Drawing.Size(55, 18);
            this.label_pattern.TabIndex = 6;
            this.label_pattern.Text = "Search";
            // 
            // label_replace
            // 
            this.label_replace.AutoSize = true;
            this.label_replace.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_replace.Location = new System.Drawing.Point(470, 9);
            this.label_replace.Name = "label_replace";
            this.label_replace.Size = new System.Drawing.Size(73, 18);
            this.label_replace.TabIndex = 7;
            this.label_replace.Text = "Replacing";
            // 
            // text_replace
            // 
            this.text_replace.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_replace.Location = new System.Drawing.Point(434, 30);
            this.text_replace.Name = "text_replace";
            this.text_replace.Size = new System.Drawing.Size(165, 24);
            this.text_replace.TabIndex = 8;
            // 
            // FormTextProcessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 520);
            this.Controls.Add(this.text_replace);
            this.Controls.Add(this.label_replace);
            this.Controls.Add(this.label_pattern);
            this.Controls.Add(this.button_replace);
            this.Controls.Add(this.text_pattern);
            this.Controls.Add(this.text_editor);
            this.Controls.Add(this.button_save_file);
            this.Controls.Add(this.button_open_file);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "FormTextProcessor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text Processor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog open_fd;
        private System.Windows.Forms.SaveFileDialog save_fd;
        private System.Windows.Forms.Button button_open_file;
        private System.Windows.Forms.Button button_save_file;
        private System.Windows.Forms.TextBox text_editor;
        private System.Windows.Forms.TextBox text_pattern;
        private System.Windows.Forms.Button button_replace;
        private System.Windows.Forms.Label label_pattern;
        private System.Windows.Forms.Label label_replace;
        private System.Windows.Forms.TextBox text_replace;
    }
}

