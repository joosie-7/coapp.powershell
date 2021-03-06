﻿//-----------------------------------------------------------------------
// <copyright company="CoApp Project">
//     Copyright (c) 2010-2013 Garrett Serack and CoApp Contributors. 
//     Contributors can be discovered using the 'git log' command.
//     All rights reserved.
// </copyright>
// <license>
//     The software is licensed under the Apache 2.0 License (the "License")
//     You may not use the software except in compliance with the License. 
// </license>
//-----------------------------------------------------------------------

namespace ClrPlus.Scripting.Exceptions {
    using Core.Exceptions;
    using Core.Extensions;
    using Languages.PropertySheet;

    public class EndUserRuleException : ClrPlusException {
        public Rule Rule;

        public EndUserRuleException(Rule rule, string errorcode, string message, params object[] parameters)
            : base("{0}({1},{2}):{3}:{4}".format(rule.SourceLocation.SourceFile, rule.SourceLocation.Row, rule.SourceLocation.Column, errorcode, message.format(parameters))) {
            Rule = rule;
        }
    }
}