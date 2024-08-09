using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleMAUI
{
    internal class CustomisedEntry:Entry
    {
        internal CustomisedEntry()
        {
            IsSpellCheckEnabled = false;
            IsTextPredictionEnabled = false;
        }
    }
}
