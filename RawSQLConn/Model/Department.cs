﻿namespace RawSQLConn.Model
{
    public class Department : EntityBase
    {
        public Int64 Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
