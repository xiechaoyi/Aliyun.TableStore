﻿using System.Collections.Generic;

namespace Aliyun.TableStore.DataModel.Search.Sort
{
    public class Sort
    {
        public List<ISorter> Sorters { get; set; }

        public Sort(List<ISorter> sorters)
        {
            this.Sorters = sorters;
        }
    }
}
