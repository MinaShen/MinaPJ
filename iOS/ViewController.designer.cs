// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Mina.iOS
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		UIKit.UIButton btnMsg { get; set; }

		[Outlet]
		UIKit.UIButton Button { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (btnMsg != null) {
				btnMsg.Dispose ();
				btnMsg = null;
			}

			if (Button != null) {
				Button.Dispose ();
				Button = null;
			}
		}
	}
}
