using UnityEngine;
using UnityEngine.UI;

public class ComputeNumbers : MonoBehaviour
{
    public Text result;
    public InputField ipfVarA;
    public InputField ipfVarB;
    public Button btnSubNumbers;
    public Button btnReset;

    void Start()
    {
        btnReset.interactable = false;
    }

    public void ResetOnClick()
    {
        ipfVarA.interactable = true;
        ipfVarB.interactable = true;
        btnSubNumbers.interactable = true;
        btnReset.interactable = false;

        result.text = "Result";
        ipfVarA.text = "0";
        ipfVarB.text = "0";
    }

    public void SubNumbersOnClick()
    {
        int variableA = int.Parse(ipfVarA.text);
        int variableB = int.Parse(ipfVarB.text);
        int subResult = variableA - variableB;
        result.text = subResult.ToString();

        ipfVarA.interactable = false;
        ipfVarB.interactable = false;
        btnSubNumbers.interactable = false;
        btnReset.interactable = true;
    }
}
