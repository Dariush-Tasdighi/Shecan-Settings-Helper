using System;

namespace Application;

internal static class Program
{
	[STAThread]
	private static void Main()
	{
		ApplicationConfiguration.Initialize();

		System.Windows.Forms.Application.Run(new MainForm());
		//System.Windows.Forms.Application.Run(new LearningForm());
	}
}
