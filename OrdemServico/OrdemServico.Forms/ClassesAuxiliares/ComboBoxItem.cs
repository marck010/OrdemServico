﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdemServico.Forms.ClassesAuxiliares
{
    public class ComboBoxItem
    {
        public String Value { get; set; }
        public String Text { get; set; }
        public override string ToString()
        {
            return Text;
        }
    }
}
