using System;
using System.Data;
using System.Collections.Generic;
//using Maticsoft.Common;
using NewsSolution.Model;
namespace NewsSolution.BLL
{
	/// <summary>
	/// hnf_n_type
	/// </summary>
	public partial class hnf_n_type
	{
		private readonly NewsSolution.DAL.hnf_n_type dal=new NewsSolution.DAL.hnf_n_type();
		public hnf_n_type()
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
		public bool Exists(int n_type_id)
		{
			return dal.Exists(n_type_id);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(NewsSolution.Model.hnf_n_type model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(NewsSolution.Model.hnf_n_type model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int n_type_id)
		{
			
			return dal.Delete(n_type_id);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string n_type_idlist )
		{
			return dal.DeleteList(n_type_idlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public NewsSolution.Model.hnf_n_type GetModel(int n_type_id)
		{
			
			return dal.GetModel(n_type_id);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
        //public NewsSolution.Model.hnf_n_type GetModelByCache(int n_type_id)
        //{
			
        //    string CacheKey = "hnf_n_typeModel-" + n_type_id;
        //    object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
        //    if (objModel == null)
        //    {
        //        try
        //        {
        //            objModel = dal.GetModel(n_type_id);
        //            if (objModel != null)
        //            {
        //                int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
        //                Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
        //            }
        //        }
        //        catch{}
        //    }
        //    return (NewsSolution.Model.hnf_n_type)objModel;
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
		public List<NewsSolution.Model.hnf_n_type> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<NewsSolution.Model.hnf_n_type> DataTableToList(DataTable dt)
		{
			List<NewsSolution.Model.hnf_n_type> modelList = new List<NewsSolution.Model.hnf_n_type>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				NewsSolution.Model.hnf_n_type model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new NewsSolution.Model.hnf_n_type();
					if(dt.Rows[n]["n_type_id"]!=null && dt.Rows[n]["n_type_id"].ToString()!="")
					{
						model.n_type_id=int.Parse(dt.Rows[n]["n_type_id"].ToString());
					}
					if(dt.Rows[n]["n_type_name"]!=null && dt.Rows[n]["n_type_name"].ToString()!="")
					{
					model.n_type_name=dt.Rows[n]["n_type_name"].ToString();
					}
					if(dt.Rows[n]["n_type_parentid"]!=null && dt.Rows[n]["n_type_parentid"].ToString()!="")
					{
						model.n_type_parentid=int.Parse(dt.Rows[n]["n_type_parentid"].ToString());
					}
					if(dt.Rows[n]["n_type_strsort"]!=null && dt.Rows[n]["n_type_strsort"].ToString()!="")
					{
					model.n_type_strsort=dt.Rows[n]["n_type_strsort"].ToString();
					}
					if(dt.Rows[n]["n_type_depth"]!=null && dt.Rows[n]["n_type_depth"].ToString()!="")
					{
						model.n_type_depth=int.Parse(dt.Rows[n]["n_type_depth"].ToString());
					}
					if(dt.Rows[n]["n_type_root"]!=null && dt.Rows[n]["n_type_root"].ToString()!="")
					{
						model.n_type_root=int.Parse(dt.Rows[n]["n_type_root"].ToString());
					}
					if(dt.Rows[n]["n_type_sort"]!=null && dt.Rows[n]["n_type_sort"].ToString()!="")
					{
						model.n_type_sort=int.Parse(dt.Rows[n]["n_type_sort"].ToString());
					}
					if(dt.Rows[n]["n_type_isshow"]!=null && dt.Rows[n]["n_type_isshow"].ToString()!="")
					{
						model.n_type_isshow=int.Parse(dt.Rows[n]["n_type_isshow"].ToString());
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
        public bool addfristtype(int parentid)
        {
            return dal.addfirsttype(parentid);
        }

        public bool addsecondtype(int parentid)
        {
            return dal.addsecondtype(parentid);
        }
        public bool UpdOrder(int id, int order)
        {
            return dal.UpdOrder(id, order);
        }
		#endregion  Method
	}
}

