﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ECSSR.UTILITY.Model
{
    public class EntityResponseModel<T>
    {
        public bool ReturnStatus { get; set; }
        public List<string> ReturnMessage { get; set; }
        public Hashtable Errors;
        public T Data;
        public EntityResponseModel()
        {
            ReturnMessage = new List<String>();
            ReturnStatus = true;
            Errors = new Hashtable();
            Data = default(T);
        }
    }
}
