// <copyright file="GlobalSuppressions.cs" company="Microsoft">
//     Copyright (c) . All rights reserved.
// </copyright>
// This file is used by Code Analysis to maintain SuppressMessage 
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given 
// a specific target and scoped to a namespace, type, member, etc.
//
// To add a suppression to this file, right-click the message in the 
// Code Analysis results, point to "Suppress Message", and click 
// "In Suppression File".
// You do not need to add suppressions to this file manually.
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1303:Do not pass literals as localized parameters", MessageId = "System.Console.WriteLine(System.String)", Scope = "member", Target = "Microsoft.Legal.MatterCenter.CreateContentTypes.Program.#CreateContentType(Microsoft.SharePoint.Client.ClientContext,System.String,System.String,System.String)", Justification = "Suppressing since code will not be localized")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1303:Do not pass literals as localized parameters", MessageId = "System.Console.WriteLine(System.String)", Scope = "member", Target = "Microsoft.Legal.MatterCenter.CreateContentTypes.Program.#DeleteContentType(Microsoft.SharePoint.Client.ClientContext,System.String)", Justification = "Suppressing since code will not be localized")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Microsoft.Legal.MatterCenter.CreateContentTypes.Program.#CreateContentType(Microsoft.SharePoint.Client.ClientContext,System.String,System.String,System.String)", Justification = "Exception message is logged on console")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Microsoft.Legal.MatterCenter.CreateContentTypes.Program.#DeleteContentType(Microsoft.SharePoint.Client.ClientContext,System.String)", Justification = "Exception message is logged on console")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1014:MarkAssembliesWithClsCompliant", Justification = "Assembly cannot be markes as CLS compliant")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member", Target = "Microsoft.Legal.MatterCenter.CreateContentTypes.Program.#CreateContentType(Microsoft.SharePoint.Client.ClientContext,System.String,System.String,System.String)", Justification = "If context is not created, exception is logged")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member", Target = "Microsoft.Legal.MatterCenter.CreateContentTypes.Program.#DeleteContentType(Microsoft.SharePoint.Client.ClientContext,System.String)", Justification = "If context is not created, exception is logged")]