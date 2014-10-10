using System;
using System.Data;
using System.Collections.Generic;
//using Maticsoft.Common;
using NewsSolution.Model;
namespace NewsSolution.BLL
{
	/// <summary>
	/// hnf_loginlog
	/// </summary>
	public partial class hnf_loginlog
	{
		private readonly NewsSolution.DAL.hnf_loginlog dal=new NewsSolution.DAL.hnf_loginlog();
		public hnf_loginlog()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
			return dal.GetMaxId();
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int log_id)
		{
			return dal.Exists(log_id);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(NewsSolution.Model.hnf_loginlog model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(NewsSolution.Model.hnf_loginlog model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int log_id)
		{
			
			return dal.Delete(log_id);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string log_idlist )
		{
			return dal.DeleteList(log_idlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public NewsSolution.Model.hnf_loginlog GetModel(int log_id)
		{
			
			return dal.GetModel(log_id);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
        //public NewsSolution.Model.hnf_loginlog GetModelByCache(int log_id)
        //{
			
        //    string CacheKey = "hnf_loginlogModel-" + log_id;
        //    object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
        //    if (objModel == null)
        //    {
        //        try
        //        {
        //            objModel = dal.GetModel(log_id);
        //            if (objModel != null)
        //            {
        //                int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
        //                Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
        //            }
        //        }
        //        catch{}
        //    }
        //    return (NewsSolution.Model.hnf_loginlog)objModel;
        //}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere)
        {
            return dal.GetList(Top, strWhere);
        }
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<NewsSolution.Model.hnf_loginlog> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<NewsSolution.Model.hnf_loginlog> DataTableToList(DataTable dt)
		{
			List<NewsSolution.Model.hnf_loginlog> modelList = new List<NewsSolution.Model.hnf_loginlog>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				NewsSolution.Model.hnf_loginlog model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new NewsSolution.Model.hnf_loginlog();
					if(dt.Rows[n]["log_id"]!=null && dt.Rows[n]["log_id"].ToString()!="")
					{
						model.log_id=int.Parse(dt.Rows[n]["log_id"].ToString());
					}
					if(dt.Rows[n]["log_type"]!=null && dt.Rows[n]["log_type"].ToString()!="")
					{
						model.log_type=int.Parse(dt.Rows[n]["log_type"].ToString());
					}
					if(dt.Rows[n]["log_note"]!=null && dt.Rows[n]["log_note"].ToString()!="")
					{
					model.log_note=dt.Rows[n]["log_note"].ToString();
					}
					if(dt.Rows[n]["log_ip"]!=null && dt.Rows[n]["log_ip"].ToString()!="")
					{
					model.log_ip=dt.Rows[n]["log_ip"].ToString();
					}
					if(dt.Rows[n]["log_time"]!=null && dt.Rows[n]["log_time"].ToString()!="")
					{
						model.log_time=DateTime.Parse(dt.Rows[n]["log_time"].ToString());
					}
					modelList.Add(model);
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			return dal.GetRecordCount(strWhere);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  Method
	}
}

