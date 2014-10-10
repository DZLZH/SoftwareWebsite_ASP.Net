using System;
using System.Data;
using System.Collections.Generic;
//using Maticsoft.Common;
using NewsSolution.Model;
namespace NewsSolution.BLL
{
	/// <summary>
	/// hnf_huandeng
	/// </summary>
	public partial class hnf_huandeng
	{
		private readonly NewsSolution.DAL.hnf_huandeng dal=new NewsSolution.DAL.hnf_huandeng();
		public hnf_huandeng()
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
		public bool Exists(int huan_id)
		{
			return dal.Exists(huan_id);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(NewsSolution.Model.hnf_huandeng model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(NewsSolution.Model.hnf_huandeng model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int huan_id)
		{
			
			return dal.Delete(huan_id);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string huan_idlist )
		{
			return dal.DeleteList(huan_idlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public NewsSolution.Model.hnf_huandeng GetModel(int huan_id)
		{
			
			return dal.GetModel(huan_id);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
        //public NewsSolution.Model.hnf_huandeng GetModelByCache(int huan_id)
        //{
			
        //    string CacheKey = "hnf_huandengModel-" + huan_id;
        //    object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
        //    if (objModel == null)
        //    {
        //        try
        //        {
        //            objModel = dal.GetModel(huan_id);
        //            if (objModel != null)
        //            {
        //                int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
        //                Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
        //            }
        //        }
        //        catch{}
        //    }
        //    return (NewsSolution.Model.hnf_huandeng)objModel;
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
		public List<NewsSolution.Model.hnf_huandeng> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<NewsSolution.Model.hnf_huandeng> DataTableToList(DataTable dt)
		{
			List<NewsSolution.Model.hnf_huandeng> modelList = new List<NewsSolution.Model.hnf_huandeng>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				NewsSolution.Model.hnf_huandeng model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new NewsSolution.Model.hnf_huandeng();
					if(dt.Rows[n]["huan_id"]!=null && dt.Rows[n]["huan_id"].ToString()!="")
					{
						model.huan_id=int.Parse(dt.Rows[n]["huan_id"].ToString());
					}
					if(dt.Rows[n]["huan_title"]!=null && dt.Rows[n]["huan_title"].ToString()!="")
					{
					model.huan_title=dt.Rows[n]["huan_title"].ToString();
					}
					if(dt.Rows[n]["huan_name"]!=null && dt.Rows[n]["huan_name"].ToString()!="")
					{
					model.huan_name=dt.Rows[n]["huan_name"].ToString();
					}
					if(dt.Rows[n]["huan_image"]!=null && dt.Rows[n]["huan_image"].ToString()!="")
					{
					model.huan_image=dt.Rows[n]["huan_image"].ToString();
					}
					if(dt.Rows[n]["huan_shenhe"]!=null && dt.Rows[n]["huan_shenhe"].ToString()!="")
					{
						model.huan_shenhe=int.Parse(dt.Rows[n]["huan_shenhe"].ToString());
					}
					if(dt.Rows[n]["huan_sort"]!=null && dt.Rows[n]["huan_sort"].ToString()!="")
					{
						model.huan_sort=int.Parse(dt.Rows[n]["huan_sort"].ToString());
					}
					if(dt.Rows[n]["huan_type"]!=null && dt.Rows[n]["huan_type"].ToString()!="")
					{
						model.huan_type=int.Parse(dt.Rows[n]["huan_type"].ToString());
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

