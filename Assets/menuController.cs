using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;
using System.Xml.Linq;



public class menuController : MonoBehaviour
{
    private UIDocument document;
    private Button button;
    // Start is called before the first frame update
    private void Awake()
    {
        document = GetComponent<UIDocument>();
        button = document.rootVisualElement.Q<Button>("btnJgr");
        button.RegisterCallback<ClickEvent>(OnPlayGameClick);
    }
    private void OnDisable()
    {
        button.UnregisterCallback<ClickEvent>(OnPlayGameClick);
    }
    // Update is called once per frame
    private void OnPlayGameClick(ClickEvent evt)
    {
        SceneManager.LoadScene("Game");
    }
}
