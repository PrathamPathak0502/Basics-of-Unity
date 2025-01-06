using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    public GameObject _mainMenu, _helpMenu, _gameplayMenu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnButtonClick(GameObject _uiObject)
    {
        if(_uiObject.name == "Start")
        {
            _mainMenu.SetActive(false);
            _gameplayMenu.SetActive(true);

        }
        if(_uiObject.name == "Help")
        {
            _helpMenu.SetActive(true);    
            _mainMenu.SetActive(false);
        }
        if( _uiObject.name == "Back")
        {
            _helpMenu.SetActive(false);
            _mainMenu.SetActive(true);
        }
        if (_uiObject.name == "Exit")
        
            Application.Quit();
        
        if (_uiObject.name == "Replay") 
        Application.LoadLevel(0);
    }
}
