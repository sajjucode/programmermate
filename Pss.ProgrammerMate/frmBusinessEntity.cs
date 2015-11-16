using Pss.ProgrammerMate.CommonClasses;
using Pss.ProgrammerMate.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pss.ProgrammerMate
{
    public partial class frmBusinessEntity : Form
    {
        string CurrentDBType = "";
        int CurrentDBID = 0;

        string CurrentFolderName;
        int CurrentFolderId=0;

        #region "Solutions and Solution DB"
        void getList_Solutions()
        {
            try
            {

                DataTable myDataTable_Solutions = new DataTable();// = new JobStatusHeadDAL().getList(1000, 1, "Id", "asc");                
                myDataTable_Solutions = new SolutionsDAL().getList(1000, 1, "ID", "asc");


                this.Solutions_bindingSource.DataSource = myDataTable_Solutions;
                //this.bnMain.BindingSource = this.Solutions_bindingSource;

                this.cmbSolutions.DataSource = null;

                this.cmbSolutions.DataSource = this.Solutions_bindingSource;

                this.cmbSolutions.DisplayMember = "SolutionName";
                this.cmbSolutions.ValueMember = "ID";

                this.cmbSolutions.Refresh();
                this.cmbSolutions.Update();

            }
            catch (Exception ex)
            {
                CommonClasses.Messages.GeneralError(ex.Message, " Solutions");
            }
        }

        void ViewAll_SolutionsDB()
        {
            try
            {
                if (this.cmbSolutions.DataSource == null)
                    return;


                this.cmbSolutionsDB.DataSource = null;
                this.cmbSolutionsDB.Items.Clear();

                DataTable myDataTable_SolutionsDB = new DataTable();// = new JobStatusHeadDAL().getList(1000, 1, "Id", "asc");

                myDataTable_SolutionsDB = new SolutionsDBDAL().getList_Search(1000, 1, " SolutionID =" + this.cmbSolutions.SelectedValue.ToString(), "DBType");

                this.SolutionsDB_bindingSource.DataSource = myDataTable_SolutionsDB;

                this.cmbSolutionsDB.DataSource = this.SolutionsDB_bindingSource;

                if (this.SolutionsDB_bindingSource != null && this.SolutionsDB_bindingSource.Count > 0)
                {
                    this.cmbSolutionsDB.DisplayMember = "DBInfo";
                    this.cmbSolutionsDB.ValueMember = "ID";
                }
                this.cmbSolutionsDB.Refresh();
                this.cmbSolutionsDB.Update();


            }
            catch (Exception ex)
            {
                CommonClasses.Messages.GeneralError(ex.Message, " Solutions DB");
            }
        }

        //void GetAutoSQLName_SolutionsDB(string TableName)
        //{
        //    try
        //    {
        //        DataRowView myRow = (DataRowView)this.SolutionsDB_bindingSource.Current;

        //        if (myRow != null && myRow["SPFormat"].ToString().Length > 0)
        //        {
        //            this.txtSqlName_Insert.Text = myRow["SPFormat"].ToString().Replace("{TableName}", TableName).Replace("{Action}", "Insert");
        //            this.txtSqlName_Delete.Text = myRow["SPFormat"].ToString().Replace("{TableName}", TableName).Replace("{Action}", "Delete");
        //            this.txtSqlName_GetRecord.Text = myRow["SPFormat"].ToString().Replace("{TableName}", TableName).Replace("{Action}", "GetList");
        //            this.txtSqlName_Update.Text = myRow["SPFormat"].ToString().Replace("{TableName}", TableName).Replace("{Action}", "Update");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        CommonClasses.Messages.GeneralError(ex.Message, " Format");
        //    }

        //}

        void GetSelectDB_Tables()
        {
            try
            {
                DataTable myDataTable_SolutionsDBTables = new SolutionsDBTablesDAL().getList_Search(10000, 1, " SolutionsDBID= " + this.cmbSolutionsDB.SelectedValue.ToString(), "TableName");

                if (myDataTable_SolutionsDBTables != null)
                {
                    this.SolutionsDBTables_bindingSource.DataSource = myDataTable_SolutionsDBTables;
                }

                if (this.SolutionsDBTables_bindingSource.DataSource != null)
                {
                    this.cmbDBTables.DataSource = this.SolutionsDBTables_bindingSource;
                    this.cmbDBTables.DisplayMember = "TableName";
                    this.cmbDBTables.ValueMember = "ID";
                }

                this.cmbDBTables.Refresh();
                this.cmbDBTables.Update();

                this.GetSelectDB_TableColumns();
            }
            catch (Exception ex)
            {

            }
        }

        void GetSelectDB_TableColumns()
        {
            try
            {
                DataTable myDataTable_SolutionsDBTableColumns = new SolutionsDBTableColumnsDAL().getList_Search(10000, 1, " SolutionsDBID= " + this.cmbSolutionsDB.SelectedValue.ToString() + " and TableName like '" + this.cmbDBTables.Text + "'", "ID");

                if (myDataTable_SolutionsDBTableColumns != null)
                {
                    this.TableColumns_bindingSource.DataSource = myDataTable_SolutionsDBTableColumns;
                }

                this.dvgTableColumns.DataSource = this.TableColumns_bindingSource;

                this.dvgTableColumns.Columns["clmName"].DataPropertyName = "ColumnName";
                this.dvgTableColumns.Columns["clmType"].DataPropertyName = "ColumnType";

                this.dvgTableColumns.Refresh();
                this.dvgTableColumns.Update();


            }
            catch (Exception ex)
            {

            }
        }

        void SelectColumns()
        {
            try
            {
                this.getSelectedTableFolder();

                if (this.cbkSelectAll.Checked == true)
                {
                    this.cbkSelectAll.Text = "Un-select All";

                    foreach (DataGridViewRow myRow in this.dvgTableColumns.Rows)
                    {
                        DataGridViewCheckBoxCell myCell = (DataGridViewCheckBoxCell)myRow.Cells["clmSelect"];
                        myCell.Value = 1;
                    }

                }
                else
                {
                    this.cbkSelectAll.Text = "Select All";

                    foreach (DataGridViewRow myRow in this.dvgTableColumns.Rows)
                    {
                        DataGridViewCheckBoxCell myCell = (DataGridViewCheckBoxCell)myRow.Cells["clmSelect"];
                        myCell.Value = 0;
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        #endregion

        #region "Get Projects"

        Boolean isProjectMapped;
        void ViewAll_Projects()
        {
            try
            {

                DataTable myDataTable_SolutionsDB = new DataTable();// = new JobStatusHeadDAL().getList(1000, 1, "Id", "asc");

                myDataTable_SolutionsDB = new ProjectsDAL().getList_Search(1000, 1, " SolutionID=" + this.cmbSolutions.SelectedValue.ToString() + " and ProjectType like 'Business Entity'", "ID", "asc");

               
                

                this.Projects_bindingSource.DataSource = myDataTable_SolutionsDB;

                if (this.Projects_bindingSource.DataSource !=null && this.isProjectMapped==false)
                {
                    this.isProjectMapped = true;

                    this.txtBaseFolder.DataBindings.Add("Text", this.Projects_bindingSource, "BaseFolder", false);
                    this.txtProjectNamespace.DataBindings.Add("Text", this.Projects_bindingSource, "PNameSpace", false);                    
                }

                this.cmbProjects.DataSource = this.Projects_bindingSource;
                this.cmbProjects.DisplayMember = "ProjectName";
                this.cmbProjects.ValueMember = "ID";

                this.cmbProjects.Update();
                this.cmbProjects.Refresh();
            }
            catch (Exception ex)
            {
                CommonClasses.Messages.GeneralError(ex.Message, " Project");
            }
        }
        #endregion

        #region "Solution & Table Folder"
        void getSelectedTableFolder()
        {
            try
            {
                DataTable myDataTable_TableFolder = new SolutionFolders_TablesDAL().getTableFolderInfo(int.Parse(this.cmbSolutions.SelectedValue.ToString()), this.cmbDBTables.Text);

                if (myDataTable_TableFolder !=null && myDataTable_TableFolder.Rows.Count >0)
                {
                    DataRow myRow = myDataTable_TableFolder.Rows[0];

                    this.CurrentFolderName = myRow["FolderName"].ToString();
                    this.CurrentFolderId = int.Parse(myRow["FolderId"].ToString());

                    this.txtGenerateBESaveIn.Text = this.txtBaseFolder.Text + "\\" + myRow["FolderName"].ToString();
                    this.txtGenerateBENamespace.Text = myRow["NamespaceFormat"].ToString().Replace("{Parent}",this.txtProjectNamespace.Text).Replace("{FolderName}",myRow["FolderName"].ToString());

                }

            }
            catch (Exception ex)
            {

            }
        }
        #endregion

        #region "Business Entity"
        string DateTimeFormat = CommonClasses.CommonVariables.FullDateFormat;
        public void GenerateBE()
        {
            try
            {
                string ClassReferences = "using System; " + Environment.NewLine +
                                     "using System.Collections.Generic; " + Environment.NewLine +
                                     "using System.Linq; " + Environment.NewLine +
                                     "using System.Text; " + Environment.NewLine +
                                     "using System.Threading.Tasks;";
                string HeaderCommand = "/// <summary> " + Environment.NewLine +
                                       "/// Business Entities for Table " + this.cmbDBTables.Text + Environment.NewLine +
                                       "  /// </summary>  " + Environment.NewLine +
                                       "  /// <remarks>  " + Environment.NewLine +
                                       "  /// Tool: Programmer Mate  " + Environment.NewLine +
                                       "  /// Author: Sajjucode  " + Environment.NewLine +
                                       "  /// Created Date: " + DateTime.Now.ToString(DateTimeFormat) + Environment.NewLine +
                                       "  /// Copy Rights: PakSoft Solutions  " + Environment.NewLine +
                                       "/// </remarks> ";

                string Entities = string.Empty;
                string IEntities = string.Empty;
                DataRowView myRows;
                string ClassContent = string.Empty;
                string IClassContent = string.Empty;

                string Namespace = this.txtGenerateBENamespace.Text;// "Pss.DAL.BE";
                string INamespace = this.txtGenerateBENamespace.Text + ".Interface";// "Pss.DAL.BE";

                string ClassName = this.cmbDBTables.Text;// +".cs";
                string IClassName = "I" + this.cmbDBTables.Text;// +".cs";

               
                foreach (DataGridViewRow myRow in this.dvgTableColumns.Rows)
                {
                    DataGridViewCheckBoxCell myCell = (DataGridViewCheckBoxCell)myRow.Cells["clmSelect"];

                    if (myCell.Value.ToString() == "1")
                    {
                        myRows = (DataRowView)myRow.DataBoundItem;
                        Entities = Entities + "public " + SQLDataTypeConversion.getDataType(myRows["DataType"].ToString()) + " " +  myRows["ColumnName"].ToString() + " {get;set;} " + Environment.NewLine ;
                        IEntities = IEntities + "" + SQLDataTypeConversion.getDataType(myRows["DataType"].ToString()) + " " + myRows["ColumnName"].ToString() + " {get;set;} " + Environment.NewLine;                        
                    }


                }

                IClassContent = ClassReferences + Environment.NewLine + Environment.NewLine +
                              "namespace " + INamespace + Environment.NewLine + Environment.NewLine +
                              "{" + Environment.NewLine +
                              "     " + HeaderCommand + " " + Environment.NewLine +
                              "    public interface " + IClassName + Environment.NewLine +
                              "    {" + Environment.NewLine +
                              "        " + IEntities +
                              "    }" + Environment.NewLine +
                              "}";

                ClassContent = ClassReferences + Environment.NewLine +
                               "using " + INamespace + ";" + Environment.NewLine + Environment.NewLine +
                               "namespace " + Namespace + Environment.NewLine + Environment.NewLine +
                               "{" + Environment.NewLine +
                               "     " + HeaderCommand + " " + Environment.NewLine +
                               "    public class " + ClassName + " : " + IClassName + Environment.NewLine +
                               "    {" + Environment.NewLine +
                               "        " + Entities +
                               "    }" + Environment.NewLine +
                               "}";


                this.txtGeneratedClass.Text = ClassContent;

                this.ProjectFile_Insert(IClassContent,"interface",INamespace,IClassName + ".cs");

                this.ProjectFile_Insert(ClassContent, "class", Namespace, ClassName + ".cs");


                                              
               



            }
            catch(Exception ex)
            {
                CommonClasses.Messages.GeneralError(ex.Message, " Project BE");
            }
        }
        #endregion

        #region "Project Files "

        void ProjectFile_Insert(string ClassContent,string ClassType,string NameSpace,string SaveAs)
        {
            try
            {
                ProjectFilesDAL ProjectFiilesDAL = new ProjectFilesDAL();

                ProjectFiilesDAL.ProjectId = int.Parse(this.cmbProjects.SelectedValue.ToString());

                ProjectFiilesDAL.ClassType = ClassType;

                if (ClassType.ToLower()=="interface")
                {
                    ProjectFiilesDAL.FullPath = this.txtGenerateBESaveIn.Text + "\\Interface\\" + SaveAs;
                }
                else
                {
                    ProjectFiilesDAL.FullPath = this.txtGenerateBESaveIn.Text + "\\" + SaveAs;
                }

                ProjectFiilesDAL.FolderId = this.CurrentFolderId;
                ProjectFiilesDAL.FolderName = this.CurrentFolderName;
                ProjectFiilesDAL.FNameSpace = NameSpace; //this.txtGenerateBENamespace.Text;
                ProjectFiilesDAL.SaveAs = SaveAs; //this.cmbDBTables.Text + ".cs";

                ProjectFiilesDAL.isGenerated = chkisSavedOnGenerate.Checked;

                ProjectFiilesDAL.FileData = ClassContent;// this.txtGeneratedClass.Text;
                ProjectFiilesDAL.isActive = true;
                ProjectFiilesDAL.UserId = Security.UserID;

                if (ProjectFiilesDAL.isGenerated==true)
                {
                    FileInfo myFile = new FileInfo(ProjectFiilesDAL.FullPath);

                    if (myFile.Exists==false)
                    {
                        Directory.CreateDirectory(myFile.Directory.FullName);
                    }

                    File.WriteAllText(ProjectFiilesDAL.FullPath, ProjectFiilesDAL.FileData);
                }

                ProjectFiilesDAL.Insert();

            }
            catch (Exception ex)
            {
                CommonClasses.Messages.GeneralError(ex.Message, " Project File");
            }
        }
        #endregion

        public frmBusinessEntity()
        {
            InitializeComponent();
        }

        private void frmBusinessEntity_Load(object sender, EventArgs e)
        {
            try
            {
                this.dvgSolutionDBQuery.AutoGenerateColumns = false;
                new Appearances.SetFocusBlur_Color().setFocus_Blur_Properties(this);
                Appearances.GridViewStyles.setGridDefaultStyle(this.dvgTableColumns);
                this.dvgTableColumns.AutoGenerateColumns = false;

                this.getList_Solutions();

                this.dvgTableColumns.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            }
            catch (Exception ex)
            {
            }
        }

        private void cmdRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                this.ViewAll_SolutionsDB();
                this.ViewAll_Projects();
            }
            catch (Exception ex)
            {

            }
        }

        private void cmdConnect_Click(object sender, EventArgs e)
        {
            try
            {
                DataRowView myRow = (DataRowView)this.SolutionsDB_bindingSource.Current;

                if (myRow != null)
                {
                    this.CurrentDBType = myRow["DBType"].ToString();
                    this.CurrentDBID = int.Parse(myRow["ID"].ToString());
                }

                this.GetSelectDB_Tables();

                this.cbkSelectAll.Checked = true;

                this.SelectColumns();
                //this.GetSelectedDB_Folders();

                //this.getMappedTables();
            }
            catch (Exception ex)
            {

            }
        }

        private void cmdColumns_Click(object sender, EventArgs e)
        {
            try
            {
                //this.SolutionDBQuery_bindingSource.DataSource = null;
                //this.dvgSolutionDBQuery.DataBindings.Clear();

                this.GetSelectDB_TableColumns();

                this.cbkSelectAll.Checked = true;

                this.SelectColumns();


            }
            catch (Exception ex)
            {
                CommonClasses.Messages.GeneralError(ex.Message, " Table Columns");
            }
        }

        private void cmbSolutions_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (this.cmbSolutions.Items != null && this.cmbSolutions.Items.Count > 0)
            //{
            //    this.ViewAll_Projects();
            //}
        }

        private void cbkSelectAll_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cmbDBTables_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbDBTables_TextChanged(object sender, EventArgs e)
        {

            this.GetSelectDB_TableColumns();

            this.cbkSelectAll.Checked = true;

            this.SelectColumns();
        }

        private void cmdGenerateBE_Click(object sender, EventArgs e)
        {
            
        }

        private void txtCopyClipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.txtGeneratedClass.Text);
            CommonClasses.Messages.SuccessMessage("Copy successfully.", "Copy");
        }

        private void cmdGenerateBE_Click_1(object sender, EventArgs e)
        {
            this.GenerateBE();
        }
    }
}
