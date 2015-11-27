using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnDrawingarea2ButtonPressEvent (object o, Gtk.ButtonPressEventArgs args)
	{
		presentX.Text = args.Event.X.ToString ();
		presentY.Text = args.Event.Y.ToString ();
		Console.WriteLine (args.Event.X.ToString ());
		Console.WriteLine ("Button Pressed");
	}
}

//http://stackoverflow.com/questions/2914622/getting-the-mouse-coordinates-when-buttonpressevent-occurs