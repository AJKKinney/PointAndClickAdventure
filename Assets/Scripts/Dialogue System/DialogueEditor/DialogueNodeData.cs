using System;
using UnityEngine;

namespace DialogueSystem
{
    [Serializable]
    public class DialogueNodeData
    {
        public string guid;
        public string dialogueText;
        public Vector2 Position;
        public DialogueNode.NodeType nodeType = DialogueNode.NodeType.Dialogue;
    }
}
