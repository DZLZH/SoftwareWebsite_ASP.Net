using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace NewsSolution.DAL
{
	/// <summary>
	/// 数据访问类:hnf_huandeng
	/// </summary>
	public partial class hnf_huandeng
	{
		public hnf_huandeng()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("huan_id", "hnf_huandeng"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int huan_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from hnf_huandeng");
			strSql.Append(" where huan_id=@huan_id");
			SqlParameter[] parameters = {
					new SqlParameter("@huan_id", SqlDbType.Int,4)
			};
			parameters[0].Value = huan_id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(NewsSolution.Model.hnf_huandeng model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into hnf_huandeng(");
			strSql.Append("huan_title,huan_name,huan_image,huan_shenhe,huan_sort,huan_type)");
			strSql.Append(" values (");
			strSql.Append("@huan_title,@huan_name,@huan_image,@huan_shenhe,@huan_sort,@huan_type)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@huan_title", SqlDbType.NVarChar,50),
					new SqlParameter("@huan_name", SqlDbType.NVarChar,50),
					new SqlParameter("@huan_image", SqlDbType.NVarChar,50),
					new SqlParameter("@huan_shenhe", SqlDbType.Int,4),
					new SqlParameter("@huan_sort", SqlDbType.Int,4),
					new SqlParameter("@huan_type", SqlDbType.Int,4)};
			parameters[0].Value = model.huan_title;
			parameters[1].Value = model.huan_name;
			parameters[2].Value = model.huan_image;
			parameters[3].Value = model.huan_shenhe;
			parameters[4].Value = model.huan_sort;
			parameters[5].Value = model.huan_type;

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
		public bool Update(NewsSolution.Model.hnf_huandeng model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update hnf_huandeng set ");
			strSql.Append("huan_title=@huan_title,");
			strSql.Append("huan_name=@huan_name,");
			strSql.Append("huan_image=@huan_image,");
			strSql.Append("huan_shenhe=@huan_shenhe,");
			strSql.Append("huan_sort=@huan_sort,");
			strSql.Append("huan_type=@huan_type");
			strSql.Append(" where huan_id=@huan_id");
			SqlParameter[] parameters = {
					new SqlParameter("@huan_title", SqlDbType.NVarChar,50),
					new SqlParameter("@huan_name", SqlDbType.NVarChar,50),
					new SqlParameter("@huan_image", SqlDbType.NVarChar,50),
					new SqlParameter("@huan_shenhe", SqlDbType.Int,4),
					new SqlParameter("@huan_sort", SqlDbType.Int,4),
					new SqlParameter("@huan_type", SqlDbType.Int,4),
					new SqlParameter("@huan_id", SqlDbType.Int,4)};
			parameters[0].Value = model.huan_title;
			parameters[1].Value = model.huan_name;
			parameters[2].Value = model.huan_image;
			parameters[3].Value = model.huan_shenhe;
			parameters[4].Value = model.huan_sort;
			parameters[5].Value = model.huan_type;
			parameters[6].Value = model.huan_id;

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
		public bool Delete(int huan_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from hnf_huandeng ");
			strSql.Append(" where huan_id=@huan_id");
			SqlParameter[] parameters = {
					new SqlParameter("@huan_id", SqlDbType.Int,4)
			};
			parameters[0].Value = huan_id;

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
		public bool DeleteList(string huan_idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from hnf_huandeng ");
			strSql.Append(" where huan_id in ("+huan_idlist + ")  ");
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
		public NewsSolution.Model.hnf_huandeng GetModel(int huan_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 huan_id,huan_title,huan_name,huan_image,huan_shenhe,huan_sort,huan_type from hnf_huandeng ");
			strSql.Append(" where huan_id=@huan_id");
			SqlParameter[] parameters = {
					new SqlParameter("@huan_id", SqlDbType.Int,4)
			};
			parameters[0].Value = huan_id;

			NewsSolution.Model.hnf_huandeng model=new NewsSolution.Model.hnf_huandeng();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["huan_id"]!=null && ds.Tables[0].Rows[0]["huan_id"].ToString()!="")
				{
					model.huan_id=int.Parse(ds.Tables[0].Rows[0]["huan_id"].ToString());
				}
				if(ds.Tables[0].Rows[0]["huan_title"]!=null && ds.Tables[0].Rows[0]["huan_title"].ToString()!="")
				{
					model.huan_title=ds.Tables[0].Rows[0]["huan_title"].ToString();
				}
				if(ds.Tables[0].Rows[0]["huan_name"]!=null && ds.Tables[0].Rows[0]["huan_name"].ToString()!="")
				{
					model.huan_name=ds.Tables[0].Rows[0]["huan_name"].ToString();
				}
				if(ds.Tables[0].Rows[0]["huan_image"]!=null && ds.Tables[0].Rows[0]["huan_image"].ToString()!="")
				{
					model.huan_image=ds.Tables[0].Rows[0]["huan_image"].ToString();
				}
				if(ds.Tables[0].Rows[0]["huan_shenhe"]!=null && ds.Tables[0].Rows[0]["huan_shenhe"].ToString()!="")
				{
					model.huan_shenhe=int.Parse(ds.Tables[0].Rows[0]["huan_shenhe"].ToString());
				}
				if(ds.Tables[0].Rows[0]["huan_sort"]!=null && ds.Tables[0].Rows[0]["huan_sort"].ToString()!="")
				{
					model.huan_sort=int.Parse(ds.Tables[0].Rows[0]["huan_sort"].ToString());
				}
				if(ds.Tables[0].Rows[0]["huan_type"]!=null && ds.Tables[0].Rows[0]["huan_type"].ToString()!="")
				{
					model.huan_type=int.Parse(ds.Tables[0].Rows[0]["huan_type"].ToString());
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
			strSql.Append("select huan_id,huan_title,huan_name,huan_image,huan_shenhe,huan_sort,huan_type ");
			strSql.Append(" FROM hnf_huandeng ");
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
            strSql.Append(" huan_id,huan_title,huan_name,huan_image,huan_shenhe,huan_sort,huan_type ");
            strSql.Append(" FROM hnf_huandeng ");
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
			strSql.Append(" huan_id,huan_title,huan_name,huan_image,huan_shenhe,huan_sort,huan_type ");
			strSql.Append(" FROM hnf_huandeng ");
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
			strSql.Append("select count(1) FROM hnf_huandeng ");
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
				strSql.Append("order by T.huan_id desc");
			}
			strSql.Append(")AS Row, T.*  from hnf_huandeng T ");
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
			parameters[0].Value = "hnf_huandeng";
			parameters[1].Value = "huan_id";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/
        public bool UpdOrder(int id, int order)
        {
            try
            {
                DbHelperSQL.ExecuteSql("update hnf_huandeng set huan_sort=" + order + " where huan_id=" + id);
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

