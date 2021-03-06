//   Copyright 2013 Mercent Corporation
//
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//
//       http://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.
using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mercent.SqlServer.Management;

namespace Mercent.SqlServer.Management.Tests
{
	[TestClass]
	public class FileScripterFixture
	{
		[TestMethod]
		public void ScriptTest()
		{
			FileScripter scripter = new FileScripter();
			scripter.OutputDirectory = "Product_Merchant";
			scripter.ServerName = @"tank";
			scripter.DatabaseName = "Product_Merchant";
			scripter.Script();
		}
	}
}
