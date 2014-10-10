using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace NewsSolution.DAL
{
	/// <summary>
	/// 数据访问类:hnf_guanggao
	/// </summary>
	public partial class hnf_guanggao
	{
		public hnf_guanggao()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("guanggao_id", "hnf_guanggao"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int guanggao_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from hnf_guanggao");
			strSql.Append(" where guanggao_id=@guanggao_id");
			SqlParameter[] parameters = {
					new SqlParameter("@guanggao_id", SqlDbType.Int,4)
			};
			parameters[0].Value = guanggao_id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(NewsSolution.Model.hnf_guanggao model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into hnf_guanggao(");
			strSql.Append("guanggao_position,guanggao_image,guanggao_site,guanggao_type)");
			strSql.Append(" values (");
			strSql.Append("@guanggao_position,@guanggao_image,@guanggao_site,@guanggao_type)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@guanggao_position", SqlDbType.NVarChar,50),
					new SqlParameter("@guanggao_image", SqlDbType.NVarChar,50),
					new SqlParameter("@guanggao_site", SqlDbType.NVarChar,50),
					new SqlParameter("@guanggao_type", SqlDbType.Int,4)};
			parameters[0].Value = model.guanggao_position;
			parameters[1].Value = model.guanggao_image;
			parameters[2].Value = model.guanggao_site;
			parameters[3].Value = model.guanggao_type;

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
		public bool Update(NewsSolution.Model.hnf_guanggao model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update hnf_guanggao set ");
			strSql.Append("guanggao_position=@guanggao_position,");
			strSql.Append("guanggao_image=@guanggao_image,");
			strSql.Append("guanggao_site=@guanggao_site,");
			strSql.Append("guanggao_type=@guanggao_type");
			strSql.Append(" where guanggao_id=@guanggao_id");
			SqlParameter[] parameters = {
					new SqlParameter("@guanggao_position", SqlDbType.NVarChar,50),
					new SqlParameter("@guanggao_image", SqlDbType.NVarChar,50),
					new SqlParameter("@guanggao_site", SqlDbType.NVarChar,50),
					new SqlParameter("@guanggao_type", SqlDbType.Int,4),
					new SqlParameter("@guanggao_id", SqlDbType.Int,4)};
			parameters[0].Value = model.guanggao_position;
			parameters[1].Value = model.guanggao_image;
			parameters[2].Value = model.guanggao_site;
			parameters[3].Value = model.guanggao_type;
			parameters[4].Value = model.guanggao_id;

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
		public bool Delete(int guanggao_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from hnf_guanggao ");
			strSql.Append(" where guanggao_id=@guanggao_id");
			SqlParameter[] parameters = {
					new SqlParameter("@guanggao_id", SqlDbType.Int,4)
			};
			parameters[0].Value = guanggao_id;

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
		public bool DeleteList(string guanggao_idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from hnf_guanggao ");
			strSql.Append(" where guanggao_id in ("+guanggao_idlist + ")  ");
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
		public NewsSolution.Model.hnf_guanggao GetModel(int guanggao_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 guanggao_id,guanggao_position,guanggao_image,guanggao_site,guanggao_type from hnf_guanggao ");
			strSql.Append(" where guanggao_id=@guanggao_id");
			SqlParameter[] parameters = {
					new SqlParameter("@guanggao_id", SqlDbType.Int,4)
			};
			parameters[0].Value = guanggao_id;

			NewsSolution.Model.hnf_guanggao model=new NewsSolution.Model.hnf_guanggao();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["guanggao_id"]!=null && ds.Tables[0].Rows[0]["guanggao_id"].ToString()!="")
				{
					model.guanggao_id=int.Parse(ds.Tables[0].Rows[0]["guanggao_id"].ToString());
				}
				if(ds.Tables[0].Rows[0]["guanggao_position"]!=null && ds.Tables[0].Rows[0]["guanggao_position"].ToString()!="")
				{
					model.guanggao_position=ds.Tables[0].Rows[0]["guanggao_position"].ToString();
				}
				if(ds.Tables[0].Rows[0]["guanggao_image"]!=null && ds.Tables[0].Rows[0]["guanggao_image"].ToString()!="")
				{
					model.guanggao_image=ds.Tables[0].Rows[0]["guanggao_image"].ToString();
				}
				if(ds.Tables[0].Rows[0]["guanggao_site"]!=null && ds.Tables[0].Rows[0]["guanggao_site"].ToString()!="")
				{
					model.guanggao_site=ds.Tables[0].Rows[0]["guanggao_site"].ToString();
				}
				if(ds.Tables[0].Rows[0]["guanggao_type"]!=null && ds.Tables[0].Rows[0]["guanggao_type"].ToString()!="")
				{
					model.guanggao_type=int.Parse(ds.Tables[0].Rows[0]["guanggao_type"].ToString());
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
			strSql.Append("select guanggao_id,guanggao_position,guanggao_image,guanggao_site,guanggao_type ");
			strSql.Append(" FROM hnf_guanggao ");
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
            strSql.Append(" guanggao_id,guanggao_position,guanggao_image,guanggao_site,guanggao_type ");
            strSql.Append(" FROM hnf_guanggao ");
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
			strSql.Append(" guanggao_id,guanggao_position,guanggao_image,guanggao_site,guanggao_type ");
			strSql.Append(" FROM hnf_guanggao ");
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
			strSql.Append("select count(1) FROM hnf_guanggao ");
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
				strSql.Append("order by T.guanggao_id desc");
			}
			strSql.Append(")AS Row, T.*  from hnf_guanggao T ");
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
			parameters[0].Value = "hnf_guanggao";
			parameters[1].Value = "guanggao_id";
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

