﻿using AutoMapper;
using jeamin.Entities.Report;
using jeamin.Entities.Search.Report;
using jeamin.Interface.DbContext;
using jeamin.Interface.Services.Report;
using jeamin.Interface.UnitOfWork;
using jeamin.Service.Services.DomainServices;
using jeamin.Utilities;
using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace jeamin.Service.Services.Report
{
    public class MainOrderReportService : ReportService<MainOrderReport, MainOrderReportSearch>, IMainOrderReportService
    {
        public MainOrderReportService(IAppUnitOfWork unitOfWork, IMapper mapper, IAppDbContext context) : base(unitOfWork, mapper, context)
        {
        }

        protected override string GetStoreProcName()
        {
            return "Report_MainOrder";
        }

        public virtual async Task<List<MainOrderReportOverView>> GetRevenueOverview(MainOrderReportSearch baseSearch)
        {
            List<MainOrderReportOverView> pagedList = new List<MainOrderReportOverView>();
            SqlParameter[] parameters = GetSqlParameters(baseSearch);
            pagedList = await ExcuteQueryRevenueOverview("Report_MainOrderOverView", parameters);  
            return pagedList;
        }

        public virtual Task<List<MainOrderReportOverView>> ExcuteQueryRevenueOverview(string commandText, SqlParameter[] sqlParameters)
        {
            return Task.Run(() =>
            {
                List<MainOrderReportOverView> pagedList = new List<MainOrderReportOverView>();
                DataTable dataTable = new DataTable();
                SqlConnection connection = null;
                SqlCommand command = null;
                try
                {
                    connection = (SqlConnection)Context.Database.GetDbConnection();
                    command = connection.CreateCommand();
                    connection.Open();
                    command.CommandText = commandText;
                    command.Parameters.AddRange(sqlParameters);
                    command.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
                    
                    sqlDataAdapter.Fill(dataTable);
                    pagedList = MappingDataTable.ConvertToList<MainOrderReportOverView>(dataTable);
                   // if (pagedList.Items != null && pagedList.Items.Any())
                        //pagedList.TotalItem = pagedList.Items.FirstOrDefault().TotalItem;
                    return pagedList;
                }
                finally
                {
                    if (connection != null && connection.State == System.Data.ConnectionState.Open)
                        connection.Close();

                    if (command != null)
                        command.Dispose();
                }
            });
        }
    }
}
