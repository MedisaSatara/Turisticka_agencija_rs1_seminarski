#pragma checksum "C:\Users\medis\Desktop\konacna_verzija_rs1\Seminarski_Turisticka_Agencija_Rs1\Seminarski_Turisticka_Agencija_Rs1\Views\Ponuda\Prikaz.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66601fba8eeaa785f36aafe741f5e88da06a4f7a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ponuda_Prikaz), @"mvc.1.0.view", @"/Views/Ponuda/Prikaz.cshtml")]
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
#nullable restore
#line 1 "C:\Users\medis\Desktop\konacna_verzija_rs1\Seminarski_Turisticka_Agencija_Rs1\Seminarski_Turisticka_Agencija_Rs1\Views\_ViewImports.cshtml"
using Seminarski_Turisticka_Agencija_Rs1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\medis\Desktop\konacna_verzija_rs1\Seminarski_Turisticka_Agencija_Rs1\Seminarski_Turisticka_Agencija_Rs1\Views\_ViewImports.cshtml"
using Seminarski_Turisticka_Agencija_Rs1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66601fba8eeaa785f36aafe741f5e88da06a4f7a", @"/Views/Ponuda/Prikaz.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6994151c0fe008ac422a089836b70f8b035c847d", @"/Views/_ViewImports.cshtml")]
    public class Views_Ponuda_Prikaz : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Seminarski_Turisticka_Agencija_Rs1.Models.PonudaIndexVM>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "66601fba8eeaa785f36aafe741f5e88da06a4f7a3347", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 8 "C:\Users\medis\Desktop\konacna_verzija_rs1\Seminarski_Turisticka_Agencija_Rs1\Seminarski_Turisticka_Agencija_Rs1\Views\Ponuda\Prikaz.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.OrganizatorId);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 8 "C:\Users\medis\Desktop\konacna_verzija_rs1\Seminarski_Turisticka_Agencija_Rs1\Seminarski_Turisticka_Agencija_Rs1\Views\Ponuda\Prikaz.cshtml"
                          WriteLiteral(Model.OrganizatorId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("hidden", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<table class=\"table table-bordered\">\r\n    <thead>\r\n        <tr>\r\n            <th>Naziv ponude</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 17 "C:\Users\medis\Desktop\konacna_verzija_rs1\Seminarski_Turisticka_Agencija_Rs1\Seminarski_Turisticka_Agencija_Rs1\Views\Ponuda\Prikaz.cshtml"
         foreach (var x in Model.rows)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n\r\n                <td>");
#nullable restore
#line 21 "C:\Users\medis\Desktop\konacna_verzija_rs1\Seminarski_Turisticka_Agencija_Rs1\Seminarski_Turisticka_Agencija_Rs1\Views\Ponuda\Prikaz.cshtml"
               Write(x.NazivPonude);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <button class=\"w3-button w3-dark-grey\" onclick=\"location.href=\'https://localhost:44373/Ponuda/Index\'\">Prikazi sve</button>\r\n");
#nullable restore
#line 24 "C:\Users\medis\Desktop\konacna_verzija_rs1\Seminarski_Turisticka_Agencija_Rs1\Seminarski_Turisticka_Agencija_Rs1\Views\Ponuda\Prikaz.cshtml"


        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Seminarski_Turisticka_Agencija_Rs1.Models.PonudaIndexVM> Html { get; private set; }
    }
}
#pragma warning restore 1591