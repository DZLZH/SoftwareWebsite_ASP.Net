using System;
using System.Data;
using System.Collections.Generic;
//using Maticsoft.Common;
using NewsSolution.Model;
namespace NewsSolution.BLL
{
	/// <summary>
	/// hnf_link
	/// </summary>
	public partial class hnf_link
	{
		private readonly NewsSolution.DAL.hnf_link dal=new NewsSolution.DAL.hnf_link();
		public hnf_link()
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
		public bool Exists(int link_id)
		{
			return dal.Exists(link_id);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(NewsSolution.Model.hnf_link model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(NewsSolution.Model.hnf_link model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int link_id)
		{
			
			return dal.Delete(link_id);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string link_idlist )
		{
			return dal.DeleteList(link_idlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public NewsSolution.Model.hnf_link GetModel(int link_id)
		{
			
			return dal.GetModel(link_id);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
        //public NewsSolution.Model.hnf_link GetModelByCache(int link_id)
        //{
			
        //    string CacheKey = "hnf_linkModel-" + link_id;
        //    object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
        //    if (objModel == null)
        //    {
        //        try
        //        {
        //            objModel = dal.GetModel(link_id);
        //            if (objModel != null)
        //            {
        //                int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
        //                Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
        //            }
        //        }
        //        catch{}
        //    }
        //    return (NewsSolution.Model.hnf_link)objModel;
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
		public List<NewsSolution.Model.hnf_link> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<NewsSolution.Model.hnf_link> DataTableToList(DataTable dt)
		{
			List<NewsSolution.Model.hnf_link> modelList = new List<NewsSolution.Model.hnf_link>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				NewsSolution.Model.hnf_link model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new NewsSolution.Model.hnf_link();
					if(dt.Rows[n]["link_id"]!=null && dt.Rows[n]["link_id"].ToString()!="")
					{
						model.link_id=int.Parse(dt.Rows[n]["link_id"].ToString());
					}
					if(dt.Rows[n]["site_name"]!=null && dt.Rows[n]["site_name"].ToString()!="")
					{
					model.site_name=dt.Rows[n]["site_name"].ToString();
					}
					if(dt.Rows[n]["site_url"]!=null && dt.Rows[n]["site_url"].ToString()!="")
					{
					model.site_url=dt.Rows[n]["site_url"].ToString();
					}
					if(dt.Rows[n]["site_logo"]!=null && dt.Rows[n]["site_logo"].ToString()!="")
					{
					model.site_logo=dt.Rows[n]["site_logo"].ToString();
					}
					if(dt.Rows[n]["site_sort"]!=null && dt.Rows[n]["site_sort"].ToString()!="")
					{
						model.site_sort=int.Parse(dt.Rows[n]["site_sort"].ToString());
					}
					if(dt.Rows[n]["site_shenhe"]!=null && dt.Rows[n]["site_shenhe"].ToString()!="")
					{
						model.site_shenhe=int.Parse(dt.Rows[n]["site_shenhe"].ToString());
					}
					if(dt.Rows[n]["site_createtime"]!=null && dt.Rows[n]["site_createtime"].ToString()!="")
					{
						model.site_createtime=DateTime.Parse(dt.Rows[n]["site_createtime"].ToString());
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
        public bool UpdOrder(int id, int order)
        {
            return dal.UpdOrder(id, order);
        }
		#endregion  Method
	}
}

