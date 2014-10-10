using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace NewsSolution.DAL
{
	/// <summary>
	/// 数据访问类:hnf_filedown
	/// </summary>
	public partial class hnf_filedown
	{
		public hnf_filedown()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("down_id", "hnf_filedown"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int down_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from hnf_filedown");
			strSql.Append(" where down_id=@down_id");
			SqlParameter[] parameters = {
					new SqlParameter("@down_id", SqlDbType.Int,4)
			};
			parameters[0].Value = down_id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(NewsSolution.Model.hnf_filedown model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into hnf_filedown(");
			strSql.Append("down_seotitle,down_keyword,down_describ,down_name,file_name,file_url,file_content,down_shenhe,down_recommand,down_createtime,down_times)");
			strSql.Append(" values (");
			strSql.Append("@down_seotitle,@down_keyword,@down_describ,@down_name,@file_name,@file_url,@file_content,@down_shenhe,@down_recommand,@down_createtime,@down_times)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@down_seotitle", SqlDbType.NVarChar,50),
					new SqlParameter("@down_keyword", SqlDbType.NVarChar,100),
					new SqlParameter("@down_describ", SqlDbType.NVarChar,100),
					new SqlParameter("@down_name", SqlDbType.NVarChar,50),
					new SqlParameter("@file_name", SqlDbType.NVarChar,50),
					new SqlParameter("@file_url", SqlDbType.NVarChar,50),
					new SqlParameter("@file_content", SqlDbType.NText),
					new SqlParameter("@down_shenhe", SqlDbType.Int,4),
					new SqlParameter("@down_recommand", SqlDbType.Int,4),
					new SqlParameter("@down_createtime", SqlDbType.SmallDateTime),
					new SqlParameter("@down_times", SqlDbType.Int,4)};
			parameters[0].Value = model.down_seotitle;
			parameters[1].Value = model.down_keyword;
			parameters[2].Value = model.down_describ;
			parameters[3].Value = model.down_name;
			parameters[4].Value = model.file_name;
			parameters[5].Value = model.file_url;
			parameters[6].Value = model.file_content;
			parameters[7].Value = model.down_shenhe;
			parameters[8].Value = model.down_recommand;
			parameters[9].Value = model.down_createtime;
			parameters[10].Value = model.down_times;

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
		public bool Update(NewsSolution.Model.hnf_filedown model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update hnf_filedown set ");
			strSql.Append("down_seotitle=@down_seotitle,");
			strSql.Append("down_keyword=@down_keyword,");
			strSql.Append("down_describ=@down_describ,");
			strSql.Append("down_name=@down_name,");
			strSql.Append("file_name=@file_name,");
			strSql.Append("file_url=@file_url,");
			strSql.Append("file_content=@file_content,");
			strSql.Append("down_shenhe=@down_shenhe,");
			strSql.Append("down_recommand=@down_recommand,");
			strSql.Append("down_createtime=@down_createtime,");
			strSql.Append("down_times=@down_times");
			strSql.Append(" where down_id=@down_id");
			SqlParameter[] parameters = {
					new SqlParameter("@down_seotitle", SqlDbType.NVarChar,50),
					new SqlParameter("@down_keyword", SqlDbType.NVarChar,100),
					new SqlParameter("@down_describ", SqlDbType.NVarChar,100),
					new SqlParameter("@down_name", SqlDbType.NVarChar,50),
					new SqlParameter("@file_name", SqlDbType.NVarChar,50),
					new SqlParameter("@file_url", SqlDbType.NVarChar,50),
					new SqlParameter("@file_content", SqlDbType.NText),
					new SqlParameter("@down_shenhe", SqlDbType.Int,4),
					new SqlParameter("@down_recommand", SqlDbType.Int,4),
					new SqlParameter("@down_createtime", SqlDbType.SmallDateTime),
					new SqlParameter("@down_times", SqlDbType.Int,4),
					new SqlParameter("@down_id", SqlDbType.Int,4)};
			parameters[0].Value = model.down_seotitle;
			parameters[1].Value = model.down_keyword;
			parameters[2].Value = model.down_describ;
			parameters[3].Value = model.down_name;
			parameters[4].Value = model.file_name;
			parameters[5].Value = model.file_url;
			parameters[6].Value = model.file_content;
			parameters[7].Value = model.down_shenhe;
			parameters[8].Value = model.down_recommand;
			parameters[9].Value = model.down_createtime;
			parameters[10].Value = model.down_times;
			parameters[11].Value = model.down_id;

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
		public bool Delete(int down_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from hnf_filedown ");
			strSql.Append(" where down_id=@down_id");
			SqlParameter[] parameters = {
					new SqlParameter("@down_id", SqlDbType.Int,4)
			};
			parameters[0].Value = down_id;

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
		public bool DeleteList(string down_idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from hnf_filedown ");
			strSql.Append(" where down_id in ("+down_idlist + ")  ");
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
		public NewsSolution.Model.hnf_filedown GetModel(int down_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 down_id,down_seotitle,down_keyword,down_describ,down_name,file_name,file_url,file_content,down_shenhe,down_recommand,down_createtime,down_times from hnf_filedown ");
			strSql.Append(" where down_id=@down_id");
			SqlParameter[] parameters = {
					new SqlParameter("@down_id", SqlDbType.Int,4)
			};
			parameters[0].Value = down_id;

			NewsSolution.Model.hnf_filedown model=new NewsSolution.Model.hnf_filedown();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["down_id"]!=null && ds.Tables[0].Rows[0]["down_id"].ToString()!="")
				{
					model.down_id=int.Parse(ds.Tables[0].Rows[0]["down_id"].ToString());
				}
				if(ds.Tables[0].Rows[0]["down_seotitle"]!=null && ds.Tables[0].Rows[0]["down_seotitle"].ToString()!="")
				{
					model.down_seotitle=ds.Tables[0].Rows[0]["down_seotitle"].ToString();
				}
				if(ds.Tables[0].Rows[0]["down_keyword"]!=null && ds.Tables[0].Rows[0]["down_keyword"].ToString()!="")
				{
					model.down_keyword=ds.Tables[0].Rows[0]["down_keyword"].ToString();
				}
				if(ds.Tables[0].Rows[0]["down_describ"]!=null && ds.Tables[0].Rows[0]["down_describ"].ToString()!="")
				{
					model.down_describ=ds.Tables[0].Rows[0]["down_describ"].ToString();
				}
				if(ds.Tables[0].Rows[0]["down_name"]!=null && ds.Tables[0].Rows[0]["down_name"].ToString()!="")
				{
					model.down_name=ds.Tables[0].Rows[0]["down_name"].ToString();
				}
				if(ds.Tables[0].Rows[0]["file_name"]!=null && ds.Tables[0].Rows[0]["file_name"].ToString()!="")
				{
					model.file_name=ds.Tables[0].Rows[0]["file_name"].ToString();
				}
				if(ds.Tables[0].Rows[0]["file_url"]!=null && ds.Tables[0].Rows[0]["file_url"].ToString()!="")
				{
					model.file_url=ds.Tables[0].Rows[0]["file_url"].ToString();
				}
				if(ds.Tables[0].Rows[0]["file_content"]!=null && ds.Tables[0].Rows[0]["file_content"].ToString()!="")
				{
					model.file_content=ds.Tables[0].Rows[0]["file_content"].ToString();
				}
				if(ds.Tables[0].Rows[0]["down_shenhe"]!=null && ds.Tables[0].Rows[0]["down_shenhe"].ToString()!="")
				{
					model.down_shenhe=int.Parse(ds.Tables[0].Rows[0]["down_shenhe"].ToString());
				}
				if(ds.Tables[0].Rows[0]["down_recommand"]!=null && ds.Tables[0].Rows[0]["down_recommand"].ToString()!="")
				{
					model.down_recommand=int.Parse(ds.Tables[0].Rows[0]["down_recommand"].ToString());
				}
				if(ds.Tables[0].Rows[0]["down_createtime"]!=null && ds.Tables[0].Rows[0]["down_createtime"].ToString()!="")
				{
					model.down_createtime=DateTime.Parse(ds.Tables[0].Rows[0]["down_createtime"].ToString());
				}
				if(ds.Tables[0].Rows[0]["down_times"]!=null && ds.Tables[0].Rows[0]["down_times"].ToString()!="")
				{
					model.down_times=int.Parse(ds.Tables[0].Rows[0]["down_times"].ToString());
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
			strSql.Append("select down_id,down_seotitle,down_keyword,down_describ,down_name,file_name,file_url,file_content,down_shenhe,down_recommand,down_createtime,down_times ");
			strSql.Append(" FROM hnf_filedown ");
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
            strSql.Append(" down_id,down_seotitle,down_keyword,down_describ,down_name,file_name,file_url,file_content,down_shenhe,down_recommand,down_createtime,down_times ");
            strSql.Append(" FROM hnf_filedown ");
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
			strSql.Append(" down_id,down_seotitle,down_keyword,down_describ,down_name,file_name,file_url,file_content,down_shenhe,down_recommand,down_createtime,down_times ");
			strSql.Append(" FROM hnf_filedown ");
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
			strSql.Append("select count(1) FROM hnf_filedown ");
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
				strSql.Append("order by T.down_id desc");
			}
			strSql.Append(")AS Row, T.*  from hnf_filedown T ");
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
			parameters[0].Value = "hnf_filedown";
			parameters[1].Value = "down_id";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/
        public DataSet GetIdList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select down_id ");
            strSql.Append(" FROM hnf_filedown ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }
		#endregion  Method
	}
}

