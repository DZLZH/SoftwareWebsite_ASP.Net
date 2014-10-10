using System;
using System.Data;
using System.Collections.Generic;
//using Maticsoft.Common;
using NewsSolution.Model;
namespace NewsSolution.BLL
{
	/// <summary>
	/// hnf_imagetype
	/// </summary>
	public partial class hnf_imagetype
	{
		private readonly NewsSolution.DAL.hnf_imagetype dal=new NewsSolution.DAL.hnf_imagetype();
		public hnf_imagetype()
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
		public bool Exists(int image_type_id)
		{
			return dal.Exists(image_type_id);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(NewsSolution.Model.hnf_imagetype model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(NewsSolution.Model.hnf_imagetype model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int image_type_id)
		{
			
			return dal.Delete(image_type_id);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string image_type_idlist )
		{
			return dal.DeleteList(image_type_idlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public NewsSolution.Model.hnf_imagetype GetModel(int image_type_id)
		{
			
			return dal.GetModel(image_type_id);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
        //public NewsSolution.Model.hnf_imagetype GetModelByCache(int image_type_id)
        //{
			
        //    string CacheKey = "hnf_imagetypeModel-" + image_type_id;
        //    object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
        //    if (objModel == null)
        //    {
        //        try
        //        {
        //            objModel = dal.GetModel(image_type_id);
        //            if (objModel != null)
        //            {
        //                int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
        //                Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
        //            }
        //        }
        //        catch{}
        //    }
        //    return (NewsSolution.Model.hnf_imagetype)objModel;
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
		public List<NewsSolution.Model.hnf_imagetype> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<NewsSolution.Model.hnf_imagetype> DataTableToList(DataTable dt)
		{
			List<NewsSolution.Model.hnf_imagetype> modelList = new List<NewsSolution.Model.hnf_imagetype>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				NewsSolution.Model.hnf_imagetype model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new NewsSolution.Model.hnf_imagetype();
					if(dt.Rows[n]["image_type_id"]!=null && dt.Rows[n]["image_type_id"].ToString()!="")
					{
						model.image_type_id=int.Parse(dt.Rows[n]["image_type_id"].ToString());
					}
					if(dt.Rows[n]["image_type_name"]!=null && dt.Rows[n]["image_type_name"].ToString()!="")
					{
					model.image_type_name=dt.Rows[n]["image_type_name"].ToString();
					}
					if(dt.Rows[n]["image_type_time"]!=null && dt.Rows[n]["image_type_time"].ToString()!="")
					{
						model.image_type_time=DateTime.Parse(dt.Rows[n]["image_type_time"].ToString());
					}
					if(dt.Rows[n]["mage_type_parent"]!=null && dt.Rows[n]["mage_type_parent"].ToString()!="")
					{
						model.mage_type_parent=int.Parse(dt.Rows[n]["mage_type_parent"].ToString());
					}
					if(dt.Rows[n]["image_sort"]!=null && dt.Rows[n]["image_sort"].ToString()!="")
					{
						model.image_sort=int.Parse(dt.Rows[n]["image_sort"].ToString());
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

