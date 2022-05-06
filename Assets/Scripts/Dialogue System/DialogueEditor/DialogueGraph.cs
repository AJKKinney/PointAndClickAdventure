using UnityEngine;
using UnityEditor;
using UnityEngine.UIElements;
using UnityEditor.UIElements;
using UnityEditor.Experimental.GraphView;

namespace DialogueSystem
{
    
    //This Class Controls the Dialogue Graph Editor Window
    public class DialogueGraph : EditorWindow
    {
        private string fileName = "New Narrative";
        private DialogueGraphView graphView;


        //Opens the Dialogue Editor Window
        [MenuItem("Dialgoue/Dialogue Graph")]
        public static void OpenDialogueGraphWindow()
        {
            var window = GetWindow<DialogueGraph>();
            window.titleContent = new GUIContent("Dialogue Graph");
        }


        //constructs new UI Display
        private void ConstructGraph()
        {
            graphView = new DialogueGraphView
            {
                name = "Dialogue Graph"
            };

            graphView.StretchToParentSize();
            rootVisualElement.Add(graphView);
        }


        //Creates Dialogue Editor Window Toolbar
        private void GenerateToolbar()
        {
            var toolbar = new Toolbar();

            var fileNameTextField = new TextField("File Name:");
            fileNameTextField.SetValueWithoutNotify("New Narrative");
            fileNameTextField.MarkDirtyRepaint();
            fileNameTextField.RegisterValueChangedCallback(evt => fileName = evt.newValue);
            toolbar.Add(fileNameTextField);

            toolbar.Add(new Button(() => RequestDataOperation(true)) { text = "Save Data" });
            toolbar.Add(new Button(() => RequestDataOperation(false)) { text = "Load Data" });

            var dialogueNodeCreateButton = new Button(() => { graphView.CreateNode("Dialogue Node"); });
            dialogueNodeCreateButton.text = "Create Dialogue Node";
            toolbar.Add(dialogueNodeCreateButton);

            var choiceNodeCreateButton = new Button(() => { graphView.CreateNode("Choice Node", DialogueNode.NodeType.Choice); });
            choiceNodeCreateButton.text = "Create Choice Node";
            toolbar.Add(choiceNodeCreateButton);

            var exitNodeCreateButton = new Button(() => { graphView.CreateNode("Exit Node", DialogueNode.NodeType.Exit); });
            exitNodeCreateButton.text = "Create Exit Node";
            toolbar.Add(exitNodeCreateButton);

            rootVisualElement.Add(toolbar);
        }


        private void RequestDataOperation(bool save)
        {
            if(string.IsNullOrEmpty(fileName))
            {
                EditorUtility.DisplayDialog("Invalid file name!", "Please enter a valid file name.", "OK");
                return;
            }

            var saveUtility = GraphSaveUtility.GetInstance(graphView);

            //for saving
            if(save)
            {
                saveUtility.SaveGraph(fileName);
            }
            //for loading
            else
            {
                saveUtility.LoadGraph(fileName);
            }
        }


        private void GenerateMinimap()
        {
            var minimap = new MiniMap { anchored = true };
            minimap.SetPosition(new Rect(10, 30, 200, 200));
            graphView.Add(minimap);
        }


        private void OnEnable()
        {
            ConstructGraph();
            GenerateToolbar();
            GenerateMinimap();
        }


        private void OnDisable()
        {
            //Remove Graph
            rootVisualElement.Remove(graphView);
        }
    }
}
