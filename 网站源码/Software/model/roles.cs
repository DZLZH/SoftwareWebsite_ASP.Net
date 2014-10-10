using System;
namespace NewsSolution.Model
{
	/// <summary>
	/// roles:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class roles
	{
		public roles()
		{}
		#region Model
		private int _roleid;
		private string _rolename;
		private int? _flash;
		private int? _video;
		private int? _documents;
		private int? _other;
		private int? _source;
		private int? _green;
		/// <summary>
		/// 
		/// </summary>
		public int roleid
		{
			set{ _roleid=value;}
			get{return _roleid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string rolename
		{
			set{ _rolename=value;}
			get{return _rolename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? flash
		{
			set{ _flash=value;}
			get{return _flash;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? video
		{
			set{ _video=value;}
			get{return _video;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? documents
		{
			set{ _documents=value;}
			get{return _documents;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? other
		{
			set{ _other=value;}
			get{return _other;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? source
		{
			set{ _source=value;}
			get{return _source;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? green
		{
			set{ _green=value;}
			get{return _green;}
		}
		#endregion Model

	}
}

