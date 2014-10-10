using System;
namespace NewsSolution.Model
{
	/// <summary>
	/// hnf_imagefile:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class hnf_imagefile
	{
		public hnf_imagefile()
		{}
		#region Model
		private int _image_id;
		private string _image_name;
		private string _image_file;
		private string _image_url;
		private string _image_content;
		private int? _image_type_id;
		private int? _user_id;
		private int? _image_times;
		private DateTime? _image_addtime;
		private int? _image_shenhe;
		private int? _image_recommand;
		private int? _guanggao_type;
		private int? _huandeng_type;
		/// <summary>
		/// 
		/// </summary>
		public int image_id
		{
			set{ _image_id=value;}
			get{return _image_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string image_name
		{
			set{ _image_name=value;}
			get{return _image_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string image_file
		{
			set{ _image_file=value;}
			get{return _image_file;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string image_url
		{
			set{ _image_url=value;}
			get{return _image_url;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string image_content
		{
			set{ _image_content=value;}
			get{return _image_content;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? image_type_id
		{
			set{ _image_type_id=value;}
			get{return _image_type_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? user_id
		{
			set{ _user_id=value;}
			get{return _user_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? image_times
		{
			set{ _image_times=value;}
			get{return _image_times;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? image_addtime
		{
			set{ _image_addtime=value;}
			get{return _image_addtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? image_shenhe
		{
			set{ _image_shenhe=value;}
			get{return _image_shenhe;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? image_recommand
		{
			set{ _image_recommand=value;}
			get{return _image_recommand;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? guanggao_type
		{
			set{ _guanggao_type=value;}
			get{return _guanggao_type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? huandeng_type
		{
			set{ _huandeng_type=value;}
			get{return _huandeng_type;}
		}
		#endregion Model

	}
}

