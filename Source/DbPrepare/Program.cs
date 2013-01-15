﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MundlTransit.WP8.Data.Reference;

namespace DbPrepare
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = ReferenceDataContext.CreateConnection();

            ReferenceDataContext.InitializeDatabase(db);

            //var importer = new CreateCamp.HaltestellenImporter();
            //importer.Import(db);

            var importer = new Qando.HaltestellenImporter();
            importer.Import(db);
        }
    }
}