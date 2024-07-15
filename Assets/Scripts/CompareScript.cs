using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CompareScript : MonoBehaviour
{

    [SerializeField] private Text _resultTextField;

    [SerializeField] private InputField _firstNumberInput;
    [SerializeField] private InputField _secondNumberInput;

    [SerializeField] private Button _compareButton;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnInputInField()
    {
        if (int.TryParse(_firstNumberInput.text, out int firstValue) && int.TryParse(_secondNumberInput.text, out int secondValue))
        {
            _compareButton.interactable = true;            
        }
        else
        {
            _compareButton.interactable = false;           
        }
    }

    public void OnCompareClick()
    {
        
        if (int.TryParse(_firstNumberInput.text, out int firstValue) && int.TryParse(_secondNumberInput.text, out int secondValue))
        {
            if (firstValue > secondValue)
            {
                _resultTextField.text = "первое число больше";
            }
            else if (firstValue < secondValue)
            {
                _resultTextField.text = "второе число больше";
            }
            else
            {
                _resultTextField.text = "числа равны";
            }
            
        }
    }


}
