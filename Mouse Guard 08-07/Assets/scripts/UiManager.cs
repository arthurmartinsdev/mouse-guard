using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public GameObject UIContainer;
    public Image _image;
    public Text _talkerName;
    public TMP_Text _dialogue;

    void Awake()
    {
        DialogueManager.NewTalker += NewTalker;
        DialogueManager.ShowMessage += ShowText;
        DialogueManager.ResetText += ResetText;
        DialogueManager.UIState += UIContainerState;
    }

    void OnDestroy()
    {
        DialogueManager.NewTalker -= NewTalker;
        DialogueManager.ShowMessage -= ShowText;
        DialogueManager.ResetText -= ResetText;
        DialogueManager.UIState -= UIContainerState;
    }

    private void NewTalker(Dialogue talkerInformations)
    {
        _image.sprite = talkerInformations._talker._sprite;
        _talkerName.text = talkerInformations._talker.name;
        _image.GetComponent<Animator>().SetTrigger("animation");
    }

    private void ShowText(string message) => 
        _dialogue.text = message;

    private void ResetText() =>
        _dialogue.text = string.Empty;
    
    private void UIContainerState(bool state) =>
        UIContainer.SetActive(state);
}
