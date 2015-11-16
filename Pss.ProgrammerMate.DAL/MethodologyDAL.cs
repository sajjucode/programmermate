using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PSS.DAL.COMMON;

namespace Pss.ProgrammerMate.DAL
{

    /// <summary> 
    /// MethodologyDAL  class is use for All database methods and operations for table Methodology
    /// </summary> 
    /// <remarks> 
    /// Author: Sajjad Yousuf Anjum 
    /// Created Date: Monday 09 Nov 2015 22:23:43
    /// Copy Rights: PakSoft Solutions 
    /// </remarks> 
    [Serializable]
    public class MethodologyDAL : clsDBFunctions
    {

        #region "public variables"
        string myTableName = "Methodology";
        string myTablesFields = string.Empty;
        string myTablesFieldsValues = string.Empty;
        string myUpdateFieldsandValues = string.Empty;
        string myWhere = string.Empty;
        SqlCommand mySqlCommand;
        string mySqlQuery = string.Empty;
        string ReturnIdentity = "-1";

        #endregion
        /// <summary>
        /// Get or Set value of I D
        /// </summary>
        public int ID { get; set; }


        /// <summary>
        /// Get or Set value of Name
        /// </summary>
        public string Name { get; set; }


        /// <summary>
        /// Get or Set value of P Description
        /// </summary>
        public string PDescription { get; set; }


        /// <summary>
        /// Get or Set value of User Id
        /// </summary>
        public int UserId { get; set; }


        /// <summary>
        /// Get or Set value of is Active
        /// </summary>
        public Boolean isActive { get; set; }


        /// <summary>
        /// Get or Set value of Created On Utc
        /// </summary>
        public DateTime CreatedOnUtc { get; set; }


        /// <summary>
        /// Get or Set value of Updated On Utc
        /// </summary>
        public DateTime UpdatedOnUtc { get; set; }



        /// <summary> 
        /// Add New Record but first fill the properties. and Id should be 0 
        /// </summary> 
        /// <returns></returns> 
        public clsActionStatus Insert()
        {
            clsActionStatus clsActionStatus = new clsActionStatus();

            try
            {
                this.myTablesFields = "Name,PDescription,UserId,isActive,CreatedOnUtc,UpdatedOnUtc";
                this.myTablesFieldsValues = "@Name,@PDescription,@UserId,@isActive,getDate(),getDate()";
                this.mySqlQuery = this.getInsertQuery(this.myTableName, this.myTablesFields, this.myTablesFieldsValues);
                this.mySqlCommand = new SqlCommand(this.mySqlQuery, this.getSQLConnection());
                var myPara = this.mySqlCommand.Parameters;

                myPara.Add("@Name", SqlDbType.NVarChar).Value = this.Name;
                myPara.Add("@PDescription", SqlDbType.NVarChar).Value = this.PDescription;
                myPara.Add("@UserId", SqlDbType.Int).Value = this.UserId;
                myPara.Add("@isActive", SqlDbType.Bit).Value = this.isActive;

                ReturnIdentity = this.mySqlCommand.ExecuteScalar().ToString();
                clsActionStatus.is_Error = false;
                clsActionStatus.Action_SuccessStatus = "Record Created successfully!. and New Id is : " + ReturnIdentity;
                clsActionStatus.Return_Id = ReturnIdentity;
            }
            catch (SqlException ex)
            {
                clsActionStatus.is_Error = true;
                clsActionStatus.Action_FailureStatus = this.Error_Description("Insert", "Methodology", ex.ErrorCode.ToString(), ex.Message);
            }
            finally
            {
                this.mySqlCommand.Dispose();
                this.CloseSqlConnection();
            }
            return clsActionStatus;
        }

        /// <summary> 
        /// Update Record but first fill the properties. and Id will be use as where condition 
        /// </summary> 
        /// <returns></returns> 
        public clsActionStatus Update()
        {
            clsActionStatus clsActionStatus = new clsActionStatus();

            try
            {
                this.myWhere = " ID=" + this.ID.ToString();
                this.myUpdateFieldsandValues = "Name=@Name,PDescription=@PDescription,UserId=@UserId,isActive=@isActive,UpdatedOnUtc=getDate()";
                this.mySqlQuery = this.getUpdateQuery(this.myTableName, this.myUpdateFieldsandValues, this.myWhere);
                this.mySqlCommand = new SqlCommand(this.mySqlQuery, this.getSQLConnection());
                var myPara = this.mySqlCommand.Parameters;

                myPara.Add("@Name", SqlDbType.NVarChar).Value = this.Name;
                myPara.Add("@PDescription", SqlDbType.NVarChar).Value = this.PDescription;
                myPara.Add("@UserId", SqlDbType.Int).Value = this.UserId;
                myPara.Add("@isActive", SqlDbType.Bit).Value = this.isActive;

                this.mySqlCommand.ExecuteNonQuery();
                clsActionStatus.is_Error = false;
                clsActionStatus.Action_SuccessStatus = "Record Updated successfully!";
                clsActionStatus.Return_Id = this.ID.ToString();
            }
            catch (SqlException ex)
            {
                clsActionStatus.is_Error = true;
                clsActionStatus.Action_FailureStatus = this.Error_Description("Update", "Methodology", ex.ErrorCode.ToString(), ex.Message);
            }
            finally
            {
                this.mySqlCommand.Dispose();
                this.CloseSqlConnection();
            }
            return clsActionStatus;
        }

