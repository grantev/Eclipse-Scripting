using System;
using System.Linq;
using System.Text;
using System.Windows;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using VMS.TPS.Common.Model.API;
using VMS.TPS.Common.Model.Types;

[assembly: AssemblyVersion("1.0.0.1")]

namespace VMS.TPS
{
	public class Script
	{
		public Script()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Execute(ScriptContext context, Window window /*, ScriptEnvironment environment*/)
		{
			// TODO : Add here the code that is called when the script is launched from Eclipse.

			PlanSetup planSetup = context.PlanSetup;
			PlanSetup plan = context.ExternalPlanSetup;
			//MessageBox.Show(planSetup.Id);
			//class PlanName
			var UserControl1 = new PlanName.UserControl1();
			UserControl1.Context = context;

			window.Content = UserControl1;
			

		}


	}



	}
}
