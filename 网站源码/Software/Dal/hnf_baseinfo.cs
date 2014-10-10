using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace NewsSolution.DAL
{
	/// <summary>
	/// 数据访问类:hnf_baseinfo
	/// </summary>
	public partial class hnf_baseinfo
	{
		public hnf_baseinfo()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("base_id", "hnf_baseinfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int base_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from hnf_baseinfo");
			strSql.Append(" where base_id=@base_id");
			SqlParameter[] parameters = {
					new SqlParameter("@base_id", SqlDbType.Int,4)
			};
			parameters[0].Value = base_id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(NewsSolution.Model.hnf_baseinfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into hnf_baseinfo(");
			strSql.Append("base_dianhua,base_mobile,base_qq,base_email,base_lianxiren,base_address,base_seotitle,base_keyword,base_describ,base_beianhao,base_content)");
			strSql.Append(" values (");
			strSql.Append("@base_dianhua,@base_mobile,@base_qq,@base_email,@base_lianxiren,@base_address,@base_seotitle,@base_keyword,@base_describ,@base_beianhao,@base_content)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@base_dianhua", SqlDbType.NVarChar,20),
					new SqlParameter("@base_mobile", SqlDbType.NVarChar,20),
					new SqlParameter("@base_qq", SqlDbType.NVarChar,20),
					new SqlParameter("@base_email", SqlDbType.NVarChar,20),
					new SqlParameter("@base_lianxiren", SqlDbType.NVarChar,50),
					new SqlParameter("@base_address", SqlDbType.NVarChar,100),
					new SqlParameter("@base_seotitle", SqlDbType.NVarChar,50),
					new SqlParameter("@base_keyword", SqlDbType.NVarChar,100),
					new SqlParameter("@base_describ", SqlDbType.NVarChar,100),
					new SqlParameter("@base_beianhao", SqlDbType.NVarChar,50),
					new SqlParameter("@base_content", SqlDbType.NText)};
			parameters[0].Value = model.base_dianhua;
			parameters[1].Value = model.base_mobile;
			parameters[2].Value = model.base_qq;
			parameters[3].Value = model.base_email;
			parameters[4].Value = model.base_lianxiren;
			parameters[5].Value = model.base_address;
			parameters[6].Value = model.base_seotitle;
			parameters[7].Value = model.base_keyword;
			parameters[8].Value = model.base_describ;
			parameters[9].Value = model.base_beianhao;
			parameters[10].Value = model.base_content;

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
		public bool Update(NewsSolution.Model.hnf_baseinfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update hnf_baseinfo set ");
			strSql.Append("base_dianhua=@base_dianhua,");
			strSql.Append("base_mobile=@base_mobile,");
			strSql.Append("base_qq=@base_qq,");
			strSql.Append("base_email=@base_email,");
			strSql.Append("base_lianxiren=@base_lianxiren,");
			strSql.Append("base_address=@base_address,");
			strSql.Append("base_seotitle=@base_seotitle,");
			strSql.Append("base_keyword=@base_keyword,");
			strSql.Append("base_describ=@base_describ,");
			strSql.Append("base_beianhao=@base_beianhao,");
			strSql.Append("base_content=@base_content");
			strSql.Append(" where base_id=@base_id");
			SqlParameter[] parameters = {
					new SqlParameter("@base_dianhua", SqlDbType.NVarChar,20),
					new SqlParameter("@base_mobile", SqlDbType.NVarChar,20),
					new SqlParameter("@base_qq", SqlDbType.NVarChar,20),
					new SqlParameter("@base_email", SqlDbType.NVarChar,20),
					new SqlParameter("@base_lianxiren", SqlDbType.NVarChar,50),
					new SqlParameter("@base_address", SqlDbType.NVarChar,100),
					new SqlParameter("@base_seotitle", SqlDbType.NVarChar,50),
					new SqlParameter("@base_keyword", SqlDbType.NVarChar,100),
					new SqlParameter("@base_describ", SqlDbType.NVarChar,100),
					new SqlParameter("@base_beianhao", SqlDbType.NVarChar,50),
					new SqlParameter("@base_content", SqlDbType.NText),
					new SqlParameter("@base_id", SqlDbType.Int,4)};
			parameters[0].Value = model.base_dianhua;
			parameters[1].Value = model.base_mobile;
			parameters[2].Value = model.base_qq;
			parameters[3].Value = model.base_email;
			parameters[4].Value = model.base_lianxiren;
			parameters[5].Value = model.base_address;
			parameters[6].Value = model.base_seotitle;
			parameters[7].Value = model.base_keyword;
			parameters[8].Value = model.base_describ;
			parameters[9].Value = model.base_beianhao;
			parameters[10].Value = model.base_content;
			parameters[11].Value = model.base_id;

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
		public bool Delete(int base_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from hnf_baseinfo ");
			strSql.Append(" where base_id=@base_id");
			SqlParameter[] parameters = {
					new SqlParameter("@base_id", SqlDbType.Int,4)
			};
			parameters[0].Value = base_id;

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
		public bool DeleteList(string base_idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from hnf_baseinfo ");
			strSql.Append(" where base_id in ("+base_idlist + ")  ");
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
		public NewsSolution.Model.hnf_baseinfo GetModel(int base_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 base_id,base_dianhua,base_mobile,base_qq,base_email,base_lianxiren,base_address,base_seotitle,base_keyword,base_describ,base_beianhao,base_content from hnf_baseinfo ");
			strSql.Append(" where base_id=@base_id");
			SqlParameter[] parameters = {
					new SqlParameter("@base_id", SqlDbType.Int,4)
			};
			parameters[0].Value = base_id;

			NewsSolution.Model.hnf_baseinfo model=new NewsSolution.Model.hnf_baseinfo();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["base_id"]!=null && ds.Tables[0].Rows[0]["base_id"].ToString()!="")
				{
					model.base_id=int.Parse(ds.Tables[0].Rows[0]["base_id"].ToString());
				}
				if(ds.Tables[0].Rows[0]["base_dianhua"]!=null && ds.Tables[0].Rows[0]["base_dianhua"].ToString()!="")
				{
					model.base_dianhua=ds.Tables[0].Rows[0]["base_dianhua"].ToString();
				}
				if(ds.Tables[0].Rows[0]["base_mobile"]!=null && ds.Tables[0].Rows[0]["base_mobile"].ToString()!="")
				{
					model.base_mobile=ds.Tables[0].Rows[0]["base_mobile"].ToString();
				}
				if(ds.Tables[0].Rows[0]["base_qq"]!=null && ds.Tables[0].Rows[0]["base_qq"].ToString()!="")
				{
					model.base_qq=ds.Tables[0].Rows[0]["base_qq"].ToString();
				}
				if(ds.Tables[0].Rows[0]["base_email"]!=null && ds.Tables[0].Rows[0]["base_email"].ToString()!="")
				{
					model.base_email=ds.Tables[0].Rows[0]["base_email"].ToString();
				}
				if(ds.Tables[0].Rows[0]["base_lianxiren"]!=null && ds.Tables[0].Rows[0]["base_lianxiren"].ToString()!="")
				{
					model.base_lianxiren=ds.Tables[0].Rows[0]["base_lianxiren"].ToString();
				}
				if(ds.Tables[0].Rows[0]["base_address"]!=null && ds.Tables[0].Rows[0]["base_address"].ToString()!="")
				{
					model.base_address=ds.Tables[0].Rows[0]["base_address"].ToString();
				}
				if(ds.Tables[0].Rows[0]["base_seotitle"]!=null && ds.Tables[0].Rows[0]["base_seotitle"].ToString()!="")
				{
					model.base_seotitle=ds.Tables[0].Rows[0]["base_seotitle"].ToString();
				}
				if(ds.Tables[0].Rows[0]["base_keyword"]!=null && ds.Tables[0].Rows[0]["base_keyword"].ToString()!="")
				{
					model.base_keyword=ds.Tables[0].Rows[0]["base_keyword"].ToString();
				}
				if(ds.Tables[0].Rows[0]["base_describ"]!=null && ds.Tables[0].Rows[0]["base_describ"].ToString()!="")
				{
					model.base_describ=ds.Tables[0].Rows[0]["base_describ"].ToString();
				}
				if(ds.Tables[0].Rows[0]["base_beianhao"]!=null && ds.Tables[0].Rows[0]["base_beianhao"].ToString()!="")
				{
					model.base_beianhao=ds.Tables[0].Rows[0]["base_beianhao"].ToString();
				}
				if(ds.Tables[0].Rows[0]["base_content"]!=null && ds.Tables[0].Rows[0]["base_content"].ToString()!="")
				{
					model.base_content=ds.Tables[0].Rows[0]["base_content"].ToString();
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
			strSql.Append("select base_id,base_dianhua,base_mobile,base_qq,base_email,base_lianxiren,base_address,base_seotitle,base_keyword,base_describ,base_beianhao,base_content ");
			strSql.Append(" FROM hnf_baseinfo ");
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
            strSql.Append(" base_id,base_dianhua,base_mobile,base_qq,base_email,base_lianxiren,base_address,base_seotitle,base_keyword,base_describ,base_beianhao,base_content ");
            strSql.Append(" FROM hnf_baseinfo ");
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
			strSql.Append(" base_id,base_dianhua,base_mobile,base_qq,base_email,base_lianxiren,base_address,base_seotitle,base_keyword,base_describ,base_beianhao,base_content ");
			strSql.Append(" FROM hnf_baseinfo ");
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
			strSql.Append("select count(1) FROM hnf_baseinfo ");
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
				strSql.Append("order by T.base_id desc");
			}
			strSql.Append(")AS Row, T.*  from hnf_baseinfo T ");
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
			parameters[0].Value = "hnf_baseinfo";
			parameters[1].Value = "base_id";
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

