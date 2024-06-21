// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace CaluclatorAssignment
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSButton addOutlet { get; set; }

		[Outlet]
		AppKit.NSButton divideOutlet { get; set; }

		[Outlet]
		AppKit.NSTextField infoLabel1 { get; set; }

		[Outlet]
		AppKit.NSTextField infoLabel2 { get; set; }

		[Outlet]
		AppKit.NSButton multiplyOutlet { get; set; }

		[Outlet]
		AppKit.NSButton squareOutlet { get; set; }

		[Outlet]
		AppKit.NSButton squareRootOutlet { get; set; }

		[Outlet]
		AppKit.NSButton subtractOutlet { get; set; }

		[Outlet]
		AppKit.NSTextField textInput1 { get; set; }

		[Outlet]
		AppKit.NSTextField textInput2 { get; set; }

		[Outlet]
		AppKit.NSTextField textInput3 { get; set; }

		[Action ("addAction:")]
		partial void addAction (AppKit.NSButton sender);

		[Action ("divideAction:")]
		partial void divideAction (AppKit.NSButton sender);

		[Action ("multiplyAction:")]
		partial void multiplyAction (AppKit.NSButton sender);

		[Action ("pushButton1:")]
		partial void pushButton1 (AppKit.NSButton sender);

		[Action ("pushButton2:")]
		partial void pushButton2 (AppKit.NSButton sender);

		[Action ("squareAction:")]
		partial void squareAction (AppKit.NSButton sender);

		[Action ("squareRootAction:")]
		partial void squareRootAction (AppKit.NSButton sender);

		[Action ("subtractAction:")]
		partial void subtractAction (AppKit.NSButton sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (infoLabel1 != null) {
				infoLabel1.Dispose ();
				infoLabel1 = null;
			}

			if (infoLabel2 != null) {
				infoLabel2.Dispose ();
				infoLabel2 = null;
			}

			if (addOutlet != null) {
				addOutlet.Dispose ();
				addOutlet = null;
			}

			if (subtractOutlet != null) {
				subtractOutlet.Dispose ();
				subtractOutlet = null;
			}

			if (multiplyOutlet != null) {
				multiplyOutlet.Dispose ();
				multiplyOutlet = null;
			}

			if (divideOutlet != null) {
				divideOutlet.Dispose ();
				divideOutlet = null;
			}

			if (squareOutlet != null) {
				squareOutlet.Dispose ();
				squareOutlet = null;
			}

			if (squareRootOutlet != null) {
				squareRootOutlet.Dispose ();
				squareRootOutlet = null;
			}

			if (textInput1 != null) {
				textInput1.Dispose ();
				textInput1 = null;
			}

			if (textInput2 != null) {
				textInput2.Dispose ();
				textInput2 = null;
			}

			if (textInput3 != null) {
				textInput3.Dispose ();
				textInput3 = null;
			}
		}
	}
}
