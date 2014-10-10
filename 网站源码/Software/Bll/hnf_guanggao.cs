using System;
using System.Data;
using System.Collections.Generic;
//using Maticsoft.Common;
using NewsSolution.Model;
namespace NewsSolution.BLL
{
	/// <summary>
	/// hnf_guanggao
	/// </summary>
	public partial class hnf_guanggao
	{
		private readonly NewsSolution.DAL.hnf_guanggao dal=new NewsSolution.DAL.hnf_guanggao();
		public hnf_guanggao()
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
		public bool Exists(int guanggao_id)
		{
			return dal.Exists(guanggao_id);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(NewsSolution.Model.hnf_guanggao model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(NewsSolution.Model.hnf_guanggao model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int guanggao_id)
		{
			
			return dal.Delete(guanggao_id);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string guanggao_idlist )
		{
			return dal.DeleteList(guanggao_idlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public NewsSolution.Model.hnf_guanggao GetModel(int guanggao_id)
		{
			
			return dal.GetModel(guanggao_id);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
        //public NewsSolution.Model.hnf_guanggao GetModelByCache(int guanggao_id)
        //{
			
        //    string CacheKey = "hnf_guanggaoModel-" + guanggao_id;
        //    object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
        //    if (objModel == null)
        //    {
        //        try
        //        {
        //            objModel = dal.GetModel(guanggao_id);
        //            if (objModel != null)
        //            {
        //                int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
        //                Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
        //            }
        //        }
        //        catch{}
        //    }
        //    return (NewsSolution.Model.hnf_guanggao)objModel;
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
		public List<NewsSolution.Model.hnf_guanggao> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<NewsSolution.Model.hnf_guanggao> DataTableToList(DataTable dt)
		{
			List<NewsSolution.Model.hnf_guanggao> modelList = new List<NewsSolution.Model.hnf_guanggao>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				NewsSolution.Model.hnf_guanggao model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new NewsSolution.Model.hnf_guanggao();
					if(dt.Rows[n]["guanggao_id"]!=null && dt.Rows[n]["guanggao_id"].ToString()!="")
					{
						model.guanggao_id=int.Parse(dt.Rows[n]["guanggao_id"].ToString());
					}
					if(dt.Rows[n]["guanggao_position"]!=null && dt.Rows[n]["guanggao_position"].ToString()!="")
					{
					model.guanggao_position=dt.Rows[n]["guanggao_position"].ToString();
					}
					if(dt.Rows[n]["guanggao_image"]!=null && dt.Rows[n]["guanggao_image"].ToString()!="")
					{
					model.guanggao_image=dt.Rows[n]["guanggao_image"].ToString();
					}
					if(dt.Rows[n]["guanggao_site"]!=null && dt.Rows[n]["guanggao_site"].ToString()!="")
					{
					model.guanggao_site=dt.Rows[n]["guanggao_site"].ToString();
					}
					if(dt.Rows[n]["guanggao_type"]!=null && dt.Rows[n]["guanggao_type"].ToString()!="")
					{
						model.guanggao_type=int.Parse(dt.Rows[n]["guanggao_type"].ToString());
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

