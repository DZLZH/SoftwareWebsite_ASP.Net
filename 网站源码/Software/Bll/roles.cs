using System;
using System.Data;
using System.Collections.Generic;
//using Maticsoft.Common;
using NewsSolution.Model;
namespace NewsSolution.BLL
{
	/// <summary>
	/// roles
	/// </summary>
	public partial class roles
	{
		private readonly NewsSolution.DAL.roles dal=new NewsSolution.DAL.roles();
		public roles()
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
		public bool Exists(int roleid)
		{
			return dal.Exists(roleid);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(NewsSolution.Model.roles model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(NewsSolution.Model.roles model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int roleid)
		{
			
			return dal.Delete(roleid);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string roleidlist )
		{
			return dal.DeleteList(roleidlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public NewsSolution.Model.roles GetModel(int roleid)
		{
			
			return dal.GetModel(roleid);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
        //public NewsSolution.Model.roles GetModelByCache(int roleid)
        //{
			
        //    string CacheKey = "rolesModel-" + roleid;
        //    object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
        //    if (objModel == null)
        //    {
        //        try
        //        {
        //            objModel = dal.GetModel(roleid);
        //            if (objModel != null)
        //            {
        //                int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
        //                Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
        //            }
        //        }
        //        catch{}
        //    }
        //    return (NewsSolution.Model.roles)objModel;
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
		public List<NewsSolution.Model.roles> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<NewsSolution.Model.roles> DataTableToList(DataTable dt)
		{
			List<NewsSolution.Model.roles> modelList = new List<NewsSolution.Model.roles>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				NewsSolution.Model.roles model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new NewsSolution.Model.roles();
					if(dt.Rows[n]["roleid"]!=null && dt.Rows[n]["roleid"].ToString()!="")
					{
						model.roleid=int.Parse(dt.Rows[n]["roleid"].ToString());
					}
					if(dt.Rows[n]["rolename"]!=null && dt.Rows[n]["rolename"].ToString()!="")
					{
					model.rolename=dt.Rows[n]["rolename"].ToString();
					}
					if(dt.Rows[n]["flash"]!=null && dt.Rows[n]["flash"].ToString()!="")
					{
						model.flash=int.Parse(dt.Rows[n]["flash"].ToString());
					}
					if(dt.Rows[n]["video"]!=null && dt.Rows[n]["video"].ToString()!="")
					{
						model.video=int.Parse(dt.Rows[n]["video"].ToString());
					}
					if(dt.Rows[n]["documents"]!=null && dt.Rows[n]["documents"].ToString()!="")
					{
						model.documents=int.Parse(dt.Rows[n]["documents"].ToString());
					}
					if(dt.Rows[n]["other"]!=null && dt.Rows[n]["other"].ToString()!="")
					{
						model.other=int.Parse(dt.Rows[n]["other"].ToString());
					}
					if(dt.Rows[n]["source"]!=null && dt.Rows[n]["source"].ToString()!="")
					{
						model.source=int.Parse(dt.Rows[n]["source"].ToString());
					}
					if(dt.Rows[n]["green"]!=null && dt.Rows[n]["green"].ToString()!="")
					{
						model.green=int.Parse(dt.Rows[n]["green"].ToString());
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

