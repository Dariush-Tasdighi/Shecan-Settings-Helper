using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Application;

public partial class LearningForm : Form
{
	public LearningForm()
	{
		InitializeComponent();
	}

	/// <summary>
	/// Running: Windows Forms Application
	/// </summary>
	private void Button1_Click(object sender, EventArgs e)
	{
		using var process = new Process();

		process.StartInfo.FileName = @"Calc.exe";
		//process.StartInfo.FileName = @"C:\Windows\System32\Calc.exe";
		process.StartInfo.Arguments = string.Empty; // ""

		process.Start();

		//Close();
	}

	/// <summary>
	/// Running: Console Application - Sample (1)
	/// </summary>
	private void Button2_Click(object sender, EventArgs e)
	{
		using var process = new Process();

		process.StartInfo.FileName = @"dotnet.exe";
		process.StartInfo.Arguments = "--version";

		process.StartInfo.CreateNoWindow = true; // Default: [false]
		process.StartInfo.UseShellExecute = false; // Default: [false]
		process.StartInfo.RedirectStandardOutput = true; // Default: [false]
		process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden; // Default: [normal]

		process.Start();
		process.WaitForExit();

		var output =
			process.StandardOutput.ReadToEnd();

		MessageBox.Show(text: output);
	}

	/// <summary>
	/// Running: Console Application - Sample (2)
	/// </summary>
	private void Button3_Click(object sender, EventArgs e)
	{
		//var pathKey = "MyPath";
		//var keyName = "MyKeyName";

		//using var process = new Process();

		//// In Command Prompt:
		//// reg Add HKLM\SOFTWARE\MyKeyName /f
		//// reg Add MyPath\MyKeyName /f

		//process.StartInfo.FileName = @"reg.exe";
		////process.StartInfo.Arguments = $"Add MyPath\\MyKeyName /f";
		//process.StartInfo.Arguments = $"Add {pathKey}\\{keyName} /f";

		//process.StartInfo.CreateNoWindow = true; // Default: [false]
		//process.StartInfo.UseShellExecute = false; // Default: [false]
		//process.StartInfo.RedirectStandardOutput = true; // Default: [false]
		//process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden; // Default: [normal]

		//process.Start();
		//process.WaitForExit();

		//var output =
		//	process.StandardOutput.ReadToEnd();

		//MessageBox.Show(output);
	}

	/// <summary>
	/// Running: Console Application - PowerShell
	/// </summary>
	private void Button4_Click(object sender, EventArgs e)
	{
		var processInfo =
			new ProcessStartInfo
			{
				FileName = "powershell.exe",

				Verb = "runas",

				CreateNoWindow = true, // Default: [false]
				LoadUserProfile = true,
				UseShellExecute = false,// Default: [false]
				RedirectStandardOutput = true, // Default: [false]
				WindowStyle = ProcessWindowStyle.Hidden, // Default: [normal]

				Arguments = "Get-DnsClientServerAddress | Where-Object -Property \"InterfaceAlias\" -EQ -Value \"Wi-Fi\" | Where-Object -Property \"AddressFamily\" -EQ -Value \"2\" | Select-Object \"InterfaceIndex\"",
			};

		using var process = new Process();

		process.StartInfo = processInfo;

		process.Start();
		process.WaitForExit();

		var output =
			process.StandardOutput.ReadToEnd();

		MessageBox.Show(output);

		var interfaceIndex = output
			.Replace(oldValue: "InterfaceIndex", newValue: string.Empty)
			.Replace(oldValue: "-", newValue: string.Empty)
			.Replace(oldValue: Environment.NewLine, newValue: string.Empty)
			.Replace(oldValue: " ", newValue: string.Empty)
			;

		MessageBox.Show(interfaceIndex);
	}
}
