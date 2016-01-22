﻿using BizTalkComponents.Utils;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizTalkComponents.PipelineComponents.ExtractZip
{
    public partial class ExtractZip
    {
        public string Name { get { return "ExtractZip"; } }
        public string Version { get { return "1.0"; } }
        public string Description { get { return "This component is used to extract the content files of a zip file"; } }
      
        public void InitNew() { }

        public IEnumerator Validate(object projectSystem)
        {
            return ValidationHelper.Validate(this, false).ToArray().GetEnumerator();
        }

        public bool Validate(out string errorMessage)
        {
            var errors = ValidationHelper.Validate(this, true).ToArray();

            if (errors.Any())
            {
                errorMessage = string.Join(",", errors);

                return false;
            }

            errorMessage = string.Empty;

            return true;
        }
        
        public IntPtr Icon { get { return IntPtr.Zero; } }
    }
}
