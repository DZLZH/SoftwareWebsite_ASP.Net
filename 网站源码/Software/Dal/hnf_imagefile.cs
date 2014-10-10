using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace NewsSolution.DAL
{
	/// <summary>
	/// 数据访问类:hnf_imagefile
	/// </summary>
	public partial class hnf_imagefile
	{
		public hnf_imagefile()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("image_id", "hnf_imagefile"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int image_id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from hnf_imagefile");
			strSql.Append(" where image_id=@image_id");
			SqlParameter[] parameters = {
					new SqlParameter("@image_id", SqlDbType.Int,4)
			};
			parameters[0].Value = image_id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(NewsSolution.Model.hnf_imagefile model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into hnf_imagefile(");
			strSql.Append("image_name,image_file,image_url,image_content,image_type_id,user_id,image_times,image_addtime,image_shenhe,image_recommand,guanggao_type,huandeng_type)");
			strSql.Append(" values (");
			strSql.Append("@image_name,@image_file,@image_url,@image_content,@image_type_id,@user_id,@image_times,@image_addtime,@image_shenhe,@image_recommand,@guanggao_type,@huandeng_type)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@image_name", SqlDbType.NVarChar,50),
					new SqlParameter("@image_file", SqlDbType.NVarChar,50),
					new SqlParameter("@image_url", SqlDbType.NVarChar,50),
					new SqlParameter("@image_content", SqlDbType.NText),
					new SqlParameter("@image_type_id", SqlDbType.Int,4),
					new SqlParameter("@user_id", SqlDbType.Int,4),
					new SqlParameter("@image_times", SqlDbType.Int,4),
					new SqlParameter("@image_addtime", SqlDbType.SmallDateTime),
					new SqlParameter("@image_shenhe", SqlDbType.Int,4),
					new SqlParameter("@image_recommand", SqlDbType.Int,4),
					new SqlParameter("@guanggao_type", SqlDbType.Int,4),
					new SqlParameter("@huandeng_type", SqlDbType.Int,4)};
			parameters[0].Value = model.image_name;
			parameters[1].Value = model.image_file;
			parameters[2].Value = model.image_url;
			parameters[3].Value = model.image_content;
			parameters[4].Value = model.image_type_id;
			parameters[5].Value = model.user_id;
			parameters[6].Value = model.image_times;
			parameters[7].Value = model.image_addtime;
			parameters[8].Value = model.image_shenhe;
			parameters[9].Value = model.image_recommand;
			parameters[10].Value = model.guanggao_type;
			parameters[11].Value = model.huandeng_type;

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
		public bool Update(NewsSolution.Model.hnf_imagefile model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update hnf_imagefile set ");
			strSql.Append("image_name=@image_name,");
			strSql.Append("image_file=@image_file,");
			strSql.Append("image_url=@image_url,");
			strSql.Append("image_content=@image_content,");
			strSql.Append("image_type_id=@image_type_id,");
			strSql.Append("user_id=@user_id,");
			strSql.Append("image_times=@image_times,");
			strSql.Append("image_addtime=@image_addtime,");
			strSql.Append("image_shenhe=@image_shenhe,");
			strSql.Append("image_recommand=@image_recommand,");
			strSql.Append("guanggao_type=@guanggao_type,");
			strSql.Append("huandeng_type=@huandeng_type");
			strSql.Append(" where image_id=@image_id");
			SqlParameter[] parameters = {
					new SqlParameter("@image_name", SqlDbType.NVarChar,50),
					new SqlParameter("@image_file", SqlDbType.NVarChar,50),
					new SqlParameter("@image_url", SqlDbType.NVarChar,50),
					new SqlParameter("@image_content", SqlDbType.NText),
					new SqlParameter("@image_type_id", SqlDbType.Int,4),
					new SqlParameter("@user_id", SqlDbType.Int,4),
					new SqlParameter("@image_times", SqlDbType.Int,4),
					new SqlParameter("@image_addtime", SqlDbType.SmallDateTime),
					new SqlParameter("@image_shenhe", SqlDbType.Int,4),
					new SqlParameter("@image_recommand", SqlDbType.Int,4),
					new SqlParameter("@guanggao_type", SqlDbType.Int,4),
					new SqlParameter("@huandeng_type", SqlDbType.Int,4),
					new SqlParameter("@image_id", SqlDbType.Int,4)};
			parameters[0].Value = model.image_name;
			parameters[1].Value = model.image_file;
			parameters[2].Value = model.image_url;
			parameters[3].Value = model.image_content;
			parameters[4].Value = model.image_type_id;
			parameters[5].Value = model.user_id;
			parameters[6].Value = model.image_times;
			parameters[7].Value = model.image_addtime;
			parameters[8].Value = model.image_shenhe;
			parameters[9].Value = model.image_recommand;
			parameters[10].Value = model.guanggao_type;
			parameters[11].Value = model.huandeng_type;
			parameters[12].Value = model.image_id;

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
		public bool Delete(int image_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from hnf_imagefile ");
			strSql.Append(" where image_id=@image_id");
			SqlParameter[] parameters = {
					new SqlParameter("@image_id", SqlDbType.Int,4)
			};
			parameters[0].Value = image_id;

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
		public bool DeleteList(string image_idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from hnf_imagefile ");
			strSql.Append(" where image_id in ("+image_idlist + ")  ");
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
		public NewsSolution.Model.hnf_imagefile GetModel(int image_id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 image_id,image_name,image_file,image_url,image_content,image_type_id,user_id,image_times,image_addtime,image_shenhe,image_recommand,guanggao_type,huandeng_type from hnf_imagefile ");
			strSql.Append(" where image_id=@image_id");
			SqlParameter[] parameters = {
					new SqlParameter("@image_id", SqlDbType.Int,4)
			};
			parameters[0].Value = image_id;

			NewsSolution.Model.hnf_imagefile model=new NewsSolution.Model.hnf_imagefile();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["image_id"]!=null && ds.Tables[0].Rows[0]["image_id"].ToString()!="")
				{
					model.image_id=int.Parse(ds.Tables[0].Rows[0]["image_id"].ToString());
				}
				if(ds.Tables[0].Rows[0]["image_name"]!=null && ds.Tables[0].Rows[0]["image_name"].ToString()!="")
				{
					model.image_name=ds.Tables[0].Rows[0]["image_name"].ToString();
				}
				if(ds.Tables[0].Rows[0]["image_file"]!=null && ds.Tables[0].Rows[0]["image_file"].ToString()!="")
				{
					model.image_file=ds.Tables[0].Rows[0]["image_file"].ToString();
				}
				if(ds.Tables[0].Rows[0]["image_url"]!=null && ds.Tables[0].Rows[0]["image_url"].ToString()!="")
				{
					model.image_url=ds.Tables[0].Rows[0]["image_url"].ToString();
				}
				if(ds.Tables[0].Rows[0]["image_content"]!=null && ds.Tables[0].Rows[0]["image_content"].ToString()!="")
				{
					model.image_content=ds.Tables[0].Rows[0]["image_content"].ToString();
				}
				if(ds.Tables[0].Rows[0]["image_type_id"]!=null && ds.Tables[0].Rows[0]["image_type_id"].ToString()!="")
				{
					model.image_type_id=int.Parse(ds.Tables[0].Rows[0]["image_type_id"].ToString());
				}
				if(ds.Tables[0].Rows[0]["user_id"]!=null && ds.Tables[0].Rows[0]["user_id"].ToString()!="")
				{
					model.user_id=int.Parse(ds.Tables[0].Rows[0]["user_id"].ToString());
				}
				if(ds.Tables[0].Rows[0]["image_times"]!=null && ds.Tables[0].Rows[0]["image_times"].ToString()!="")
				{
					model.image_times=int.Parse(ds.Tables[0].Rows[0]["image_times"].ToString());
				}
				if(ds.Tables[0].Rows[0]["image_addtime"]!=null && ds.Tables[0].Rows[0]["image_addtime"].ToString()!="")
				{
					model.image_addtime=DateTime.Parse(ds.Tables[0].Rows[0]["image_addtime"].ToString());
				}
				if(ds.Tables[0].Rows[0]["image_shenhe"]!=null && ds.Tables[0].Rows[0]["image_shenhe"].ToString()!="")
				{
					model.image_shenhe=int.Parse(ds.Tables[0].Rows[0]["image_shenhe"].ToString());
				}
				if(ds.Tables[0].Rows[0]["image_recommand"]!=null && ds.Tables[0].Rows[0]["image_recommand"].ToString()!="")
				{
					model.image_recommand=int.Parse(ds.Tables[0].Rows[0]["image_recommand"].ToString());
				}
				if(ds.Tables[0].Rows[0]["guanggao_type"]!=null && ds.Tables[0].Rows[0]["guanggao_type"].ToString()!="")
				{
					model.guanggao_type=int.Parse(ds.Tables[0].Rows[0]["guanggao_type"].ToString());
				}
				if(ds.Tables[0].Rows[0]["huandeng_type"]!=null && ds.Tables[0].Rows[0]["huandeng_type"].ToString()!="")
				{
					model.huandeng_type=int.Parse(ds.Tables[0].Rows[0]["huandeng_type"].ToString());
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
			strSql.Append("select image_id,image_name,image_file,image_url,image_content,image_type_id,user_id,image_times,image_addtime,image_shenhe,image_recommand,guanggao_type,huandeng_type ");
			strSql.Append(" FROM hnf_imagefile ");
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
            strSql.Append(" image_id,image_name,image_file,image_url,image_content,image_type_id,user_id,image_times,image_addtime,image_shenhe,image_recommand,guanggao_type,huandeng_type ");
            strSql.Append(" FROM hnf_imagefile ");
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
			strSql.Append(" image_id,image_name,image_file,image_url,image_content,image_type_id,user_id,image_times,image_addtime,image_shenhe,image_recommand,guanggao_type,huandeng_type ");
			strSql.Append(" FROM hnf_imagefile ");
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
			strSql.Append("select count(1) FROM hnf_imagefile ");
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
        ///根据查询条件获得图片的image_id号
        /// </summary>
        /// <param name="strWhere">查询条件</param>
        /// <returns>返回DataSet记录集类型</returns>
        public DataSet GetIdList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select image_id");
            strSql.Append(" FROM hnf_imagefile ");
            if (strWhere != "")
            {
                strSql.Append(" WHERE " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
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
				strSql.Append("order by T.image_id desc");
			}
			strSql.Append(")AS Row, T.*  from hnf_imagefile T ");
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
			parameters[0].Value = "hnf_imagefile";
			parameters[1].Value = "image_id";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/
        //统计当月图片信息发布的记录数
        public Int32 getnum(int image_type_id, int year, int month)
        {
            StringBuilder strsql = new StringBuilder();
            strsql.Append("select count(image_id) as num from hnf_imagefile where image_type_id=" + image_type_id.ToString());
            strsql.Append(" and year(image_addtime)=" + year.ToString());
            strsql.Append(" and month(image_addtime)=" + month.ToString());
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

