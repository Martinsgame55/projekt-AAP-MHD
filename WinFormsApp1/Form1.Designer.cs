namespace WinFormsApp1;

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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        comboBox1 = new System.Windows.Forms.ComboBox();
        comboBox2 = new System.Windows.Forms.ComboBox();
        dataGridView1 = new System.Windows.Forms.DataGridView();
        pictureBox1 = new System.Windows.Forms.PictureBox();
        label2 = new System.Windows.Forms.Label();
        label1 = new System.Windows.Forms.Label();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // comboBox1
        // 
        comboBox1.FormattingEnabled = true;
        comboBox1.Location = new System.Drawing.Point(106, 32);
        comboBox1.Name = "comboBox1";
        comboBox1.Size = new System.Drawing.Size(166, 23);
        comboBox1.TabIndex = 0;
        // 
        // comboBox2
        // 
        comboBox2.FormattingEnabled = true;
        comboBox2.Location = new System.Drawing.Point(106, 87);
        comboBox2.Name = "comboBox2";
        comboBox2.Size = new System.Drawing.Size(165, 23);
        comboBox2.TabIndex = 1;
        // 
        // dataGridView1
        // 
        dataGridView1.Location = new System.Drawing.Point(71, 165);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.Size = new System.Drawing.Size(317, 203);
        dataGridView1.TabIndex = 2;
        // 
        // pictureBox1
        // 
        pictureBox1.Location = new System.Drawing.Point(429, 12);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new System.Drawing.Size(356, 426);
        pictureBox1.TabIndex = 3;
        pictureBox1.TabStop = false;
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(26, 87);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(57, 22);
        label2.TabIndex = 5;
        label2.Text = "linka";
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(26, 32);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(57, 22);
        label1.TabIndex = 6;
        label1.Text = "zastavky";
        label1.Click += label1_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(label1);
        Controls.Add(label2);
        Controls.Add(pictureBox1);
        Controls.Add(dataGridView1);
        Controls.Add(comboBox2);
        Controls.Add(comboBox1);
        Text = "Odjezdy autobusů";
        Load += Form1_Load;
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.TextBox textBox2;

    private System.Windows.Forms.TextBox textBox1;

    private System.Windows.Forms.ComboBox comboBox1;
    private System.Windows.Forms.ComboBox comboBox2;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.PictureBox pictureBox1;

    #endregion
}