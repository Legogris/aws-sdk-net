﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 14.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace ServiceClientGenerator.Generators.SourceFiles
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    public partial class ServiceInterface : BaseGenerator
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            
            #line 6 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface.tt"

	AddLicenseHeader();

            
            #line default
            #line hidden
            this.Write("\r\n\r\nusing System;\r\nusing System.Collections.Generic;\r\n\r\nusing Amazon.Runtime;\r\nus" +
                    "ing ");
            
            #line 15 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.Namespace));
            
            #line default
            #line hidden
            this.Write(".Model;\r\n\r\nnamespace ");
            
            #line 17 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.Namespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n");
            
            #line 19 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface.tt"
    this.FormatServiceInterfaceDocumentation(this.Config.ServiceModel.Documentation); 
            
            #line default
            #line hidden
            this.Write("\tpublic partial interface IAmazon");
            
            #line 20 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.BaseName));
            
            #line default
            #line hidden
            this.Write(" : IAmazonService, IDisposable\r\n\t{\r\n\r\n\t\t");
            
            #line 23 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface.tt"

		foreach(var operation in this.Config.ServiceModel.Operations)
		{
            if(operation.IsInternal)
                continue;
		
            
            #line default
            #line hidden
            this.Write("\r\n\t\t#region  ");
            
            #line 30 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("\r\n\r\n");
            
            #line 32 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface.tt"

        // Creates a method for the operation that takes no parameters if the operation has a request that requires no members to be set
        if (this.Config.ServiceModel.Customizations.CreateNoArgOverload(operation.Name))
        {

            
            #line default
            #line hidden
            
            #line 37 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface.tt"

        this.FormatOperationDocumentationSync(operation, false);
		if(operation.IsDeprecated)
		{

            
            #line default
            #line hidden
            this.Write("\t\t[Obsolete(\"");
            
            #line 42 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.DeprecationMessage));
            
            #line default
            #line hidden
            this.Write("\")]\r\n");
            
            #line 43 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface.tt"
		
		}

            
            #line default
            #line hidden
            this.Write("        ");
            
            #line 46 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("Response ");
            
            #line 46 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("();\r\n");
            
            #line 47 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface.tt"

        }

        AddSimpleClientMethodInterfaces(operation, true);

            
            #line default
            #line hidden
            
            #line 52 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface.tt"

        this.FormatOperationDocumentationSync(operation, true);
		if(operation.IsDeprecated)
		{

            
            #line default
            #line hidden
            this.Write("\t\t[Obsolete(\"");
            
            #line 57 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.DeprecationMessage));
            
            #line default
            #line hidden
            this.Write("\")]\r\n");
            
            #line 58 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface.tt"
		
		}

            
            #line default
            #line hidden
            this.Write("        ");
            
            #line 61 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("Response ");
            
            #line 61 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("(");
            
            #line 61 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("Request request);\r\n\r\n");
            
            #line 63 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface.tt"
AddBeginAsyncDocumentation(operation.Name);
		if(operation.IsDeprecated)
		{

            
            #line default
            #line hidden
            this.Write("\t\t[Obsolete(\"");
            
            #line 67 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.DeprecationMessage));
            
            #line default
            #line hidden
            this.Write("\")]\r\n");
            
            #line 68 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface.tt"
		
		}

            
            #line default
            #line hidden
            this.Write("        IAsyncResult Begin");
            
            #line 71 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("(");
            
            #line 71 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("Request request, AsyncCallback callback, object state);\r\n\r\n\r\n\r\n");
            
            #line 75 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface.tt"
AddEndAsyncDocumentation(operation.Name);
		if(operation.IsDeprecated)
		{

            
            #line default
            #line hidden
            this.Write("\t\t[Obsolete(\"");
            
            #line 79 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.DeprecationMessage));
            
            #line default
            #line hidden
            this.Write("\")]\r\n");
            
            #line 80 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface.tt"
		
		}

            
            #line default
            #line hidden
            this.Write("        ");
            
            #line 83 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("Response End");
            
            #line 83 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("(IAsyncResult asyncResult);\r\n\r\n\t\t#endregion\r\n\t\t");
            
            #line 86 "C:\codebase\v3\AWSDotNetPublic\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceInterface.tt"

		}
		
            
            #line default
            #line hidden
            this.Write("\r\n    }\r\n}");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
