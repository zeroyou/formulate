﻿namespace formulate.app.Forms.Fields.Hidden
{
    using System;
    public class HiddenField : IFormFieldType
    {
        public string Directive => "formulate-hidden-field";
        public string TypeLabel => "Hidden";
        public string Icon => "icon-formulate-hidden";
        public Guid TypeId => new Guid("3DF6FACD2FFA4055B0BE94E8FA8E7C4A");
        public object DeserializeConfiguration(string configuration)
        {
            return null;
        }
    }
}