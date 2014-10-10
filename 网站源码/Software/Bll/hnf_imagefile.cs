using System;
using System.Data;
using System.Collections.Generic;
//using Maticsoft.Common;
using NewsSolution.Model;
namespace NewsSolution.BLL
{
	/// <summary>
	/// hnf_imagefile
	/// </summary>
	public partial class hnf_imagefile
	{
		private readonly NewsSolution.DAL.hnf_imagefile dal=new NewsSolution.DAL.hnf_imagefile();
		public hnf_imagefile()
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
		public bool Exists(int image_id)
		{
			return dal.Exists(image_id);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(NewsSolution.Model.hnf_imagefile model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(NewsSolution.Model.hnf_imagefile model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int image_id)
		{
			
			return dal.Delete(image_id);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string image_idlist )
		{
			return dal.DeleteList(image_idlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public NewsSolution.Model.hnf_imagefile GetModel(int image_id)
		{
			
			return dal.GetModel(image_id);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
        //public NewsSolution.Model.hnf_imagefile GetModelByCache(int image_id)
        //{
			
        //    string CacheKey = "hnf_imagefileModel-" + image_id;
        //    object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
        //    if (objModel == null)
        //    {
        //        try
        //        {
        //            objModel = dal.GetModel(image_id);
        //            if (objModel != null)
        //            {
        //                int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
        //                Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
        //            }
        //        }
        //        catch{}
        //    }
        //    return (NewsSolution.Model.hnf_imagefile)objModel;
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
		public List<NewsSolution.Model.hnf_imagefile> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<NewsSolution.Model.hnf_imagefile> DataTableToList(DataTable dt)
		{
			List<NewsSolution.Model.hnf_imagefile> modelList = new List<NewsSolution.Model.hnf_imagefile>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				NewsSolution.Model.hnf_imagefile model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new NewsSolution.Model.hnf_imagefile();
					if(dt.Rows[n]["image_id"]!=null && dt.Rows[n]["image_id"].ToString()!="")
					{
						model.image_id=int.Parse(dt.Rows[n]["image_id"].ToString());
					}
					if(dt.Rows[n]["image_name"]!=null && dt.Rows[n]["image_name"].ToString()!="")
					{
					model.image_name=dt.Rows[n]["image_name"].ToString();
					}
					if(dt.Rows[n]["image_file"]!=null && dt.Rows[n]["image_file"].ToString()!="")
					{
					model.image_file=dt.Rows[n]["image_file"].ToString();
					}
					if(dt.Rows[n]["image_url"]!=null && dt.Rows[n]["image_url"].ToString()!="")
					{
					model.image_url=dt.Rows[n]["image_url"].ToString();
					}
					if(dt.Rows[n]["image_content"]!=null && dt.Rows[n]["image_content"].ToString()!="")
					{
					model.image_content=dt.Rows[n]["image_content"].ToString();
					}
					if(dt.Rows[n]["image_type_id"]!=null && dt.Rows[n]["image_type_id"].ToString()!="")
					{
						model.image_type_id=int.Parse(dt.Rows[n]["image_type_id"].ToString());
					}
					if(dt.Rows[n]["user_id"]!=null && dt.Rows[n]["user_id"].ToString()!="")
					{
						model.user_id=int.Parse(dt.Rows[n]["user_id"].ToString());
					}
					if(dt.Rows[n]["image_times"]!=null && dt.Rows[n]["image_times"].ToString()!="")
					{
						model.image_times=int.Parse(dt.Rows[n]["image_times"].ToString());
					}
					if(dt.Rows[n]["image_addtime"]!=null && dt.Rows[n]["image_addtime"].ToString()!="")
					{
						model.image_addtime=DateTime.Parse(dt.Rows[n]["image_addtime"].ToString());
					}
					if(dt.Rows[n]["image_shenhe"]!=null && dt.Rows[n]["image_shenhe"].ToString()!="")
					{
						model.image_shenhe=int.Parse(dt.Rows[n]["image_shenhe"].ToString());
					}
					if(dt.Rows[n]["image_recommand"]!=null && dt.Rows[n]["image_recommand"].ToString()!="")
					{
						model.image_recommand=int.Parse(dt.Rows[n]["image_recommand"].ToString());
					}
					if(dt.Rows[n]["guanggao_type"]!=null && dt.Rows[n]["guanggao_type"].ToString()!="")
					{
						model.guanggao_type=int.Parse(dt.Rows[n]["guanggao_type"].ToString());
					}
					if(dt.Rows[n]["huandeng_type"]!=null && dt.Rows[n]["huandeng_type"].ToString()!="")
					{
						model.huandeng_type=int.Parse(dt.Rows[n]["huandeng_type"].ToString());
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
        /// <summary>
        /// 统计当月发布图片资讯记录数
        /// </summary>		
        public int getnum(int image_type_id, int year, int month)
        {
            return dal.getnum(image_type_id, year, month);
        }
		#endregion  Method
	}
}

