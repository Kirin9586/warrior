/*
 * Created by SharpDevelop.
 * User: HCM2
 * Date: 12/23/2018
 * Time: 3:44 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace bai2
{
	/// <summary>
	/// Description of CanBo.
	/// </summary>
	public class CanBo
	{
		private string ten;
		private int tuoi;
		private string gioitinh;
		private string diachi;
		public string iten
		{
			get
			{
				return ten;
			}
			set
			{
				ten = value;
			}
		}
		public int ituoi
		{
			get
			{
				return tuoi;
			}
			set
			{
				tuoi = value;
			}
		}
		public string igioitinh
		{
			get
			{
				return gioitinh;
			}
			set
			{
				gioitinh = value;
			}
		}
		public string idiachi
		{
			get
			{
				return diachi;
			}
			set
			{
				diachi = value;
			}
		}
		public CanBo()
		{
		}
		
	}
}
