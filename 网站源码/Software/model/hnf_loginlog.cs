using System;
namespace NewsSolution.Model
{
	/// <summary>
	/// hnf_loginlog:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class hnf_loginlog
	{
		public hnf_loginlog()
		{}
		#region Model
		private int _log_id;
		private int? _log_type;
		private string _log_note;
		private string _log_ip;
		private DateTime? _log_time;
		/// <summary>
		/// 
		/// </summary>
		public int log_id
		{
			set{ _log_id=value;}
			get{return _log_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? log_type
		{
			set{ _log_type=value;}
			get{return _log_type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string log_note
		{
			set{ _log_note=value;}
			get{return _log_note;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string log_ip
		{
			set{ _log_ip=value;}
			get{return _log_ip;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? log_time
		{
			set{ _log_time=value;}
			get{return _log_time;}
		}
		#endregion Model

	}
}

