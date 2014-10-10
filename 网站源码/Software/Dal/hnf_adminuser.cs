using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace NewsSolution.DAL
{
	/// <summary>
	/// 数据访问类:hnf_adminuser
	/// </summary>
	public partial class hnf_adminuser
	{
		public hnf_adminuser()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("user_id", "hnf_adminuser"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int user_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from hnf_adminuser");
			strSql.Append(" where user_id=@user_id");
			SqlParameter[] parameters = {
					new SqlParameter("@user_id", SqlDbType.Int,4)
			};
			parameters[0].Value = user_id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(NewsSolution.Model.hnf_adminuser model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into hnf_adminuser(");
			strSql.Append("user_name,user_password,user_createtime,user_ip,user_logintime,user_role)");
			strSql.Append(" values (");
			strSql.Append("@user_name,@user_password,@user_createtime,@user_ip,@user_logintime,@user_role)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@user_name", SqlDbType.NVarChar,50),
					new SqlParameter("@user_password", SqlDbType.NVarChar,50),
					new SqlParameter("@user_createtime", SqlDbType.SmallDateTime),
					new SqlParameter("@user_ip", SqlDbType.NVarChar,50),
					new SqlParameter("@user_logintime", SqlDbType.SmallDateTime),
					new SqlParameter("@user_role", SqlDbType.Int,4)};
			parameters[0].Value = model.user_name;
			parameters[1].Value = model.user_password;
			parameters[2].Value = model.user_createtime;
			parameters[3].Value = model.user_ip;
			parameters[4].Value = model.user_logintime;
			parameters[5].Value = model.user_role;

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
		public bool Update(NewsSolution.Model.hnf_adminuser model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update hnf_adminuser set ");
			strSql.Append("user_name=@user_name,");
			strSql.Append("user_password=@user_password,");
			strSql.Append("user_createtime=@user_createtime,");
			strSql.Append("user_ip=@user_ip,");
			strSql.Append("user_logintime=@user_logintime,");
			strSql.Append("user_role=@user_role");
			strSql.Append(" where user_id=@user_id");
			SqlParameter[] parameters = {
					new SqlParameter("@user_name", SqlDbType.NVarChar,50),
					new SqlParameter("@user_password", SqlDbType.NVarChar,50),
					new SqlParameter("@user_createtime", SqlDbType.SmallDateTime),
					new SqlParameter("@user_ip", SqlDbType.NVarChar,50),
					new SqlParameter("@user_logintime", SqlDbType.SmallDateTime),
					new SqlParameter("@user_role", SqlDbType.Int,4),
					new SqlParameter("@user_id", SqlDbType.Int,4)};
			parameters[0].Value = model.user_name;
			parameters[1].Value = model.user_password;
			parameters[2].Value = model.user_createtime;
			parameters[3].Value = model.user_ip;
			parameters[4].Value = model.user_logintime;
			parameters[5].Value = model.user_role;
			parameters[6].Value = model.user_id;

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
		public bool Delete(int user_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from hnf_adminuser ");
			strSql.Append(" where user_id=@user_id");
			SqlParameter[] parameters = {
					new SqlParameter("@user_id", SqlDbType.Int,4)
			};
			parameters[0].Value = user_id;

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
		public bool DeleteList(string user_idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from hnf_adminuser ");
			strSql.Append(" where user_id in ("+user_idlist + ")  ");
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
		public NewsSolution.Model.hnf_adminuser GetModel(int user_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 user_id,user_name,user_password,user_createtime,user_ip,user_logintime,user_role from hnf_adminuser ");
			strSql.Append(" where user_id=@user_id");
			SqlParameter[] parameters = {
					new SqlParameter("@user_id", SqlDbType.Int,4)
			};
			parameters[0].Value = user_id;

			NewsSolution.Model.hnf_adminuser model=new NewsSolution.Model.hnf_adminuser();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["user_id"]!=null && ds.Tables[0].Rows[0]["user_id"].ToString()!="")
				{
					model.user_id=int.Parse(ds.Tables[0].Rows[0]["user_id"].ToString());
				}
				if(ds.Tables[0].Rows[0]["user_name"]!=null && ds.Tables[0].Rows[0]["user_name"].ToString()!="")
				{
					model.user_name=ds.Tables[0].Rows[0]["user_name"].ToString();
				}
				if(ds.Tables[0].Rows[0]["user_password"]!=null && ds.Tables[0].Rows[0]["user_password"].ToString()!="")
				{
					model.user_password=ds.Tables[0].Rows[0]["user_password"].ToString();
				}
				if(ds.Tables[0].Rows[0]["user_createtime"]!=null && ds.Tables[0].Rows[0]["user_createtime"].ToString()!="")
				{
					model.user_createtime=DateTime.Parse(ds.Tables[0].Rows[0]["user_createtime"].ToString());
				}
				if(ds.Tables[0].Rows[0]["user_ip"]!=null && ds.Tables[0].Rows[0]["user_ip"].ToString()!="")
				{
					model.user_ip=ds.Tables[0].Rows[0]["user_ip"].ToString();
				}
				if(ds.Tables[0].Rows[0]["user_logintime"]!=null && ds.Tables[0].Rows[0]["user_logintime"].ToString()!="")
				{
					model.user_logintime=DateTime.Parse(ds.Tables[0].Rows[0]["user_logintime"].ToString());
				}
				if(ds.Tables[0].Rows[0]["user_role"]!=null && ds.Tables[0].Rows[0]["user_role"].ToString()!="")
				{
					model.user_role=int.Parse(ds.Tables[0].Rows[0]["user_role"].ToString());
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
			strSql.Append("select user_id,user_name,user_password,user_createtime,user_ip,user_logintime,user_role ");
			strSql.Append(" FROM hnf_adminuser ");
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
            strSql.Append(" user_id,user_name,user_password,user_createtime,user_ip,user_logintime,user_role ");
            strSql.Append(" FROM hnf_adminuser ");
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
			strSql.Append(" user_id,user_name,user_password,user_createtime,user_ip,user_logintime,user_role ");
			strSql.Append(" FROM hnf_adminuser ");
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
			strSql.Append("select count(1) FROM hnf_adminuser ");
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
				strSql.Append("order by T.user_id desc");
			}
			strSql.Append(")AS Row, T.*  from hnf_adminuser T ");
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
			parameters[0].Value = "hnf_adminuser";
			parameters[1].Value = "user_id";
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

