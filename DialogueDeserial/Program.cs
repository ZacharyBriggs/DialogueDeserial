using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DialogueDeserial
{
    public class DialogueTree
    {
        public List<DialogueRoot> DialogueRoots;
    }

    public class DialogueRoot
    {
        public List<DialogueNode> DialogueNodes;
    }

    public class DialogueNode
    {
        public string ConversationID;
        public string ParticipantName;
        public string EmoteType;
        public string Side;
        public string Line;
        public string SpecialtyAnimation;
        public string SpecialtyCamera;
        public string Participants;
        public string ConversationSummery;

    }
    static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
