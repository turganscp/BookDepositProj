﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace BookDeposit2
{
    class DataBaseManger
    {
        private string GetConnectionString()
        {
            return "Data Source=den1.mssql8.gear.host; Initial Catalog=hvidvarer22; User Id=hvidvarer22; Password=Lb8qw~vq~B0X";
        }

        public void InsertRPGBOOK(RPGBook r)
        {
            string InsertSqlString = $"Insert into RPGBooks (Title, Author, Genre, Pages, ISBN)" +
                $"values('{r.Title}', '{r.Author}', '{r.Genre}', '{r.Pages}', '{r.ISBN}')";
            Console.WriteLine(InsertSqlString); //test to see if the string I send to the database is correct.

            SqlConnection conn = new SqlConnection(GetConnectionString());
            conn.Open();
            SqlCommand com = new SqlCommand(InsertSqlString, conn);
            com.ExecuteNonQuery();

            conn.Close();
        }


    }
}
