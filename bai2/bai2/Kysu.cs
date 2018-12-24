/*
 * Created by SharpDevelop.
 * User: HCM2
 * Date: 12/23/2018
 * Time: 4:02 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace bai2
{
	/// <summary>
	/// Description of Kysu.
	/// </summary>
	public class Kysu :CanBo
	{
		private string nganh;
		public string inghanh
		{
			get
			{
				return nganh;
			}
			set
			{
				nganh = value;
			}
		}
		public Kysu()
		{
		}
	}
}
