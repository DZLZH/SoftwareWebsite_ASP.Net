using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace NewsSolution.DAL
{
	/// <summary>
	/// 数据访问类:hnf_link
	/// </summary>
	public partial class hnf_link
	{
		public hnf_link()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("link_id", "hnf_link"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int link_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from hnf_link");
			strSql.Append(" where link_id=@link_id");
			SqlParameter[] parameters = {
					new SqlParameter("@link_id", SqlDbType.Int,4)
			};
			parameters[0].Value = link_id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(NewsSolution.Model.hnf_link model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into hnf_link(");
			strSql.Append("site_name,site_url,site_logo,site_sort,site_shenhe,site_createtime)");
			strSql.Append(" values (");
			strSql.Append("@site_name,@site_url,@site_logo,@site_sort,@site_shenhe,@site_createtime)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@site_name", SqlDbType.NVarChar,50),
					new SqlParameter("@site_url", SqlDbType.NVarChar,50),
					new SqlParameter("@site_logo", SqlDbType.NVarChar,50),
					new SqlParameter("@site_sort", SqlDbType.Int,4),
					new SqlParameter("@site_shenhe", SqlDbType.Int,4),
					new SqlParameter("@site_createtime", SqlDbType.SmallDateTime)};
			parameters[0].Value = model.site_name;
			parameters[1].Value = model.site_url;
			parameters[2].Value = model.site_logo;
			parameters[3].Value = model.site_sort;
			parameters[4].Value = model.site_shenhe;
			parameters[5].Value = model.site_createtime;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(NewsSolution.Model.hnf_link model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update hnf_link set ");
			strSql.Append("site_name=@site_name,");
			strSql.Append("site_url=@site_url,");
			strSql.Append("site_logo=@site_logo,");
			strSql.Append("site_sort=@site_sort,");
			strSql.Append("site_shenhe=@site_shenhe,");
			strSql.Append("site_createtime=@site_createtime");
			strSql.Append(" where link_id=@link_id");
			SqlParameter[] parameters = {
					new SqlParameter("@site_name", SqlDbType.NVarChar,50),
					new SqlParameter("@site_url", SqlDbType.NVarChar,50),
					new SqlParameter("@site_logo", SqlDbType.NVarChar,50),
					new SqlParameter("@site_sort", SqlDbType.Int,4),
					new SqlParameter("@site_shenhe", SqlDbType.Int,4),
					new SqlParameter("@site_createtime", SqlDbType.SmallDateTime),
					new SqlParameter("@link_id", SqlDbType.Int,4)};
			parameters[0].Value = model.site_name;
			parameters[1].Value = model.site_url;
			parameters[2].Value = model.site_logo;
			parameters[3].Value = model.site_sort;
			parameters[4].Value = model.site_shenhe;
			parameters[5].Value = model.site_createtime;
			parameters[6].Value = model.link_id;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int link_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from hnf_link ");
			strSql.Append(" where link_id=@link_id");
			SqlParameter[] parameters = {
					new SqlParameter("@link_id", SqlDbType.Int,4)
			};
			parameters[0].Value = link_id;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string link_idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from hnf_link ");
			strSql.Append(" where link_id in ("+link_idlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public NewsSolution.Model.hnf_link GetModel(int link_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 link_id,site_name,site_url,site_logo,site_sort,site_shenhe,site_createtime from hnf_link ");
			strSql.Append(" where link_id=@link_id");
			SqlParameter[] parameters = {
					new SqlParameter("@link_id", SqlDbType.Int,4)
			};
			parameters[0].Value = link_id;

			NewsSolution.Model.hnf_link model=new NewsSolution.Model.hnf_link();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["link_id"]!=null && ds.Tables[0].Rows[0]["link_id"].ToString()!="")
				{
					model.link_id=int.Parse(ds.Tables[0].Rows[0]["link_id"].ToString());
				}
				if(ds.Tables[0].Rows[0]["site_name"]!=null && ds.Tables[0].Rows[0]["site_name"].ToString()!="")
				{
					model.site_name=ds.Tables[0].Rows[0]["site_name"].ToString();
				}
				if(ds.Tables[0].Rows[0]["site_url"]!=null && ds.Tables[0].Rows[0]["site_url"].ToString()!="")
				{
					model.site_url=ds.Tables[0].Rows[0]["site_url"].ToString();
				}
				if(ds.Tables[0].Rows[0]["site_logo"]!=null && ds.Tables[0].Rows[0]["site_logo"].ToString()!="")
				{
					model.site_logo=ds.Tables[0].Rows[0]["site_logo"].ToString();
				}
				if(ds.Tables[0].Rows[0]["site_sort"]!=null && ds.Tables[0].Rows[0]["site_sort"].ToString()!="")
				{
					model.site_sort=int.Parse(ds.Tables[0].Rows[0]["site_sort"].ToString());
				}
				if(ds.Tables[0].Rows[0]["site_shenhe"]!=null && ds.Tables[0].Rows[0]["site_shenhe"].ToString()!="")
				{
					model.site_shenhe=int.Parse(ds.Tables[0].Rows[0]["site_shenhe"].ToString());
				}
				if(ds.Tables[0].Rows[0]["site_createtime"]!=null && ds.Tables[0].Rows[0]["site_createtime"].ToString()!="")
				{
					model.site_createtime=DateTime.Parse(ds.Tables[0].Rows[0]["site_createtime"].ToString());
				}
				return model;
			}
			else
			{
				return null;
			}
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select link_id,site_name,site_url,site_logo,site_sort,site_shenhe,site_createtime ");
			strSql.Append(" FROM hnf_link ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}
        public DataSet GetList(int Top, string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" link_id,site_name,site_url,site_logo,site_sort,site_shenhe,site_createtime ");
            strSql.Append(" FROM hnf_link ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            
            return DbHelperSQL.Query(strSql.ToString());
        }
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" link_id,site_name,site_url,site_logo,site_sort,site_shenhe,site_createtime ");
			strSql.Append(" FROM hnf_link ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM hnf_link ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.link_id desc");
			}
			strSql.Append(")AS Row, T.*  from hnf_link T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "hnf_link";
			parameters[1].Value = "link_id";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/
        /// <summary>
        /// 根据id修改排序号
        /// </summary>
        /// <param name="id"></param>
        /// <param name="order"></param>
        /// <returns></returns>
        public bool UpdOrder(int id, int order)
        {
            try
            {
                DbHelperSQL.ExecuteSql("update hnf_link set site_sort=" + order + " where link_id=" + id);
            }
            catch
            {
                return false;
            }
            return true;
        }
		#endregion  Method
	}
}

