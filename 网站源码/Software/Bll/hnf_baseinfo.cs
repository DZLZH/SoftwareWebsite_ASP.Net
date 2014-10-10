using System;
using System.Data;
using System.Collections.Generic;
//using Maticsoft.Common;
using NewsSolution.Model;
namespace NewsSolution.BLL
{
	/// <summary>
	/// hnf_baseinfo
	/// </summary>
	public partial class hnf_baseinfo
	{
		private readonly NewsSolution.DAL.hnf_baseinfo dal=new NewsSolution.DAL.hnf_baseinfo();
		public hnf_baseinfo()
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
		public bool Exists(int base_id)
		{
			return dal.Exists(base_id);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(NewsSolution.Model.hnf_baseinfo model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(NewsSolution.Model.hnf_baseinfo model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int base_id)
		{
			
			return dal.Delete(base_id);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string base_idlist )
		{
			return dal.DeleteList(base_idlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public NewsSolution.Model.hnf_baseinfo GetModel(int base_id)
		{
			
			return dal.GetModel(base_id);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
        //public NewsSolution.Model.hnf_baseinfo GetModelByCache(int base_id)
        //{
			
        //    string CacheKey = "hnf_baseinfoModel-" + base_id;
        //    object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
        //    if (objModel == null)
        //    {
        //        try
        //        {
        //            objModel = dal.GetModel(base_id);
        //            if (objModel != null)
        //            {
        //                int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
        //                Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
        //            }
        //        }
        //        catch{}
        //    }
        //    return (NewsSolution.Model.hnf_baseinfo)objModel;
        //}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
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
		public List<NewsSolution.Model.hnf_baseinfo> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<NewsSolution.Model.hnf_baseinfo> DataTableToList(DataTable dt)
		{
			List<NewsSolution.Model.hnf_baseinfo> modelList = new List<NewsSolution.Model.hnf_baseinfo>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				NewsSolution.Model.hnf_baseinfo model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new NewsSolution.Model.hnf_baseinfo();
					if(dt.Rows[n]["base_id"]!=null && dt.Rows[n]["base_id"].ToString()!="")
					{
						model.base_id=int.Parse(dt.Rows[n]["base_id"].ToString());
					}
					if(dt.Rows[n]["base_dianhua"]!=null && dt.Rows[n]["base_dianhua"].ToString()!="")
					{
					model.base_dianhua=dt.Rows[n]["base_dianhua"].ToString();
					}
					if(dt.Rows[n]["base_mobile"]!=null && dt.Rows[n]["base_mobile"].ToString()!="")
					{
					model.base_mobile=dt.Rows[n]["base_mobile"].ToString();
					}
					if(dt.Rows[n]["base_qq"]!=null && dt.Rows[n]["base_qq"].ToString()!="")
					{
					model.base_qq=dt.Rows[n]["base_qq"].ToString();
					}
					if(dt.Rows[n]["base_email"]!=null && dt.Rows[n]["base_email"].ToString()!="")
					{
					model.base_email=dt.Rows[n]["base_email"].ToString();
					}
					if(dt.Rows[n]["base_lianxiren"]!=null && dt.Rows[n]["base_lianxiren"].ToString()!="")
					{
					model.base_lianxiren=dt.Rows[n]["base_lianxiren"].ToString();
					}
					if(dt.Rows[n]["base_address"]!=null && dt.Rows[n]["base_address"].ToString()!="")
					{
					model.base_address=dt.Rows[n]["base_address"].ToString();
					}
					if(dt.Rows[n]["base_seotitle"]!=null && dt.Rows[n]["base_seotitle"].ToString()!="")
					{
					model.base_seotitle=dt.Rows[n]["base_seotitle"].ToString();
					}
					if(dt.Rows[n]["base_keyword"]!=null && dt.Rows[n]["base_keyword"].ToString()!="")
					{
					model.base_keyword=dt.Rows[n]["base_keyword"].ToString();
					}
					if(dt.Rows[n]["base_describ"]!=null && dt.Rows[n]["base_describ"].ToString()!="")
					{
					model.base_describ=dt.Rows[n]["base_describ"].ToString();
					}
					if(dt.Rows[n]["base_beianhao"]!=null && dt.Rows[n]["base_beianhao"].ToString()!="")
					{
					model.base_beianhao=dt.Rows[n]["base_beianhao"].ToString();
					}
					if(dt.Rows[n]["base_content"]!=null && dt.Rows[n]["base_content"].ToString()!="")
					{
					model.base_content=dt.Rows[n]["base_content"].ToString();
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

