using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace NewsSolution.DAL
{
	/// <summary>
	/// 数据访问类:hnf_news
	/// </summary>
	public partial class hnf_news
	{
		public hnf_news()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("news_id", "hnf_news"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int news_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from hnf_news");
			strSql.Append(" where news_id=@news_id");
			SqlParameter[] parameters = {
					new SqlParameter("@news_id", SqlDbType.Int,4)
			};
			parameters[0].Value = news_id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}

        /// <summary>
        /// 增加记录
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>

        public int Add1(NewsSolution.Model.hnf_news model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into hnf_news(");
            strSql.Append("news_seotitle,news_keyword,news_describ,news_name,news_content,news_createtime,news_alertime,news_comefrom,news_seetime,news_isshow,news_recommand,news_type,news_image,news_isimage,news_sort)");
            strSql.Append(" values (");
            strSql.Append("'" + model.news_seotitle + "','" + model.news_keyword + "','" + model.news_describ + "','" + model.news_name + "','" + model.news_content + "','" + model.news_createtime + "','" + model.news_alertime + "','" + model.news_comefrom + "'," + model.news_seetime.ToString() + "," + model.news_recommand.ToString() + "," + model.news_recommand.ToString() + "," + model.news_type.ToString() + ",'" + model.news_image + "'," + model.news_isimage.ToString() + "," + model.news_sort.ToString() + ")");

            int num = DbHelperSQL.ExecuteSql(strSql.ToString());

            if (num == 0)
            {
                return 0;
            }
            else
            {
                return num;
            }
        }
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(NewsSolution.Model.hnf_news model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into hnf_news(");
			strSql.Append("news_seotitle,news_keyword,news_describ,news_name,news_content,news_createtime,news_alertime,news_comefrom,news_seetime,news_isshow,news_recommand,news_type,news_image,news_isimage,news_sort,user_id)");
			strSql.Append(" values (");
			strSql.Append("@news_seotitle,@news_keyword,@news_describ,@news_name,@news_content,@news_createtime,@news_alertime,@news_comefrom,@news_seetime,@news_isshow,@news_recommand,@news_type,@news_image,@news_isimage,@news_sort,@user_id)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@news_seotitle", SqlDbType.NVarChar,50),
					new SqlParameter("@news_keyword", SqlDbType.NVarChar,100),
					new SqlParameter("@news_describ", SqlDbType.NVarChar,100),
					new SqlParameter("@news_name", SqlDbType.NVarChar,50),
					new SqlParameter("@news_content", SqlDbType.NText),
					new SqlParameter("@news_createtime", SqlDbType.SmallDateTime),
					new SqlParameter("@news_alertime", SqlDbType.SmallDateTime),
					new SqlParameter("@news_comefrom", SqlDbType.NVarChar,50),
					new SqlParameter("@news_seetime", SqlDbType.Int,4),
					new SqlParameter("@news_isshow", SqlDbType.Int,4),
					new SqlParameter("@news_recommand", SqlDbType.Int,4),
					new SqlParameter("@news_type", SqlDbType.Int,4),
					new SqlParameter("@news_image", SqlDbType.NVarChar,50),
					new SqlParameter("@news_isimage", SqlDbType.Int,4),
					new SqlParameter("@news_sort", SqlDbType.Int,4),
					new SqlParameter("@user_id", SqlDbType.Int,4)};
			parameters[0].Value = model.news_seotitle;
			parameters[1].Value = model.news_keyword;
			parameters[2].Value = model.news_describ;
			parameters[3].Value = model.news_name;
			parameters[4].Value = model.news_content;
			parameters[5].Value = model.news_createtime;
			parameters[6].Value = model.news_alertime;
			parameters[7].Value = model.news_comefrom;
			parameters[8].Value = model.news_seetime;
			parameters[9].Value = model.news_isshow;
			parameters[10].Value = model.news_recommand;
			parameters[11].Value = model.news_type;
			parameters[12].Value = model.news_image;
			parameters[13].Value = model.news_isimage;
			parameters[14].Value = model.news_sort;
			parameters[15].Value = model.user_id;

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
		public bool Update(NewsSolution.Model.hnf_news model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update hnf_news set ");
			strSql.Append("news_seotitle=@news_seotitle,");
			strSql.Append("news_keyword=@news_keyword,");
			strSql.Append("news_describ=@news_describ,");
			strSql.Append("news_name=@news_name,");
			strSql.Append("news_content=@news_content,");
			strSql.Append("news_createtime=@news_createtime,");
			strSql.Append("news_alertime=@news_alertime,");
			strSql.Append("news_comefrom=@news_comefrom,");
			strSql.Append("news_seetime=@news_seetime,");
			strSql.Append("news_isshow=@news_isshow,");
			strSql.Append("news_recommand=@news_recommand,");
			strSql.Append("news_type=@news_type,");
			strSql.Append("news_image=@news_image,");
			strSql.Append("news_isimage=@news_isimage,");
			strSql.Append("news_sort=@news_sort,");
			strSql.Append("user_id=@user_id");
			strSql.Append(" where news_id=@news_id");
			SqlParameter[] parameters = {
					new SqlParameter("@news_seotitle", SqlDbType.NVarChar,50),
					new SqlParameter("@news_keyword", SqlDbType.NVarChar,100),
					new SqlParameter("@news_describ", SqlDbType.NVarChar,100),
					new SqlParameter("@news_name", SqlDbType.NVarChar,50),
					new SqlParameter("@news_content", SqlDbType.NText),
					new SqlParameter("@news_createtime", SqlDbType.SmallDateTime),
					new SqlParameter("@news_alertime", SqlDbType.SmallDateTime),
					new SqlParameter("@news_comefrom", SqlDbType.NVarChar,50),
					new SqlParameter("@news_seetime", SqlDbType.Int,4),
					new SqlParameter("@news_isshow", SqlDbType.Int,4),
					new SqlParameter("@news_recommand", SqlDbType.Int,4),
					new SqlParameter("@news_type", SqlDbType.Int,4),
					new SqlParameter("@news_image", SqlDbType.NVarChar,50),
					new SqlParameter("@news_isimage", SqlDbType.Int,4),
					new SqlParameter("@news_sort", SqlDbType.Int,4),
					new SqlParameter("@user_id", SqlDbType.Int,4),
					new SqlParameter("@news_id", SqlDbType.Int,4)};
			parameters[0].Value = model.news_seotitle;
			parameters[1].Value = model.news_keyword;
			parameters[2].Value = model.news_describ;
			parameters[3].Value = model.news_name;
			parameters[4].Value = model.news_content;
			parameters[5].Value = model.news_createtime;
			parameters[6].Value = model.news_alertime;
			parameters[7].Value = model.news_comefrom;
			parameters[8].Value = model.news_seetime;
			parameters[9].Value = model.news_isshow;
			parameters[10].Value = model.news_recommand;
			parameters[11].Value = model.news_type;
			parameters[12].Value = model.news_image;
			parameters[13].Value = model.news_isimage;
			parameters[14].Value = model.news_sort;
			parameters[15].Value = model.user_id;
			parameters[16].Value = model.news_id;

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
		public bool Delete(int news_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from hnf_news ");
			strSql.Append(" where news_id=@news_id");
			SqlParameter[] parameters = {
					new SqlParameter("@news_id", SqlDbType.Int,4)
			};
			parameters[0].Value = news_id;

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
        public bool Delete(NewsSolution.Model.hnf_news model)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from hnf_news ");
            strSql.Append(" where news_id=@news_id");
            SqlParameter[] parameters = {
					new SqlParameter("@news_id", SqlDbType.Int,4)
             };
            parameters[0].Value = model.news_id;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
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
		public bool DeleteList(string news_idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from hnf_news ");
			strSql.Append(" where news_id in ("+news_idlist + ")  ");
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
		public NewsSolution.Model.hnf_news GetModel(int news_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 news_id,news_seotitle,news_keyword,news_describ,news_name,news_content,news_createtime,news_alertime,news_comefrom,news_seetime,news_isshow,news_recommand,news_type,news_image,news_isimage,news_sort,user_id from hnf_news ");
			strSql.Append(" where news_id=@news_id");
			SqlParameter[] parameters = {
					new SqlParameter("@news_id", SqlDbType.Int,4)
			};
			parameters[0].Value = news_id;

			NewsSolution.Model.hnf_news model=new NewsSolution.Model.hnf_news();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["news_id"]!=null && ds.Tables[0].Rows[0]["news_id"].ToString()!="")
				{
					model.news_id=int.Parse(ds.Tables[0].Rows[0]["news_id"].ToString());
				}
				if(ds.Tables[0].Rows[0]["news_seotitle"]!=null && ds.Tables[0].Rows[0]["news_seotitle"].ToString()!="")
				{
					model.news_seotitle=ds.Tables[0].Rows[0]["news_seotitle"].ToString();
				}
				if(ds.Tables[0].Rows[0]["news_keyword"]!=null && ds.Tables[0].Rows[0]["news_keyword"].ToString()!="")
				{
					model.news_keyword=ds.Tables[0].Rows[0]["news_keyword"].ToString();
				}
				if(ds.Tables[0].Rows[0]["news_describ"]!=null && ds.Tables[0].Rows[0]["news_describ"].ToString()!="")
				{
					model.news_describ=ds.Tables[0].Rows[0]["news_describ"].ToString();
				}
				if(ds.Tables[0].Rows[0]["news_name"]!=null && ds.Tables[0].Rows[0]["news_name"].ToString()!="")
				{
					model.news_name=ds.Tables[0].Rows[0]["news_name"].ToString();
				}
				if(ds.Tables[0].Rows[0]["news_content"]!=null && ds.Tables[0].Rows[0]["news_content"].ToString()!="")
				{
					model.news_content=ds.Tables[0].Rows[0]["news_content"].ToString();
				}
				if(ds.Tables[0].Rows[0]["news_createtime"]!=null && ds.Tables[0].Rows[0]["news_createtime"].ToString()!="")
				{
					model.news_createtime=DateTime.Parse(ds.Tables[0].Rows[0]["news_createtime"].ToString());
				}
				if(ds.Tables[0].Rows[0]["news_alertime"]!=null && ds.Tables[0].Rows[0]["news_alertime"].ToString()!="")
				{
					model.news_alertime=DateTime.Parse(ds.Tables[0].Rows[0]["news_alertime"].ToString());
				}
				if(ds.Tables[0].Rows[0]["news_comefrom"]!=null && ds.Tables[0].Rows[0]["news_comefrom"].ToString()!="")
				{
					model.news_comefrom=ds.Tables[0].Rows[0]["news_comefrom"].ToString();
				}
				if(ds.Tables[0].Rows[0]["news_seetime"]!=null && ds.Tables[0].Rows[0]["news_seetime"].ToString()!="")
				{
					model.news_seetime=int.Parse(ds.Tables[0].Rows[0]["news_seetime"].ToString());
				}
				if(ds.Tables[0].Rows[0]["news_isshow"]!=null && ds.Tables[0].Rows[0]["news_isshow"].ToString()!="")
				{
					model.news_isshow=int.Parse(ds.Tables[0].Rows[0]["news_isshow"].ToString());
				}
				if(ds.Tables[0].Rows[0]["news_recommand"]!=null && ds.Tables[0].Rows[0]["news_recommand"].ToString()!="")
				{
					model.news_recommand=int.Parse(ds.Tables[0].Rows[0]["news_recommand"].ToString());
				}
				if(ds.Tables[0].Rows[0]["news_type"]!=null && ds.Tables[0].Rows[0]["news_type"].ToString()!="")
				{
					model.news_type=int.Parse(ds.Tables[0].Rows[0]["news_type"].ToString());
				}
				if(ds.Tables[0].Rows[0]["news_image"]!=null && ds.Tables[0].Rows[0]["news_image"].ToString()!="")
				{
					model.news_image=ds.Tables[0].Rows[0]["news_image"].ToString();
				}
				if(ds.Tables[0].Rows[0]["news_isimage"]!=null && ds.Tables[0].Rows[0]["news_isimage"].ToString()!="")
				{
					model.news_isimage=int.Parse(ds.Tables[0].Rows[0]["news_isimage"].ToString());
				}
				if(ds.Tables[0].Rows[0]["news_sort"]!=null && ds.Tables[0].Rows[0]["news_sort"].ToString()!="")
				{
					model.news_sort=int.Parse(ds.Tables[0].Rows[0]["news_sort"].ToString());
				}
				if(ds.Tables[0].Rows[0]["user_id"]!=null && ds.Tables[0].Rows[0]["user_id"].ToString()!="")
				{
					model.user_id=int.Parse(ds.Tables[0].Rows[0]["user_id"].ToString());
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
			strSql.Append("select news_id,news_seotitle,news_keyword,news_describ,news_name,news_content,news_createtime,news_alertime,news_comefrom,news_seetime,news_isshow,news_recommand,news_type,news_image,news_isimage,news_sort,user_id ");
			strSql.Append(" FROM hnf_news ");
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
            strSql.Append(" news_id,news_seotitle,news_keyword,news_describ,news_name,news_content,news_createtime,news_alertime,news_comefrom,news_seetime,news_isshow,news_recommand,news_type,news_image,news_isimage,news_sort,user_id ");
            strSql.Append(" FROM hnf_news ");
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
			strSql.Append(" news_id,news_seotitle,news_keyword,news_describ,news_name,news_content,news_createtime,news_alertime,news_comefrom,news_seetime,news_isshow,news_recommand,news_type,news_image,news_isimage,news_sort,user_id ");
			strSql.Append(" FROM hnf_news ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}
        public DataSet GetIdList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select news_id ");
            strSql.Append(" FROM hnf_news ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" WHERE " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }
		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM hnf_news ");
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
				strSql.Append("order by T.news_id desc");
			}
			strSql.Append(")AS Row, T.*  from hnf_news T ");
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
			parameters[0].Value = "hnf_news";
			parameters[1].Value = "news_id";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/
       
        
        public Int32 getnum(int news_type, int year, int month)
        {
            StringBuilder strsql = new StringBuilder();
            strsql.Append("select count(news_id) as num from hnf_news where news_type=" + news_type.ToString());
            strsql.Append(" and year(news_createtime)=" + year.ToString());
            strsql.Append(" and month(news_createtime)=" + month.ToString());
            object obj = DbHelperSQL.GetSingle(strsql.ToString());
            if (obj != null)
            {
                return Convert.ToInt32(obj);
            }
            else
            {
                return 0;
            }
        }
		#endregion  Method
	}
}

