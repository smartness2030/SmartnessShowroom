using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


    /// <summary>
    /// Controls the steps in the in coaching card.
    /// </summary>
    public class ArticleReaderController : MonoBehaviour
    {
        [Serializable]
        class Step
        {
            [SerializeField]
            public GameObject stepObject;

        }

        [SerializeField]
        List<Step> m_PageList = new List<Step>();

        int m_CurrentStepIndex = 0;

        public void Next()
        {
            m_PageList[m_CurrentStepIndex].stepObject.SetActive(false);
            m_CurrentStepIndex = (m_CurrentStepIndex + 1) % m_PageList.Count;
            m_PageList[m_CurrentStepIndex].stepObject.SetActive(true);
        }
        public void Prev()
        {
            if(m_CurrentStepIndex == 0)
        {
            m_PageList[m_CurrentStepIndex].stepObject.SetActive(false);
            m_CurrentStepIndex = m_PageList.Count - 1;
            m_PageList[m_CurrentStepIndex].stepObject.SetActive(true);
        }
        else
        {
            m_PageList[m_CurrentStepIndex].stepObject.SetActive(false);
            m_CurrentStepIndex = (m_CurrentStepIndex - 1) % m_PageList.Count;
            m_PageList[m_CurrentStepIndex].stepObject.SetActive(true);
        }
            
        }

}
