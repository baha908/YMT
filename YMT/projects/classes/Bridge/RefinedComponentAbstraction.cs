﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YMT.projects.classes.Bridge
{
	class RefinedComponentAbstraction : ComponentAbstraction
	{
		public override void ComponentBuilder()
		{
			_componentBuilder.ComponentBuilder();
		}
	}
}
