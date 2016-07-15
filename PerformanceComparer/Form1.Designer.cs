namespace PerformanceComparer
{
    partial class MainForm
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
            this.radioButtonStack = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonQueue = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxMethodList = new System.Windows.Forms.ComboBox();
            this.listBoxResults = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.groupBoxAmountOfValues = new System.Windows.Forms.GroupBox();
            this.textBoxTextBoxAmountOfValues = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBoxAmountOfValues.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButtonStack
            // 
            this.radioButtonStack.AutoSize = true;
            this.radioButtonStack.Location = new System.Drawing.Point(7, 20);
            this.radioButtonStack.Name = "radioButtonStack";
            this.radioButtonStack.Size = new System.Drawing.Size(53, 17);
            this.radioButtonStack.TabIndex = 0;
            this.radioButtonStack.TabStop = true;
            this.radioButtonStack.Text = "Stack";
            this.radioButtonStack.UseVisualStyleBackColor = true;
            this.radioButtonStack.CheckedChanged += new System.EventHandler(this.radioButtonStack_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonQueue);
            this.groupBox1.Controls.Add(this.radioButtonStack);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(107, 69);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buffer Type";
            // 
            // radioButtonQueue
            // 
            this.radioButtonQueue.AutoSize = true;
            this.radioButtonQueue.Location = new System.Drawing.Point(7, 43);
            this.radioButtonQueue.Name = "radioButtonQueue";
            this.radioButtonQueue.Size = new System.Drawing.Size(57, 17);
            this.radioButtonQueue.TabIndex = 1;
            this.radioButtonQueue.TabStop = true;
            this.radioButtonQueue.Text = "Queue";
            this.radioButtonQueue.UseVisualStyleBackColor = true;
            this.radioButtonQueue.CheckedChanged += new System.EventHandler(this.radioButtonQueue_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxMethodList);
            this.groupBox2.Location = new System.Drawing.Point(12, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(107, 52);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Method";
            // 
            // comboBoxMethodList
            // 
            this.comboBoxMethodList.FormattingEnabled = true;
            this.comboBoxMethodList.Location = new System.Drawing.Point(7, 20);
            this.comboBoxMethodList.Name = "comboBoxMethodList";
            this.comboBoxMethodList.Size = new System.Drawing.Size(94, 21);
            this.comboBoxMethodList.TabIndex = 0;
            this.comboBoxMethodList.SelectedIndexChanged += new System.EventHandler(this.comboBoxMethodList_SelectedIndexChanged);
            // 
            // listBoxResults
            // 
            this.listBoxResults.FormattingEnabled = true;
            this.listBoxResults.Location = new System.Drawing.Point(6, 19);
            this.listBoxResults.Name = "listBoxResults";
            this.listBoxResults.Size = new System.Drawing.Size(391, 212);
            this.listBoxResults.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listBoxResults);
            this.groupBox3.Location = new System.Drawing.Point(125, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(403, 241);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Results";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(19, 201);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 5;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(19, 230);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 6;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // groupBoxAmountOfValues
            // 
            this.groupBoxAmountOfValues.Controls.Add(this.textBoxTextBoxAmountOfValues);
            this.groupBoxAmountOfValues.Location = new System.Drawing.Point(12, 145);
            this.groupBoxAmountOfValues.Name = "groupBoxAmountOfValues";
            this.groupBoxAmountOfValues.Size = new System.Drawing.Size(107, 50);
            this.groupBoxAmountOfValues.TabIndex = 7;
            this.groupBoxAmountOfValues.TabStop = false;
            this.groupBoxAmountOfValues.Text = "Amount of values";
            // 
            // textBoxTextBoxAmountOfValues
            // 
            this.textBoxTextBoxAmountOfValues.Location = new System.Drawing.Point(6, 19);
            this.textBoxTextBoxAmountOfValues.Name = "textBoxTextBoxAmountOfValues";
            this.textBoxTextBoxAmountOfValues.Size = new System.Drawing.Size(95, 20);
            this.textBoxTextBoxAmountOfValues.TabIndex = 8;
            this.textBoxTextBoxAmountOfValues.TextChanged += new System.EventHandler(this.textBoxTextBoxAmountOfValues_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 261);
            this.Controls.Add(this.groupBoxAmountOfValues);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Performance Comparer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBoxAmountOfValues.ResumeLayout(false);
            this.groupBoxAmountOfValues.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonStack;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonQueue;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxMethodList;
        private System.Windows.Forms.ListBox listBoxResults;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.GroupBox groupBoxAmountOfValues;
        private System.Windows.Forms.TextBox textBoxTextBoxAmountOfValues;
    }
}

