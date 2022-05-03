using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace MVC_Assignment2.Models
{
    public class BusInformationDetails
    {
     
        public void AddBusInformation(BusInformation busInformation)
        {
            string connect = ConfigurationManager.ConnectionStrings["BusInformation"].ConnectionString;


            using(SqlConnection conn = new SqlConnection(connect))
            {
                
                SqlCommand cmd = new SqlCommand("Insert_BusInformation", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paraBoardingPoint = new SqlParameter();
                paraBoardingPoint.ParameterName = "@BoardingPoint";
                paraBoardingPoint.Value = busInformation.BoardingPoint;
                cmd.Parameters.Add(paraBoardingPoint);

                SqlParameter paraTravelDate = new SqlParameter();
                paraTravelDate.ParameterName = "@TravelDate";
                paraTravelDate.Value = busInformation.TravelDate;
                cmd.Parameters.Add(paraTravelDate);

                SqlParameter paraAmount = new SqlParameter();
                paraAmount.ParameterName = "@Amount";
                paraAmount.Value = busInformation.Amount;
                cmd.Parameters.Add(paraAmount);

                SqlParameter paraRating = new SqlParameter();
                paraRating.ParameterName = "@Rating";
                paraRating.Value = busInformation.Rating;
                cmd.Parameters.Add(paraRating);

                SqlParameter paraDroppingPoint = new SqlParameter();
                paraDroppingPoint.ParameterName = "@DroppingPoint";
                paraDroppingPoint.Value= busInformation.DroppingPoint;
                cmd.Parameters.Add(paraDroppingPoint);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}