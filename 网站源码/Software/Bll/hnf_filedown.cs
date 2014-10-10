using System;
using System.Data;
using System.Collections.Generic;
//using Maticsoft.Common;
using NewsSolution.Model;
namespace NewsSolution.BLL
{
	/// <summary>
	/// hnf_filedown
	/// </summary>
	public partial class hnf_filedown
	{
		private readonly NewsSolution.DAL.hnf_filedown dal=new NewsSolution.DAL.hnf_filedown();
		public hnf_filedown()
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
		public bool Exists(int down_id)
		{
			return dal.Exists(down_id);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(NewsSolution.Model.hnf_filedown model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(NewsSolution.Model.hnf_filedown model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int down_id)
		{
			
			return dal.Delete(down_id);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string down_idlist )
		{
			return dal.DeleteList(down_idlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public NewsSolution.Model.hnf_filedown GetModel(int down_id)
		{
			
			return dal.GetModel(down_id);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
        //public NewsSolution.Model.hnf_filedown GetModelByCache(int down_id)
        //{
			
        //    string CacheKey = "hnf_filedownModel-" + down_id;
        //    object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
        //    if (objModel == null)
        //    {
        //        try
        //        {
        //            objModel = dal.GetModel(down_id);
        //            if (objModel != null)
        //            {
        //                int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
        //                Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
        //            }
        //        }
        //        catch{}
        //    }
        //    return (NewsSolution.Model.hnf_filedown)objModel;
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
		public List<NewsSolution.Model.hnf_filedown> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<NewsSolution.Model.hnf_filedown> DataTableToList(DataTable dt)
		{
			List<NewsSolution.Model.hnf_filedown> modelList = new List<NewsSolution.Model.hnf_filedown>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				NewsSolution.Model.hnf_filedown model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new NewsSolution.Model.hnf_filedown();
					if(dt.Rows[n]["down_id"]!=null && dt.Rows[n]["down_id"].ToString()!="")
					{
						model.down_id=int.Parse(dt.Rows[n]["down_id"].ToString());
					}
					if(dt.Rows[n]["down_seotitle"]!=null && dt.Rows[n]["down_seotitle"].ToString()!="")
					{
					model.down_seotitle=dt.Rows[n]["down_seotitle"].ToString();
					}
					if(dt.Rows[n]["down_keyword"]!=null && dt.Rows[n]["down_keyword"].ToString()!="")
					{
					model.down_keyword=dt.Rows[n]["down_keyword"].ToString();
					}
					if(dt.Rows[n]["down_describ"]!=null && dt.Rows[n]["down_describ"].ToString()!="")
					{
					model.down_describ=dt.Rows[n]["down_describ"].ToString();
					}
					if(dt.Rows[n]["down_name"]!=null && dt.Rows[n]["down_name"].ToString()!="")
					{
					model.down_name=dt.Rows[n]["down_name"].ToString();
					}
					if(dt.Rows[n]["file_name"]!=null && dt.Rows[n]["file_name"].ToString()!="")
					{
					model.file_name=dt.Rows[n]["file_name"].ToString();
					}
					if(dt.Rows[n]["file_url"]!=null && dt.Rows[n]["file_url"].ToString()!="")
					{
					model.file_url=dt.Rows[n]["file_url"].ToString();
					}
					if(dt.Rows[n]["file_content"]!=null && dt.Rows[n]["file_content"].ToString()!="")
					{
					model.file_content=dt.Rows[n]["file_content"].ToString();
					}
					if(dt.Rows[n]["down_shenhe"]!=null && dt.Rows[n]["down_shenhe"].ToString()!="")
					{
						model.down_shenhe=int.Parse(dt.Rows[n]["down_shenhe"].ToString());
					}
					if(dt.Rows[n]["down_recommand"]!=null && dt.Rows[n]["down_recommand"].ToString()!="")
					{
						model.down_recommand=int.Parse(dt.Rows[n]["down_recommand"].ToString());
					}
					if(dt.Rows[n]["down_createtime"]!=null && dt.Rows[n]["down_createtime"].ToString()!="")
					{
						model.down_createtime=DateTime.Parse(dt.Rows[n]["down_createtime"].ToString());
					}
					if(dt.Rows[n]["down_times"]!=null && dt.Rows[n]["down_times"].ToString()!="")
					{
						model.down_times=int.Parse(dt.Rows[n]["down_times"].ToString());
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
        public DataSet GetIdList(string strWhere)
        {
            return dal.GetIdList(strWhere);
        }
		#endregion  Method
	}
}

