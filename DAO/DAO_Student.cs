﻿using Dapper;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAO_Student : DBConnect
    {
        public List<Student> GetAll()
        {
            DBConnect _dbContext = new DBConnect();
            using (IDbConnection _dbConnection = _dbContext.CreateConnection())
            { 
                var output = _dbConnection.Query<Student>($"select * from STUDENT").ToList();
                return output;
            }
        }
    }
}
