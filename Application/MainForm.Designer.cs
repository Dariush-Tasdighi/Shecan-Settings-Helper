namespace Application;

partial class MainForm
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
	///  Required method for Designer support - do not modify
	///  the contents of this method with the code editor.
	/// </summary>
	private void InitializeComponent()
	{
		setDnsButton = new System.Windows.Forms.Button();
		unsetDnsButton = new System.Windows.Forms.Button();
		professionalCheckBox = new System.Windows.Forms.CheckBox();
		restartNetAdapterButton = new System.Windows.Forms.Button();
		SuspendLayout();
		// 
		// setDnsButton
		// 
		setDnsButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		setDnsButton.BackColor = System.Drawing.Color.Khaki;
		setDnsButton.FlatAppearance.BorderSize = 0;
		setDnsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		setDnsButton.Location = new System.Drawing.Point(12, 38);
		setDnsButton.Name = "setDnsButton";
		setDnsButton.Size = new System.Drawing.Size(218, 40);
		setDnsButton.TabIndex = 1;
		setDnsButton.Text = "&Set DNS";
		setDnsButton.UseVisualStyleBackColor = false;
		setDnsButton.Click += SetButton_Click;
		// 
		// unsetDnsButton
		// 
		unsetDnsButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		unsetDnsButton.BackColor = System.Drawing.Color.Khaki;
		unsetDnsButton.FlatAppearance.BorderSize = 0;
		unsetDnsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		unsetDnsButton.Location = new System.Drawing.Point(12, 84);
		unsetDnsButton.Name = "unsetDnsButton";
		unsetDnsButton.Size = new System.Drawing.Size(218, 40);
		unsetDnsButton.TabIndex = 2;
		unsetDnsButton.Text = "&Unset DNS";
		unsetDnsButton.UseVisualStyleBackColor = false;
		unsetDnsButton.Click += UnsetButton_Click;
		// 
		// professionalCheckBox
		// 
		professionalCheckBox.AutoSize = true;
		professionalCheckBox.Location = new System.Drawing.Point(11, 11);
		professionalCheckBox.Margin = new System.Windows.Forms.Padding(2);
		professionalCheckBox.Name = "professionalCheckBox";
		professionalCheckBox.Size = new System.Drawing.Size(130, 22);
		professionalCheckBox.TabIndex = 0;
		professionalCheckBox.Text = "&Professional";
		professionalCheckBox.UseVisualStyleBackColor = true;
		// 
		// restartNetAdapterButton
		// 
		restartNetAdapterButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		restartNetAdapterButton.BackColor = System.Drawing.Color.Khaki;
		restartNetAdapterButton.FlatAppearance.BorderSize = 0;
		restartNetAdapterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		restartNetAdapterButton.Location = new System.Drawing.Point(11, 130);
		restartNetAdapterButton.Name = "restartNetAdapterButton";
		restartNetAdapterButton.Size = new System.Drawing.Size(219, 40);
		restartNetAdapterButton.TabIndex = 3;
		restartNetAdapterButton.Text = "&Restart Net Adapter";
		restartNetAdapterButton.UseVisualStyleBackColor = false;
		restartNetAdapterButton.Click += RestartNetAdapterButton_Click;
		// 
		// MainForm
		// 
		AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
		AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		ClientSize = new System.Drawing.Size(242, 183);
		Controls.Add(restartNetAdapterButton);
		Controls.Add(professionalCheckBox);
		Controls.Add(unsetDnsButton);
		Controls.Add(setDnsButton);
		Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		MaximizeBox = false;
		MinimizeBox = false;
		Name = "MainForm";
		StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		Text = "Shecan Settings Helper";
		Load += MainForm_Load;
		ResumeLayout(false);
		PerformLayout();
	}

	#endregion

	private System.Windows.Forms.Button setDnsButton;
	private System.Windows.Forms.Button unsetDnsButton;
	private System.Windows.Forms.CheckBox professionalCheckBox;
	private System.Windows.Forms.Button restartNetAdapterButton;
}
