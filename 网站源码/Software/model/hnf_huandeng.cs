using System;
namespace NewsSolution.Model
{
	/// <summary>
	/// hnf_huandeng:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class hnf_huandeng
	{
		public hnf_huandeng()
		{}
		#region Model
		private int _huan_id;
		private string _huan_title;
		private string _huan_name;
		private string _huan_image;
		private int? _huan_shenhe;
		private int? _huan_sort;
		private int? _huan_type;
		/// <summary>
		/// 
		/// </summary>
		public int huan_id
		{
			set{ _huan_id=value;}
			get{return _huan_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string huan_title
		{
			set{ _huan_title=value;}
			get{return _huan_title;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string huan_name
		{
			set{ _huan_name=value;}
			get{return _huan_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string huan_image
		{
			set{ _huan_image=value;}
			get{return _huan_image;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? huan_shenhe
		{
			set{ _huan_shenhe=value;}
			get{return _huan_shenhe;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? huan_sort
		{
			set{ _huan_sort=value;}
			get{return _huan_sort;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? huan_type
		{
			set{ _huan_type=value;}
			get{return _huan_type;}
		}
		#endregion Model

	}
}

