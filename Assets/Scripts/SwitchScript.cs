using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwitchScript : MonoBehaviour
{
    [SerializeField] private GameObject _calcScreen;
    [SerializeField] private GameObject _compareScreen;

    private GameObject _currentScreen;

    // Start is called before the first frame update
    void Start()
    {
        _calcScreen.SetActive(true);
        _currentScreen = _calcScreen;
    }

    public void OnCalcClick()
    {
        if (_currentScreen != null)
        {
            if (_currentScreen != _calcScreen)
            {
                _currentScreen.SetActive(false);
                _calcScreen.SetActive(true);
                _currentScreen = _calcScreen;
            }
        }
    }

    public void OnCompareClick()
    {
        if (_currentScreen != null)
        {
            if (_currentScreen != _compareScreen)
            {
                _currentScreen.SetActive(false);
                _compareScreen.SetActive(true);
                _currentScreen = _compareScreen;
            }
        }
    }

}
