/*
 * Created by SharpDevelop.
 * User: HCM2
 * Date: 12/23/2018
 * Time: 2:51 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.ComponentModel;
namespace bai2
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{	/*
		đây là cách khai báo lại các class con sau khi sử dụng Tính kế thừa (Inheritance) của class cha 
		cơ sử dụng databinding,vì list<> k có source để hiển thị trong datagridview
		nên dùng bindinglist của class con thêm list của class con đã khai báo vào
		để đưa biến bindinglist vào source
		*/
		Congnhan congnhan = new Congnhan();/*khai báo class con*/
		List<Congnhan> dscongnhan = new List<Congnhan>();/*khai báo list của class con*/
 		BindingList<Congnhan> bindinglist;/*khai báo bindinglist để chưa biến list của class con*/
 		Kysu kysu = new Kysu(); 
 		List<Kysu> dskysu = new List<Kysu>();
 		BindingList<Kysu> bindinglist2;
 		Nhanvien nhanvien = new Nhanvien();
 		List<Nhanvien> dscnhanvien = new List<Nhanvien>();
 		BindingList<Nhanvien> bindinglist3;
 		BindingSource source; /*khai báo source để chưa biến bindinglist*/
 		BindingSource source2;
 		BindingSource source3;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			bindinglist = new BindingList<Congnhan>(dscongnhan);/*phương thức để gán list vào bindinglist*/
 			bindinglist2 = new BindingList<Kysu>(dskysu);
 			bindinglist3 = new BindingList<Nhanvien>(dscnhanvien);

			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		public void cleardata()
		{
			tenho.Text = "";
			namsinh.Text = "";
			diachi.Text = "";
			nganh.Text = "";
			congviec.Text = "";
			bac.Text ="";
		}
		
		
		void RbnamCheckedChanged(object sender, EventArgs e)
		{
			if(rbnam.Checked == true)/*điều kiện radiobutton để in ra giới tính*/
			{
				nhanvien.igioitinh = rbnam.Text;
				congnhan.igioitinh = rbnam.Text;
				kysu.igioitinh = rbnam.Text;
			}
		}
		
		void RbnuCheckedChanged(object sender, EventArgs e)
		{
			if(rbnu.Checked == true)/*vì có 3 class nên phải gọi cả 3 class*/
			{
				nhanvien.igioitinh = rbnu.Text;
				congnhan.igioitinh = rbnu.Text;
				kysu.igioitinh = rbnu.Text;
			}
		}
		void DulieuClick(object sender, EventArgs e)
		{
			if(rbnhanvien.Checked == true)/*điều kiện để source của class*/
			{
				if(tenho.Text.Length > 20 || namsinh.Text.Length !=4 || diachi.Text.Length >30 || tenho.Text =="" || namsinh.Text =="")
				{
				/*đây là điều kiện chống việc nhập quá kí tự và việc không nhâp dữ liệu nào 
				mà vẫn bấm add dữ liệu
				*/
					cleardata();
				}
				else
				{
				/*cách add những thông tin của class con sau khi sử dụng tính kế thừa*/
				nhanvien.icongviec = congviec.Text;
				nhanvien.iten = tenho.Text;
				nhanvien.ituoi = int.Parse(namsinh.Text);
				nhanvien.idiachi = diachi.Text;
				source3.Add(nhanvien);/*đây là cách add source của class*/
				cleardata();
				show.Refresh();
				}
			}
			else if(rbcongnhan.Checked == true)
			{
				if(tenho.Text.Length > 20 || namsinh.Text.Length !=4 || diachi.Text.Length >30 || tenho.Text =="" || namsinh.Text =="")
				{
					cleardata();
				}
				else
				{
					congnhan.ibac = bac.Text;
					congnhan.iten = tenho.Text;
					congnhan.ituoi = int.Parse(namsinh.Text);
					congnhan.idiachi = diachi.Text;
					source.Add(congnhan);
					cleardata();
					show.Refresh();
				}
			}
			else if(rbkysu.Checked == true)
			{
				if(tenho.Text.Length > 20 || namsinh.Text.Length !=4 ||  diachi.Text.Length >30 || tenho.Text =="" || namsinh.Text =="")
				{
					cleardata();
				}
				else
				{
				kysu.inghanh = nganh.Text;
				kysu.iten = tenho.Text;
				kysu.ituoi = int.Parse(namsinh.Text);
				kysu.idiachi = diachi.Text;
				source2.Add(kysu);
				cleardata();
				show.Refresh();
				}
			}
			
		}
		void RadioButton1CheckedChanged(object sender, EventArgs e)
		{
			if(rbnhanvien.Checked == true)
			{
				/*đây là điều kiện thầy ra trong đề bài của thầy và dùng để hiển thị
				show.DataSource = source3
				*/
				bindinglist3 = new BindingList<Nhanvien>(dscnhanvien);
 				source3 = new BindingSource(bindinglist3 ,null);
 				show.DataSource = source3;
 				nganh.Visible = false;
 				bac.Visible = false;
			}
			else
			{	/*lệnh visible dùng để hiện ẩn textbox*/
				bac.Visible = true;
 				nganh.Visible = true;
			}
		}
		
		void RbkysuCheckedChanged(object sender, EventArgs e)
		{
			if(rbkysu.Checked == true)
			{
				bindinglist2 = new BindingList<Kysu>(dskysu);
 				source2 = new BindingSource(bindinglist2 ,null);
 				show.DataSource = source2;
 				congviec.Visible = false;
 				bac.Visible = false;
			}
			else
			{
				congviec.Visible = true;
 				bac.Visible = true;
			}
		}
		
		void RbcongnhanCheckedChanged(object sender, EventArgs e)
		{
			if(rbcongnhan.Checked == true)
			{
				bindinglist = new BindingList<Congnhan>(dscongnhan);
 				source = new BindingSource(bindinglist ,null);
 				show.DataSource = source;
 				congviec.Visible = false;
 				nganh.Visible = false;
			}
			else
			{
				congviec.Visible = true;
 				nganh.Visible = true;
			}
		}
		void ThoatClick(object sender, EventArgs e)
		{
			this.Dispose(); /*lệnh thoát*/
		}
		
		void TimClick(object sender, EventArgs e)
		{
			/*sử dụng foreach để sử lí danh sách của tên họ vì lúc đầu chúng ta
			không biết được số lượng kết thúc nên dùng foreach để chứa
			cá biến tạm trong danh sách ta chèn vào
			*/
			foreach(var item in dscongnhan)
			{
				if(item.iten == timkiem.Text)
				{
					MessageBox.Show(timkiem.Text);
				}
			}
			foreach(var item in dscnhanvien)
			{
				if(item.iten == timkiem.Text)
				{
					MessageBox.Show(timkiem.Text);
				}
			}
			foreach(var item in dskysu)
			{
				if(item.iten == timkiem.Text)
				{
					MessageBox.Show(timkiem.Text);
				}
			}
		}
	}
}
