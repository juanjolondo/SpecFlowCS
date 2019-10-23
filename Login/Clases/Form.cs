using System;
using System.Collections.Generic;
using System.Text;

namespace Clases
{
    public class Form
    {
        public String name { get; set; }
        public String lastName { get; set; }
        public int age { get; set; }

        public String send()
        {
            // Save the data
            bool resultSave = true;
            if (resultSave)
            {
                return "correct";
            }
            else
            {
                return "wrong";
            }
        }
    }
}
