using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
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
		var processInfo =
			new ProcessStartInfo
			{
				FileName = "Calc.exe",
				Arguments = string.Empty,

				Verb = string.Empty, // Default: [""]
				WorkingDirectory = string.Empty, // Default: [""]

				ErrorDialog = false, // Default: [false]
				CreateNoWindow = false, // Default: [false]
				LoadUserProfile = false, // Default: [false]
				UseShellExecute = false,// Default: [false]

				StandardErrorEncoding = null, // Default: [null]
				StandardInputEncoding = null, // Default: [null]
				StandardOutputEncoding = null, // Default: [null]

				RedirectStandardError = false, // Default: [false]
				RedirectStandardInput = false, // Default: [false]
				RedirectStandardOutput = false, // Default: [false]

				Domain = string.Empty, // Default: [""]
				UserName = string.Empty, // Default: [""]
				Password = null, // Default: [null]
				PasswordInClearText = null, // Default: [null]
				UseCredentialsForNetworkingOnly = false, // Default: [false]

				// Note
				WindowStyle = ProcessWindowStyle.Normal, // Default: [normal]
			};

		using var process = new Process();

		process.StartInfo = processInfo;

		process.Start();

		// در صورتی که برنامه اصلی بسته شود
		// برنامه‌ای که اجرا شده است، بسته نخواهد شد
		//Close();
	}

	/// <summary>
	/// Running: Console Application - Sample (1)
	/// </summary>
	private void Button2_Click(object sender, EventArgs e)
	{
		var processInfo =
			new ProcessStartInfo
			{
				FileName = "dotnet.exe",
				Arguments = "--version",

				CreateNoWindow = true, // Default: [false]
				RedirectStandardOutput = true, // Default: [false]
			};

		using var process = new Process();

		process.StartInfo = processInfo;

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
		var pathKey = "MyPath";
		var keyName = "MyKeyName";

		var processInfo =
			new ProcessStartInfo
			{
				FileName = @"reg.exe",
				//Arguments = $"Add MyPath\\MyKeyName /f",
				Arguments = $"Add {pathKey}\\{keyName} /f",

				CreateNoWindow = true, // Default: [false]
				RedirectStandardOutput = true, // Default: [false]
			};

		using var process = new Process();

		process.StartInfo = processInfo;

		//process.Start();
		//process.WaitForExit();

		//var output =
		//	process.StandardOutput.ReadToEnd();

		//MessageBox.Show(text: output);
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

				CreateNoWindow = true, // Default: [false]
				RedirectStandardOutput = true, // Default: [false]

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
