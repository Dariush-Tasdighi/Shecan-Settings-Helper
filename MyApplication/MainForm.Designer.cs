namespace MyApplication;

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
		restartNetworkAdapterButton = new System.Windows.Forms.Button();
		notesLabel = new System.Windows.Forms.Label();
		poweredByLabel = new System.Windows.Forms.Label();
		sponsorLabel = new System.Windows.Forms.Label();
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
		setDnsButton.Size = new System.Drawing.Size(358, 40);
		setDnsButton.TabIndex = 1;
		setDnsButton.Text = "&Set DNS";
		setDnsButton.UseVisualStyleBackColor = false;
		setDnsButton.Click += SetDnsButton_Click;
		// 
		// unsetDnsButton
		// 
		unsetDnsButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		unsetDnsButton.BackColor = System.Drawing.Color.Khaki;
		unsetDnsButton.FlatAppearance.BorderSize = 0;
		unsetDnsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		unsetDnsButton.Location = new System.Drawing.Point(12, 84);
		unsetDnsButton.Name = "unsetDnsButton";
		unsetDnsButton.Size = new System.Drawing.Size(358, 40);
		unsetDnsButton.TabIndex = 2;
		unsetDnsButton.Text = "&Unset DNS";
		unsetDnsButton.UseVisualStyleBackColor = false;
		unsetDnsButton.Click += UnsetDnsButton_Click;
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
		// restartNetworkAdapterButton
		// 
		restartNetworkAdapterButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		restartNetworkAdapterButton.BackColor = System.Drawing.Color.Khaki;
		restartNetworkAdapterButton.FlatAppearance.BorderSize = 0;
		restartNetworkAdapterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		restartNetworkAdapterButton.Location = new System.Drawing.Point(11, 130);
		restartNetworkAdapterButton.Name = "restartNetworkAdapterButton";
		restartNetworkAdapterButton.Size = new System.Drawing.Size(359, 40);
		restartNetworkAdapterButton.TabIndex = 3;
		restartNetworkAdapterButton.Text = "&Restart Network Adapter";
		restartNetworkAdapterButton.UseVisualStyleBackColor = false;
		restartNetworkAdapterButton.Click += RestartNetworkAdapterButton_Click;
		// 
		// notesLabel
		// 
		notesLabel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		notesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		notesLabel.ForeColor = System.Drawing.Color.Red;
		notesLabel.Location = new System.Drawing.Point(12, 173);
		notesLabel.Name = "notesLabel";
		notesLabel.Size = new System.Drawing.Size(358, 53);
		notesLabel.TabIndex = 4;
		notesLabel.Text = "Run this application as Administrator!";
		notesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		// 
		// poweredByLabel
		// 
		poweredByLabel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		poweredByLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		poweredByLabel.ForeColor = System.Drawing.Color.Blue;
		poweredByLabel.Location = new System.Drawing.Point(12, 226);
		poweredByLabel.Name = "poweredByLabel";
		poweredByLabel.Size = new System.Drawing.Size(358, 53);
		poweredByLabel.TabIndex = 5;
		poweredByLabel.Text = "Powered by: Dariush Tasdighi";
		poweredByLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		// 
		// sponsorLabel
		// 
		sponsorLabel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
		sponsorLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		sponsorLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		sponsorLabel.ForeColor = System.Drawing.Color.Blue;
		sponsorLabel.Location = new System.Drawing.Point(11, 279);
		sponsorLabel.Name = "sponsorLabel";
		sponsorLabel.Size = new System.Drawing.Size(358, 53);
		sponsorLabel.TabIndex = 6;
		sponsorLabel.Text = "اسپانسر: شرکت مهندسی صنایع یاس ارغوانی";
		sponsorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		// 
		// MainForm
		// 
		AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
		AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		ClientSize = new System.Drawing.Size(382, 353);
		Controls.Add(sponsorLabel);
		Controls.Add(poweredByLabel);
		Controls.Add(notesLabel);
		Controls.Add(restartNetworkAdapterButton);
		Controls.Add(professionalCheckBox);
		Controls.Add(unsetDnsButton);
		Controls.Add(setDnsButton);
		Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		MaximizeBox = false;
		MinimizeBox = false;
		Name = "MainForm";
		StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		Text = "Shecan Settings Helper - Version: 1.0.5";
		Load += MainForm_Load;
		ResumeLayout(false);
		PerformLayout();
	}

	#endregion

	private System.Windows.Forms.Button setDnsButton;
	private System.Windows.Forms.Button unsetDnsButton;
	private System.Windows.Forms.CheckBox professionalCheckBox;
	private System.Windows.Forms.Button restartNetworkAdapterButton;
	private System.Windows.Forms.Label notesLabel;
	private System.Windows.Forms.Label poweredByLabel;
	private System.Windows.Forms.Label sponsorLabel;
}