        /// <summary> 
        /// Change  Record Status for active or disable but first fill the properties. and Id will be use as where condition 
        /// </summary> 
        /// <returns></returns> 
        public clsActionStatus ChangeStatus()
        {
            clsActionStatus clsActionStatus = new clsActionStatus();

            try
            {
                this.myWhere = " ID=" + this.ID.ToString();
                this.myUpdateFieldsandValues = "isActive=@isActive";
                this.mySqlQuery = this.getUpdateQuery(this.myTableName, this.myUpdateFieldsandValues, this.myWhere);
                this.mySqlCommand = new SqlCommand(this.mySqlQuery, this.getSQLConnection());
                var myPara = this.mySqlCommand.Parameters;

                myPara.Add("@isActive", SqlDbType.Bit).Value = this.isActive;

                this.mySqlCommand.ExecuteNonQuery();
                clsActionStatus.is_Error = false;
                clsActionStatus.Action_SuccessStatus = "Record Status updated successfully!";
                clsActionStatus.Return_Id = this.ID.ToString();
            }
            catch (SqlException ex)
            {
                clsActionStatus.is_Error = true;
                clsActionStatus.Action_FailureStatus = this.Error_Description("Change Status", "Methodology", ex.ErrorCode.ToString(), ex.Message);
            }
            finally
            {
                this.mySqlCommand.Dispose();
                this.CloseSqlConnection();
            }
            return clsActionStatus;
        }

        /// <summary> 
        /// Delete Record but first fill the properties. and Id will be use as where condition 
        /// </summary> 
        /// <returns></returns> 
        public clsActionStatus Delete()
        {
            clsActionStatus clsActionStatus = new clsActionStatus();

            try
            {
                this.myWhere = " ID=" + this.ID.ToString();
                this.mySqlQuery = this.getDeleteQuery(this.myTableName, this.myWhere);
                this.mySqlCommand = new SqlCommand(this.mySqlQuery, this.getSQLConnection());

                this.mySqlCommand.ExecuteNonQuery();
                clsActionStatus.is_Error = false;
                clsActionStatus.Action_SuccessStatus = "Record Deleted successfully!";
                clsActionStatus.Return_Id = this.ID.ToString();
            }
            catch (SqlException ex)
            {
                clsActionStatus.is_Error = true;
                clsActionStatus.Action_FailureStatus = this.Error_Description("Delete", "Methodology", ex.ErrorCode.ToString(), ex.Message);
            }
            finally
            {
                this.mySqlCommand.Dispose();
                this.CloseSqlConnection();
            }
            return clsActionStatus;
        }

        /// <summary> 
        /// Use to Get Total Records 
        /// </summary> 
        /// <returns></returns> 
        public Int64 getTotalNumberOfRecords(int PageSize, int PageNo, string OrderBy, string Ordering = "Asc")
        {
            return this.TotalRecords(this.myTableName);


        }

        /// <summary> 
        /// Get Detail of Record by Id 
        /// </summary> 
        /// <returns></returns> 
        public DataTable getInfo(Int64 Org_Id)
        {
            try
            {
                this.myWhere = " ID=" + Org_Id;
                return this.getAllRecords_DataTable(this.myTableName, this.myWhere, " Id asc");
            }
            catch (SqlException ex)
            {
                return null;
            }


        }
        /// <summary> 
        /// Use to Get List of Records by Page Size and Page No 
        /// </summary> 
        /// <returns></returns> 
        public DataTable getList(int PageSize, int PageNo, string OrderBy, string Ordering = "Asc")
        {
            this.mySqlQuery = "Select * " + Environment.NewLine +
            "  from  (  " + Environment.NewLine +
            "          Select *, ROW_NUMBER() over (Order By " + OrderBy + " " + Ordering + ") as MyRecordNo " + Environment.NewLine +
            "          from " + this.myTableName + " " + Environment.NewLine +
            "          ) as myTable " + Environment.NewLine +
            "          Where myTable.MyRecordNo BETWEEN (" + PageSize + "*(" + PageNo + "-1))+1 AND (" + PageSize + "*" + PageNo + ") ";


            return this.getAllRecords_CustomizeQuery_DataTable(this.mySqlQuery);
        }

        /// <summary> 
        /// Use to Get List of Records by Search and by Page Size and Page No 
        /// </summary> 
        /// <returns></returns> 
        public DataTable getList_Search(int PageSize, int PageNo, string myWhereCondition, string OrderBy, string Ordering = "Asc")
        {
            this.mySqlQuery = "Select * " + Environment.NewLine +
            "  from  (  " + Environment.NewLine +
            "          Select *, ROW_NUMBER() over (Order By " + OrderBy + " " + Ordering + ") as MyRecordNo " + Environment.NewLine +
            "          from " + this.myTableName + " " + Environment.NewLine +
            "          Where " + myWhereCondition + Environment.NewLine +
            "          ) as myTable " + Environment.NewLine +
            "          Where myTable.MyRecordNo BETWEEN (" + PageSize + "*(" + PageNo + "-1))+1 AND (" + PageSize + "*" + PageNo + ") ";


            return this.getAllRecords_CustomizeQuery_DataTable(this.mySqlQuery);
        }

    }
}