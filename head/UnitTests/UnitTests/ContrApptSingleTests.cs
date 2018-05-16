using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CodeBase;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenDental;
using OpenDentBusiness;
using UnitTestsCore;

namespace UnitTests {
	[TestClass]	
	public class ContrApptSingleTests:TestBase {
		[TestMethod]
		public void ContrApptSingle_ShadowGet_Threads() {
			//Sadly we had to revert the fix that this test was testing.
			/*
			//This test was created to test that we don't get an "Object currently in use elsewhere" exception.
			//GDI+ isn't thread safe, so when two threads try to access the image data an exception is thrown. 
			//This test creates 20 threads who all try and access the image 500 times each.
			ContrApptSingle CAS=new ContrApptSingle();
			//Spawn 20 threads to all try and access it.
			CAS.Shadow=new Bitmap(100,100);	//Good size that trips the error   1000x1000 uses to much memory (because bitmaps)
			bool passed=true;	//Accessed by all threads, set to false if any of the threads fails.
			List<Action> listThreads=new List<Action>();
			//Creates 20 threads, which access the bitmap 100 times each.  
			//This way we have a good chance of two threads accessing the image at the same time.
			Action action=new Action(() => {
				for(int k=0; k<500;k++) {
					if(!passed) { return; }	//Don't do work we don't need to.
					try {
						Bitmap test=(Bitmap)CAS.Shadow.Clone();	//The clone shares image data with the original.
						//This will attempt to access the test bitmap
						//If it is not thread safe, then it will throw an exception.
						test.GetThumbnailImage(64,64,null,IntPtr.Zero);
						test.Dispose();	
					}
					catch(InvalidOperationException e) {	//Catching  "System.InvalidOperationException: The object is currently in use elsewhere."
						e.DoNothing(); //Swallow the actual exception because this is a thread.
						if(passed) { passed=false; }	//Communicate failure to the outside world.
						return;
					}
				}
			});
			for(int i=0;i<20;i++) {
				listThreads.Add(action);				
			}
			ODThread.RunParallel(listThreads,Timeout.InfiniteTimeSpan,listThreads.Count);
			Assert.IsTrue(passed);//This will be true if none of threads hit an access violation.
			*/
		}
	}
}
