using System;
using System.Data;
using System.Collections.Generic;
//using Maticsoft.Common;
using NewsSolution.Model;
using NewsSolution.DAL;
namespace NewsSolution.BLL
{
	/// <summary>
	/// hnf_news
	/// </summary>
	public partial class hnf_news
	{
		private readonly NewsSolution.DAL.hnf_news dal=new NewsSolution.DAL.hnf_news();
		public hnf_news()
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
		public bool Exists(int news_id)
		{
			return dal.Exists(news_id);
		}
        public int Add1(NewsSolution.Model.hnf_news model)
        {
            return dal.Add1(model);
        }
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(NewsSolution.Model.hnf_news model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(NewsSolution.Model.hnf_news model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int news_id)
		{
			
			return dal.Delete(news_id);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string news_idlist )
		{
			return dal.DeleteList(news_idlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public NewsSolution.Model.hnf_news GetModel(int news_id)
		{
			
			return dal.GetModel(news_id);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
        //public NewsSolution.Model.hnf_news GetModelByCache(int news_id)
        //{
			
        //    string CacheKey = "hnf_newsModel-" + news_id;
        //    object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
        //    if (objModel == null)
        //    {
        //        try
        //        {
        //            objModel = dal.GetModel(news_id);
        //            if (objModel != null)
        //            {
        //                int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
        //                Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
        //            }
        //        }
        //        catch{}
        //    }
        //    return (NewsSolution.Model.hnf_news)objModel;
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
		public List<NewsSolution.Model.hnf_news> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<NewsSolution.Model.hnf_news> DataTableToList(DataTable dt)
		{
			List<NewsSolution.Model.hnf_news> modelList = new List<NewsSolution.Model.hnf_news>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				NewsSolution.Model.hnf_news model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new NewsSolution.Model.hnf_news();
					if(dt.Rows[n]["news_id"]!=null && dt.Rows[n]["news_id"].ToString()!="")
					{
						model.news_id=int.Parse(dt.Rows[n]["news_id"].ToString());
					}
					if(dt.Rows[n]["news_seotitle"]!=null && dt.Rows[n]["news_seotitle"].ToString()!="")
					{
					model.news_seotitle=dt.Rows[n]["news_seotitle"].ToString();
					}
					if(dt.Rows[n]["news_keyword"]!=null && dt.Rows[n]["news_keyword"].ToString()!="")
					{
					model.news_keyword=dt.Rows[n]["news_keyword"].ToString();
					}
					if(dt.Rows[n]["news_describ"]!=null && dt.Rows[n]["news_describ"].ToString()!="")
					{
					model.news_describ=dt.Rows[n]["news_describ"].ToString();
					}
					if(dt.Rows[n]["news_name"]!=null && dt.Rows[n]["news_name"].ToString()!="")
					{
					model.news_name=dt.Rows[n]["news_name"].ToString();
					}
					if(dt.Rows[n]["news_content"]!=null && dt.Rows[n]["news_content"].ToString()!="")
					{
					model.news_content=dt.Rows[n]["news_content"].ToString();
					}
					if(dt.Rows[n]["news_createtime"]!=null && dt.Rows[n]["news_createtime"].ToString()!="")
					{
						model.news_createtime=DateTime.Parse(dt.Rows[n]["news_createtime"].ToString());
					}
					if(dt.Rows[n]["news_alertime"]!=null && dt.Rows[n]["news_alertime"].ToString()!="")
					{
						model.news_alertime=DateTime.Parse(dt.Rows[n]["news_alertime"].ToString());
					}
					if(dt.Rows[n]["news_comefrom"]!=null && dt.Rows[n]["news_comefrom"].ToString()!="")
					{
					model.news_comefrom=dt.Rows[n]["news_comefrom"].ToString();
					}
					if(dt.Rows[n]["news_seetime"]!=null && dt.Rows[n]["news_seetime"].ToString()!="")
					{
						model.news_seetime=int.Parse(dt.Rows[n]["news_seetime"].ToString());
					}
					if(dt.Rows[n]["news_isshow"]!=null && dt.Rows[n]["news_isshow"].ToString()!="")
					{
						model.news_isshow=int.Parse(dt.Rows[n]["news_isshow"].ToString());
					}
					if(dt.Rows[n]["news_recommand"]!=null && dt.Rows[n]["news_recommand"].ToString()!="")
					{
						model.news_recommand=int.Parse(dt.Rows[n]["news_recommand"].ToString());
					}
					if(dt.Rows[n]["news_type"]!=null && dt.Rows[n]["news_type"].ToString()!="")
					{
						model.news_type=int.Parse(dt.Rows[n]["news_type"].ToString());
					}
					if(dt.Rows[n]["news_image"]!=null && dt.Rows[n]["news_image"].ToString()!="")
					{
					model.news_image=dt.Rows[n]["news_image"].ToString();
					}
					if(dt.Rows[n]["news_isimage"]!=null && dt.Rows[n]["news_isimage"].ToString()!="")
					{
						model.news_isimage=int.Parse(dt.Rows[n]["news_isimage"].ToString());
					}
					if(dt.Rows[n]["news_sort"]!=null && dt.Rows[n]["news_sort"].ToString()!="")
					{
						model.news_sort=int.Parse(dt.Rows[n]["news_sort"].ToString());
					}
					if(dt.Rows[n]["user_id"]!=null && dt.Rows[n]["user_id"].ToString()!="")
					{
						model.user_id=int.Parse(dt.Rows[n]["user_id"].ToString());
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
        public DataSet GetIdList(string strWhere)
        {
            return dal.GetIdList(strWhere);
        }
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}
        public int getnum(int news_type, int year, int month)
        {
            return dal.getnum(news_type, year, month);
        }
		#endregion  Method
	}
}

