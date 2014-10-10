using System;
namespace NewsSolution.Model
{
	/// <summary>
	/// hnf_n_type:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class hnf_n_type
	{
		public hnf_n_type()
		{}
		#region Model
		private int _n_type_id;
		private string _n_type_name;
		private int? _n_type_parentid;
		private string _n_type_strsort;
		private int? _n_type_depth;
		private int? _n_type_root;
		private int? _n_type_sort;
		private int? _n_type_isshow;
		/// <summary>
		/// 
		/// </summary>
		public int n_type_id
		{
			set{ _n_type_id=value;}
			get{return _n_type_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string n_type_name
		{
			set{ _n_type_name=value;}
			get{return _n_type_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_type_parentid
		{
			set{ _n_type_parentid=value;}
			get{return _n_type_parentid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string n_type_strsort
		{
			set{ _n_type_strsort=value;}
			get{return _n_type_strsort;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_type_depth
		{
			set{ _n_type_depth=value;}
			get{return _n_type_depth;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_type_root
		{
			set{ _n_type_root=value;}
			get{return _n_type_root;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_type_sort
		{
			set{ _n_type_sort=value;}
			get{return _n_type_sort;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_type_isshow
		{
			set{ _n_type_isshow=value;}
			get{return _n_type_isshow;}
		}
		#endregion Model

	}
}

