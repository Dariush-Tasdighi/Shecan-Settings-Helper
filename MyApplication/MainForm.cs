using System;
using System.Threading;
using System.Diagnostics;
using System.Windows.Forms;

namespace MyApplication;

public partial class MainForm : Form
{
	public MainForm()
	{
		InitializeComponent();
	}

	private void MainForm_Load(object sender, EventArgs e)
	{
		//TopMost = true;
		//SetTopLevel(value: true);

		FormBorderStyle =
			FormBorderStyle.FixedSingle;
	}

	private void SetButton_Click(object sender, EventArgs e)
	{
		var interfaceIndex =
			GetInterfaceIndex();

		var processInfo =
			new ProcessStartInfo
			{
				FileName = "powershell.exe",

				CreateNoWindow = true, // Default: [false]
				RedirectStandardOutput = true, // Default: [false]
			};

		if (professionalCheckBox.Checked)
		{
			processInfo.Arguments =
				$"Set-DnsClientServerAddress -InterfaceIndex {interfaceIndex} -ServerAddresses ('178.22.122.101','185.51.200.1')";
		}
		else
		{
			processInfo.Arguments =
				$"Set-DnsClientServerAddress -InterfaceIndex {interfaceIndex} -ServerAddresses ('178.22.122.100','185.51.200.2')";
		}

		using var process = new Process();

		process.StartInfo = processInfo;

		process.Start();
		process.WaitForExit();

		var output =
			process.StandardOutput.ReadToEnd();

		if (output == string.Empty)
		{
			MessageBox.Show
				(text: "Shecan DNS Set Successfully...");
		}
		else
		{
			MessageBox.Show(text: output);
		}
	}

	private void UnsetButton_Click(object sender, EventArgs e)
	{
		var interfaceIndex =
			GetInterfaceIndex();

		var processInfo =
			new ProcessStartInfo
			{
				FileName = "powershell.exe",

				CreateNoWindow = true, // Default: [false]
				RedirectStandardOutput = true, // Default: [false]

				Arguments = $"Set-DnsClientServerAddress -InterfaceIndex {interfaceIndex} -ResetServerAddresses",
			};

		using var process = new Process();

		process.StartInfo = processInfo;

		process.Start();
		process.WaitForExit();

		var output =
			process.StandardOutput.ReadToEnd();

		if (output == string.Empty)
		{
			MessageBox.Show
				(text: "DNS Set to Default Value Successfully...");
		}
		else
		{
			MessageBox.Show(text: output);
		}
	}

	private string GetInterfaceIndex()
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

		var interfaceIndex = output
			.Replace(oldValue: "InterfaceIndex", newValue: string.Empty)
			.Replace(oldValue: "-", newValue: string.Empty)
			.Replace(oldValue: Environment.NewLine, newValue: string.Empty)
			.Replace(oldValue: " ", newValue: string.Empty)
			;

		return interfaceIndex;
	}

	private void EnableNetworkAdapter()
	{
		var processInfo =
			new ProcessStartInfo
			{
				FileName = "powershell.exe",

				CreateNoWindow = true, // Default: [false]
				RedirectStandardOutput = true, // Default: [false]

				Arguments =
					"Enable-NetAdapter -Name Wi-Fi -Confirm:$false",
			};

		using var process = new Process();

		process.StartInfo = processInfo;

		process.Start();
		process.WaitForExit();

		var output =
			process.StandardOutput.ReadToEnd();
	}

	private void DisableNetworkAdapter()
	{
		var processInfo =
			new ProcessStartInfo
			{
				FileName = "powershell.exe",

				CreateNoWindow = true, // Default: [false]
				RedirectStandardOutput = true, // Default: [false]

				Arguments =
					"Disable-NetAdapter -Name Wi-Fi -Confirm:$false",
			};

		using var process = new Process();

		process.StartInfo = processInfo;

		process.Start();
		process.WaitForExit();

		var output =
			process.StandardOutput.ReadToEnd();
	}

	private void RestartNetworkAdapterButton_Click(object sender, EventArgs e)
	{
		DisableNetworkAdapter();
		Thread.Sleep(millisecondsTimeout: 5000);
		EnableNetworkAdapter();
	}
}
