using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CalculatorScript : MonoBehaviour
{

    [SerializeField] private Text _resultTextField;

    [SerializeField] private InputField _firstNumberInput;
    [SerializeField] private InputField _secondNumberInput;

    [SerializeField] private Button _plusButton;
    [SerializeField] private Button _minusButton;
    [SerializeField] private Button _multButton;
    [SerializeField] private Button _divButton;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }    

    public void OnInputInField()
    {
        if (int.TryParse(_firstNumberInput.text, out int firstValue) && int.TryParse(_secondNumberInput.text, out int secondValue)) 
        {
            _plusButton.interactable = true;
            _minusButton.interactable = true;
            _multButton.interactable = true;
            _divButton.interactable = true;
        }
        else
        {
            _plusButton.interactable = false;
            _minusButton.interactable = false;
            _multButton.interactable = false;
            _divButton.interactable = false;
        }
    }

    public void OnPlusClick()
    {
        int result;

        if (int.TryParse(_firstNumberInput.text, out int firstValue) && int.TryParse(_secondNumberInput.text, out int secondValue))
        {
            result = firstValue + secondValue;
            _resultTextField.text = "= " + result.ToString();
        }
    }

    public void OnMinusClick()
    {
        int result;

        if (int.TryParse(_firstNumberInput.text, out int firstValue) && int.TryParse(_secondNumberInput.text, out int secondValue))
        {
            result = firstValue - secondValue;
            _resultTextField.text = "= " + result.ToString();
        }
    }

    public void OnMultClick()
    {
        int result;

        if (int.TryParse(_firstNumberInput.text, out int firstValue) && int.TryParse(_secondNumberInput.text, out int secondValue))
        {
            result = firstValue * secondValue;
            _resultTextField.text = "= " + result.ToString();
        }
    }

    public void OnDivClick()
    {
        float result;

        if (int.TryParse(_firstNumberInput.text, out int firstValue) && int.TryParse(_secondNumberInput.text, out int secondValue))
        {
            result = (float)firstValue / (float)secondValue;
            _resultTextField.text = "= " + result.ToString();
        }
    }

}
