using System;
using Gtk;

namespace Happy
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Application.Init ();
			MainWindow win = new MainWindow ();
			DrawingArea a = new DrawingArea ();	
			a.ButtonPressEvent += HandleAButtonPressEvent;
			a.ButtonPressEvent += delegate(object o, ButtonPressEventArgs PressArgs) {
				Console.WriteLine ("Button Pressed");
			};
			
			win.Add (a);
			
			win.Show ();
			Application.Run ();
		}

		static void HandleAButtonPressEvent (object o, ButtonPressEventArgs args)
		{
			Console.WriteLine ("Button Pressed");
		}
	}
}
