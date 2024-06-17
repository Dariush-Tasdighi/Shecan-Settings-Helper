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

	private void EnableControls()
	{
		professionalCheckBox.Enabled = true;

		setDnsButton.Enabled = true;
		unsetDnsButton.Enabled = true;
		restartNetworkAdapterButton.Enabled = true;
	}

	private void DisableControls()
	{
		professionalCheckBox.Enabled = false;

		setDnsButton.Enabled = false;
		unsetDnsButton.Enabled = false;
		restartNetworkAdapterButton.Enabled = false;
	}

	private void SetDnsButton_Click(object sender, EventArgs e)
	{
		DisableControls();

		try
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
		catch (Exception ex)
		{
			var errorMessage =
				$"Error! - {ex.Message}";

			MessageBox.Show(text: errorMessage);
		}

		EnableControls();
	}

	private void UnsetDnsButton_Click(object sender, EventArgs e)
	{
		DisableControls();

		try
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
		catch (Exception ex)
		{
			var errorMessage =
				$"Error! - {ex.Message}";

			MessageBox.Show(text: errorMessage);
		}

		EnableControls();
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

		//var output =
		//	process.StandardOutput.ReadToEnd();
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

		//var output =
		//	process.StandardOutput.ReadToEnd();
	}

	private void RestartNetworkAdapterButton_Click(object sender, EventArgs e)
	{
		DisableControls();

		try
		{
			DisableNetworkAdapter();
			Thread.Sleep(millisecondsTimeout: 5000);
			EnableNetworkAdapter();
		}
		catch (Exception ex)
		{
			var errorMessage =
				$"Error! - {ex.Message}";

			MessageBox.Show(text: errorMessage);
		}

		EnableControls();
	}
}
