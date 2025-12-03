using Autodesk.AutoCAD.Windows;
using Microsoft.Web.WebView2.WinForms;
using System.Drawing;
using System.Windows.Forms;

namespace CAD_AI_PLUGIN
{
    public static class ChatGPTPalette
    {
        private static PaletteSet _palette;
        private static WebView2 _web;

        public static void ShowPalette()
        {
            if (_palette == null)
            {
                _palette = new PaletteSet("ASSIST AI-cr");
                _palette.Size = new Size(480, 720);

                _web = new WebView2
                {
                    Dock = DockStyle.Fill
                };

                _palette.Add("Chat", _web);

                _web.CoreWebView2InitializationCompleted += (s, e) =>
                {
                    if (e.IsSuccess)
                    {
                        _web.CoreWebView2.Navigate("https://chat.openai.com/");
                    }
                };

                _web.EnsureCoreWebView2Async();
            }

            _palette.Visible = true;
        }
    }
}
