﻿namespace AppRegex;

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
        buttonSendEmail = new Button();
        textBoxEmail = new TextBox();
        label1 = new Label();
        SuspendLayout();
        // 
        // buttonSendEmail
        // 
        buttonSendEmail.Location = new Point(376, 28);
        buttonSendEmail.Name = "buttonSendEmail";
        buttonSendEmail.Size = new Size(121, 23);
        buttonSendEmail.TabIndex = 0;
        buttonSendEmail.Text = "Send Email";
        buttonSendEmail.UseVisualStyleBackColor = true;
        buttonSendEmail.Click += buttonSendEmail_Click;
        // 
        // textBoxEmail
        // 
        textBoxEmail.Location = new Point(88, 28);
        textBoxEmail.Name = "textBoxEmail";
        textBoxEmail.Size = new Size(272, 23);
        textBoxEmail.TabIndex = 1;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(52, 31);
        label1.Name = "label1";
        label1.Size = new Size(19, 15);
        label1.TabIndex = 2;
        label1.Text = "To";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(label1);
        Controls.Add(textBoxEmail);
        Controls.Add(buttonSendEmail);
        Name = "Form1";
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button buttonSendEmail;
    private TextBox textBoxEmail;
    private Label label1;
}
