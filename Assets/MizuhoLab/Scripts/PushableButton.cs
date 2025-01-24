using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PushableButton : MonoBehaviour
{
    [System.Serializable]
    public class ButtonPressedEvent : UnityEvent { }
    public ButtonPressedEvent OnButtonPressed;

    // ������ĂȂ���Ԃ̍���
    private float unpushedY = 0.0f;
    // �������Ɣ��肷�鍂��
    private float pushedThreshold = -0.02f;

    // ������Ă��邩
    [SerializeField]
    private bool isPushed;

    // Rigidbody
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // �����ł�������Ă����牟���Ԃ�
        if (transform.localPosition.y < unpushedY)
        {
            rb.AddForce(transform.up);
            transform.localPosition = new Vector3(0f, transform.localPosition.y, 0f);// x, z
        }
        // �����ʒu�ɖ߂��Ă�����A�������茳�̈ʒu�ɖ߂�
        else
        {
            //buttonTop.transform.localPosition = new Vector3(buttonTop.transform.localPosition.x, unpushedY, buttonTop.transform.localPosition.z);
            transform.localPosition = new Vector3(0f, unpushedY, 0f);
        }

        // 臒l�܂ŉ������܂ꂽ��A�������܂ꂽ�ۂ̏���������
        if (!isPushed && transform.localPosition.y < pushedThreshold)
        {
            isPushed = true;
            // �������ݎ��̏���
            OnButtonPressed.Invoke();

        }
        // �������܂ꂽ���ƁA臒l�����ɖ߂��Ă�����
        if (isPushed && transform.localPosition.y > pushedThreshold)
        {
            isPushed = false;
            //audioSource.Play();
        }
    }

}
