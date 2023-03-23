namespace lab5
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nValue = new System.Windows.Forms.TextBox();
            this.kValue = new System.Windows.Forms.TextBox();
            this.taskResult = new System.Windows.Forms.TextBox();
            this.asyncResult = new System.Windows.Forms.TextBox();
            this.delegatesResult = new System.Windows.Forms.TextBox();
            this.Task = new System.Windows.Forms.Button();
            this.Delegates = new System.Windows.Forms.Button();
            this.Async = new System.Windows.Forms.Button();
            this.nFibValue = new System.Windows.Forms.NumericUpDown();
            this.startAsyncButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.resultLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label4 = new System.Windows.Forms.Label();
            this.compressButton = new System.Windows.Forms.Button();
            this.decompressButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nFibValue)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "N";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "K";
            // 
            // nValue
            // 
            this.nValue.Location = new System.Drawing.Point(38, 12);
            this.nValue.Margin = new System.Windows.Forms.Padding(2);
            this.nValue.Name = "nValue";
            this.nValue.Size = new System.Drawing.Size(68, 20);
            this.nValue.TabIndex = 2;
            // 
            // kValue
            // 
            this.kValue.Location = new System.Drawing.Point(38, 34);
            this.kValue.Margin = new System.Windows.Forms.Padding(2);
            this.kValue.Name = "kValue";
            this.kValue.Size = new System.Drawing.Size(68, 20);
            this.kValue.TabIndex = 3;
            // 
            // taskResult
            // 
            this.taskResult.Location = new System.Drawing.Point(174, 12);
            this.taskResult.Margin = new System.Windows.Forms.Padding(2);
            this.taskResult.Name = "taskResult";
            this.taskResult.Size = new System.Drawing.Size(68, 20);
            this.taskResult.TabIndex = 4;
            // 
            // asyncResult
            // 
            this.asyncResult.Location = new System.Drawing.Point(174, 55);
            this.asyncResult.Margin = new System.Windows.Forms.Padding(2);
            this.asyncResult.Name = "asyncResult";
            this.asyncResult.Size = new System.Drawing.Size(68, 20);
            this.asyncResult.TabIndex = 5;
            // 
            // delegatesResult
            // 
            this.delegatesResult.Location = new System.Drawing.Point(174, 34);
            this.delegatesResult.Margin = new System.Windows.Forms.Padding(2);
            this.delegatesResult.Name = "delegatesResult";
            this.delegatesResult.Size = new System.Drawing.Size(68, 20);
            this.delegatesResult.TabIndex = 6;
            // 
            // Task
            // 
            this.Task.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Task.Location = new System.Drawing.Point(120, 14);
            this.Task.Margin = new System.Windows.Forms.Padding(2);
            this.Task.Name = "Task";
            this.Task.Size = new System.Drawing.Size(50, 15);
            this.Task.TabIndex = 7;
            this.Task.Text = "Task";
            this.Task.UseVisualStyleBackColor = true;
            this.Task.Click += new System.EventHandler(this.button1_Click);
            // 
            // Delegates
            // 
            this.Delegates.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Delegates.Location = new System.Drawing.Point(120, 35);
            this.Delegates.Margin = new System.Windows.Forms.Padding(2);
            this.Delegates.Name = "Delegates";
            this.Delegates.Size = new System.Drawing.Size(50, 15);
            this.Delegates.TabIndex = 8;
            this.Delegates.Text = "Delegates";
            this.Delegates.UseVisualStyleBackColor = true;
            this.Delegates.Click += new System.EventHandler(this.Delegates_Click);
            // 
            // Async
            // 
            this.Async.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Async.Location = new System.Drawing.Point(120, 57);
            this.Async.Margin = new System.Windows.Forms.Padding(2);
            this.Async.Name = "Async";
            this.Async.Size = new System.Drawing.Size(50, 15);
            this.Async.TabIndex = 9;
            this.Async.Text = "Async";
            this.Async.UseVisualStyleBackColor = true;
            this.Async.Click += new System.EventHandler(this.Async_Click);
            // 
            // nFibValue
            // 
            this.nFibValue.Location = new System.Drawing.Point(10, 116);
            this.nFibValue.Margin = new System.Windows.Forms.Padding(2);
            this.nFibValue.Maximum = new decimal(new int[] {
            91,
            0,
            0,
            0});
            this.nFibValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nFibValue.Name = "nFibValue";
            this.nFibValue.Size = new System.Drawing.Size(53, 20);
            this.nFibValue.TabIndex = 10;
            this.nFibValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // startAsyncButton
            // 
            this.startAsyncButton.Location = new System.Drawing.Point(10, 153);
            this.startAsyncButton.Margin = new System.Windows.Forms.Padding(2);
            this.startAsyncButton.Name = "startAsyncButton";
            this.startAsyncButton.Size = new System.Drawing.Size(81, 20);
            this.startAsyncButton.TabIndex = 11;
            this.startAsyncButton.Text = "Start Async";
            this.startAsyncButton.Click += new System.EventHandler(this.startAsyncButton_Click_1);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(11, 137);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(171, 5);
            this.progressBar1.Step = 2;
            this.progressBar1.TabIndex = 13;
            // 
            // resultLabel
            // 
            this.resultLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.resultLabel.Location = new System.Drawing.Point(74, 116);
            this.resultLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(107, 15);
            this.resultLabel.TabIndex = 12;
            this.resultLabel.Text = "(no result)";
            this.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Fibonacci";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(227, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Compression";
            // 
            // compressButton
            // 
            this.compressButton.Location = new System.Drawing.Point(219, 119);
            this.compressButton.Name = "compressButton";
            this.compressButton.Size = new System.Drawing.Size(75, 23);
            this.compressButton.TabIndex = 16;
            this.compressButton.Text = "Compress";
            this.compressButton.UseVisualStyleBackColor = true;
            this.compressButton.Click += new System.EventHandler(this.compressButton_Click);
            // 
            // decompressButton
            // 
            this.decompressButton.Location = new System.Drawing.Point(300, 119);
            this.decompressButton.Name = "decompressButton";
            this.decompressButton.Size = new System.Drawing.Size(75, 23);
            this.decompressButton.TabIndex = 17;
            this.decompressButton.Text = "Decompress";
            this.decompressButton.UseVisualStyleBackColor = true;
            this.decompressButton.Click += new System.EventHandler(this.decompressButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 365);
            this.Controls.Add(this.decompressButton);
            this.Controls.Add(this.compressButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.startAsyncButton);
            this.Controls.Add(this.nFibValue);
            this.Controls.Add(this.Async);
            this.Controls.Add(this.Delegates);
            this.Controls.Add(this.Task);
            this.Controls.Add(this.delegatesResult);
            this.Controls.Add(this.asyncResult);
            this.Controls.Add(this.taskResult);
            this.Controls.Add(this.kValue);
            this.Controls.Add(this.nValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nFibValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nValue;
        private System.Windows.Forms.TextBox kValue;
        private System.Windows.Forms.TextBox taskResult;
        private System.Windows.Forms.TextBox asyncResult;
        private System.Windows.Forms.TextBox delegatesResult;
        private System.Windows.Forms.Button Task;
        private System.Windows.Forms.Button Delegates;
        private System.Windows.Forms.Button Async;
        private System.Windows.Forms.NumericUpDown nFibValue;
        private System.Windows.Forms.Button startAsyncButton;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button compressButton;
        private System.Windows.Forms.Button decompressButton;
    }
}

