using MultiColoredModernUI.Forms.Subway;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiColoredModernUI.Forms.DashBoard
{
    class MssqlDashBoard
    {
        SqlConnection sqlConnect;
        SqlCommand cmd;

        public void Connect()
        {
            sqlConnect = new SqlConnection("Server=218.234.32.245,5242; Database=AID_TOOL; uid=sa; pwd=yasdo12!@");

            sqlConnect.Open();

        }


        public void RegionData()
        {
            Connect();

            SqlDataAdapter da = new SqlDataAdapter("usp_C001_02_RegionData", sqlConnect);

            DataSet ds = new DataSet();
          
            da.Fill(ds);

            if (ds.Tables.Count > 0)
            {

                for(int i = 0; i < ds.Tables.Count; i++)
                {
                    foreach (DataRow dr in ds.Tables[i].Rows)
                    {
                        
                        StaticDashBoard.dashBoard_RegionData.Add(dr[0].ToString());
                    }

                }
                
            }

            //연결종료

            sqlConnect.Close();
        }

        public void RegionDataView(int index)
        {
            Connect();

            string strSql = "";

            strSql = string.Format("select * from ufn_C001_02_TBDataView({0})", index);

            cmd = new SqlCommand(strSql, sqlConnect);

            SqlDataReader reader = cmd.ExecuteReader();

            StaticDashBoard.regionData.Clear();
            StaticDashBoard.regionDatas.Clear();

            while (reader.Read())
            {
                if(index > 0)
                {
                    StaticDashBoard.regionData.Add(reader["RegionSub"].ToString());
                    StaticDashBoard.regionData.Add(reader["RegionIndex"].ToString());
                    StaticDashBoard.regionData.Add(reader["Region"].ToString());
                }
                else
                {
                    StaticDashBoard.regionData.Add(reader["Region"].ToString());
                    StaticDashBoard.regionData.Add(reader["RegionIndex"].ToString());
                    StaticDashBoard.regionData.Add(reader["RegionSub"].ToString());
                }


                StaticDashBoard.regionData.Add(reader["RegionSubIndex"].ToString());
                StaticDashBoard.regionData.Add(reader["CityBusStation"].ToString());
                StaticDashBoard.regionData.Add(reader["CityBusRoute"].ToString());
                StaticDashBoard.regionData.Add(reader["VillageBusRoute"].ToString());
                StaticDashBoard.regionData.Add(reader["AirportBusStation"].ToString());
                StaticDashBoard.regionData.Add(reader["AirportBusRoute"].ToString());
                StaticDashBoard.regionData.Add(reader["InterBusStation"].ToString());
                StaticDashBoard.regionData.Add(reader["InterBusRoute"].ToString());
                StaticDashBoard.regionData.Add(reader["ExpressBusStation"].ToString());
                StaticDashBoard.regionData.Add(reader["ExpressBusRoute"].ToString());
                StaticDashBoard.regionData.Add(reader["SubwayStation"].ToString());
                StaticDashBoard.regionData.Add(reader["SubwayRoute"].ToString());
                StaticDashBoard.regionData.Add(reader["TrainStation"].ToString());
                StaticDashBoard.regionData.Add(reader["TrainRoute"].ToString());
                StaticDashBoard.regionData.Add(reader["AirplaneStation"].ToString());
                StaticDashBoard.regionData.Add(reader["AirplaneRoute"].ToString());

                StaticDashBoard.regionDatas.Add(StaticDashBoard.regionData.ToList());
                StaticDashBoard.regionData.Clear();

            }

            //연결종료
            reader.Close();
            sqlConnect.Close();
        }

        public void UpdateDataView(int index)
        {
            Connect();

            string strSql = "";

            strSql = string.Format("select * from ufn_C001_02_TBDataView({0})", index);

            cmd = new SqlCommand(strSql, sqlConnect);

            SqlDataReader reader = cmd.ExecuteReader();

            StaticDashBoard.regionData.Clear();
            StaticDashBoard.regionDatas.Clear();

            while (reader.Read())
            {
                if (index > 0)
                {
                    StaticDashBoard.regionData.Add(reader["RegionSub"].ToString());
                    StaticDashBoard.regionData.Add(reader["RegionIndex"].ToString());
                    StaticDashBoard.regionData.Add(reader["Region"].ToString());
                }
                else
                {
                    StaticDashBoard.regionData.Add(reader["Region"].ToString());
                    StaticDashBoard.regionData.Add(reader["RegionIndex"].ToString());
                    StaticDashBoard.regionData.Add(reader["RegionSub"].ToString());
                }

                StaticDashBoard.regionDatas.Add(StaticDashBoard.regionData.ToList());
                StaticDashBoard.regionData.Clear();

            }

            //연결종료
            reader.Close();
            sqlConnect.Close();
        }

        public void DataManegementView(int jobCode, int searchType, string search)
        {
            Connect();

            string strSql = "";

            if (search != "")
                search = "%" + search + "%";

            strSql = string.Format("select  * from ufn_C001_01_TBDataManegementView({0},{1},'{2}') order by updatedAt desc", jobCode, searchType, search);

            cmd = new SqlCommand(strSql, sqlConnect);

            SqlDataReader reader = cmd.ExecuteReader();

            StaticDashBoard.dashBoard_DataMenegement.Clear();
            StaticDashBoard.dashBoard_DataMenegements.Clear();

            while (reader.Read())
            {

                StaticDashBoard.dashBoard_DataMenegement.Add(reader["CityName"].ToString());
                StaticDashBoard.dashBoard_DataMenegement.Add(reader["transportType"].ToString());
                StaticDashBoard.dashBoard_DataMenegement.Add(reader["transportName"].ToString());
                StaticDashBoard.dashBoard_DataMenegement.Add(reader["jobCode"].ToString());
                StaticDashBoard.dashBoard_DataMenegement.Add(reader["jobName"].ToString());
                StaticDashBoard.dashBoard_DataMenegement.Add(reader["CityCode"].ToString());
                
                StaticDashBoard.dashBoard_DataMenegement.Add(Convert.ToDateTime(reader["collectedAt"]).ToString("yyyy-MM-dd"));
                StaticDashBoard.dashBoard_DataMenegement.Add(Convert.ToDateTime(reader["updatedAt"]).ToString("yyyy-MM-dd"));
                StaticDashBoard.dashBoard_DataMenegement.Add(reader["comment"].ToString());
                StaticDashBoard.dashBoard_DataMenegements.Add(StaticDashBoard.dashBoard_DataMenegement.ToList());
                StaticDashBoard.dashBoard_DataMenegement.Clear();

            }

            reader.Close();
            sqlConnect.Close();

        }

        public void UpdateDateStatus(int index)
        {
            Connect();

            string strSql = "";

            strSql = string.Format(
                "select * from ( " +
                    "select serviceName, Cast(Month(updateDate) as varchar) + '/' + cast(day(updateDate) as varchar) as updateDate, " +
                    "row_number() over(partition by serviceName " +
                    "order by serviceName, updateDate desc) as num " +
                "from[dbo].[TBService_Update_Date]) as a " +
                "where num = 1");

            cmd = new SqlCommand(strSql, sqlConnect);

            SqlDataReader reader = cmd.ExecuteReader();

            StaticDashBoard.updateDate.Clear();
            StaticDashBoard.updateDates.Clear();

            while (reader.Read())
            {

                StaticDashBoard.updateDate.Add(reader["serviceName"].ToString());
                StaticDashBoard.updateDate.Add(reader["updateDate"].ToString());

                

                StaticDashBoard.updateDates.Add(StaticDashBoard.updateDate.ToList());
                StaticDashBoard.updateDate.Clear();

            }

            //연결종료
            reader.Close();
            sqlConnect.Close();
        }


    }
}
