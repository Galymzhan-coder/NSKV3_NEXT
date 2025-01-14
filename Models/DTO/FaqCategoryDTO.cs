﻿using Models.DTO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Mysqlx.Notice.Warning.Types;

namespace Models.DTO
{
    public class FaqCategoryDTO : IDto
    {
       
        public int id { get; set; }

        public uint? parent_id { get; set; }

        public string? title { get; set; }

        public string sefname { get; set; } = null!;

        public bool is_active { get; set; }

        public DateTime create_date { get; set; }

        public DateTime update_date { get; set; }

        public uint? product_id { get; set; }

        public void SetDefaultValues()
        {
            id = 0;

            parent_id = 0;

            title = string.Empty;

            sefname = string.Empty;

            is_active = false;

            create_date = DateTime.MinValue;

            update_date = DateTime.MinValue;

            product_id = 0;
        }
    }
}
