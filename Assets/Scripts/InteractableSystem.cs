using UnityEngine;
using Valve.VR.InteractionSystem;

namespace KID
{
    /// <summary>
    /// ���ʨt��
    /// </summary>
    public class InteractableSystem : MonoBehaviour
    {
        private Interactable interactable;

        private void Awake()
        {
            interactable = GetComponent<Interactable>();
        }

        private void Update()
        {
            SaveToInventory();
        }

        /// <summary>
        /// �N�����x�s�ܹD����
        /// </summary>
        private void SaveToInventory()
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                if (interactable.attachedToHand == null) return;

                interactable.attachedToHand.DetachObject(gameObject);
            }
        }
    }
}
