﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRM.Core.Protocol.Base
{
    public enum FieldType
    {
        String,
        Int,
    }

    public class ExtendOption : NotifyPropertyChangedBase, ICloneable
    {

        private string _fieldName = "";
        public string FieldName
        {
            get => _fieldName;
            set => SetAndNotifyIfChanged(ref _fieldName, value);
        }


        private FieldType _type = FieldType.String;
        public FieldType Type
        {
            get => _type;
            set => SetAndNotifyIfChanged(ref _type, value);
        }

        private string _fieldValue = "";
        public string FieldValue
        {
            get => _fieldValue;
            set => SetAndNotifyIfChanged(ref _fieldValue, value);
        }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
