using System;
namespace NewsSolution.Model
{
	/// <summary>
	/// hnf_baseinfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class hnf_baseinfo
	{
		public hnf_baseinfo()
		{}
		#region Model
		private int _base_id;
		private string _base_dianhua;
		private string _base_mobile;
		private string _base_qq;
		private string _base_email;
		private string _base_lianxiren;
		private string _base_address;
		private string _base_seotitle;
		private string _base_keyword;
		private string _base_describ;
		private string _base_beianhao;
		private string _base_content;
		/// <summary>
		/// 
		/// </summary>
		public int base_id
		{
			set{ _base_id=value;}
			get{return _base_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string base_dianhua
		{
			set{ _base_dianhua=value;}
			get{return _base_dianhua;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string base_mobile
		{
			set{ _base_mobile=value;}
			get{return _base_mobile;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string base_qq
		{
			set{ _base_qq=value;}
			get{return _base_qq;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string base_email
		{
			set{ _base_email=value;}
			get{return _base_email;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string base_lianxiren
		{
			set{ _base_lianxiren=value;}
			get{return _base_lianxiren;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string base_address
		{
			set{ _base_address=value;}
			get{return _base_address;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string base_seotitle
		{
			set{ _base_seotitle=value;}
			get{return _base_seotitle;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string base_keyword
		{
			set{ _base_keyword=value;}
			get{return _base_keyword;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string base_describ
		{
			set{ _base_describ=value;}
			get{return _base_describ;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string base_beianhao
		{
			set{ _base_beianhao=value;}
			get{return _base_beianhao;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string base_content
		{
			set{ _base_content=value;}
			get{return _base_content;}
		}
		#endregion Model

	}
}

