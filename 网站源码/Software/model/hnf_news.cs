using System;
namespace NewsSolution.Model
{
	/// <summary>
	/// hnf_news:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class hnf_news
	{
		public hnf_news()
		{}
		#region Model
		private int _news_id;
		private string _news_seotitle;
		private string _news_keyword;
		private string _news_describ;
		private string _news_name;
		private string _news_content;
		private DateTime? _news_createtime;
		private DateTime? _news_alertime;
		private string _news_comefrom;
		private int? _news_seetime;
		private int? _news_isshow;
		private int? _news_recommand;
		private int? _news_type;
		private string _news_image;
		private int? _news_isimage;
		private int? _news_sort;
		private int? _user_id;
		/// <summary>
		/// 
		/// </summary>
		public int news_id
		{
			set{ _news_id=value;}
			get{return _news_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string news_seotitle
		{
			set{ _news_seotitle=value;}
			get{return _news_seotitle;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string news_keyword
		{
			set{ _news_keyword=value;}
			get{return _news_keyword;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string news_describ
		{
			set{ _news_describ=value;}
			get{return _news_describ;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string news_name
		{
			set{ _news_name=value;}
			get{return _news_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string news_content
		{
			set{ _news_content=value;}
			get{return _news_content;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? news_createtime
		{
			set{ _news_createtime=value;}
			get{return _news_createtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? news_alertime
		{
			set{ _news_alertime=value;}
			get{return _news_alertime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string news_comefrom
		{
			set{ _news_comefrom=value;}
			get{return _news_comefrom;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? news_seetime
		{
			set{ _news_seetime=value;}
			get{return _news_seetime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? news_isshow
		{
			set{ _news_isshow=value;}
			get{return _news_isshow;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? news_recommand
		{
			set{ _news_recommand=value;}
			get{return _news_recommand;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? news_type
		{
			set{ _news_type=value;}
			get{return _news_type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string news_image
		{
			set{ _news_image=value;}
			get{return _news_image;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? news_isimage
		{
			set{ _news_isimage=value;}
			get{return _news_isimage;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? news_sort
		{
			set{ _news_sort=value;}
			get{return _news_sort;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? user_id
		{
			set{ _user_id=value;}
			get{return _user_id;}
		}
		#endregion Model

	}
}

