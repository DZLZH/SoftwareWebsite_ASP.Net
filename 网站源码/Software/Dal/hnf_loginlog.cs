using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace NewsSolution.DAL
{
	/// <summary>
	/// 数据访问类:hnf_loginlog
	/// </summary>
	public partial class hnf_loginlog
	{
		public hnf_loginlog()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("log_id", "hnf_loginlog"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int log_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from hnf_loginlog");
			strSql.Append(" where log_id=@log_id");
			SqlParameter[] parameters = {
					new SqlParameter("@log_id", SqlDbType.Int,4)
			};
			parameters[0].Value = log_id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(NewsSolution.Model.hnf_loginlog model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into hnf_loginlog(");
			strSql.Append("log_type,log_note,log_ip,log_time)");
			strSql.Append(" values (");
			strSql.Append("@log_type,@log_note,@log_ip,@log_time)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@log_type", SqlDbType.Int,4),
					new SqlParameter("@log_note", SqlDbType.NVarChar,200),
					new SqlParameter("@log_ip", SqlDbType.NVarChar,50),
					new SqlParameter("@log_time", SqlDbType.SmallDateTime)};
			parameters[0].Value = model.log_type;
			parameters[1].Value = model.log_note;
			parameters[2].Value = model.log_ip;
			parameters[3].Value = model.log_time;

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
		public bool Update(NewsSolution.Model.hnf_loginlog model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update hnf_loginlog set ");
			strSql.Append("log_type=@log_type,");
			strSql.Append("log_note=@log_note,");
			strSql.Append("log_ip=@log_ip,");
			strSql.Append("log_time=@log_time");
			strSql.Append(" where log_id=@log_id");
			SqlParameter[] parameters = {
					new SqlParameter("@log_type", SqlDbType.Int,4),
					new SqlParameter("@log_note", SqlDbType.NVarChar,200),
					new SqlParameter("@log_ip", SqlDbType.NVarChar,50),
					new SqlParameter("@log_time", SqlDbType.SmallDateTime),
					new SqlParameter("@log_id", SqlDbType.Int,4)};
			parameters[0].Value = model.log_type;
			parameters[1].Value = model.log_note;
			parameters[2].Value = model.log_ip;
			parameters[3].Value = model.log_time;
			parameters[4].Value = model.log_id;

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
		public bool Delete(int log_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from hnf_loginlog ");
			strSql.Append(" where log_id=@log_id");
			SqlParameter[] parameters = {
					new SqlParameter("@log_id", SqlDbType.Int,4)
			};
			parameters[0].Value = log_id;

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
		public bool DeleteList(string log_idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from hnf_loginlog ");
			strSql.Append(" where log_id in ("+log_idlist + ")  ");
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
		public NewsSolution.Model.hnf_loginlog GetModel(int log_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 log_id,log_type,log_note,log_ip,log_time from hnf_loginlog ");
			strSql.Append(" where log_id=@log_id");
			SqlParameter[] parameters = {
					new SqlParameter("@log_id", SqlDbType.Int,4)
			};
			parameters[0].Value = log_id;

			NewsSolution.Model.hnf_loginlog model=new NewsSolution.Model.hnf_loginlog();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["log_id"]!=null && ds.Tables[0].Rows[0]["log_id"].ToString()!="")
				{
					model.log_id=int.Parse(ds.Tables[0].Rows[0]["log_id"].ToString());
				}
				if(ds.Tables[0].Rows[0]["log_type"]!=null && ds.Tables[0].Rows[0]["log_type"].ToString()!="")
				{
					model.log_type=int.Parse(ds.Tables[0].Rows[0]["log_type"].ToString());
				}
				if(ds.Tables[0].Rows[0]["log_note"]!=null && ds.Tables[0].Rows[0]["log_note"].ToString()!="")
				{
					model.log_note=ds.Tables[0].Rows[0]["log_note"].ToString();
				}
				if(ds.Tables[0].Rows[0]["log_ip"]!=null && ds.Tables[0].Rows[0]["log_ip"].ToString()!="")
				{
					model.log_ip=ds.Tables[0].Rows[0]["log_ip"].ToString();
				}
				if(ds.Tables[0].Rows[0]["log_time"]!=null && ds.Tables[0].Rows[0]["log_time"].ToString()!="")
				{
					model.log_time=DateTime.Parse(ds.Tables[0].Rows[0]["log_time"].ToString());
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
			strSql.Append("select log_id,log_type,log_note,log_ip,log_time ");
			strSql.Append(" FROM hnf_loginlog ");
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
            strSql.Append(" log_id,log_type,log_note,log_ip,log_time ");
            strSql.Append(" FROM hnf_loginlog ");
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
			strSql.Append(" log_id,log_type,log_note,log_ip,log_time ");
			strSql.Append(" FROM hnf_loginlog ");
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
			strSql.Append("select count(1) FROM hnf_loginlog ");
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
				strSql.Append("order by T.log_id desc");
			}
			strSql.Append(")AS Row, T.*  from hnf_loginlog T ");
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
			parameters[0].Value = "hnf_loginlog";
			parameters[1].Value = "log_id";
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

