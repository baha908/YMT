﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YMT.projects.classes.Factory
{
	class CreditCard:IPayment
	{
		public bool Pay()
		{
			return true;
		}
		public String Feedback()
		{
			return "Order completed with Credit Card";
		}
	}
}
