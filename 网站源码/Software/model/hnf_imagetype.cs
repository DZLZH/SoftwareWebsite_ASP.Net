using System;
namespace NewsSolution.Model
{
	/// <summary>
	/// hnf_imagetype:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class hnf_imagetype
	{
		public hnf_imagetype()
		{}
		#region Model
		private int _image_type_id;
		private string _image_type_name;
		private DateTime? _image_type_time;
		private int? _mage_type_parent;
		private int? _image_sort;
		/// <summary>
		/// 
		/// </summary>
		public int image_type_id
		{
			set{ _image_type_id=value;}
			get{return _image_type_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string image_type_name
		{
			set{ _image_type_name=value;}
			get{return _image_type_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? image_type_time
		{
			set{ _image_type_time=value;}
			get{return _image_type_time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? mage_type_parent
		{
			set{ _mage_type_parent=value;}
			get{return _mage_type_parent;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? image_sort
		{
			set{ _image_sort=value;}
			get{return _image_sort;}
		}
		#endregion Model

	}
}

