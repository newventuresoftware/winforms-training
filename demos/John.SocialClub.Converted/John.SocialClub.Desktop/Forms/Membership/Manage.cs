// -----------------------------------------------------------------------
// <copyright file="Manage.cs" company="John">
//  Socia Member club Demo ©2013
// </copyright>
// -----------------------------------------------------------------------

namespace John.SocialClub.Desktop.Forms.Membership
{
    using System;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Drawing.Printing;
    using System.Globalization;
    using System.Windows.Forms;
    using John.SocialClub.Data.BusinessService;
    using John.SocialClub.Data.DataModel;
    using John.SocialClub.Data.Enum;
    using John.SocialClub.Desktop.Properties;
    using Telerik.WinControls.UI;

    /// <summary>
    /// Manage screen - To view, search, print, export club members information
    /// </summary>
    public partial class Manage : Telerik.WinControls.UI.RadForm
    {
        ///// <summary>
        ///// Instance of DataGridViewPrinter
        ///// </summary>
        //private DataGridViewPrinter dataGridViewPrinter;

        /// <summary>
        /// Interface of ClubMemberService
        /// </summary>
        private IClubMemberService clubMemberService;

        /// <summary>
        /// Variable to store error message
        /// </summary>
        private string errorMessage;

        /// <summary>
        /// Member id
        /// </summary>
        private int memberId;

        /// <summary>
        /// Initializes a new instance of the Manage class
        /// </summary>
        public Manage()
        {
            this.InitializeComponent();
            this.InitializeResourceString();
            this.InitializeDropDownList();
            this.InitilizeDataGridViewStyle();
            this.clubMemberService = new ClubMemberService();
            this.ResetRegistration();
            this.ResetSearch();
        }

        /// <summary>
        /// Initializes resource strings
        /// </summary>
        private void InitializeResourceString()
        {
            // Registeration
            lblName.Text = Resources.Registration_Name_Label_Text;
            lblDateOfBirth.Text = Resources.Registration_DateOfBirth_Label_Text;
            lblOccupation.Text = Resources.Registration_Occupation_Label_Text;
            lblMaritalStatus.Text = Resources.Registration_MaritalStatus_Label_Text;
            lblHealthStatus.Text = Resources.Registration_HealthStatus_Label_Text;
            lblSalary.Text = Resources.Registration_Salary_Label_Text;
            lblNoOfChildren.Text = Resources.Registration_Children_Label_Text;
            btnRegister.Text = Resources.Registration_Register_Button_Text;

            // Search, Print, Export, Update, Delete
            btnSearch.Text = Resources.Search_Search_Button_Text;
            btnRefresh.Text = Resources.Search_Refresh_Button_Text;
            btnPrintPreview.Text = Resources.Print_PrintPreview_Button_Text;
            btnPrint.Text = Resources.Print_Print_Button_Text;
            btnExport.Text = Resources.Export_Button_Text;
            btnUpdate.Text = Resources.Update_Button_Text;
            btnDelete.Text = Resources.Delete_Button_Text;
        }

        /// <summary>
        /// Initializes all dropdown controls
        /// </summary>
        private void InitializeDropDownList()
        {
            cmbOccupation.DataSource = Enum.GetValues(typeof(Occupation));
            cmbMaritalStatus.DataSource = Enum.GetValues(typeof(MaritalStatus));
            cmbHealthStatus.DataSource = Enum.GetValues(typeof(HealthStatus));

            cmbSearchOccupation.DataSource = Enum.GetValues(typeof(Occupation));
            cmbSearchMaritalStatus.DataSource = Enum.GetValues(typeof(MaritalStatus));
            cmbOperand.SelectedIndex = 0;
        }

        /// <summary>
        /// Resets search criteria
        /// </summary>
        private void ResetSearch()
        {
            cmbSearchMaritalStatus.SelectedIndex = -1;
            cmbSearchOccupation.SelectedIndex = -1;
            cmbOperand.SelectedIndex = 0;
        }

