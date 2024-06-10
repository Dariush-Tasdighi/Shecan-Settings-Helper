namespace Application;

partial class LearningForm
{
	private System.ComponentModel.IContainer components = null;

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
		button1 = new System.Windows.Forms.Button();
		button2 = new System.Windows.Forms.Button();
		button3 = new System.Windows.Forms.Button();
		button4 = new System.Windows.Forms.Button();
		SuspendLayout();
		// 
		// button1
		// 
		button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		button1.Location = new System.Drawing.Point(16, 14);
		button1.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
		button1.Name = "button1";
		button1.Size = new System.Drawing.Size(466, 107);
		button1.TabIndex = 0;
		button1.Text = "button1";
		button1.UseVisualStyleBackColor = true;
		button1.Click += Button1_Click;
		// 
		// button2
		// 
		button2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		button2.Location = new System.Drawing.Point(16, 131);
		button2.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
		button2.Name = "button2";
		button2.Size = new System.Drawing.Size(466, 107);
		button2.TabIndex = 1;
		button2.Text = "button2";
		button2.UseVisualStyleBackColor = true;
		button2.Click += Button2_Click;
		// 
		// button3
		// 
		button3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		button3.Location = new System.Drawing.Point(16, 248);
		button3.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
		button3.Name = "button3";
		button3.Size = new System.Drawing.Size(466, 107);
		button3.TabIndex = 2;
		button3.Text = "button3";
		button3.UseVisualStyleBackColor = true;
		button3.Click += Button3_Click;
		// 
		// button4
		// 
		button4.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		button4.Location = new System.Drawing.Point(16, 365);
		button4.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
		button4.Name = "button4";
		button4.Size = new System.Drawing.Size(466, 107);
		button4.TabIndex = 3;
		button4.Text = "button4";
		button4.UseVisualStyleBackColor = true;
		button4.Click += Button4_Click;
		// 
		// LearningForm
		// 
		AutoScaleDimensions = new System.Drawing.SizeF(19F, 32F);
		AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		ClientSize = new System.Drawing.Size(498, 485);
		Controls.Add(button4);
		Controls.Add(button3);
		Controls.Add(button2);
		Controls.Add(button1);
		Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
		Name = "LearningForm";
		StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		Text = "Learning";
		Click += Button3_Click;
		ResumeLayout(false);
	}

	#endregion

	private System.Windows.Forms.Button button1;
	private System.Windows.Forms.Button button2;
	private System.Windows.Forms.Button button3;
	private System.Windows.Forms.Button button4;
}
