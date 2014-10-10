using System;
using System.Data;
using System.Collections.Generic;
//using Maticsoft.Common;
using NewsSolution.Model;
namespace NewsSolution.BLL
{
	/// <summary>
	/// hnf_user
	/// </summary>
	public partial class hnf_user
	{
		private readonly NewsSolution.DAL.hnf_user dal=new NewsSolution.DAL.hnf_user();
		public hnf_user()
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
		public bool Exists(int user_id)
		{
			return dal.Exists(user_id);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(NewsSolution.Model.hnf_user model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(NewsSolution.Model.hnf_user model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int user_id)
		{
			
			return dal.Delete(user_id);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string user_idlist )
		{
			return dal.DeleteList(user_idlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public NewsSolution.Model.hnf_user GetModel(int user_id)
		{
			
			return dal.GetModel(user_id);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
        ///// </summary>
        //public NewsSolution.Model.hnf_user GetModelByCache(int user_id)
        //{
			
        //    string CacheKey = "hnf_userModel-" + user_id;
        //    object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
        //    if (objModel == null)
        //    {
        //        try
        //        {
        //            objModel = dal.GetModel(user_id);
        //            if (objModel != null)
        //            {
        //                int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
        //                Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
        //            }
        //        }
        //        catch{}
        //    }
        //    return (NewsSolution.Model.hnf_user)objModel;
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
		public List<NewsSolution.Model.hnf_user> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<NewsSolution.Model.hnf_user> DataTableToList(DataTable dt)
		{
			List<NewsSolution.Model.hnf_user> modelList = new List<NewsSolution.Model.hnf_user>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				NewsSolution.Model.hnf_user model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new NewsSolution.Model.hnf_user();
					if(dt.Rows[n]["user_id"]!=null && dt.Rows[n]["user_id"].ToString()!="")
					{
						model.user_id=int.Parse(dt.Rows[n]["user_id"].ToString());
					}
					if(dt.Rows[n]["user_name"]!=null && dt.Rows[n]["user_name"].ToString()!="")
					{
					model.user_name=dt.Rows[n]["user_name"].ToString();
					}
					if(dt.Rows[n]["user_password"]!=null && dt.Rows[n]["user_password"].ToString()!="")
					{
					model.user_password=dt.Rows[n]["user_password"].ToString();
					}
					if(dt.Rows[n]["user_truename"]!=null && dt.Rows[n]["user_truename"].ToString()!="")
					{
					model.user_truename=dt.Rows[n]["user_truename"].ToString();
					}
					if(dt.Rows[n]["user_question"]!=null && dt.Rows[n]["user_question"].ToString()!="")
					{
					model.user_question=dt.Rows[n]["user_question"].ToString();
					}
					if(dt.Rows[n]["user_answer"]!=null && dt.Rows[n]["user_answer"].ToString()!="")
					{
					model.user_answer=dt.Rows[n]["user_answer"].ToString();
					}
					if(dt.Rows[n]["user_isable"]!=null && dt.Rows[n]["user_isable"].ToString()!="")
					{
						model.user_isable=int.Parse(dt.Rows[n]["user_isable"].ToString());
					}
					if(dt.Rows[n]["user_addTime"]!=null && dt.Rows[n]["user_addTime"].ToString()!="")
					{
						model.user_addTime=DateTime.Parse(dt.Rows[n]["user_addTime"].ToString());
					}
					if(dt.Rows[n]["user_email"]!=null && dt.Rows[n]["user_email"].ToString()!="")
					{
					model.user_email=dt.Rows[n]["user_email"].ToString();
					}
					if(dt.Rows[n]["user_type"]!=null && dt.Rows[n]["user_type"].ToString()!="")
					{
						model.user_type=int.Parse(dt.Rows[n]["user_type"].ToString());
					}
					if(dt.Rows[n]["u_flash"]!=null && dt.Rows[n]["u_flash"].ToString()!="")
					{
						model.u_flash=int.Parse(dt.Rows[n]["u_flash"].ToString());
					}
					if(dt.Rows[n]["u_video"]!=null && dt.Rows[n]["u_video"].ToString()!="")
					{
						model.u_video=int.Parse(dt.Rows[n]["u_video"].ToString());
					}
					if(dt.Rows[n]["u_document"]!=null && dt.Rows[n]["u_document"].ToString()!="")
					{
						model.u_document=int.Parse(dt.Rows[n]["u_document"].ToString());
					}
					if(dt.Rows[n]["u_source"]!=null && dt.Rows[n]["u_source"].ToString()!="")
					{
						model.u_source=int.Parse(dt.Rows[n]["u_source"].ToString());
					}
					if(dt.Rows[n]["u_other"]!=null && dt.Rows[n]["u_other"].ToString()!="")
					{
						model.u_other=int.Parse(dt.Rows[n]["u_other"].ToString());
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

