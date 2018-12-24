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
		/*khai báo private để đảm báo tính đóng gói của hướng đối tượng(OOP)
		và sử dụng set{} get{} trong public để thay đổi được giá trị của kiểu dữ liệu
		(phần này hiểu sao nói vậy có thể xem trong property)
		*/
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
