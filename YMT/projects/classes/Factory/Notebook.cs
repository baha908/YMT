﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YMT.projects.classes.Factory
{
	class Notebook: Product, IProduct
	{
		public String ProductName()
		{
			return "Notebook";
		}
	}
}