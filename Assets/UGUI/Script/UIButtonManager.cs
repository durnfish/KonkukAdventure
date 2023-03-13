using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIButtonManager : MonoBehaviour
{
    [SerializeField] private GameObject _selectArea, _recordArea;
    [SerializeField] private GameObject _closeUi;
    private bool _isSelect, _isRecord;

    private void Awake()
    {
        _isSelect = true;
        _isRecord = false;
    }

    public void SelectButton()
    {
        _isSelect = true;
        _isRecord = false;

        _selectArea.SetActive(true);
        _recordArea.SetActive(false);
    }

    public void RecordButton()
    {
        _isSelect = false;
        _isRecord = true;

        _selectArea.SetActive(false);
        _recordArea.SetActive(true);
    }

    public void CloseStudySelect()
    {
        _closeUi.SetActive(false);
    }
}
