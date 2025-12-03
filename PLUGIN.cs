using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.ApplicationServices.Core;

namespace CAD_AI_PLUGIN
{
    public class Plugin
    {
        [CommandMethod("HELLOAI")]
        public static void HelloAI()
        {
            var doc = Application.DocumentManager.MdiActiveDocument;
            var ed = doc.Editor;

            ed.WriteMessage("\n🧚‍♀️ Hello Carla, your AI plugin is ALIVE in AutoCAD!");
        }
    }
}



