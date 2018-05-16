﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenDentBusiness;
using UnitTestsCore;

namespace UnitTests {
	[TestClass]
	public class WikiPagesTests:TestBase {
		[TestMethod]
		public void WikiPages_ConvertToPlainText_HTML() {
			string htmltags="<h2>Ideas</h2> <h3>Common Passwords file</h3>A file would be &>included that would contain</br> the top 1000 or so";
			string htmlResult="Ideas Common Passwords fileA file would be &>included that would contain the top 1000 or so";
			Assert.AreEqual(htmlResult,WikiPages.ConvertToPlainText(htmltags));
		}

		[TestMethod]
		public void WikiPages_ConvertToPlainText_PageLinks() {
			string PageLinks="This is a title: [[234]] that shouldn't be [There]";
			string pageLinkResult="This is a title:  that shouldn't be [There]";
			Assert.AreEqual(pageLinkResult,WikiPages.ConvertToPlainText(PageLinks));
		}

		[TestMethod]
		public void WikiPages_IsWikiPageTitleValid_HashMark() {
			string titleHash,container;
			titleHash="Title with an # mark";
			container="";
			Assert.IsFalse(WikiPages.IsWikiPageTitleValid(titleHash,out container));
		}

		[TestMethod]
		public void WikiPages_IsWikiPageTitleValid_Underline() {
			string titleUnderline,container;
			titleUnderline="_Title that contains an underline";
			Assert.IsFalse(WikiPages.IsWikiPageTitleValid(titleUnderline,out container));
		}

		[TestMethod]
		public void WikiPages_IsWikiPageTitleValid_Quotes() {
			string titleQuote,container;
			titleQuote="This is really only 1/2 a \"title\".";
			Assert.IsFalse(WikiPages.IsWikiPageTitleValid(titleQuote,out container));
		}

		[TestMethod]
		public void WikiPages_IsWikiPageTitleValid_MultipleLines() {
			string titleNewLine,container;
			titleNewLine="Two line \r\n title";
			container="";
			Assert.IsFalse(WikiPages.IsWikiPageTitleValid(titleNewLine,out container));
		}

		[TestMethod]
		public void WikiPages_IsWikiPageTitleValid() {
			string titleValid,container;
			titleValid="This is a valid title";
			container="";
			Assert.IsTrue(WikiPages.IsWikiPageTitleValid(titleValid,out container));
		}
	}
}
