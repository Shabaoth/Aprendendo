#pragma checksum "C:\Users\gstvo\source\repos\Aprendendo\TodoList\Views\Todo\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "98da45f52f9688a527ff45a88cf349ea9b3831ab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Todo_Index), @"mvc.1.0.view", @"/Views/Todo/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Todo/Index.cshtml", typeof(AspNetCore.Views_Todo_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\gstvo\source\repos\Aprendendo\TodoList\Views\_ViewImports.cshtml"
using TodoList;

#line default
#line hidden
#line 2 "C:\Users\gstvo\source\repos\Aprendendo\TodoList\Views\_ViewImports.cshtml"
using TodoList.Models;

#line default
#line hidden
#line 2 "C:\Users\gstvo\source\repos\Aprendendo\TodoList\Views\Todo\Index.cshtml"
using Humanizer;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98da45f52f9688a527ff45a88cf349ea9b3831ab", @"/Views/Todo/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11405023e71b4984b21d108cf68c11a8d007b906", @"/Views/_ViewImports.cshtml")]
    public class Views_Todo_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TodoViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MarkDone", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(40, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\gstvo\source\repos\Aprendendo\TodoList\Views\Todo\Index.cshtml"
  
    ViewData["Title"] = "Gerencie sua lista de afazeres";

#line default
#line hidden
            BeginContext(108, 76, true);
            WriteLiteral("\r\n<div class=\"panel panel-default todo-panel\">\r\n\t<div class=\"panel-heading\">");
            EndContext();
            BeginContext(185, 18, false);
#line 9 "C:\Users\gstvo\source\repos\Aprendendo\TodoList\Views\Todo\Index.cshtml"
                          Write(ViewData["T�tulo"]);

#line default
#line hidden
            EndContext();
            BeginContext(203, 154, true);
            WriteLiteral("</div>\r\n\r\n\t<table class=\"table table-hover\">\r\n\t\t<thead>\r\n\t\t\t<tr>\r\n\t\t\t\t<td>&#x2714;</td>\r\n\t\t\t\t<td>Tarefa</td>\r\n\t\t\t\t<td>Prazo</td>\r\n\t\t\t</tr>\r\n\t\t</thead>\r\n\r\n");
            EndContext();
#line 20 "C:\Users\gstvo\source\repos\Aprendendo\TodoList\Views\Todo\Index.cshtml"
         foreach (var item in Model.Items)
      {

#line default
#line hidden
            BeginContext(404, 18, true);
            WriteLiteral("\t<tr>\r\n\t\t<td>\r\n\t\t\t");
            EndContext();
            BeginContext(422, 159, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cc38c80b4502497fb35812342a03116a", async() => {
                BeginContext(464, 87, true);
                WriteLiteral("\r\n\t\t\t\t<input type=\"checkbox\" class=\"done-checkbox\">\r\n\t\t\t\t<input type=\"hidden\" name=\"id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 551, "\"", 567, 1);
#line 26 "C:\Users\gstvo\source\repos\Aprendendo\TodoList\Views\Todo\Index.cshtml"
WriteAttributeValue("", 559, item.Id, 559, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(568, 6, true);
                WriteLiteral(">\r\n\t\t\t");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(581, 19, true);
            WriteLiteral("\r\n\t\t</td>\r\n\r\n\t\t<td>");
            EndContext();
            BeginContext(601, 11, false);
#line 30 "C:\Users\gstvo\source\repos\Aprendendo\TodoList\Views\Todo\Index.cshtml"
       Write(item.Titulo);

#line default
#line hidden
            EndContext();
            BeginContext(612, 13, true);
            WriteLiteral("</td>\r\n\t\t<td>");
            EndContext();
            BeginContext(626, 21, false);
#line 31 "C:\Users\gstvo\source\repos\Aprendendo\TodoList\Views\Todo\Index.cshtml"
       Write(item.Prazo.Humanize());

#line default
#line hidden
            EndContext();
            BeginContext(647, 19, true);
            WriteLiteral("</td>\r\n\t\t\r\n\t</tr>\r\n");
            EndContext();
#line 34 "C:\Users\gstvo\source\repos\Aprendendo\TodoList\Views\Todo\Index.cshtml"
      }

#line default
#line hidden
            BeginContext(675, 90, true);
            WriteLiteral("\t</table>\r\n\r\n\t<div class=\"panel-footer add-item-form\">\r\n\t\t<!-- TODO: Add item form -->\r\n\t\t");
            EndContext();
            BeginContext(766, 57, false);
#line 39 "C:\Users\gstvo\source\repos\Aprendendo\TodoList\Views\Todo\Index.cshtml"
   Write(await Html.PartialAsync("AddItemPartial", new TodoItem()));

#line default
#line hidden
            EndContext();
            BeginContext(823, 17, true);
            WriteLiteral("\r\n\t</div>\r\n</div>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TodoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
