#pragma checksum "C:\Users\Super Magic\OneDrive\سطح المكتب\C# Course\Asp Web\Aliaa-MVC\CompanyMVC\CompanyMVC\Views\User\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3b580c03812b0b0ef6901c7db001939b25833c02bc514854c8c4c342ae562cd1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Index), @"mvc.1.0.view", @"/Views/User/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 2 "C:\Users\Super Magic\OneDrive\سطح المكتب\C# Course\Asp Web\Aliaa-MVC\CompanyMVC\CompanyMVC\Views\_ViewImports.cshtml"
using BLL.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Super Magic\OneDrive\سطح المكتب\C# Course\Asp Web\Aliaa-MVC\CompanyMVC\CompanyMVC\Views\_ViewImports.cshtml"
using DAL.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Super Magic\OneDrive\سطح المكتب\C# Course\Asp Web\Aliaa-MVC\CompanyMVC\CompanyMVC\Views\_ViewImports.cshtml"
using CompanyMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Super Magic\OneDrive\سطح المكتب\C# Course\Asp Web\Aliaa-MVC\CompanyMVC\CompanyMVC\Views\_ViewImports.cshtml"
using CompanyMVC.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Super Magic\OneDrive\سطح المكتب\C# Course\Asp Web\Aliaa-MVC\CompanyMVC\CompanyMVC\Views\_ViewImports.cshtml"
using CompanyMVC.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"3b580c03812b0b0ef6901c7db001939b25833c02bc514854c8c4c342ae562cd1", @"/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"c44b26575396ed1d9abae9ecff90bedc8fada4e2e3fc54c8ba7c6ff86fe888a7", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<UserViewModel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("row offset-2 "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ButtonsPartialView", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Super Magic\OneDrive\سطح المكتب\C# Course\Asp Web\Aliaa-MVC\CompanyMVC\CompanyMVC\Views\User\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Super Magic\OneDrive\سطح المكتب\C# Course\Asp Web\Aliaa-MVC\CompanyMVC\CompanyMVC\Views\User\Index.cshtml"
 if(Model.Count() >0){
    

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"m-2\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b580c03812b0b0ef6901c7db001939b25833c02bc514854c8c4c342ae562cd15813", async() => {
                WriteLiteral(@"
            <div class=""col-8"">
                <input class=""form-control"" type=""text"" name=""SearchValue"" placeholder=""User's Name""></input>
            </div>

            <div class=""col-4"">
                <input type=""submit"" class=""btn btn-info"" value=""Search"" />
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n    <br />\r\n    <br />\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b580c03812b0b0ef6901c7db001939b25833c02bc514854c8c4c342ae562cd17718", async() => {
                WriteLiteral("\r\n<table class=\"table  table-hover\">\r\n    <thead>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\Super Magic\OneDrive\سطح المكتب\C# Course\Asp Web\Aliaa-MVC\CompanyMVC\CompanyMVC\Views\User\Index.cshtml"
           Write(Html.DisplayNameFor(U=>U.Id));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            <td>Name</td>\r\n            <td>");
#nullable restore
#line 27 "C:\Users\Super Magic\OneDrive\سطح المكتب\C# Course\Asp Web\Aliaa-MVC\CompanyMVC\CompanyMVC\Views\User\Index.cshtml"
           Write(Html.DisplayNameFor(U => U.Email));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 28 "C:\Users\Super Magic\OneDrive\سطح المكتب\C# Course\Asp Web\Aliaa-MVC\CompanyMVC\CompanyMVC\Views\User\Index.cshtml"
           Write(Html.DisplayNameFor(U => U.PhoneNumber));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 29 "C:\Users\Super Magic\OneDrive\سطح المكتب\C# Course\Asp Web\Aliaa-MVC\CompanyMVC\CompanyMVC\Views\User\Index.cshtml"
           Write(Html.DisplayNameFor(U => U.Roles));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            <td> </td>\r\n            <td>Edit</td>\r\n            <td>Details</td>\r\n            <td>Delete</td>\r\n            \r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n       \r\n");
#nullable restore
#line 39 "C:\Users\Super Magic\OneDrive\سطح المكتب\C# Course\Asp Web\Aliaa-MVC\CompanyMVC\CompanyMVC\Views\User\Index.cshtml"
         foreach(var item in Model)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr>\r\n                    <td>");
#nullable restore
#line 42 "C:\Users\Super Magic\OneDrive\سطح المكتب\C# Course\Asp Web\Aliaa-MVC\CompanyMVC\CompanyMVC\Views\User\Index.cshtml"
                   Write(item.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 43 "C:\Users\Super Magic\OneDrive\سطح المكتب\C# Course\Asp Web\Aliaa-MVC\CompanyMVC\CompanyMVC\Views\User\Index.cshtml"
                   Write(item.FName);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 43 "C:\Users\Super Magic\OneDrive\سطح المكتب\C# Course\Asp Web\Aliaa-MVC\CompanyMVC\CompanyMVC\Views\User\Index.cshtml"
                               Write(item.LName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 44 "C:\Users\Super Magic\OneDrive\سطح المكتب\C# Course\Asp Web\Aliaa-MVC\CompanyMVC\CompanyMVC\Views\User\Index.cshtml"
                   Write(item.Email);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 45 "C:\Users\Super Magic\OneDrive\سطح المكتب\C# Course\Asp Web\Aliaa-MVC\CompanyMVC\CompanyMVC\Views\User\Index.cshtml"
                   Write(item.PhoneNumber);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 46 "C:\Users\Super Magic\OneDrive\سطح المكتب\C# Course\Asp Web\Aliaa-MVC\CompanyMVC\CompanyMVC\Views\User\Index.cshtml"
                   Write(string.Join(",", item.Roles));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>");
                WriteLiteral("\r\n                    <td>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3b580c03812b0b0ef6901c7db001939b25833c02bc514854c8c4c342ae562cd111711", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 47 "C:\Users\Super Magic\OneDrive\سطح المكتب\C# Course\Asp Web\Aliaa-MVC\CompanyMVC\CompanyMVC\Views\User\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = item.Id;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</td>\r\n             </tr>   \r\n");
#nullable restore
#line 49 "C:\Users\Super Magic\OneDrive\سطح المكتب\C# Course\Asp Web\Aliaa-MVC\CompanyMVC\CompanyMVC\Views\User\Index.cshtml"
        }          

#line default
#line hidden
#nullable disable
                WriteLiteral("        </tbody>\r\n    </table>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 53 "C:\Users\Super Magic\OneDrive\سطح المكتب\C# Course\Asp Web\Aliaa-MVC\CompanyMVC\CompanyMVC\Views\User\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        <h1>There is No Users </h1>\r\n    </div>\r\n");
#nullable restore
#line 59 "C:\Users\Super Magic\OneDrive\سطح المكتب\C# Course\Asp Web\Aliaa-MVC\CompanyMVC\CompanyMVC\Views\User\Index.cshtml"
    
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<UserViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
