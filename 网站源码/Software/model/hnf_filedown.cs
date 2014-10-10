using System;
namespace NewsSolution.Model
{
	/// <summary>
	/// hnf_filedown:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class hnf_filedown
	{
		public hnf_filedown()
		{}
		#region Model
		private int _down_id;
		private string _down_seotitle;
		private string _down_keyword;
		private string _down_describ;
		private string _down_name;
		private string _file_name;
		private string _file_url;
		private string _file_content;
		private int? _down_shenhe;
		private int? _down_recommand;
		private DateTime? _down_createtime;
		private int? _down_times;
		/// <summary>
		/// 
		/// </summary>
		public int down_id
		{
			set{ _down_id=value;}
			get{return _down_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string down_seotitle
		{
			set{ _down_seotitle=value;}
			get{return _down_seotitle;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string down_keyword
		{
			set{ _down_keyword=value;}
			get{return _down_keyword;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string down_describ
		{
			set{ _down_describ=value;}
			get{return _down_describ;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string down_name
		{
			set{ _down_name=value;}
			get{return _down_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string file_name
		{
			set{ _file_name=value;}
			get{return _file_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string file_url
		{
			set{ _file_url=value;}
			get{return _file_url;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string file_content
		{
			set{ _file_content=value;}
			get{return _file_content;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? down_shenhe
		{
			set{ _down_shenhe=value;}
			get{return _down_shenhe;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? down_recommand
		{
			set{ _down_recommand=value;}
			get{return _down_recommand;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? down_createtime
		{
			set{ _down_createtime=value;}
			get{return _down_createtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? down_times
		{
			set{ _down_times=value;}
			get{return _down_times;}
		}
		#endregion Model

	}
}