        /// <summary>
        /// Resets the registration screen
        /// </summary>
        private void ResetRegistration()
        {
            txtName.Text = string.Empty;
            txtSalary.Text = string.Empty;
            txtNoOfChildren.Text = string.Empty;
            cmbOccupation.SelectedIndex = -1;
            cmbHealthStatus.SelectedIndex = -1;
            cmbMaritalStatus.SelectedIndex = -1;
        }

        /// <summary>
        /// Initializes all dropdown controls in update section
        /// </summary>
        private void InitializeUpdate()
        {
            cmb2Occupation.DataSource = Enum.GetValues(typeof(Occupation));
            cmb2MaritalStatus.DataSource = Enum.GetValues(typeof(MaritalStatus));
            cmb2HealthStatus.DataSource = Enum.GetValues(typeof(HealthStatus));
        }

        /// <summary>
        /// Resets the update section of manage screen
        /// </summary>
        private void ResetUpdate()
        {
            txt2Name.Text = string.Empty;
            txt2Salary.Text = string.Empty;
            txt2NoOfChildren.Text = string.Empty;
            cmb2Occupation.SelectedIndex = -1;
            cmb2HealthStatus.SelectedIndex = -1;
            cmb2MaritalStatus.SelectedIndex = -1;
        }

        /// <summary>
        /// Validates registration input
        /// </summary>
        /// <returns>true or false</returns>
        private bool ValidateRegistration()
        {
            this.errorMessage = string.Empty;

            if (txtName.Text.Trim() == string.Empty)
            {
                this.AddErrorMessage(Resources.Registration_Name_Required_Text);
            }

            if (cmbOccupation.SelectedIndex == -1)
            {
                this.AddErrorMessage(Resources.Registration_Occupation_Select_Text);
            }

            if (cmbMaritalStatus.SelectedIndex == -1)
            {
                this.AddErrorMessage(Resources.Registration_MaritalStatus_Select_Text);
            }

            if (cmbHealthStatus.SelectedIndex == -1)
            {
                this.AddErrorMessage(Resources.Registration_HealthStatus_Select_Text);
            }

            return this.errorMessage != string.Empty ? false : true;
        }

        /// <summary>
        /// Validates update data
        /// </summary>
        /// <returns>true or false</returns>
        private bool ValidateUpdate()
        {
            this.errorMessage = string.Empty;

            if (txt2Name.Text.Trim() == string.Empty)
            {
                this.AddErrorMessage(Resources.Registration_Name_Required_Text);
            }

            if (cmb2Occupation.SelectedIndex == -1)
            {
                this.AddErrorMessage(Resources.Registration_Occupation_Select_Text);
            }

            if (cmb2MaritalStatus.SelectedIndex == -1)
            {
                this.AddErrorMessage(Resources.Registration_MaritalStatus_Select_Text);
            }

            if (cmb2HealthStatus.SelectedIndex == -1)
            {
                this.AddErrorMessage(Resources.Registration_HealthStatus_Select_Text);
            }

            return this.errorMessage != string.Empty ? false : true;
        }

        /// <summary>
        /// To generate the error message
        /// </summary>
        /// <param name="error">error message</param>
        private void AddErrorMessage(string error)
        {
            if (this.errorMessage == string.Empty)
            {
                this.errorMessage = Resources.Error_Message_Header + "\n\n";
            }

            this.errorMessage += error + "\n";
        }

