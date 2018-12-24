/*
 * Created by SharpDevelop.
 * User: HCM2
 * Date: 12/23/2018
 * Time: 3:59 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace bai2
{
	/// <summary>
	/// Description of Nhanvien.
	/// </summary>
	public class Nhanvien :CanBo
	{
		private string congviec;
		public string icongviec
		{
			get
			{
				return congviec;
			}
			set
			{
				congviec = value;
			}
		}
		public Nhanvien()
		{
		}
	}
}
