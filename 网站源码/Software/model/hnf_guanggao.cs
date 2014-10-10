using System;
namespace NewsSolution.Model
{
	/// <summary>
	/// hnf_guanggao:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class hnf_guanggao
	{
		public hnf_guanggao()
		{}
		#region Model
		private int _guanggao_id;
		private string _guanggao_position;
		private string _guanggao_image;
		private string _guanggao_site;
		private int? _guanggao_type;
		/// <summary>
		/// 
		/// </summary>
		public int guanggao_id
		{
			set{ _guanggao_id=value;}
			get{return _guanggao_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string guanggao_position
		{
			set{ _guanggao_position=value;}
			get{return _guanggao_position;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string guanggao_image
		{
			set{ _guanggao_image=value;}
			get{return _guanggao_image;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string guanggao_site
		{
			set{ _guanggao_site=value;}
			get{return _guanggao_site;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? guanggao_type
		{
			set{ _guanggao_type=value;}
			get{return _guanggao_type;}
		}
		#endregion Model

	}
}

