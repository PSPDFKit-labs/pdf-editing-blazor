using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using PdfSharp.Drawing;
using PdfSharp.Fonts;
using PdfSharp.Snippets.Font;
using PdfSharp;

public class PdfEditor
{
    static PdfEditor()
    {
        if (Capabilities.Build.IsCoreBuild)
            GlobalFontSettings.FontResolver = new FailsafeFontResolver();
    }
    public void EditPdf(string filePath)
    {

        PdfDocument document = PdfReader.Open(filePath, PdfDocumentOpenMode.Modify);
        PdfPage page = document.Pages[0];
        XGraphics gfx = XGraphics.FromPdfPage(page);

        XFont font = new XFont("Verdana", 20, XFontStyleEx.Bold);
        gfx.DrawString("Added this with PDFsharp", font, XBrushes.Black, new XRect(0, 0, page.Width, page.Height), XStringFormats.TopLeft);

        document.Save(filePath);
    }
}