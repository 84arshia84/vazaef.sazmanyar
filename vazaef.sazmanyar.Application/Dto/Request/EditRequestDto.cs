﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vazaef.sazmanyar.Application.Dto.Request
{
    public class EditRequestDto
    {
        [Required]
        public string RequestTitle { get; set; }
        public long RequestingDepartmentId { get; set; }
        public long RequestTypeId { get; set; }
        public long FundingSourceId { get; set; }
        public int year { get; set; }
        public string ServiceDescription { get; set; }

    }
}
