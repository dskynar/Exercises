using System;
using Gtk;

namespace DrawLines
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Application.Init ();
			Window win = new Window ("hej");
			win.Resize (600, 600);
			
			Label instruction = new Label ();
			instruction.Text = "Draw two dots!";
 
			//Add the label to the form
			win.Add (instruction);
			win.ShowAll ();
			Application.Run ();
		}
	}
}


//http://www.mono-project.com/docs/gui/gtksharp/beginners-guide/