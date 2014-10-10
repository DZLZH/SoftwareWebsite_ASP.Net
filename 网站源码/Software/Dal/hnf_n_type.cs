using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace NewsSolution.DAL
{
	/// <summary>
	/// 数据访问类:hnf_n_type
	/// </summary>
	public partial class hnf_n_type
	{
		public hnf_n_type()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("n_type_id", "hnf_n_type"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int n_type_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from hnf_n_type");
			strSql.Append(" where n_type_id=@n_type_id");
			SqlParameter[] parameters = {
					new SqlParameter("@n_type_id", SqlDbType.Int,4)
			};
			parameters[0].Value = n_type_id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(NewsSolution.Model.hnf_n_type model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into hnf_n_type(");
			strSql.Append("n_type_name,n_type_parentid,n_type_strsort,n_type_depth,n_type_root,n_type_sort,n_type_isshow)");
			strSql.Append(" values (");
			strSql.Append("@n_type_name,@n_type_parentid,@n_type_strsort,@n_type_depth,@n_type_root,@n_type_sort,@n_type_isshow)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@n_type_name", SqlDbType.NVarChar,255),
					new SqlParameter("@n_type_parentid", SqlDbType.Int,4),
					new SqlParameter("@n_type_strsort", SqlDbType.NVarChar,50),
					new SqlParameter("@n_type_depth", SqlDbType.Int,4),
					new SqlParameter("@n_type_root", SqlDbType.Int,4),
					new SqlParameter("@n_type_sort", SqlDbType.Int,4),
					new SqlParameter("@n_type_isshow", SqlDbType.Int,4)};
			parameters[0].Value = model.n_type_name;
			parameters[1].Value = model.n_type_parentid;
			parameters[2].Value = model.n_type_strsort;
			parameters[3].Value = model.n_type_depth;
			parameters[4].Value = model.n_type_root;
			parameters[5].Value = model.n_type_sort;
			parameters[6].Value = model.n_type_isshow;

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
		public bool Update(NewsSolution.Model.hnf_n_type model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update hnf_n_type set ");
			strSql.Append("n_type_name=@n_type_name,");
			strSql.Append("n_type_parentid=@n_type_parentid,");
			strSql.Append("n_type_strsort=@n_type_strsort,");
			strSql.Append("n_type_depth=@n_type_depth,");
			strSql.Append("n_type_root=@n_type_root,");
			strSql.Append("n_type_sort=@n_type_sort,");
			strSql.Append("n_type_isshow=@n_type_isshow");
			strSql.Append(" where n_type_id=@n_type_id");
			SqlParameter[] parameters = {
					new SqlParameter("@n_type_name", SqlDbType.NVarChar,255),
					new SqlParameter("@n_type_parentid", SqlDbType.Int,4),
					new SqlParameter("@n_type_strsort", SqlDbType.NVarChar,50),
					new SqlParameter("@n_type_depth", SqlDbType.Int,4),
					new SqlParameter("@n_type_root", SqlDbType.Int,4),
					new SqlParameter("@n_type_sort", SqlDbType.Int,4),
					new SqlParameter("@n_type_isshow", SqlDbType.Int,4),
					new SqlParameter("@n_type_id", SqlDbType.Int,4)};
			parameters[0].Value = model.n_type_name;
			parameters[1].Value = model.n_type_parentid;
			parameters[2].Value = model.n_type_strsort;
			parameters[3].Value = model.n_type_depth;
			parameters[4].Value = model.n_type_root;
			parameters[5].Value = model.n_type_sort;
			parameters[6].Value = model.n_type_isshow;
			parameters[7].Value = model.n_type_id;

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
		public bool Delete(int n_type_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from hnf_n_type ");
			strSql.Append(" where n_type_id=@n_type_id");
			SqlParameter[] parameters = {
					new SqlParameter("@n_type_id", SqlDbType.Int,4)
			};
			parameters[0].Value = n_type_id;

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
		public bool DeleteList(string n_type_idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from hnf_n_type ");
			strSql.Append(" where n_type_id in ("+n_type_idlist + ")  ");
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
		public NewsSolution.Model.hnf_n_type GetModel(int n_type_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 n_type_id,n_type_name,n_type_parentid,n_type_strsort,n_type_depth,n_type_root,n_type_sort,n_type_isshow from hnf_n_type ");
			strSql.Append(" where n_type_id=@n_type_id");
			SqlParameter[] parameters = {
					new SqlParameter("@n_type_id", SqlDbType.Int,4)
			};
			parameters[0].Value = n_type_id;

			NewsSolution.Model.hnf_n_type model=new NewsSolution.Model.hnf_n_type();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["n_type_id"]!=null && ds.Tables[0].Rows[0]["n_type_id"].ToString()!="")
				{
					model.n_type_id=int.Parse(ds.Tables[0].Rows[0]["n_type_id"].ToString());
				}
				if(ds.Tables[0].Rows[0]["n_type_name"]!=null && ds.Tables[0].Rows[0]["n_type_name"].ToString()!="")
				{
					model.n_type_name=ds.Tables[0].Rows[0]["n_type_name"].ToString();
				}
				if(ds.Tables[0].Rows[0]["n_type_parentid"]!=null && ds.Tables[0].Rows[0]["n_type_parentid"].ToString()!="")
				{
					model.n_type_parentid=int.Parse(ds.Tables[0].Rows[0]["n_type_parentid"].ToString());
				}
				if(ds.Tables[0].Rows[0]["n_type_strsort"]!=null && ds.Tables[0].Rows[0]["n_type_strsort"].ToString()!="")
				{
					model.n_type_strsort=ds.Tables[0].Rows[0]["n_type_strsort"].ToString();
				}
				if(ds.Tables[0].Rows[0]["n_type_depth"]!=null && ds.Tables[0].Rows[0]["n_type_depth"].ToString()!="")
				{
					model.n_type_depth=int.Parse(ds.Tables[0].Rows[0]["n_type_depth"].ToString());
				}
				if(ds.Tables[0].Rows[0]["n_type_root"]!=null && ds.Tables[0].Rows[0]["n_type_root"].ToString()!="")
				{
					model.n_type_root=int.Parse(ds.Tables[0].Rows[0]["n_type_root"].ToString());
				}
				if(ds.Tables[0].Rows[0]["n_type_sort"]!=null && ds.Tables[0].Rows[0]["n_type_sort"].ToString()!="")
				{
					model.n_type_sort=int.Parse(ds.Tables[0].Rows[0]["n_type_sort"].ToString());
				}
				if(ds.Tables[0].Rows[0]["n_type_isshow"]!=null && ds.Tables[0].Rows[0]["n_type_isshow"].ToString()!="")
				{
					model.n_type_isshow=int.Parse(ds.Tables[0].Rows[0]["n_type_isshow"].ToString());
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
			strSql.Append("select n_type_id,n_type_name,n_type_parentid,n_type_strsort,n_type_depth,n_type_root,n_type_sort,n_type_isshow ");
			strSql.Append(" FROM hnf_n_type ");
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
            strSql.Append(" n_type_id,n_type_name,n_type_parentid,n_type_strsort,n_type_depth,n_type_root,n_type_sort,n_type_isshow ");
            strSql.Append(" FROM hnf_n_type ");
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
			strSql.Append(" n_type_id,n_type_name,n_type_parentid,n_type_strsort,n_type_depth,n_type_root,n_type_sort,n_type_isshow ");
			strSql.Append(" FROM hnf_n_type ");
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
			strSql.Append("select count(1) FROM hnf_n_type ");
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
				strSql.Append("order by T.n_type_id desc");
			}
			strSql.Append(")AS Row, T.*  from hnf_n_type T ");
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
			parameters[0].Value = "hnf_n_type";
			parameters[1].Value = "n_type_id";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

        //只可添加一级类

        public bool addfirsttype(int parentid)
        {
            bool flag;
            DataSet ds = new DataSet();
            ds = DbHelperSQL.Query("select n_type_depth from hnf_n_type where n_type_id=" + parentid);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (Convert.ToInt32(ds.Tables[0].Rows[0]["n_type_depth"].ToString()) == 0)
                {
                    flag = false;
                }
                else
                {
                    flag = true;
                }
            }
            else
            {
                flag = true;
            }
            return flag;
        }

        //只可添加二级类

        public bool addsecondtype(int parentid)
        {
            bool flag;
            DataSet ds = new DataSet();
            ds = DbHelperSQL.Query("select n_type_depth from hnf_n_type where n_type_id=" + parentid);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (Convert.ToInt32(ds.Tables[0].Rows[0]["n_type_depth"].ToString()) == 1)
                {
                    flag = false;
                }
                else
                {
                    flag = true;
                }
            }
            else
            {
                flag = true;
            }
            return flag;
        }
        public bool UpdOrder(int id, int order)
        {
            try
            {
                DbHelperSQL.ExecuteSql("update hnf_n_type set n_type_sort=" + order + " where n_type_id=" + id);
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

