using System;
namespace NewsSolution.Model
{
	/// <summary>
	/// hnf_link:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class hnf_link
	{
		public hnf_link()
		{}
		#region Model
		private int _link_id;
		private string _site_name;
		private string _site_url;
		private string _site_logo;
		private int? _site_sort;
		private int? _site_shenhe;
		private DateTime? _site_createtime;
		/// <summary>
		/// 
		/// </summary>
		public int link_id
		{
			set{ _link_id=value;}
			get{return _link_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string site_name
		{
			set{ _site_name=value;}
			get{return _site_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string site_url
		{
			set{ _site_url=value;}
			get{return _site_url;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string site_logo
		{
			set{ _site_logo=value;}
			get{return _site_logo;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? site_sort
		{
			set{ _site_sort=value;}
			get{return _site_sort;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? site_shenhe
		{
			set{ _site_shenhe=value;}
			get{return _site_shenhe;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? site_createtime
		{
			set{ _site_createtime=value;}
			get{return _site_createtime;}
		}
		#endregion Model

	}
}

