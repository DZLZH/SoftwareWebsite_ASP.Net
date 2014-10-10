using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace NewsSolution.DAL
{
	/// <summary>
	/// 数据访问类:hnf_user
	/// </summary>
	public partial class hnf_user
	{
		public hnf_user()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("user_id", "hnf_user"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int user_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from hnf_user");
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
		public int Add(NewsSolution.Model.hnf_user model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into hnf_user(");
			strSql.Append("user_name,user_password,user_truename,user_question,user_answer,user_isable,user_addTime,user_email,user_type,u_flash,u_video,u_document,u_source,u_other)");
			strSql.Append(" values (");
			strSql.Append("@user_name,@user_password,@user_truename,@user_question,@user_answer,@user_isable,@user_addTime,@user_email,@user_type,@u_flash,@u_video,@u_document,@u_source,@u_other)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@user_name", SqlDbType.NVarChar,50),
					new SqlParameter("@user_password", SqlDbType.NVarChar,50),
					new SqlParameter("@user_truename", SqlDbType.NVarChar,50),
					new SqlParameter("@user_question", SqlDbType.NVarChar,50),
					new SqlParameter("@user_answer", SqlDbType.NVarChar,50),
					new SqlParameter("@user_isable", SqlDbType.Int,4),
					new SqlParameter("@user_addTime", SqlDbType.SmallDateTime),
					new SqlParameter("@user_email", SqlDbType.NVarChar,50),
					new SqlParameter("@user_type", SqlDbType.Int,4),
					new SqlParameter("@u_flash", SqlDbType.Int,4),
					new SqlParameter("@u_video", SqlDbType.Int,4),
					new SqlParameter("@u_document", SqlDbType.Int,4),
					new SqlParameter("@u_source", SqlDbType.Int,4),
					new SqlParameter("@u_other", SqlDbType.Int,4)};
			parameters[0].Value = model.user_name;
			parameters[1].Value = model.user_password;
			parameters[2].Value = model.user_truename;
			parameters[3].Value = model.user_question;
			parameters[4].Value = model.user_answer;
			parameters[5].Value = model.user_isable;
			parameters[6].Value = model.user_addTime;
			parameters[7].Value = model.user_email;
			parameters[8].Value = model.user_type;
			parameters[9].Value = model.u_flash;
			parameters[10].Value = model.u_video;
			parameters[11].Value = model.u_document;
			parameters[12].Value = model.u_source;
			parameters[13].Value = model.u_other;

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
		public bool Update(NewsSolution.Model.hnf_user model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update hnf_user set ");
			strSql.Append("user_name=@user_name,");
			strSql.Append("user_password=@user_password,");
			strSql.Append("user_truename=@user_truename,");
			strSql.Append("user_question=@user_question,");
			strSql.Append("user_answer=@user_answer,");
			strSql.Append("user_isable=@user_isable,");
			strSql.Append("user_addTime=@user_addTime,");
			strSql.Append("user_email=@user_email,");
			strSql.Append("user_type=@user_type,");
			strSql.Append("u_flash=@u_flash,");
			strSql.Append("u_video=@u_video,");
			strSql.Append("u_document=@u_document,");
			strSql.Append("u_source=@u_source,");
			strSql.Append("u_other=@u_other");
			strSql.Append(" where user_id=@user_id");
			SqlParameter[] parameters = {
					new SqlParameter("@user_name", SqlDbType.NVarChar,50),
					new SqlParameter("@user_password", SqlDbType.NVarChar,50),
					new SqlParameter("@user_truename", SqlDbType.NVarChar,50),
					new SqlParameter("@user_question", SqlDbType.NVarChar,50),
					new SqlParameter("@user_answer", SqlDbType.NVarChar,50),
					new SqlParameter("@user_isable", SqlDbType.Int,4),
					new SqlParameter("@user_addTime", SqlDbType.SmallDateTime),
					new SqlParameter("@user_email", SqlDbType.NVarChar,50),
					new SqlParameter("@user_type", SqlDbType.Int,4),
					new SqlParameter("@u_flash", SqlDbType.Int,4),
					new SqlParameter("@u_video", SqlDbType.Int,4),
					new SqlParameter("@u_document", SqlDbType.Int,4),
					new SqlParameter("@u_source", SqlDbType.Int,4),
					new SqlParameter("@u_other", SqlDbType.Int,4),
					new SqlParameter("@user_id", SqlDbType.Int,4)};
			parameters[0].Value = model.user_name;
			parameters[1].Value = model.user_password;
			parameters[2].Value = model.user_truename;
			parameters[3].Value = model.user_question;
			parameters[4].Value = model.user_answer;
			parameters[5].Value = model.user_isable;
			parameters[6].Value = model.user_addTime;
			parameters[7].Value = model.user_email;
			parameters[8].Value = model.user_type;
			parameters[9].Value = model.u_flash;
			parameters[10].Value = model.u_video;
			parameters[11].Value = model.u_document;
			parameters[12].Value = model.u_source;
			parameters[13].Value = model.u_other;
			parameters[14].Value = model.user_id;

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
			strSql.Append("delete from hnf_user ");
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
			strSql.Append("delete from hnf_user ");
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
		public NewsSolution.Model.hnf_user GetModel(int user_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 user_id,user_name,user_password,user_truename,user_question,user_answer,user_isable,user_addTime,user_email,user_type,u_flash,u_video,u_document,u_source,u_other from hnf_user ");
			strSql.Append(" where user_id=@user_id");
			SqlParameter[] parameters = {
					new SqlParameter("@user_id", SqlDbType.Int,4)
			};
			parameters[0].Value = user_id;

			NewsSolution.Model.hnf_user model=new NewsSolution.Model.hnf_user();
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
				if(ds.Tables[0].Rows[0]["user_truename"]!=null && ds.Tables[0].Rows[0]["user_truename"].ToString()!="")
				{
					model.user_truename=ds.Tables[0].Rows[0]["user_truename"].ToString();
				}
				if(ds.Tables[0].Rows[0]["user_question"]!=null && ds.Tables[0].Rows[0]["user_question"].ToString()!="")
				{
					model.user_question=ds.Tables[0].Rows[0]["user_question"].ToString();
				}
				if(ds.Tables[0].Rows[0]["user_answer"]!=null && ds.Tables[0].Rows[0]["user_answer"].ToString()!="")
				{
					model.user_answer=ds.Tables[0].Rows[0]["user_answer"].ToString();
				}
				if(ds.Tables[0].Rows[0]["user_isable"]!=null && ds.Tables[0].Rows[0]["user_isable"].ToString()!="")
				{
					model.user_isable=int.Parse(ds.Tables[0].Rows[0]["user_isable"].ToString());
				}
				if(ds.Tables[0].Rows[0]["user_addTime"]!=null && ds.Tables[0].Rows[0]["user_addTime"].ToString()!="")
				{
					model.user_addTime=DateTime.Parse(ds.Tables[0].Rows[0]["user_addTime"].ToString());
				}
				if(ds.Tables[0].Rows[0]["user_email"]!=null && ds.Tables[0].Rows[0]["user_email"].ToString()!="")
				{
					model.user_email=ds.Tables[0].Rows[0]["user_email"].ToString();
				}
				if(ds.Tables[0].Rows[0]["user_type"]!=null && ds.Tables[0].Rows[0]["user_type"].ToString()!="")
				{
					model.user_type=int.Parse(ds.Tables[0].Rows[0]["user_type"].ToString());
				}
				if(ds.Tables[0].Rows[0]["u_flash"]!=null && ds.Tables[0].Rows[0]["u_flash"].ToString()!="")
				{
					model.u_flash=int.Parse(ds.Tables[0].Rows[0]["u_flash"].ToString());
				}
				if(ds.Tables[0].Rows[0]["u_video"]!=null && ds.Tables[0].Rows[0]["u_video"].ToString()!="")
				{
					model.u_video=int.Parse(ds.Tables[0].Rows[0]["u_video"].ToString());
				}
				if(ds.Tables[0].Rows[0]["u_document"]!=null && ds.Tables[0].Rows[0]["u_document"].ToString()!="")
				{
					model.u_document=int.Parse(ds.Tables[0].Rows[0]["u_document"].ToString());
				}
				if(ds.Tables[0].Rows[0]["u_source"]!=null && ds.Tables[0].Rows[0]["u_source"].ToString()!="")
				{
					model.u_source=int.Parse(ds.Tables[0].Rows[0]["u_source"].ToString());
				}
				if(ds.Tables[0].Rows[0]["u_other"]!=null && ds.Tables[0].Rows[0]["u_other"].ToString()!="")
				{
					model.u_other=int.Parse(ds.Tables[0].Rows[0]["u_other"].ToString());
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
			strSql.Append("select user_id,user_name,user_password,user_truename,user_question,user_answer,user_isable,user_addTime,user_email,user_type,u_flash,u_video,u_document,u_source,u_other ");
			strSql.Append(" FROM hnf_user ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}
        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" user_id,user_name,user_password,user_truename,user_question,user_answer,user_isable,user_addTime,user_email,user_type,u_flash,u_video,u_document,u_source,u_other ");
            strSql.Append(" FROM hnf_user ");
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
			strSql.Append(" user_id,user_name,user_password,user_truename,user_question,user_answer,user_isable,user_addTime,user_email,user_type,u_flash,u_video,u_document,u_source,u_other ");
			strSql.Append(" FROM hnf_user ");
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
			strSql.Append("select count(1) FROM hnf_user ");
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
			strSql.Append(")AS Row, T.*  from hnf_user T ");
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
			parameters[0].Value = "hnf_user";
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

