using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bcs.LogicalTree.LogicalTreeControlLibrary.Data_Layer
{
   class Data_Layer
   {
      static public string arcConnectionString = "Data Source=BCSWS7;Initial Catalog=\"Ancient Roman Coins\";Integrated Security=True";
      static public string ltConnectionString = "Data Source=BCSWS7;Initial Catalog=\"LogicalTree\";Integrated Security=True";


      public static bool ExecuteStoredProcedure(string storedProcedureString, List<SqlParameter> lstParameters, string connectionString)
      {
         bool successfulStoredProcedureExecution = false;

         if (string.IsNullOrEmpty(storedProcedureString) || lstParameters == null)
         {
            return successfulStoredProcedureExecution;
         }

         SqlConnection conn = new SqlConnection(connectionString);
         SqlCommand comm = new SqlCommand(storedProcedureString, conn);

         comm.CommandType = System.Data.CommandType.StoredProcedure;

         for (int i = 0; i < lstParameters.Count; i++)
         {
            comm.Parameters.Add(lstParameters[i]);
         }

         try
         {
            conn.Open();
            comm.ExecuteNonQuery();
            successfulStoredProcedureExecution = true;
         }
         catch (Exception ex)
         {
            successfulStoredProcedureExecution = false;
         }
         finally
         {
            conn.Close();
            conn.Dispose();
            comm.Dispose();
         }

         return successfulStoredProcedureExecution;
      }


      public static bool InsertTypeRecord(string formattedInsertString, string connectionString)
      {
         bool insertSuccessful = false;

         if (string.IsNullOrEmpty(formattedInsertString))
         {
            return insertSuccessful;
         }

         SqlConnection conn = new SqlConnection(connectionString);
         SqlCommand comm = new SqlCommand(formattedInsertString, conn);

         try
         {
            conn.Open();
            comm.ExecuteNonQuery();
            insertSuccessful = true;
         }
         catch (Exception ex)
         {
            insertSuccessful = false;
         }
         finally
         {
            conn.Close();
            conn.Dispose();
            comm.Dispose();
         }

         return insertSuccessful;
      }

      public static bool UpdateTypeRecord(string formattedUpdateString, string connectionString)
      {
         bool updateSuccessful = false;

         if (string.IsNullOrEmpty(formattedUpdateString))
         {
            return updateSuccessful;
         }

         SqlConnection conn = new SqlConnection(connectionString);
         SqlCommand comm = new SqlCommand(formattedUpdateString, conn);

         try
         {
            conn.Open();
            comm.ExecuteNonQuery();
            updateSuccessful = true;
         }
         catch
         {
            updateSuccessful = false;
         }
         finally
         {
            conn.Close();
            conn.Dispose();
            comm.Dispose();
         }

         return updateSuccessful;
      }

      public static bool DeleteTypeRecord(string formattedDeleteString, string connectionString)
      {
         bool deleteSuccessful = false;

         if (string.IsNullOrEmpty(formattedDeleteString))
         {
            return deleteSuccessful;
         }

         SqlConnection conn = new SqlConnection(connectionString);
         SqlCommand comm = new SqlCommand(formattedDeleteString, conn);

         try
         {
            conn.Open();
            comm.ExecuteNonQuery();
            deleteSuccessful = true;
         }
         catch
         {
            deleteSuccessful = false;
         }
         finally
         {
            conn.Close();
            conn.Dispose();
            comm.Dispose();
         }

         return deleteSuccessful;
      }
   }
}
