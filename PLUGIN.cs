using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.EditorInput;

namespace CAD_AI_PLUGIN
{
    public class Plugin
    {
        [CommandMethod("HELLOAI")]
        public static void HelloAI()
        {
            Document doc = Autodesk.AutoCAD.ApplicationServices.Application.DocumentManager.MdiActiveDocument;
            Editor ed = doc.Editor;
            ed.WriteMessage("\n🧚‍♀️ Hello Carla, your AI plugin is ALIVE in AutoCAD!");
        }
    }
}
