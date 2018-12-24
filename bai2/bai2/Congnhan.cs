/*
 * Created by SharpDevelop.
 * User: HCM2
 * Date: 12/23/2018
 * Time: 4:01 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace bai2
{
	/// <summary>
	/// Description of Congnhan.
	/// </summary>
	public class Congnhan :CanBo
	{
		private string bac;
		public string ibac
		{
			get
			{
				return bac;
			}
			set
			{
				bac = value;
			}
		}
		public Congnhan()
		{
		}
	}
}
