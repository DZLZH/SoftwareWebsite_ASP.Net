using System;
namespace NewsSolution.Model
{
	/// <summary>
	/// hnf_user:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class hnf_user
	{
		public hnf_user()
		{}
		#region Model
		private int _user_id;
		private string _user_name;
		private string _user_password;
		private string _user_truename;
		private string _user_question;
		private string _user_answer;
		private int? _user_isable;
		private DateTime? _user_addtime;
		private string _user_email;
		private int? _user_type;
		private int? _u_flash;
		private int? _u_video;
		private int? _u_document;
		private int? _u_source;
		private int? _u_other;
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
		public string user_truename
		{
			set{ _user_truename=value;}
			get{return _user_truename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string user_question
		{
			set{ _user_question=value;}
			get{return _user_question;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string user_answer
		{
			set{ _user_answer=value;}
			get{return _user_answer;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? user_isable
		{
			set{ _user_isable=value;}
			get{return _user_isable;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? user_addTime
		{
			set{ _user_addtime=value;}
			get{return _user_addtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string user_email
		{
			set{ _user_email=value;}
			get{return _user_email;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? user_type
		{
			set{ _user_type=value;}
			get{return _user_type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? u_flash
		{
			set{ _u_flash=value;}
			get{return _u_flash;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? u_video
		{
			set{ _u_video=value;}
			get{return _u_video;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? u_document
		{
			set{ _u_document=value;}
			get{return _u_document;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? u_source
		{
			set{ _u_source=value;}
			get{return _u_source;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? u_other
		{
			set{ _u_other=value;}
			get{return _u_other;}
		}
		#endregion Model

	}
}

