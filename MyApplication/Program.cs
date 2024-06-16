using System;
using System.Windows.Forms;

namespace MyApplication;

internal static class Program
{
	[STAThread]
	private static void Main()
	{
		ApplicationConfiguration.Initialize();

		Application.Run(new MainForm());
		//Application.Run(new LearningForm());
	}
}
