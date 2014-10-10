using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace NewsSolution.DAL
{
	/// <summary>
	/// 数据访问类:roles
	/// </summary>
	public partial class roles
	{
		public roles()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("roleid", "roles"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int roleid)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from roles");
			strSql.Append(" where roleid=@roleid");
			SqlParameter[] parameters = {
					new SqlParameter("@roleid", SqlDbType.Int,4)
			};
			parameters[0].Value = roleid;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(NewsSolution.Model.roles model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into roles(");
			strSql.Append("rolename,flash,video,documents,other,source,green)");
			strSql.Append(" values (");
			strSql.Append("@rolename,@flash,@video,@documents,@other,@source,@green)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@rolename", SqlDbType.VarChar,50),
					new SqlParameter("@flash", SqlDbType.Int,4),
					new SqlParameter("@video", SqlDbType.Int,4),
					new SqlParameter("@documents", SqlDbType.Int,4),
					new SqlParameter("@other", SqlDbType.Int,4),
					new SqlParameter("@source", SqlDbType.Int,4),
					new SqlParameter("@green", SqlDbType.Int,4)};
			parameters[0].Value = model.rolename;
			parameters[1].Value = model.flash;
			parameters[2].Value = model.video;
			parameters[3].Value = model.documents;
			parameters[4].Value = model.other;
			parameters[5].Value = model.source;
			parameters[6].Value = model.green;

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
		public bool Update(NewsSolution.Model.roles model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update roles set ");
			strSql.Append("rolename=@rolename,");
			strSql.Append("flash=@flash,");
			strSql.Append("video=@video,");
			strSql.Append("documents=@documents,");
			strSql.Append("other=@other,");
			strSql.Append("source=@source,");
			strSql.Append("green=@green");
			strSql.Append(" where roleid=@roleid");
			SqlParameter[] parameters = {
					new SqlParameter("@rolename", SqlDbType.VarChar,50),
					new SqlParameter("@flash", SqlDbType.Int,4),
					new SqlParameter("@video", SqlDbType.Int,4),
					new SqlParameter("@documents", SqlDbType.Int,4),
					new SqlParameter("@other", SqlDbType.Int,4),
					new SqlParameter("@source", SqlDbType.Int,4),
					new SqlParameter("@green", SqlDbType.Int,4),
					new SqlParameter("@roleid", SqlDbType.Int,4)};
			parameters[0].Value = model.rolename;
			parameters[1].Value = model.flash;
			parameters[2].Value = model.video;
			parameters[3].Value = model.documents;
			parameters[4].Value = model.other;
			parameters[5].Value = model.source;
			parameters[6].Value = model.green;
			parameters[7].Value = model.roleid;

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
		public bool Delete(int roleid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from roles ");
			strSql.Append(" where roleid=@roleid");
			SqlParameter[] parameters = {
					new SqlParameter("@roleid", SqlDbType.Int,4)
			};
			parameters[0].Value = roleid;

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
		public bool DeleteList(string roleidlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from roles ");
			strSql.Append(" where roleid in ("+roleidlist + ")  ");
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
		public NewsSolution.Model.roles GetModel(int roleid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 roleid,rolename,flash,video,documents,other,source,green from roles ");
			strSql.Append(" where roleid=@roleid");
			SqlParameter[] parameters = {
					new SqlParameter("@roleid", SqlDbType.Int,4)
			};
			parameters[0].Value = roleid;

			NewsSolution.Model.roles model=new NewsSolution.Model.roles();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["roleid"]!=null && ds.Tables[0].Rows[0]["roleid"].ToString()!="")
				{
					model.roleid=int.Parse(ds.Tables[0].Rows[0]["roleid"].ToString());
				}
				if(ds.Tables[0].Rows[0]["rolename"]!=null && ds.Tables[0].Rows[0]["rolename"].ToString()!="")
				{
					model.rolename=ds.Tables[0].Rows[0]["rolename"].ToString();
				}
				if(ds.Tables[0].Rows[0]["flash"]!=null && ds.Tables[0].Rows[0]["flash"].ToString()!="")
				{
					model.flash=int.Parse(ds.Tables[0].Rows[0]["flash"].ToString());
				}
				if(ds.Tables[0].Rows[0]["video"]!=null && ds.Tables[0].Rows[0]["video"].ToString()!="")
				{
					model.video=int.Parse(ds.Tables[0].Rows[0]["video"].ToString());
				}
				if(ds.Tables[0].Rows[0]["documents"]!=null && ds.Tables[0].Rows[0]["documents"].ToString()!="")
				{
					model.documents=int.Parse(ds.Tables[0].Rows[0]["documents"].ToString());
				}
				if(ds.Tables[0].Rows[0]["other"]!=null && ds.Tables[0].Rows[0]["other"].ToString()!="")
				{
					model.other=int.Parse(ds.Tables[0].Rows[0]["other"].ToString());
				}
				if(ds.Tables[0].Rows[0]["source"]!=null && ds.Tables[0].Rows[0]["source"].ToString()!="")
				{
					model.source=int.Parse(ds.Tables[0].Rows[0]["source"].ToString());
				}
				if(ds.Tables[0].Rows[0]["green"]!=null && ds.Tables[0].Rows[0]["green"].ToString()!="")
				{
					model.green=int.Parse(ds.Tables[0].Rows[0]["green"].ToString());
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
			strSql.Append("select roleid,rolename,flash,video,documents,other,source,green ");
			strSql.Append(" FROM roles ");
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
            strSql.Append(" roleid,rolename,flash,video,documents,other,source,green ");
            strSql.Append(" FROM roles ");
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
			strSql.Append(" roleid,rolename,flash,video,documents,other,source,green ");
			strSql.Append(" FROM roles ");
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
			strSql.Append("select count(1) FROM roles ");
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
				strSql.Append("order by T.roleid desc");
			}
			strSql.Append(")AS Row, T.*  from roles T ");
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
			parameters[0].Value = "roles";
			parameters[1].Value = "roleid";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  Method
	}
}

