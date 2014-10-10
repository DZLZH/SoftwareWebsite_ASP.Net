using System;
namespace NewsSolution.Model
{
	/// <summary>
	/// hnf_adminuser:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class hnf_adminuser
	{
		public hnf_adminuser()
		{}
		#region Model
		private int _user_id;
		private string _user_name;
		private string _user_password;
		private DateTime? _user_createtime;
		private string _user_ip;
		private DateTime? _user_logintime;
		private int? _user_role=0;
		/// <summary>
		/// 
		/// </summary>
		public int user_id
		{
			set{ _user_id=value;}
			get{return _user_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string user_name
		{
			set{ _user_name=value;}
			get{return _user_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string user_password
		{
			set{ _user_password=value;}
			get{return _user_password;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? user_createtime
		{
			set{ _user_createtime=value;}
			get{return _user_createtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string user_ip
		{
			set{ _user_ip=value;}
			get{return _user_ip;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? user_logintime
		{
			set{ _user_logintime=value;}
			get{return _user_logintime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? user_role
		{
			set{ _user_role=value;}
			get{return _user_role;}
		}
		#endregion Model

	}
}