        /// <summary>
        /// Method to show general error message on any system level exception
        /// </summary>
        private void ShowErrorMessage(Exception ex)
        {
            MessageBox.Show(
                ex.Message,
                //Resources.System_Error_Message, 
                Resources.System_Error_Message_Title,
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        /// <summary>
        /// Initializes data grid view style
        /// </summary>
        private void InitilizeDataGridViewStyle()
        {
            // Setting the style of the DataGridView control
            //dataGridViewMembers.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9, FontStyle.Bold, GraphicsUnit.Point);
            //dataGridViewMembers.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.ControlDark;
            //dataGridViewMembers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            //dataGridViewMembers.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dataGridViewMembers.DefaultCellStyle.Font = new Font("Tahoma", 8, FontStyle.Regular, GraphicsUnit.Point);
            //dataGridViewMembers.DefaultCellStyle.BackColor = Color.Empty;
            //dataGridViewMembers.AlternatingRowsDefaultCellStyle.BackColor = SystemColors.Info;
            //dataGridViewMembers.CellBorderStyle = DataGridViewCellBorderStyle.Single;

            dataGridViewMembers.Columns[3].DataType = typeof(string);
            dataGridViewMembers.Columns[3].DataTypeConverter = new IntToEnumConverter(typeof(Occupation));
            dataGridViewMembers.Columns[4].DataType = typeof(string);
            dataGridViewMembers.Columns[4].DataTypeConverter = new IntToEnumConverter(typeof(MaritalStatus));
            dataGridViewMembers.Columns[5].DataType = typeof(string);
            dataGridViewMembers.Columns[5].DataTypeConverter = new IntToEnumConverter(typeof(HealthStatus));
        }

        /// <summary>
        /// Method to load data grid view
        /// </summary>
        /// <param name="data">data table</param>
        private void LoadDataGridView(DataTable data)
        {
            // Data grid view column setting            
            dataGridViewMembers.DataSource = data;
            dataGridViewMembers.DataMember = data.TableName;
        }

        ///// <summary>
        ///// Method to set up the printing
        ///// </summary>
        ///// <param name="isPrint">isPrint value</param>
        ///// <returns>true or false</returns>
        //private bool SetupPrinting(bool isPrint)
        //{
        //    PrintDialog printDialog = new PrintDialog();
        //    printDialog.AllowCurrentPage = false;
        //    printDialog.AllowPrintToFile = false;
        //    printDialog.AllowSelection = false;
        //    printDialog.AllowSomePages = false;
        //    printDialog.PrintToFile = false;
        //    printDialog.ShowHelp = false;
        //    printDialog.ShowNetwork = false;

        //    if (isPrint)
        //    {
        //        if (printDialog.ShowDialog() != DialogResult.OK)
        //        {
        //            return false;
        //        }
        //    }

        //    this.PrintReport.DocumentName = "MembersReport";
        //    this.PrintReport.PrinterSettings = printDialog.PrinterSettings;
        //    this.PrintReport.DefaultPageSettings = printDialog.PrinterSettings.DefaultPageSettings;
        //    this.PrintReport.DefaultPageSettings.Margins = new Margins(40, 40, 40, 40);
        //    //this.dataGridViewPrinter = new DataGridViewPrinter(dataGridViewMembers, PrintReport, true, true, Resources.Report_Header, new Font("Tahoma", 13, FontStyle.Bold, GraphicsUnit.Point), Color.Black, true);
        //    return true;
        //}

        /// <summary>
        /// Click event to handle registration
        /// </summary>
        /// <param name="sender">sender object</param>
        /// <param name="e">event data</param>
        private void Register_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if the validation passes
                if (this.ValidateRegistration())
                {
                    // Assign the values to the model
                    ClubMemberModel clubMemberModel = new ClubMemberModel()
                    {
                        Id = 0,
                        Name = txtName.Text.Trim(),
                        DateOfBirth = dtDateOfBirth.Value,
                        Occupation = (Occupation)cmbOccupation.SelectedValue,
                        HealthStatus = (HealthStatus)cmbHealthStatus.SelectedValue,
                        MaritalStatus = (MaritalStatus)cmbMaritalStatus.SelectedValue,
                        Salary = txtSalary.Text.Trim() == string.Empty ? 0 : Convert.ToDecimal(txtSalary.Text),
                        NumberOfChildren = txtNoOfChildren.Text.Trim() == string.Empty ? 0 : Convert.ToInt16(txtNoOfChildren.Text)
                    };

                    // Call the service method and assign the return status to variable
                    var success = this.clubMemberService.RegisterClubMember(clubMemberModel);

                    // if status of success variable is true then display a information else display the error message
                    if (success)
                    {
                        // display the message box
                        MessageBox.Show(
                            Resources.Registration_Successful_Message,
                            Resources.Registration_Successful_Message_Title,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        // Reset the screen
                        this.ResetRegistration();
                    }
                    else
                    {
                        // display the error messge
                        MessageBox.Show(
                            Resources.Registration_Error_Message,
                            Resources.Registration_Error_Message_Title,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // Display the validation failed message
                    MessageBox.Show(
                        this.errorMessage,
                        Resources.Registration_Error_Message_Title,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                this.ShowErrorMessage(ex);
            }
        }

        /// <summary>
        /// Key press Event to accept only numeric value
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">key press event data</param>
        private void Salary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Key press Event to accept only numeric value
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">event data</param>
        private void Children_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Event to handle tab selection
        /// </summary>
        /// <param name="sender">sender object</param>
        /// <param name="e">event data</param>
        private void Tab_SelectedPageChanged(object sender, EventArgs e)
        {
            try
            {
                if (tab.Pages.IndexOf(tab.SelectedPage) == 1)
                {
                    DataTable data = this.clubMemberService.GetAllClubMembers();
                    this.InitializeUpdate();
                    this.LoadDataGridView(data);
                }
            }
            catch (Exception ex)
            {
                this.ShowErrorMessage(ex);
            }
        }

        private void DataGridViewMembers_ViewRowFormatting(object sender, Telerik.WinControls.UI.RowFormattingEventArgs e)
        {
            if (e.RowElement is Telerik.WinControls.UI.GridTableHeaderRowElement)
            {
                e.RowElement.Font = new Font("Tahoma", 9, FontStyle.Bold, GraphicsUnit.Point);
            }
        }

        private void DataGridViewMembers_PrintCellFormatting(object sender, Telerik.WinControls.UI.PrintCellFormattingEventArgs e)
        {
            if (e.Row is GridViewTableHeaderRowInfo)
                return;

            if (e.Column is GridViewDataColumn dataColumn && dataColumn.DataTypeConverter is IntToEnumConverter)
            {
                e.PrintCell.Text = dataColumn.DataTypeConverter.ConvertToString(int.Parse(e.PrintCell.Text));
            }
        }

        /// <summary>
        /// Event to handle the data formatting in data grid view
        /// </summary>
        /// <param name="sender">sender object</param>
        /// <param name="e">event data</param>
        private void DataGridView_CellFormatting(object sender, Telerik.WinControls.UI.CellFormattingEventArgs e)
        {
            //try
            //{
            //    if (e.ColumnIndex == 2)
            //    {
            //        e.CellElement.Value = string.Format("{0:dd/MM/yyyy}", (DateTime)e.CellElement.RowInfo.Cells[2].Value);
            //    }

                //if (e.ColumnIndex == 3)
                //{
                //    e.CellElement.Value = Enum.GetName(typeof(Occupation), e.CellElement.RowInfo.Cells[3].Value);
                //}

                //if (e.ColumnIndex == 4)
                //{
                //    e.CellElement.Value = Enum.GetName(typeof(MaritalStatus), e.CellElement.RowInfo.Cells[4].Value);
                //}

                //if (e.ColumnIndex == 5)
                //{
                //    e.CellElement.Value = Enum.GetName(typeof(HealthStatus), e.CellElement.RowInfo.Cells[5].Value);
                //}

                //if (e.ColumnIndex == 6)
                //{
                //    e.CellElement.Value = Convert.ToDecimal(e.CellElement.Value) == 0 ? string.Empty : e.CellElement.Value;
                //}

                //if (e.ColumnIndex == 7)
                //{
                //    e.CellElement.Value = Convert.ToInt16(e.CellElement.Value) == 0 ? string.Empty : e.CellElement.Value;
                //}
            //}
            //catch (Exception ex)
            //{
            //    this.ShowErrorMessage(ex);
            //}
        }

        /// <summary>
        /// Click event to handle search
        /// </summary>
        /// <param name="sender">sender object</param>
        /// <param name="e">event data</param>
        private void Search_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable data = this.clubMemberService.SearchClubMembers(cmbSearchOccupation.SelectedValue, cmbSearchMaritalStatus.SelectedValue, cmbOperand.SelectedItem.Text);
                this.LoadDataGridView(data);
            }
            catch (Exception ex)
            {
                this.ShowErrorMessage(ex);
            }
        }

        /// <summary>
        /// Click event to handle the refresh
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">event data</param>
        private void Refresh_Click(object sender, EventArgs e)
        {
            try
            {
                this.ResetSearch();
                DataTable data = this.clubMemberService.GetAllClubMembers();
                this.LoadDataGridView(data);
            }
            catch (Exception ex)
            {
                this.ShowErrorMessage(ex);
            }
        }

        /// <summary>
        /// Click event to handle print preview
        /// </summary>
        /// <param name="sender">sender object</param>
        /// <param name="e">event data</param>
        private void PrintPreview_Click(object sender, EventArgs e)
        {
            this.dataGridViewMembers.PrintPreview();
            //try
            //{
            //    if (this.SetupPrinting(false))
            //    {
            //        PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            //        printPreviewDialog.Document = this.PrintReport;
            //        printPreviewDialog.ShowDialog();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    this.ShowErrorMessage(ex);
            //}
        }

        /// <summary>
        /// Click event to handle print
        /// </summary>
        /// <param name="sender">sender object</param>
        /// <param name="e">event data</param>
        private void Print_Click(object sender, EventArgs e)
        {
            this.dataGridViewMembers.Print(true);
            //try
            //{
            //    if (this.SetupPrinting(true))
            //    {
            //        this.PrintReport.Print();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    this.ShowErrorMessage(ex);
            //}
        }

        ///// <summary>
        ///// Event to handle print page
        ///// </summary>
        ///// <param name="sender">sender object</param>
        ///// <param name="e">event data</param>
        //private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        //{
        //    try
        //    {
        //        bool hasMorePages = this.dataGridViewPrinter.DrawDataGridView(e.Graphics);

        //        if (hasMorePages == true)
        //        {
        //            e.HasMorePages = true;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        this.ShowErrorMessage(ex);
        //    }
        //}

        /// <summary>
        /// Click event to handle the export to excel
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">event data</param>
        private void Export_Click(object sender, EventArgs e)
        {
            try
            {
                var table = (DataTable)dataGridViewMembers.DataSource;

                Microsoft.Office.Interop.Excel.Application excel
                    = new Microsoft.Office.Interop.Excel.Application();

                excel.Application.Workbooks.Add(true);

                int columnIndex = 0;

                foreach (DataColumn col in table.Columns)
                {
                    columnIndex++;
                    excel.Cells[1, columnIndex] = col.ColumnName;
                }

                int rowIndex = 0;

                foreach (DataRow row in table.Rows)
                {
                    rowIndex++;
                    columnIndex = 0;
                    foreach (DataColumn col in table.Columns)
                    {
                        columnIndex++;
                        if (columnIndex == 4 || columnIndex == 5 || columnIndex == 6)
                        {
                            if (columnIndex == 4)
                            {
                                excel.Cells[rowIndex + 1, columnIndex]
                                    = Enum.GetName(typeof(Occupation), row[col.ColumnName]);
                            }

                            if (columnIndex == 5)
                            {
                                excel.Cells[rowIndex + 1, columnIndex]
                                    = Enum.GetName(typeof(MaritalStatus), row[col.ColumnName]);
                            }

                            if (columnIndex == 6)
                            {
                                excel.Cells[rowIndex + 1, columnIndex]
                                    = Enum.GetName(typeof(HealthStatus), row[col.ColumnName]);
                            }
                        }
                        else
                        {
                            excel.Cells[rowIndex + 1, columnIndex] = row[col.ColumnName].ToString();
                        }
                    }
                }

                excel.Visible = true;
                Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)excel.ActiveSheet;
                worksheet.Activate();
            }
            catch (Exception ex)
            {
                this.ShowErrorMessage(ex);
            }
        }

        private void dataGridViewMembers_CellContentClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            int currentRow = dataGridViewMembers.SelectedCells[0].RowInfo.Index;
            MessageBox.Show("cell content click");
            try
            {
                string clubMemberId = dataGridViewMembers.Rows[currentRow].Cells[0].Value.ToString();
                memberId = int.Parse(clubMemberId);
            }
            catch (Exception ex)
            {

            }
        }

        /// <summary>
        /// Click event to update the data
        /// </summary>
        /// <param name="sender">sender object</param>
        /// <param name="e">event args</param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidateUpdate())
                {
                    ClubMemberModel clubMemberModel = new ClubMemberModel()
                    {
                        Id = this.memberId,
                        Name = txt2Name.Text.Trim(),
                        DateOfBirth = dt2DateOfBirth.Value,
                        Occupation = (Occupation)cmb2Occupation.SelectedValue,
                        HealthStatus = (HealthStatus)cmb2HealthStatus.SelectedValue,
                        MaritalStatus = (MaritalStatus)cmb2MaritalStatus.SelectedValue,
                        Salary = txt2Salary.Text.Trim() == string.Empty ? 0 : Convert.ToDecimal(txt2Salary.Text),
                        NumberOfChildren = txt2NoOfChildren.Text.Trim() == string.Empty ? 0 : Convert.ToInt16(txt2NoOfChildren.Text)
                    };

                    var flag = this.clubMemberService.UpdateClubMember(clubMemberModel);

                    if (flag)
                    {
                        DataTable data = this.clubMemberService.GetAllClubMembers();
                        this.LoadDataGridView(data);

                        MessageBox.Show(
                            Resources.Update_Successful_Message,
                            Resources.Update_Successful_Message_Title,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show(
                        this.errorMessage,
                        Resources.Registration_Error_Message_Title,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                this.ShowErrorMessage(ex);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var flag = this.clubMemberService.DeleteClubMember(this.memberId);

                if (flag)
                {
                    DataTable data = this.clubMemberService.GetAllClubMembers();
                    this.LoadDataGridView(data);

                    MessageBox.Show(
                        Resources.Delete_Successful_Message,
                        Resources.Delete_Successful_Message_Title,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                this.ShowErrorMessage(ex);
            }
        }

        private void dataGridViewMembers_SelectionChanged(object sender, EventArgs e)
        {
            Telerik.WinControls.UI.RadGridView dgv = (Telerik.WinControls.UI.RadGridView)sender;

            try
            {
                if (dgv.SelectedRows.Count > 0)
                {
                    string clubMemberId = dgv.SelectedRows[0].Cells[0].Value.ToString();
                    memberId = int.Parse(clubMemberId);

                    DataRow dataRow = this.clubMemberService.GetClubMemberById(memberId);

                    txt2Name.Text = dataRow["Name"].ToString();
                    dt2DateOfBirth.Value = Convert.ToDateTime(dataRow["DateOfBirth"]);
                    cmb2Occupation.SelectedValue = dataRow.Field<Occupation>("Occupation");
                    cmb2MaritalStatus.SelectedValue = dataRow.Field<MaritalStatus>("MaritalStatus");
                    cmb2HealthStatus.SelectedValue = dataRow.Field<HealthStatus>("HealthStatus");
                    txt2Salary.Text = dataRow["Salary"].ToString() == "0.0000" ? string.Empty : dataRow["Salary"].ToString();
                    txt2NoOfChildren.Text = dataRow["NumberOfChildren"].ToString();
                }
            }
            catch (Exception ex)
            {
                this.ShowErrorMessage(ex);
            }
        }


    }

    public class IntToEnumConverter : TypeConverter
    {
        public IntToEnumConverter(Type enumType)
        {
            this.EnumType = enumType;
        }

        public Type EnumType { get; private set; }

        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            return sourceType == typeof(int) || sourceType == typeof(string);
        }

        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            if (value is int)
            {
                return Enum.GetName(EnumType, value);
            }
            else
            {
                return Enum.Parse(EnumType, (string)value);
            }
        }

        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
        {
            return destinationType == typeof(int) || destinationType == typeof(string);
        }

        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            if (value is int && destinationType == typeof(string))
            {
                return Enum.GetName(EnumType, value);
            }
            else if (value is string && destinationType == typeof(int))
            {
                return Enum.Parse(EnumType, (string)value);
            }
            return base.ConvertTo(context, culture, value, destinationType);
        }
    }
}
