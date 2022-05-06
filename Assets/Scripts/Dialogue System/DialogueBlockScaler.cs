using UnityEngine;

namespace DialogueSystem
{

    //attach to a dialogue block to scale the height accordingly
    public class DialogueBlockScaler : MonoBehaviour
    {
        private RectTransform rectTransform;
        private RectTransform speakerTransform;
        private RectTransform dialogueTransform;

        private void Awake()
        {
            rectTransform = GetComponent<RectTransform>();
            speakerTransform = transform.GetChild(0).GetComponent<RectTransform>();
            dialogueTransform = transform.GetChild(1).GetComponent<RectTransform>();
        }

        // Update is called once per frame
        void Update()
        {
            ScaleDialogue();
        }

        private void ScaleDialogue()
        {
            float height = dialogueTransform.sizeDelta.y;

            if (speakerTransform.gameObject.activeSelf == true)
            {
                height += speakerTransform.sizeDelta.y;
                dialogueTransform.anchoredPosition = new Vector2(dialogueTransform.anchoredPosition.x, speakerTransform.anchoredPosition.y * 2);
            }
            else
            {
                dialogueTransform.anchoredPosition = new Vector2(dialogueTransform.anchoredPosition.x, -10);
            }

            rectTransform.sizeDelta = new Vector2(rectTransform.sizeDelta.x, height);
        }
    }
}
