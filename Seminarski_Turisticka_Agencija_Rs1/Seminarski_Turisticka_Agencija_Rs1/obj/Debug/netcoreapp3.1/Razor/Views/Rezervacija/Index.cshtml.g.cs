#pragma checksum "C:\Users\medis\Desktop\konacna_verzija_rs1\Seminarski_Turisticka_Agencija_Rs1\Seminarski_Turisticka_Agencija_Rs1\Views\Rezervacija\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "850db9d989bdc52f082766b67a0cc13aa68337d4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Rezervacija_Index), @"mvc.1.0.view", @"/Views/Rezervacija/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"850db9d989bdc52f082766b67a0cc13aa68337d4", @"/Views/Rezervacija/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6994151c0fe008ac422a089836b70f8b035c847d", @"/Views/_ViewImports.cshtml")]
    public class Views_Rezervacija_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Seminarski_Turisticka_Agencija_Rs1.Models.RezervacijaIndexVM>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "850db9d989bdc52f082766b67a0cc13aa68337d43372", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 8 "C:\Users\medis\Desktop\konacna_verzija_rs1\Seminarski_Turisticka_Agencija_Rs1\Seminarski_Turisticka_Agencija_Rs1\Views\Rezervacija\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.KorisnikId);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 8 "C:\Users\medis\Desktop\konacna_verzija_rs1\Seminarski_Turisticka_Agencija_Rs1\Seminarski_Turisticka_Agencija_Rs1\Views\Rezervacija\Index.cshtml"
                       WriteLiteral(Model.KorisnikId);

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
            WriteLiteral(@"

<h1>Podaci o korisnicima turisticke agencije:</h1>
<table class=""table table-bordered"">
    <thead>
        <tr>
            <th>Ime</th>
            <th>Prezime</th>
            <th>Broj odraslih osoba</th>
            <th>Broj djece</th>
            <th>Datum polaska</th>
            <th>Datum povratka</th>
            <th>Poruka</th>
            <th>Ponuda</th>
            <th>Akcija</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 26 "C:\Users\medis\Desktop\konacna_verzija_rs1\Seminarski_Turisticka_Agencija_Rs1\Seminarski_Turisticka_Agencija_Rs1\Views\Rezervacija\Index.cshtml"
         foreach (var x in Model.rows)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 29 "C:\Users\medis\Desktop\konacna_verzija_rs1\Seminarski_Turisticka_Agencija_Rs1\Seminarski_Turisticka_Agencija_Rs1\Views\Rezervacija\Index.cshtml"
               Write(x.Ime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 30 "C:\Users\medis\Desktop\konacna_verzija_rs1\Seminarski_Turisticka_Agencija_Rs1\Seminarski_Turisticka_Agencija_Rs1\Views\Rezervacija\Index.cshtml"
               Write(x.Prezime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 31 "C:\Users\medis\Desktop\konacna_verzija_rs1\Seminarski_Turisticka_Agencija_Rs1\Seminarski_Turisticka_Agencija_Rs1\Views\Rezervacija\Index.cshtml"
               Write(x.BrojOdraslihOsoba);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 32 "C:\Users\medis\Desktop\konacna_verzija_rs1\Seminarski_Turisticka_Agencija_Rs1\Seminarski_Turisticka_Agencija_Rs1\Views\Rezervacija\Index.cshtml"
               Write(x.BrojDjece);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 33 "C:\Users\medis\Desktop\konacna_verzija_rs1\Seminarski_Turisticka_Agencija_Rs1\Seminarski_Turisticka_Agencija_Rs1\Views\Rezervacija\Index.cshtml"
               Write(x.OD);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 34 "C:\Users\medis\Desktop\konacna_verzija_rs1\Seminarski_Turisticka_Agencija_Rs1\Seminarski_Turisticka_Agencija_Rs1\Views\Rezervacija\Index.cshtml"
               Write(x.DO);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 35 "C:\Users\medis\Desktop\konacna_verzija_rs1\Seminarski_Turisticka_Agencija_Rs1\Seminarski_Turisticka_Agencija_Rs1\Views\Rezervacija\Index.cshtml"
               Write(x.Poruka);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 36 "C:\Users\medis\Desktop\konacna_verzija_rs1\Seminarski_Turisticka_Agencija_Rs1\Seminarski_Turisticka_Agencija_Rs1\Views\Rezervacija\Index.cshtml"
               Write(x.Ponuda);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 40 "C:\Users\medis\Desktop\konacna_verzija_rs1\Seminarski_Turisticka_Agencija_Rs1\Seminarski_Turisticka_Agencija_Rs1\Views\Rezervacija\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Seminarski_Turisticka_Agencija_Rs1.Models.RezervacijaIndexVM> Html { get; private set; }
    }
}
#pragma warning restore 1591